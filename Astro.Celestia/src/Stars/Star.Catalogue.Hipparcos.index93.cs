using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_93() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70857"},
        {"Hipparcos Number", "HIP 41310"},
        {"Smithsonian Astrophysical Observation", "SAO 60801"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.42432022),
        dec: Angle.Degrees(+36.50351592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216997"},
        {"Hipparcos Number", "HIP 113322"},
        {"Smithsonian Astrophysical Observation", "SAO 72871"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.25516946),
        dec: Angle.Degrees(+36.50555023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10501"},
        {"Smithsonian Astrophysical Observation", "SAO 55392"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.84046198),
        dec: Angle.Degrees(+36.50607146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150998"},
        {"Hipparcos Number", "HIP 81848"},
        {"Geneva Identification System", "GEN# +1.00150998"},
        {"Smithsonian Astrophysical Observation", "SAO 65508"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.76759754),
        dec: Angle.Degrees(+36.50962247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129046"},
        {"Hipparcos Number", "HIP 71657"},
        {"Geneva Identification System", "GEN# +1.00129046"},
        {"Smithsonian Astrophysical Observation", "SAO 64258"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.85278260),
        dec: Angle.Degrees(+36.51053902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86776"},
        {"Hipparcos Number", "HIP 49122"},
        {"Geneva Identification System", "GEN# +1.00086776"},
        {"Smithsonian Astrophysical Observation", "SAO 61814"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.38712179),
        dec: Angle.Degrees(+36.51102736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146789"},
        {"Hipparcos Number", "HIP 79759"},
        {"Smithsonian Astrophysical Observation", "SAO 65194"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18662422),
        dec: Angle.Degrees(+36.51102774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278329"},
        {"Hipparcos Number", "HIP 14775"},
        {"Smithsonian Astrophysical Observation", "SAO 56220"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.68155012),
        dec: Angle.Degrees(+36.51304646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8346"},
        {"Hipparcos Number", "HIP 6480"},
        {"Smithsonian Astrophysical Observation", "SAO 54648"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.82529370),
        dec: Angle.Degrees(+36.51467328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28549",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4592 A"},
        {"Henry Draper", "HD 40598"},
        {"Hipparcos Number", "HIP 28549"},
        {"Smithsonian Astrophysical Observation", "SAO 58663"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.40508808),
        dec: Angle.Degrees(+36.51552960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56549"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.92464272),
        dec: Angle.Degrees(+36.51741258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166517"},
        {"Hipparcos Number", "HIP 88953"},
        {"Smithsonian Astrophysical Observation", "SAO 66693"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.36179916),
        dec: Angle.Degrees(+36.51886558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92646"},
        {"Hipparcos Number", "HIP 52382"},
        {"Smithsonian Astrophysical Observation", "SAO 62210"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.60569739),
        dec: Angle.Degrees(+36.51941093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158447"},
        {"Hipparcos Number", "HIP 85459"},
        {"Smithsonian Astrophysical Observation", "SAO 66070"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.95666738),
        dec: Angle.Degrees(+36.52011143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28067"},
        {"Hipparcos Number", "HIP 20791"},
        {"Geneva Identification System", "GEN# +1.00028067"},
        {"Smithsonian Astrophysical Observation", "SAO 57239"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.82616635),
        dec: Angle.Degrees(+36.52035441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280904"},
        {"Hipparcos Number", "HIP 25056"},
        {"Smithsonian Astrophysical Observation", "SAO 57939"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.819,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.47719818),
        dec: Angle.Degrees(+36.52193078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40831"},
        {"Hipparcos Number", "HIP 28658"},
        {"Geneva Identification System", "GEN# +1.00040831"},
        {"Smithsonian Astrophysical Observation", "SAO 58691"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.77144659),
        dec: Angle.Degrees(+36.52213833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58492"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.93969474),
        dec: Angle.Degrees(+36.52543017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43296",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43296"},
        {"Cincinnati Publication", "Ci 20 490"},
        {"Wilson Evans Batten Catalogue", "WEB 8343"},
    },
    visualMagnitude: 11.24,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.29940984),
        dec: Angle.Degrees(+36.52561006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -410.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144723"},
        {"Hipparcos Number", "HIP 78854"},
        {"Geneva Identification System", "GEN# +1.00144723"},
        {"Smithsonian Astrophysical Observation", "SAO 65075"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.45336221),
        dec: Angle.Degrees(+36.52821230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95679",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12478 AB"},
        {"Henry Draper", "HD 183363"},
        {"Hipparcos Number", "HIP 95679"},
        {"Geneva Identification System", "GEN# +1.00183363"},
        {"Wilson Evans Batten Catalogue", "WEB 16738"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.91923939),
        dec: Angle.Degrees(+36.52899836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84869"},
        {"Hipparcos Number", "HIP 48173"},
        {"Geneva Identification System", "GEN# +1.00084869"},
        {"Smithsonian Astrophysical Observation", "SAO 61698"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.28760966),
        dec: Angle.Degrees(+36.52996632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86631"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.51712122),
        dec: Angle.Degrees(+36.52997590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31050"},
        {"Smithsonian Astrophysical Observation", "SAO 59162"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.72262823),
        dec: Angle.Degrees(+36.53077378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50746",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50746"},
        {"Smithsonian Astrophysical Observation", "SAO 61998"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.43124087),
        dec: Angle.Degrees(+36.53154436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9764"},
        {"Hipparcos Number", "HIP 7462"},
        {"Geneva Identification System", "GEN# +1.00009764"},
        {"Smithsonian Astrophysical Observation", "SAO 54820"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.03497666),
        dec: Angle.Degrees(+36.53768952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53852"},
        {"Smithsonian Astrophysical Observation", "SAO 62355"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.24732160),
        dec: Angle.Degrees(+36.53891032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -126.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92551",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174959"},
        {"Hipparcos Number", "HIP 92551"},
        {"Celescope Catalog", "CEL 4659"},
        {"Geneva Identification System", "GEN# +1.00174959"},
        {"Renson", "Renson 48974"},
        {"Smithsonian Astrophysical Observation", "SAO 67485"},
        {"Wilson Evans Batten Catalogue", "WEB 16011"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.90217060),
        dec: Angle.Degrees(+36.53909869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10074"},
        {"Hipparcos Number", "HIP 7700"},
        {"Celescope Catalog", "CEL 153"},
        {"Smithsonian Astrophysical Observation", "SAO 54870"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.78223179),
        dec: Angle.Degrees(+36.54339295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198663"},
        {"Hipparcos Number", "HIP 102883"},
        {"Smithsonian Astrophysical Observation", "SAO 70568"},
    },
    visualMagnitude: 8.85,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.66482315),
        dec: Angle.Degrees(+36.54477972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111768"},
    },
    visualMagnitude: 11.28,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.60291906),
        dec: Angle.Degrees(+36.54547211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29363"},
        {"Hipparcos Number", "HIP 21657"},
        {"Smithsonian Astrophysical Observation", "SAO 57358"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.74542028),
        dec: Angle.Degrees(+36.54656445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105693"},
        {"Geneva Identification System", "GEN# +2.70630005"},
        {"New General Catalogue", "NGC 7063 5"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.10053666),
        dec: Angle.Degrees(+36.55031896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1315"},
        {"Hipparcos Number", "HIP 1403"},
        {"Geneva Identification System", "GEN# +1.00001315"},
        {"Smithsonian Astrophysical Observation", "SAO 53785"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.38769154),
        dec: Angle.Degrees(+36.55045493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173169"},
        {"Hipparcos Number", "HIP 91729"},
        {"Celescope Catalog", "CEL 4643"},
        {"Geneva Identification System", "GEN# +1.00173169"},
        {"Smithsonian Astrophysical Observation", "SAO 67274"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.58330241),
        dec: Angle.Degrees(+36.55176777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146639"},
        {"Hipparcos Number", "HIP 79691"},
        {"Fundamental Katalog 5th Edition", "FK5 5434"},
        {"Smithsonian Astrophysical Observation", "SAO 65183"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.96136039),
        dec: Angle.Degrees(+36.55449989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162159"},
        {"Hipparcos Number", "HIP 87114"},
        {"Smithsonian Astrophysical Observation", "SAO 66341"},
        {"Wilson Evans Batten Catalogue", "WEB 14697"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.98621897),
        dec: Angle.Degrees(+36.55516284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91852",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Xihe"},
        {"Henry Draper", "HD 173416"},
        {"Hipparcos Number", "HIP 91852"},
        {"Geneva Identification System", "GEN# +1.00173416"},
        {"Smithsonian Astrophysical Observation", "SAO 67292"},
        {"Wilson Evans Batten Catalogue", "WEB 15809"},
    },
    visualMagnitude: 6.04,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.90039215),
        dec: Angle.Degrees(+36.55646483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69439"},
        {"Geneva Identification System", "GEN# +0.03702505"},
        {"Smithsonian Astrophysical Observation", "SAO 63991"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.24690895),
        dec: Angle.Degrees(+36.55741357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10323"},
        {"Hipparcos Number", "HIP 7903"},
        {"Geneva Identification System", "GEN# +1.00010323"},
        {"Smithsonian Astrophysical Observation", "SAO 54905"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.40541093),
        dec: Angle.Degrees(+36.55946130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61242"},
        {"Smithsonian Astrophysical Observation", "SAO 63058"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.24912184),
        dec: Angle.Degrees(+36.56214366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34546",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5820 A"},
        {"Henry Draper", "HD 54159"},
        {"Hipparcos Number", "HIP 34546"},
        {"Smithsonian Astrophysical Observation", "SAO 59824"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.35716310),
        dec: Angle.Degrees(+36.56329092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17249"},
        {"Hipparcos Number", "HIP 13009"},
        {"Smithsonian Astrophysical Observation", "SAO 55876"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.79709748),
        dec: Angle.Degrees(+36.56351805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159152"},
        {"Hipparcos Number", "HIP 85756"},
        {"Geneva Identification System", "GEN# +1.00159152"},
        {"Smithsonian Astrophysical Observation", "SAO 66108"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.85666936),
        dec: Angle.Degrees(+36.56428274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75616"},
        {"Smithsonian Astrophysical Observation", "SAO 64708"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.75136591),
        dec: Angle.Degrees(+36.56471917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173761"},
        {"Hipparcos Number", "HIP 92020"},
        {"Smithsonian Astrophysical Observation", "SAO 67334"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.34044922),
        dec: Angle.Degrees(+36.56725424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191226"},
        {"Hipparcos Number", "HIP 99124"},
        {"Geneva Identification System", "GEN# +1.10191226"},
        {"Smithsonian Astrophysical Observation", "SAO 69449"},
        {"Wilson Evans Batten Catalogue", "WEB 17636"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.86056713),
        dec: Angle.Degrees(+36.56777121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53228"},
        {"Hipparcos Number", "HIP 34244"},
        {"Geneva Identification System", "GEN# +1.00053228"},
        {"Smithsonian Astrophysical Observation", "SAO 59767"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.49019223),
        dec: Angle.Degrees(+36.57312234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27403"},
        {"Hipparcos Number", "HIP 20300"},
        {"Smithsonian Astrophysical Observation", "SAO 57177"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.24555330),
        dec: Angle.Degrees(+36.57432724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87197"},
        {"Smithsonian Astrophysical Observation", "SAO 66351"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.21452644),
        dec: Angle.Degrees(+36.57709035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116458",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116458"},
        {"Smithsonian Astrophysical Observation", "SAO 73364"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.96444143),
        dec: Angle.Degrees(+36.57804044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3202"},
        {"Hipparcos Number", "HIP 2793"},
        {"Geneva Identification System", "GEN# +1.00003202"},
        {"Smithsonian Astrophysical Observation", "SAO 54006"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.89441376),
        dec: Angle.Degrees(+36.57904826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207446"},
        {"Hipparcos Number", "HIP 107637"},
        {"Smithsonian Astrophysical Observation", "SAO 71716"},
        {"Wilson Evans Batten Catalogue", "WEB 19420"},
    },
    visualMagnitude: 6.25,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.03504788),
        dec: Angle.Degrees(+36.58040284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196589"},
        {"Hipparcos Number", "HIP 101720"},
        {"Geneva Identification System", "GEN# +1.00196589"},
        {"Smithsonian Astrophysical Observation", "SAO 70273"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.28317296),
        dec: Angle.Degrees(+36.58403050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224708"},
        {"Hipparcos Number", "HIP 9"},
        {"Smithsonian Astrophysical Observation", "SAO 73666"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.03534189),
        dec: Angle.Degrees(+36.58593777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56115"},
        {"Smithsonian Astrophysical Observation", "SAO 62581"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.54722474),
        dec: Angle.Degrees(+36.58604860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81039"},
        {"Hipparcos Number", "HIP 46125"},
        {"Fundamental Katalog 5th Edition", "FK5 2748"},
        {"Geneva Identification System", "GEN# +1.00081039"},
        {"Smithsonian Astrophysical Observation", "SAO 61456"},
        {"Wilson Evans Batten Catalogue", "WEB 8734"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.09390392),
        dec: Angle.Degrees(+36.58714415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102998"},
        {"Hipparcos Number", "HIP 57831"},
        {"Smithsonian Astrophysical Observation", "SAO 62734"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.89489917),
        dec: Angle.Degrees(+36.58748531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194840"},
        {"Hipparcos Number", "HIP 100826"},
        {"Celescope Catalog", "CEL 5062"},
        {"Geneva Identification System", "GEN# +1.00194840"},
        {"Smithsonian Astrophysical Observation", "SAO 70031"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.65965349),
        dec: Angle.Degrees(+36.58788696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189864"},
        {"Hipparcos Number", "HIP 98510"},
        {"Celescope Catalog", "CEL 4908"},
        {"Geneva Identification System", "GEN# +1.00189864"},
        {"Smithsonian Astrophysical Observation", "SAO 69252"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18669490),
        dec: Angle.Degrees(+36.58973455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3544"},
        {"Hipparcos Number", "HIP 3046"},
        {"Smithsonian Astrophysical Observation", "SAO 54051"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.67976781),
        dec: Angle.Degrees(+36.59379964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130968"},
        {"Hipparcos Number", "HIP 72538"},
        {"Smithsonian Astrophysical Observation", "SAO 64350"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.46155803),
        dec: Angle.Degrees(+36.59420845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83208"},
        {"Hipparcos Number", "HIP 47244"},
        {"Smithsonian Astrophysical Observation", "SAO 61604"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.45088570),
        dec: Angle.Degrees(+36.59424743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67061"},
        {"Geneva Identification System", "GEN# +0.03702449"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.13302001),
        dec: Angle.Degrees(+36.59474680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61576",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61576"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.26814363),
        dec: Angle.Degrees(+36.59489925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91364"},
        {"Hipparcos Number", "HIP 51687"},
        {"Smithsonian Astrophysical Observation", "SAO 62120"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.38230637),
        dec: Angle.Degrees(+36.59953569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115255"},
        {"Hipparcos Number", "HIP 64691"},
        {"Smithsonian Astrophysical Observation", "SAO 63432"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.88365144),
        dec: Angle.Degrees(+36.59969319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78862",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78862"},
        {"Smithsonian Astrophysical Observation", "SAO 65077"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.47207698),
        dec: Angle.Degrees(+36.59991635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52935"},
        {"Hipparcos Number", "HIP 34141"},
        {"Geneva Identification System", "GEN# +1.00052935"},
        {"Smithsonian Astrophysical Observation", "SAO 59745"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.18876874),
        dec: Angle.Degrees(+36.60029980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45195"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.15384715),
        dec: Angle.Degrees(+36.60042469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203029"},
        {"Hipparcos Number", "HIP 105213"},
        {"Celescope Catalog", "CEL 5291"},
        {"Geneva Identification System", "GEN# +1.00203029"},
        {"Smithsonian Astrophysical Observation", "SAO 71191"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68112190),
        dec: Angle.Degrees(+36.60225848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4181"},
        {"Hipparcos Number", "HIP 3498"},
        {"Smithsonian Astrophysical Observation", "SAO 54119"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.16260423),
        dec: Angle.Degrees(+36.60253452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12007"},
        {"Hipparcos Number", "HIP 9239"},
        {"Smithsonian Astrophysical Observation", "SAO 55161"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.69350017),
        dec: Angle.Degrees(+36.60281122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30950",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5106 AB"},
        {"Henry Draper", "HD 45540"},
        {"Hipparcos Number", "HIP 30950"},
        {"Smithsonian Astrophysical Observation", "SAO 59144"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.44362218),
        dec: Angle.Degrees(+36.60323301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192538"},
        {"Hipparcos Number", "HIP 99719"},
        {"Celescope Catalog", "CEL 4982"},
        {"Geneva Identification System", "GEN# +1.00192538"},
        {"Smithsonian Astrophysical Observation", "SAO 69653"},
        {"Wilson Evans Batten Catalogue", "WEB 17892"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.52030039),
        dec: Angle.Degrees(+36.60489439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61858"},
        {"Hipparcos Number", "HIP 37589"},
        {"Smithsonian Astrophysical Observation", "SAO 60292"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.70041710),
        dec: Angle.Degrees(+36.60689278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84235"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.27520375),
        dec: Angle.Degrees(+36.60703564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71897",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71897"},
        {"Smithsonian Astrophysical Observation", "SAO 64285"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.58506942),
        dec: Angle.Degrees(+36.61258685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138525"},
        {"Hipparcos Number", "HIP 76006"},
        {"Geneva Identification System", "GEN# +1.00138525"},
        {"Smithsonian Astrophysical Observation", "SAO 64754"},
        {"Wilson Evans Batten Catalogue", "WEB 12920"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.84295934),
        dec: Angle.Degrees(+36.61666057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63701"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.81837616),
        dec: Angle.Degrees(+36.61687206)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19308"},
        {"Hipparcos Number", "HIP 14532"},
        {"Cincinnati Publication", "Ci 18 405"},
        {"Geneva Identification System", "GEN# +1.00019308"},
        {"Smithsonian Astrophysical Observation", "SAO 56178"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91345143),
        dec: Angle.Degrees(+36.61815129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68317",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68317"},
        {"Smithsonian Astrophysical Observation", "SAO 63866"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.77980992),
        dec: Angle.Degrees(+36.62550657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128198"},
        {"Hipparcos Number", "HIP 71277"},
        {"Geneva Identification System", "GEN# +1.00128198"},
        {"Smithsonian Astrophysical Observation", "SAO 64227"},
        {"Wilson Evans Batten Catalogue", "WEB 12314"},
    },
    visualMagnitude: 6.02,
    bvColour: 1.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.66049120),
        dec: Angle.Degrees(+36.62617707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31817"},
        {"Hipparcos Number", "HIP 23282"},
        {"Smithsonian Astrophysical Observation", "SAO 57564"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.13874623),
        dec: Angle.Degrees(+36.62740311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 400"},
        {"Hipparcos Number", "HIP 699"},
        {"Geneva Identification System", "GEN# +1.00000400"},
        {"Smithsonian Astrophysical Observation", "SAO 53677"},
        {"Wilson Evans Batten Catalogue", "WEB 119"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.17092314),
        dec: Angle.Degrees(+36.62742794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8996"},
        {"Hipparcos Number", "HIP 6925"},
        {"Smithsonian Astrophysical Observation", "SAO 54733"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.30348277),
        dec: Angle.Degrees(+36.62781090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1333",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 220 AB"},
        {"Henry Draper", "HD 1223"},
        {"Hipparcos Number", "HIP 1333"},
        {"Geneva Identification System", "GEN# +1.00001223J"},
        {"Smithsonian Astrophysical Observation", "SAO 53772"},
        {"Wilson Evans Batten Catalogue", "WEB 236"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.17935512),
        dec: Angle.Degrees(+36.62987437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82572",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82572"},
        {"Smithsonian Astrophysical Observation", "SAO 65622"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.18448937),
        dec: Angle.Degrees(+36.65533768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1080 AB"},
        {"Henry Draper", "HD 8009"},
        {"Hipparcos Number", "HIP 6240"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.707,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.01855515),
        dec: Angle.Degrees(+36.63126864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144208"},
        {"Henry Draper 2", "HD 144209"},
        {"Hipparcos Number", "HIP 78649"},
        {"Geneva Identification System", "GEN# +1.00144208"},
        {"Smithsonian Astrophysical Observation", "SAO 65049"},
        {"Wilson Evans Batten Catalogue", "WEB 13295"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.83066182),
        dec: Angle.Degrees(+36.63181986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34333"},
        {"Hipparcos Number", "HIP 24744"},
        {"Celescope Catalog", "CEL 594"},
        {"Geneva Identification System", "GEN# +1.00034333"},
        {"Smithsonian Astrophysical Observation", "SAO 57857"},
        {"Wilson Evans Batten Catalogue", "WEB 4786"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.58777940),
        dec: Angle.Degrees(+36.63204993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34626"},
        {"Hipparcos Number", "HIP 24938"},
        {"Celescope Catalog", "CEL 618"},
        {"Geneva Identification System", "GEN# +1.00034626"},
        {"Smithsonian Astrophysical Observation", "SAO 57915"},
        {"Wilson Evans Batten Catalogue", "WEB 4829"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.13765120),
        dec: Angle.Degrees(+36.63224012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185205"},
        {"Hipparcos Number", "HIP 96446"},
        {"Smithsonian Astrophysical Observation", "SAO 68577"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.12741692),
        dec: Angle.Degrees(+36.63243800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120600"},
        {"Hipparcos Number", "HIP 67483"},
        {"Geneva Identification System", "GEN# +1.00120600"},
        {"Smithsonian Astrophysical Observation", "SAO 63772"},
        {"Wilson Evans Batten Catalogue", "WEB 11869"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.43743518),
        dec: Angle.Degrees(+36.63276425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40039"},
        {"Smithsonian Astrophysical Observation", "SAO 60620"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.68489284),
        dec: Angle.Degrees(+36.63307553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202240"},
        {"Hipparcos Number", "HIP 104765"},
        {"Geneva Identification System", "GEN# +1.00202240"},
        {"Smithsonian Astrophysical Observation", "SAO 71086"},
        {"Wilson Evans Batten Catalogue", "WEB 19055"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.36010480),
        dec: Angle.Degrees(+36.63326173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76669",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9737 AB"},
        {"Aitken 2", "ADS 9737 A"},
        {"Henry Draper", "HD 139892"},
        {"Henry Draper 2", "HD 139891J"},
        {"Hipparcos Number", "HIP 76669"},
        {"Geneva Identification System", "GEN# +1.00139892J"},
        {"Smithsonian Astrophysical Observation", "SAO 64834"},
        {"Wilson Evans Batten Catalogue", "WEB 13017"},
    },
    visualMagnitude: 4.64,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.84451583),
        dec: Angle.Degrees(+36.63582763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79467"},
        {"Smithsonian Astrophysical Observation", "SAO 65150"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.25621831),
        dec: Angle.Degrees(+36.63667406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21579"},
        {"Hipparcos Number", "HIP 16302"},
        {"Geneva Identification System", "GEN# +1.00021579"},
        {"Smithsonian Astrophysical Observation", "SAO 56498"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.54505493),
        dec: Angle.Degrees(+36.63836101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30794"},
        {"Hipparcos Number", "HIP 22647"},
        {"Geneva Identification System", "GEN# +1.00030794"},
        {"Smithsonian Astrophysical Observation", "SAO 57469"},
        {"Wilson Evans Batten Catalogue", "WEB 4379"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.08473616),
        dec: Angle.Degrees(+36.64206505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63058"},
        {"Hipparcos Number", "HIP 38098"},
        {"Geneva Identification System", "GEN# +1.00063058"},
        {"Smithsonian Astrophysical Observation", "SAO 60349"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.11435681),
        dec: Angle.Degrees(+36.64349648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143435"},
        {"Hipparcos Number", "HIP 78276"},
        {"Geneva Identification System", "GEN# +1.00143435"},
        {"Smithsonian Astrophysical Observation", "SAO 65001"},
        {"Wilson Evans Batten Catalogue", "WEB 13237"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.74039750),
        dec: Angle.Degrees(+36.64370627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94233"},
        {"Hipparcos Number", "HIP 53216"},
        {"Smithsonian Astrophysical Observation", "SAO 62296"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.26606608),
        dec: Angle.Degrees(+36.65368731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201857"},
        {"Hipparcos Number", "HIP 104588"},
        {"Geneva Identification System", "GEN# +1.00201857"},
        {"Smithsonian Astrophysical Observation", "SAO 71035"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.79901973),
        dec: Angle.Degrees(+36.65508286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47238"},
        {"Hipparcos Number", "HIP 31835"},
        {"Geneva Identification System", "GEN# +1.00047238"},
        {"Smithsonian Astrophysical Observation", "SAO 59332"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.83489426),
        dec: Angle.Degrees(+36.65542370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5897"},
        {"Hipparcos Number", "HIP 4742"},
        {"Smithsonian Astrophysical Observation", "SAO 54346"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.22402460),
        dec: Angle.Degrees(+36.65648079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27334"},
        {"Smithsonian Astrophysical Observation", "SAO 58432"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.84947403),
        dec: Angle.Degrees(+36.65660704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212334"},
        {"Hipparcos Number", "HIP 110487"},
        {"Fundamental Katalog 5th Edition", "FK5 3787"},
        {"Geneva Identification System", "GEN# +1.00212334"},
        {"Smithsonian Astrophysical Observation", "SAO 72284"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.70949358),
        dec: Angle.Degrees(+36.65891683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192641"},
        {"Hipparcos Number", "HIP 99769"},
        {"Celescope Catalog", "CEL 4986"},
        {"Geneva Identification System", "GEN# +1.00192641"},
        {"Smithsonian Astrophysical Observation", "SAO 69677"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.63237188),
        dec: Angle.Degrees(+36.66101334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63004"},
        {"Geneva Identification System", "GEN# +0.03702335"},
        {"Smithsonian Astrophysical Observation", "SAO 63246"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.65310482),
        dec: Angle.Degrees(+36.66125322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69745"},
        {"Smithsonian Astrophysical Observation", "SAO 64042"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.12430052),
        dec: Angle.Degrees(+36.66546624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27886"},
        {"Hipparcos Number", "HIP 20664"},
        {"Smithsonian Astrophysical Observation", "SAO 57224"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.41037780),
        dec: Angle.Degrees(+36.66556131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113660"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.28882727),
        dec: Angle.Degrees(+36.66731314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105811",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14969 A"},
        {"Henry Draper", "HD 204172"},
        {"Hipparcos Number", "HIP 105811"},
        {"Geneva Identification System", "GEN# +1.00204172A"},
        {"Smithsonian Astrophysical Observation", "SAO 71329"},
        {"Wilson Evans Batten Catalogue", "WEB 19196"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.44591740),
        dec: Angle.Degrees(+36.66740768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227535"},
        {"Hipparcos Number", "HIP 98914"},
        {"Geneva Identification System", "GEN# +1.00227535"},
        {"Smithsonian Astrophysical Observation", "SAO 69373"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.27765431),
        dec: Angle.Degrees(+36.66995801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167740"},
        {"Hipparcos Number", "HIP 89419"},
        {"Geneva Identification System", "GEN# +1.00167740"},
        {"Smithsonian Astrophysical Observation", "SAO 66794"},
        {"Wilson Evans Batten Catalogue", "WEB 15208"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.73280957),
        dec: Angle.Degrees(+36.67036155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38126"},
        {"Geneva Identification System", "GEN# +0.03701776"},
    },
    visualMagnitude: 10.02,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.19484352),
        dec: Angle.Degrees(+36.67161332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191456"},
        {"Hipparcos Number", "HIP 99231"},
        {"Celescope Catalog", "CEL 4945"},
        {"Geneva Identification System", "GEN# +1.00191456"},
        {"Smithsonian Astrophysical Observation", "SAO 69491"},
        {"Wilson Evans Batten Catalogue", "WEB 17679"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.15000629),
        dec: Angle.Degrees(+36.67203616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88425"},
        {"Hipparcos Number", "HIP 50007"},
        {"Smithsonian Astrophysical Observation", "SAO 61925"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.13711154),
        dec: Angle.Degrees(+36.67442939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34576"},
        {"Hipparcos Number", "HIP 24898"},
        {"Celescope Catalog", "CEL 614"},
        {"Geneva Identification System", "GEN# +1.00034576"},
        {"Smithsonian Astrophysical Observation", "SAO 57911"},
        {"Wilson Evans Batten Catalogue", "WEB 4822"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.04754813),
        dec: Angle.Degrees(+36.67463657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56628"},
        {"Hipparcos Number", "HIP 35477"},
        {"Geneva Identification System", "GEN# +1.00056628"},
        {"Smithsonian Astrophysical Observation", "SAO 59979"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.84364704),
        dec: Angle.Degrees(+36.67558976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116057"},
        {"Hipparcos Number", "HIP 65114"},
        {"Geneva Identification System", "GEN# +1.00116057"},
        {"Smithsonian Astrophysical Observation", "SAO 63487"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.16120567),
        dec: Angle.Degrees(+36.67577620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174622"},
        {"Hipparcos Number", "HIP 92395"},
        {"Geneva Identification System", "GEN# +1.00174622"},
        {"Smithsonian Astrophysical Observation", "SAO 67445"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.43184804),
        dec: Angle.Degrees(+36.67622242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170326"},
        {"Hipparcos Number", "HIP 90434"},
        {"Smithsonian Astrophysical Observation", "SAO 66992"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.78285697),
        dec: Angle.Degrees(+36.67707809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95485"},
        {"Hipparcos Number", "HIP 53903"},
        {"Geneva Identification System", "GEN# +1.00095485"},
        {"Smithsonian Astrophysical Observation", "SAO 62360"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.44060003),
        dec: Angle.Degrees(+36.67811033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82719"},
        {"Smithsonian Astrophysical Observation", "SAO 65644"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61874756),
        dec: Angle.Degrees(+36.68004892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132275"},
        {"Hipparcos Number", "HIP 73158"},
        {"Smithsonian Astrophysical Observation", "SAO 64419"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.27303115),
        dec: Angle.Degrees(+36.68211406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70969"},
        {"Hipparcos Number", "HIP 41359"},
        {"Smithsonian Astrophysical Observation", "SAO 60807"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.57066212),
        dec: Angle.Degrees(+36.68276719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73723"},
        {"Smithsonian Astrophysical Observation", "SAO 64489"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.05616912),
        dec: Angle.Degrees(+36.68290179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6930"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.32364239),
        dec: Angle.Degrees(+36.68377108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278784"},
        {"Hipparcos Number", "HIP 16576"},
        {"Geneva Identification System", "GEN# +1.00278784"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.34610792),
        dec: Angle.Degrees(+36.68474352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151501"},
        {"Hipparcos Number", "HIP 82100"},
        {"Geneva Identification System", "GEN# +1.00151501"},
        {"Smithsonian Astrophysical Observation", "SAO 65545"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.56004122),
        dec: Angle.Degrees(+36.68908713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157293"},
        {"Hipparcos Number", "HIP 84878"},
        {"Smithsonian Astrophysical Observation", "SAO 65966"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.19509426),
        dec: Angle.Degrees(+36.69125030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64627"},
        {"Hipparcos Number", "HIP 38774"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.05421713),
        dec: Angle.Degrees(+36.69148794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37182",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6227 A"},
        {"Hipparcos Number", "HIP 37182"},
        {"Cincinnati Publication", "Ci 20 431"},
        {"Geneva Identification System", "GEN# +0.03701748"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.59562641),
        dec: Angle.Degrees(+36.69496098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -874.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37748"},
        {"Smithsonian Astrophysical Observation", "SAO 60309"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.13461781),
        dec: Angle.Degrees(+36.69573398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7728"},
        {"Smithsonian Astrophysical Observation", "SAO 54878"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.87584371),
        dec: Angle.Degrees(+36.69660018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228155"},
        {"Hipparcos Number", "HIP 99441"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.75491988),
        dec: Angle.Degrees(+36.70059295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200371"},
        {"Hipparcos Number", "HIP 103799"},
        {"Smithsonian Astrophysical Observation", "SAO 70809"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.49351728),
        dec: Angle.Degrees(+36.70099364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30834"},
        {"Hipparcos Number", "HIP 22678"},
        {"Geneva Identification System", "GEN# +1.00030834"},
        {"Smithsonian Astrophysical Observation", "SAO 57475"},
        {"Wilson Evans Batten Catalogue", "WEB 4384"},
    },
    visualMagnitude: 4.79,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.15833005),
        dec: Angle.Degrees(+36.70319636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216191"},
        {"Hipparcos Number", "HIP 112768"},
        {"Smithsonian Astrophysical Observation", "SAO 72767"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.55922393),
        dec: Angle.Degrees(+36.70427968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96019",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12561 C"},
        {"Henry Draper", "HD 184106"},
        {"Hipparcos Number", "HIP 96019"},
        {"Smithsonian Astrophysical Observation", "SAO 68434"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.84244520),
        dec: Angle.Degrees(+36.70485150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9914"},
        {"Hipparcos Number", "HIP 7569"},
        {"Geneva Identification System", "GEN# +1.00009914"},
        {"Smithsonian Astrophysical Observation", "SAO 54845"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.37817121),
        dec: Angle.Degrees(+36.70688367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7780 AB"},
        {"Henry Draper", "HD 90537"},
        {"Hipparcos Number", "HIP 51233"},
        {"Fundamental Katalog 5th Edition", "FK5 390"},
        {"Geneva Identification System", "GEN# +1.00090537J"},
        {"Smithsonian Astrophysical Observation", "SAO 62053"},
        {"Wilson Evans Batten Catalogue", "WEB 9363"},
    },
    visualMagnitude: 4.20,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.97121865),
        dec: Angle.Degrees(+36.70747818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12561 A"},
        {"Hipparcos Number", "HIP 96025"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.85917714),
        dec: Angle.Degrees(+36.71049964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197735"},
        {"Hipparcos Number", "HIP 102356"},
        {"Smithsonian Astrophysical Observation", "SAO 70444"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.08916788),
        dec: Angle.Degrees(+36.71367055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46131"},
        {"Renson", "Renson 23010"},
    },
    visualMagnitude: 10.19,
    bvColour: -0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.10993715),
        dec: Angle.Degrees(+36.71483276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74152"},
        {"Hipparcos Number", "HIP 42824"},
        {"Smithsonian Astrophysical Observation", "SAO 61012"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.89124858),
        dec: Angle.Degrees(+36.71498619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77767",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77767"},
        {"Smithsonian Astrophysical Observation", "SAO 64963"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.18579546),
        dec: Angle.Degrees(+36.71571094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9500",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1613 AB"},
        {"Henry Draper", "HD 12376"},
        {"Hipparcos Number", "HIP 9500"},
        {"Geneva Identification System", "GEN# +1.00012376"},
        {"Smithsonian Astrophysical Observation", "SAO 55204"},
        {"Wilson Evans Batten Catalogue", "WEB 1994"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.55344226),
        dec: Angle.Degrees(+36.71712273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222451"},
        {"Hipparcos Number", "HIP 116824"},
        {"Fundamental Katalog 5th Edition", "FK5 3899"},
        {"Geneva Identification System", "GEN# +1.00222451"},
        {"Smithsonian Astrophysical Observation", "SAO 73428"},
        {"Wilson Evans Batten Catalogue", "WEB 20612"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.16860835),
        dec: Angle.Degrees(+36.72071051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 234.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46041"},
    },
    visualMagnitude: 11.35,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.84512132),
        dec: Angle.Degrees(+36.73421632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -287.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93497",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93497"},
    },
    visualMagnitude: 11.15,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.61295370),
        dec: Angle.Degrees(+36.72214363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30282"},
        {"Hipparcos Number", "HIP 22275"},
        {"Geneva Identification System", "GEN# +1.00030282"},
        {"Smithsonian Astrophysical Observation", "SAO 57431"},
        {"Wilson Evans Batten Catalogue", "WEB 4293"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.94298222),
        dec: Angle.Degrees(+36.72280366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78028",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78028"},
        {"Smithsonian Astrophysical Observation", "SAO 64976"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.98717966),
        dec: Angle.Degrees(+36.72287311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104675"},
        {"Hipparcos Number", "HIP 58772"},
        {"Geneva Identification System", "GEN# +1.00104675"},
        {"Smithsonian Astrophysical Observation", "SAO 62815"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.81424236),
        dec: Angle.Degrees(+36.72309403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192382"},
        {"Hipparcos Number", "HIP 99628"},
        {"Geneva Identification System", "GEN# +1.00192382"},
        {"Renson", "Renson 53604"},
        {"Smithsonian Astrophysical Observation", "SAO 69625"},
        {"Wilson Evans Batten Catalogue", "WEB 17855"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.29521630),
        dec: Angle.Degrees(+36.72549106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128847"},
        {"Hipparcos Number", "HIP 71576"},
        {"Smithsonian Astrophysical Observation", "SAO 64250"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.57122179),
        dec: Angle.Degrees(+36.72586626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50745"},
        {"Hipparcos Number", "HIP 33348"},
        {"Geneva Identification System", "GEN# +1.00050745"},
        {"Smithsonian Astrophysical Observation", "SAO 59619"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.03613940),
        dec: Angle.Degrees(+36.72635133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24433"},
        {"Hipparcos Number", "HIP 18287"},
        {"Smithsonian Astrophysical Observation", "SAO 56806"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.66436235),
        dec: Angle.Degrees(+36.72753239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104204"},
        {"Hipparcos Number", "HIP 58530"},
        {"Geneva Identification System", "GEN# +1.00104204"},
        {"Renson", "Renson 30130"},
        {"Smithsonian Astrophysical Observation", "SAO 62789"},
        {"Wilson Evans Batten Catalogue", "WEB 10450"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.04130641),
        dec: Angle.Degrees(+36.72980848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112641"},
        {"Hipparcos Number", "HIP 63265"},
        {"Geneva Identification System", "GEN# +1.00112641"},
        {"Smithsonian Astrophysical Observation", "SAO 63268"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.46048040),
        dec: Angle.Degrees(+36.73011708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2211 AB"},
        {"Henry Draper", "HD 18042"},
        {"Hipparcos Number", "HIP 13587"},
        {"Smithsonian Astrophysical Observation", "SAO 55994"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.75616608),
        dec: Angle.Degrees(+36.73061500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12132"},
        {"Hipparcos Number", "HIP 9342"},
        {"Geneva Identification System", "GEN# +1.00012132"},
        {"Smithsonian Astrophysical Observation", "SAO 55173"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.98863722),
        dec: Angle.Degrees(+36.73062752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57968"},
        {"Geneva Identification System", "GEN# +0.03702225"},
        {"Smithsonian Astrophysical Observation", "SAO 62742"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.34799580),
        dec: Angle.Degrees(+36.73241469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58541",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58541"},
        {"Geneva Identification System", "GEN# +0.03702239"},
        {"Smithsonian Astrophysical Observation", "SAO 62792"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.07113085),
        dec: Angle.Degrees(+36.73302039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175538"},
        {"Hipparcos Number", "HIP 92769"},
        {"Geneva Identification System", "GEN# +1.00175538"},
        {"Smithsonian Astrophysical Observation", "SAO 67550"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.55653432),
        dec: Angle.Degrees(+36.73345730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26872"},
        {"Hipparcos Number", "HIP 19915"},
        {"Geneva Identification System", "GEN# +1.00026872"},
        {"Smithsonian Astrophysical Observation", "SAO 57113"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.08250299),
        dec: Angle.Degrees(+36.73414739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96370"},
        {"Hipparcos Number", "HIP 54343"},
        {"Smithsonian Astrophysical Observation", "SAO 62412"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.75689248),
        dec: Angle.Degrees(+36.73659162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106292"},
        {"Hipparcos Number", "HIP 59632"},
        {"Geneva Identification System", "GEN# +1.00106292"},
        {"Smithsonian Astrophysical Observation", "SAO 62902"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.43972548),
        dec: Angle.Degrees(+36.73698233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64187"},
        {"Hipparcos Number", "HIP 38595"},
        {"Geneva Identification System", "GEN# +1.00064187"},
        {"Smithsonian Astrophysical Observation", "SAO 60422"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.54653188),
        dec: Angle.Degrees(+36.74156981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57098",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57098"},
        {"Geneva Identification System", "GEN# +0.03702208"},
        {"Smithsonian Astrophysical Observation", "SAO 62663"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.57635972),
        dec: Angle.Degrees(+36.74161342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175741"},
        {"Hipparcos Number", "HIP 92847"},
        {"Geneva Identification System", "GEN# +1.00175741"},
        {"Smithsonian Astrophysical Observation", "SAO 67573"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.78878233),
        dec: Angle.Degrees(+36.74171880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28591"},
        {"Hipparcos Number", "HIP 21144"},
        {"Geneva Identification System", "GEN# +1.00028591"},
        {"Smithsonian Astrophysical Observation", "SAO 57285"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.98726375),
        dec: Angle.Degrees(+36.74285269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78822"},
        {"Hipparcos Number", "HIP 45112"},
        {"Smithsonian Astrophysical Observation", "SAO 61315"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.86584094),
        dec: Angle.Degrees(+36.74323958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200597"},
        {"Hipparcos Number", "HIP 103903"},
        {"Smithsonian Astrophysical Observation", "SAO 70835"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.79823884),
        dec: Angle.Degrees(+36.74413829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160451"},
        {"Hipparcos Number", "HIP 86325"},
        {"Fundamental Katalog 5th Edition", "FK5 5547"},
        {"Geneva Identification System", "GEN# +1.00160451"},
        {"Smithsonian Astrophysical Observation", "SAO 66203"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.57880962),
        dec: Angle.Degrees(+36.74728371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84914"},
        {"Hipparcos Number", "HIP 48192"},
        {"Geneva Identification System", "GEN# +1.00084914"},
        {"Smithsonian Astrophysical Observation", "SAO 61703"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.36843158),
        dec: Angle.Degrees(+36.74742945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102760"},
        {"Hipparcos Number", "HIP 57695"},
        {"Smithsonian Astrophysical Observation", "SAO 62720"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.48568228),
        dec: Angle.Degrees(+36.74823008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116411",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116411"},
        {"Smithsonian Astrophysical Observation", "SAO 73356"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.85069881),
        dec: Angle.Degrees(+36.74834708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9121 AB"},
        {"Henry Draper", "HD 123670"},
        {"Hipparcos Number", "HIP 69062"},
        {"Smithsonian Astrophysical Observation", "SAO 63947"},
    },
    visualMagnitude: 8.22,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.04934704),
        dec: Angle.Degrees(+36.74906712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70502"},
        {"Smithsonian Astrophysical Observation", "SAO 64135"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.33183128),
        dec: Angle.Degrees(+36.75064304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192661"},
        {"Hipparcos Number", "HIP 99777"},
        {"Smithsonian Astrophysical Observation", "SAO 69681"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.66507334),
        dec: Angle.Degrees(+36.75208074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154508"},
        {"Hipparcos Number", "HIP 83528"},
        {"Geneva Identification System", "GEN# +1.00154508"},
        {"Smithsonian Astrophysical Observation", "SAO 65773"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.06431049),
        dec: Angle.Degrees(+36.75302593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76643"},
        {"Smithsonian Astrophysical Observation", "SAO 64827"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.76679796),
        dec: Angle.Degrees(+36.75431232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135078"},
        {"Hipparcos Number", "HIP 74381"},
        {"Geneva Identification System", "GEN# +1.00135078"},
        {"Smithsonian Astrophysical Observation", "SAO 64549"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.99066043),
        dec: Angle.Degrees(+36.75465983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -213.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103500"},
        {"Hipparcos Number", "HIP 58119"},
        {"Geneva Identification System", "GEN# +1.00103500"},
        {"Smithsonian Astrophysical Observation", "SAO 62754"},
        {"Wilson Evans Batten Catalogue", "WEB 10408"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.80875730),
        dec: Angle.Degrees(+36.75648978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129653"},
        {"Hipparcos Number", "HIP 71925"},
        {"Smithsonian Astrophysical Observation", "SAO 64289"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.66474657),
        dec: Angle.Degrees(+36.75678667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31000"},
        {"Hipparcos Number", "HIP 22776"},
        {"Geneva Identification System", "GEN# +1.00031000"},
        {"Smithsonian Astrophysical Observation", "SAO 57487"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.48419462),
        dec: Angle.Degrees(+36.75740514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94456"},
        {"Hipparcos Number", "HIP 53360"},
        {"Geneva Identification System", "GEN# +1.00094456"},
        {"Smithsonian Astrophysical Observation", "SAO 62308"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68672269),
        dec: Angle.Degrees(+36.75888999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35710",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6009 A"},
        {"Henry Draper", "HD 57264"},
        {"Hipparcos Number", "HIP 35710"},
        {"Fundamental Katalog 5th Edition", "FK5 2568"},
        {"Geneva Identification System", "GEN# +1.00057264"},
        {"Smithsonian Astrophysical Observation", "SAO 60010"},
        {"Wilson Evans Batten Catalogue", "WEB 7110"},
    },
    visualMagnitude: 5.12,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.51120175),
        dec: Angle.Degrees(+36.76063782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197309"},
        {"Hipparcos Number", "HIP 102121"},
        {"Smithsonian Astrophysical Observation", "SAO 70385"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.42445174),
        dec: Angle.Degrees(+36.76358824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181656"},
        {"Hipparcos Number", "HIP 94992"},
        {"Geneva Identification System", "GEN# +1.00181656"},
        {"Smithsonian Astrophysical Observation", "SAO 68145"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.94146025),
        dec: Angle.Degrees(+36.76428459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54422"},
    },
    visualMagnitude: 12.17,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.05054342),
        dec: Angle.Degrees(+36.76522620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100404"},
        {"Hipparcos Number", "HIP 56382"},
        {"Geneva Identification System", "GEN# +1.00100404"},
        {"Smithsonian Astrophysical Observation", "SAO 62603"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.37210319),
        dec: Angle.Degrees(+36.76545601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29293",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29293"},
        {"Smithsonian Astrophysical Observation", "SAO 58822"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.63365861),
        dec: Angle.Degrees(+36.76883802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3469",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3469"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08798888),
        dec: Angle.Degrees(+36.76886645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212858"},
        {"Hipparcos Number", "HIP 110788"},
        {"Geneva Identification System", "GEN# +1.00212858"},
        {"Smithsonian Astrophysical Observation", "SAO 72343"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.67992401),
        dec: Angle.Degrees(+36.76964387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 226.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 108.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9126",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1557 A"},
        {"Henry Draper", "HD 11886"},
        {"Hipparcos Number", "HIP 9126"},
        {"Geneva Identification System", "GEN# +1.00011886"},
        {"Smithsonian Astrophysical Observation", "SAO 55137"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.41587006),
        dec: Angle.Degrees(+36.77035033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13857"},
        {"Hipparcos Number", "HIP 10554"},
        {"Geneva Identification System", "GEN# +1.00013857"},
        {"Smithsonian Astrophysical Observation", "SAO 55396"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.97642131),
        dec: Angle.Degrees(+36.77069100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8633"},
        {"Smithsonian Astrophysical Observation", "SAO 55033"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.83719405),
        dec: Angle.Degrees(+36.77480672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62338"},
        {"Smithsonian Astrophysical Observation", "SAO 63188"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.61717945),
        dec: Angle.Degrees(+36.77689844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17164 B"},
        {"Hipparcos Number", "HIP 70"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.20280014),
        dec: Angle.Degrees(+36.77763945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86026"},
        {"Hipparcos Number", "HIP 48765"},
        {"Smithsonian Astrophysical Observation", "SAO 61773"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.19779837),
        dec: Angle.Degrees(+36.77799949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36149"},
        {"Hipparcos Number", "HIP 25875"},
        {"Smithsonian Astrophysical Observation", "SAO 58141"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.85289313),
        dec: Angle.Degrees(+36.77906549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183535"},
        {"Hipparcos Number", "HIP 95760"},
        {"Celescope Catalog", "CEL 4771"},
        {"Geneva Identification System", "GEN# +1.00183535"},
        {"Smithsonian Astrophysical Observation", "SAO 68370"},
        {"Wilson Evans Batten Catalogue", "WEB 16755"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.15900580),
        dec: Angle.Degrees(+36.77919770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17164 A"},
        {"Henry Draper", "HD 224803"},
        {"Hipparcos Number", "HIP 71"},
        {"Geneva Identification System", "GEN# +1.00224803"},
        {"Smithsonian Astrophysical Observation", "SAO 73678"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.20709981),
        dec: Angle.Degrees(+36.78015328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60271"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.37236975),
        dec: Angle.Degrees(+36.78024432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34312",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34312"},
        {"Smithsonian Astrophysical Observation", "SAO 59782"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.70979912),
        dec: Angle.Degrees(+36.78076414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51470"},
        {"Hipparcos Number", "HIP 33631"},
        {"Smithsonian Astrophysical Observation", "SAO 59660"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.79731326),
        dec: Angle.Degrees(+36.78091449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43757"},
        {"Smithsonian Astrophysical Observation", "SAO 61130"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.70129066),
        dec: Angle.Degrees(+36.78245118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7759 AB"},
        {"Henry Draper", "HD 90205"},
        {"Hipparcos Number", "HIP 51030"},
        {"Smithsonian Astrophysical Observation", "SAO 62032"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.38589213),
        dec: Angle.Degrees(+36.78308555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37141"},
        {"Smithsonian Astrophysical Observation", "SAO 60233"},
        {"Wilson Evans Batten Catalogue", "WEB 7362"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.47676356),
        dec: Angle.Degrees(+36.78343146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93992"},
        {"Hipparcos Number", "HIP 53073"},
        {"Geneva Identification System", "GEN# +1.00093992"},
        {"Smithsonian Astrophysical Observation", "SAO 62282"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.87493218),
        dec: Angle.Degrees(+36.78359686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112476"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.73609311),
        dec: Angle.Degrees(+36.78394084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103239"},
        {"Smithsonian Astrophysical Observation", "SAO 70664"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.73235397),
        dec: Angle.Degrees(+36.78426858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1404"},
        {"Hipparcos Number", "HIP 1473"},
        {"Fundamental Katalog 5th Edition", "FK5 1005"},
        {"Geneva Identification System", "GEN# +1.00001404"},
        {"Smithsonian Astrophysical Observation", "SAO 53798"},
        {"Wilson Evans Batten Catalogue", "WEB 268"},
    },
    visualMagnitude: 4.51,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.58210555),
        dec: Angle.Degrees(+36.78532730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55746"},
        {"Hipparcos Number", "HIP 35137"},
        {"Geneva Identification System", "GEN# +1.00055746"},
        {"Smithsonian Astrophysical Observation", "SAO 59922"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.96015678),
        dec: Angle.Degrees(+36.78580952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3626"},
        {"Hipparcos Number", "HIP 3109"},
        {"Geneva Identification System", "GEN# +1.00003626"},
        {"Smithsonian Astrophysical Observation", "SAO 54061"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.89732204),
        dec: Angle.Degrees(+36.79057888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218934"},
        {"Hipparcos Number", "HIP 114514"},
        {"Smithsonian Astrophysical Observation", "SAO 73071"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.91496640),
        dec: Angle.Degrees(+36.79470750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201750"},
        {"Hipparcos Number", "HIP 104541"},
        {"Geneva Identification System", "GEN# +1.00201750"},
        {"Smithsonian Astrophysical Observation", "SAO 71015"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.63689354),
        dec: Angle.Degrees(+36.79609799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52633"},
        {"Hipparcos Number", "HIP 34036"},
        {"Smithsonian Astrophysical Observation", "SAO 59727"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.91045941),
        dec: Angle.Degrees(+36.79611916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204723"},
        {"Hipparcos Number", "HIP 106119"},
        {"Smithsonian Astrophysical Observation", "SAO 71394"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.42306412),
        dec: Angle.Degrees(+36.79850960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19102"},
        {"Hipparcos Number", "HIP 14387"},
        {"Smithsonian Astrophysical Observation", "SAO 56144"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.39779764),
        dec: Angle.Degrees(+36.79878820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213872"},
        {"Hipparcos Number", "HIP 111380"},
        {"Geneva Identification System", "GEN# +1.00213872"},
        {"Smithsonian Astrophysical Observation", "SAO 72468"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.47467203),
        dec: Angle.Degrees(+36.80009478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63571"},
        {"Hipparcos Number", "HIP 38327"},
        {"Smithsonian Astrophysical Observation", "SAO 60378"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77489126),
        dec: Angle.Degrees(+36.80128671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111599"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.13102636),
        dec: Angle.Degrees(+36.80279869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45688",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7292 A"},
        {"Henry Draper", "HD 80081"},
        {"Henry Draper 2", "HD 80081A"},
        {"Hipparcos Number", "HIP 45688"},
        {"Smithsonian Astrophysical Observation", "SAO 61391"},
        {"Wilson Evans Batten Catalogue", "WEB 8674"},
    },
    visualMagnitude: 3.82,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.71111394),
        dec: Angle.Degrees(+36.80289763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104602"},
        {"Hipparcos Number", "HIP 58740"},
        {"Geneva Identification System", "GEN# +1.00104602"},
        {"Smithsonian Astrophysical Observation", "SAO 62814"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.71360459),
        dec: Angle.Degrees(+36.80381820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138383"},
        {"Hipparcos Number", "HIP 75928"},
        {"Smithsonian Astrophysical Observation", "SAO 64741"},
        {"Wilson Evans Batten Catalogue", "WEB 12913"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.61608244),
        dec: Angle.Degrees(+36.80446873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30943"},
        {"Hipparcos Number", "HIP 22744"},
        {"Geneva Identification System", "GEN# +1.00030943"},
        {"Smithsonian Astrophysical Observation", "SAO 57483"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.39483946),
        dec: Angle.Degrees(+36.80588032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192640"},
        {"Hipparcos Number", "HIP 99770"},
        {"Celescope Catalog", "CEL 4988"},
        {"Geneva Identification System", "GEN# +1.00192640"},
        {"Smithsonian Astrophysical Observation", "SAO 69678"},
        {"Wilson Evans Batten Catalogue", "WEB 17918"},
    },
    visualMagnitude: 4.93,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.63326032),
        dec: Angle.Degrees(+36.80613540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105345"},
        {"Fundamental Katalog 5th Edition", "FK5 5881"},
        {"Smithsonian Astrophysical Observation", "SAO 71218"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.06106092),
        dec: Angle.Degrees(+36.80675485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202570"},
        {"Hipparcos Number", "HIP 104955"},
        {"Smithsonian Astrophysical Observation", "SAO 71129"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89510918),
        dec: Angle.Degrees(+36.80713263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2149 AB"},
        {"Henry Draper", "HD 17510"},
        {"Hipparcos Number", "HIP 13180"},
        {"Smithsonian Astrophysical Observation", "SAO 55912"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.39421324),
        dec: Angle.Degrees(+36.80816650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156283"},
        {"Hipparcos Number", "HIP 84380"},
        {"Fundamental Katalog 5th Edition", "FK5 643"},
        {"Geneva Identification System", "GEN# +1.00156283"},
        {"Smithsonian Astrophysical Observation", "SAO 65890"},
        {"Wilson Evans Batten Catalogue", "WEB 14244"},
    },
    visualMagnitude: 3.16,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.76189282),
        dec: Angle.Degrees(+36.80915527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26422"},
        {"Hipparcos Number", "HIP 19622"},
        {"Smithsonian Astrophysical Observation", "SAO 57059"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.06513849),
        dec: Angle.Degrees(+36.81304092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64833",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8847 AB"},
        {"Henry Draper", "HD 115572"},
        {"Hipparcos Number", "HIP 64833"},
        {"Geneva Identification System", "GEN# +1.00115572J"},
        {"Smithsonian Astrophysical Observation", "SAO 63452"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.36327977),
        dec: Angle.Degrees(+36.81508717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100470"},
        {"Hipparcos Number", "HIP 56410"},
        {"Fundamental Katalog 5th Edition", "FK5 2923"},
        {"Geneva Identification System", "GEN# +1.00100470"},
        {"Smithsonian Astrophysical Observation", "SAO 62604"},
        {"Wilson Evans Batten Catalogue", "WEB 10136"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.48489895),
        dec: Angle.Degrees(+36.81573666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190629"},
        {"Hipparcos Number", "HIP 98856"},
        {"Smithsonian Astrophysical Observation", "SAO 69360"},
    },
    visualMagnitude: 8.16,
    bvColour: 2.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.11504365),
        dec: Angle.Degrees(+36.81680574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117846"},
        {"Hipparcos Number", "HIP 66042"},
        {"Geneva Identification System", "GEN# +1.00117846J"},
        {"Smithsonian Astrophysical Observation", "SAO 63593"},
        {"Wilson Evans Batten Catalogue", "WEB 11672"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.09164662),
        dec: Angle.Degrees(+36.81822120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102686"},
        {"Smithsonian Astrophysical Observation", "SAO 70525"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10787323),
        dec: Angle.Degrees(+36.81887383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218259"},
        {"Hipparcos Number", "HIP 114074"},
        {"Geneva Identification System", "GEN# +1.00218259"},
        {"Smithsonian Astrophysical Observation", "SAO 72992"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.55110921),
        dec: Angle.Degrees(+36.82028920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99664",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99664"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.36686794),
        dec: Angle.Degrees(+36.82225488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112055"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.44490777),
        dec: Angle.Degrees(+36.82450674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8536",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8536"},
        {"Smithsonian Astrophysical Observation", "SAO 55009"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.51823785),
        dec: Angle.Degrees(+36.82602393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191158"},
        {"Hipparcos Number", "HIP 99097"},
        {"Geneva Identification System", "GEN# +1.00191158"},
        {"Renson", "Renson 53200"},
        {"Smithsonian Astrophysical Observation", "SAO 69438"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.77578026),
        dec: Angle.Degrees(+36.82667005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52575"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.26205156),
        dec: Angle.Degrees(+36.82775310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9554 AB"},
        {"Henry Draper", "HD 135657"},
        {"Hipparcos Number", "HIP 74643"},
        {"Smithsonian Astrophysical Observation", "SAO 64586"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.76347320),
        dec: Angle.Degrees(+36.83022647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211138"},
        {"Hipparcos Number", "HIP 109797"},
        {"Smithsonian Astrophysical Observation", "SAO 72160"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.58984862),
        dec: Angle.Degrees(+36.83179214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2753",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 486 A"},
        {"Henry Draper", "HD 3165"},
        {"Hipparcos Number", "HIP 2753"},
        {"Geneva Identification System", "GEN# +1.00003165A"},
        {"Smithsonian Astrophysical Observation", "SAO 53999"},
        {"Wilson Evans Batten Catalogue", "WEB 497"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.79013047),
        dec: Angle.Degrees(+36.83227188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4994"},
        {"Geneva Identification System", "GEN# +0.03600187"},
        {"Smithsonian Astrophysical Observation", "SAO 54391"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.00108925),
        dec: Angle.Degrees(+36.83327837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2752",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 486 B"},
        {"Henry Draper", "HD 3165B"},
        {"Hipparcos Number", "HIP 2752"},
        {"Geneva Identification System", "GEN# +1.00003165B"},
        {"Wilson Evans Batten Catalogue", "WEB 496"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.78712762),
        dec: Angle.Degrees(+36.83445910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102941"},
        {"Hipparcos Number", "HIP 57801"},
        {"Geneva Identification System", "GEN# +1.00102941"},
        {"Smithsonian Astrophysical Observation", "SAO 62729"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.77962630),
        dec: Angle.Degrees(+36.83520449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114909",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114909"},
        {"Smithsonian Astrophysical Observation", "SAO 73131"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.12976195),
        dec: Angle.Degrees(+36.83691569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191610"},
        {"Hipparcos Number", "HIP 99303"},
        {"Celescope Catalog", "CEL 4951"},
        {"Fundamental Katalog 5th Edition", "FK5 1525"},
        {"Geneva Identification System", "GEN# +1.00191610"},
        {"Smithsonian Astrophysical Observation", "SAO 69518"},
        {"Wilson Evans Batten Catalogue", "WEB 17709"},
    },
    visualMagnitude: 4.93,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.35673642),
        dec: Angle.Degrees(+36.83959003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83979"},
        {"Smithsonian Astrophysical Observation", "SAO 65841"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.50399884),
        dec: Angle.Degrees(+36.84016910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80258"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77093036),
        dec: Angle.Degrees(+36.84172873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6202"},
        {"Hipparcos Number", "HIP 4950"},
        {"Smithsonian Astrophysical Observation", "SAO 54382"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.87117701),
        dec: Angle.Degrees(+36.84200527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162667"},
        {"Hipparcos Number", "HIP 87319"},
        {"Smithsonian Astrophysical Observation", "SAO 66373"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.63126206),
        dec: Angle.Degrees(+36.84611818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66787"},
        {"Geneva Identification System", "GEN# +0.03702439"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.32030437),
        dec: Angle.Degrees(+36.84657251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127336"},
        {"Hipparcos Number", "HIP 70886"},
        {"Smithsonian Astrophysical Observation", "SAO 64179"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.44316962),
        dec: Angle.Degrees(+36.84785411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114390",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16558 A"},
        {"Henry Draper", "HD 218741"},
        {"Hipparcos Number", "HIP 114390"},
        {"Smithsonian Astrophysical Observation", "SAO 73051"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.51069618),
        dec: Angle.Degrees(+36.84829775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111113"},
        {"Hipparcos Number", "HIP 62357"},
        {"Geneva Identification System", "GEN# +1.00111113"},
        {"Smithsonian Astrophysical Observation", "SAO 63189"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.66502605),
        dec: Angle.Degrees(+36.84847883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29536"},
        {"Hipparcos Number", "HIP 21780"},
        {"Fundamental Katalog 5th Edition", "FK5 4418"},
        {"Geneva Identification System", "GEN# +1.00029536"},
        {"Smithsonian Astrophysical Observation", "SAO 57370"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.18547056),
        dec: Angle.Degrees(+36.85017075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82030"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.34982973),
        dec: Angle.Degrees(+36.85086552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87003"},
        {"Hipparcos Number", "HIP 49241"},
        {"Smithsonian Astrophysical Observation", "SAO 61828"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.77429444),
        dec: Angle.Degrees(+36.85131686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279067"},
        {"Hipparcos Number", "HIP 18156"},
        {"Geneva Identification System", "GEN# +1.00279067"},
        {"Smithsonian Astrophysical Observation", "SAO 56777"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.22418363),
        dec: Angle.Degrees(+36.85514033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92751",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92751"},
        {"Geneva Identification System", "GEN# +0.03603312"},
        {"Smithsonian Astrophysical Observation", "SAO 67546"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.50956631),
        dec: Angle.Degrees(+36.85570834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93094"},
        {"Smithsonian Astrophysical Observation", "SAO 67638"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.47141292),
        dec: Angle.Degrees(+36.85935579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126245"},
        {"Hipparcos Number", "HIP 70334"},
        {"Smithsonian Astrophysical Observation", "SAO 64114"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.85282041),
        dec: Angle.Degrees(+36.85955748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163968"},
        {"Hipparcos Number", "HIP 87882"},
        {"Geneva Identification System", "GEN# +1.00163968"},
        {"Smithsonian Astrophysical Observation", "SAO 66502"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.28572680),
        dec: Angle.Degrees(+36.86023968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 928"},
        {"Hipparcos Number", "HIP 1112"},
        {"Smithsonian Astrophysical Observation", "SAO 53739"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.45930626),
        dec: Angle.Degrees(+36.86028926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114386",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16558 B"},
        {"Henry Draper", "HD 218726"},
        {"Hipparcos Number", "HIP 114386"},
        {"Smithsonian Astrophysical Observation", "SAO 73050"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.49524714),
        dec: Angle.Degrees(+36.86227784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99234"},
        {"Hipparcos Number", "HIP 55762"},
        {"Smithsonian Astrophysical Observation", "SAO 62549"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.38326421),
        dec: Angle.Degrees(+36.86304332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63181"},
        {"Geneva Identification System", "GEN# +0.03702337"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.16324506),
        dec: Angle.Degrees(+36.86589248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75373"},
        {"Geneva Identification System", "GEN# +0.03702635"},
        {"Wilson Evans Batten Catalogue", "WEB 12858"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.02920661),
        dec: Angle.Degrees(+36.86685920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9471"},
        {"Hipparcos Number", "HIP 7268"},
        {"Smithsonian Astrophysical Observation", "SAO 54782"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.40291648),
        dec: Angle.Degrees(+36.86873389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62648"},
        {"Geneva Identification System", "GEN# +0.03702331"},
        {"Smithsonian Astrophysical Observation", "SAO 63218"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.55267029),
        dec: Angle.Degrees(+36.87022122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71221"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.46668014),
        dec: Angle.Degrees(+36.87070959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208583"},
        {"Hipparcos Number", "HIP 108295"},
        {"Geneva Identification System", "GEN# +1.00208583"},
        {"Smithsonian Astrophysical Observation", "SAO 71858"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.09867376),
        dec: Angle.Degrees(+36.87248633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56381"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.36978786),
        dec: Angle.Degrees(+36.87394747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -274.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164213"},
        {"Hipparcos Number", "HIP 87992"},
        {"Smithsonian Astrophysical Observation", "SAO 66525"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.60730659),
        dec: Angle.Degrees(+36.87462906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20526"},
        {"Hipparcos Number", "HIP 15468"},
        {"Fundamental Katalog 5th Edition", "FK5 4305"},
        {"Geneva Identification System", "GEN# +1.00020526"},
        {"Smithsonian Astrophysical Observation", "SAO 56346"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.86394076),
        dec: Angle.Degrees(+36.87630898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23130"},
        {"Hipparcos Number", "HIP 17430"},
        {"Geneva Identification System", "GEN# +1.00023130"},
        {"Smithsonian Astrophysical Observation", "SAO 56670"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.01266786),
        dec: Angle.Degrees(+36.87707144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75331"},
        {"Hipparcos Number", "HIP 43420"},
        {"Smithsonian Astrophysical Observation", "SAO 61075"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.65997140),
        dec: Angle.Degrees(+36.87717416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39193"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.24080529),
        dec: Angle.Degrees(+36.87806060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41888"},
        {"Smithsonian Astrophysical Observation", "SAO 60883"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.12068254),
        dec: Angle.Degrees(+36.87864518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206579"},
        {"Hipparcos Number", "HIP 107132"},
        {"Smithsonian Astrophysical Observation", "SAO 71614"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.51604337),
        dec: Angle.Degrees(+36.88113418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8452"},
        {"Hipparcos Number", "HIP 6568"},
        {"Smithsonian Astrophysical Observation", "SAO 54665"},
        {"Wilson Evans Batten Catalogue", "WEB 1443"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.09830400),
        dec: Angle.Degrees(+36.88352522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66634"},
        {"Hipparcos Number", "HIP 39628"},
        {"Smithsonian Astrophysical Observation", "SAO 60553"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.47663263),
        dec: Angle.Degrees(+36.88437926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93192",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93192"},
        {"Smithsonian Astrophysical Observation", "SAO 67665"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.72736039),
        dec: Angle.Degrees(+36.88445635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39784"},
        {"Hipparcos Number", "HIP 28106"},
        {"Smithsonian Astrophysical Observation", "SAO 58585"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.10411783),
        dec: Angle.Degrees(+36.88679723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12790",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12790"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.09816624),
        dec: Angle.Degrees(+36.88751171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 204.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114975"},
        {"Hipparcos Number", "HIP 64530"},
        {"Geneva Identification System", "GEN# +1.00114975"},
        {"Smithsonian Astrophysical Observation", "SAO 63414"},
        {"Wilson Evans Batten Catalogue", "WEB 11412"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.39975707),
        dec: Angle.Degrees(+36.88758126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106218"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.71276739),
        dec: Angle.Degrees(+36.88926842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 299.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 143.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57788",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8319 AB"},
        {"Hipparcos Number", "HIP 57788"},
        {"Geneva Identification System", "GEN# +0.03702219J"},
        {"Smithsonian Astrophysical Observation", "SAO 62726"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.75278542),
        dec: Angle.Degrees(+36.88927038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77079"},
        {"Hipparcos Number", "HIP 44301"},
        {"Geneva Identification System", "GEN# +1.00077079"},
        {"Smithsonian Astrophysical Observation", "SAO 61201"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.34014193),
        dec: Angle.Degrees(+36.89063638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98185"},
        {"Hipparcos Number", "HIP 55191"},
        {"Smithsonian Astrophysical Observation", "SAO 62481"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.49885080),
        dec: Angle.Degrees(+36.89087178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130253"},
        {"Hipparcos Number", "HIP 72199"},
        {"Geneva Identification System", "GEN# +1.00130253"},
        {"Smithsonian Astrophysical Observation", "SAO 64316"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.50970996),
        dec: Angle.Degrees(+36.89141804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97287"},
        {"Hipparcos Number", "HIP 54726"},
        {"Geneva Identification System", "GEN# +1.00097287"},
        {"Smithsonian Astrophysical Observation", "SAO 62446"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.06183976),
        dec: Angle.Degrees(+36.89270824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114508"},
        {"Smithsonian Astrophysical Observation", "SAO 73069"},
        {"Wilson Evans Batten Catalogue", "WEB 20321"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.88336267),
        dec: Angle.Degrees(+36.89321639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 109.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64725"},
        {"Hipparcos Number", "HIP 38825"},
        {"Smithsonian Astrophysical Observation", "SAO 60467"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.18651127),
        dec: Angle.Degrees(+36.89649044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92791",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11825 A"},
        {"Henry Draper", "HD 175588"},
        {"Hipparcos Number", "HIP 92791"},
        {"Geneva Identification System", "GEN# +1.00175588"},
        {"Smithsonian Astrophysical Observation", "SAO 67559"},
        {"Wilson Evans Batten Catalogue", "WEB 16059"},
    },
    visualMagnitude: 4.22,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62620294),
        dec: Angle.Degrees(+36.89860518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59967"},
    },
    visualMagnitude: 10.27,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.48535197),
        dec: Angle.Degrees(+36.89937568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2507"},
        {"Hipparcos Number", "HIP 2270"},
        {"Geneva Identification System", "GEN# +1.00002507"},
        {"Smithsonian Astrophysical Observation", "SAO 53928"},
        {"Wilson Evans Batten Catalogue", "WEB 422"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.23610470),
        dec: Angle.Degrees(+36.89970105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169306"},
        {"Hipparcos Number", "HIP 90044"},
        {"Geneva Identification System", "GEN# +1.00169306"},
        {"Smithsonian Astrophysical Observation", "SAO 66913"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.60367470),
        dec: Angle.Degrees(+36.90091785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1934"},
        {"Hipparcos Number", "HIP 1882"},
        {"Geneva Identification System", "GEN# +1.00001934"},
        {"Smithsonian Astrophysical Observation", "SAO 53857"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.94094491),
        dec: Angle.Degrees(+36.90122012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115727"},
        {"Smithsonian Astrophysical Observation", "SAO 73256"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.68370693),
        dec: Angle.Degrees(+36.90274983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27548"},
        {"Hipparcos Number", "HIP 20421"},
        {"Smithsonian Astrophysical Observation", "SAO 57189"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.61042162),
        dec: Angle.Degrees(+36.90565550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26275"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.93193632),
        dec: Angle.Degrees(+36.90610193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64411",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8815 AB"},
        {"Henry Draper", "HD 114744"},
        {"Hipparcos Number", "HIP 64411"},
        {"Smithsonian Astrophysical Observation", "SAO 63398"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.02015528),
        dec: Angle.Degrees(+36.90862896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110190"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.80199538),
        dec: Angle.Degrees(+36.90898606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -192.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99810"},
        {"Hipparcos Number", "HIP 56052"},
        {"Geneva Identification System", "GEN# +1.00099810"},
        {"Smithsonian Astrophysical Observation", "SAO 62573"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.31890000),
        dec: Angle.Degrees(+36.91183851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10124 ABC"},
        {"Henry Draper", "HD 149772"},
        {"Hipparcos Number", "HIP 81225"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.85369054),
        dec: Angle.Degrees(+36.91228467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93448"},
        {"Hipparcos Number", "HIP 52812"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.95103882),
        dec: Angle.Degrees(+36.91231703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46761"},
        {"Hipparcos Number", "HIP 31602"},
        {"Smithsonian Astrophysical Observation", "SAO 59289"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.21261828),
        dec: Angle.Degrees(+36.91413129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92764"},
        {"Geneva Identification System", "GEN# +0.03603314"},
        {"Smithsonian Astrophysical Observation", "SAO 67549"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.54882153),
        dec: Angle.Degrees(+36.91439564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33749"},
        {"Hipparcos Number", "HIP 24398"},
        {"Celescope Catalog", "CEL 571"},
        {"Geneva Identification System", "GEN# +1.00033749"},
        {"Smithsonian Astrophysical Observation", "SAO 57770"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.51053360),
        dec: Angle.Degrees(+36.91624725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74243"},
        {"Hipparcos Number", "HIP 42871"},
        {"Geneva Identification System", "GEN# +1.00074243"},
        {"Smithsonian Astrophysical Observation", "SAO 61018"},
        {"Wilson Evans Batten Catalogue", "WEB 8284"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.04230209),
        dec: Angle.Degrees(+36.91853935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193928"},
        {"Hipparcos Number", "HIP 120155"},
        {"Geneva Identification System", "GEN# +1.00193928"},
        {"Wilson Evans Batten Catalogue", "WEB 18118"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.38221191),
        dec: Angle.Degrees(+36.92022827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1617"},
    },
    visualMagnitude: 11.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.05590095),
        dec: Angle.Degrees(+36.92116598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10302 AB"},
        {"Henry Draper", "HD 153778"},
        {"Hipparcos Number", "HIP 83164"},
        {"Smithsonian Astrophysical Observation", "SAO 65711"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.94345280),
        dec: Angle.Degrees(+36.92135296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146959"},
        {"Hipparcos Number", "HIP 79824"},
        {"Smithsonian Astrophysical Observation", "SAO 65205"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.39091271),
        dec: Angle.Degrees(+36.92164006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157879"},
        {"Hipparcos Number", "HIP 85160"},
        {"Smithsonian Astrophysical Observation", "SAO 66008"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.04638540),
        dec: Angle.Degrees(+36.92282209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50773"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.52116633),
        dec: Angle.Degrees(+36.92416933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -258.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204376"},
        {"Hipparcos Number", "HIP 105921"},
        {"Smithsonian Astrophysical Observation", "SAO 71355"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.78609679),
        dec: Angle.Degrees(+36.92565100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112863"},
        {"Smithsonian Astrophysical Observation", "SAO 72783"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.84298619),
        dec: Angle.Degrees(+36.92583369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111814",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111814"},
        {"Smithsonian Astrophysical Observation", "SAO 72566"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.72880942),
        dec: Angle.Degrees(+36.92839919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108211"},
        {"Smithsonian Astrophysical Observation", "SAO 71842"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.83706914),
        dec: Angle.Degrees(+36.93066291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67774",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67774"},
        {"Geneva Identification System", "GEN# +0.03702459"},
        {"Smithsonian Astrophysical Observation", "SAO 63808"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.27146000),
        dec: Angle.Degrees(+36.93100254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91702"},
        {"Hipparcos Number", "HIP 51877"},
        {"Geneva Identification System", "GEN# +1.00091702"},
        {"Smithsonian Astrophysical Observation", "SAO 62143"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.98368100),
        dec: Angle.Degrees(+36.93106241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34508"},
        {"Hipparcos Number", "HIP 24856"},
        {"Smithsonian Astrophysical Observation", "SAO 57899"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.92515553),
        dec: Angle.Degrees(+36.93327999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2064"},
    },
    visualMagnitude: 10.56,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.52934816),
        dec: Angle.Degrees(+36.93431804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 161.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41268"},
        {"Hipparcos Number", "HIP 28872"},
        {"Smithsonian Astrophysical Observation", "SAO 58728"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.43638702),
        dec: Angle.Degrees(+36.93451395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101214",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13949 A"},
        {"Henry Draper", "HD 195593"},
        {"Henry Draper 2", "HD 195593A"},
        {"Hipparcos Number", "HIP 101214"},
        {"Geneva Identification System", "GEN# +1.00195593"},
        {"Smithsonian Astrophysical Observation", "SAO 70135"},
        {"Wilson Evans Batten Catalogue", "WEB 18284"},
    },
    visualMagnitude: 6.21,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.74678964),
        dec: Angle.Degrees(+36.93584939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28043",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4505 AB"},
        {"Aitken 2", "ADS 4505"},
        {"Henry Draper", "HD 39697"},
        {"Hipparcos Number", "HIP 28043"},
        {"Smithsonian Astrophysical Observation", "SAO 58575"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.95936474),
        dec: Angle.Degrees(+36.93670577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10649"},
        {"Hipparcos Number", "HIP 8138"},
        {"Smithsonian Astrophysical Observation", "SAO 54948"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.16115880),
        dec: Angle.Degrees(+36.93842248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50402"},
        {"Hipparcos Number", "HIP 33209"},
        {"Smithsonian Astrophysical Observation", "SAO 59602"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.67264583),
        dec: Angle.Degrees(+36.93947524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178002"},
        {"Hipparcos Number", "HIP 93748"},
        {"Celescope Catalog", "CEL 4698"},
        {"Geneva Identification System", "GEN# +1.00178002"},
        {"Smithsonian Astrophysical Observation", "SAO 67798"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.35345079),
        dec: Angle.Degrees(+36.94084175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42730"},
        {"Smithsonian Astrophysical Observation", "SAO 60996"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.62221334),
        dec: Angle.Degrees(+36.94126561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143468"},
        {"Hipparcos Number", "HIP 78281"},
        {"Smithsonian Astrophysical Observation", "SAO 65002"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.74970154),
        dec: Angle.Degrees(+36.94202179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185037"},
        {"Hipparcos Number", "HIP 96387"},
        {"Celescope Catalog", "CEL 4795"},
        {"Geneva Identification System", "GEN# +1.00185037"},
        {"Smithsonian Astrophysical Observation", "SAO 68552"},
        {"Wilson Evans Batten Catalogue", "WEB 16905"},
    },
    visualMagnitude: 6.03,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.95125591),
        dec: Angle.Degrees(+36.94454320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4133"},
        {"Smithsonian Astrophysical Observation", "SAO 54226"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22649561),
        dec: Angle.Degrees(+36.94479907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189433"},
        {"Hipparcos Number", "HIP 98321"},
        {"Geneva Identification System", "GEN# +1.00189433"},
        {"Smithsonian Astrophysical Observation", "SAO 69191"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.64573695),
        dec: Angle.Degrees(+36.94568114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209343"},
        {"Hipparcos Number", "HIP 108763"},
        {"Smithsonian Astrophysical Observation", "SAO 71961"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.48191064),
        dec: Angle.Degrees(+36.94575279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17605"},
        {"Hipparcos Number", "HIP 13257"},
        {"Geneva Identification System", "GEN# +1.00017605"},
        {"Smithsonian Astrophysical Observation", "SAO 55930"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.64707607),
        dec: Angle.Degrees(+36.94864201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116157"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.03358014),
        dec: Angle.Degrees(+36.94940769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18141"},
        {"Hipparcos Number", "HIP 13666"},
        {"Smithsonian Astrophysical Observation", "SAO 56012"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.98839547),
        dec: Angle.Degrees(+36.94960402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201252"},
        {"Hipparcos Number", "HIP 104242"},
        {"Geneva Identification System", "GEN# +1.00201252"},
        {"Smithsonian Astrophysical Observation", "SAO 70936"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.80108120),
        dec: Angle.Degrees(+36.95015700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85181",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10535 A"},
        {"Henry Draper", "HD 157910"},
        {"Hipparcos Number", "HIP 85181"},
        {"Geneva Identification System", "GEN# +1.00157910A"},
        {"Smithsonian Astrophysical Observation", "SAO 66014"},
        {"Wilson Evans Batten Catalogue", "WEB 14385"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.11305613),
        dec: Angle.Degrees(+36.95182070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29122"},
        {"Hipparcos Number", "HIP 21468"},
        {"Geneva Identification System", "GEN# +1.00029122"},
        {"Smithsonian Astrophysical Observation", "SAO 57337"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.15804811),
        dec: Angle.Degrees(+36.95293026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223848"},
        {"Hipparcos Number", "HIP 117762"},
        {"Geneva Identification System", "GEN# +1.00223848"},
        {"Smithsonian Astrophysical Observation", "SAO 73582"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.23463661),
        dec: Angle.Degrees(+36.95447475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278943"},
        {"Hipparcos Number", "HIP 17629"},
        {"Geneva Identification System", "GEN# +1.00278943"},
        {"Smithsonian Astrophysical Observation", "SAO 56693"},
    },
    visualMagnitude: 10.99,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.66189073),
        dec: Angle.Degrees(+36.95459713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9770"},
    },
    visualMagnitude: 11.81,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.41030968),
        dec: Angle.Degrees(+36.95509303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9772",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9772"},
        {"Smithsonian Astrophysical Observation", "SAO 55256"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.41575812),
        dec: Angle.Degrees(+36.95731785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173291"},
        {"Hipparcos Number", "HIP 91774"},
        {"Fundamental Katalog 5th Edition", "FK5 5644"},
        {"Geneva Identification System", "GEN# +1.00173291"},
        {"Wilson Evans Batten Catalogue", "WEB 15788"},
    },
    visualMagnitude: 7.97,
    bvColour: 3.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.70833677),
        dec: Angle.Degrees(+36.95857863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127986"},
        {"Hipparcos Number", "HIP 71168"},
        {"Geneva Identification System", "GEN# +1.00127986"},
        {"Smithsonian Astrophysical Observation", "SAO 64212"},
        {"Wilson Evans Batten Catalogue", "WEB 12301"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.33444972),
        dec: Angle.Degrees(+36.95920251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23894",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23894"},
        {"Geneva Identification System", "GEN# +2.17780002"},
        {"New General Catalogue", "NGC 1778 2"},
    },
    visualMagnitude: 10.05,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.01616232),
        dec: Angle.Degrees(+36.96019611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47030"},
        {"Smithsonian Astrophysical Observation", "SAO 61579"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.77489857),
        dec: Angle.Degrees(+36.96147067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1537"},
        {"Hipparcos Number", "HIP 1579"},
        {"Smithsonian Astrophysical Observation", "SAO 53812"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.94477964),
        dec: Angle.Degrees(+36.96249753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13404"},
        {"Hipparcos Number", "HIP 10253"},
        {"Geneva Identification System", "GEN# +1.00013404"},
        {"Renson", "Renson 3470"},
        {"Smithsonian Astrophysical Observation", "SAO 55342"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97506000),
        dec: Angle.Degrees(+36.96624519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215212"},
        {"Hipparcos Number", "HIP 112175"},
        {"Geneva Identification System", "GEN# +1.00215212"},
        {"Smithsonian Astrophysical Observation", "SAO 72656"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.77986455),
        dec: Angle.Degrees(+36.96627638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25950"},
        {"Hipparcos Number", "HIP 19291"},
        {"Smithsonian Astrophysical Observation", "SAO 56997"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.02737795),
        dec: Angle.Degrees(+36.96663818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2814"},
        {"Hipparcos Number", "HIP 2509"},
        {"Smithsonian Astrophysical Observation", "SAO 53963"},
        {"Wilson Evans Batten Catalogue", "WEB 459"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.95615138),
        dec: Angle.Degrees(+36.96715075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89271"},
        {"Smithsonian Astrophysical Observation", "SAO 66761"},
    },
    visualMagnitude: 9.83,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.25467250),
        dec: Angle.Degrees(+36.96727283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15126"},
        {"Hipparcos Number", "HIP 11421"},
        {"Smithsonian Astrophysical Observation", "SAO 55568"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.81199034),
        dec: Angle.Degrees(+36.96730973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219028"},
        {"Hipparcos Number", "HIP 114565"},
        {"Smithsonian Astrophysical Observation", "SAO 73086"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.10408739),
        dec: Angle.Degrees(+36.96778175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172006"},
        {"Hipparcos Number", "HIP 91181"},
        {"Smithsonian Astrophysical Observation", "SAO 67153"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.02772537),
        dec: Angle.Degrees(+36.96915977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200389"},
        {"Hipparcos Number", "HIP 103802"},
        {"Smithsonian Astrophysical Observation", "SAO 70810"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.50255439),
        dec: Angle.Degrees(+36.96958160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225147"},
        {"Hipparcos Number", "HIP 311"},
        {"Geneva Identification System", "GEN# +1.00225147"},
        {"Smithsonian Astrophysical Observation", "SAO 53611"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.98758897),
        dec: Angle.Degrees(+36.97021204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175426"},
        {"Hipparcos Number", "HIP 92728"},
        {"Celescope Catalog", "CEL 4664"},
        {"Fundamental Katalog 5th Edition", "FK5 3506"},
        {"Geneva Identification System", "GEN# +1.00175426"},
        {"Smithsonian Astrophysical Observation", "SAO 67537"},
        {"Wilson Evans Batten Catalogue", "WEB 16045"},
    },
    visualMagnitude: 5.58,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.43149392),
        dec: Angle.Degrees(+36.97172755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83346"},
        {"Smithsonian Astrophysical Observation", "SAO 65744"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.50752904),
        dec: Angle.Degrees(+36.97532796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114108"},
        {"Hipparcos Number", "HIP 64083"},
        {"Geneva Identification System", "GEN# +1.00114108"},
        {"Smithsonian Astrophysical Observation", "SAO 63360"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.98644986),
        dec: Angle.Degrees(+36.97556720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147395"},
        {"Hipparcos Number", "HIP 80042"},
        {"Geneva Identification System", "GEN# +1.00147395"},
        {"Smithsonian Astrophysical Observation", "SAO 65237"},
        {"Wilson Evans Batten Catalogue", "WEB 13553"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.07590813),
        dec: Angle.Degrees(+36.97563905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81685"},
        {"Geneva Identification System", "GEN# +0.03702790"},
        {"Smithsonian Astrophysical Observation", "SAO 65484"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.28955945),
        dec: Angle.Degrees(+36.97614169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191720"},
        {"Hipparcos Number", "HIP 99359"},
        {"Celescope Catalog", "CEL 4954"},
        {"Geneva Identification System", "GEN# +1.00191720"},
        {"Smithsonian Astrophysical Observation", "SAO 69535"},
        {"Wilson Evans Batten Catalogue", "WEB 17732"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.50682778),
        dec: Angle.Degrees(+36.97844877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66500"},
        {"Smithsonian Astrophysical Observation", "SAO 63652"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.47947671),
        dec: Angle.Degrees(+36.97869288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195407"},
        {"Hipparcos Number", "HIP 101118"},
        {"Geneva Identification System", "GEN# +1.00195407"},
        {"Smithsonian Astrophysical Observation", "SAO 70108"},
        {"Wilson Evans Batten Catalogue", "WEB 18263"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.44902827),
        dec: Angle.Degrees(+36.98040443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212121"},
        {"Hipparcos Number", "HIP 110369"},
        {"Smithsonian Astrophysical Observation", "SAO 72258"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.32509802),
        dec: Angle.Degrees(+36.98164637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95550"},
        {"Hipparcos Number", "HIP 53931"},
        {"Geneva Identification System", "GEN# +1.00095550"},
        {"Smithsonian Astrophysical Observation", "SAO 62364"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.53481492),
        dec: Angle.Degrees(+36.98169501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70920"},
        {"Hipparcos Number", "HIP 41337"},
        {"Smithsonian Astrophysical Observation", "SAO 60804"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.50987701),
        dec: Angle.Degrees(+36.98274937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108789",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15566 A"},
        {"Henry Draper", "HD 209394"},
        {"Hipparcos Number", "HIP 108789"},
        {"Smithsonian Astrophysical Observation", "SAO 71965"},
        {"Wilson Evans Batten Catalogue", "WEB 19570"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.56666233),
        dec: Angle.Degrees(+36.98284633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42705"},
        {"Hipparcos Number", "HIP 29576"},
        {"Smithsonian Astrophysical Observation", "SAO 58872"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.47925133),
        dec: Angle.Degrees(+36.98322054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36050",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36050"},
        {"Smithsonian Astrophysical Observation", "SAO 60065"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.43928331),
        dec: Angle.Degrees(+36.98487597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217618"},
        {"Hipparcos Number", "HIP 113695"},
        {"Smithsonian Astrophysical Observation", "SAO 72937"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.40359937),
        dec: Angle.Degrees(+36.98541333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112151"},
        {"Hipparcos Number", "HIP 62960"},
        {"Geneva Identification System", "GEN# +1.00112151"},
        {"Smithsonian Astrophysical Observation", "SAO 63243"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.52979316),
        dec: Angle.Degrees(+36.98726851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88987"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.44822823),
        dec: Angle.Degrees(+36.98799396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180375"},
        {"Hipparcos Number", "HIP 94560"},
        {"Smithsonian Astrophysical Observation", "SAO 68029"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.67895940),
        dec: Angle.Degrees(+36.98833364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25152"},
        {"Hipparcos Number", "HIP 18769"},
        {"Geneva Identification System", "GEN# +1.00025152"},
        {"Smithsonian Astrophysical Observation", "SAO 56899"},
        {"Wilson Evans Batten Catalogue", "WEB 3613"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.31181383),
        dec: Angle.Degrees(+36.98948395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48271"},
        {"Hipparcos Number", "HIP 32263"},
        {"Geneva Identification System", "GEN# +1.00048271"},
        {"Smithsonian Astrophysical Observation", "SAO 59422"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04893507),
        dec: Angle.Degrees(+36.99403556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188650"},
        {"Hipparcos Number", "HIP 97985"},
        {"Geneva Identification System", "GEN# +1.00188650"},
        {"Smithsonian Astrophysical Observation", "SAO 69072"},
        {"Wilson Evans Batten Catalogue", "WEB 17247"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.70101118),
        dec: Angle.Degrees(+36.99565531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110166"},
        {"Hipparcos Number", "HIP 61800"},
        {"Geneva Identification System", "GEN# +1.00110166"},
        {"Smithsonian Astrophysical Observation", "SAO 63127"},
        {"Wilson Evans Batten Catalogue", "WEB 10992"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.98744517),
        dec: Angle.Degrees(+36.99823739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90883"},
        {"Geneva Identification System", "GEN# +0.03603168"},
        {"Smithsonian Astrophysical Observation", "SAO 67087"},
        {"Wilson Evans Batten Catalogue", "WEB 15585"},
    },
    visualMagnitude: 7.57,
    bvColour: 5.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.08366823),
        dec: Angle.Degrees(+36.99879842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193369"},
        {"Hipparcos Number", "HIP 100108"},
        {"Celescope Catalog", "CEL 5020"},
        {"Geneva Identification System", "GEN# +1.00193369"},
        {"Smithsonian Astrophysical Observation", "SAO 69803"},
        {"Wilson Evans Batten Catalogue", "WEB 18029"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.61927485),
        dec: Angle.Degrees(+36.99975390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66692",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66692"},
        {"Geneva Identification System", "GEN# +0.03702438"},
        {"Smithsonian Astrophysical Observation", "SAO 63677"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.06762222),
        dec: Angle.Degrees(+37.00297434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33152"},
        {"Hipparcos Number", "HIP 24029"},
        {"Geneva Identification System", "GEN# +1.00033152"},
        {"Smithsonian Astrophysical Observation", "SAO 57696"},
        {"Wilson Evans Batten Catalogue", "WEB 4684"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.48513923),
        dec: Angle.Degrees(+37.00445264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 281116"},
        {"Hipparcos Number", "HIP 25588"},
        {"Smithsonian Astrophysical Observation", "SAO 58066"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.02911787),
        dec: Angle.Degrees(+37.00887102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23904"},
        {"Geneva Identification System", "GEN# +2.17780005"},
        {"New General Catalogue", "NGC 1778 5"},
    },
    visualMagnitude: 11.18,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.03299975),
        dec: Angle.Degrees(+37.01020464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85956",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85956"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.51696230),
        dec: Angle.Degrees(+37.01099236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71353"},
        {"Hipparcos Number", "HIP 41552"},
        {"Smithsonian Astrophysical Observation", "SAO 60838"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09326671),
        dec: Angle.Degrees(+37.01208955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21182"},
        {"Hipparcos Number", "HIP 16028"},
        {"Geneva Identification System", "GEN# +1.00021182"},
        {"Smithsonian Astrophysical Observation", "SAO 56447"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.59381083),
        dec: Angle.Degrees(+37.01325761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14968"},
        {"Hipparcos Number", "HIP 11333"},
        {"Smithsonian Astrophysical Observation", "SAO 55544"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.45808093),
        dec: Angle.Degrees(+37.01364283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68327",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68327"},
        {"Geneva Identification System", "GEN# +0.03702478"},
        {"Smithsonian Astrophysical Observation", "SAO 63867"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.79497344),
        dec: Angle.Degrees(+37.01384736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151877"},
        {"Hipparcos Number", "HIP 82267"},
        {"Cincinnati Publication", "Ci 18 2245"},
        {"Geneva Identification System", "GEN# +1.00151877"},
        {"Smithsonian Astrophysical Observation", "SAO 65567"},
        {"Wilson Evans Batten Catalogue", "WEB 13887"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.14815779),
        dec: Angle.Degrees(+37.01425370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -363.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105289"},
        {"Hipparcos Number", "HIP 59117"},
        {"Geneva Identification System", "GEN# +1.00105289"},
        {"Smithsonian Astrophysical Observation", "SAO 62845"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.84066548),
        dec: Angle.Degrees(+37.01508101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67886"},
        {"Smithsonian Astrophysical Observation", "SAO 63820"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.55938815),
        dec: Angle.Degrees(+37.01681782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61915"},
        {"Geneva Identification System", "GEN# +0.03702310"},
        {"Smithsonian Astrophysical Observation", "SAO 63136"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.34589174),
        dec: Angle.Degrees(+37.01681804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58220"},
        {"Hipparcos Number", "HIP 36112"},
        {"Smithsonian Astrophysical Observation", "SAO 60075"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.58871192),
        dec: Angle.Degrees(+37.01692031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140101"},
        {"Hipparcos Number", "HIP 76773"},
        {"Smithsonian Astrophysical Observation", "SAO 64841"},
        {"Wilson Evans Batten Catalogue", "WEB 13029"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.12596014),
        dec: Angle.Degrees(+37.01700379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 278497"},
        {"Hipparcos Number", "HIP 15740"},
        {"Smithsonian Astrophysical Observation", "SAO 56391"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.70017514),
        dec: Angle.Degrees(+37.01972171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73172"},
        {"Hipparcos Number", "HIP 42364"},
        {"Geneva Identification System", "GEN# +1.00073172"},
        {"Smithsonian Astrophysical Observation", "SAO 60937"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.57316117),
        dec: Angle.Degrees(+37.02041577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149750"},
        {"Hipparcos Number", "HIP 81210"},
        {"Geneva Identification System", "GEN# +1.00149750"},
        {"Smithsonian Astrophysical Observation", "SAO 65410"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.81119953),
        dec: Angle.Degrees(+37.02193611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36032"},
        {"Smithsonian Astrophysical Observation", "SAO 60063"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.37656361),
        dec: Angle.Degrees(+37.02434738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194357"},
        {"Hipparcos Number", "HIP 100579"},
        {"Celescope Catalog", "CEL 5047"},
        {"Fundamental Katalog 5th Edition", "FK5 5800"},
        {"Geneva Identification System", "GEN# +1.00194357"},
        {"Smithsonian Astrophysical Observation", "SAO 69952"},
        {"Wilson Evans Batten Catalogue", "WEB 18173"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.95014956),
        dec: Angle.Degrees(+37.02613840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89574",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89574"},
        {"Smithsonian Astrophysical Observation", "SAO 66821"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.17789370),
        dec: Angle.Degrees(+37.02683591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68612",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68612"},
        {"Smithsonian Astrophysical Observation", "SAO 63907"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.68990630),
        dec: Angle.Degrees(+37.02846491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90193"},
        {"Hipparcos Number", "HIP 51022"},
        {"Smithsonian Astrophysical Observation", "SAO 62030"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.35013830),
        dec: Angle.Degrees(+37.02861886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15294"},
        {"Hipparcos Number", "HIP 11544"},
        {"Smithsonian Astrophysical Observation", "SAO 55588"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.19403255),
        dec: Angle.Degrees(+37.02879314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7995 A"},
        {"Henry Draper", "HD 94979"},
        {"Hipparcos Number", "HIP 53641"},
        {"Geneva Identification System", "GEN# +1.00094979A"},
        {"Smithsonian Astrophysical Observation", "SAO 62335"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.60679119),
        dec: Angle.Degrees(+37.02883134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69083"},
        {"Smithsonian Astrophysical Observation", "SAO 63950"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.10462441),
        dec: Angle.Degrees(+37.02914068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36704",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59747"},
        {"Hipparcos Number", "HIP 36704"},
        {"Geneva Identification System", "GEN# +1.00059747"},
        {"Smithsonian Astrophysical Observation", "SAO 60168"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.25257044),
        dec: Angle.Degrees(+37.02982342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32556"},
        {"Smithsonian Astrophysical Observation", "SAO 59485"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.89566785),
        dec: Angle.Degrees(+37.03056643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53640",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7995 B"},
        {"Hipparcos Number", "HIP 53640"},
        {"Geneva Identification System", "GEN# +1.00094979B"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.60498213),
        dec: Angle.Degrees(+37.03139908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33704"},
        {"Hipparcos Number", "HIP 24379"},
        {"Celescope Catalog", "CEL 569"},
        {"Geneva Identification System", "GEN# +1.00033704"},
        {"Smithsonian Astrophysical Observation", "SAO 57767"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.45521702),
        dec: Angle.Degrees(+37.03275591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4882"},
        {"Hipparcos Number", "HIP 3997"},
        {"Smithsonian Astrophysical Observation", "SAO 54202"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.83381297),
        dec: Angle.Degrees(+37.03284584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116581"},
        {"Hipparcos Number", "HIP 65376"},
        {"Geneva Identification System", "GEN# +1.00116581"},
        {"Smithsonian Astrophysical Observation", "SAO 63514"},
        {"Wilson Evans Batten Catalogue", "WEB 11537"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.97466246),
        dec: Angle.Degrees(+37.03394754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134791"},
        {"Hipparcos Number", "HIP 74260"},
        {"Smithsonian Astrophysical Observation", "SAO 64535"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.64674121),
        dec: Angle.Degrees(+37.03466778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90930"},
        {"Hipparcos Number", "HIP 51455"},
        {"Geneva Identification System", "GEN# +1.00090930"},
        {"Smithsonian Astrophysical Observation", "SAO 62083"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.64644747),
        dec: Angle.Degrees(+37.03501926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148086"},
        {"Hipparcos Number", "HIP 80349"},
        {"Geneva Identification System", "GEN# +1.00148086"},
        {"Smithsonian Astrophysical Observation", "SAO 65276"},
        {"Wilson Evans Batten Catalogue", "WEB 13597"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.04366613),
        dec: Angle.Degrees(+37.03659126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108404"},
        {"Smithsonian Astrophysical Observation", "SAO 71880"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.41559746),
        dec: Angle.Degrees(+37.03741859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7271 AB"},
        {"Henry Draper", "HD 79725"},
        {"Hipparcos Number", "HIP 45536"},
        {"Smithsonian Astrophysical Observation", "SAO 61376"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.21312016),
        dec: Angle.Degrees(+37.03845474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189687"},
        {"Hipparcos Number", "HIP 98425"},
        {"Celescope Catalog", "CEL 4901"},
        {"Fundamental Katalog 5th Edition", "FK5 3599"},
        {"Geneva Identification System", "GEN# +1.00189687"},
        {"Smithsonian Astrophysical Observation", "SAO 69231"},
        {"Wilson Evans Batten Catalogue", "WEB 17376"},
    },
    visualMagnitude: 5.15,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.97997979),
        dec: Angle.Degrees(+37.04288602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28620"},
        {"Hipparcos Number", "HIP 21167"},
        {"Geneva Identification System", "GEN# +1.00028620"},
        {"Smithsonian Astrophysical Observation", "SAO 57288"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.07179385),
        dec: Angle.Degrees(+37.04326501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185753"},
        {"Hipparcos Number", "HIP 96670"},
        {"Smithsonian Astrophysical Observation", "SAO 68639"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80863987),
        dec: Angle.Degrees(+37.04387015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94137"},
        {"Smithsonian Astrophysical Observation", "SAO 67895"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.43642786),
        dec: Angle.Degrees(+37.04404648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109741"},
        {"Smithsonian Astrophysical Observation", "SAO 72151"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.44107615),
        dec: Angle.Degrees(+37.04490853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36974"},
        {"Hipparcos Number", "HIP 26385"},
        {"Geneva Identification System", "GEN# +1.00036974"},
        {"Smithsonian Astrophysical Observation", "SAO 58251"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.26770486),
        dec: Angle.Degrees(+37.04520252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124985"},
        {"Hipparcos Number", "HIP 69677"},
        {"Geneva Identification System", "GEN# +1.00124985"},
        {"Smithsonian Astrophysical Observation", "SAO 64032"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.94534461),
        dec: Angle.Degrees(+37.04543854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61206"},
        {"Geneva Identification System", "GEN# +0.03702289"},
        {"Smithsonian Astrophysical Observation", "SAO 63053"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.13076954),
        dec: Angle.Degrees(+37.04559448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19427"},
        {"Hipparcos Number", "HIP 14616"},
        {"Smithsonian Astrophysical Observation", "SAO 56195"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.19809686),
        dec: Angle.Degrees(+37.04574383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140364"},
        {"Hipparcos Number", "HIP 76870"},
        {"Smithsonian Astrophysical Observation", "SAO 64853"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.45267321),
        dec: Angle.Degrees(+37.04838138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115793",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115793"},
        {"Smithsonian Astrophysical Observation", "SAO 73267"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.87719939),
        dec: Angle.Degrees(+37.04858634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151023"},
        {"Hipparcos Number", "HIP 81867"},
        {"Geneva Identification System", "GEN# +1.00151023"},
        {"Smithsonian Astrophysical Observation", "SAO 65509"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.81531433),
        dec: Angle.Degrees(+37.05098904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59153",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59153"},
        {"Geneva Identification System", "GEN# +0.03702252"},
        {"Smithsonian Astrophysical Observation", "SAO 62850"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.96430359),
        dec: Angle.Degrees(+37.05418046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106998"},
    },
    visualMagnitude: 11.44,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04512140),
        dec: Angle.Degrees(+37.05578470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69434"},
        {"Hipparcos Number", "HIP 40692"},
        {"Smithsonian Astrophysical Observation", "SAO 60713"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59679774),
        dec: Angle.Degrees(+37.05622303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192987"},
        {"Hipparcos Number", "HIP 99929"},
        {"Celescope Catalog", "CEL 5005"},
        {"Geneva Identification System", "GEN# +1.00192987"},
        {"Smithsonian Astrophysical Observation", "SAO 69725"},
        {"Wilson Evans Batten Catalogue", "WEB 17976"},
    },
    visualMagnitude: 6.47,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.11730319),
        dec: Angle.Degrees(+37.05639710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16057"},
        {"Hipparcos Number", "HIP 12100"},
        {"Geneva Identification System", "GEN# +1.00016057"},
        {"Smithsonian Astrophysical Observation", "SAO 55690"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.97898618),
        dec: Angle.Degrees(+37.05834056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79424"},
        {"Hipparcos Number", "HIP 45403"},
        {"Geneva Identification System", "GEN# +1.00079424"},
        {"Smithsonian Astrophysical Observation", "SAO 61358"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78814294),
        dec: Angle.Degrees(+37.06018571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162338"},
        {"Hipparcos Number", "HIP 87204"},
        {"Smithsonian Astrophysical Observation", "SAO 66352"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.24280545),
        dec: Angle.Degrees(+37.06193424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229015"},
        {"Hipparcos Number", "HIP 100323"},
        {"Smithsonian Astrophysical Observation", "SAO 69866"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.18996237),
        dec: Angle.Degrees(+37.06214507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 796 A"},
        {"Henry Draper", "HD 5539"},
        {"Hipparcos Number", "HIP 4490"},
        {"Smithsonian Astrophysical Observation", "SAO 54289"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.38922203),
        dec: Angle.Degrees(+37.06284918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83758",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83758"},
        {"Smithsonian Astrophysical Observation", "SAO 65800"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.77328474),
        dec: Angle.Degrees(+37.06356005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31424",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5201 AB"},
        {"Henry Draper", "HD 46451"},
        {"Hipparcos Number", "HIP 31424"},
        {"Smithsonian Astrophysical Observation", "SAO 59255"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.77562608),
        dec: Angle.Degrees(+37.06439519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121458"},
        {"Hipparcos Number", "HIP 67921"},
        {"Geneva Identification System", "GEN# +1.00121458"},
        {"Smithsonian Astrophysical Observation", "SAO 63828"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.66218071),
        dec: Angle.Degrees(+37.06532939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187482"},
        {"Hipparcos Number", "HIP 97482"},
        {"Smithsonian Astrophysical Observation", "SAO 68898"},
    },
    visualMagnitude: 8.76,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.20338565),
        dec: Angle.Degrees(+37.06545971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61025",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61025"},
        {"Geneva Identification System", "GEN# +0.03702284"},
        {"Renson", "Renson 31600"},
        {"Smithsonian Astrophysical Observation", "SAO 63030"},
        {"Wilson Evans Batten Catalogue", "WEB 10864"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.60188573),
        dec: Angle.Degrees(+37.06571588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26447"},
        {"Hipparcos Number", "HIP 19640"},
        {"Smithsonian Astrophysical Observation", "SAO 57065"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.13019140),
        dec: Angle.Degrees(+37.06657128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14190"},
        {"Hipparcos Number", "HIP 10771"},
        {"Smithsonian Astrophysical Observation", "SAO 55444"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.65013751),
        dec: Angle.Degrees(+37.06704236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135891"},
        {"Hipparcos Number", "HIP 74730"},
        {"Fundamental Katalog 5th Edition", "FK5 5356"},
        {"Geneva Identification System", "GEN# +1.00135891"},
        {"Smithsonian Astrophysical Observation", "SAO 64602"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.08985803),
        dec: Angle.Degrees(+37.06947747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -268.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14445"},
        {"Hipparcos Number", "HIP 10950"},
        {"Geneva Identification System", "GEN# +1.00014445"},
        {"Smithsonian Astrophysical Observation", "SAO 55475"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.25979969),
        dec: Angle.Degrees(+37.07026483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75782"},
        {"Hipparcos Number", "HIP 43634"},
        {"Geneva Identification System", "GEN# +1.00075782"},
        {"Smithsonian Astrophysical Observation", "SAO 61111"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.29829117),
        dec: Angle.Degrees(+37.07062973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8908"},
        {"Hipparcos Number", "HIP 6872"},
        {"Celescope Catalog", "CEL 140"},
        {"Smithsonian Astrophysical Observation", "SAO 54720"},
        {"Wilson Evans Batten Catalogue", "WEB 1497"},
    },
    visualMagnitude: 7.51,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.10756695),
        dec: Angle.Degrees(+37.07063504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71636"},
        {"Hipparcos Number", "HIP 41691"},
        {"Geneva Identification System", "GEN# +1.00071636"},
        {"Smithsonian Astrophysical Observation", "SAO 60855"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.48462093),
        dec: Angle.Degrees(+37.07097469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94704"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.05582023),
        dec: Angle.Degrees(+37.07188069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103216",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14420 AB"},
        {"Henry Draper", "HD 199234"},
        {"Hipparcos Number", "HIP 103216"},
        {"Celescope Catalog", "CEL 5203"},
        {"Geneva Identification System", "GEN# +1.00199234J"},
        {"Smithsonian Astrophysical Observation", "SAO 70659"},
        {"Wilson Evans Batten Catalogue", "WEB 18749"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.67495617),
        dec: Angle.Degrees(+37.07371725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74009"},
        {"Smithsonian Astrophysical Observation", "SAO 64511"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.86726454),
        dec: Angle.Degrees(+37.07373627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174260"},
        {"Hipparcos Number", "HIP 92256"},
        {"Celescope Catalog", "CEL 4654"},
        {"Geneva Identification System", "GEN# +1.00174260"},
        {"Smithsonian Astrophysical Observation", "SAO 67399"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.01207794),
        dec: Angle.Degrees(+37.07394271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78138"},
        {"Hipparcos Number", "HIP 44794"},
        {"Fundamental Katalog 5th Edition", "FK5 4810"},
        {"Geneva Identification System", "GEN# +1.00078138"},
        {"Smithsonian Astrophysical Observation", "SAO 61273"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.93417170),
        dec: Angle.Degrees(+37.07436651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216756"},
        {"Hipparcos Number", "HIP 113174"},
        {"Fundamental Katalog 5th Edition", "FK5 1600"},
        {"Geneva Identification System", "GEN# +1.00216756"},
        {"Smithsonian Astrophysical Observation", "SAO 72838"},
        {"Wilson Evans Batten Catalogue", "WEB 20142"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.76076644),
        dec: Angle.Degrees(+37.07680479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207637"},
        {"Hipparcos Number", "HIP 107737"},
        {"Smithsonian Astrophysical Observation", "SAO 71740"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.36686002),
        dec: Angle.Degrees(+37.08122195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98745"},
        {"Hipparcos Number", "HIP 55509"},
        {"Smithsonian Astrophysical Observation", "SAO 62515"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.53039983),
        dec: Angle.Degrees(+37.08126176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8072"},
        {"Smithsonian Astrophysical Observation", "SAO 54936"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.92957810),
        dec: Angle.Degrees(+37.08176794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63588"},
        {"Hipparcos Number", "HIP 38349"},
        {"Smithsonian Astrophysical Observation", "SAO 60384"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.81393599),
        dec: Angle.Degrees(+37.08215389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93588"},
        {"Smithsonian Astrophysical Observation", "SAO 67749"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.89573759),
        dec: Angle.Degrees(+37.08332033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37071"},
        {"Hipparcos Number", "HIP 26434"},
        {"Geneva Identification System", "GEN# +1.00037071"},
        {"Smithsonian Astrophysical Observation", "SAO 58258"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.38557579),
        dec: Angle.Degrees(+37.08665480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25538"},
        {"Hipparcos Number", "HIP 19055"},
        {"Fundamental Katalog 5th Edition", "FK5 4368"},
        {"Geneva Identification System", "GEN# +1.00025538"},
        {"Smithsonian Astrophysical Observation", "SAO 56953"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.24063585),
        dec: Angle.Degrees(+37.08759322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98744"},
        {"Hipparcos Number", "HIP 55508"},
        {"Smithsonian Astrophysical Observation", "SAO 62514"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.52935334),
        dec: Angle.Degrees(+37.08762908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72236"},
        {"Hipparcos Number", "HIP 41945"},
        {"Smithsonian Astrophysical Observation", "SAO 60892"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.26573470),
        dec: Angle.Degrees(+37.08816080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17758"},
        {"Hipparcos Number", "HIP 13378"},
        {"Smithsonian Astrophysical Observation", "SAO 55957"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.04706960),
        dec: Angle.Degrees(+37.09412821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47862"},
        {"Hipparcos Number", "HIP 32100"},
        {"Geneva Identification System", "GEN# +1.00047862"},
        {"Smithsonian Astrophysical Observation", "SAO 59384"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.59605753),
        dec: Angle.Degrees(+37.09622654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115388"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.61489494),
        dec: Angle.Degrees(+37.09729669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33649",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5642 A"},
        {"Henry Draper", "HD 51560"},
        {"Hipparcos Number", "HIP 33649"},
        {"Smithsonian Astrophysical Observation", "SAO 59665"},
        {"Wilson Evans Batten Catalogue", "WEB 6761"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.86329739),
        dec: Angle.Degrees(+37.09819008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111351",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111351"},
        {"Renson", "Renson 59310"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.39111271),
        dec: Angle.Degrees(+37.09883842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189942"},
        {"Hipparcos Number", "HIP 98563"},
        {"Geneva Identification System", "GEN# +1.00189942"},
        {"Smithsonian Astrophysical Observation", "SAO 69267"},
        {"Wilson Evans Batten Catalogue", "WEB 17420"},
    },
    visualMagnitude: 6.23,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.31365859),
        dec: Angle.Degrees(+37.09887283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63817",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63817"},
        {"Smithsonian Astrophysical Observation", "SAO 63330"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.19401973),
        dec: Angle.Degrees(+37.09964132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202217"},
        {"Hipparcos Number", "HIP 104749"},
        {"Celescope Catalog", "CEL 5276"},
        {"Geneva Identification System", "GEN# +1.00202217"},
        {"Smithsonian Astrophysical Observation", "SAO 71082"},
    },
    visualMagnitude: 8.22,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.32024371),
        dec: Angle.Degrees(+37.10199851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213977"},
        {"Hipparcos Number", "HIP 111438"},
        {"Smithsonian Astrophysical Observation", "SAO 72481"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.64136580),
        dec: Angle.Degrees(+37.10240239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33653",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5642 G"},
        {"Aitken 2", "ADS 5642 B"},
        {"Henry Draper", "HD 51582"},
        {"Hipparcos Number", "HIP 33653"},
        {"Smithsonian Astrophysical Observation", "SAO 59666"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.87097557),
        dec: Angle.Degrees(+37.10241846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111408"},
        {"Renson", "Renson 59340"},
        {"Smithsonian Astrophysical Observation", "SAO 72474"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.55496243),
        dec: Angle.Degrees(+37.10468081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28005"},
        {"Smithsonian Astrophysical Observation", "SAO 58572"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.86301661),
        dec: Angle.Degrees(+37.10540966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210577"},
        {"Hipparcos Number", "HIP 109469"},
        {"Smithsonian Astrophysical Observation", "SAO 72094"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.65038247),
        dec: Angle.Degrees(+37.10646773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72340"},
        {"Hipparcos Number", "HIP 42006"},
        {"Smithsonian Astrophysical Observation", "SAO 60900"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.42678579),
        dec: Angle.Degrees(+37.11164452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58846",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58846"},
        {"Geneva Identification System", "GEN# +0.03702245"},
        {"Smithsonian Astrophysical Observation", "SAO 62822"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.03324239),
        dec: Angle.Degrees(+37.11313270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117728"},
        {"Hipparcos Number", "HIP 65976"},
        {"Geneva Identification System", "GEN# +1.00117728"},
        {"Smithsonian Astrophysical Observation", "SAO 63583"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.90021350),
        dec: Angle.Degrees(+37.11371271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108299"},
        {"Hipparcos Number", "HIP 60696"},
        {"Geneva Identification System", "GEN# +1.00108299"},
        {"Smithsonian Astrophysical Observation", "SAO 63006"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.59914715),
        dec: Angle.Degrees(+37.11388094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47085"},
        {"Hipparcos Number", "HIP 31754"},
        {"Geneva Identification System", "GEN# +1.00047085"},
        {"Smithsonian Astrophysical Observation", "SAO 59315"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.63637593),
        dec: Angle.Degrees(+37.11415038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26833",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26833"},
        {"Smithsonian Astrophysical Observation", "SAO 58340"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.47205186),
        dec: Angle.Degrees(+37.11532557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102645"},
        {"Hipparcos Number", "HIP 57638"},
        {"Geneva Identification System", "GEN# +1.00102645"},
        {"Smithsonian Astrophysical Observation", "SAO 62716"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.28595478),
        dec: Angle.Degrees(+37.11618064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13160"},
        {"Hipparcos Number", "HIP 10077"},
        {"Smithsonian Astrophysical Observation", "SAO 55308"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40564905),
        dec: Angle.Degrees(+37.11640581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204403"},
        {"Hipparcos Number", "HIP 105942"},
        {"Fundamental Katalog 5th Edition", "FK5 3714"},
        {"Geneva Identification System", "GEN# +1.00204403"},
        {"Smithsonian Astrophysical Observation", "SAO 71358"},
        {"Wilson Evans Batten Catalogue", "WEB 19209"},
    },
    visualMagnitude: 5.30,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.83901766),
        dec: Angle.Degrees(+37.11679196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83295"},
        {"Smithsonian Astrophysical Observation", "SAO 65734"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.35118575),
        dec: Angle.Degrees(+37.11773647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95666"},
        {"Smithsonian Astrophysical Observation", "SAO 68343"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.89264705),
        dec: Angle.Degrees(+37.11795309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14893"},
        {"Hipparcos Number", "HIP 11278"},
        {"Celescope Catalog", "CEL 274"},
        {"Geneva Identification System", "GEN# +1.00014893"},
        {"Smithsonian Astrophysical Observation", "SAO 55530"},
    },
    visualMagnitude: 7.35,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.31547415),
        dec: Angle.Degrees(+37.11900841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54832"},
        {"Smithsonian Astrophysical Observation", "SAO 62457"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.38530262),
        dec: Angle.Degrees(+37.11978704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178565"},
        {"Hipparcos Number", "HIP 93924"},
        {"Smithsonian Astrophysical Observation", "SAO 67842"},
    },
    visualMagnitude: 9.09,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.87818754),
        dec: Angle.Degrees(+37.12079684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25338"},
        {"Hipparcos Number", "HIP 18908"},
        {"Geneva Identification System", "GEN# +1.00025338"},
        {"Smithsonian Astrophysical Observation", "SAO 56926"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.78980682),
        dec: Angle.Degrees(+37.12112072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54695"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.96279081),
        dec: Angle.Degrees(+37.12349916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279276"},
        {"Hipparcos Number", "HIP 18767"},
        {"Geneva Identification System", "GEN# +1.00279276"},
        {"Smithsonian Astrophysical Observation", "SAO 56897"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.30154706),
        dec: Angle.Degrees(+37.12673344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11624"},
        {"Hipparcos Number", "HIP 8930"},
        {"Geneva Identification System", "GEN# +1.00011624"},
        {"Smithsonian Astrophysical Observation", "SAO 55082"},
        {"Wilson Evans Batten Catalogue", "WEB 1878"},
    },
    visualMagnitude: 6.28,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.74013935),
        dec: Angle.Degrees(+37.12833508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51909"},
        {"Hipparcos Number", "HIP 33768"},
        {"Smithsonian Astrophysical Observation", "SAO 59683"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.19501102),
        dec: Angle.Degrees(+37.12856330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84003"},
        {"Hipparcos Number", "HIP 47660"},
        {"Smithsonian Astrophysical Observation", "SAO 61652"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.76730802),
        dec: Angle.Degrees(+37.12860512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125112"},
        {"Hipparcos Number", "HIP 69733"},
        {"Geneva Identification System", "GEN# +1.00125112"},
        {"Smithsonian Astrophysical Observation", "SAO 64038"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.10145328),
        dec: Angle.Degrees(+37.12998987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193621"},
        {"Hipparcos Number", "HIP 100239"},
        {"Celescope Catalog", "CEL 5026"},
        {"Geneva Identification System", "GEN# +1.00193621"},
        {"Smithsonian Astrophysical Observation", "SAO 69841"},
        {"Wilson Evans Batten Catalogue", "WEB 18066"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.95130281),
        dec: Angle.Degrees(+37.13253176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56659",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56659"},
        {"Geneva Identification System", "GEN# +0.03702199"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.25953709),
        dec: Angle.Degrees(+37.13328604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66085"},
        {"Hipparcos Number", "HIP 39414"},
        {"Smithsonian Astrophysical Observation", "SAO 60531"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.86058027),
        dec: Angle.Degrees(+37.13672875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63882",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63882"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.37541923),
        dec: Angle.Degrees(+37.13677988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -303.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213091"},
        {"Hipparcos Number", "HIP 110918"},
        {"Smithsonian Astrophysical Observation", "SAO 72374"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.07778760),
        dec: Angle.Degrees(+37.13983310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86262"},
        {"Smithsonian Astrophysical Observation", "SAO 66194"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.39503517),
        dec: Angle.Degrees(+37.14046051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50206"},
        {"Smithsonian Astrophysical Observation", "SAO 61950"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.74264948),
        dec: Angle.Degrees(+37.14400445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127403"},
        {"Hipparcos Number", "HIP 70912"},
        {"Geneva Identification System", "GEN# +1.00127403"},
        {"Smithsonian Astrophysical Observation", "SAO 64183"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.53130597),
        dec: Angle.Degrees(+37.14426188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87019"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71457897),
        dec: Angle.Degrees(+37.14447218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194709"},
        {"Hipparcos Number", "HIP 100757"},
        {"Smithsonian Astrophysical Observation", "SAO 70002"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.42538809),
        dec: Angle.Degrees(+37.14517640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85112",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10526 AB"},
        {"Hipparcos Number", "HIP 85112"},
        {"Geneva Identification System", "GEN# +1.00157779"},
    },
    visualMagnitude: 4.15,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.92072033),
        dec: Angle.Degrees(+37.14592396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48073"},
        {"Hipparcos Number", "HIP 32190"},
        {"Geneva Identification System", "GEN# +1.00048073"},
        {"Smithsonian Astrophysical Observation", "SAO 59406"},
        {"Wilson Evans Batten Catalogue", "WEB 6492"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80718325),
        dec: Angle.Degrees(+37.14743034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23407"},
        {"Hipparcos Number", "HIP 17619"},
        {"Smithsonian Astrophysical Observation", "SAO 56691"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.61640404),
        dec: Angle.Degrees(+37.14780943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47512",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47512"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.29438664),
        dec: Angle.Degrees(+37.14926987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109231",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109231"},
        {"Smithsonian Astrophysical Observation", "SAO 72049"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.93541567),
        dec: Angle.Degrees(+37.14986484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227959"},
        {"Hipparcos Number", "HIP 99276"},
        {"Geneva Identification System", "GEN# +1.00227959"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.28234013),
        dec: Angle.Degrees(+37.15197832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275960"},
        {"Hipparcos Number", "HIP 18444"},
        {"Smithsonian Astrophysical Observation", "SAO 56826"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.13980523),
        dec: Angle.Degrees(+37.15786747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42617"},
        {"Hipparcos Number", "HIP 29541"},
        {"Smithsonian Astrophysical Observation", "SAO 58866"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.37706181),
        dec: Angle.Degrees(+37.15913399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97440",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12965 AB"},
        {"Henry Draper", "HD 187375"},
        {"Hipparcos Number", "HIP 97440"},
        {"Smithsonian Astrophysical Observation", "SAO 68884"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.06867569),
        dec: Angle.Degrees(+37.16039480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59036"},
        {"Hipparcos Number", "HIP 36424"},
        {"Geneva Identification System", "GEN# +1.00059036"},
        {"Smithsonian Astrophysical Observation", "SAO 60127"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.44081843),
        dec: Angle.Degrees(+37.16152374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11752",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11752"},
        {"Smithsonian Astrophysical Observation", "SAO 55627"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.90436964),
        dec: Angle.Degrees(+37.16277250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104040"},
        {"Smithsonian Astrophysical Observation", "SAO 70869"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.16986633),
        dec: Angle.Degrees(+37.16312087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103831"},
        {"Hipparcos Number", "HIP 58319"},
        {"Geneva Identification System", "GEN# +1.00103831"},
        {"Smithsonian Astrophysical Observation", "SAO 62773"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.38227247),
        dec: Angle.Degrees(+37.16315156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77508",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77508"},
        {"Smithsonian Astrophysical Observation", "SAO 64928"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.39338859),
        dec: Angle.Degrees(+37.16438692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41478"},
        {"Hipparcos Number", "HIP 29003"},
        {"Smithsonian Astrophysical Observation", "SAO 58755"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.79155788),
        dec: Angle.Degrees(+37.16439586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203611"},
        {"Hipparcos Number", "HIP 105530"},
        {"Geneva Identification System", "GEN# +1.00203611"},
        {"Smithsonian Astrophysical Observation", "SAO 71254"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.60327099),
        dec: Angle.Degrees(+37.16477916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195465"},
        {"Hipparcos Number", "HIP 101147"},
        {"Smithsonian Astrophysical Observation", "SAO 70120"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.53728528),
        dec: Angle.Degrees(+37.16700995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93624"},
        {"Hipparcos Number", "HIP 52885"},
        {"Smithsonian Astrophysical Observation", "SAO 62265"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.24859119),
        dec: Angle.Degrees(+37.17111490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16809"},
        {"Hipparcos Number", "HIP 12678"},
        {"Smithsonian Astrophysical Observation", "SAO 55807"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.72107019),
        dec: Angle.Degrees(+37.17392351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45848"},
        {"Hipparcos Number", "HIP 31096"},
        {"Smithsonian Astrophysical Observation", "SAO 59173"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.88159574),
        dec: Angle.Degrees(+37.17802208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5376"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.19442926),
        dec: Angle.Degrees(+37.18043344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190570"},
        {"Hipparcos Number", "HIP 98821"},
        {"Celescope Catalog", "CEL 4924"},
        {"Geneva Identification System", "GEN# +1.00190570"},
        {"Smithsonian Astrophysical Observation", "SAO 69348"},
        {"Wilson Evans Batten Catalogue", "WEB 17520"},
    },
    visualMagnitude: 8.16,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.02745222),
        dec: Angle.Degrees(+37.18210559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118216"},
        {"Hipparcos Number", "HIP 66257"},
        {"Fundamental Katalog 5th Edition", "FK5 502"},
        {"Geneva Identification System", "GEN# +1.00118216"},
        {"Smithsonian Astrophysical Observation", "SAO 63623"},
        {"Wilson Evans Batten Catalogue", "WEB 11711"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.69894294),
        dec: Angle.Degrees(+37.18243871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2983"},
        {"Hipparcos Number", "HIP 2625"},
        {"Smithsonian Astrophysical Observation", "SAO 53980"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.32611506),
        dec: Angle.Degrees(+37.18290918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43835"},
        {"Hipparcos Number", "HIP 30097"},
        {"Renson", "Renson 11630"},
        {"Smithsonian Astrophysical Observation", "SAO 58988"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.00940374),
        dec: Angle.Degrees(+37.18409485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 86 AB"},
        {"Henry Draper", "HD 292"},
        {"Hipparcos Number", "HIP 634"},
        {"Smithsonian Astrophysical Observation", "SAO 53665"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.92958594),
        dec: Angle.Degrees(+37.18548226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160693"},
        {"Hipparcos Number", "HIP 86431"},
        {"Cincinnati Publication", "Ci 20 1054"},
        {"Cincinnati Publication 2", "Ci 18 2353"},
        {"Geneva Identification System", "GEN# +1.00160693"},
        {"Smithsonian Astrophysical Observation", "SAO 66228"},
        {"Wilson Evans Batten Catalogue", "WEB 14582"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.90515414),
        dec: Angle.Degrees(+37.18574616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -497.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -819.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113816"},
        {"Smithsonian Astrophysical Observation", "SAO 72958"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.72328346),
        dec: Angle.Degrees(+37.18598255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88390",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88390"},
        {"Smithsonian Astrophysical Observation", "SAO 66584"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.74568288),
        dec: Angle.Degrees(+37.18644594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182737"},
        {"Hipparcos Number", "HIP 95409"},
        {"Celescope Catalog", "CEL 4746"},
        {"Geneva Identification System", "GEN# +1.00182737"},
        {"Smithsonian Astrophysical Observation", "SAO 68272"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.12763344),
        dec: Angle.Degrees(+37.18779744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59826"},
        {"Hipparcos Number", "HIP 36740"},
        {"Smithsonian Astrophysical Observation", "SAO 60173"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.35345342),
        dec: Angle.Degrees(+37.18788282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95759",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12504 AB"},
        {"Henry Draper", "HD 183559"},
        {"Hipparcos Number", "HIP 95759"},
        {"Smithsonian Astrophysical Observation", "SAO 68371"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.15710255),
        dec: Angle.Degrees(+37.18858225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35060"},
        {"Hipparcos Number", "HIP 25225"},
        {"Geneva Identification System", "GEN# +1.00035060"},
        {"Smithsonian Astrophysical Observation", "SAO 57968"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.92884155),
        dec: Angle.Degrees(+37.18921281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100213",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100213"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.88301783),
        dec: Angle.Degrees(+37.19080547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28727",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28727"},
        {"Smithsonian Astrophysical Observation", "SAO 58700"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.01654343),
        dec: Angle.Degrees(+37.19150241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5664"},
        {"Hipparcos Number", "HIP 4589"},
        {"Smithsonian Astrophysical Observation", "SAO 54310"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.68553977),
        dec: Angle.Degrees(+37.19275715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64388"},
        {"Hipparcos Number", "HIP 38681"},
        {"Geneva Identification System", "GEN# +1.00064388"},
        {"Smithsonian Astrophysical Observation", "SAO 60445"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.79505831),
        dec: Angle.Degrees(+37.19462066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85878"},
        {"Hipparcos Number", "HIP 48688"},
        {"Smithsonian Astrophysical Observation", "SAO 61760"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.94043989),
        dec: Angle.Degrees(+37.19517461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104257"},
        {"Smithsonian Astrophysical Observation", "SAO 70942"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.82344117),
        dec: Angle.Degrees(+37.19605280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68357"},
        {"Geneva Identification System", "GEN# +0.03702480"},
        {"Smithsonian Astrophysical Observation", "SAO 63872"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.88937940),
        dec: Angle.Degrees(+37.19736516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122969"},
        {"Hipparcos Number", "HIP 68737"},
        {"Smithsonian Astrophysical Observation", "SAO 63920"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.05290077),
        dec: Angle.Degrees(+37.19747627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27308"},
        {"Hipparcos Number", "HIP 20235"},
        {"Smithsonian Astrophysical Observation", "SAO 57164"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.05008927),
        dec: Angle.Degrees(+37.20073535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150292"},
        {"Hipparcos Number", "HIP 81481"},
        {"Smithsonian Astrophysical Observation", "SAO 65452"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.63147720),
        dec: Angle.Degrees(+37.20130587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43990"},
        {"Smithsonian Astrophysical Observation", "SAO 61154"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.37285953),
        dec: Angle.Degrees(+37.20166205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32639"},
        {"Hipparcos Number", "HIP 23760"},
        {"Geneva Identification System", "GEN# +1.00032639"},
        {"Smithsonian Astrophysical Observation", "SAO 57636"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.60078578),
        dec: Angle.Degrees(+37.20376306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213580"},
        {"Hipparcos Number", "HIP 111217"},
        {"Smithsonian Astrophysical Observation", "SAO 72441"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.97849876),
        dec: Angle.Degrees(+37.20384313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275907"},
        {"Hipparcos Number", "HIP 18037"},
        {"Geneva Identification System", "GEN# +1.00275907"},
        {"Smithsonian Astrophysical Observation", "SAO 56746"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.82781444),
        dec: Angle.Degrees(+37.20602975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126266"},
        {"Hipparcos Number", "HIP 70338"},
        {"Geneva Identification System", "GEN# +1.00126266"},
        {"Smithsonian Astrophysical Observation", "SAO 64115"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.86427216),
        dec: Angle.Degrees(+37.20642117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100254"},
        {"Hipparcos Number", "HIP 56297"},
        {"Smithsonian Astrophysical Observation", "SAO 62593"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.10970656),
        dec: Angle.Degrees(+37.20643169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32258"},
        {"Smithsonian Astrophysical Observation", "SAO 59421"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.04369018),
        dec: Angle.Degrees(+37.20774914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38328",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6399 A"},
        {"Henry Draper", "HD 63570"},
        {"Hipparcos Number", "HIP 38328"},
        {"Geneva Identification System", "GEN# +1.00063570"},
        {"Smithsonian Astrophysical Observation", "SAO 60377"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77531868),
        dec: Angle.Degrees(+37.21176810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28380",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mahasim"},
        {"Aitken", "ADS 4566 A"},
        {"Henry Draper", "HD 40312"},
        {"Hipparcos Number", "HIP 28380"},
        {"Geneva Identification System", "GEN# +1.00040312"},
        {"Renson", "Renson 10750"},
        {"Smithsonian Astrophysical Observation", "SAO 58636"},
        {"Wilson Evans Batten Catalogue", "WEB 5547"},
        {"Wilson Evans Batten Catalogue 2", "WEB 5548"},
    },
    visualMagnitude: 2.65,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.93015897),
        dec: Angle.Degrees(+37.21276409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143312"},
        {"Hipparcos Number", "HIP 78214"},
        {"Geneva Identification System", "GEN# +1.00143312"},
        {"Smithsonian Astrophysical Observation", "SAO 64992"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.834,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.58238029),
        dec: Angle.Degrees(+37.21368716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155877"},
        {"Hipparcos Number", "HIP 84196"},
        {"Geneva Identification System", "GEN# +1.00155877"},
        {"Smithsonian Astrophysical Observation", "SAO 65870"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.16376441),
        dec: Angle.Degrees(+37.21480665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2390 AB"},
        {"Henry Draper", "HD 19771"},
        {"Hipparcos Number", "HIP 14886"},
        {"Smithsonian Astrophysical Observation", "SAO 56241"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.03976575),
        dec: Angle.Degrees(+37.21784530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206718"},
        {"Hipparcos Number", "HIP 107226"},
        {"Smithsonian Astrophysical Observation", "SAO 71641"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.75914770),
        dec: Angle.Degrees(+37.21940661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170896"},
        {"Hipparcos Number", "HIP 90689"},
        {"Smithsonian Astrophysical Observation", "SAO 67040"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.55032082),
        dec: Angle.Degrees(+37.22020221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108122"},
        {"Hipparcos Number", "HIP 60590"},
        {"Geneva Identification System", "GEN# +1.00108122"},
        {"Smithsonian Astrophysical Observation", "SAO 62993"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.27758327),
        dec: Angle.Degrees(+37.22083077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106877"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.71199135),
        dec: Angle.Degrees(+37.22128423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3960"},
        {"Hipparcos Number", "HIP 3339"},
        {"Smithsonian Astrophysical Observation", "SAO 54099"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.64128696),
        dec: Angle.Degrees(+37.22243063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114218"},
        {"Hipparcos Number", "HIP 64139"},
        {"Geneva Identification System", "GEN# +1.00114218"},
        {"Smithsonian Astrophysical Observation", "SAO 63365"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.17252859),
        dec: Angle.Degrees(+37.22336544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67319"},
        {"Hipparcos Number", "HIP 39886"},
        {"Smithsonian Astrophysical Observation", "SAO 60595"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.20513112),
        dec: Angle.Degrees(+37.22699652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91875"},
        {"Hipparcos Number", "HIP 51970"},
        {"Smithsonian Astrophysical Observation", "SAO 62157"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.27304027),
        dec: Angle.Degrees(+37.22841220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35691"},
        {"Hipparcos Number", "HIP 25605"},
        {"Geneva Identification System", "GEN# +1.00035691"},
        {"Smithsonian Astrophysical Observation", "SAO 58070"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.06021961),
        dec: Angle.Degrees(+37.22946041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82381"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.51069808),
        dec: Angle.Degrees(+37.23274462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 177.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6613 AB"},
        {"Henry Draper", "HD 67391"},
        {"Hipparcos Number", "HIP 39916"},
        {"Smithsonian Astrophysical Observation", "SAO 60597"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.28721210),
        dec: Angle.Degrees(+37.23335901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73302"},
        {"Smithsonian Astrophysical Observation", "SAO 64437"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.70414945),
        dec: Angle.Degrees(+37.23395997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99002"},
        {"Hipparcos Number", "HIP 55641"},
        {"Geneva Identification System", "GEN# +1.00099002"},
        {"Smithsonian Astrophysical Observation", "SAO 62533"},
        {"Wilson Evans Batten Catalogue", "WEB 9998"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.97239823),
        dec: Angle.Degrees(+37.23485109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191473"},
        {"Hipparcos Number", "HIP 99246"},
        {"Celescope Catalog", "CEL 4946"},
        {"Geneva Identification System", "GEN# +1.00191473"},
        {"Smithsonian Astrophysical Observation", "SAO 69498"},
        {"Wilson Evans Batten Catalogue", "WEB 17686"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.19072128),
        dec: Angle.Degrees(+37.23705767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9531"},
        {"Hipparcos Number", "HIP 7321"},
        {"Celescope Catalog", "CEL 145"},
        {"Geneva Identification System", "GEN# +1.00009531"},
        {"Renson", "Renson 2330"},
        {"Smithsonian Astrophysical Observation", "SAO 54788"},
        {"Wilson Evans Batten Catalogue", "WEB 1574"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.56915511),
        dec: Angle.Degrees(+37.23719753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80564"},
        {"Smithsonian Astrophysical Observation", "SAO 65305"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.73734976),
        dec: Angle.Degrees(+37.23889123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101854"},
        {"Hipparcos Number", "HIP 57169"},
        {"Geneva Identification System", "GEN# +1.00101854"},
        {"Smithsonian Astrophysical Observation", "SAO 62670"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.86899162),
        dec: Angle.Degrees(+37.24076129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181023"},
        {"Hipparcos Number", "HIP 94794"},
        {"Smithsonian Astrophysical Observation", "SAO 68085"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.31470029),
        dec: Angle.Degrees(+37.24169459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29084",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4707 AB"},
        {"Hipparcos Number", "HIP 29084"},
        {"Smithsonian Astrophysical Observation", "SAO 58775"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.02894878),
        dec: Angle.Degrees(+37.24183191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92217",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92217"},
        {"Smithsonian Astrophysical Observation", "SAO 67391"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.91029306),
        dec: Angle.Degrees(+37.24330093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43944",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7100 AB"},
        {"Henry Draper", "HD 76387"},
        {"Hipparcos Number", "HIP 43944"},
        {"Smithsonian Astrophysical Observation", "SAO 61147"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.26123076),
        dec: Angle.Degrees(+37.24345686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182896"},
        {"Hipparcos Number", "HIP 95480"},
        {"Smithsonian Astrophysical Observation", "SAO 68285"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.32562908),
        dec: Angle.Degrees(+37.24527075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279869"},
        {"Hipparcos Number", "HIP 20788"},
        {"Smithsonian Astrophysical Observation", "SAO 57238"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.82083194),
        dec: Angle.Degrees(+37.24579449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55945"},
        {"Hipparcos Number", "HIP 35225"},
        {"Smithsonian Astrophysical Observation", "SAO 59935"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20316621),
        dec: Angle.Degrees(+37.24815214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163770"},
        {"Hipparcos Number", "HIP 87808"},
        {"Fundamental Katalog 5th Edition", "FK5 672"},
        {"Geneva Identification System", "GEN# +1.00163770"},
        {"Smithsonian Astrophysical Observation", "SAO 66485"},
        {"Wilson Evans Batten Catalogue", "WEB 14820"},
    },
    visualMagnitude: 3.86,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.06324389),
        dec: Angle.Degrees(+37.25052158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9021",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1534 A"},
        {"Henry Draper", "HD 11749"},
        {"Hipparcos Number", "HIP 9021"},
        {"Geneva Identification System", "GEN# +1.00011749A"},
        {"Smithsonian Astrophysical Observation", "SAO 55107"},
        {"Wilson Evans Batten Catalogue", "WEB 1896"},
    },
    visualMagnitude: 5.69,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.03845779),
        dec: Angle.Degrees(+37.25180400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104952",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14796 A"},
        {"Henry Draper", "HD 202569"},
        {"Hipparcos Number", "HIP 104952"},
        {"Celescope Catalog", "CEL 5281"},
        {"Geneva Identification System", "GEN# +1.00202569J"},
        {"Smithsonian Astrophysical Observation", "SAO 71128"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.89168817),
        dec: Angle.Degrees(+37.25236068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170596"},
        {"Hipparcos Number", "HIP 90556"},
        {"Geneva Identification System", "GEN# +1.00170596"},
        {"Smithsonian Astrophysical Observation", "SAO 67011"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.17630358),
        dec: Angle.Degrees(+37.25240503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47480"},
        {"Hipparcos Number", "HIP 31943"},
        {"Fundamental Katalog 5th Edition", "FK5 4608"},
        {"Geneva Identification System", "GEN# +1.00047480"},
        {"Smithsonian Astrophysical Observation", "SAO 59347"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.12914030),
        dec: Angle.Degrees(+37.26108989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82353"},
        {"Hipparcos Number", "HIP 46817"},
        {"Geneva Identification System", "GEN# +1.00082353"},
        {"Smithsonian Astrophysical Observation", "SAO 61550"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.10771226),
        dec: Angle.Degrees(+37.26129414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123407"},
        {"Hipparcos Number", "HIP 68927"},
        {"Smithsonian Astrophysical Observation", "SAO 63936"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.66596411),
        dec: Angle.Degrees(+37.26174070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71906"},
        {"Hipparcos Number", "HIP 41798"},
        {"Geneva Identification System", "GEN# +1.00071906"},
        {"Smithsonian Astrophysical Observation", "SAO 60866"},
        {"Wilson Evans Batten Catalogue", "WEB 8048"},
    },
    visualMagnitude: 6.18,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.83323549),
        dec: Angle.Degrees(+37.26501510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83786"},
        {"Hipparcos Number", "HIP 47558"},
        {"Geneva Identification System", "GEN# +1.00083786"},
        {"Smithsonian Astrophysical Observation", "SAO 61634"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.44459292),
        dec: Angle.Degrees(+37.26532351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114036"},
        {"Hipparcos Number", "HIP 64028"},
        {"Geneva Identification System", "GEN# +1.00114036"},
        {"Smithsonian Astrophysical Observation", "SAO 63351"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.81476980),
        dec: Angle.Degrees(+37.26587329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17308",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2696 AB"},
        {"Henry Draper", "HD 275772"},
        {"Hipparcos Number", "HIP 17308"},
        {"Geneva Identification System", "GEN# +1.00275772J"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.57597277),
        dec: Angle.Degrees(+37.26738102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32270"},
        {"Hipparcos Number", "HIP 23536"},
        {"Geneva Identification System", "GEN# +1.00032270"},
        {"Smithsonian Astrophysical Observation", "SAO 57596"},
        {"Wilson Evans Batten Catalogue", "WEB 4587"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.90940846),
        dec: Angle.Degrees(+37.26857904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92149"},
        {"Hipparcos Number", "HIP 52119"},
        {"Geneva Identification System", "GEN# +1.00092149"},
        {"Smithsonian Astrophysical Observation", "SAO 62175"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.72472307),
        dec: Angle.Degrees(+37.26866590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84074"},
        {"Smithsonian Astrophysical Observation", "SAO 65853"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.82910562),
        dec: Angle.Degrees(+37.26867814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20105"},
        {"Hipparcos Number", "HIP 15143"},
        {"Smithsonian Astrophysical Observation", "SAO 56282"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.80659759),
        dec: Angle.Degrees(+37.26885945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40922"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.27652523),
        dec: Angle.Degrees(+37.27078475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131111"},
        {"Hipparcos Number", "HIP 72582"},
        {"Geneva Identification System", "GEN# +1.00131111"},
        {"Smithsonian Astrophysical Observation", "SAO 64355"},
        {"Wilson Evans Batten Catalogue", "WEB 12480"},
    },
    visualMagnitude: 5.47,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.62417599),
        dec: Angle.Degrees(+37.27181511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27875"},
        {"Hipparcos Number", "HIP 20653"},
        {"Geneva Identification System", "GEN# +1.00027875"},
        {"Smithsonian Astrophysical Observation", "SAO 57220"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37990595),
        dec: Angle.Degrees(+37.27352146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74988",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74988"},
        {"Smithsonian Astrophysical Observation", "SAO 64631"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.85558035),
        dec: Angle.Degrees(+37.27536104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4481"},
        {"Hipparcos Number", "HIP 3687"},
        {"Smithsonian Astrophysical Observation", "SAO 54145"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.81616663),
        dec: Angle.Degrees(+37.27542204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34613"},
        {"Geneva Identification System", "GEN# +0.03701665"},
        {"Smithsonian Astrophysical Observation", "SAO 59836"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.53460030),
        dec: Angle.Degrees(+37.27670270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 280105"},
        {"Hipparcos Number", "HIP 22091"},
        {"Smithsonian Astrophysical Observation", "SAO 57406"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.29031193),
        dec: Angle.Degrees(+37.27726855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9001",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1534 B"},
        {"Henry Draper", "HD 11727"},
        {"Hipparcos Number", "HIP 9001"},
        {"Geneva Identification System", "GEN# +1.00011727"},
        {"Smithsonian Astrophysical Observation", "SAO 55102"},
        {"Wilson Evans Batten Catalogue", "WEB 1888"},
    },
    visualMagnitude: 5.89,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.97697359),
        dec: Angle.Degrees(+37.27780093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85137"},
        {"Geneva Identification System", "GEN# +0.03702879"},
        {"Smithsonian Astrophysical Observation", "SAO 66004"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.98893215),
        dec: Angle.Degrees(+37.28101484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -335.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69055"},
        {"Hipparcos Number", "HIP 40531"},
        {"Smithsonian Astrophysical Observation", "SAO 60697"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.13751842),
        dec: Angle.Degrees(+37.28163580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2128"},
        {"Smithsonian Astrophysical Observation", "SAO 53902"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.74789021),
        dec: Angle.Degrees(+37.28355547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 314.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208950"},
        {"Hipparcos Number", "HIP 108514"},
        {"Geneva Identification System", "GEN# +1.00208950"},
        {"Smithsonian Astrophysical Observation", "SAO 71906"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.74851991),
        dec: Angle.Degrees(+37.28424193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38230"},
        {"Hipparcos Number", "HIP 27207"},
        {"Cincinnati Publication", "Ci 20 348"},
        {"Cincinnati Publication 2", "Ci 18 725"},
        {"Geneva Identification System", "GEN# +1.00038230"},
        {"Smithsonian Astrophysical Observation", "SAO 58412"},
        {"Wilson Evans Batten Catalogue", "WEB 5349"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.50636958),
        dec: Angle.Degrees(+37.28588759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 487.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -509.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87506"},
        {"Smithsonian Astrophysical Observation", "SAO 66417"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.18341868),
        dec: Angle.Degrees(+37.28628487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120566"},
        {"Hipparcos Number", "HIP 67460"},
        {"Geneva Identification System", "GEN# +1.00120566"},
        {"Smithsonian Astrophysical Observation", "SAO 63770"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.37201735),
        dec: Angle.Degrees(+37.28851444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156729"},
        {"Hipparcos Number", "HIP 84606"},
        {"Geneva Identification System", "GEN# +1.00156729"},
        {"Smithsonian Astrophysical Observation", "SAO 65921"},
        {"Wilson Evans Batten Catalogue", "WEB 14286"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.41785775),
        dec: Angle.Degrees(+37.29134328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74483"},
        {"Hipparcos Number", "HIP 42983"},
        {"Geneva Identification System", "GEN# +1.00074483"},
        {"Smithsonian Astrophysical Observation", "SAO 61033"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.40779650),
        dec: Angle.Degrees(+37.29172407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210660"},
        {"Hipparcos Number", "HIP 109524"},
        {"Smithsonian Astrophysical Observation", "SAO 72104"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79627354),
        dec: Angle.Degrees(+37.29470106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137806"},
        {"Hipparcos Number", "HIP 75606"},
        {"Smithsonian Astrophysical Observation", "SAO 64707"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.70851180),
        dec: Angle.Degrees(+37.29494410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8746"},
        {"Hipparcos Number", "HIP 6753"},
        {"Geneva Identification System", "GEN# +1.00008746"},
        {"Smithsonian Astrophysical Observation", "SAO 54702"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.72453073),
        dec: Angle.Degrees(+37.29662674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212002"},
        {"Hipparcos Number", "HIP 110300"},
        {"Smithsonian Astrophysical Observation", "SAO 72248"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.11744550),
        dec: Angle.Degrees(+37.29808237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180659"},
        {"Hipparcos Number", "HIP 94669"},
        {"Smithsonian Astrophysical Observation", "SAO 68053"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.95889648),
        dec: Angle.Degrees(+37.29904441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45061"},
        {"Hipparcos Number", "HIP 30689"},
        {"Smithsonian Astrophysical Observation", "SAO 59085"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.73269216),
        dec: Angle.Degrees(+37.29946916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19509"},
        {"Hipparcos Number", "HIP 14666"},
        {"Smithsonian Astrophysical Observation", "SAO 56202"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.36758104),
        dec: Angle.Degrees(+37.30154960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159925"},
        {"Hipparcos Number", "HIP 86096"},
        {"Fundamental Katalog 5th Edition", "FK5 3395"},
        {"Geneva Identification System", "GEN# +1.00159925"},
        {"Smithsonian Astrophysical Observation", "SAO 66165"},
        {"Wilson Evans Batten Catalogue", "WEB 14523"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.92651408),
        dec: Angle.Degrees(+37.30158659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3734 AB"},
        {"Henry Draper", "HD 33203"},
        {"Hipparcos Number", "HIP 24072"},
        {"Geneva Identification System", "GEN# +1.00033203J"},
        {"Smithsonian Astrophysical Observation", "SAO 57704"},
        {"Wilson Evans Batten Catalogue", "WEB 4687"},
    },
    visualMagnitude: 6.02,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.57835458),
        dec: Angle.Degrees(+37.30185120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33308"},
        {"Hipparcos Number", "HIP 24145"},
        {"Geneva Identification System", "GEN# +1.00033308"},
        {"Smithsonian Astrophysical Observation", "SAO 57718"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.78317895),
        dec: Angle.Degrees(+37.30189652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88676",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88676"},
        {"Smithsonian Astrophysical Observation", "SAO 66632"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.54491670),
        dec: Angle.Degrees(+37.30203218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 382 AB"},
        {"Henry Draper", "HD 2471"},
        {"Hipparcos Number", "HIP 2252"},
        {"Renson", "Renson 580"},
        {"Smithsonian Astrophysical Observation", "SAO 53925"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.17029988),
        dec: Angle.Degrees(+37.30412680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84649"},
        {"Hipparcos Number", "HIP 48046"},
        {"Smithsonian Astrophysical Observation", "SAO 61686"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.91609097),
        dec: Angle.Degrees(+37.30422967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38944"},
        {"Hipparcos Number", "HIP 27639"},
        {"Fundamental Katalog 5th Edition", "FK5 2440"},
        {"Geneva Identification System", "GEN# +1.00038944"},
        {"Smithsonian Astrophysical Observation", "SAO 58496"},
        {"Wilson Evans Batten Catalogue", "WEB 5425"},
    },
    visualMagnitude: 4.72,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.76004280),
        dec: Angle.Degrees(+37.30568175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14009"},
        {"Smithsonian Astrophysical Observation", "SAO 56073"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.08456223),
        dec: Angle.Degrees(+37.31201317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12072",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1964 A"},
        {"Henry Draper", "HD 16028"},
        {"Hipparcos Number", "HIP 12072"},
        {"Geneva Identification System", "GEN# +1.00016028"},
        {"Smithsonian Astrophysical Observation", "SAO 55684"},
        {"Wilson Evans Batten Catalogue", "WEB 2485"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.91142631),
        dec: Angle.Degrees(+37.31229050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44633"},
        {"Hipparcos Number", "HIP 30484"},
        {"Smithsonian Astrophysical Observation", "SAO 59047"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.12163759),
        dec: Angle.Degrees(+37.31658363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175290"},
        {"Hipparcos Number", "HIP 92666"},
        {"Geneva Identification System", "GEN# +1.00175290"},
        {"Smithsonian Astrophysical Observation", "SAO 67517"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.24644973),
        dec: Angle.Degrees(+37.31757581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134474"},
        {"Hipparcos Number", "HIP 74135"},
        {"Geneva Identification System", "GEN# +1.00134474"},
        {"Smithsonian Astrophysical Observation", "SAO 64521"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24454090),
        dec: Angle.Degrees(+37.31830887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152971"},
        {"Hipparcos Number", "HIP 82777"},
        {"Smithsonian Astrophysical Observation", "SAO 65653"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.75371108),
        dec: Angle.Degrees(+37.32009518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1500 AB"},
        {"Henry Draper", "HD 11430"},
        {"Hipparcos Number", "HIP 8805"},
        {"Smithsonian Astrophysical Observation", "SAO 55058"},
        {"Wilson Evans Batten Catalogue", "WEB 1852"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.29471466),
        dec: Angle.Degrees(+37.32130146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185659"},
        {"Hipparcos Number", "HIP 96621"},
        {"Smithsonian Astrophysical Observation", "SAO 68623"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.67950558),
        dec: Angle.Degrees(+37.32219099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78750"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.16500442),
        dec: Angle.Degrees(+37.32400306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17484"},
        {"Hipparcos Number", "HIP 13176"},
        {"Geneva Identification System", "GEN# +1.00017484"},
        {"Smithsonian Astrophysical Observation", "SAO 55910"},
        {"Wilson Evans Batten Catalogue", "WEB 2650"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.36219739),
        dec: Angle.Degrees(+37.32641914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85186",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85186"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.874,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.13860700),
        dec: Angle.Degrees(+37.32651590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36742",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36742"},
        {"Smithsonian Astrophysical Observation", "SAO 60174"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.35819892),
        dec: Angle.Degrees(+37.32680292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31550"},
        {"Hipparcos Number", "HIP 23117"},
        {"Geneva Identification System", "GEN# +1.00031550"},
        {"Smithsonian Astrophysical Observation", "SAO 57539"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.61855648),
        dec: Angle.Degrees(+37.32915506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11573",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1881 AB"},
        {"Henry Draper", "HD 15333"},
        {"Hipparcos Number", "HIP 11573"},
        {"Renson", "Renson 3850"},
        {"Smithsonian Astrophysical Observation", "SAO 55594"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.28110197),
        dec: Angle.Degrees(+37.32978174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123944"},
        {"Hipparcos Number", "HIP 69184"},
        {"Geneva Identification System", "GEN# +1.00123944"},
        {"Smithsonian Astrophysical Observation", "SAO 63962"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.43551843),
        dec: Angle.Degrees(+37.33001889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181655"},
        {"Hipparcos Number", "HIP 94981"},
        {"Geneva Identification System", "GEN# +1.00181655"},
        {"Smithsonian Astrophysical Observation", "SAO 68144"},
        {"Wilson Evans Batten Catalogue", "WEB 16591"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.91268060),
        dec: Angle.Degrees(+37.33098454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21728"},
        {"Hipparcos Number", "HIP 16438"},
        {"Geneva Identification System", "GEN# +2.13420002"},
        {"Renson", "Renson 5430"},
        {"Smithsonian Astrophysical Observation", "SAO 56512"},
        {"New General Catalogue", "NGC 1342 2"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.92410107),
        dec: Angle.Degrees(+37.33140862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37505"},
        {"Hipparcos Number", "HIP 26733"},
        {"Smithsonian Astrophysical Observation", "SAO 58320"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.19729485),
        dec: Angle.Degrees(+37.33197215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15745"},
        {"Hipparcos Number", "HIP 11847"},
        {"Geneva Identification System", "GEN# +1.00015745"},
        {"Smithsonian Astrophysical Observation", "SAO 55649"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.23240373),
        dec: Angle.Degrees(+37.33373864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7285",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7285"},
        {"Geneva Identification System", "GEN# +0.03600276"},
        {"Smithsonian Astrophysical Observation", "SAO 54784"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.46684121),
        dec: Angle.Degrees(+37.33495961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30452"},
        {"Hipparcos Number", "HIP 22421"},
        {"Geneva Identification System", "GEN# +1.00030452"},
        {"Smithsonian Astrophysical Observation", "SAO 57446"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.37484257),
        dec: Angle.Degrees(+37.33502791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53285"},
        {"Hipparcos Number", "HIP 34265"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.54615271),
        dec: Angle.Degrees(+37.33519216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33632"},
        {"Hipparcos Number", "HIP 24332"},
        {"Geneva Identification System", "GEN# +1.00033632"},
        {"Smithsonian Astrophysical Observation", "SAO 57754"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.32313264),
        dec: Angle.Degrees(+37.33763726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27844",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4472 AB"},
        {"Henry Draper", "HD 39315"},
        {"Hipparcos Number", "HIP 27844"},
        {"Smithsonian Astrophysical Observation", "SAO 58535"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.36944204),
        dec: Angle.Degrees(+37.33884958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98850"},
        {"Hipparcos Number", "HIP 55558"},
        {"Smithsonian Astrophysical Observation", "SAO 62521"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.70230929),
        dec: Angle.Degrees(+37.34329527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124676"},
        {"Hipparcos Number", "HIP 69533"},
        {"Smithsonian Astrophysical Observation", "SAO 64009"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.51793060),
        dec: Angle.Degrees(+37.34418171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113302"},
        {"Hipparcos Number", "HIP 63622"},
        {"Geneva Identification System", "GEN# +1.00113302"},
        {"Smithsonian Astrophysical Observation", "SAO 63312"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.59273744),
        dec: Angle.Degrees(+37.34539777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82432"},
        {"Smithsonian Astrophysical Observation", "SAO 65600"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.70108441),
        dec: Angle.Degrees(+37.34629075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51946"},
        {"Smithsonian Astrophysical Observation", "SAO 62151"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.17944586),
        dec: Angle.Degrees(+37.34704916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9626 BC"},
        {"Henry Draper", "HD 137392"},
        {"Hipparcos Number", "HIP 75415"},
        {"Geneva Identification System", "GEN# +1.00137392J"},
        {"Smithsonian Astrophysical Observation", "SAO 64687"},
        {"Wilson Evans Batten Catalogue", "WEB 12865"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.12904066),
        dec: Angle.Degrees(+37.34709337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67661"},
        {"Hipparcos Number", "HIP 40026"},
        {"Geneva Identification System", "GEN# +1.00067661"},
        {"Smithsonian Astrophysical Observation", "SAO 60616"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.63088535),
        dec: Angle.Degrees(+37.34851543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82096"},
        {"Smithsonian Astrophysical Observation", "SAO 65544"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.54971828),
        dec: Angle.Degrees(+37.34984111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57075"},
        {"Geneva Identification System", "GEN# +0.03802268"},
        {"Smithsonian Astrophysical Observation", "SAO 62660"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.50222735),
        dec: Angle.Degrees(+37.35042557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203857"},
        {"Hipparcos Number", "HIP 105637"},
        {"Smithsonian Astrophysical Observation", "SAO 71280"},
        {"Wilson Evans Batten Catalogue", "WEB 19174"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.95163645),
        dec: Angle.Degrees(+37.35149782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13355"},
        {"Hipparcos Number", "HIP 10222"},
        {"Smithsonian Astrophysical Observation", "SAO 55337"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.85985165),
        dec: Angle.Degrees(+37.35221746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214716"},
        {"Hipparcos Number", "HIP 111864"},
        {"Smithsonian Astrophysical Observation", "SAO 72578"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.88055283),
        dec: Angle.Degrees(+37.35364403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192639"},
        {"Hipparcos Number", "HIP 99768"},
        {"Celescope Catalog", "CEL 4987"},
        {"Geneva Identification System", "GEN# +1.00192639"},
        {"Smithsonian Astrophysical Observation", "SAO 69676"},
        {"Wilson Evans Batten Catalogue", "WEB 17917"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.62679461),
        dec: Angle.Degrees(+37.35383972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177487"},
        {"Hipparcos Number", "HIP 93549"},
        {"Smithsonian Astrophysical Observation", "SAO 67744"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.80428159),
        dec: Angle.Degrees(+37.35397866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186675"},
        {"Hipparcos Number", "HIP 97118"},
        {"Fundamental Katalog 5th Edition", "FK5 740"},
        {"Geneva Identification System", "GEN# +1.00186675"},
        {"Smithsonian Astrophysical Observation", "SAO 68778"},
        {"Wilson Evans Batten Catalogue", "WEB 17048"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.06896508),
        dec: Angle.Degrees(+37.35426967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16186"},
        {"Hipparcos Number", "HIP 12183"},
        {"Smithsonian Astrophysical Observation", "SAO 55706"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.23837433),
        dec: Angle.Degrees(+37.35451028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150566"},
        {"Hipparcos Number", "HIP 81623"},
        {"Smithsonian Astrophysical Observation", "SAO 65475"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.06430865),
        dec: Angle.Degrees(+37.35567401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213062"},
        {"Hipparcos Number", "HIP 110915"},
        {"Geneva Identification System", "GEN# +1.00213062"},
        {"Smithsonian Astrophysical Observation", "SAO 72373"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.06542082),
        dec: Angle.Degrees(+37.35942765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9507"},
        {"Smithsonian Astrophysical Observation", "SAO 55208"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.57858879),
        dec: Angle.Degrees(+37.36095760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78077"},
        {"Smithsonian Astrophysical Observation", "SAO 64982"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.13291702),
        dec: Angle.Degrees(+37.36105277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29284"},
        {"Hipparcos Number", "HIP 21608"},
        {"Geneva Identification System", "GEN# +1.00029284"},
        {"Smithsonian Astrophysical Observation", "SAO 57352"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.58357293),
        dec: Angle.Degrees(+37.36249677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13440"},
        {"Hipparcos Number", "HIP 10275"},
        {"Smithsonian Astrophysical Observation", "SAO 55345"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.07066613),
        dec: Angle.Degrees(+37.36684699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122968"},
        {"Hipparcos Number", "HIP 68734"},
        {"Smithsonian Astrophysical Observation", "SAO 63919"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.04728240),
        dec: Angle.Degrees(+37.36939779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66046"},
        {"Hipparcos Number", "HIP 39400"},
        {"Smithsonian Astrophysical Observation", "SAO 60530"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.82462550),
        dec: Angle.Degrees(+37.37024322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217091"},
        {"Hipparcos Number", "HIP 113364"},
        {"Smithsonian Astrophysical Observation", "SAO 72880"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.39424429),
        dec: Angle.Degrees(+37.37187356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16143 A"},
        {"Henry Draper", "HD 214652"},
        {"Hipparcos Number", "HIP 111828"},
        {"Geneva Identification System", "GEN# +1.00214652"},
        {"Smithsonian Astrophysical Observation", "SAO 72569"},
        {"Wilson Evans Batten Catalogue", "WEB 19976"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.76910639),
        dec: Angle.Degrees(+37.37543197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188075"},
        {"Hipparcos Number", "HIP 97752"},
        {"Fundamental Katalog 5th Edition", "FK5 5754"},
        {"Geneva Identification System", "GEN# +1.00188075"},
        {"Smithsonian Astrophysical Observation", "SAO 68993"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.98816930),
        dec: Angle.Degrees(+37.37594968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226822"},
        {"Hipparcos Number", "HIP 98243"},
        {"Smithsonian Astrophysical Observation", "SAO 69165"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.46662332),
        dec: Angle.Degrees(+37.37638878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9719 AB"},
        {"Henry Draper", "HD 139374"},
        {"Hipparcos Number", "HIP 76414"},
        {"Smithsonian Astrophysical Observation", "SAO 64803"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.10912982),
        dec: Angle.Degrees(+37.37657222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75411",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alkalurops"},
        {"Aitken", "ADS 9626 A"},
        {"Henry Draper", "HD 137391"},
        {"Hipparcos Number", "HIP 75411"},
        {"Fundamental Katalog 5th Edition", "FK5 568"},
        {"Geneva Identification System", "GEN# +1.00137391"},
        {"Renson", "Renson 39052"},
        {"Smithsonian Astrophysical Observation", "SAO 64686"},
        {"Wilson Evans Batten Catalogue", "WEB 12864"},
    },
    visualMagnitude: 4.31,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.12306762),
        dec: Angle.Degrees(+37.37696091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64488"},
        {"Geneva Identification System", "GEN# +0.03802412"},
        {"Smithsonian Astrophysical Observation", "SAO 63409"},
        {"Wilson Evans Batten Catalogue", "WEB 11400"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.27659503),
        dec: Angle.Degrees(+37.37700393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72620",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72620"},
        {"Smithsonian Astrophysical Observation", "SAO 64360"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71701845),
        dec: Angle.Degrees(+37.37833029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14756"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.64035634),
        dec: Angle.Degrees(+37.37902766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275501"},
        {"Hipparcos Number", "HIP 16476"},
        {"Geneva Identification System", "GEN# +2.13420004"},
        {"Smithsonian Astrophysical Observation", "SAO 56524"},
        {"New General Catalogue", "NGC 1342 4"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.04678601),
        dec: Angle.Degrees(+37.38207181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4231"},
        {"Hipparcos Number", "HIP 3539"},
        {"Smithsonian Astrophysical Observation", "SAO 54124"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.29330629),
        dec: Angle.Degrees(+37.38282000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64974"},
        {"Smithsonian Astrophysical Observation", "SAO 63467"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.75167842),
        dec: Angle.Degrees(+37.38439124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16209",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16209"},
        {"Cincinnati Publication", "Ci 20 235"},
        {"Geneva Identification System", "GEN# +9.80038001"},
        {"Wilson Evans Batten Catalogue", "WEB 3088"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.21798939),
        dec: Angle.Degrees(+37.38503584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1120.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1065.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25292",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3984 A"},
        {"Henry Draper", "HD 35186"},
        {"Hipparcos Number", "HIP 25292"},
        {"Geneva Identification System", "GEN# +1.00035186J"},
        {"Smithsonian Astrophysical Observation", "SAO 57981"},
        {"Wilson Evans Batten Catalogue", "WEB 4909"},
    },
    visualMagnitude: 5.02,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.16309201),
        dec: Angle.Degrees(+37.38537514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 226343"},
        {"Hipparcos Number", "HIP 97847"},
        {"Smithsonian Astrophysical Observation", "SAO 69024"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.26230152),
        dec: Angle.Degrees(+37.38556240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103137",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103137"},
        {"Smithsonian Astrophysical Observation", "SAO 70644"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.44728789),
        dec: Angle.Degrees(+37.38563548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6140",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1055 A"},
        {"Henry Draper", "HD 7853"},
        {"Hipparcos Number", "HIP 6140"},
        {"Geneva Identification System", "GEN# +1.00007853"},
        {"Renson", "Renson 1930"},
        {"Smithsonian Astrophysical Observation", "SAO 54592"},
        {"Wilson Evans Batten Catalogue", "WEB 1379"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.69589864),
        dec: Angle.Degrees(+37.38630238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62710"},
        {"Geneva Identification System", "GEN# +0.03802374"},
        {"Smithsonian Astrophysical Observation", "SAO 63223"},
        {"Wilson Evans Batten Catalogue", "WEB 11121"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.77044223),
        dec: Angle.Degrees(+37.38709805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80845"},
        {"Hipparcos Number", "HIP 46025"},
        {"Smithsonian Astrophysical Observation", "SAO 61436"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.79654047),
        dec: Angle.Degrees(+37.38808840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178307"},
        {"Hipparcos Number", "HIP 93831"},
        {"Smithsonian Astrophysical Observation", "SAO 67821"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.61774906),
        dec: Angle.Degrees(+37.38834404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41286",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6796 AB"},
        {"Henry Draper", "HD 70803"},
        {"Hipparcos Number", "HIP 41286"},
        {"Smithsonian Astrophysical Observation", "SAO 60797"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.34885812),
        dec: Angle.Degrees(+37.38853254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207183"},
        {"Hipparcos Number", "HIP 107483"},
        {"Smithsonian Astrophysical Observation", "SAO 71680"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.55285818),
        dec: Angle.Degrees(+37.38995048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200777"},
        {"Hipparcos Number", "HIP 104008"},
        {"Smithsonian Astrophysical Observation", "SAO 70862"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.07805591),
        dec: Angle.Degrees(+37.39310544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98652"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.56130047),
        dec: Angle.Degrees(+37.39380626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98016"},
        {"Hipparcos Number", "HIP 55089"},
        {"Smithsonian Astrophysical Observation", "SAO 62473"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.18465586),
        dec: Angle.Degrees(+37.39381857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148283"},
        {"Hipparcos Number", "HIP 80460"},
        {"Fundamental Katalog 5th Edition", "FK5 3296"},
        {"Geneva Identification System", "GEN# +1.00148283"},
        {"Smithsonian Astrophysical Observation", "SAO 65290"},
        {"Wilson Evans Batten Catalogue", "WEB 13613"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.35069083),
        dec: Angle.Degrees(+37.39407872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51021"},
        {"Hipparcos Number", "HIP 33453"},
        {"Smithsonian Astrophysical Observation", "SAO 59634"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.32709140),
        dec: Angle.Degrees(+37.39473253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63529"},
        {"Smithsonian Astrophysical Observation", "SAO 63301"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.27560782),
        dec: Angle.Degrees(+37.39612370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197162"},
        {"Hipparcos Number", "HIP 102035"},
        {"Smithsonian Astrophysical Observation", "SAO 70355"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.15357619),
        dec: Angle.Degrees(+37.39745782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214715"},
        {"Hipparcos Number", "HIP 111872"},
        {"Smithsonian Astrophysical Observation", "SAO 72583"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.90517747),
        dec: Angle.Degrees(+37.39754324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46472",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46472"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.16903985),
        dec: Angle.Degrees(+37.39781396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48083"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.03724530),
        dec: Angle.Degrees(+37.39829176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207068"},
        {"Hipparcos Number", "HIP 107432"},
        {"Smithsonian Astrophysical Observation", "SAO 71674"},
    },
    visualMagnitude: 8.52,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.39265727),
        dec: Angle.Degrees(+37.40089504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125874"},
        {"Hipparcos Number", "HIP 70142"},
        {"Smithsonian Astrophysical Observation", "SAO 64092"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.877,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.28731121),
        dec: Angle.Degrees(+37.40108632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88231"},
        {"Hipparcos Number", "HIP 49893"},
        {"Fundamental Katalog 5th Edition", "FK5 2817"},
        {"Geneva Identification System", "GEN# +1.00088231"},
        {"Smithsonian Astrophysical Observation", "SAO 61914"},
        {"Wilson Evans Batten Catalogue", "WEB 9184"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.80330481),
        dec: Angle.Degrees(+37.40197095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202655"},
        {"Hipparcos Number", "HIP 105014"},
        {"Renson", "Renson 56470"},
        {"Smithsonian Astrophysical Observation", "SAO 71143"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.04787205),
        dec: Angle.Degrees(+37.40341928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 275839"},
        {"Hipparcos Number", "HIP 17536"},
        {"Geneva Identification System", "GEN# +0.03600746"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.31903182),
        dec: Angle.Degrees(+37.40576763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220500"},
        {"Hipparcos Number", "HIP 115511"},
        {"Smithsonian Astrophysical Observation", "SAO 73225"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.97598265),
        dec: Angle.Degrees(+37.40579508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66306",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66306"},
        {"Geneva Identification System", "GEN# +0.03802460"},
        {"Smithsonian Astrophysical Observation", "SAO 63629"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.83928529),
        dec: Angle.Degrees(+37.40584319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128798"},
        {"Hipparcos Number", "HIP 71539"},
        {"Smithsonian Astrophysical Observation", "SAO 64248"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.48176789),
        dec: Angle.Degrees(+37.40640828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203784"},
        {"Henry Draper 2", "HD 203857B"},
        {"Hipparcos Number", "HIP 105607"},
        {"Geneva Identification System", "GEN# +1.00203784"},
        {"Smithsonian Astrophysical Observation", "SAO 71276"},
        {"Wilson Evans Batten Catalogue", "WEB 19171"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.84578611),
        dec: Angle.Degrees(+37.40648196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5538"},
        {"Hipparcos Number", "HIP 4491"},
        {"Geneva Identification System", "GEN# +1.00005538"},
        {"Smithsonian Astrophysical Observation", "SAO 54290"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.39101638),
        dec: Angle.Degrees(+37.40666619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31979"},
        {"Hipparcos Number", "HIP 23387"},
        {"Smithsonian Astrophysical Observation", "SAO 57579"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.41214193),
        dec: Angle.Degrees(+37.40954797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111105"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.62438741),
        dec: Angle.Degrees(+37.40996132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34558"},
        {"Hipparcos Number", "HIP 24889"},
        {"Smithsonian Astrophysical Observation", "SAO 57905"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.02286781),
        dec: Angle.Degrees(+37.41051918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190428"},
        {"Hipparcos Number", "HIP 98755"},
        {"Smithsonian Astrophysical Observation", "SAO 69328"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.87762369),
        dec: Angle.Degrees(+37.41057120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85744"},
        {"Hipparcos Number", "HIP 48614"},
        {"Smithsonian Astrophysical Observation", "SAO 61753"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.71445146),
        dec: Angle.Degrees(+37.41508194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215943"},
        {"Hipparcos Number", "HIP 112590"},
        {"Geneva Identification System", "GEN# +1.00215943"},
        {"Smithsonian Astrophysical Observation", "SAO 72732"},
        {"Wilson Evans Batten Catalogue", "WEB 20073"},
    },
    visualMagnitude: 5.82,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.04611234),
        dec: Angle.Degrees(+37.41684226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101648"},
        {"Geneva Identification System", "GEN# +0.03604145"},
        {"Smithsonian Astrophysical Observation", "SAO 70255"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.07586802),
        dec: Angle.Degrees(+37.41746691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5118"},
        {"Hipparcos Number", "HIP 4185"},
        {"Geneva Identification System", "GEN# +1.00005118"},
        {"Smithsonian Astrophysical Observation", "SAO 54237"},
        {"Wilson Evans Batten Catalogue", "WEB 753"},
    },
    visualMagnitude: 6.07,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.36756319),
        dec: Angle.Degrees(+37.41831737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 850"},
        {"Hipparcos Number", "HIP 1049"},
        {"Smithsonian Astrophysical Observation", "SAO 53728"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.26924809),
        dec: Angle.Degrees(+37.41863959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1713"},
        {"Hipparcos Number", "HIP 1716"},
        {"Smithsonian Astrophysical Observation", "SAO 53836"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.39754074),
        dec: Angle.Degrees(+37.41941043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31380"},
        {"Geneva Identification System", "GEN# +0.03701537"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.68915521),
        dec: Angle.Degrees(+37.42272091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1790 AB"},
        {"Henry Draper", "HD 14472"},
        {"Hipparcos Number", "HIP 10966"},
        {"Smithsonian Astrophysical Observation", "SAO 55478"},
    },
    visualMagnitude: 8.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.31219608),
        dec: Angle.Degrees(+37.42309425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114357"},
        {"Hipparcos Number", "HIP 64212"},
        {"Geneva Identification System", "GEN# +1.00114357"},
        {"Smithsonian Astrophysical Observation", "SAO 63372"},
        {"Wilson Evans Batten Catalogue", "WEB 11351"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.41134739),
        dec: Angle.Degrees(+37.42313176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99982",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13641 A"},
        {"Henry Draper", "HD 193077"},
        {"Hipparcos Number", "HIP 99982"},
        {"Geneva Identification System", "GEN# +1.00193077A"},
        {"Smithsonian Astrophysical Observation", "SAO 69755"},
        {"Wilson Evans Batten Catalogue", "WEB 17996"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.25011975),
        dec: Angle.Degrees(+37.42328661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72968"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.68054521),
        dec: Angle.Degrees(+37.42565350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27194"},
    },
    visualMagnitude: 12.49,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.46503106),
        dec: Angle.Degrees(+37.42690775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6276"},
        {"Henry Draper", "HD 61600"},
        {"Hipparcos Number", "HIP 37483"},
        {"Renson", "Renson 16896"},
        {"Smithsonian Astrophysical Observation", "SAO 60275"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.42341717),
        dec: Angle.Degrees(+37.43005640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11348"},
        {"Hipparcos Number", "HIP 8734"},
        {"Geneva Identification System", "GEN# +1.00011348"},
        {"Smithsonian Astrophysical Observation", "SAO 55047"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.09309303),
        dec: Angle.Degrees(+37.43009231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27195"},
        {"Smithsonian Astrophysical Observation", "SAO 58408"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.47300456),
        dec: Angle.Degrees(+37.43014957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22442"},
        {"Hipparcos Number", "HIP 16935"},
        {"Geneva Identification System", "GEN# +1.00022442"},
        {"Smithsonian Astrophysical Observation", "SAO 56593"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.48437649),
        dec: Angle.Degrees(+37.43090070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171363"},
        {"Hipparcos Number", "HIP 90929"},
        {"Renson", "Renson 47990"},
        {"Smithsonian Astrophysical Observation", "SAO 67095"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.22169610),
        dec: Angle.Degrees(+37.43178122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1906"},
        {"Hipparcos Number", "HIP 1861"},
        {"Geneva Identification System", "GEN# +1.00001906"},
        {"Smithsonian Astrophysical Observation", "SAO 53856"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.88543711),
        dec: Angle.Degrees(+37.43295749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172324"},
        {"Hipparcos Number", "HIP 91359"},
        {"Geneva Identification System", "GEN# +1.00172324"},
        {"Smithsonian Astrophysical Observation", "SAO 67189"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.49490665),
        dec: Angle.Degrees(+37.43494632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116737"},
        {"Hipparcos Number", "HIP 65458"},
        {"Geneva Identification System", "GEN# +1.00116737"},
        {"Smithsonian Astrophysical Observation", "SAO 63525"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.24561537),
        dec: Angle.Degrees(+37.43514366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31102",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31102"},
        {"Smithsonian Astrophysical Observation", "SAO 59174"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.90119064),
        dec: Angle.Degrees(+37.43685695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34656"},
        {"Hipparcos Number", "HIP 24957"},
        {"Celescope Catalog", "CEL 620"},
        {"Geneva Identification System", "GEN# +1.00034656"},
        {"Smithsonian Astrophysical Observation", "SAO 57919"},
        {"Wilson Evans Batten Catalogue", "WEB 4833"},
    },
    visualMagnitude: 6.79,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.17949940),
        dec: Angle.Degrees(+37.43867717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29132"},
        {"Hipparcos Number", "HIP 21485"},
        {"Geneva Identification System", "GEN# +1.00029132"},
        {"Smithsonian Astrophysical Observation", "SAO 57338"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.21063074),
        dec: Angle.Degrees(+37.43912364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170260"},
        {"Hipparcos Number", "HIP 90411"},
        {"Smithsonian Astrophysical Observation", "SAO 66985"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.71732318),
        dec: Angle.Degrees(+37.44049371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60783",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60783"},
    },
    visualMagnitude: 12.08,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.87326817),
        dec: Angle.Degrees(+37.44236075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -227.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212883"},
        {"Hipparcos Number", "HIP 110790"},
        {"Geneva Identification System", "GEN# +1.00212883"},
        {"Smithsonian Astrophysical Observation", "SAO 72344"},
        {"Wilson Evans Batten Catalogue", "WEB 19848"},
    },
    visualMagnitude: 6.46,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.68982704),
        dec: Angle.Degrees(+37.44371876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24051"},
        {"Hipparcos Number", "HIP 18047"},
        {"Smithsonian Astrophysical Observation", "SAO 56747"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.85710645),
        dec: Angle.Degrees(+37.44394778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30249"},
        {"Smithsonian Astrophysical Observation", "SAO 59009"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.44624435),
        dec: Angle.Degrees(+37.44507198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53925"},
        {"Hipparcos Number", "HIP 34462"},
        {"Geneva Identification System", "GEN# +1.00053925"},
        {"Smithsonian Astrophysical Observation", "SAO 59812"},
        {"Wilson Evans Batten Catalogue", "WEB 6903"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.15103117),
        dec: Angle.Degrees(+37.44513204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181470"},
        {"Hipparcos Number", "HIP 94932"},
        {"Geneva Identification System", "GEN# +1.00181470"},
        {"Smithsonian Astrophysical Observation", "SAO 68129"},
        {"Wilson Evans Batten Catalogue", "WEB 16573"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.75478526),
        dec: Angle.Degrees(+37.44531278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30391"},
        {"Smithsonian Astrophysical Observation", "SAO 59031"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.85897120),
        dec: Angle.Degrees(+37.44577906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215181"},
        {"Hipparcos Number", "HIP 112140"},
        {"Smithsonian Astrophysical Observation", "SAO 72650"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.72566741),
        dec: Angle.Degrees(+37.44732118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193368"},
        {"Hipparcos Number", "HIP 100113"},
        {"Wilson Evans Batten Catalogue", "WEB 18030"},
    },
    visualMagnitude: 10.16,
    bvColour: 3.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.63864634),
        dec: Angle.Degrees(+37.44975798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37473"},
        {"Smithsonian Astrophysical Observation", "SAO 60270"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.37729912),
        dec: Angle.Degrees(+37.45001257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6263"},
        {"Hipparcos Number", "HIP 4999"},
        {"Geneva Identification System", "GEN# +1.00006263"},
        {"Smithsonian Astrophysical Observation", "SAO 54392"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.01466611),
        dec: Angle.Degrees(+37.45106803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186926"},
        {"Hipparcos Number", "HIP 97238"},
        {"Smithsonian Astrophysical Observation", "SAO 68809"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.44097464),
        dec: Angle.Degrees(+37.45257972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110927",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15970 A"},
        {"Henry Draper", "HD 213100"},
        {"Hipparcos Number", "HIP 110927"},
        {"Geneva Identification System", "GEN# +1.00213100"},
        {"Smithsonian Astrophysical Observation", "SAO 72380"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.11557197),
        dec: Angle.Degrees(+37.45383908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11734",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1914 A"},
        {"Henry Draper", "HD 15582"},
        {"Hipparcos Number", "HIP 11734"},
        {"Geneva Identification System", "GEN# +1.00015582"},
        {"Smithsonian Astrophysical Observation", "SAO 55625"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.86699791),
        dec: Angle.Degrees(+37.45416356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8531"},
        {"Hipparcos Number", "HIP 6620"},
        {"Smithsonian Astrophysical Observation", "SAO 54675"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24596075),
        dec: Angle.Degrees(+37.45492090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228101"},
        {"Hipparcos Number", "HIP 99412"},
        {"Celescope Catalog", "CEL 4959"},
        {"Geneva Identification System", "GEN# +1.00228101"},
        {"Smithsonian Astrophysical Observation", "SAO 69557"},
        {"Wilson Evans Batten Catalogue", "WEB 17753"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.65288722),
        dec: Angle.Degrees(+37.45852392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105485",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105485"},
        {"Wilson Evans Batten Catalogue", "WEB 19153"},
    },
    visualMagnitude: 11.82,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.47802382),
        dec: Angle.Degrees(+37.45920883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106577"},
        {"Hipparcos Number", "HIP 59772"},
        {"Geneva Identification System", "GEN# +1.00106577"},
        {"Smithsonian Astrophysical Observation", "SAO 62920"},
        {"Wilson Evans Batten Catalogue", "WEB 10620"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.84748419),
        dec: Angle.Degrees(+37.46348977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228114"},
        {"Hipparcos Number", "HIP 99419"},
        {"Smithsonian Astrophysical Observation", "SAO 69561"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.68148046),
        dec: Angle.Degrees(+37.46534541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63341"},
        {"Smithsonian Astrophysical Observation", "SAO 63276"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.69986326),
        dec: Angle.Degrees(+37.46808964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199495"},
        {"Hipparcos Number", "HIP 103352"},
        {"Geneva Identification System", "GEN# +1.00199495"},
        {"Smithsonian Astrophysical Observation", "SAO 70689"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.08594726),
        dec: Angle.Degrees(+37.46850763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198086"},
        {"Hipparcos Number", "HIP 102536"},
        {"Smithsonian Astrophysical Observation", "SAO 70484"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.68509183),
        dec: Angle.Degrees(+37.46954077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 639"},
        {"Hipparcos Number", "HIP 880"},
        {"Geneva Identification System", "GEN# +1.00000639"},
        {"Smithsonian Astrophysical Observation", "SAO 53697"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.69509815),
        dec: Angle.Degrees(+37.47386216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59509",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59509"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.07324768),
        dec: Angle.Degrees(+37.47504614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56058"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.33988435),
        dec: Angle.Degrees(+37.47522043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194335"},
        {"Hipparcos Number", "HIP 100574"},
        {"Celescope Catalog", "CEL 5046"},
        {"Geneva Identification System", "GEN# +1.00194335"},
        {"Smithsonian Astrophysical Observation", "SAO 69951"},
        {"Wilson Evans Batten Catalogue", "WEB 18171"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.93485540),
        dec: Angle.Degrees(+37.47644822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217696"},
        {"Hipparcos Number", "HIP 113741"},
        {"Geneva Identification System", "GEN# +1.00217696"},
        {"Smithsonian Astrophysical Observation", "SAO 72946"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52628821),
        dec: Angle.Degrees(+37.47708836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114888"},
        {"Smithsonian Astrophysical Observation", "SAO 73124"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.07539468),
        dec: Angle.Degrees(+37.47733725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48575"},
        {"Smithsonian Astrophysical Observation", "SAO 61746"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.61462740),
        dec: Angle.Degrees(+37.47848345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10661",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1747 AB"},
        {"Henry Draper", "HD 14016"},
        {"Hipparcos Number", "HIP 10661"},
        {"Smithsonian Astrophysical Observation", "SAO 55425"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.29958151),
        dec: Angle.Degrees(+37.48338517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96131"},
        {"Smithsonian Astrophysical Observation", "SAO 68476"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.19872971),
        dec: Angle.Degrees(+37.48399883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59887",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59887"},
        {"Geneva Identification System", "GEN# +0.03802321"},
        {"Smithsonian Astrophysical Observation", "SAO 62934"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.22908144),
        dec: Angle.Degrees(+37.48408840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10659",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1747 C"},
        {"Hipparcos Number", "HIP 10659"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)17, 11.7800),
        dec: Angle.DegreesMinutesSeconds((int)+37, (int)29, 11.400)
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
    primaryId: "HIP 74968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74968"},
        {"Smithsonian Astrophysical Observation", "SAO 64627"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.79665254),
        dec: Angle.Degrees(+37.48804638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30504"},
        {"Hipparcos Number", "HIP 22453"},
        {"Fundamental Katalog 5th Edition", "FK5 1133"},
        {"Geneva Identification System", "GEN# +1.00030504"},
        {"Smithsonian Astrophysical Observation", "SAO 57447"},
        {"Wilson Evans Batten Catalogue", "WEB 4333"},
    },
    visualMagnitude: 4.89,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.47777728),
        dec: Angle.Degrees(+37.48818131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 227049"},
        {"Hipparcos Number", "HIP 98456"},
        {"Smithsonian Astrophysical Observation", "SAO 69240"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.05685973),
        dec: Angle.Degrees(+37.48978975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150119"},
        {"Hipparcos Number", "HIP 81398"},
        {"Smithsonian Astrophysical Observation", "SAO 65437"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.36096956),
        dec: Angle.Degrees(+37.49039491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8745"},
        {"Hipparcos Number", "HIP 6752"},
        {"Geneva Identification System", "GEN# +1.00008745"},
        {"Smithsonian Astrophysical Observation", "SAO 54701"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.72422621),
        dec: Angle.Degrees(+37.49240880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79239",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79239"},
        {"Smithsonian Astrophysical Observation", "SAO 65120"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.57012933),
        dec: Angle.Degrees(+37.49283047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124102"},
        {"Hipparcos Number", "HIP 69246"},
        {"Geneva Identification System", "GEN# +1.00124102"},
        {"Smithsonian Astrophysical Observation", "SAO 63972"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.64070988),
        dec: Angle.Degrees(+37.49288574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45618",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45618"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.47294309),
        dec: Angle.Degrees(+37.49291559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61477"},
        {"Geneva Identification System", "GEN# +0.03802349"},
        {"Smithsonian Astrophysical Observation", "SAO 63090"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.95798414),
        dec: Angle.Degrees(+37.52497409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70478",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70478"},
        {"Smithsonian Astrophysical Observation", "SAO 64131"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.23740633),
        dec: Angle.Degrees(+37.49516217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92918"},
        {"Hipparcos Number", "HIP 52516"},
        {"Smithsonian Astrophysical Observation", "SAO 62222"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.782,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.06849936),
        dec: Angle.Degrees(+37.49779110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201777"},
        {"Hipparcos Number", "HIP 104550"},
        {"Smithsonian Astrophysical Observation", "SAO 71019"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.67283265),
        dec: Angle.Degrees(+37.49794751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48965",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48965"},
        {"Smithsonian Astrophysical Observation", "SAO 61794"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.83421899),
        dec: Angle.Degrees(+37.49890917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28965"},
        {"Hipparcos Number", "HIP 21387"},
        {"Smithsonian Astrophysical Observation", "SAO 57322"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.85200533),
        dec: Angle.Degrees(+37.49906379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12412"},
        {"Hipparcos Number", "HIP 9526"},
        {"Geneva Identification System", "GEN# +1.00012412"},
        {"Smithsonian Astrophysical Observation", "SAO 55212"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.62804630),
        dec: Angle.Degrees(+37.49930559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5582"},
        {"Hipparcos Number", "HIP 4534"},
        {"Geneva Identification System", "GEN# +1.00005582"},
        {"Smithsonian Astrophysical Observation", "SAO 54297"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.51093804),
        dec: Angle.Degrees(+37.49953172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27867",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27867"},
        {"Geneva Identification System", "GEN# +0.03701350"},
        {"Smithsonian Astrophysical Observation", "SAO 58545"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.44512210),
        dec: Angle.Degrees(+37.50257101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35234"},
        {"Hipparcos Number", "HIP 25320"},
        {"Smithsonian Astrophysical Observation", "SAO 57994"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.24141289),
        dec: Angle.Degrees(+37.50309637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49178"},
        {"Hipparcos Number", "HIP 32673"},
        {"Geneva Identification System", "GEN# +1.00049178"},
        {"Smithsonian Astrophysical Observation", "SAO 59506"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.22470574),
        dec: Angle.Degrees(+37.50530148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223113"},
        {"Hipparcos Number", "HIP 117268"},
        {"Smithsonian Astrophysical Observation", "SAO 73501"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.68287559),
        dec: Angle.Degrees(+37.50784931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50472",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7717 AB"},
        {"Henry Draper", "HD 89222"},
        {"Hipparcos Number", "HIP 50472"},
        {"Geneva Identification System", "GEN# +1.00089222"},
        {"Smithsonian Astrophysical Observation", "SAO 61976"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.58902735),
        dec: Angle.Degrees(+37.50829256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78074"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.11407047),
        dec: Angle.Degrees(+37.50893923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69376",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69376"},
        {"Geneva Identification System", "GEN# +0.03802525"},
        {"Smithsonian Astrophysical Observation", "SAO 63986"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.03634104),
        dec: Angle.Degrees(+37.51091967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59516",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59516"},
        {"Geneva Identification System", "GEN# +0.03802310"},
        {"Smithsonian Astrophysical Observation", "SAO 62892"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.08820047),
        dec: Angle.Degrees(+37.51100542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13909 AB"},
        {"Henry Draper", "HD 195323"},
        {"Hipparcos Number", "HIP 101062"},
        {"Geneva Identification System", "GEN# +1.00195323J"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.30641388),
        dec: Angle.Degrees(+37.51272243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49364"},
        {"Hipparcos Number", "HIP 32746"},
        {"Smithsonian Astrophysical Observation", "SAO 59518"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.43457913),
        dec: Angle.Degrees(+37.51273042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21785"},
        {"Hipparcos Number", "HIP 16461"},
        {"Geneva Identification System", "GEN# +2.13420003"},
        {"Smithsonian Astrophysical Observation", "SAO 56520"},
        {"New General Catalogue", "NGC 1342 3"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.00787854),
        dec: Angle.Degrees(+37.51477925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3390 AB"},
        {"Henry Draper", "HD 29695"},
        {"Hipparcos Number", "HIP 21878"},
        {"Smithsonian Astrophysical Observation", "SAO 57379"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.55599102),
        dec: Angle.Degrees(+37.51489293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92590",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11777 A"},
        {"Henry Draper", "HD 175081"},
        {"Hipparcos Number", "HIP 92590"},
        {"Celescope Catalog", "CEL 4661"},
        {"Geneva Identification System", "GEN# +1.00175081"},
        {"Smithsonian Astrophysical Observation", "SAO 67494"},
        {"Wilson Evans Batten Catalogue", "WEB 16017"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.00625536),
        dec: Angle.Degrees(+37.51653133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111604"},
        {"Hipparcos Number", "HIP 62641"},
        {"Geneva Identification System", "GEN# +1.00111604"},
        {"Smithsonian Astrophysical Observation", "SAO 63217"},
        {"Wilson Evans Batten Catalogue", "WEB 11115"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.54502356),
        dec: Angle.Degrees(+37.51688446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172613"},
        {"Hipparcos Number", "HIP 91490"},
        {"Smithsonian Astrophysical Observation", "SAO 67218"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.88721423),
        dec: Angle.Degrees(+37.51712251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140086"},
        {"Hipparcos Number", "HIP 76764"},
        {"Smithsonian Astrophysical Observation", "SAO 64840"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.10829468),
        dec: Angle.Degrees(+37.51712795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62647"},
        {"Hipparcos Number", "HIP 37946"},
        {"Fundamental Katalog 5th Edition", "FK5 1199"},
        {"Geneva Identification System", "GEN# +1.00062647"},
        {"Smithsonian Astrophysical Observation", "SAO 60328"},
        {"Wilson Evans Batten Catalogue", "WEB 7490"},
    },
    visualMagnitude: 5.15,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.66358038),
        dec: Angle.Degrees(+37.51736326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150510"},
        {"Hipparcos Number", "HIP 81605"},
        {"Smithsonian Astrophysical Observation", "SAO 65470"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.98626652),
        dec: Angle.Degrees(+37.51764719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105894",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14990 AB"},
        {"Henry Draper", "HD 204324"},
        {"Hipparcos Number", "HIP 105894"},
        {"Smithsonian Astrophysical Observation", "SAO 71348"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.69864793),
        dec: Angle.Degrees(+37.51768739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32560",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32560"},
        {"Cincinnati Publication", "Ci 20 398"},
        {"Geneva Identification System", "GEN# +9.80087007"},
        {"Wilson Evans Batten Catalogue", "WEB 6569"},
    },
    visualMagnitude: 12.06,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.90899326),
        dec: Angle.Degrees(+37.51813267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -225.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -935.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39982"},
        {"Hipparcos Number", "HIP 28228"},
        {"Smithsonian Astrophysical Observation", "SAO 58612"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.45969222),
        dec: Angle.Degrees(+37.51820850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33528"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.52572339),
        dec: Angle.Degrees(+37.51916906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115259"},
        {"Smithsonian Astrophysical Observation", "SAO 73185"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.17780308),
        dec: Angle.Degrees(+37.52047569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102748"},
        {"Smithsonian Astrophysical Observation", "SAO 70543"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.28507295),
        dec: Angle.Degrees(+37.52345912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112249",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112249"},
        {"Smithsonian Astrophysical Observation", "SAO 72676"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.03722286),
        dec: Angle.Degrees(+37.52396776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120004"},
        {"Hipparcos Number", "HIP 67177"},
        {"Geneva Identification System", "GEN# +1.00120004"},
        {"Smithsonian Astrophysical Observation", "SAO 63730"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.50208012),
        dec: Angle.Degrees(+37.52513373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144186"},
        {"Hipparcos Number", "HIP 78638"},
        {"Smithsonian Astrophysical Observation", "SAO 65047"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80204030),
        dec: Angle.Degrees(+37.52596483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149058"},
        {"Hipparcos Number", "HIP 80861"},
        {"Geneva Identification System", "GEN# +1.00149058"},
        {"Smithsonian Astrophysical Observation", "SAO 65353"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68248976),
        dec: Angle.Degrees(+37.52649238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77482"},
        {"Hipparcos Number", "HIP 44502"},
        {"Smithsonian Astrophysical Observation", "SAO 61229"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99911144),
        dec: Angle.Degrees(+37.52727278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155040"},
        {"Hipparcos Number", "HIP 83800"},
        {"Smithsonian Astrophysical Observation", "SAO 65805"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.89233999),
        dec: Angle.Degrees(+37.52748038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42445",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42445"},
        {"Smithsonian Astrophysical Observation", "SAO 60953"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.81278067),
        dec: Angle.Degrees(+37.52765565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111919",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16164 AB"},
        {"Aitken 2", "ADS 16164"},
        {"Henry Draper", "HD 214807"},
        {"Hipparcos Number", "HIP 111919"},
        {"Smithsonian Astrophysical Observation", "SAO 72603"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.05713509),
        dec: Angle.Degrees(+37.52790702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8428"},
        {"Hipparcos Number", "HIP 6550"},
        {"Geneva Identification System", "GEN# +1.00008428"},
        {"Smithsonian Astrophysical Observation", "SAO 54662"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.05049052),
        dec: Angle.Degrees(+37.52819370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101979"},
        {"Hipparcos Number", "HIP 57251"},
        {"Geneva Identification System", "GEN# +1.00101979"},
        {"Smithsonian Astrophysical Observation", "SAO 62679"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.08462014),
        dec: Angle.Degrees(+37.52865343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47133"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.06661552),
        dec: Angle.Degrees(+37.52952475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78938"},
        {"Hipparcos Number", "HIP 45162"},
        {"Smithsonian Astrophysical Observation", "SAO 61326"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.00482882),
        dec: Angle.Degrees(+37.53069246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100404"},
        {"Geneva Identification System", "GEN# +0.03703903"},
        {"Wilson Evans Batten Catalogue", "WEB 18123"},
    },
    visualMagnitude: 8.42,
    bvColour: 3.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.41062682),
        dec: Angle.Degrees(+37.53304965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116723"},
        {"Hipparcos Number", "HIP 65456"},
        {"Smithsonian Astrophysical Observation", "SAO 63523"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.23377459),
        dec: Angle.Degrees(+37.53386746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140847"},
        {"Hipparcos Number", "HIP 77091"},
        {"Smithsonian Astrophysical Observation", "SAO 64876"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.11986780),
        dec: Angle.Degrees(+37.53492202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1327"},
        {"Hipparcos Number", "HIP 1411"},
        {"Smithsonian Astrophysical Observation", "SAO 53787"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.41861908),
        dec: Angle.Degrees(+37.53787056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -171.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115605"},
        {"Hipparcos Number", "HIP 64854"},
        {"Geneva Identification System", "GEN# +1.00115605"},
        {"Smithsonian Astrophysical Observation", "SAO 63453"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40400404),
        dec: Angle.Degrees(+37.53890901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26702"},
        {"Hipparcos Number", "HIP 19810"},
        {"Geneva Identification System", "GEN# +1.00026702"},
        {"Smithsonian Astrophysical Observation", "SAO 57094"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.71697289),
        dec: Angle.Degrees(+37.54268034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41367",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6802 A"},
        {"Henry Draper", "HD 70987"},
        {"Hipparcos Number", "HIP 41367"},
        {"Geneva Identification System", "GEN# +1.00070987"},
        {"Smithsonian Astrophysical Observation", "SAO 60809"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.58501875),
        dec: Angle.Degrees(+37.54539765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41368",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6802 B"},
        {"Henry Draper", "HD 70987B"},
        {"Hipparcos Number", "HIP 41368"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.58768503),
        dec: Angle.Degrees(+37.54721516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49549"},
        {"Smithsonian Astrophysical Observation", "SAO 61869"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.75437926),
        dec: Angle.Degrees(+37.54898023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15082"},
        {"Hipparcos Number", "HIP 11397"},
        {"Geneva Identification System", "GEN# +1.00015082"},
        {"Renson", "Renson 3750"},
        {"Smithsonian Astrophysical Observation", "SAO 55561"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.71274665),
        dec: Angle.Degrees(+37.55050390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82939"},
        {"Hipparcos Number", "HIP 47110"},
        {"Geneva Identification System", "GEN# +1.00082939"},
        {"Smithsonian Astrophysical Observation", "SAO 61589"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.758,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.01813028),
        dec: Angle.Degrees(+37.55309624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142035"},
        {"Hipparcos Number", "HIP 77624"},
        {"Smithsonian Astrophysical Observation", "SAO 64944"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.71541759),
        dec: Angle.Degrees(+37.55342139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11216"},
        {"Hipparcos Number", "HIP 8606"},
        {"Smithsonian Astrophysical Observation", "SAO 55028"},
        {"New General Catalogue", "NGC 752 1529"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.75596486),
        dec: Angle.Degrees(+37.55420971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213422"},
        {"Hipparcos Number", "HIP 111117"},
        {"Smithsonian Astrophysical Observation", "SAO 72416"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.65190549),
        dec: Angle.Degrees(+37.55459064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 228658"},
        {"Hipparcos Number", "HIP 99898"},
        {"Geneva Identification System", "GEN# +3.49960008"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.03565338),
        dec: Angle.Degrees(+37.55641820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127030"},
        {"Hipparcos Number", "HIP 70749"},
        {"Geneva Identification System", "GEN# +1.00127030"},
        {"Smithsonian Astrophysical Observation", "SAO 64157"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.03986131),
        dec: Angle.Degrees(+37.55666041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151749"},
        {"Hipparcos Number", "HIP 82203"},
        {"Geneva Identification System", "GEN# +1.00151749"},
        {"Smithsonian Astrophysical Observation", "SAO 65559"},
    },
    visualMagnitude: 7.18,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.90736959),
        dec: Angle.Degrees(+37.56023169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 279327"},
        {"Hipparcos Number", "HIP 19026"},
        {"Smithsonian Astrophysical Observation", "SAO 56944"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.13040229),
        dec: Angle.Degrees(+37.56252003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52822"},
        {"Henry Draper 2", "HD 52823"},
        {"Hipparcos Number", "HIP 34103"},
        {"Geneva Identification System", "GEN# +1.00052822"},
        {"Smithsonian Astrophysical Observation", "SAO 59741"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.07124717),
        dec: Angle.Degrees(+37.56399059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79319",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79319"},
        {"Smithsonian Astrophysical Observation", "SAO 65128"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.81920221),
        dec: Angle.Degrees(+37.56479962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116092"},
        {"Hipparcos Number", "HIP 65128"},
        {"Geneva Identification System", "GEN# +1.00116092"},
        {"Smithsonian Astrophysical Observation", "SAO 63489"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.20137274),
        dec: Angle.Degrees(+37.56501374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161287"},
        {"Hipparcos Number", "HIP 86711"},
        {"Geneva Identification System", "GEN# +1.00161287"},
        {"Smithsonian Astrophysical Observation", "SAO 66281"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.76441331),
        dec: Angle.Degrees(+37.56967411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93521"},
        {"Hipparcos Number", "HIP 52849"},
        {"Geneva Identification System", "GEN# +1.00093521"},
        {"Smithsonian Astrophysical Observation", "SAO 62257"},
        {"Wilson Evans Batten Catalogue", "WEB 9621"},
    },
    visualMagnitude: 7.03,
    bvColour: -0.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.09796343),
        dec: Angle.Degrees(+37.57029731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183258"},
        {"Hipparcos Number", "HIP 95630"},
        {"Smithsonian Astrophysical Observation", "SAO 68330"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.77024186),
        dec: Angle.Degrees(+37.57054324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41981"},
        {"Hipparcos Number", "HIP 29238"},
        {"Geneva Identification System", "GEN# +1.00041981"},
        {"Smithsonian Astrophysical Observation", "SAO 58807"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.46736491),
        dec: Angle.Degrees(+37.57124029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124624"},
        {"Hipparcos Number", "HIP 69507"},
        {"Smithsonian Astrophysical Observation", "SAO 64001"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.44228649),
        dec: Angle.Degrees(+37.57338524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39015"},
        {"Smithsonian Astrophysical Observation", "SAO 60494"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.75901090),
        dec: Angle.Degrees(+37.57500147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60792"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.89270853),
        dec: Angle.Degrees(+37.57539946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194467"},
        {"Hipparcos Number", "HIP 100631"},
        {"Celescope Catalog", "CEL 5050"},
        {"Geneva Identification System", "GEN# +1.00194467"},
        {"Smithsonian Astrophysical Observation", "SAO 69971"},
        {"Wilson Evans Batten Catalogue", "WEB 18189"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.07525001),
        dec: Angle.Degrees(+37.57545618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111308"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.24397657),
        dec: Angle.Degrees(+37.57567759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27105",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4313 AB"},
        {"Henry Draper", "HD 38093"},
        {"Hipparcos Number", "HIP 27105"},
        {"Smithsonian Astrophysical Observation", "SAO 58386"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.21541426),
        dec: Angle.Degrees(+37.57636552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27086"},
        {"Hipparcos Number", "HIP 20085"},
        {"Smithsonian Astrophysical Observation", "SAO 57137"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.59058174),
        dec: Angle.Degrees(+37.57720824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8102 AB"},
        {"Henry Draper", "HD 97731"},
        {"Hipparcos Number", "HIP 54941"},
        {"Smithsonian Astrophysical Observation", "SAO 62460"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76291736),
        dec: Angle.Degrees(+37.57866004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22780"},
        {"Hipparcos Number", "HIP 17203"},
        {"Geneva Identification System", "GEN# +1.00022780"},
        {"Smithsonian Astrophysical Observation", "SAO 56628"},
        {"Wilson Evans Batten Catalogue", "WEB 3257"},
    },
    visualMagnitude: 5.55,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.28267183),
        dec: Angle.Degrees(+37.58026421)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76452"},
    },
    visualMagnitude: 11.22,
    bvColour: 1.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.21061285),
        dec: Angle.Degrees(+37.58060310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -275.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182354"},
        {"Hipparcos Number", "HIP 95245"},
        {"Smithsonian Astrophysical Observation", "SAO 68225"},
    },
    visualMagnitude: 6.60,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.67048435),
        dec: Angle.Degrees(+37.58119868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90384"},
        {"Smithsonian Astrophysical Observation", "SAO 66977"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.64384786),
        dec: Angle.Degrees(+37.58680679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22859"},
        {"Hipparcos Number", "HIP 17254"},
        {"Geneva Identification System", "GEN# +1.00022859"},
        {"Smithsonian Astrophysical Observation", "SAO 56637"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.43057627),
        dec: Angle.Degrees(+37.58722305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40161"},
        {"Hipparcos Number", "HIP 28300"},
        {"Smithsonian Astrophysical Observation", "SAO 58623"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.71890654),
        dec: Angle.Degrees(+37.58921639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207771"},
        {"Hipparcos Number", "HIP 107812"},
        {"Smithsonian Astrophysical Observation", "SAO 71757"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.62623333),
        dec: Angle.Degrees(+37.59010600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111869",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16154 A"},
        {"Henry Draper", "HD 214714"},
        {"Hipparcos Number", "HIP 111869"},
        {"Geneva Identification System", "GEN# +1.00214714"},
        {"Smithsonian Astrophysical Observation", "SAO 72581"},
        {"Wilson Evans Batten Catalogue", "WEB 19982"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.89301814),
        dec: Angle.Degrees(+37.59281397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224069"},
        {"Hipparcos Number", "HIP 117890"},
        {"Smithsonian Astrophysical Observation", "SAO 73605"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.70041648),
        dec: Angle.Degrees(+37.59441241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91973",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11639 D"},
        {"Henry Draper", "HD 173649"},
        {"Hipparcos Number", "HIP 91973"},
        {"Geneva Identification System", "GEN# +1.00173649"},
        {"Smithsonian Astrophysical Observation", "SAO 67324"},
        {"Wilson Evans Batten Catalogue", "WEB 15842"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.20079095),
        dec: Angle.Degrees(+37.59456466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92702"},
        {"Smithsonian Astrophysical Observation", "SAO 67529"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.34051770),
        dec: Angle.Degrees(+37.59512962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84700"},
        {"Hipparcos Number", "HIP 48070"},
        {"Smithsonian Astrophysical Observation", "SAO 61687"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.99232137),
        dec: Angle.Degrees(+37.59520682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43437"},
        {"Smithsonian Astrophysical Observation", "SAO 61078"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.70437301),
        dec: Angle.Degrees(+37.59985906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79057"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.712,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.05226789),
        dec: Angle.Degrees(+37.60014697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65837"},
        {"Fundamental Katalog 5th Edition", "FK5 5190"},
        {"Geneva Identification System", "GEN# +0.03802451"},
        {"Smithsonian Astrophysical Observation", "SAO 63567"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.43547962),
        dec: Angle.Degrees(+37.60139493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8873"},
        {"Hipparcos Number", "HIP 6855"},
        {"Smithsonian Astrophysical Observation", "SAO 54718"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.03322619),
        dec: Angle.Degrees(+37.60301123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76944"},
        {"Hipparcos Number", "HIP 44231"},
        {"Smithsonian Astrophysical Observation", "SAO 61191"},
        {"Wilson Evans Batten Catalogue", "WEB 8487"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.12837461),
        dec: Angle.Degrees(+37.60435051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48346"},
        {"Geneva Identification System", "GEN# +0.03802075"},
        {"Smithsonian Astrophysical Observation", "SAO 61713"},
        {"Wilson Evans Batten Catalogue", "WEB 9019"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.82916632),
        dec: Angle.Degrees(+37.60442874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223016"},
        {"Hipparcos Number", "HIP 117200"},
        {"Smithsonian Astrophysical Observation", "SAO 73486"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46336733),
        dec: Angle.Degrees(+37.60484650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91971",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11639 A"},
        {"Henry Draper", "HD 173648"},
        {"Hipparcos Number", "HIP 91971"},
        {"Celescope Catalog", "CEL 4648"},
        {"Geneva Identification System", "GEN# +1.00173648"},
        {"Renson", "Renson 48650"},
        {"Smithsonian Astrophysical Observation", "SAO 67321"},
        {"Wilson Evans Batten Catalogue", "WEB 15841"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.19306613),
        dec: Angle.Degrees(+37.60505025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9763"},
        {"Hipparcos Number", "HIP 7465"},
        {"Smithsonian Astrophysical Observation", "SAO 54821"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.04156428),
        dec: Angle.Degrees(+37.60749276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125607"},
        {"Hipparcos Number", "HIP 70003"},
        {"Geneva Identification System", "GEN# +1.00125607"},
        {"Smithsonian Astrophysical Observation", "SAO 64066"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.86351718),
        dec: Angle.Degrees(+37.61004748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156650"},
        {"Hipparcos Number", "HIP 84562"},
        {"Smithsonian Astrophysical Observation", "SAO 65912"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.29626245),
        dec: Angle.Degrees(+37.61097925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25454"},
        {"Hipparcos Number", "HIP 18987"},
        {"Geneva Identification System", "GEN# +1.00025454"},
        {"Smithsonian Astrophysical Observation", "SAO 56939"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.02911809),
        dec: Angle.Degrees(+37.61101821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67269"},
        {"Smithsonian Astrophysical Observation", "SAO 63743"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.80355541),
        dec: Angle.Degrees(+37.61232930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109237",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109237"},
        {"Smithsonian Astrophysical Observation", "SAO 72052"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.95055047),
        dec: Angle.Degrees(+37.61701479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64717",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64717"},
        {"Smithsonian Astrophysical Observation", "SAO 63434"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.96691467),
        dec: Angle.Degrees(+37.61702981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34891",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34891"},
        {"Smithsonian Astrophysical Observation", "SAO 59891"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.28240113),
        dec: Angle.Degrees(+37.62139691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196408"},
        {"Hipparcos Number", "HIP 101632"},
        {"Geneva Identification System", "GEN# +1.00196408"},
        {"Smithsonian Astrophysical Observation", "SAO 70247"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.98169787),
        dec: Angle.Degrees(+37.62406488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59873",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59873"},
        {"Geneva Identification System", "GEN# +0.03802320"},
        {"Smithsonian Astrophysical Observation", "SAO 62931"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.18550760),
        dec: Angle.Degrees(+37.62645947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3005"},
        {"Smithsonian Astrophysical Observation", "SAO 54045"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.55512593),
        dec: Angle.Degrees(+37.63103601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4524"},
        {"Hipparcos Number", "HIP 3714"},
        {"Smithsonian Astrophysical Observation", "SAO 54148"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.92095429),
        dec: Angle.Degrees(+37.63112607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 26675"},
        {"Wilson Evans Batten Catalogue", "WEB 5258"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.03287641),
        dec: Angle.Degrees(+37.63630263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63259"},
        {"Hipparcos Number", "HIP 38199"},
        {"Geneva Identification System", "GEN# +1.00063259"},
        {"Smithsonian Astrophysical Observation", "SAO 60363"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.39190404),
        dec: Angle.Degrees(+37.63650276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43094"},
        {"Hipparcos Number", "HIP 29767"},
        {"Smithsonian Astrophysical Observation", "SAO 58915"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.02531605),
        dec: Angle.Degrees(+37.63668979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66194"},
        {"Geneva Identification System", "GEN# +0.03802457"},
        {"Smithsonian Astrophysical Observation", "SAO 63612"},
        {"Wilson Evans Batten Catalogue", "WEB 11695"},
    },
    visualMagnitude: 9.94,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.52322560),
        dec: Angle.Degrees(+37.63775436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12859"},
        {"Hipparcos Number", "HIP 9861"},
        {"Smithsonian Astrophysical Observation", "SAO 55271"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.71329809),
        dec: Angle.Degrees(+37.63874013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200947"},
        {"Hipparcos Number", "HIP 104104"},
        {"Renson", "Renson 56033"},
        {"Smithsonian Astrophysical Observation", "SAO 70889"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.36987361),
        dec: Angle.Degrees(+37.64001444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180285"},
        {"Hipparcos Number", "HIP 94531"},
        {"Geneva Identification System", "GEN# +1.00180285"},
        {"Smithsonian Astrophysical Observation", "SAO 68021"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.58807310),
        dec: Angle.Degrees(+37.64124565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52517",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52517"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.07072068),
        dec: Angle.Degrees(+37.64250420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55030"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.98473131),
        dec: Angle.Degrees(+37.64322663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62487"},
        {"Hipparcos Number", "HIP 37869"},
        {"Smithsonian Astrophysical Observation", "SAO 60321"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.43967104),
        dec: Angle.Degrees(+37.64471510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87340"},
        {"Hipparcos Number", "HIP 49424"},
        {"Smithsonian Astrophysical Observation", "SAO 61848"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.32598682),
        dec: Angle.Degrees(+37.64497695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55413"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.22890291),
        dec: Angle.Degrees(+37.64548169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53565"},
        {"Fundamental Katalog 5th Edition", "FK5 4966"},
        {"Geneva Identification System", "GEN# +0.03802197"},
        {"Smithsonian Astrophysical Observation", "SAO 62327"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.36662693),
        dec: Angle.Degrees(+37.64847173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24724",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3871 AB"},
        {"Henry Draper", "HD 34302"},
        {"Hipparcos Number", "HIP 24724"},
        {"Celescope Catalog", "CEL 593"},
        {"Geneva Identification System", "GEN# +1.00034302"},
        {"Smithsonian Astrophysical Observation", "SAO 57850"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54240723),
        dec: Angle.Degrees(+37.65014217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15723 A"},
        {"Henry Draper", "HD 210772"},
        {"Hipparcos Number", "HIP 109587"},
        {"Geneva Identification System", "GEN# +1.00210772"},
        {"Smithsonian Astrophysical Observation", "SAO 72119"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.99443085),
        dec: Angle.Degrees(+37.65116662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3275 AB"},
        {"Henry Draper", "HD 28544"},
        {"Hipparcos Number", "HIP 21117"},
        {"Smithsonian Astrophysical Observation", "SAO 57282"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.88979681),
        dec: Angle.Degrees(+37.65244742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109588",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15723 B"},
        {"Hipparcos Number", "HIP 109588"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.831,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.99826973),
        dec: Angle.Degrees(+37.65246006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116781",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16913 A"},
        {"Henry Draper", "HD 222399"},
        {"Hipparcos Number", "HIP 116781"},
        {"Geneva Identification System", "GEN# +1.00222399"},
        {"Smithsonian Astrophysical Observation", "SAO 73422"},
        {"Wilson Evans Batten Catalogue", "WEB 20608"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.01176265),
        dec: Angle.Degrees(+37.65283835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200207"},
        {"Hipparcos Number", "HIP 103706"},
        {"Geneva Identification System", "GEN# +1.00200207"},
        {"Smithsonian Astrophysical Observation", "SAO 70788"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.22235447),
        dec: Angle.Degrees(+37.65309872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7306"},
        {"Hipparcos Number", "HIP 5749"},
        {"Smithsonian Astrophysical Observation", "SAO 54530"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.45901966),
        dec: Angle.Degrees(+37.65375036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200466"},
        {"Hipparcos Number", "HIP 103824"},
        {"Smithsonian Astrophysical Observation", "SAO 70816"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.59151257),
        dec: Angle.Degrees(+37.65440838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207263"},
        {"Hipparcos Number", "HIP 107532"},
        {"Smithsonian Astrophysical Observation", "SAO 71691"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.69317111),
        dec: Angle.Degrees(+37.65800225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125375"},
        {"Hipparcos Number", "HIP 69878"},
        {"Geneva Identification System", "GEN# +1.00125375"},
        {"Smithsonian Astrophysical Observation", "SAO 64054"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.49656544),
        dec: Angle.Degrees(+37.65836493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168620"},
        {"Hipparcos Number", "HIP 89765"},
        {"Smithsonian Astrophysical Observation", "SAO 66854"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.76838655),
        dec: Angle.Degrees(+37.65839364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187036"},
        {"Hipparcos Number", "HIP 97284"},
        {"Smithsonian Astrophysical Observation", "SAO 68826"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.57485839),
        dec: Angle.Degrees(+37.65842887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80100",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80100"},
        {"Smithsonian Astrophysical Observation", "SAO 65243"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.26851196),
        dec: Angle.Degrees(+37.65891494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38199"},
        {"Hipparcos Number", "HIP 27189"},
        {"Geneva Identification System", "GEN# +1.00038199"},
        {"Smithsonian Astrophysical Observation", "SAO 58406"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.44951944),
        dec: Angle.Degrees(+37.65902509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89221",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89221"},
        {"Smithsonian Astrophysical Observation", "SAO 66749"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.11184693),
        dec: Angle.Degrees(+37.65932082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20849"},
        {"Hipparcos Number", "HIP 15750"},
        {"Smithsonian Astrophysical Observation", "SAO 56392"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.72802890),
        dec: Angle.Degrees(+37.66020351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203940"},
        {"Hipparcos Number", "HIP 105676"},
        {"Geneva Identification System", "GEN# +1.00203940"},
        {"Smithsonian Astrophysical Observation", "SAO 71288"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.06721167),
        dec: Angle.Degrees(+37.66228939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 145.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57104"},
        {"Hipparcos Number", "HIP 35662"},
        {"Smithsonian Astrophysical Observation", "SAO 59999"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.37873033),
        dec: Angle.Degrees(+37.66304093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34741",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34741"},
        {"Smithsonian Astrophysical Observation", "SAO 59865"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.89011294),
        dec: Angle.Degrees(+37.66371184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209462"},
        {"Hipparcos Number", "HIP 108830"},
        {"Smithsonian Astrophysical Observation", "SAO 71975"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.70695957),
        dec: Angle.Degrees(+37.66771688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10617"},
        {"Hipparcos Number", "HIP 8123"},
        {"Smithsonian Astrophysical Observation", "SAO 54944"},
    },
    visualMagnitude: 7.19,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.09648853),
        dec: Angle.Degrees(+37.66840205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130616"},
        {"Hipparcos Number", "HIP 72393"},
        {"Smithsonian Astrophysical Observation", "SAO 64333"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.01976041),
        dec: Angle.Degrees(+37.67006064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171912"},
        {"Hipparcos Number", "HIP 91148"},
        {"Geneva Identification System", "GEN# +1.00171912"},
        {"Smithsonian Astrophysical Observation", "SAO 67150"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.92326837),
        dec: Angle.Degrees(+37.67023183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156052"},
        {"Hipparcos Number", "HIP 84283"},
        {"Smithsonian Astrophysical Observation", "SAO 65879"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.43942484),
        dec: Angle.Degrees(+37.67078710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8029"},
        {"Hipparcos Number", "HIP 6260"},
        {"Smithsonian Astrophysical Observation", "SAO 54612"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.07647156),
        dec: Angle.Degrees(+37.67237780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51665",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7827 A"},
        {"Henry Draper", "HD 91313"},
        {"Henry Draper 2", "HD 91313A"},
        {"Hipparcos Number", "HIP 51665"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.32111686),
        dec: Angle.Degrees(+37.67377730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19993"},
        {"Hipparcos Number", "HIP 15056"},
        {"Smithsonian Astrophysical Observation", "SAO 56273"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.50565725),
        dec: Angle.Degrees(+37.67391627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111636",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16109 A"},
        {"Hipparcos Number", "HIP 111636"},
        {"Smithsonian Astrophysical Observation", "SAO 72539"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.23096235),
        dec: Angle.Degrees(+37.67558620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34921"},
        {"Hipparcos Number", "HIP 25114"},
        {"Celescope Catalog", "CEL 646"},
        {"Geneva Identification System", "GEN# +1.00034921"},
        {"Smithsonian Astrophysical Observation", "SAO 57950"},
        {"Wilson Evans Batten Catalogue", "WEB 4870"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.64679394),
        dec: Angle.Degrees(+37.67602078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112513"},
        {"Renson", "Renson 59620"},
        {"Smithsonian Astrophysical Observation", "SAO 72723"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.85980540),
        dec: Angle.Degrees(+37.67686312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186438"},
        {"Hipparcos Number", "HIP 96997"},
        {"Geneva Identification System", "GEN# +1.00186438"},
        {"Smithsonian Astrophysical Observation", "SAO 68739"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.72050681),
        dec: Angle.Degrees(+37.67818485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86879",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86879"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.25700372),
        dec: Angle.Degrees(+37.67969475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57731",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57731"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.57943597),
        dec: Angle.Degrees(+37.68102368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193076"},
        {"Hipparcos Number", "HIP 99980"},
        {"Geneva Identification System", "GEN# +3.49960064"},
        {"Smithsonian Astrophysical Observation", "SAO 69754"},
        {"Wilson Evans Batten Catalogue", "WEB 17995"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.24535653),
        dec: Angle.Degrees(+37.68143135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67562"},
    },
    visualMagnitude: 11.08,
    bvColour: 0.861,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.66555735),
        dec: Angle.Degrees(+37.68175068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33105"},
        {"Hipparcos Number", "HIP 24013"},
        {"Geneva Identification System", "GEN# +1.00033105"},
        {"Smithsonian Astrophysical Observation", "SAO 57692"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.42816116),
        dec: Angle.Degrees(+37.68273714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185816"},
        {"Hipparcos Number", "HIP 96695"},
        {"Celescope Catalog", "CEL 4811"},
        {"Geneva Identification System", "GEN# +1.00185816"},
        {"Smithsonian Astrophysical Observation", "SAO 68645"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.87062457),
        dec: Angle.Degrees(+37.68368352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186429"},
        {"Hipparcos Number", "HIP 96986"},
        {"Geneva Identification System", "GEN# +1.00186429"},
        {"Smithsonian Astrophysical Observation", "SAO 68737"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.70235164),
        dec: Angle.Degrees(+37.68681359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29662"},
        {"Geneva Identification System", "GEN# +9.80098056"},
    },
    visualMagnitude: 11.34,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.73354515),
        dec: Angle.Degrees(+37.87214835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218714"},
        {"Hipparcos Number", "HIP 114369"},
        {"Geneva Identification System", "GEN# +1.00218714"},
        {"Smithsonian Astrophysical Observation", "SAO 73048"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.45360591),
        dec: Angle.Degrees(+37.68720201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112842",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112842"},
        {"Smithsonian Astrophysical Observation", "SAO 72781"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.78020404),
        dec: Angle.Degrees(+37.68735747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134712"},
        {"Hipparcos Number", "HIP 74225"},
        {"Smithsonian Astrophysical Observation", "SAO 64530"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.53165076),
        dec: Angle.Degrees(+37.69090241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 829"},
        {"Hipparcos Number", "HIP 1030"},
        {"Geneva Identification System", "GEN# +1.00000829"},
        {"Smithsonian Astrophysical Observation", "SAO 53725"},
        {"Wilson Evans Batten Catalogue", "WEB 177"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.20935172),
        dec: Angle.Degrees(+37.69366311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58489"},
        {"Geneva Identification System", "GEN# +0.03802295"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.92527982),
        dec: Angle.Degrees(+37.69754155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97155"},
        {"Hipparcos Number", "HIP 54666"},
        {"Smithsonian Astrophysical Observation", "SAO 62441"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.85472791),
        dec: Angle.Degrees(+37.69829985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14585"},
        {"Hipparcos Number", "HIP 11063"},
        {"Geneva Identification System", "GEN# +1.00014585"},
        {"Smithsonian Astrophysical Observation", "SAO 55494"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.59791652),
        dec: Angle.Degrees(+37.69879320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98528",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13262 AB"},
        {"Henry Draper", "HD 189901"},
        {"Hipparcos Number", "HIP 98528"},
        {"Celescope Catalog", "CEL 4911"},
        {"Geneva Identification System", "GEN# +1.00189901J"},
        {"Smithsonian Astrophysical Observation", "SAO 69258"},
        {"Wilson Evans Batten Catalogue", "WEB 17405"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.24837300),
        dec: Angle.Degrees(+37.69892189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13262 C"},
        {"Hipparcos Number", "HIP 98534"},
        {"Smithsonian Astrophysical Observation", "SAO 69261"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.25593615),
        dec: Angle.Degrees(+37.69901623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215327"},
        {"Hipparcos Number", "HIP 112224"},
        {"Geneva Identification System", "GEN# +1.00215327"},
        {"Renson", "Renson 59490"},
        {"Smithsonian Astrophysical Observation", "SAO 72670"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.94358177),
        dec: Angle.Degrees(+37.69960287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118311"},
        {"Hipparcos Number", "HIP 66327"},
        {"Geneva Identification System", "GEN# +1.00118311"},
        {"Smithsonian Astrophysical Observation", "SAO 63632"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.89121798),
        dec: Angle.Degrees(+37.70269442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8540"},
        {"Hipparcos Number", "HIP 6625"},
        {"Geneva Identification System", "GEN# +1.00008540"},
        {"Smithsonian Astrophysical Observation", "SAO 54676"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.25350166),
        dec: Angle.Degrees(+37.70350836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162752"},
        {"Hipparcos Number", "HIP 87349"},
        {"Geneva Identification System", "GEN# +1.00162752"},
        {"Smithsonian Astrophysical Observation", "SAO 66383"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.72965032),
        dec: Angle.Degrees(+37.70488927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209542"},
        {"Hipparcos Number", "HIP 108881"},
        {"Smithsonian Astrophysical Observation", "SAO 71985"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.84250209),
        dec: Angle.Degrees(+37.70617488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15828 D"},
        {"Hipparcos Number", "HIP 110173"},
    },
    visualMagnitude: 11.28,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.73861083),
        dec: Angle.Degrees(+37.70675969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53299"},
        {"Smithsonian Astrophysical Observation", "SAO 62301"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.51963924),
        dec: Angle.Degrees(+37.71128405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50967",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50967"},
        {"Smithsonian Astrophysical Observation", "SAO 62022"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.15768913),
        dec: Angle.Degrees(+37.71147889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26421"},
        {"Hipparcos Number", "HIP 19631"},
        {"Geneva Identification System", "GEN# +1.00026421"},
        {"Smithsonian Astrophysical Observation", "SAO 57063"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.09525944),
        dec: Angle.Degrees(+37.71184965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39112",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39112"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.03066534),
        dec: Angle.Degrees(+37.71253443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8374"},
        {"Hipparcos Number", "HIP 6514"},
        {"Fundamental Katalog 5th Edition", "FK5 2093"},
        {"Geneva Identification System", "GEN# +1.00008374"},
        {"Renson", "Renson 2020"},
        {"Smithsonian Astrophysical Observation", "SAO 54655"},
        {"Wilson Evans Batten Catalogue", "WEB 1437"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.91898254),
        dec: Angle.Degrees(+37.71499034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31454",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5208 A"},
        {"Henry Draper", "HD 46482"},
        {"Hipparcos Number", "HIP 31454"},
        {"Smithsonian Astrophysical Observation", "SAO 59259"},
    },
    visualMagnitude: 7.01,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.84178163),
        dec: Angle.Degrees(+37.71538829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120893"},
        {"Hipparcos Number", "HIP 67631"},
        {"Geneva Identification System", "GEN# +1.00120893"},
        {"Smithsonian Astrophysical Observation", "SAO 63787"},
        {"Wilson Evans Batten Catalogue", "WEB 11894"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.86274544),
        dec: Angle.Degrees(+37.71887815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65500",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65500"},
        {"Smithsonian Astrophysical Observation", "SAO 63531"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.36868770),
        dec: Angle.Degrees(+37.71928574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29759",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29759"},
        {"Geneva Identification System", "GEN# +0.03701458"},
        {"Smithsonian Astrophysical Observation", "SAO 58912"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.00612259),
        dec: Angle.Degrees(+37.72273393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33903",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33903"},
        {"Smithsonian Astrophysical Observation", "SAO 59706"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.55147676),
        dec: Angle.Degrees(+37.72360467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7019"},
        {"Hipparcos Number", "HIP 5550"},
        {"Celescope Catalog", "CEL 125"},
        {"Geneva Identification System", "GEN# +1.00007019"},
        {"Smithsonian Astrophysical Observation", "SAO 54494"},
        {"Wilson Evans Batten Catalogue", "WEB 1240"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.79287081),
        dec: Angle.Degrees(+37.72413814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60614",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60614"},
    },
    visualMagnitude: 11.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.34627317),
        dec: Angle.Degrees(+37.72475469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63971"},
        {"Hipparcos Number", "HIP 38507"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.28902712),
        dec: Angle.Degrees(+37.72483068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99403"},
        {"Hipparcos Number", "HIP 55836"},
        {"Smithsonian Astrophysical Observation", "SAO 62553"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.66623875),
        dec: Angle.Degrees(+37.72507316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35276"},
        {"Smithsonian Astrophysical Observation", "SAO 59944"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32243733),
        dec: Angle.Degrees(+37.72534564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187374"},
        {"Hipparcos Number", "HIP 97435"},
        {"Smithsonian Astrophysical Observation", "SAO 68880"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.05041727),
        dec: Angle.Degrees(+37.72540137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
