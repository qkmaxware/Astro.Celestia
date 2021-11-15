using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_21() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166199"},
        {"Hipparcos Number", "HIP 89167"},
        {"Smithsonian Astrophysical Observation", "SAO 228785"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.95165349),
        dec: Angle.Degrees(-46.04834382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116715"},
        {"Hipparcos Number", "HIP 65549"},
        {"Smithsonian Astrophysical Observation", "SAO 224139"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.56028883),
        dec: Angle.Degrees(-46.04805470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50787"},
        {"Hipparcos Number", "HIP 32991"},
        {"Geneva Identification System", "GEN# +1.00050787"},
        {"Smithsonian Astrophysical Observation", "SAO 218270"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.09879969),
        dec: Angle.Degrees(-46.04799911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81136"},
        {"Hipparcos Number", "HIP 45962"},
        {"Fundamental Katalog 5th Edition", "FK5 2746"},
        {"Geneva Identification System", "GEN# +1.00081136"},
        {"Smithsonian Astrophysical Observation", "SAO 221109"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.59997928),
        dec: Angle.Degrees(-46.04750246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185729"},
        {"Hipparcos Number", "HIP 96973"},
        {"Smithsonian Astrophysical Observation", "SAO 229822"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.67257978),
        dec: Angle.Degrees(-46.04714679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119278"},
        {"Hipparcos Number", "HIP 66950"},
        {"Geneva Identification System", "GEN# +1.00119278"},
        {"Smithsonian Astrophysical Observation", "SAO 224362"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.83034106),
        dec: Angle.Degrees(-46.04643571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140502"},
        {"Hipparcos Number", "HIP 77209"},
        {"Smithsonian Astrophysical Observation", "SAO 226161"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.46841457),
        dec: Angle.Degrees(-46.04515159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30705"},
        {"Hipparcos Number", "HIP 22274"},
        {"Smithsonian Astrophysical Observation", "SAO 216997"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.94152313),
        dec: Angle.Degrees(-46.04371869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132119"},
        {"Hipparcos Number", "HIP 73318"},
        {"Fundamental Katalog 5th Edition", "FK5 5329"},
        {"Smithsonian Astrophysical Observation", "SAO 225338"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73623427),
        dec: Angle.Degrees(-46.04366786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160917"},
        {"Hipparcos Number", "HIP 86850"},
        {"Celescope Catalog", "CEL 4561"},
        {"Geneva Identification System", "GEN# +1.00160917"},
        {"Smithsonian Astrophysical Observation", "SAO 228360"},
    },
    visualMagnitude: 6.71,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.18262878),
        dec: Angle.Degrees(-46.04258921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75063"},
        {"Hipparcos Number", "HIP 43023"},
        {"Celescope Catalog", "CEL 2878"},
        {"Geneva Identification System", "GEN# +1.00075063"},
        {"Smithsonian Astrophysical Observation", "SAO 220422"},
        {"Wilson Evans Batten Catalogue", "WEB 8312"},
    },
    visualMagnitude: 3.87,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.50689464),
        dec: Angle.Degrees(-46.04153920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205580"},
        {"Hipparcos Number", "HIP 106773"},
        {"Smithsonian Astrophysical Observation", "SAO 230761"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.41837562),
        dec: Angle.Degrees(-46.04147927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329832"},
        {"Hipparcos Number", "HIP 84654"},
    },
    visualMagnitude: 10.36,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.59506920),
        dec: Angle.Degrees(-46.03841697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158476"},
        {"Hipparcos Number", "HIP 85788"},
        {"Geneva Identification System", "GEN# +1.00158476J"},
        {"Smithsonian Astrophysical Observation", "SAO 228075"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.805,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.95456928),
        dec: Angle.Degrees(-46.03677640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50945"},
        {"Hipparcos Number", "HIP 33052"},
        {"Smithsonian Astrophysical Observation", "SAO 218283"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.27387158),
        dec: Angle.Degrees(-46.03614948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168474"},
        {"Hipparcos Number", "HIP 90020"},
        {"Geneva Identification System", "GEN# +1.00168474"},
        {"Smithsonian Astrophysical Observation", "SAO 228950"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.52935331),
        dec: Angle.Degrees(-46.03528928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113766"},
        {"Hipparcos Number", "HIP 63975"},
        {"Smithsonian Astrophysical Observation", "SAO 223904"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.64943694),
        dec: Angle.Degrees(-46.03385090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1066"},
        {"Hipparcos Number", "HIP 1181"},
        {"Smithsonian Astrophysical Observation", "SAO 215018"},
    },
    visualMagnitude: 7.13,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.68436900),
        dec: Angle.Degrees(-46.03345890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184781"},
        {"Hipparcos Number", "HIP 96597"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.54838328),
        dec: Angle.Degrees(-46.03300072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -185.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177170"},
        {"Hipparcos Number", "HIP 93771"},
        {"Geneva Identification System", "GEN# +1.00177170"},
        {"Smithsonian Astrophysical Observation", "SAO 229484"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.44828103),
        dec: Angle.Degrees(-46.03046223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113312"},
        {"Hipparcos Number", "HIP 63711"},
        {"Fundamental Katalog 5th Edition", "FK5 5154"},
        {"Smithsonian Astrophysical Observation", "SAO 223868"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.84758910),
        dec: Angle.Degrees(-46.02934628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328176"},
        {"Hipparcos Number", "HIP 80424"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.23714637),
        dec: Angle.Degrees(-46.02898626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 191",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 191"},
        {"Geneva Identification System", "GEN# +6.20145149"},
    },
    visualMagnitude: 12.43,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.61228711),
        dec: Angle.Degrees(-46.02884131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 192.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86864"},
        {"Hipparcos Number", "HIP 49027"},
        {"Smithsonian Astrophysical Observation", "SAO 221684"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.04578497),
        dec: Angle.Degrees(-46.02863804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118962"},
        {"Hipparcos Number", "HIP 66782"},
        {"Smithsonian Astrophysical Observation", "SAO 224333"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.30656019),
        dec: Angle.Degrees(-46.02824918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37447"},
        {"Hipparcos Number", "HIP 26318"},
        {"Smithsonian Astrophysical Observation", "SAO 217423"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.07225295),
        dec: Angle.Degrees(-46.02296364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164324"},
        {"Hipparcos Number", "HIP 88375"},
        {"Smithsonian Astrophysical Observation", "SAO 228649"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.69306100),
        dec: Angle.Degrees(-46.02224122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186738"},
        {"Hipparcos Number", "HIP 97444"},
        {"Smithsonian Astrophysical Observation", "SAO 229871"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.08821184),
        dec: Angle.Degrees(-46.01982892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78527"},
        {"Hipparcos Number", "HIP 44747"},
        {"Smithsonian Astrophysical Observation", "SAO 220866"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.78966196),
        dec: Angle.Degrees(-46.01850965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155495"},
        {"Hipparcos Number", "HIP 84313"},
        {"Geneva Identification System", "GEN# +1.00155495"},
        {"Smithsonian Astrophysical Observation", "SAO 227728"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.55859797),
        dec: Angle.Degrees(-46.01800929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125627"},
        {"Hipparcos Number", "HIP 70210"},
        {"Smithsonian Astrophysical Observation", "SAO 224864"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.47267420),
        dec: Angle.Degrees(-46.01536632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102769"},
        {"Hipparcos Number", "HIP 57682"},
        {"Geneva Identification System", "GEN# +1.00102769"},
        {"Smithsonian Astrophysical Observation", "SAO 223044"},
        {"Wilson Evans Batten Catalogue", "WEB 10359"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.45335859),
        dec: Angle.Degrees(-46.01493018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59030"},
        {"Hipparcos Number", "HIP 36076"},
        {"Smithsonian Astrophysical Observation", "SAO 218718"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.50403674),
        dec: Angle.Degrees(-46.01397195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41133"},
        {"Hipparcos Number", "HIP 28483"},
        {"Smithsonian Astrophysical Observation", "SAO 217670"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.20255348),
        dec: Angle.Degrees(-46.01276887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196049"},
        {"Hipparcos Number", "HIP 101683"},
        {"Smithsonian Astrophysical Observation", "SAO 230293"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.15737142),
        dec: Angle.Degrees(-46.01186667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10521"},
        {"Hipparcos Number", "HIP 7898"},
        {"Geneva Identification System", "GEN# +1.00010521"},
        {"Smithsonian Astrophysical Observation", "SAO 215618"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39687369),
        dec: Angle.Degrees(-46.00746501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65621"},
        {"Hipparcos Number", "HIP 38889"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.37710973),
        dec: Angle.Degrees(-46.00719658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13390"},
        {"Hipparcos Number", "HIP 10073"},
        {"Smithsonian Astrophysical Observation", "SAO 215791"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40047134),
        dec: Angle.Degrees(-46.00716165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28896"},
        {"Hipparcos Number", "HIP 21072"},
        {"Smithsonian Astrophysical Observation", "SAO 216853"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.75299325),
        dec: Angle.Degrees(-46.00273864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217844"},
        {"Hipparcos Number", "HIP 113915"},
        {"Geneva Identification System", "GEN# +1.00217844"},
        {"Smithsonian Astrophysical Observation", "SAO 231421"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.02536322),
        dec: Angle.Degrees(-46.00055276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15339"},
        {"Hipparcos Number", "HIP 11388"},
        {"Geneva Identification System", "GEN# +1.00015339"},
        {"Smithsonian Astrophysical Observation", "SAO 215905"},
        {"Wilson Evans Batten Catalogue", "WEB 2379"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.68861863),
        dec: Angle.Degrees(-45.99988472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49355"},
        {"Hipparcos Number", "HIP 32395"},
        {"Geneva Identification System", "GEN# +1.00049355"},
        {"Smithsonian Astrophysical Observation", "SAO 218178"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.45192991),
        dec: Angle.Degrees(-45.99773714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84173"},
        {"Hipparcos Number", "HIP 47566"},
        {"Fundamental Katalog 5th Edition", "FK5 4861"},
        {"Geneva Identification System", "GEN# +1.00084173"},
        {"Smithsonian Astrophysical Observation", "SAO 221408"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.47490602),
        dec: Angle.Degrees(-45.99669658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137324"},
        {"Hipparcos Number", "HIP 75627"},
        {"Smithsonian Astrophysical Observation", "SAO 225796"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.78377916),
        dec: Angle.Degrees(-45.99668487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91304"},
        {"Hipparcos Number", "HIP 51534"},
        {"Geneva Identification System", "GEN# +1.00091304"},
        {"Smithsonian Astrophysical Observation", "SAO 222119"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.89015975),
        dec: Angle.Degrees(-45.99605510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67416"},
        {"Hipparcos Number", "HIP 39623"},
        {"Geneva Identification System", "GEN# +1.00067416"},
        {"Smithsonian Astrophysical Observation", "SAO 219408"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.45199616),
        dec: Angle.Degrees(-45.99598674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17928"},
        {"Hipparcos Number", "HIP 13304"},
        {"Smithsonian Astrophysical Observation", "SAO 216072"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.80350057),
        dec: Angle.Degrees(-45.99443541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19604"},
        {"Hipparcos Number", "HIP 14525"},
        {"Smithsonian Astrophysical Observation", "SAO 216174"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.89399548),
        dec: Angle.Degrees(-45.99172525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145812"},
        {"Hipparcos Number", "HIP 79628"},
        {"Geneva Identification System", "GEN# +1.00145812"},
        {"Smithsonian Astrophysical Observation", "SAO 226596"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.73449532),
        dec: Angle.Degrees(-45.99153478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216291"},
        {"Hipparcos Number", "HIP 112939"},
        {"Geneva Identification System", "GEN# +1.00216291"},
        {"Smithsonian Astrophysical Observation", "SAO 231334"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.11022984),
        dec: Angle.Degrees(-45.99138542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127923"},
        {"Hipparcos Number", "HIP 71346"},
        {"Smithsonian Astrophysical Observation", "SAO 225043"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.86166802),
        dec: Angle.Degrees(-45.99030497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124254"},
        {"Hipparcos Number", "HIP 69489"},
        {"Geneva Identification System", "GEN# +1.00124254"},
        {"Smithsonian Astrophysical Observation", "SAO 224774"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.41017572),
        dec: Angle.Degrees(-45.98636123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204944"},
        {"Hipparcos Number", "HIP 106421"},
        {"Smithsonian Astrophysical Observation", "SAO 230736"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.33587172),
        dec: Angle.Degrees(-45.98553866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173380"},
        {"Hipparcos Number", "HIP 92169"},
        {"Geneva Identification System", "GEN# +1.00173380"},
        {"Smithsonian Astrophysical Observation", "SAO 229274"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.77532579),
        dec: Angle.Degrees(-45.98485216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152853"},
        {"Hipparcos Number", "HIP 83039"},
        {"Celescope Catalog", "CEL 4469"},
        {"Geneva Identification System", "GEN# +2.62500001"},
        {"Smithsonian Astrophysical Observation", "SAO 227500"},
        {"New General Catalogue", "NGC 6250 1"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53303563),
        dec: Angle.Degrees(-45.98234347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190015"},
        {"Hipparcos Number", "HIP 98895"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.24064592),
        dec: Angle.Degrees(-45.98119440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86437"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.92230194),
        dec: Angle.Degrees(-45.98059284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328262"},
        {"Hipparcos Number", "HIP 80760"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.34421433),
        dec: Angle.Degrees(-45.98051826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65270"},
        {"Hipparcos Number", "HIP 38737"},
        {"Celescope Catalog", "CEL 2103"},
        {"Geneva Identification System", "GEN# +1.00065270"},
        {"Renson", "Renson 17884"},
        {"Smithsonian Astrophysical Observation", "SAO 219158"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.95892433),
        dec: Angle.Degrees(-45.98006888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101388"},
        {"Hipparcos Number", "HIP 56893"},
        {"Geneva Identification System", "GEN# +1.00101388"},
        {"Smithsonian Astrophysical Observation", "SAO 222937"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.94378945),
        dec: Angle.Degrees(-45.97821662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131545"},
        {"Hipparcos Number", "HIP 73051"},
        {"Geneva Identification System", "GEN# +1.00131545"},
        {"Smithsonian Astrophysical Observation", "SAO 225295"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.94036016),
        dec: Angle.Degrees(-45.97402990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160715"},
        {"Hipparcos Number", "HIP 86755"},
        {"Celescope Catalog", "CEL 4557"},
        {"Geneva Identification System", "GEN# +1.00160715"},
        {"Smithsonian Astrophysical Observation", "SAO 228335"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.90530204),
        dec: Angle.Degrees(-45.97130344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63052"},
        {"Hipparcos Number", "HIP 37778"},
        {"Celescope Catalog", "CEL 2013"},
        {"Geneva Identification System", "GEN# +1.00063052"},
        {"Smithsonian Astrophysical Observation", "SAO 218951"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.19295162),
        dec: Angle.Degrees(-45.97062260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62036"},
        {"Hipparcos Number", "HIP 37343"},
        {"Geneva Identification System", "GEN# +1.00062036"},
        {"Smithsonian Astrophysical Observation", "SAO 218882"},
        {"Wilson Evans Batten Catalogue", "WEB 7391"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.97805367),
        dec: Angle.Degrees(-45.96961797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27209"},
        {"Hipparcos Number", "HIP 19875"},
        {"Geneva Identification System", "GEN# +1.00027209"},
        {"Smithsonian Astrophysical Observation", "SAO 216725"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.93761897),
        dec: Angle.Degrees(-45.96922234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 243.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54315"},
        {"Hipparcos Number", "HIP 34261"},
        {"Smithsonian Astrophysical Observation", "SAO 218451"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.52304651),
        dec: Angle.Degrees(-45.96879530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11768"},
        {"Hipparcos Number", "HIP 8879"},
        {"Smithsonian Astrophysical Observation", "SAO 215698"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.58429260),
        dec: Angle.Degrees(-45.96843374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169467"},
        {"Hipparcos Number", "HIP 90422"},
        {"Fundamental Katalog 5th Edition", "FK5 691"},
        {"Geneva Identification System", "GEN# +1.00169467"},
        {"Renson", "Renson 47480"},
        {"Smithsonian Astrophysical Observation", "SAO 229023"},
        {"Wilson Evans Batten Catalogue", "WEB 15484"},
    },
    visualMagnitude: 3.49,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.74345947),
        dec: Angle.Degrees(-45.96832919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126607"},
        {"Hipparcos Number", "HIP 70724"},
        {"Smithsonian Astrophysical Observation", "SAO 224944"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.95864417),
        dec: Angle.Degrees(-45.96312244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112685"},
        {"Hipparcos Number", "HIP 63372"},
        {"Geneva Identification System", "GEN# +1.00112685"},
        {"Smithsonian Astrophysical Observation", "SAO 223804"},
        {"Wilson Evans Batten Catalogue", "WEB 11220"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.78093315),
        dec: Angle.Degrees(-45.96219099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152799"},
        {"Hipparcos Number", "HIP 83008"},
        {"Celescope Catalog", "CEL 4468"},
        {"Geneva Identification System", "GEN# +2.62500002"},
        {"Smithsonian Astrophysical Observation", "SAO 227495"},
        {"New General Catalogue", "NGC 6250 2"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.42851027),
        dec: Angle.Degrees(-45.96145604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44972"},
        {"Hipparcos Number", "HIP 30299"},
        {"Geneva Identification System", "GEN# +1.00044972"},
        {"Smithsonian Astrophysical Observation", "SAO 217889"},
    },
    visualMagnitude: 6.84,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.59668067),
        dec: Angle.Degrees(-45.96036359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23308"},
        {"Hipparcos Number", "HIP 17298"},
        {"Fundamental Katalog 5th Edition", "FK5 2264"},
        {"Geneva Identification System", "GEN# +1.00023308"},
        {"Smithsonian Astrophysical Observation", "SAO 216449"},
        {"Wilson Evans Batten Catalogue", "WEB 3270"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.54131805),
        dec: Angle.Degrees(-45.95792132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192634"},
        {"Hipparcos Number", "HIP 100036"},
        {"Smithsonian Astrophysical Observation", "SAO 230133"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43500230),
        dec: Angle.Degrees(-45.95720145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169300"},
        {"Hipparcos Number", "HIP 90358"},
        {"Smithsonian Astrophysical Observation", "SAO 229013"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.56829439),
        dec: Angle.Degrees(-45.95609845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166063"},
        {"Hipparcos Number", "HIP 89112"},
        {"Fundamental Katalog 5th Edition", "FK5 1473"},
        {"Geneva Identification System", "GEN# +1.00166063"},
        {"Smithsonian Astrophysical Observation", "SAO 228777"},
        {"Wilson Evans Batten Catalogue", "WEB 15129"},
    },
    visualMagnitude: 4.52,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.80740093),
        dec: Angle.Degrees(-45.95432704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89371"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.57351088),
        dec: Angle.Degrees(-45.94952971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80470"},
        {"Hipparcos Number", "HIP 45664"},
        {"Smithsonian Astrophysical Observation", "SAO 221049"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.61404715),
        dec: Angle.Degrees(-45.94893544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212087"},
        {"Hipparcos Number", "HIP 110478"},
        {"Geneva Identification System", "GEN# +1.00212087"},
        {"Smithsonian Astrophysical Observation", "SAO 231105"},
    },
    visualMagnitude: 6.42,
    bvColour: 2.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.68409136),
        dec: Angle.Degrees(-45.94791727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45228"},
        {"Hipparcos Number", "HIP 30439"},
        {"Geneva Identification System", "GEN# +1.00045228"},
        {"Smithsonian Astrophysical Observation", "SAO 217904"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.99004440),
        dec: Angle.Degrees(-45.94781987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 299.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 155.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40361"},
        {"Hipparcos Number", "HIP 28055"},
        {"Geneva Identification System", "GEN# +1.00040361"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.98590204),
        dec: Angle.Degrees(-45.94601396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74960",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74960"},
    },
    visualMagnitude: 11.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.77454489),
        dec: Angle.Degrees(-45.94593937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151196"},
        {"Hipparcos Number", "HIP 82238"},
        {"Geneva Identification System", "GEN# +1.00151196"},
        {"Smithsonian Astrophysical Observation", "SAO 227233"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.02307535),
        dec: Angle.Degrees(-45.94486271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171141"},
        {"Hipparcos Number", "HIP 91124"},
        {"Geneva Identification System", "GEN# +1.00171141"},
        {"Smithsonian Astrophysical Observation", "SAO 229131"},
        {"Wilson Evans Batten Catalogue", "WEB 15643"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.81627514),
        dec: Angle.Degrees(-45.94082636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189483"},
        {"Hipparcos Number", "HIP 98648"},
        {"Fundamental Katalog 5th Edition", "FK5 5766"},
        {"Smithsonian Astrophysical Observation", "SAO 229999"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.55484289),
        dec: Angle.Degrees(-45.94000666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4858"},
        {"Hipparcos Number", "HIP 3906"},
        {"Smithsonian Astrophysical Observation", "SAO 215256"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.52249117),
        dec: Angle.Degrees(-45.93939639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165696"},
        {"Hipparcos Number", "HIP 88954"},
        {"Geneva Identification System", "GEN# +1.00165696"},
        {"Smithsonian Astrophysical Observation", "SAO 228747"},
        {"Wilson Evans Batten Catalogue", "WEB 15087"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.36445563),
        dec: Angle.Degrees(-45.93805292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61495"},
        {"Cincinnati Publication", "Ci 20 720"},
        {"Geneva Identification System", "GEN# +6.10010477"},
        {"Geneva Identification System 2", "GEN# -0.04507872"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.99373219),
        dec: Angle.Degrees(-45.93739996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -697.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32474"},
        {"Hipparcos Number", "HIP 23341"},
        {"Smithsonian Astrophysical Observation", "SAO 217121"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.31435007),
        dec: Angle.Degrees(-45.93642251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43790"},
        {"Hipparcos Number", "HIP 29741"},
        {"Smithsonian Astrophysical Observation", "SAO 217814"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.95008257),
        dec: Angle.Degrees(-45.93259932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20009"},
        {"Geneva Identification System", "GEN# +9.51502067"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.35028629),
        dec: Angle.Degrees(-45.93233659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34880",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34880"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.26207572),
        dec: Angle.Degrees(-45.93047964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143137"},
        {"Hipparcos Number", "HIP 78419"},
        {"Geneva Identification System", "GEN# +1.00143137"},
        {"Smithsonian Astrophysical Observation", "SAO 226437"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.14335722),
        dec: Angle.Degrees(-45.92856457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212132"},
        {"Hipparcos Number", "HIP 110506"},
        {"Fundamental Katalog 5th Edition", "FK5 3786"},
        {"Geneva Identification System", "GEN# +1.00212132"},
        {"Renson", "Renson 58860"},
        {"Smithsonian Astrophysical Observation", "SAO 231111"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.78246322),
        dec: Angle.Degrees(-45.92834717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 233.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85893",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85893"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.29219280),
        dec: Angle.Degrees(-45.92777608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217046"},
        {"Hipparcos Number", "HIP 113425"},
        {"Smithsonian Astrophysical Observation", "SAO 231373"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.57834755),
        dec: Angle.Degrees(-45.92654525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23647"},
        {"Hipparcos Number", "HIP 17487"},
        {"Geneva Identification System", "GEN# +1.00023647"},
        {"Smithsonian Astrophysical Observation", "SAO 216467"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.19650133),
        dec: Angle.Degrees(-45.92633797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36734"},
        {"Hipparcos Number", "HIP 25887"},
        {"Geneva Identification System", "GEN# +1.00036734"},
        {"Smithsonian Astrophysical Observation", "SAO 217382"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.89995202),
        dec: Angle.Degrees(-45.92540473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135625"},
        {"Hipparcos Number", "HIP 74856"},
        {"Geneva Identification System", "GEN# +1.00135625"},
        {"Smithsonian Astrophysical Observation", "SAO 225624"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.45201040),
        dec: Angle.Degrees(-45.92231896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168060"},
        {"Hipparcos Number", "HIP 89855"},
        {"Geneva Identification System", "GEN# +1.00168060"},
        {"Smithsonian Astrophysical Observation", "SAO 228917"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.04767686),
        dec: Angle.Degrees(-45.92186997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45034"},
        {"Hipparcos Number", "HIP 30337"},
        {"Smithsonian Astrophysical Observation", "SAO 217892"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.71645502),
        dec: Angle.Degrees(-45.92045987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92161"},
        {"Hipparcos Number", "HIP 52012"},
        {"Smithsonian Astrophysical Observation", "SAO 222204"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.39996730),
        dec: Angle.Degrees(-45.91966066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6654"},
        {"Hipparcos Number", "HIP 5205"},
        {"Smithsonian Astrophysical Observation", "SAO 215369"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.64815878),
        dec: Angle.Degrees(-45.91838030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84774"},
        {"Hipparcos Number", "HIP 47940"},
        {"Geneva Identification System", "GEN# +1.00084774"},
        {"Smithsonian Astrophysical Observation", "SAO 221480"},
    },
    visualMagnitude: 6.60,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.53749589),
        dec: Angle.Degrees(-45.91795054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20251"},
        {"Hipparcos Number", "HIP 15013"},
        {"Smithsonian Astrophysical Observation", "SAO 216219"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.38672962),
        dec: Angle.Degrees(-45.91584471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5887"},
        {"Hipparcos Number", "HIP 4653"},
        {"Smithsonian Astrophysical Observation", "SAO 215317"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.94897988),
        dec: Angle.Degrees(-45.91566576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170465"},
        {"Hipparcos Number", "HIP 90830"},
        {"Geneva Identification System", "GEN# +1.00170465"},
        {"Smithsonian Astrophysical Observation", "SAO 229092"},
        {"Wilson Evans Batten Catalogue", "WEB 15570"},
    },
    visualMagnitude: 4.92,
    bvColour: -0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.93931691),
        dec: Angle.Degrees(-45.91474360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123664"},
        {"Hipparcos Number", "HIP 69209"},
        {"Geneva Identification System", "GEN# +1.00123664"},
        {"Smithsonian Astrophysical Observation", "SAO 224737"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.54554875),
        dec: Angle.Degrees(-45.91379416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34631"},
        {"Hipparcos Number", "HIP 24603"},
        {"Geneva Identification System", "GEN# +1.00034631"},
        {"Renson", "Renson 8840"},
        {"Smithsonian Astrophysical Observation", "SAO 217265"},
    },
    visualMagnitude: 7.02,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.15758238),
        dec: Angle.Degrees(-45.91377467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75149"},
        {"Hipparcos Number", "HIP 43082"},
        {"Celescope Catalog", "CEL 2892"},
        {"Geneva Identification System", "GEN# +1.00075149"},
        {"Smithsonian Astrophysical Observation", "SAO 220442"},
        {"Wilson Evans Batten Catalogue", "WEB 8315"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.62729635),
        dec: Angle.Degrees(-45.91251639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210796"},
        {"Hipparcos Number", "HIP 109758"},
        {"Geneva Identification System", "GEN# +1.00210796"},
        {"Smithsonian Astrophysical Observation", "SAO 231041"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47221855),
        dec: Angle.Degrees(-45.91150196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84712"},
        {"Hipparcos Number", "HIP 47889"},
        {"Geneva Identification System", "GEN# +1.00084712"},
        {"Smithsonian Astrophysical Observation", "SAO 221465"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.41178600),
        dec: Angle.Degrees(-45.91117555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7211"},
        {"Hipparcos Number", "HIP 5597"},
        {"Smithsonian Astrophysical Observation", "SAO 215405"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.94109657),
        dec: Angle.Degrees(-45.91072489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192415"},
        {"Hipparcos Number", "HIP 99935"},
        {"Smithsonian Astrophysical Observation", "SAO 230129"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.14657731),
        dec: Angle.Degrees(-45.90802961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111434"},
        {"Hipparcos Number", "HIP 62599"},
        {"Smithsonian Astrophysical Observation", "SAO 223693"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.40683595),
        dec: Angle.Degrees(-45.90574832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125069"},
        {"Hipparcos Number", "HIP 69901"},
        {"Geneva Identification System", "GEN# +1.00125069"},
        {"Smithsonian Astrophysical Observation", "SAO 224827"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.59456128),
        dec: Angle.Degrees(-45.90492628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165822"},
        {"Hipparcos Number", "HIP 89022"},
        {"Smithsonian Astrophysical Observation", "SAO 228760"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.52400264),
        dec: Angle.Degrees(-45.90394341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25956"},
        {"Hipparcos Number", "HIP 19029"},
        {"Geneva Identification System", "GEN# +1.00025956"},
        {"Smithsonian Astrophysical Observation", "SAO 216629"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.14777704),
        dec: Angle.Degrees(-45.90216933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2822"},
        {"Hipparcos Number", "HIP 2470"},
        {"Geneva Identification System", "GEN# +1.00002822"},
        {"Smithsonian Astrophysical Observation", "SAO 215130"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.84661271),
        dec: Angle.Degrees(-45.90153387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3598"},
        {"Hipparcos Number", "HIP 3020"},
        {"Fundamental Katalog 5th Edition", "FK5 4057"},
        {"Geneva Identification System", "GEN# +1.00003598"},
        {"Smithsonian Astrophysical Observation", "SAO 215174"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.61412469),
        dec: Angle.Degrees(-45.90145517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 60.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204670"},
        {"Hipparcos Number", "HIP 106288"},
        {"Geneva Identification System", "GEN# +1.00204670"},
        {"Smithsonian Astrophysical Observation", "SAO 230723"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.91459260),
        dec: Angle.Degrees(-45.90088496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 338.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172568"},
        {"Hipparcos Number", "HIP 91805"},
        {"Smithsonian Astrophysical Observation", "SAO 229221"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.78592441),
        dec: Angle.Degrees(-45.90023467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121175"},
        {"Hipparcos Number", "HIP 67950"},
        {"Smithsonian Astrophysical Observation", "SAO 224530"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.73804749),
        dec: Angle.Degrees(-45.89986982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87640"},
        {"Hipparcos Number", "HIP 49400"},
        {"Geneva Identification System", "GEN# +1.00087640J"},
        {"Smithsonian Astrophysical Observation", "SAO 221758"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.27498733),
        dec: Angle.Degrees(-45.89616031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56701"},
        {"Hipparcos Number", "HIP 35160"},
        {"Geneva Identification System", "GEN# +1.00056701"},
        {"Smithsonian Astrophysical Observation", "SAO 218581"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.00260954),
        dec: Angle.Degrees(-45.89580532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180002"},
        {"Hipparcos Number", "HIP 94762"},
        {"Geneva Identification System", "GEN# +1.00180002"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.23415619),
        dec: Angle.Degrees(-45.89538829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91795"},
        {"Hipparcos Number", "HIP 51805"},
        {"Geneva Identification System", "GEN# +1.00091795"},
        {"Smithsonian Astrophysical Observation", "SAO 222168"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.76784760),
        dec: Angle.Degrees(-45.89522906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78684"},
        {"Hipparcos Number", "HIP 44810"},
        {"Geneva Identification System", "GEN# +1.00078684"},
        {"Smithsonian Astrophysical Observation", "SAO 220877"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.97584581),
        dec: Angle.Degrees(-45.89516113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60129"},
        {"Hipparcos Number", "HIP 36534"},
        {"Smithsonian Astrophysical Observation", "SAO 218774"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73516481),
        dec: Angle.Degrees(-45.89512339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71236"},
        {"Hipparcos Number", "HIP 41193"},
        {"Geneva Identification System", "GEN# +1.00071236"},
        {"Smithsonian Astrophysical Observation", "SAO 219882"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.08982748),
        dec: Angle.Degrees(-45.89496544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135011"},
        {"Hipparcos Number", "HIP 74602"},
        {"Smithsonian Astrophysical Observation", "SAO 225566"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.64305453),
        dec: Angle.Degrees(-45.89481281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222988"},
        {"Hipparcos Number", "HIP 117198"},
        {"Geneva Identification System", "GEN# +1.00222988"},
        {"Smithsonian Astrophysical Observation", "SAO 231765"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.46078484),
        dec: Angle.Degrees(-45.89450414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157354"},
        {"Hipparcos Number", "HIP 85234"},
        {"Geneva Identification System", "GEN# +1.00157354"},
        {"Smithsonian Astrophysical Observation", "SAO 227924"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.24707680),
        dec: Angle.Degrees(-45.89382545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221156"},
        {"Hipparcos Number", "HIP 115975"},
        {"Fundamental Katalog 5th Edition", "FK5 6077"},
        {"Geneva Identification System", "GEN# +1.00221156"},
        {"Smithsonian Astrophysical Observation", "SAO 231630"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.45880197),
        dec: Angle.Degrees(-45.89377485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82684",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82684"},
        {"Smithsonian Astrophysical Observation", "SAO 160154"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.51943761),
        dec: Angle.Degrees(-16.40862669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58138"},
        {"Hipparcos Number", "HIP 35714"},
        {"Smithsonian Astrophysical Observation", "SAO 218673"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.51975549),
        dec: Angle.Degrees(-45.89362449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8808"},
        {"Hipparcos Number", "HIP 6696"},
        {"Smithsonian Astrophysical Observation", "SAO 215504"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.50232090),
        dec: Angle.Degrees(-45.89354114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60792"},
        {"Hipparcos Number", "HIP 36798"},
        {"Smithsonian Astrophysical Observation", "SAO 218808"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.52327293),
        dec: Angle.Degrees(-45.89340478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72641",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72641"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.78011176),
        dec: Angle.Degrees(-45.89291718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51317"},
        {"Hipparcos Number", "HIP 33201"},
        {"Smithsonian Astrophysical Observation", "SAO 218301"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.65240876),
        dec: Angle.Degrees(-45.89250295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44324"},
        {"Hipparcos Number", "HIP 30012"},
        {"Smithsonian Astrophysical Observation", "SAO 217844"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.74622749),
        dec: Angle.Degrees(-45.89218841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149832"},
        {"Hipparcos Number", "HIP 81549"},
        {"Smithsonian Astrophysical Observation", "SAO 227006"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83219435),
        dec: Angle.Degrees(-45.88911877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216531"},
        {"Hipparcos Number", "HIP 113100"},
        {"Geneva Identification System", "GEN# +1.00216531"},
        {"Smithsonian Astrophysical Observation", "SAO 231346"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.56741151),
        dec: Angle.Degrees(-45.88858134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179930"},
        {"Hipparcos Number", "HIP 94739"},
        {"Cincinnati Publication", "Ci 20 1141"},
        {"Geneva Identification System", "GEN# +1.00179930"},
        {"Wilson Evans Batten Catalogue", "WEB 16528"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.17808751),
        dec: Angle.Degrees(-45.88834168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 215.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -412.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151018"},
        {"Hipparcos Number", "HIP 82148"},
        {"Geneva Identification System", "GEN# +1.00151018"},
        {"Smithsonian Astrophysical Observation", "SAO 227195"},
        {"Wilson Evans Batten Catalogue", "WEB 13872"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.73382601),
        dec: Angle.Degrees(-45.88730220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67641"},
        {"Hipparcos Number", "HIP 39706"},
        {"Smithsonian Astrophysical Observation", "SAO 219434"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.73618502),
        dec: Angle.Degrees(-45.88727682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19816"},
        {"Hipparcos Number", "HIP 14662"},
        {"Geneva Identification System", "GEN# +1.00019816"},
        {"Smithsonian Astrophysical Observation", "SAO 216188"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.35757601),
        dec: Angle.Degrees(-45.88656003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6279"},
        {"Hipparcos Number", "HIP 4917"},
        {"Smithsonian Astrophysical Observation", "SAO 215345"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.78507734),
        dec: Angle.Degrees(-45.88643611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159902"},
        {"Hipparcos Number", "HIP 86415"},
        {"Geneva Identification System", "GEN# +1.00159902"},
        {"Smithsonian Astrophysical Observation", "SAO 228240"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.86564875),
        dec: Angle.Degrees(-45.88621435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98717"},
        {"Hipparcos Number", "HIP 55430"},
        {"Smithsonian Astrophysical Observation", "SAO 222735"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.27777217),
        dec: Angle.Degrees(-45.88615391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208466"},
        {"Hipparcos Number", "HIP 108386"},
        {"Smithsonian Astrophysical Observation", "SAO 230913"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.37306493),
        dec: Angle.Degrees(-45.88510504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118435"},
        {"Hipparcos Number", "HIP 66484"},
        {"Smithsonian Astrophysical Observation", "SAO 224288"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.45018575),
        dec: Angle.Degrees(-45.88283095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210234"},
        {"Hipparcos Number", "HIP 109411"},
        {"Smithsonian Astrophysical Observation", "SAO 231006"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.49905250),
        dec: Angle.Degrees(-45.88184494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107094"},
        {"Hipparcos Number", "HIP 60051"},
        {"Geneva Identification System", "GEN# +1.00107094"},
        {"Smithsonian Astrophysical Observation", "SAO 223350"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.73529392),
        dec: Angle.Degrees(-45.88143600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54364"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.83260995),
        dec: Angle.Degrees(-45.88141783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112954",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112954"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.14562915),
        dec: Angle.Degrees(-45.88111186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129747"},
        {"Hipparcos Number", "HIP 72177"},
        {"Geneva Identification System", "GEN# +1.00129747"},
        {"Smithsonian Astrophysical Observation", "SAO 225171"},
        {"Wilson Evans Batten Catalogue", "WEB 12418"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.44020786),
        dec: Angle.Degrees(-45.88095178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99385"},
        {"Hipparcos Number", "HIP 55776"},
        {"Smithsonian Astrophysical Observation", "SAO 222789"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.42490284),
        dec: Angle.Degrees(-45.88033838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98096"},
        {"Hipparcos Number", "HIP 55068"},
        {"Geneva Identification System", "GEN# +1.00098096"},
        {"Smithsonian Astrophysical Observation", "SAO 222687"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.11641893),
        dec: Angle.Degrees(-45.88017922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155634"},
        {"Hipparcos Number", "HIP 84383"},
        {"Geneva Identification System", "GEN# +1.00155634"},
        {"Smithsonian Astrophysical Observation", "SAO 227743"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.77385304),
        dec: Angle.Degrees(-45.87855935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47796",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47796"},
    },
    visualMagnitude: 12.29,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.15947782),
        dec: Angle.Degrees(-45.87704737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143544"},
        {"Hipparcos Number", "HIP 78595"},
        {"Smithsonian Astrophysical Observation", "SAO 226461"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.70647410),
        dec: Angle.Degrees(-45.87697630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95027"},
        {"Hipparcos Number", "HIP 53576"},
        {"Smithsonian Astrophysical Observation", "SAO 222454"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.40779742),
        dec: Angle.Degrees(-45.87588870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182610"},
        {"Hipparcos Number", "HIP 95676"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.91499888),
        dec: Angle.Degrees(-45.87534851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145662"},
        {"Hipparcos Number", "HIP 79570"},
        {"Smithsonian Astrophysical Observation", "SAO 226590"},
    },
    visualMagnitude: 8.51,
    bvColour: 2.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.53167325),
        dec: Angle.Degrees(-45.87478361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155114"},
        {"Hipparcos Number", "HIP 84121"},
        {"Geneva Identification System", "GEN# +1.00155114"},
        {"Smithsonian Astrophysical Observation", "SAO 227703"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.96372599),
        dec: Angle.Degrees(-45.87409582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128413"},
        {"Hipparcos Number", "HIP 71570"},
        {"Geneva Identification System", "GEN# +1.00128413"},
        {"Smithsonian Astrophysical Observation", "SAO 225079"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.55605254),
        dec: Angle.Degrees(-45.87178755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89953"},
        {"Hipparcos Number", "HIP 50758"},
        {"Smithsonian Astrophysical Observation", "SAO 221987"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.46398851),
        dec: Angle.Degrees(-45.87176241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15929"},
        {"Hipparcos Number", "HIP 11804"},
        {"Geneva Identification System", "GEN# +1.00015929"},
        {"Smithsonian Astrophysical Observation", "SAO 215936"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.06306486),
        dec: Angle.Degrees(-45.87118404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114411"},
        {"Hipparcos Number", "HIP 64323"},
        {"Geneva Identification System", "GEN# +1.00114411"},
        {"Smithsonian Astrophysical Observation", "SAO 223957"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.76013963),
        dec: Angle.Degrees(-45.86964303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127257"},
        {"Hipparcos Number", "HIP 71039"},
        {"Geneva Identification System", "GEN# +1.00127257"},
        {"Smithsonian Astrophysical Observation", "SAO 224995"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92766487),
        dec: Angle.Degrees(-45.86948515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2480"},
        {"Hipparcos Number", "HIP 2236"},
    },
    visualMagnitude: 8.59,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.08800674),
        dec: Angle.Degrees(-45.86907330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106769"},
        {"Hipparcos Number", "HIP 59869"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.17895652),
        dec: Angle.Degrees(-45.86739453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26413"},
        {"Hipparcos Number", "HIP 19331"},
        {"Fundamental Katalog 5th Edition", "FK5 2299"},
        {"Geneva Identification System", "GEN# +1.00026413"},
        {"Smithsonian Astrophysical Observation", "SAO 216667"},
    },
    visualMagnitude: 6.58,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.14091232),
        dec: Angle.Degrees(-45.86485707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62783"},
        {"Hipparcos Number", "HIP 37649"},
        {"Geneva Identification System", "GEN# +1.00062783"},
        {"Smithsonian Astrophysical Observation", "SAO 218933"},
        {"Wilson Evans Batten Catalogue", "WEB 7444"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.89036133),
        dec: Angle.Degrees(-45.86401712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216"},
        {"Hipparcos Number", "HIP 564"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.71380391),
        dec: Angle.Degrees(-45.86393212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110861"},
        {"Hipparcos Number", "HIP 62252"},
        {"Smithsonian Astrophysical Observation", "SAO 223647"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.36508870),
        dec: Angle.Degrees(-45.86256777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76308",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76308"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.81650884),
        dec: Angle.Degrees(-45.86246198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78116"},
        {"Hipparcos Number", "HIP 44561"},
        {"Smithsonian Astrophysical Observation", "SAO 220817"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.19345385),
        dec: Angle.Degrees(-45.86170030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164500"},
        {"Hipparcos Number", "HIP 88460"},
        {"Geneva Identification System", "GEN# +1.00164500"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.92251190),
        dec: Angle.Degrees(-45.86148854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -245.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131168B"},
        {"Hipparcos Number", "HIP 120006"},
        {"Geneva Identification System", "GEN# +1.00131168B"},
        {"Smithsonian Astrophysical Observation", "SAO 225272"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.33696355),
        dec: Angle.Degrees(-45.85908156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187312"},
        {"Hipparcos Number", "HIP 97703"},
        {"Smithsonian Astrophysical Observation", "SAO 229893"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.84004785),
        dec: Angle.Degrees(-45.85582034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131168"},
        {"Hipparcos Number", "HIP 72843"},
        {"Celescope Catalog", "CEL 4325"},
        {"Geneva Identification System", "GEN# +1.00131168J"},
        {"Geneva Identification System 2", "GEN# +1.00131168A"},
        {"Smithsonian Astrophysical Observation", "SAO 225273"},
        {"Wilson Evans Batten Catalogue", "WEB 12511"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.34216188),
        dec: Angle.Degrees(-45.85574427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174173"},
        {"Hipparcos Number", "HIP 92543"},
        {"Geneva Identification System", "GEN# +1.00174173"},
        {"Smithsonian Astrophysical Observation", "SAO 229323"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.87527862),
        dec: Angle.Degrees(-45.85540105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197748"},
        {"Hipparcos Number", "HIP 102588"},
        {"Smithsonian Astrophysical Observation", "SAO 230370"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.84854346),
        dec: Angle.Degrees(-45.85450813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21309"},
        {"Hipparcos Number", "HIP 15874"},
        {"Fundamental Katalog 5th Edition", "FK5 4309"},
        {"Geneva Identification System", "GEN# +1.00021309"},
        {"Smithsonian Astrophysical Observation", "SAO 216301"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.11842425),
        dec: Angle.Degrees(-45.85355836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147537"},
        {"Hipparcos Number", "HIP 80394"},
        {"Smithsonian Astrophysical Observation", "SAO 226725"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.14846833),
        dec: Angle.Degrees(-45.85109147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119069"},
        {"Hipparcos Number", "HIP 66842"},
        {"Geneva Identification System", "GEN# +1.00119069"},
        {"Smithsonian Astrophysical Observation", "SAO 224345"},
        {"Wilson Evans Batten Catalogue", "WEB 11782"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.48342280),
        dec: Angle.Degrees(-45.85096599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114195"},
        {"Hipparcos Number", "HIP 64214"},
        {"Smithsonian Astrophysical Observation", "SAO 223941"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.41774871),
        dec: Angle.Degrees(-45.84986341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45168",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79403"},
        {"Hipparcos Number", "HIP 45168"},
        {"Geneva Identification System", "GEN# +1.00079403"},
        {"Smithsonian Astrophysical Observation", "SAO 220948"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.05788077),
        dec: Angle.Degrees(-45.84842490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8963"},
        {"Hipparcos Number", "HIP 6799"},
        {"Geneva Identification System", "GEN# +1.00008963"},
        {"Smithsonian Astrophysical Observation", "SAO 215510"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.87226863),
        dec: Angle.Degrees(-45.84624427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110907"},
        {"Hipparcos Number", "HIP 62283"},
        {"Geneva Identification System", "GEN# +1.00110907"},
        {"Smithsonian Astrophysical Observation", "SAO 223653"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.46218313),
        dec: Angle.Degrees(-45.84550654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80454"},
        {"Hipparcos Number", "HIP 45652"},
        {"Celescope Catalog", "CEL 3261"},
        {"Geneva Identification System", "GEN# +1.00080454"},
        {"Smithsonian Astrophysical Observation", "SAO 221045"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.58575169),
        dec: Angle.Degrees(-45.84443815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157661"},
        {"Hipparcos Number", "HIP 85389"},
        {"Celescope Catalog", "CEL 4514"},
        {"Wilson Evans Batten Catalogue", "WEB 14424"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.71659776),
        dec: Angle.Degrees(-45.84296289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218266"},
        {"Hipparcos Number", "HIP 114165"},
        {"Smithsonian Astrophysical Observation", "SAO 231446"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.79987592),
        dec: Angle.Degrees(-45.84256249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9398",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9398"},
    },
    visualMagnitude: 10.63,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.19699971),
        dec: Angle.Degrees(-45.84226500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 304.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87788",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87788"},
        {"Geneva Identification System", "GEN# +9.80154034"},
        {"Wilson Evans Batten Catalogue", "WEB 14815"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.99357684),
        dec: Angle.Degrees(-16.40756953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -632.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215468"},
        {"Hipparcos Number", "HIP 112407"},
        {"Geneva Identification System", "GEN# +1.00215468"},
        {"Smithsonian Astrophysical Observation", "SAO 231284"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.51801069),
        dec: Angle.Degrees(-45.84188943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85489",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85489"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.06545100),
        dec: Angle.Degrees(-45.83834892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223295"},
        {"Hipparcos Number", "HIP 117418"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.721,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.13239165),
        dec: Angle.Degrees(-45.83692689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111672",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111672"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.34218592),
        dec: Angle.Degrees(-45.83571194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23921"},
        {"Hipparcos Number", "HIP 17654"},
        {"Smithsonian Astrophysical Observation", "SAO 216486"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.71834398),
        dec: Angle.Degrees(-45.83568708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12586"},
        {"Hipparcos Number", "HIP 9495"},
        {"Fundamental Katalog 5th Edition", "FK5 4184"},
        {"Geneva Identification System", "GEN# +1.00012586"},
        {"Smithsonian Astrophysical Observation", "SAO 215741"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.54450880),
        dec: Angle.Degrees(-45.83553703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69302"},
        {"Hipparcos Number", "HIP 40357"},
        {"Celescope Catalog", "CEL 2270"},
        {"Geneva Identification System", "GEN# +1.00069302J"},
        {"Smithsonian Astrophysical Observation", "SAO 219657"},
        {"Wilson Evans Batten Catalogue", "WEB 7871"},
    },
    visualMagnitude: 5.86,
    bvColour: -0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.59949300),
        dec: Angle.Degrees(-45.83454842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38458"},
        {"Hipparcos Number", "HIP 27001"},
        {"Geneva Identification System", "GEN# +1.00038458"},
        {"Smithsonian Astrophysical Observation", "SAO 217497"},
        {"Wilson Evans Batten Catalogue", "WEB 5320"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.92132767),
        dec: Angle.Degrees(-45.83310130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58452",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104080"},
        {"Hipparcos Number", "HIP 58452"},
        {"Geneva Identification System", "GEN# +1.00104080"},
        {"Smithsonian Astrophysical Observation", "SAO 223151"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.79460657),
        dec: Angle.Degrees(-45.83219996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20887"},
        {"Hipparcos Number", "HIP 15545"},
        {"Smithsonian Astrophysical Observation", "SAO 216269"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.07594141),
        dec: Angle.Degrees(-45.82832683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204227"},
        {"Hipparcos Number", "HIP 106026"},
        {"Smithsonian Astrophysical Observation", "SAO 230702"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.11897898),
        dec: Angle.Degrees(-45.82791106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188555"},
        {"Hipparcos Number", "HIP 98233"},
        {"Geneva Identification System", "GEN# +1.00188555"},
        {"Smithsonian Astrophysical Observation", "SAO 229953"},
        {"Wilson Evans Batten Catalogue", "WEB 17327"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.43838528),
        dec: Angle.Degrees(-45.82748938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95507"},
        {"Hipparcos Number", "HIP 53843"},
        {"Smithsonian Astrophysical Observation", "SAO 222502"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.22311074),
        dec: Angle.Degrees(-45.82582378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111417"},
        {"Hipparcos Number", "HIP 62589"},
        {"Geneva Identification System", "GEN# +1.00111417"},
        {"Smithsonian Astrophysical Observation", "SAO 223690"},
        {"Wilson Evans Batten Catalogue", "WEB 11107"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.38273599),
        dec: Angle.Degrees(-45.82568655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132623"},
        {"Hipparcos Number", "HIP 73526"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.43020186),
        dec: Angle.Degrees(-45.82555252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106785"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.43676185),
        dec: Angle.Degrees(-45.82460031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172643"},
        {"Hipparcos Number", "HIP 91857"},
        {"Smithsonian Astrophysical Observation", "SAO 229227"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.90997398),
        dec: Angle.Degrees(-45.82380924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69382"},
        {"Hipparcos Number", "HIP 40392"},
        {"Geneva Identification System", "GEN# +1.00069382"},
        {"Smithsonian Astrophysical Observation", "SAO 219671"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.70082516),
        dec: Angle.Degrees(-45.82161381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190393"},
        {"Hipparcos Number", "HIP 99063"},
        {"Smithsonian Astrophysical Observation", "SAO 230043"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.67797028),
        dec: Angle.Degrees(-45.82108396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32805"},
        {"Hipparcos Number", "HIP 23531"},
        {"Smithsonian Astrophysical Observation", "SAO 217151"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.88702610),
        dec: Angle.Degrees(-45.81896638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68627"},
        {"Hipparcos Number", "HIP 40088"},
        {"Geneva Identification System", "GEN# +1.00068627"},
        {"Smithsonian Astrophysical Observation", "SAO 219566"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.82820437),
        dec: Angle.Degrees(-45.81814478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145560"},
        {"Hipparcos Number", "HIP 79516"},
        {"Smithsonian Astrophysical Observation", "SAO 226583"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.39312581),
        dec: Angle.Degrees(-45.81761402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188392"},
        {"Hipparcos Number", "HIP 98164"},
        {"Geneva Identification System", "GEN# +1.00188392"},
        {"Smithsonian Astrophysical Observation", "SAO 229944"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.24188077),
        dec: Angle.Degrees(-45.81654950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42024"},
        {"Hipparcos Number", "HIP 28913"},
        {"Geneva Identification System", "GEN# +1.00042024"},
        {"Smithsonian Astrophysical Observation", "SAO 217718"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.54807438),
        dec: Angle.Degrees(-45.81583693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211111"},
        {"Hipparcos Number", "HIP 109922"},
        {"Smithsonian Astrophysical Observation", "SAO 231056"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.95777396),
        dec: Angle.Degrees(-45.81566251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118130",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118130"},
        {"Cincinnati Publication", "Ci 20 1463"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.43858848),
        dec: Angle.Degrees(-45.81494030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 365.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159515"},
        {"Hipparcos Number", "HIP 86243"},
        {"Geneva Identification System", "GEN# +1.00159515"},
        {"Renson", "Renson 44880"},
        {"Smithsonian Astrophysical Observation", "SAO 228202"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.35946128),
        dec: Angle.Degrees(-45.81331917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196749"},
        {"Hipparcos Number", "HIP 102073"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.28228898),
        dec: Angle.Degrees(-45.81229681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145486"},
        {"Hipparcos Number", "HIP 79478"},
        {"Smithsonian Astrophysical Observation", "SAO 226578"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.29988936),
        dec: Angle.Degrees(-45.81134444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72251"},
        {"Hipparcos Number", "HIP 41692"},
        {"Geneva Identification System", "GEN# +1.00072251"},
        {"Smithsonian Astrophysical Observation", "SAO 220013"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.48521800),
        dec: Angle.Degrees(-45.81116095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202996"},
        {"Hipparcos Number", "HIP 105391"},
        {"Geneva Identification System", "GEN# +1.00202996"},
        {"Smithsonian Astrophysical Observation", "SAO 230643"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.21225957),
        dec: Angle.Degrees(-45.81086977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173791"},
        {"Hipparcos Number", "HIP 92367"},
        {"Fundamental Katalog 5th Edition", "FK5 3495"},
        {"Geneva Identification System", "GEN# +1.00173791"},
        {"Smithsonian Astrophysical Observation", "SAO 229306"},
        {"Wilson Evans Batten Catalogue", "WEB 15949"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36367328),
        dec: Angle.Degrees(-45.81023948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146884"},
        {"Hipparcos Number", "HIP 80065"},
        {"Geneva Identification System", "GEN# +1.00146884"},
        {"Smithsonian Astrophysical Observation", "SAO 226672"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.13550979),
        dec: Angle.Degrees(-45.80960006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76933",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76933"},
    },
    visualMagnitude: 9.68,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.64150905),
        dec: Angle.Degrees(-45.80812077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210795"},
        {"Hipparcos Number", "HIP 109752"},
        {"Smithsonian Astrophysical Observation", "SAO 231040"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.46874711),
        dec: Angle.Degrees(-45.80636376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123938"},
        {"Hipparcos Number", "HIP 69351"},
        {"Geneva Identification System", "GEN# +1.00123938"},
        {"Smithsonian Astrophysical Observation", "SAO 224756"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.92045181),
        dec: Angle.Degrees(-45.80460733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203726"},
        {"Hipparcos Number", "HIP 105786"},
        {"Geneva Identification System", "GEN# +1.00203726"},
        {"Smithsonian Astrophysical Observation", "SAO 230677"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.36647365),
        dec: Angle.Degrees(-45.80414036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7534"},
        {"Hipparcos Number", "HIP 5826"},
        {"Smithsonian Astrophysical Observation", "SAO 215426"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.68062772),
        dec: Angle.Degrees(-45.80389836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101408"},
        {"Hipparcos Number", "HIP 56902"},
        {"Geneva Identification System", "GEN# +1.00101408"},
        {"Smithsonian Astrophysical Observation", "SAO 222938"},
        {"Wilson Evans Batten Catalogue", "WEB 10248"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.97125356),
        dec: Angle.Degrees(-45.80371066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63199"},
        {"Hipparcos Number", "HIP 37851"},
        {"Smithsonian Astrophysical Observation", "SAO 218963"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.39189254),
        dec: Angle.Degrees(-45.80205011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130364"},
        {"Hipparcos Number", "HIP 72481"},
        {"Geneva Identification System", "GEN# +1.00130364"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.31153535),
        dec: Angle.Degrees(-45.80153583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36331"},
        {"Hipparcos Number", "HIP 25641"},
        {"Smithsonian Astrophysical Observation", "SAO 217352"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.15685709),
        dec: Angle.Degrees(-45.80140128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53164"},
        {"Hipparcos Number", "HIP 33871"},
        {"Smithsonian Astrophysical Observation", "SAO 218390"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.46399871),
        dec: Angle.Degrees(-45.80132545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141803"},
        {"Hipparcos Number", "HIP 77780"},
        {"Smithsonian Astrophysical Observation", "SAO 226323"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.22983467),
        dec: Angle.Degrees(-45.80084479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29048"},
        {"Hipparcos Number", "HIP 21163"},
        {"Geneva Identification System", "GEN# +1.00029048"},
        {"Smithsonian Astrophysical Observation", "SAO 216861"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.05133409),
        dec: Angle.Degrees(-45.79926021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94939",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94939"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.78720239),
        dec: Angle.Degrees(-45.79857653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -415.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112579"},
        {"Hipparcos Number", "HIP 63292"},
        {"Smithsonian Astrophysical Observation", "SAO 223795"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.55784227),
        dec: Angle.Degrees(-45.79802008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82662"},
        {"Hipparcos Number", "HIP 46775"},
        {"Smithsonian Astrophysical Observation", "SAO 221257"},
    },
    visualMagnitude: 8.96,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.99308845),
        dec: Angle.Degrees(-45.79521623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128775"},
        {"Hipparcos Number", "HIP 71727"},
        {"Geneva Identification System", "GEN# +1.00128775"},
        {"Renson", "Renson 36640"},
        {"Smithsonian Astrophysical Observation", "SAO 225104"},
        {"Wilson Evans Batten Catalogue", "WEB 12355"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.08037344),
        dec: Angle.Degrees(-45.79378480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66162"},
        {"Hipparcos Number", "HIP 39124"},
        {"Geneva Identification System", "GEN# +1.00066162"},
        {"Smithsonian Astrophysical Observation", "SAO 219276"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.06269290),
        dec: Angle.Degrees(-45.79350778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 76.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113057",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113057"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.43488157),
        dec: Angle.Degrees(-45.79349094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29929"},
        {"Hipparcos Number", "HIP 21786"},
        {"Smithsonian Astrophysical Observation", "SAO 216929"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.20259249),
        dec: Angle.Degrees(-45.79305049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147841"},
        {"Hipparcos Number", "HIP 80525"},
        {"Fundamental Katalog 5th Edition", "FK5 5451"},
        {"Smithsonian Astrophysical Observation", "SAO 226760"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.58220082),
        dec: Angle.Degrees(-45.79138094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34346"},
        {"Hipparcos Number", "HIP 24432"},
        {"Smithsonian Astrophysical Observation", "SAO 217252"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.63087524),
        dec: Angle.Degrees(-45.79126057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52666"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.53793270),
        dec: Angle.Degrees(-45.79038259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88349"},
        {"Hipparcos Number", "HIP 49815"},
        {"Geneva Identification System", "GEN# +1.00088349"},
        {"Renson", "Renson 25300"},
        {"Smithsonian Astrophysical Observation", "SAO 221823"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.54108640),
        dec: Angle.Degrees(-45.78948038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148919"},
        {"Hipparcos Number", "HIP 81071"},
        {"Geneva Identification System", "GEN# +1.00148919"},
        {"Smithsonian Astrophysical Observation", "SAO 226883"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.38129470),
        dec: Angle.Degrees(-45.78805559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4964"},
        {"Geneva Identification System", "GEN# -0.04600293"},
    },
    visualMagnitude: 11.62,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.91285183),
        dec: Angle.Degrees(-45.78788795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -261.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1714.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207451"},
        {"Hipparcos Number", "HIP 107802"},
        {"Smithsonian Astrophysical Observation", "SAO 230862"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.58452889),
        dec: Angle.Degrees(-45.78625987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77020",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77020"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.88690939),
        dec: Angle.Degrees(-45.78590454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4087"},
        {"Hipparcos Number", "HIP 3376"},
        {"Smithsonian Astrophysical Observation", "SAO 215206"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.72849725),
        dec: Angle.Degrees(-45.78490777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72537"},
        {"Hipparcos Number", "HIP 41823"},
        {"Celescope Catalog", "CEL 2606"},
        {"Geneva Identification System", "GEN# +1.00072537"},
        {"Smithsonian Astrophysical Observation", "SAO 220048"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.90294122),
        dec: Angle.Degrees(-45.78479144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213785"},
        {"Hipparcos Number", "HIP 111456"},
        {"Geneva Identification System", "GEN# +1.00213785"},
        {"Smithsonian Astrophysical Observation", "SAO 231200"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.69886774),
        dec: Angle.Degrees(-45.78461573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29232"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.44615693),
        dec: Angle.Degrees(-16.36382306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -259.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201931"},
        {"Hipparcos Number", "HIP 104838"},
        {"Geneva Identification System", "GEN# +1.00201931"},
        {"Smithsonian Astrophysical Observation", "SAO 230585"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56946090),
        dec: Angle.Degrees(-45.78256708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76756"},
        {"Geneva Identification System", "GEN# -0.04510108"},
        {"Wilson Evans Batten Catalogue", "WEB 13028"},
    },
    visualMagnitude: 10.72,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.09382967),
        dec: Angle.Degrees(-45.78077737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132363"},
        {"Hipparcos Number", "HIP 73423"},
        {"Smithsonian Astrophysical Observation", "SAO 225362"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.07378239),
        dec: Angle.Degrees(-45.77939468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46068"},
        {"Hipparcos Number", "HIP 30873"},
        {"Celescope Catalog", "CEL 1266"},
        {"Smithsonian Astrophysical Observation", "SAO 217956"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.21684941),
        dec: Angle.Degrees(-45.77765995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122058"},
        {"Hipparcos Number", "HIP 68435"},
        {"Smithsonian Astrophysical Observation", "SAO 224610"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.15432336),
        dec: Angle.Degrees(-45.77574204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47780",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47780"},
        {"Cincinnati Publication", "Ci 20 547"},
        {"Geneva Identification System", "GEN# -0.04505378"},
        {"Wilson Evans Batten Catalogue", "WEB 8949"},
    },
    visualMagnitude: 10.22,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.12593185),
        dec: Angle.Degrees(-45.77508870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -466.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -585.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161064"},
        {"Hipparcos Number", "HIP 86934"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.44502134),
        dec: Angle.Degrees(-45.77504413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10210"},
        {"Hipparcos Number", "HIP 7689"},
        {"Geneva Identification System", "GEN# +1.00010210"},
        {"Smithsonian Astrophysical Observation", "SAO 215598"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.74319845),
        dec: Angle.Degrees(-45.77484723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22934"},
        {"Hipparcos Number", "HIP 17029"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.75695665),
        dec: Angle.Degrees(-45.77438586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99794"},
        {"Hipparcos Number", "HIP 55983"},
        {"Smithsonian Astrophysical Observation", "SAO 222812"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.10654153),
        dec: Angle.Degrees(-45.77428576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207512"},
        {"Hipparcos Number", "HIP 107830"},
        {"Smithsonian Astrophysical Observation", "SAO 230865"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.854,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.67925343),
        dec: Angle.Degrees(-45.77278836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87889"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.29888847),
        dec: Angle.Degrees(-45.77259710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86035"},
        {"Hipparcos Number", "HIP 48603"},
        {"Smithsonian Astrophysical Observation", "SAO 221597"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.67831696),
        dec: Angle.Degrees(-45.77245533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124380"},
        {"Hipparcos Number", "HIP 69568"},
        {"Smithsonian Astrophysical Observation", "SAO 224785"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.59797405),
        dec: Angle.Degrees(-45.77137980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11492"},
        {"Hipparcos Number", "HIP 8695"},
        {"Smithsonian Astrophysical Observation", "SAO 215683"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.96755083),
        dec: Angle.Degrees(-45.77036940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200874"},
        {"Hipparcos Number", "HIP 104292"},
        {"Smithsonian Astrophysical Observation", "SAO 230534"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.92103386),
        dec: Angle.Degrees(-45.76903813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173754"},
        {"Hipparcos Number", "HIP 92345"},
        {"Smithsonian Astrophysical Observation", "SAO 229302"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.30900461),
        dec: Angle.Degrees(-45.76881689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92736"},
        {"Hipparcos Number", "HIP 52332"},
        {"Geneva Identification System", "GEN# +1.00092736"},
        {"Smithsonian Astrophysical Observation", "SAO 222260"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.42046567),
        dec: Angle.Degrees(-45.76869406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -118.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52362"},
        {"Hipparcos Number", "HIP 33590"},
        {"Celescope Catalog", "CEL 1481"},
        {"Geneva Identification System", "GEN# +1.00052362"},
        {"Smithsonian Astrophysical Observation", "SAO 218360"},
    },
    visualMagnitude: 6.23,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.67392127),
        dec: Angle.Degrees(-45.76758269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165493"},
        {"Hipparcos Number", "HIP 88859"},
        {"Geneva Identification System", "GEN# +1.00165493J"},
        {"Renson", "Renson 46660"},
        {"Smithsonian Astrophysical Observation", "SAO 228734"},
        {"Wilson Evans Batten Catalogue", "WEB 15065"},
    },
    visualMagnitude: 6.13,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.12545979),
        dec: Angle.Degrees(-45.76697281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33391"},
        {"Hipparcos Number", "HIP 23861"},
        {"Smithsonian Astrophysical Observation", "SAO 217190"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.92131792),
        dec: Angle.Degrees(-45.76677820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162421"},
        {"Hipparcos Number", "HIP 87549"},
        {"Smithsonian Astrophysical Observation", "SAO 228513"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.28748621),
        dec: Angle.Degrees(-45.76610258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115527"},
        {"Hipparcos Number", "HIP 64925"},
        {"Geneva Identification System", "GEN# +1.00115527"},
        {"Smithsonian Astrophysical Observation", "SAO 224051"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.60385732),
        dec: Angle.Degrees(-45.76461115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87432"},
        {"Hipparcos Number", "HIP 49298"},
        {"Renson", "Renson 25050"},
        {"Smithsonian Astrophysical Observation", "SAO 221737"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.93722734),
        dec: Angle.Degrees(-45.76312102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1410"},
        {"Hipparcos Number", "HIP 1451"},
        {"Smithsonian Astrophysical Observation", "SAO 215041"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.51298695),
        dec: Angle.Degrees(-45.76278665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159809"},
        {"Hipparcos Number", "HIP 86368"},
        {"Geneva Identification System", "GEN# +1.00159809J"},
        {"Smithsonian Astrophysical Observation", "SAO 228233"},
        {"Wilson Evans Batten Catalogue", "WEB 14572"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.72223393),
        dec: Angle.Degrees(-45.75950817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93335"},
        {"Hipparcos Number", "HIP 52629"},
        {"Smithsonian Astrophysical Observation", "SAO 222304"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.43909310),
        dec: Angle.Degrees(-45.75889844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206194"},
        {"Hipparcos Number", "HIP 107113"},
        {"Geneva Identification System", "GEN# +1.00206194"},
        {"Renson", "Renson 57440"},
        {"Smithsonian Astrophysical Observation", "SAO 230796"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44483600),
        dec: Angle.Degrees(-45.75827176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182374"},
        {"Hipparcos Number", "HIP 95578"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.61539139),
        dec: Angle.Degrees(-45.75746262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170523"},
        {"Hipparcos Number", "HIP 90853"},
        {"Geneva Identification System", "GEN# +1.00170523"},
        {"Smithsonian Astrophysical Observation", "SAO 229095"},
        {"Wilson Evans Batten Catalogue", "WEB 15576"},
    },
    visualMagnitude: 5.07,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.00810133),
        dec: Angle.Degrees(-45.75735390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209477"},
        {"Hipparcos Number", "HIP 108994"},
        {"Smithsonian Astrophysical Observation", "SAO 230968"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.20330929),
        dec: Angle.Degrees(-45.75631788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20565"},
        {"Hipparcos Number", "HIP 15258"},
        {"Smithsonian Astrophysical Observation", "SAO 216242"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.20363929),
        dec: Angle.Degrees(-45.75516915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72798"},
        {"Hipparcos Number", "HIP 41941"},
        {"Celescope Catalog", "CEL 2638"},
        {"Geneva Identification System", "GEN# +1.00072798J"},
        {"Smithsonian Astrophysical Observation", "SAO 220086"},
        {"Wilson Evans Batten Catalogue", "WEB 8073"},
    },
    visualMagnitude: 6.36,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.25777973),
        dec: Angle.Degrees(-45.75292764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69856"},
        {"Hipparcos Number", "HIP 40575"},
        {"Geneva Identification System", "GEN# +1.00069856"},
        {"Smithsonian Astrophysical Observation", "SAO 219726"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.25539887),
        dec: Angle.Degrees(-45.75199435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53442"},
        {"Hipparcos Number", "HIP 33969"},
        {"Celescope Catalog", "CEL 1537"},
        {"Geneva Identification System", "GEN# +1.00053442J"},
        {"Smithsonian Astrophysical Observation", "SAO 218405"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.72005432),
        dec: Angle.Degrees(-45.75161715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171882"},
        {"Hipparcos Number", "HIP 91484"},
        {"Smithsonian Astrophysical Observation", "SAO 229169"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.87024885),
        dec: Angle.Degrees(-45.75013459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101158"},
        {"Hipparcos Number", "HIP 56759"},
        {"Geneva Identification System", "GEN# +1.00101158"},
        {"Smithsonian Astrophysical Observation", "SAO 222924"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.54563131),
        dec: Angle.Degrees(-45.74952338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186975"},
        {"Hipparcos Number", "HIP 97539"},
        {"Geneva Identification System", "GEN# +1.00186975"},
        {"Smithsonian Astrophysical Observation", "SAO 229883"},
        {"Wilson Evans Batten Catalogue", "WEB 17152"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.36525994),
        dec: Angle.Degrees(-45.74781248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91578"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.12127592),
        dec: Angle.Degrees(-45.74769218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 496"},
        {"Hipparcos Number", "HIP 765"},
        {"Fundamental Katalog 5th Edition", "FK5 3"},
        {"Geneva Identification System", "GEN# +1.00000496"},
        {"Smithsonian Astrophysical Observation", "SAO 214983"},
        {"Wilson Evans Batten Catalogue", "WEB 129"},
    },
    visualMagnitude: 3.88,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.35224949),
        dec: Angle.Degrees(-45.74698836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39522"},
        {"Hipparcos Number", "HIP 27620"},
        {"Smithsonian Astrophysical Observation", "SAO 217570"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.71993240),
        dec: Angle.Degrees(-45.74476353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113886"},
        {"Hipparcos Number", "HIP 64036"},
        {"Geneva Identification System", "GEN# +1.00113886"},
        {"Smithsonian Astrophysical Observation", "SAO 223911"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.85539924),
        dec: Angle.Degrees(-45.74473119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1696"},
        {"Cincinnati Publication", "Ci 20 23"},
        {"Geneva Identification System", "GEN# -0.04600076"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.33150549),
        dec: Angle.Degrees(-45.74443728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -815.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160898"},
        {"Hipparcos Number", "HIP 86849"},
        {"Smithsonian Astrophysical Observation", "SAO 228361"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.18089730),
        dec: Angle.Degrees(-45.74443709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128726"},
        {"Hipparcos Number", "HIP 71700"},
        {"Geneva Identification System", "GEN# +1.00128726"},
        {"Smithsonian Astrophysical Observation", "SAO 225098"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.00536171),
        dec: Angle.Degrees(-45.74359281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208614"},
        {"Hipparcos Number", "HIP 108486"},
        {"Smithsonian Astrophysical Observation", "SAO 230922"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.65727828),
        dec: Angle.Degrees(-45.74343076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91674"},
        {"Hipparcos Number", "HIP 51730"},
        {"Geneva Identification System", "GEN# +1.00091674"},
        {"Smithsonian Astrophysical Observation", "SAO 222153"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.54149000),
        dec: Angle.Degrees(-45.74180806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -126.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86099"},
        {"Hipparcos Number", "HIP 48640"},
        {"Smithsonian Astrophysical Observation", "SAO 221602"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.77179307),
        dec: Angle.Degrees(-45.74080792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136336"},
        {"Hipparcos Number", "HIP 75184"},
        {"Smithsonian Astrophysical Observation", "SAO 225698"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.46342651),
        dec: Angle.Degrees(-45.73882691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88334"},
        {"Smithsonian Astrophysical Observation", "SAO 228640"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.60054835),
        dec: Angle.Degrees(-45.73793015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67409"},
    },
    visualMagnitude: 11.04,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.23106546),
        dec: Angle.Degrees(-45.73634568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -291.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328425"},
        {"Hipparcos Number", "HIP 81076"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39373269),
        dec: Angle.Degrees(-45.73374954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92704",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92704"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.34150063),
        dec: Angle.Degrees(-45.73371030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85355"},
        {"Hipparcos Number", "HIP 48224"},
        {"Geneva Identification System", "GEN# +1.00085355A"},
        {"Smithsonian Astrophysical Observation", "SAO 221523"},
        {"Wilson Evans Batten Catalogue", "WEB 9001"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.48817288),
        dec: Angle.Degrees(-45.73276023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86006"},
        {"Hipparcos Number", "HIP 48583"},
        {"Geneva Identification System", "GEN# +1.00086006"},
        {"Smithsonian Astrophysical Observation", "SAO 221594"},
        {"Wilson Evans Batten Catalogue", "WEB 9046"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.708,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.62968088),
        dec: Angle.Degrees(-45.73107076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198827"},
        {"Hipparcos Number", "HIP 103215"},
        {"Geneva Identification System", "GEN# +1.00198827"},
        {"Smithsonian Astrophysical Observation", "SAO 230428"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.67164874),
        dec: Angle.Degrees(-45.73068737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98635"},
        {"Hipparcos Number", "HIP 55387"},
        {"Geneva Identification System", "GEN# +1.00098635"},
        {"Smithsonian Astrophysical Observation", "SAO 222730"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.12473219),
        dec: Angle.Degrees(-45.72877078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169611"},
        {"Hipparcos Number", "HIP 90468"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.90538648),
        dec: Angle.Degrees(-45.72873998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205489"},
        {"Hipparcos Number", "HIP 106717"},
        {"Smithsonian Astrophysical Observation", "SAO 230754"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.24845174),
        dec: Angle.Degrees(-45.72591590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41633"},
        {"Hipparcos Number", "HIP 28722"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.00166694),
        dec: Angle.Degrees(-45.72481373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218063"},
        {"Hipparcos Number", "HIP 114036"},
        {"Smithsonian Astrophysical Observation", "SAO 231429"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.39915723),
        dec: Angle.Degrees(-45.72414981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106321"},
        {"Hipparcos Number", "HIP 59654"},
        {"Geneva Identification System", "GEN# +1.00106321"},
        {"Smithsonian Astrophysical Observation", "SAO 223297"},
        {"Wilson Evans Batten Catalogue", "WEB 10598"},
    },
    visualMagnitude: 5.31,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.51136205),
        dec: Angle.Degrees(-45.72393011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8663"},
        {"Hipparcos Number", "HIP 6584"},
        {"Geneva Identification System", "GEN# +1.00008663"},
        {"Smithsonian Astrophysical Observation", "SAO 215491"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.14138525),
        dec: Angle.Degrees(-45.72129627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30488"},
        {"Hipparcos Number", "HIP 22148"},
        {"Smithsonian Astrophysical Observation", "SAO 216984"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.49398484),
        dec: Angle.Degrees(-45.71977896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11077"},
        {"Hipparcos Number", "HIP 8372"},
        {"Smithsonian Astrophysical Observation", "SAO 215657"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.95418308),
        dec: Angle.Degrees(-45.71850774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93538",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93538"},
        {"Smithsonian Astrophysical Observation", "SAO 229457"},
    },
    visualMagnitude: 8.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)19, (int)03, 03.9400),
        dec: Angle.DegreesMinutesSeconds((int)-45, (int)42, 58.700)
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
    primaryId: "HIP 75952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137935"},
        {"Hipparcos Number", "HIP 75952"},
        {"Celescope Catalog", "CEL 4375"},
        {"Smithsonian Astrophysical Observation", "SAO 225850"},
    },
    visualMagnitude: 8.42,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.68986018),
        dec: Angle.Degrees(-45.71591629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135624"},
        {"Hipparcos Number", "HIP 74853"},
        {"Smithsonian Astrophysical Observation", "SAO 225623"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.44938989),
        dec: Angle.Degrees(-45.71490623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59260"},
        {"Hipparcos Number", "HIP 36154"},
        {"Geneva Identification System", "GEN# +1.00059260"},
        {"Smithsonian Astrophysical Observation", "SAO 218730"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.73253114),
        dec: Angle.Degrees(-45.71384343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159262"},
        {"Hipparcos Number", "HIP 86127"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.02126479),
        dec: Angle.Degrees(-45.71272412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176555"},
        {"Hipparcos Number", "HIP 93539"},
        {"Smithsonian Astrophysical Observation", "SAO 229458"},
    },
    visualMagnitude: 7.59,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.77201997),
        dec: Angle.Degrees(-45.71170637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55715"},
    },
    visualMagnitude: 11.53,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.24574794),
        dec: Angle.Degrees(-45.70959758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139206"},
        {"Hipparcos Number", "HIP 76606"},
        {"Celescope Catalog", "CEL 4385"},
        {"Geneva Identification System", "GEN# +1.00139206"},
        {"Smithsonian Astrophysical Observation", "SAO 226010"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.67334088),
        dec: Angle.Degrees(-45.70873228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64317"},
        {"Hipparcos Number", "HIP 38346"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.80924734),
        dec: Angle.Degrees(-45.70761593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29954"},
        {"Hipparcos Number", "HIP 21806"},
        {"Smithsonian Astrophysical Observation", "SAO 216931"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.26448411),
        dec: Angle.Degrees(-45.70485226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198008"},
        {"Hipparcos Number", "HIP 102744"},
        {"Smithsonian Astrophysical Observation", "SAO 230387"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.27973602),
        dec: Angle.Degrees(-45.70331484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170688"},
        {"Hipparcos Number", "HIP 90940"},
        {"Smithsonian Astrophysical Observation", "SAO 229106"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.25949279),
        dec: Angle.Degrees(-45.70167281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139037"},
        {"Hipparcos Number", "HIP 76524"},
        {"Smithsonian Astrophysical Observation", "SAO 225998"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.42149280),
        dec: Angle.Degrees(-45.70104190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204823"},
        {"Hipparcos Number", "HIP 106364"},
        {"Smithsonian Astrophysical Observation", "SAO 230731"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.14154545),
        dec: Angle.Degrees(-45.70028144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136716"},
        {"Hipparcos Number", "HIP 75355"},
        {"Smithsonian Astrophysical Observation", "SAO 225730"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.99275357),
        dec: Angle.Degrees(-45.69969966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167954"},
        {"Hipparcos Number", "HIP 89808"},
        {"Geneva Identification System", "GEN# +1.00167954"},
        {"Smithsonian Astrophysical Observation", "SAO 228906"},
        {"Wilson Evans Batten Catalogue", "WEB 15323"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.92230057),
        dec: Angle.Degrees(-45.69882271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13033"},
        {"Hipparcos Number", "HIP 9818"},
        {"Geneva Identification System", "GEN# +1.00013033"},
        {"Smithsonian Astrophysical Observation", "SAO 215769"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.57606160),
        dec: Angle.Degrees(-45.69650913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43371",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43371"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.51038705),
        dec: Angle.Degrees(-45.69489724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110923"},
        {"Hipparcos Number", "HIP 62290"},
        {"Smithsonian Astrophysical Observation", "SAO 223654"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.47471161),
        dec: Angle.Degrees(-45.69249946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178346"},
        {"Hipparcos Number", "HIP 94186"},
        {"Smithsonian Astrophysical Observation", "SAO 229533"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.62762748),
        dec: Angle.Degrees(-45.69244267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109606"},
        {"Hipparcos Number", "HIP 61511"},
        {"Smithsonian Astrophysical Observation", "SAO 223547"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.04105100),
        dec: Angle.Degrees(-45.69177330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45965"},
        {"Hipparcos Number", "HIP 30797"},
        {"Smithsonian Astrophysical Observation", "SAO 217950"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.06827704),
        dec: Angle.Degrees(-45.69139321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9733"},
        {"Hipparcos Number", "HIP 7327"},
        {"Geneva Identification System", "GEN# +1.00009733"},
        {"Smithsonian Astrophysical Observation", "SAO 215567"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.58568528),
        dec: Angle.Degrees(-45.69137430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102232"},
        {"Hipparcos Number", "HIP 57371"},
        {"Geneva Identification System", "GEN# +1.00102232"},
        {"Renson", "Renson 29480"},
        {"Smithsonian Astrophysical Observation", "SAO 223009"},
        {"Wilson Evans Batten Catalogue", "WEB 10312"},
    },
    visualMagnitude: 5.28,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.43334854),
        dec: Angle.Degrees(-45.69014545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133782"},
        {"Hipparcos Number", "HIP 74039"},
        {"Smithsonian Astrophysical Observation", "SAO 225465"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.97002362),
        dec: Angle.Degrees(-45.68827015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175816"},
        {"Hipparcos Number", "HIP 93220"},
        {"Smithsonian Astrophysical Observation", "SAO 229416"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.83344023),
        dec: Angle.Degrees(-45.68822192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149277"},
        {"Hipparcos Number", "HIP 81255"},
        {"Geneva Identification System", "GEN# +2.61780009"},
        {"Renson", "Renson 42253"},
        {"Smithsonian Astrophysical Observation", "SAO 226941"},
        {"New General Catalogue", "NGC 6178 9"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95065467),
        dec: Angle.Degrees(-45.67875132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10069"},
        {"Hipparcos Number", "HIP 7562"},
        {"Geneva Identification System", "GEN# +1.00010069"},
        {"Smithsonian Astrophysical Observation", "SAO 215585"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.35421593),
        dec: Angle.Degrees(-45.67793111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2597"},
        {"Hipparcos Number", "HIP 2297"},
        {"Geneva Identification System", "GEN# +1.00002597"},
        {"Smithsonian Astrophysical Observation", "SAO 215110"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.32841187),
        dec: Angle.Degrees(-45.67706883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219556"},
        {"Hipparcos Number", "HIP 114967"},
        {"Geneva Identification System", "GEN# +1.00219556"},
        {"Smithsonian Astrophysical Observation", "SAO 231535"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.28351785),
        dec: Angle.Degrees(-45.67703441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115853"},
        {"Hipparcos Number", "HIP 65102"},
        {"Smithsonian Astrophysical Observation", "SAO 224073"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.12720464),
        dec: Angle.Degrees(-45.67691862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76588"},
        {"Hipparcos Number", "HIP 43814"},
        {"Celescope Catalog", "CEL 3085"},
        {"Geneva Identification System", "GEN# +1.00076588"},
        {"Renson", "Renson 21580"},
        {"Smithsonian Astrophysical Observation", "SAO 220667"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.84976011),
        dec: Angle.Degrees(-45.67104165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18608"},
        {"Hipparcos Number", "HIP 13818"},
        {"Smithsonian Astrophysical Observation", "SAO 216110"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.46694228),
        dec: Angle.Degrees(-45.67053539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60032"},
        {"Hipparcos Number", "HIP 36493"},
        {"Smithsonian Astrophysical Observation", "SAO 218770"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62322649),
        dec: Angle.Degrees(-45.66973447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166488"},
        {"Hipparcos Number", "HIP 89273"},
        {"Geneva Identification System", "GEN# +1.00166488"},
        {"Smithsonian Astrophysical Observation", "SAO 228808"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.25752710),
        dec: Angle.Degrees(-45.66882592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31076"},
        {"Hipparcos Number", "HIP 22514"},
        {"Geneva Identification System", "GEN# +1.00031076"},
        {"Smithsonian Astrophysical Observation", "SAO 217035"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.66842384),
        dec: Angle.Degrees(-45.66841032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15792"},
        {"Hipparcos Number", "HIP 11703"},
        {"Smithsonian Astrophysical Observation", "SAO 215928"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.74731988),
        dec: Angle.Degrees(-45.66840509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196666"},
        {"Hipparcos Number", "HIP 102036"},
        {"Smithsonian Astrophysical Observation", "SAO 230319"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.16363051),
        dec: Angle.Degrees(-45.66781466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26074"},
        {"Hipparcos Number", "HIP 19088"},
        {"Geneva Identification System", "GEN# +1.00026074"},
        {"Smithsonian Astrophysical Observation", "SAO 216638"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.39196916),
        dec: Angle.Degrees(-45.66671132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14533"},
        {"Hipparcos Number", "HIP 10837"},
        {"Smithsonian Astrophysical Observation", "SAO 215861"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.86157409),
        dec: Angle.Degrees(-45.66517191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20407"},
        {"Hipparcos Number", "HIP 15131"},
        {"Geneva Identification System", "GEN# +1.00020407"},
        {"Smithsonian Astrophysical Observation", "SAO 216230"},
        {"Wilson Evans Batten Catalogue", "WEB 2915"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.77708474),
        dec: Angle.Degrees(-45.66516723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 141.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142488"},
        {"Hipparcos Number", "HIP 78087"},
        {"Smithsonian Astrophysical Observation", "SAO 226384"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.16915784),
        dec: Angle.Degrees(-45.66462876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65074"},
        {"Hipparcos Number", "HIP 38650"},
        {"Celescope Catalog", "CEL 2097"},
        {"Geneva Identification System", "GEN# +1.00065074"},
        {"Smithsonian Astrophysical Observation", "SAO 219140"},
    },
    visualMagnitude: 7.34,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.70990590),
        dec: Angle.Degrees(-45.66411575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125937"},
        {"Hipparcos Number", "HIP 70362"},
        {"Geneva Identification System", "GEN# +1.00125937"},
        {"Smithsonian Astrophysical Observation", "SAO 224891"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95247888),
        dec: Angle.Degrees(-45.66395767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21319"},
        {"Hipparcos Number", "HIP 15883"},
        {"Smithsonian Astrophysical Observation", "SAO 216302"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.14392580),
        dec: Angle.Degrees(-45.66391936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161745"},
        {"Hipparcos Number", "HIP 87241"},
        {"Smithsonian Astrophysical Observation", "SAO 228454"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.38193417),
        dec: Angle.Degrees(-45.66293666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124416"},
        {"Hipparcos Number", "HIP 69606"},
        {"Smithsonian Astrophysical Observation", "SAO 224789"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.69147759),
        dec: Angle.Degrees(-45.65958770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107716"},
        {"Hipparcos Number", "HIP 60382"},
        {"Renson", "Renson 31230"},
        {"Smithsonian Astrophysical Observation", "SAO 223393"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70940489),
        dec: Angle.Degrees(-45.65898161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87984"},
        {"Hipparcos Number", "HIP 49604"},
        {"Smithsonian Astrophysical Observation", "SAO 221789"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87648089),
        dec: Angle.Degrees(-45.65812238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210194"},
        {"Hipparcos Number", "HIP 109386"},
        {"Smithsonian Astrophysical Observation", "SAO 231002"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.41301928),
        dec: Angle.Degrees(-45.65415216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44430"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.78665071),
        dec: Angle.Degrees(-45.65387104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142936"},
        {"Hipparcos Number", "HIP 78297"},
        {"Smithsonian Astrophysical Observation", "SAO 226420"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.81434681),
        dec: Angle.Degrees(-45.65323609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81258",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81258"},
        {"Geneva Identification System", "GEN# +2.61780007"},
        {"New General Catalogue", "NGC 6178 7"},
    },
    visualMagnitude: 11.30,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.95459065),
        dec: Angle.Degrees(-45.65215739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27471"},
        {"Hipparcos Number", "HIP 20052"},
        {"Fundamental Katalog 5th Edition", "FK5 4395"},
        {"Geneva Identification System", "GEN# +1.00027471"},
        {"Smithsonian Astrophysical Observation", "SAO 216737"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.50040085),
        dec: Angle.Degrees(-45.65119580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221622"},
        {"Hipparcos Number", "HIP 116298"},
        {"Smithsonian Astrophysical Observation", "SAO 231665"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.45945302),
        dec: Angle.Degrees(-45.64906215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101698"},
        {"Hipparcos Number", "HIP 57074"},
        {"Smithsonian Astrophysical Observation", "SAO 222967"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.49894294),
        dec: Angle.Degrees(-45.64905956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38940"},
        {"Hipparcos Number", "HIP 27290"},
        {"Geneva Identification System", "GEN# +1.00038940"},
        {"Smithsonian Astrophysical Observation", "SAO 217530"},
        {"Wilson Evans Batten Catalogue", "WEB 5366"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.74173335),
        dec: Angle.Degrees(-45.64771521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 128.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88601"},
        {"Hipparcos Number", "HIP 49956"},
        {"Smithsonian Astrophysical Observation", "SAO 221854"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.99236113),
        dec: Angle.Degrees(-45.64708062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89611"},
        {"Hipparcos Number", "HIP 50550"},
        {"Smithsonian Astrophysical Observation", "SAO 221959"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.87231836),
        dec: Angle.Degrees(-45.64687004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138581"},
        {"Hipparcos Number", "HIP 76281"},
        {"Smithsonian Astrophysical Observation", "SAO 225924"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.71535068),
        dec: Angle.Degrees(-45.64639340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201788"},
        {"Hipparcos Number", "HIP 104761"},
        {"Smithsonian Astrophysical Observation", "SAO 230580"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.34411268),
        dec: Angle.Degrees(-45.64372313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156385"},
        {"Hipparcos Number", "HIP 84757"},
        {"Celescope Catalog", "CEL 4503"},
        {"Geneva Identification System", "GEN# +1.00156385"},
        {"Smithsonian Astrophysical Observation", "SAO 227822"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.87458917),
        dec: Angle.Degrees(-45.63995670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72751"},
        {"Hipparcos Number", "HIP 41921"},
        {"Celescope Catalog", "CEL 2630"},
        {"Geneva Identification System", "GEN# +1.00072751"},
        {"Smithsonian Astrophysical Observation", "SAO 220081"},
    },
    visualMagnitude: 9.16,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.20335494),
        dec: Angle.Degrees(-45.63745215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160993"},
        {"Hipparcos Number", "HIP 86894"},
        {"Celescope Catalog", "CEL 4563"},
        {"Geneva Identification System", "GEN# +1.00160993"},
        {"Smithsonian Astrophysical Observation", "SAO 228373"},
        {"Wilson Evans Batten Catalogue", "WEB 14657"},
    },
    visualMagnitude: 7.72,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.32361891),
        dec: Angle.Degrees(-45.63701422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154810"},
        {"Hipparcos Number", "HIP 83970"},
        {"Geneva Identification System", "GEN# +1.00154810"},
        {"Smithsonian Astrophysical Observation", "SAO 227680"},
        {"Wilson Evans Batten Catalogue", "WEB 14184"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.46011471),
        dec: Angle.Degrees(-45.63673146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73010"},
        {"Hipparcos Number", "HIP 42041"},
        {"Celescope Catalog", "CEL 2660"},
        {"Geneva Identification System", "GEN# +1.00073010"},
        {"Smithsonian Astrophysical Observation", "SAO 220121"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.54638762),
        dec: Angle.Degrees(-45.63660880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80380"},
        {"Hipparcos Number", "HIP 45625"},
        {"Celescope Catalog", "CEL 3259"},
        {"Geneva Identification System", "GEN# +1.00080380"},
        {"Smithsonian Astrophysical Observation", "SAO 221041"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.49890331),
        dec: Angle.Degrees(-45.63627689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86438"},
        {"Hipparcos Number", "HIP 48808"},
        {"Geneva Identification System", "GEN# +1.00086438"},
        {"Smithsonian Astrophysical Observation", "SAO 221637"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.33162347),
        dec: Angle.Degrees(-45.63253792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77453"},
        {"Hipparcos Number", "HIP 44271"},
        {"Celescope Catalog", "CEL 3143"},
        {"Geneva Identification System", "GEN# +1.00077453"},
        {"Smithsonian Astrophysical Observation", "SAO 220757"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.22643763),
        dec: Angle.Degrees(-45.63174242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45056"},
        {"Hipparcos Number", "HIP 30339"},
        {"Smithsonian Astrophysical Observation", "SAO 217893"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.72993162),
        dec: Angle.Degrees(-45.62893190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13463"},
        {"Hipparcos Number", "HIP 10131"},
        {"Smithsonian Astrophysical Observation", "SAO 215795"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.57046364),
        dec: Angle.Degrees(-45.62593642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108096"},
        {"Hipparcos Number", "HIP 60616"},
        {"Smithsonian Astrophysical Observation", "SAO 223429"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.35401114),
        dec: Angle.Degrees(-45.62542259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106233"},
        {"Hipparcos Number", "HIP 59604"},
        {"Geneva Identification System", "GEN# +1.00106233"},
        {"Smithsonian Astrophysical Observation", "SAO 223289"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.34393162),
        dec: Angle.Degrees(-45.62532266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -203.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75955"},
        {"Hipparcos Number", "HIP 43484"},
        {"Celescope Catalog", "CEL 3005"},
        {"Geneva Identification System", "GEN# +1.00075955"},
        {"Smithsonian Astrophysical Observation", "SAO 220582"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.85847403),
        dec: Angle.Degrees(-45.62297381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38468"},
        {"Hipparcos Number", "HIP 27006"},
        {"Smithsonian Astrophysical Observation", "SAO 217498"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.92895319),
        dec: Angle.Degrees(-45.62123598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199640"},
        {"Hipparcos Number", "HIP 103661"},
        {"Smithsonian Astrophysical Observation", "SAO 230473"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.04591749),
        dec: Angle.Degrees(-45.62021123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45921"},
        {"Hipparcos Number", "HIP 30778"},
        {"Smithsonian Astrophysical Observation", "SAO 217947"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.00910659),
        dec: Angle.Degrees(-45.61923789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212648"},
        {"Hipparcos Number", "HIP 110795"},
        {"Smithsonian Astrophysical Observation", "SAO 231141"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.70423689),
        dec: Angle.Degrees(-45.61897392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127974"},
        {"Hipparcos Number", "HIP 71369"},
        {"Geneva Identification System", "GEN# +1.00127974"},
        {"Smithsonian Astrophysical Observation", "SAO 225048"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.93731549),
        dec: Angle.Degrees(-45.61845102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74106"},
        {"Hipparcos Number", "HIP 42521"},
        {"Celescope Catalog", "CEL 2753"},
        {"Geneva Identification System", "GEN# +1.00074106"},
        {"Smithsonian Astrophysical Observation", "SAO 220251"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.04328771),
        dec: Angle.Degrees(-45.61581660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156979"},
        {"Hipparcos Number", "HIP 85035"},
        {"Geneva Identification System", "GEN# +1.00156979"},
        {"Smithsonian Astrophysical Observation", "SAO 227880"},
        {"Wilson Evans Batten Catalogue", "WEB 14359"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.69366914),
        dec: Angle.Degrees(-45.61426847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51464"},
        {"Hipparcos Number", "HIP 33265"},
        {"Smithsonian Astrophysical Observation", "SAO 218312"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.80165952),
        dec: Angle.Degrees(-45.61274960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10768"},
        {"Hipparcos Number", "HIP 8124"},
        {"Smithsonian Astrophysical Observation", "SAO 215630"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.09753100),
        dec: Angle.Degrees(-45.61220605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71060"},
        {"Hipparcos Number", "HIP 41122"},
        {"Celescope Catalog", "CEL 2463"},
        {"Smithsonian Astrophysical Observation", "SAO 219869"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.86662419),
        dec: Angle.Degrees(-45.61200281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222226"},
        {"Hipparcos Number", "HIP 116699"},
        {"Geneva Identification System", "GEN# +1.00222226"},
        {"Smithsonian Astrophysical Observation", "SAO 231715"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.73180317),
        dec: Angle.Degrees(-45.61181449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8718"},
        {"Hipparcos Number", "HIP 6628"},
        {"Smithsonian Astrophysical Observation", "SAO 215497"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.26227590),
        dec: Angle.Degrees(-45.61149918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115648",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115648"},
        {"Geneva Identification System", "GEN# -0.04614649"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.42344778),
        dec: Angle.Degrees(-45.60972488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 476.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17399"},
        {"Hipparcos Number", "HIP 12903"},
        {"Geneva Identification System", "GEN# +1.00017399"},
        {"Smithsonian Astrophysical Observation", "SAO 216042"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.46948212),
        dec: Angle.Degrees(-45.60746230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221418"},
        {"Hipparcos Number", "HIP 116171"},
        {"Smithsonian Astrophysical Observation", "SAO 231651"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.07898667),
        dec: Angle.Degrees(-45.60638119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122223"},
        {"Hipparcos Number", "HIP 68523"},
        {"Geneva Identification System", "GEN# +1.00122223"},
        {"Smithsonian Astrophysical Observation", "SAO 224621"},
        {"Wilson Evans Batten Catalogue", "WEB 12002"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.43121648),
        dec: Angle.Degrees(-45.60336989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93937"},
        {"Hipparcos Number", "HIP 52963"},
        {"Smithsonian Astrophysical Observation", "SAO 222365"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.48373013),
        dec: Angle.Degrees(-45.60301820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94622"},
        {"Hipparcos Number", "HIP 53357"},
        {"Geneva Identification System", "GEN# +1.00094622"},
        {"Smithsonian Astrophysical Observation", "SAO 222418"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.68184773),
        dec: Angle.Degrees(-45.60287684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16976"},
        {"Hipparcos Number", "HIP 12583"},
        {"Smithsonian Astrophysical Observation", "SAO 216010"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.44907124),
        dec: Angle.Degrees(-45.60277662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123246"},
        {"Hipparcos Number", "HIP 68991"},
        {"Smithsonian Astrophysical Observation", "SAO 224697"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.86789193),
        dec: Angle.Degrees(-45.60133948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -169.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162123"},
        {"Hipparcos Number", "HIP 87404"},
        {"Geneva Identification System", "GEN# +1.00162123"},
        {"Smithsonian Astrophysical Observation", "SAO 228490"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.93562958),
        dec: Angle.Degrees(-45.60068694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32588"},
        {"Hipparcos Number", "HIP 23424"},
        {"Smithsonian Astrophysical Observation", "SAO 217130"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.51566682),
        dec: Angle.Degrees(-45.59940723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129221"},
        {"Hipparcos Number", "HIP 71941"},
        {"Geneva Identification System", "GEN# +1.00129221"},
        {"Smithsonian Astrophysical Observation", "SAO 225142"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.70461691),
        dec: Angle.Degrees(-45.59754051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69129"},
        {"Hipparcos Number", "HIP 40286"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.40152752),
        dec: Angle.Degrees(-45.59658298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28874"},
        {"Hipparcos Number", "HIP 21057"},
        {"Smithsonian Astrophysical Observation", "SAO 216849"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.70246036),
        dec: Angle.Degrees(-45.59651383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166835"},
        {"Hipparcos Number", "HIP 89409"},
        {"Smithsonian Astrophysical Observation", "SAO 228838"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68442101),
        dec: Angle.Degrees(-45.59519311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20262"},
        {"Hipparcos Number", "HIP 15032"},
        {"Smithsonian Astrophysical Observation", "SAO 216222"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.42321017),
        dec: Angle.Degrees(-45.59494358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47657"},
        {"Hipparcos Number", "HIP 31653"},
        {"Geneva Identification System", "GEN# +1.00047657J"},
        {"Smithsonian Astrophysical Observation", "SAO 218067"},
    },
    visualMagnitude: 8.29,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.37639769),
        dec: Angle.Degrees(-45.59431813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194350"},
        {"Hipparcos Number", "HIP 100853"},
        {"Smithsonian Astrophysical Observation", "SAO 230209"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.72632529),
        dec: Angle.Degrees(-45.59351297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200672"},
        {"Hipparcos Number", "HIP 104169"},
        {"Geneva Identification System", "GEN# +1.00200672"},
        {"Smithsonian Astrophysical Observation", "SAO 230520"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.59292298),
        dec: Angle.Degrees(-45.59155097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130997"},
        {"Hipparcos Number", "HIP 72793"},
        {"Geneva Identification System", "GEN# +1.00130997"},
        {"Smithsonian Astrophysical Observation", "SAO 225264"},
        {"Wilson Evans Batten Catalogue", "WEB 12506"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.17907689),
        dec: Angle.Degrees(-45.59067499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191796"},
        {"Hipparcos Number", "HIP 99671"},
        {"Geneva Identification System", "GEN# +1.00191796"},
        {"Renson", "Renson 53460"},
        {"Smithsonian Astrophysical Observation", "SAO 230108"},
    },
    visualMagnitude: 7.79,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.39481877),
        dec: Angle.Degrees(-45.59056791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102611"},
        {"Hipparcos Number", "HIP 57605"},
        {"Smithsonian Astrophysical Observation", "SAO 223036"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.15550977),
        dec: Angle.Degrees(-45.58753258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195029"},
        {"Hipparcos Number", "HIP 101194"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.68164726),
        dec: Angle.Degrees(-45.58695564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205591"},
        {"Hipparcos Number", "HIP 106782"},
        {"Geneva Identification System", "GEN# +1.00205591"},
        {"Smithsonian Astrophysical Observation", "SAO 230762"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.42996767),
        dec: Angle.Degrees(-45.58558038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327627"},
        {"Hipparcos Number", "HIP 77945"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.76244396),
        dec: Angle.Degrees(-45.58510146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215342"},
        {"Hipparcos Number", "HIP 112330"},
        {"Smithsonian Astrophysical Observation", "SAO 231274"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.29149850),
        dec: Angle.Degrees(-45.58488871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97201"},
        {"Hipparcos Number", "HIP 54624"},
        {"Smithsonian Astrophysical Observation", "SAO 222619"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.70858182),
        dec: Angle.Degrees(-45.58431793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164724"},
        {"Hipparcos Number", "HIP 88544"},
        {"Smithsonian Astrophysical Observation", "SAO 228676"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.20457296),
        dec: Angle.Degrees(-45.58370001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55400"},
        {"Hipparcos Number", "HIP 34654"},
        {"Smithsonian Astrophysical Observation", "SAO 218507"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.65823235),
        dec: Angle.Degrees(-45.58126270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105313"},
        {"Hipparcos Number", "HIP 59133"},
        {"Geneva Identification System", "GEN# +1.00105313"},
        {"Smithsonian Astrophysical Observation", "SAO 223226"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.88649287),
        dec: Angle.Degrees(-45.58115953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273665"},
        {"Hipparcos Number", "HIP 24733"},
        {"Geneva Identification System", "GEN# +1.00273665"},
        {"Smithsonian Astrophysical Observation", "SAO 217277"},
    },
    visualMagnitude: 10.14,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.56052125),
        dec: Angle.Degrees(-45.57974636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133822"},
        {"Hipparcos Number", "HIP 74049"},
        {"Geneva Identification System", "GEN# +1.00133822"},
        {"Smithsonian Astrophysical Observation", "SAO 225468"},
        {"Wilson Evans Batten Catalogue", "WEB 12647"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.99102349),
        dec: Angle.Degrees(-45.57913355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102004"},
        {"Hipparcos Number", "HIP 57237"},
        {"Smithsonian Astrophysical Observation", "SAO 222986"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.03748962),
        dec: Angle.Degrees(-45.57856989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40250"},
        {"Hipparcos Number", "HIP 27999"},
        {"Smithsonian Astrophysical Observation", "SAO 217619"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.83473648),
        dec: Angle.Degrees(-45.57832231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65685"},
        {"Hipparcos Number", "HIP 38917"},
        {"Geneva Identification System", "GEN# +1.00065685"},
        {"Smithsonian Astrophysical Observation", "SAO 219218"},
        {"Wilson Evans Batten Catalogue", "WEB 7628"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.46555642),
        dec: Angle.Degrees(-45.57774475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204468"},
        {"Hipparcos Number", "HIP 106158"},
        {"Smithsonian Astrophysical Observation", "SAO 230715"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.54511054),
        dec: Angle.Degrees(-45.57706583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79134"},
        {"Hipparcos Number", "HIP 45060"},
        {"Smithsonian Astrophysical Observation", "SAO 220923"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.67051239),
        dec: Angle.Degrees(-45.57663956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7115",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9414"},
        {"Hipparcos Number", "HIP 7115"},
        {"Geneva Identification System", "GEN# +1.00009414J"},
        {"Smithsonian Astrophysical Observation", "SAO 215539"},
    },
    visualMagnitude: 6.17,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.91256447),
        dec: Angle.Degrees(-45.57572379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123485"},
        {"Hipparcos Number", "HIP 69130"},
        {"Smithsonian Astrophysical Observation", "SAO 224722"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.25920526),
        dec: Angle.Degrees(-45.57515984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98287"},
        {"Hipparcos Number", "HIP 55180"},
        {"Smithsonian Astrophysical Observation", "SAO 222703"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.47140909),
        dec: Angle.Degrees(-45.57363417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273436"},
        {"Hipparcos Number", "HIP 23853"},
        {"Smithsonian Astrophysical Observation", "SAO 217188"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90991431),
        dec: Angle.Degrees(-45.57356957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89411"},
        {"Hipparcos Number", "HIP 50460"},
        {"Smithsonian Astrophysical Observation", "SAO 221945"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.54419987),
        dec: Angle.Degrees(-45.57313219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200282"},
        {"Hipparcos Number", "HIP 103985"},
        {"Smithsonian Astrophysical Observation", "SAO 230502"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.02849617),
        dec: Angle.Degrees(-45.57237937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174473"},
        {"Hipparcos Number", "HIP 92658"},
        {"Smithsonian Astrophysical Observation", "SAO 229341"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.22670597),
        dec: Angle.Degrees(-45.57108650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82436"},
        {"Hipparcos Number", "HIP 46630"},
        {"Geneva Identification System", "GEN# +1.00082436"},
        {"Smithsonian Astrophysical Observation", "SAO 221233"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.63806943),
        dec: Angle.Degrees(-45.57061710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24577"},
        {"Hipparcos Number", "HIP 18134"},
        {"Geneva Identification System", "GEN# +1.00024577"},
        {"Smithsonian Astrophysical Observation", "SAO 216533"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.15817822),
        dec: Angle.Degrees(-45.57027237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40269",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40269"},
    },
    visualMagnitude: 11.13,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.34523400),
        dec: Angle.Degrees(-45.56949998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111299"},
        {"Hipparcos Number", "HIP 62521"},
        {"Smithsonian Astrophysical Observation", "SAO 223680"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.19365289),
        dec: Angle.Degrees(-45.56918228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222096"},
        {"Hipparcos Number", "HIP 116601"},
        {"Smithsonian Astrophysical Observation", "SAO 231706"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.45835322),
        dec: Angle.Degrees(-45.56875811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212965"},
        {"Hipparcos Number", "HIP 110970"},
        {"Smithsonian Astrophysical Observation", "SAO 231153"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.24927180),
        dec: Angle.Degrees(-45.56716289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50126"},
        {"Hipparcos Number", "HIP 32715"},
        {"Celescope Catalog", "CEL 1402"},
        {"Geneva Identification System", "GEN# +1.00050126J"},
        {"Smithsonian Astrophysical Observation", "SAO 218228"},
    },
    visualMagnitude: 7.11,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.38159238),
        dec: Angle.Degrees(-45.56691051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273604"},
        {"Hipparcos Number", "HIP 24395"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.50353508),
        dec: Angle.Degrees(-45.56501184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90520"},
        {"Hipparcos Number", "HIP 51078"},
        {"Geneva Identification System", "GEN# +1.00090520"},
        {"Smithsonian Astrophysical Observation", "SAO 222050"},
        {"Wilson Evans Batten Catalogue", "WEB 9340"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.54466259),
        dec: Angle.Degrees(-45.56273813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109889"},
        {"Hipparcos Number", "HIP 61675"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.825,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.64547165),
        dec: Angle.Degrees(-45.56211149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74599"},
        {"Hipparcos Number", "HIP 42788"},
        {"Geneva Identification System", "GEN# +1.00074599"},
        {"Smithsonian Astrophysical Observation", "SAO 220339"},
    },
    visualMagnitude: 6.87,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.77869853),
        dec: Angle.Degrees(-45.56175868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197789"},
        {"Hipparcos Number", "HIP 102604"},
        {"Smithsonian Astrophysical Observation", "SAO 230373"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.89878631),
        dec: Angle.Degrees(-45.56119121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21659"},
        {"Hipparcos Number", "HIP 16141"},
        {"Smithsonian Astrophysical Observation", "SAO 216335"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.99443737),
        dec: Angle.Degrees(-45.56117774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48151"},
        {"Hipparcos Number", "HIP 31868"},
        {"Geneva Identification System", "GEN# +1.00048151"},
        {"Smithsonian Astrophysical Observation", "SAO 218110"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.92655842),
        dec: Angle.Degrees(-45.56054316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196014"},
        {"Hipparcos Number", "HIP 101671"},
        {"Smithsonian Astrophysical Observation", "SAO 230292"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.12707891),
        dec: Angle.Degrees(-45.55791669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5992"},
        {"Hipparcos Number", "HIP 4722"},
        {"Smithsonian Astrophysical Observation", "SAO 215326"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.16407858),
        dec: Angle.Degrees(-45.55656329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79900"},
        {"Hipparcos Number", "HIP 45413"},
        {"Celescope Catalog", "CEL 3243"},
        {"Geneva Identification System", "GEN# +1.00079900J"},
        {"Smithsonian Astrophysical Observation", "SAO 220998"},
    },
    visualMagnitude: 6.25,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.81100525),
        dec: Angle.Degrees(-45.55549346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4025"},
        {"Hipparcos Number", "HIP 3318"},
        {"Geneva Identification System", "GEN# +1.00004025"},
        {"Smithsonian Astrophysical Observation", "SAO 215200"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.57684820),
        dec: Angle.Degrees(-45.55104330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11198"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.05002887),
        dec: Angle.Degrees(-45.54984940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22230"},
        {"Hipparcos Number", "HIP 16533"},
        {"Smithsonian Astrophysical Observation", "SAO 216378"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.22890704),
        dec: Angle.Degrees(-45.54984476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61689"},
        {"Hipparcos Number", "HIP 37187"},
        {"Geneva Identification System", "GEN# +1.00061689"},
        {"Renson", "Renson 16930"},
        {"Smithsonian Astrophysical Observation", "SAO 218851"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.60382239),
        dec: Angle.Degrees(-45.54687540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103729"},
        {"Hipparcos Number", "HIP 58233"},
        {"Geneva Identification System", "GEN# +1.00103729"},
        {"Smithsonian Astrophysical Observation", "SAO 223125"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.16184108),
        dec: Angle.Degrees(-45.54677086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85024"},
        {"Hipparcos Number", "HIP 48064"},
        {"Smithsonian Astrophysical Observation", "SAO 221497"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.96700635),
        dec: Angle.Degrees(-45.54656822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215355"},
        {"Hipparcos Number", "HIP 112337"},
        {"Smithsonian Astrophysical Observation", "SAO 231275"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.31021525),
        dec: Angle.Degrees(-45.54634637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223711"},
        {"Hipparcos Number", "HIP 117687"},
        {"Smithsonian Astrophysical Observation", "SAO 231818"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.00988277),
        dec: Angle.Degrees(-45.54615900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128760"},
        {"Hipparcos Number", "HIP 71719"},
        {"Geneva Identification System", "GEN# +1.00128760"},
        {"Smithsonian Astrophysical Observation", "SAO 225102"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.05287328),
        dec: Angle.Degrees(-45.54592056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221487"},
        {"Hipparcos Number", "HIP 116216"},
        {"Smithsonian Astrophysical Observation", "SAO 231656"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.20946685),
        dec: Angle.Degrees(-45.54578110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193213"},
        {"Hipparcos Number", "HIP 100336"},
        {"Geneva Identification System", "GEN# +1.00193213J"},
        {"Smithsonian Astrophysical Observation", "SAO 230165"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.22494792),
        dec: Angle.Degrees(-45.54530737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118751"},
        {"Hipparcos Number", "HIP 66647"},
        {"Smithsonian Astrophysical Observation", "SAO 224314"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.93465489),
        dec: Angle.Degrees(-45.54444152)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108747"},
        {"Hipparcos Number", "HIP 60972"},
        {"Smithsonian Astrophysical Observation", "SAO 223470"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.48092059),
        dec: Angle.Degrees(-45.54339026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158456"},
        {"Hipparcos Number", "HIP 85780"},
        {"Geneva Identification System", "GEN# +1.00158456"},
        {"Smithsonian Astrophysical Observation", "SAO 228071"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.92426392),
        dec: Angle.Degrees(-45.54107869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20464"},
        {"Hipparcos Number", "HIP 15186"},
        {"Smithsonian Astrophysical Observation", "SAO 216235"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.93500678),
        dec: Angle.Degrees(-45.54085632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100837"},
        {"Hipparcos Number", "HIP 56591"},
        {"Smithsonian Astrophysical Observation", "SAO 222898"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.03095723),
        dec: Angle.Degrees(-45.54020557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117145"},
        {"Hipparcos Number", "HIP 65798"},
        {"Geneva Identification System", "GEN# +1.00117145"},
        {"Smithsonian Astrophysical Observation", "SAO 224175"},
    },
    visualMagnitude: 6.61,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.31699348),
        dec: Angle.Degrees(-45.53776432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97114"},
        {"Hipparcos Number", "HIP 54583"},
        {"Smithsonian Astrophysical Observation", "SAO 222610"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.55674144),
        dec: Angle.Degrees(-45.53551145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7570"},
        {"Hipparcos Number", "HIP 5862"},
        {"Cincinnati Publication", "Ci 20 87"},
        {"Geneva Identification System", "GEN# +1.00007570"},
        {"Smithsonian Astrophysical Observation", "SAO 215428"},
        {"Wilson Evans Batten Catalogue", "WEB 1335"},
    },
    visualMagnitude: 4.97,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.79403213),
        dec: Angle.Degrees(-45.53209717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 664.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 178.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45789"},
        {"Celescope Catalog", "CEL 3270"},
        {"Geneva Identification System", "GEN# -0.04505058"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.04227430),
        dec: Angle.Degrees(-45.53192917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63707"},
        {"Smithsonian Astrophysical Observation", "SAO 157681"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.83900480),
        dec: Angle.Degrees(-16.27952804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117737"},
        {"Hipparcos Number", "HIP 66105"},
        {"Smithsonian Astrophysical Observation", "SAO 224236"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.26441587),
        dec: Angle.Degrees(-45.53038180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171308"},
        {"Hipparcos Number", "HIP 91209"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.09001657),
        dec: Angle.Degrees(-45.52876385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116310"},
        {"Hipparcos Number", "HIP 65342"},
        {"Smithsonian Astrophysical Observation", "SAO 224101"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.88611774),
        dec: Angle.Degrees(-45.52115481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101176",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101176"},
        {"Geneva Identification System", "GEN# -0.04513852"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.61883706),
        dec: Angle.Degrees(-45.52113034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217084"},
        {"Hipparcos Number", "HIP 113454"},
        {"Geneva Identification System", "GEN# +1.00217084"},
        {"Smithsonian Astrophysical Observation", "SAO 231376"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.65144845),
        dec: Angle.Degrees(-45.51945623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95150"},
        {"Hipparcos Number", "HIP 53646"},
        {"Smithsonian Astrophysical Observation", "SAO 222461"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.63021192),
        dec: Angle.Degrees(-45.51939736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140351"},
        {"Hipparcos Number", "HIP 77145"},
        {"Smithsonian Astrophysical Observation", "SAO 226146"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.26372929),
        dec: Angle.Degrees(-45.51858319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26613"},
        {"Hipparcos Number", "HIP 19492"},
        {"Geneva Identification System", "GEN# +1.00026613"},
        {"Smithsonian Astrophysical Observation", "SAO 216681"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.63126619),
        dec: Angle.Degrees(-45.51482305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4419"},
        {"Hipparcos Number", "HIP 3595"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.50968277),
        dec: Angle.Degrees(-45.51366546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137247"},
        {"Hipparcos Number", "HIP 75594"},
        {"Smithsonian Astrophysical Observation", "SAO 225782"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.67316729),
        dec: Angle.Degrees(-45.51328967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218507"},
        {"Hipparcos Number", "HIP 114314"},
        {"Smithsonian Astrophysical Observation", "SAO 231458"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.26653079),
        dec: Angle.Degrees(-45.51166043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158747"},
        {"Hipparcos Number", "HIP 85902"},
        {"Celescope Catalog", "CEL 4526"},
        {"Geneva Identification System", "GEN# +1.00158747J"},
        {"Smithsonian Astrophysical Observation", "SAO 228107"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.30856547),
        dec: Angle.Degrees(-45.51127495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28573"},
        {"Hipparcos Number", "HIP 20847"},
        {"Smithsonian Astrophysical Observation", "SAO 216822"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01421777),
        dec: Angle.Degrees(-45.50608299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214705"},
        {"Hipparcos Number", "HIP 111975"},
        {"Geneva Identification System", "GEN# +1.00214705"},
        {"Smithsonian Astrophysical Observation", "SAO 231245"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.21948302),
        dec: Angle.Degrees(-45.50598382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5218"},
        {"Hipparcos Number", "HIP 4177"},
        {"Smithsonian Astrophysical Observation", "SAO 215279"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.33425703),
        dec: Angle.Degrees(-45.50574853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98286"},
        {"Hipparcos Number", "HIP 55179"},
        {"Geneva Identification System", "GEN# +1.00098286"},
        {"Smithsonian Astrophysical Observation", "SAO 222702"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.46402856),
        dec: Angle.Degrees(-45.50574570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141645"},
        {"Hipparcos Number", "HIP 77720"},
        {"Smithsonian Astrophysical Observation", "SAO 226306"},
    },
    visualMagnitude: 7.49,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.00679540),
        dec: Angle.Degrees(-45.50514198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18466"},
        {"Geneva Identification System", "GEN# -0.04501339"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.19922336),
        dec: Angle.Degrees(-45.50383486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 209.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57966"},
        {"Hipparcos Number", "HIP 35653"},
        {"Celescope Catalog", "CEL 1804"},
        {"Smithsonian Astrophysical Observation", "SAO 218664"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.34644489),
        dec: Angle.Degrees(-45.50348626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165536"},
        {"Hipparcos Number", "HIP 88885"},
        {"Smithsonian Astrophysical Observation", "SAO 228737"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.18811306),
        dec: Angle.Degrees(-45.50339550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157888"},
        {"Hipparcos Number", "HIP 85485"},
        {"Smithsonian Astrophysical Observation", "SAO 227996"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.05785653),
        dec: Angle.Degrees(-45.50233918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154025"},
        {"Hipparcos Number", "HIP 83594"},
        {"Celescope Catalog", "CEL 4474"},
        {"Geneva Identification System", "GEN# +1.00154025"},
        {"Smithsonian Astrophysical Observation", "SAO 227601"},
    },
    visualMagnitude: 6.28,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.27246159),
        dec: Angle.Degrees(-45.50204313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29286",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29286"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.61968958),
        dec: Angle.Degrees(-45.50141933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82121"},
        {"Hipparcos Number", "HIP 46470"},
        {"Geneva Identification System", "GEN# +1.00082121"},
        {"Smithsonian Astrophysical Observation", "SAO 221200"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.16612415),
        dec: Angle.Degrees(-45.50036542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82109"},
        {"Hipparcos Number", "HIP 46465"},
        {"Geneva Identification System", "GEN# +1.00082109"},
        {"Smithsonian Astrophysical Observation", "SAO 221199"},
    },
    visualMagnitude: 7.13,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.14245767),
        dec: Angle.Degrees(-45.49775477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144694"},
        {"Hipparcos Number", "HIP 79128"},
        {"Smithsonian Astrophysical Observation", "SAO 226536"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.27158564),
        dec: Angle.Degrees(-45.49749525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83690"},
        {"Hipparcos Number", "HIP 47341"},
        {"Smithsonian Astrophysical Observation", "SAO 221365"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.70375759),
        dec: Angle.Degrees(-45.49703887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118998"},
        {"Hipparcos Number", "HIP 66802"},
        {"Smithsonian Astrophysical Observation", "SAO 224338"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.40252332),
        dec: Angle.Degrees(-45.49374950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222095"},
        {"Hipparcos Number", "HIP 116602"},
        {"Fundamental Katalog 5th Edition", "FK5 889"},
        {"Geneva Identification System", "GEN# +1.00222095"},
        {"Renson", "Renson 60850"},
        {"Smithsonian Astrophysical Observation", "SAO 231707"},
        {"Wilson Evans Batten Catalogue", "WEB 20585"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.46223051),
        dec: Angle.Degrees(-45.49232134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209466"},
        {"Hipparcos Number", "HIP 108987"},
        {"Smithsonian Astrophysical Observation", "SAO 230967"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.18978514),
        dec: Angle.Degrees(-45.49040049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174779"},
        {"Hipparcos Number", "HIP 92788"},
        {"Geneva Identification System", "GEN# +1.00174779"},
        {"Renson", "Renson 48940"},
        {"Smithsonian Astrophysical Observation", "SAO 229359"},
    },
    visualMagnitude: 6.65,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62126995),
        dec: Angle.Degrees(-45.48625870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1880"},
        {"Hipparcos Number", "HIP 1814"},
        {"Smithsonian Astrophysical Observation", "SAO 215073"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.75282769),
        dec: Angle.Degrees(-45.48625492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27978"},
        {"Hipparcos Number", "HIP 20445"},
        {"Smithsonian Astrophysical Observation", "SAO 216770"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.69947309),
        dec: Angle.Degrees(-45.48550439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103220"},
        {"Hipparcos Number", "HIP 57948"},
        {"Geneva Identification System", "GEN# +1.00103220"},
        {"Smithsonian Astrophysical Observation", "SAO 223086"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.27009282),
        dec: Angle.Degrees(-45.48376731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6792"},
        {"Hipparcos Number", "HIP 5308"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.97779978),
        dec: Angle.Degrees(-45.48320141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117211"},
        {"Hipparcos Number", "HIP 65820"},
        {"Smithsonian Astrophysical Observation", "SAO 224181"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.39961662),
        dec: Angle.Degrees(-45.48268922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135309"},
        {"Hipparcos Number", "HIP 74710"},
        {"Smithsonian Astrophysical Observation", "SAO 225599"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.02850233),
        dec: Angle.Degrees(-45.48123050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92102"},
        {"Hipparcos Number", "HIP 51976"},
        {"Smithsonian Astrophysical Observation", "SAO 222197"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.30141272),
        dec: Angle.Degrees(-45.48110027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90261"},
        {"Geneva Identification System", "GEN# -0.04512460"},
        {"Wilson Evans Batten Catalogue", "WEB 15443"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.25774469),
        dec: Angle.Degrees(-45.47932372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -208.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202846"},
        {"Hipparcos Number", "HIP 105322"},
        {"Geneva Identification System", "GEN# +1.00202846"},
        {"Smithsonian Astrophysical Observation", "SAO 230632"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.99487486),
        dec: Angle.Degrees(-45.47871863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222013"},
        {"Hipparcos Number", "HIP 116554"},
        {"Geneva Identification System", "GEN# +1.00222013"},
        {"Smithsonian Astrophysical Observation", "SAO 231702"},
        {"Smithsonian Astrophysical Observation 2", "SAO 231703"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.31380797),
        dec: Angle.Degrees(-45.47522245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -198.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67675"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.96979824),
        dec: Angle.Degrees(-45.47400758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11437"},
        {"Hipparcos Number", "HIP 8642"},
        {"Smithsonian Astrophysical Observation", "SAO 215681"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.86057251),
        dec: Angle.Degrees(-45.47109888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50834"},
        {"Geneva Identification System", "GEN# -0.04406435"},
        {"Smithsonian Astrophysical Observation", "SAO 222005"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.69562997),
        dec: Angle.Degrees(-45.47062952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157005"},
        {"Hipparcos Number", "HIP 85058"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.74993174),
        dec: Angle.Degrees(-45.47049990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121852"},
        {"Hipparcos Number", "HIP 68323"},
        {"Geneva Identification System", "GEN# +1.00121852"},
        {"Smithsonian Astrophysical Observation", "SAO 224592"},
        {"Wilson Evans Batten Catalogue", "WEB 11988"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.79044717),
        dec: Angle.Degrees(-45.46881222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218959"},
        {"Hipparcos Number", "HIP 114581"},
        {"Smithsonian Astrophysical Observation", "SAO 231487"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.18622490),
        dec: Angle.Degrees(-45.46872013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137361"},
        {"Hipparcos Number", "HIP 75654"},
        {"Smithsonian Astrophysical Observation", "SAO 225801"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.84558135),
        dec: Angle.Degrees(-45.46776099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13388"},
        {"Hipparcos Number", "HIP 10067"},
        {"Geneva Identification System", "GEN# +1.00013388"},
        {"Smithsonian Astrophysical Observation", "SAO 215789"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39059372),
        dec: Angle.Degrees(-45.46672168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167757"},
        {"Hipparcos Number", "HIP 89748"},
        {"Smithsonian Astrophysical Observation", "SAO 228900"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.73078430),
        dec: Angle.Degrees(-45.46650467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171645"},
        {"Hipparcos Number", "HIP 91383"},
        {"Geneva Identification System", "GEN# +1.00171645"},
        {"Smithsonian Astrophysical Observation", "SAO 229160"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.57410870),
        dec: Angle.Degrees(-45.46619872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179886"},
        {"Hipparcos Number", "HIP 94712"},
        {"Geneva Identification System", "GEN# +1.00179886"},
        {"Smithsonian Astrophysical Observation", "SAO 229584"},
        {"Wilson Evans Batten Catalogue", "WEB 16516"},
    },
    visualMagnitude: 5.38,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.09059981),
        dec: Angle.Degrees(-45.46606262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7197"},
        {"Hipparcos Number", "HIP 5583"},
        {"Smithsonian Astrophysical Observation", "SAO 215404"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.89778714),
        dec: Angle.Degrees(-45.46521891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74579"},
        {"Hipparcos Number", "HIP 42771"},
        {"Geneva Identification System", "GEN# +1.00074579"},
        {"Smithsonian Astrophysical Observation", "SAO 220331"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72578030),
        dec: Angle.Degrees(-45.46366328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82515"},
        {"Hipparcos Number", "HIP 46686"},
        {"Geneva Identification System", "GEN# +1.00082515"},
        {"Smithsonian Astrophysical Observation", "SAO 221241"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.76450093),
        dec: Angle.Degrees(-45.46250366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222804"},
        {"Hipparcos Number", "HIP 117060"},
        {"Geneva Identification System", "GEN# +1.00222804"},
        {"Smithsonian Astrophysical Observation", "SAO 231754"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.97487961),
        dec: Angle.Degrees(-45.46241097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152078"},
        {"Hipparcos Number", "HIP 82617"},
        {"Celescope Catalog", "CEL 4435"},
        {"Geneva Identification System", "GEN# +1.00152078"},
        {"Smithsonian Astrophysical Observation", "SAO 227348"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.34630791),
        dec: Angle.Degrees(-45.46084726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151113"},
        {"Hipparcos Number", "HIP 82193"},
        {"Celescope Catalog", "CEL 4426"},
        {"Geneva Identification System", "GEN# +1.00151113J"},
        {"Smithsonian Astrophysical Observation", "SAO 227214"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.87642032),
        dec: Angle.Degrees(-45.46052002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109135"},
        {"Hipparcos Number", "HIP 61220"},
        {"Geneva Identification System", "GEN# +1.00109135"},
        {"Smithsonian Astrophysical Observation", "SAO 223500"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.18206112),
        dec: Angle.Degrees(-45.45963912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95850"},
    },
    visualMagnitude: 11.11,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.41876882),
        dec: Angle.Degrees(-45.45813001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110003"},
        {"Hipparcos Number", "HIP 61755"},
        {"Smithsonian Astrophysical Observation", "SAO 223576"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.84632646),
        dec: Angle.Degrees(-45.45770909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66190"},
        {"Hipparcos Number", "HIP 39137"},
        {"Geneva Identification System", "GEN# +1.00066190"},
        {"Smithsonian Astrophysical Observation", "SAO 219280"},
    },
    visualMagnitude: 6.62,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.08139500),
        dec: Angle.Degrees(-45.45696814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163378"},
        {"Hipparcos Number", "HIP 87957"},
        {"Smithsonian Astrophysical Observation", "SAO 228581"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.52092504),
        dec: Angle.Degrees(-45.45638634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218693"},
        {"Hipparcos Number", "HIP 114443"},
        {"Geneva Identification System", "GEN# +1.00218693"},
        {"Smithsonian Astrophysical Observation", "SAO 231471"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.65972634),
        dec: Angle.Degrees(-45.45627552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102964"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.91376538),
        dec: Angle.Degrees(-45.45608360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217139"},
        {"Hipparcos Number", "HIP 113490"},
        {"Geneva Identification System", "GEN# +1.00217139"},
        {"Smithsonian Astrophysical Observation", "SAO 231378"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.75836689),
        dec: Angle.Degrees(-45.45598438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91303"},
        {"Hipparcos Number", "HIP 51537"},
        {"Renson", "Renson 26270"},
        {"Smithsonian Astrophysical Observation", "SAO 222120"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.89671624),
        dec: Angle.Degrees(-45.45431849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143120"},
        {"Hipparcos Number", "HIP 78408"},
        {"Geneva Identification System", "GEN# +1.00143120"},
        {"Smithsonian Astrophysical Observation", "SAO 226434"},
        {"Wilson Evans Batten Catalogue", "WEB 13252"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.09639621),
        dec: Angle.Degrees(-45.45244409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153258"},
        {"Hipparcos Number", "HIP 83230"},
        {"Geneva Identification System", "GEN# +1.00153258"},
        {"Smithsonian Astrophysical Observation", "SAO 227547"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.13484427),
        dec: Angle.Degrees(-45.45175080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50196"},
        {"Hipparcos Number", "HIP 32771"},
        {"Geneva Identification System", "GEN# +1.00050196"},
        {"Smithsonian Astrophysical Observation", "SAO 218236"},
        {"Wilson Evans Batten Catalogue", "WEB 6601"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.49039986),
        dec: Angle.Degrees(-45.45025944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146316"},
        {"Hipparcos Number", "HIP 79831"},
        {"Smithsonian Astrophysical Observation", "SAO 226629"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.42383906),
        dec: Angle.Degrees(-45.44777573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22595"},
        {"Hipparcos Number", "HIP 16804"},
        {"Smithsonian Astrophysical Observation", "SAO 216400"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.07535454),
        dec: Angle.Degrees(-45.44757716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13490"},
        {"Hipparcos Number", "HIP 10145"},
        {"Geneva Identification System", "GEN# +1.00013490"},
        {"Smithsonian Astrophysical Observation", "SAO 215798"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.62510133),
        dec: Angle.Degrees(-45.44701836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123316"},
        {"Hipparcos Number", "HIP 69043"},
        {"Smithsonian Astrophysical Observation", "SAO 224712"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98987557),
        dec: Angle.Degrees(-45.44623790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119118"},
        {"Hipparcos Number", "HIP 66867"},
        {"Geneva Identification System", "GEN# +1.00119118"},
        {"Smithsonian Astrophysical Observation", "SAO 224352"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.56800839),
        dec: Angle.Degrees(-45.44534870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95837"},
        {"Hipparcos Number", "HIP 54010"},
        {"Smithsonian Astrophysical Observation", "SAO 222521"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.73375454),
        dec: Angle.Degrees(-45.44502661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99216"},
        {"Hipparcos Number", "HIP 55686"},
        {"Smithsonian Astrophysical Observation", "SAO 222775"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.15039825),
        dec: Angle.Degrees(-45.44488144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127325"},
        {"Hipparcos Number", "HIP 71074"},
        {"Geneva Identification System", "GEN# +1.00127325"},
        {"Smithsonian Astrophysical Observation", "SAO 225002"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.01799711),
        dec: Angle.Degrees(-45.44429359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 297017"},
        {"Hipparcos Number", "HIP 48162"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.25268023),
        dec: Angle.Degrees(-45.44046346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87378"},
        {"Hipparcos Number", "HIP 49273"},
        {"Smithsonian Astrophysical Observation", "SAO 221730"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.87080347),
        dec: Angle.Degrees(-45.44001814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119378"},
        {"Hipparcos Number", "HIP 67001"},
        {"Geneva Identification System", "GEN# +1.00119378"},
        {"Smithsonian Astrophysical Observation", "SAO 224367"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.96608356),
        dec: Angle.Degrees(-45.43724919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19230"},
        {"Hipparcos Number", "HIP 14265"},
        {"Smithsonian Astrophysical Observation", "SAO 216157"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.98878086),
        dec: Angle.Degrees(-45.43460572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 105.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61377"},
        {"Hipparcos Number", "HIP 37052"},
        {"Smithsonian Astrophysical Observation", "SAO 218840"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.21161583),
        dec: Angle.Degrees(-45.43139093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149126"},
        {"Hipparcos Number", "HIP 81176"},
        {"Geneva Identification System", "GEN# +1.00149126"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.70901874),
        dec: Angle.Degrees(-45.42952536)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108195"},
        {"Hipparcos Number", "HIP 60658"},
        {"Smithsonian Astrophysical Observation", "SAO 223435"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.48469935),
        dec: Angle.Degrees(-45.42942289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185033"},
        {"Hipparcos Number", "HIP 96680"},
        {"Geneva Identification System", "GEN# +1.00185033"},
        {"Smithsonian Astrophysical Observation", "SAO 229793"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.82988032),
        dec: Angle.Degrees(-45.42819166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328953"},
        {"Hipparcos Number", "HIP 82498"},
        {"Geneva Identification System", "GEN# +1.00328953"},
    },
    visualMagnitude: 9.82,
    bvColour: 1.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.91061828),
        dec: Angle.Degrees(-45.42668865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105578"},
        {"Hipparcos Number", "HIP 59267"},
        {"Geneva Identification System", "GEN# +1.00105578"},
        {"Smithsonian Astrophysical Observation", "SAO 223245"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.34924325),
        dec: Angle.Degrees(-45.42632190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39766"},
        {"Hipparcos Number", "HIP 27739"},
        {"Smithsonian Astrophysical Observation", "SAO 217585"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.08641809),
        dec: Angle.Degrees(-45.42623963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83718"},
        {"Hipparcos Number", "HIP 47371"},
        {"Smithsonian Astrophysical Observation", "SAO 221371"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.666,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.77381766),
        dec: Angle.Degrees(-45.42622379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63253"},
        {"Hipparcos Number", "HIP 37878"},
        {"Smithsonian Astrophysical Observation", "SAO 218968"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46157505),
        dec: Angle.Degrees(-45.42621437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3145"},
        {"Hipparcos Number", "HIP 2708"},
        {"Smithsonian Astrophysical Observation", "SAO 215148"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.60475192),
        dec: Angle.Degrees(-45.42586849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137957"},
        {"Hipparcos Number", "HIP 75957"},
        {"Geneva Identification System", "GEN# +1.00137957"},
        {"Smithsonian Astrophysical Observation", "SAO 225851"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70182214),
        dec: Angle.Degrees(-45.42436407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327993"},
        {"Hipparcos Number", "HIP 80015"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.00065665),
        dec: Angle.Degrees(-45.42407106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105852"},
        {"Hipparcos Number", "HIP 59392"},
        {"Geneva Identification System", "GEN# +1.00105852J"},
        {"Smithsonian Astrophysical Observation", "SAO 223266"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.76219447),
        dec: Angle.Degrees(-45.42286413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224800"},
        {"Hipparcos Number", "HIP 62"},
        {"Geneva Identification System", "GEN# +1.00224800"},
        {"Smithsonian Astrophysical Observation", "SAO 231893"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.17996123),
        dec: Angle.Degrees(-45.42272731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156623"},
        {"Hipparcos Number", "HIP 84881"},
        {"Celescope Catalog", "CEL 4505"},
        {"Geneva Identification System", "GEN# +1.00156623"},
        {"Smithsonian Astrophysical Observation", "SAO 227843"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.21095438),
        dec: Angle.Degrees(-45.42073725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10513"},
        {"Hipparcos Number", "HIP 7896"},
        {"Geneva Identification System", "GEN# +1.00010513"},
        {"Smithsonian Astrophysical Observation", "SAO 215616"},
        {"Wilson Evans Batten Catalogue", "WEB 1685"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39122144),
        dec: Angle.Degrees(-45.41948097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 245.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109062"},
        {"Hipparcos Number", "HIP 61176"},
        {"Smithsonian Astrophysical Observation", "SAO 223496"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.02475403),
        dec: Angle.Degrees(-45.41881983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133590"},
        {"Hipparcos Number", "HIP 73962"},
        {"Smithsonian Astrophysical Observation", "SAO 225449"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.72783808),
        dec: Angle.Degrees(-45.41686517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67270"},
        {"Hipparcos Number", "HIP 39571"},
        {"Geneva Identification System", "GEN# +1.00067270"},
        {"Smithsonian Astrophysical Observation", "SAO 219390"},
    },
    visualMagnitude: 8.38,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.29291250),
        dec: Angle.Degrees(-45.41404478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12759"},
        {"Hipparcos Number", "HIP 9642"},
        {"Geneva Identification System", "GEN# +1.00012759J"},
        {"Smithsonian Astrophysical Observation", "SAO 215754"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.97907630),
        dec: Angle.Degrees(-45.41303242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 328.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35459"},
        {"Hipparcos Number", "HIP 25122"},
        {"Smithsonian Astrophysical Observation", "SAO 217311"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.66364229),
        dec: Angle.Degrees(-45.41113843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74371"},
        {"Hipparcos Number", "HIP 42679"},
        {"Celescope Catalog", "CEL 2791"},
        {"Geneva Identification System", "GEN# +1.00074371"},
        {"Smithsonian Astrophysical Observation", "SAO 220300"},
        {"Wilson Evans Batten Catalogue", "WEB 8242"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.48713962),
        dec: Angle.Degrees(-45.41072610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179554"},
        {"Hipparcos Number", "HIP 94616"},
        {"Smithsonian Astrophysical Observation", "SAO 229578"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.81199344),
        dec: Angle.Degrees(-45.41063768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153695"},
        {"Hipparcos Number", "HIP 83427"},
        {"Geneva Identification System", "GEN# +1.00153695"},
        {"Smithsonian Astrophysical Observation", "SAO 227580"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.77693486),
        dec: Angle.Degrees(-45.40852587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67269"},
        {"Hipparcos Number", "HIP 39573"},
        {"Celescope Catalog", "CEL 2156"},
        {"Geneva Identification System", "GEN# +1.00067269"},
        {"Smithsonian Astrophysical Observation", "SAO 219391"},
    },
    visualMagnitude: 8.68,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.29612526),
        dec: Angle.Degrees(-45.40686909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121637"},
        {"Hipparcos Number", "HIP 68194"},
        {"Smithsonian Astrophysical Observation", "SAO 224571"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.41904568),
        dec: Angle.Degrees(-45.40411267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72267",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72267"},
        {"Cincinnati Publication", "Ci 20 883"},
        {"Geneva Identification System", "GEN# -0.04409595"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.811,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.68264165),
        dec: Angle.Degrees(-45.40195881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -444.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141296"},
        {"Henry Draper 2", "HD 141296A"},
        {"Hipparcos Number", "HIP 77574"},
        {"Fundamental Katalog 5th Edition", "FK5 3251"},
        {"Geneva Identification System", "GEN# +1.00141296"},
        {"Renson", "Renson 40110"},
        {"Smithsonian Astrophysical Observation", "SAO 226263"},
        {"Wilson Evans Batten Catalogue", "WEB 13130"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.56783711),
        dec: Angle.Degrees(-45.40163254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33682"},
        {"Hipparcos Number", "HIP 24023"},
        {"Smithsonian Astrophysical Observation", "SAO 217206"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.44348962),
        dec: Angle.Degrees(-45.40066929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213383"},
        {"Hipparcos Number", "HIP 111215"},
        {"Smithsonian Astrophysical Observation", "SAO 231185"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.96545817),
        dec: Angle.Degrees(-45.39883887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149388"},
        {"Hipparcos Number", "HIP 81308"},
        {"Smithsonian Astrophysical Observation", "SAO 226952"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.09798646),
        dec: Angle.Degrees(-45.39739339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17160",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17160"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.12503871),
        dec: Angle.Degrees(-45.39600402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -333.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109367"},
        {"Hipparcos Number", "HIP 61362"},
        {"Smithsonian Astrophysical Observation", "SAO 223523"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.60850515),
        dec: Angle.Degrees(-45.39599623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106902"},
        {"Hipparcos Number", "HIP 59951"},
        {"Geneva Identification System", "GEN# +1.00106902"},
        {"Smithsonian Astrophysical Observation", "SAO 223338"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44792768),
        dec: Angle.Degrees(-45.39287366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209742"},
        {"Hipparcos Number", "HIP 109166"},
        {"Cincinnati Publication", "Ci 20 1333"},
        {"Cincinnati Publication 2", "Ci 18 2878"},
        {"Geneva Identification System", "GEN# +1.00209742"},
        {"Smithsonian Astrophysical Observation", "SAO 230983"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.69155839),
        dec: Angle.Degrees(-45.39179667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 385.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27303"},
        {"Hipparcos Number", "HIP 19932"},
        {"Smithsonian Astrophysical Observation", "SAO 216730"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.13840672),
        dec: Angle.Degrees(-45.39119377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151173"},
        {"Hipparcos Number", "HIP 82221"},
        {"Celescope Catalog", "CEL 4427"},
        {"Geneva Identification System", "GEN# +1.00151173"},
        {"Smithsonian Astrophysical Observation", "SAO 227225"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.95571860),
        dec: Angle.Degrees(-45.39030199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146072"},
        {"Hipparcos Number", "HIP 79725"},
        {"Smithsonian Astrophysical Observation", "SAO 226613"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.07046320),
        dec: Angle.Degrees(-45.38915386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107436"},
        {"Hipparcos Number", "HIP 60250"},
        {"Geneva Identification System", "GEN# +1.00107436"},
        {"Smithsonian Astrophysical Observation", "SAO 223372"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.31198169),
        dec: Angle.Degrees(-45.38692514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24291"},
        {"Hipparcos Number", "HIP 17925"},
        {"Geneva Identification System", "GEN# +1.00024291"},
        {"Smithsonian Astrophysical Observation", "SAO 216513"},
        {"Wilson Evans Batten Catalogue", "WEB 3453"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.51085501),
        dec: Angle.Degrees(-45.38538778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217827"},
        {"Hipparcos Number", "HIP 113906"},
        {"Smithsonian Astrophysical Observation", "SAO 231420"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.00806651),
        dec: Angle.Degrees(-45.38537132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77663"},
    },
    visualMagnitude: 11.94,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.82080093),
        dec: Angle.Degrees(-15.75080078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198887"},
        {"Hipparcos Number", "HIP 103254"},
        {"Smithsonian Astrophysical Observation", "SAO 230434"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.77174883),
        dec: Angle.Degrees(-45.38446125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113600"},
        {"Hipparcos Number", "HIP 63868"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.34877231),
        dec: Angle.Degrees(-45.38365484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91282"},
        {"Hipparcos Number", "HIP 51524"},
        {"Geneva Identification System", "GEN# +1.00091282"},
        {"Smithsonian Astrophysical Observation", "SAO 222117"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.84440397),
        dec: Angle.Degrees(-45.38275581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 346"},
        {"Hipparcos Number", "HIP 654"},
        {"Smithsonian Astrophysical Observation", "SAO 214976"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.00852236),
        dec: Angle.Degrees(-45.38213796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187099"},
        {"Hipparcos Number", "HIP 97593"},
        {"Smithsonian Astrophysical Observation", "SAO 229888"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.54514986),
        dec: Angle.Degrees(-45.37950523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200887"},
        {"Hipparcos Number", "HIP 104296"},
        {"Smithsonian Astrophysical Observation", "SAO 230535"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.93542377),
        dec: Angle.Degrees(-45.37945192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126354"},
        {"Hipparcos Number", "HIP 70576"},
        {"Geneva Identification System", "GEN# +1.00126354"},
        {"Smithsonian Astrophysical Observation", "SAO 224920"},
        {"Wilson Evans Batten Catalogue", "WEB 12238"},
    },
    visualMagnitude: 4.33,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.54500648),
        dec: Angle.Degrees(-45.37926095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46817"},
        {"Hipparcos Number", "HIP 31247"},
        {"Geneva Identification System", "GEN# +1.00046817"},
        {"Smithsonian Astrophysical Observation", "SAO 218015"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.30526843),
        dec: Angle.Degrees(-45.37855487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219481"},
        {"Hipparcos Number", "HIP 114903"},
        {"Smithsonian Astrophysical Observation", "SAO 231530"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.11156494),
        dec: Angle.Degrees(-45.37775580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76358"},
        {"Hipparcos Number", "HIP 43681"},
        {"Geneva Identification System", "GEN# +1.00076358"},
        {"Smithsonian Astrophysical Observation", "SAO 220637"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.47882413),
        dec: Angle.Degrees(-45.37711636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87843"},
        {"Hipparcos Number", "HIP 49514"},
        {"Geneva Identification System", "GEN# +1.00087843"},
        {"Smithsonian Astrophysical Observation", "SAO 221776"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.64557787),
        dec: Angle.Degrees(-45.37663154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81576"},
        {"Hipparcos Number", "HIP 46188"},
        {"Geneva Identification System", "GEN# +1.00081576"},
        {"Smithsonian Astrophysical Observation", "SAO 221144"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.25573541),
        dec: Angle.Degrees(-45.37633616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145037"},
        {"Hipparcos Number", "HIP 79275"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.69481860),
        dec: Angle.Degrees(-45.37397420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191039"},
        {"Hipparcos Number", "HIP 99339"},
        {"Geneva Identification System", "GEN# +1.00191039"},
        {"Smithsonian Astrophysical Observation", "SAO 230074"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.44230067),
        dec: Angle.Degrees(-45.37388826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47872"},
        {"Hipparcos Number", "HIP 31750"},
        {"Geneva Identification System", "GEN# +1.00047872"},
        {"Smithsonian Astrophysical Observation", "SAO 218084"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.62232888),
        dec: Angle.Degrees(-45.37380928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191133"},
        {"Hipparcos Number", "HIP 99373"},
        {"Smithsonian Astrophysical Observation", "SAO 230078"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.54891703),
        dec: Angle.Degrees(-45.37281481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146198"},
        {"Hipparcos Number", "HIP 79789"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.24969049),
        dec: Angle.Degrees(-45.37140778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150248"},
        {"Hipparcos Number", "HIP 81746"},
        {"Geneva Identification System", "GEN# +1.00150248"},
        {"Smithsonian Astrophysical Observation", "SAO 227066"},
        {"Wilson Evans Batten Catalogue", "WEB 13813"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.45726854),
        dec: Angle.Degrees(-45.36849794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183578"},
        {"Hipparcos Number", "HIP 96102"},
        {"Geneva Identification System", "GEN# +1.00183578"},
        {"Smithsonian Astrophysical Observation", "SAO 229736"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.09159903),
        dec: Angle.Degrees(-45.36796711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26855"},
        {"Hipparcos Number", "HIP 19652"},
        {"Smithsonian Astrophysical Observation", "SAO 216697"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.16211732),
        dec: Angle.Degrees(-45.36768392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99679"},
        {"Hipparcos Number", "HIP 55925"},
        {"Geneva Identification System", "GEN# +1.00099679"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.92398690),
        dec: Angle.Degrees(-45.36706772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191038"},
        {"Hipparcos Number", "HIP 99335"},
        {"Smithsonian Astrophysical Observation", "SAO 230072"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.42851277),
        dec: Angle.Degrees(-45.36703323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90959"},
        {"Hipparcos Number", "HIP 51331"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.27516688),
        dec: Angle.Degrees(-45.36651756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30888",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30888"},
        {"Geneva Identification System", "GEN# -0.04502540"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.25520042),
        dec: Angle.Degrees(-45.36570857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -288.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144533"},
        {"Hipparcos Number", "HIP 79058"},
        {"Smithsonian Astrophysical Observation", "SAO 226528"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.06660761),
        dec: Angle.Degrees(-45.36534821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17287"},
        {"Hipparcos Number", "HIP 12841"},
        {"Smithsonian Astrophysical Observation", "SAO 216032"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.26724819),
        dec: Angle.Degrees(-45.36508958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177299"},
        {"Hipparcos Number", "HIP 93806"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.56337741),
        dec: Angle.Degrees(-45.36502890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101266"},
        {"Hipparcos Number", "HIP 56819"},
        {"Fundamental Katalog 5th Edition", "FK5 5026"},
        {"Geneva Identification System", "GEN# +1.00101266"},
        {"Smithsonian Astrophysical Observation", "SAO 222933"},
        {"Wilson Evans Batten Catalogue", "WEB 10230"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.71145046),
        dec: Angle.Degrees(-45.36237000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143234"},
        {"Hipparcos Number", "HIP 78473"},
        {"Geneva Identification System", "GEN# +1.00143234"},
        {"Smithsonian Astrophysical Observation", "SAO 226445"},
        {"Wilson Evans Batten Catalogue", "WEB 13267"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.28474480),
        dec: Angle.Degrees(-45.36114387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28904"},
        {"Hipparcos Number", "HIP 21079"},
        {"Geneva Identification System", "GEN# +1.00028904"},
        {"Smithsonian Astrophysical Observation", "SAO 216856"},
        {"Wilson Evans Batten Catalogue", "WEB 4057"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.77013669),
        dec: Angle.Degrees(-45.36047476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115507",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115507"},
    },
    visualMagnitude: 10.93,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.96907741),
        dec: Angle.Degrees(-45.35816997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57641"},
        {"Hipparcos Number", "HIP 35524"},
        {"Smithsonian Astrophysical Observation", "SAO 218646"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98200629),
        dec: Angle.Degrees(-45.35170240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13602"},
        {"Hipparcos Number", "HIP 10225"},
        {"Geneva Identification System", "GEN# +1.00013602"},
        {"Smithsonian Astrophysical Observation", "SAO 215807"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.86915784),
        dec: Angle.Degrees(-45.35105102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147614"},
        {"Hipparcos Number", "HIP 80421"},
        {"Geneva Identification System", "GEN# +1.00147614J"},
        {"Smithsonian Astrophysical Observation", "SAO 226730"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.22557137),
        dec: Angle.Degrees(-45.34946169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62088"},
        {"Hipparcos Number", "HIP 37363"},
        {"Smithsonian Astrophysical Observation", "SAO 218887"},
    },
    visualMagnitude: 7.29,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.04170769),
        dec: Angle.Degrees(-45.34932877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119644"},
        {"Hipparcos Number", "HIP 67118"},
        {"Geneva Identification System", "GEN# +1.00119644"},
        {"Smithsonian Astrophysical Observation", "SAO 224393"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.34420817),
        dec: Angle.Degrees(-45.34851623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152798"},
        {"Hipparcos Number", "HIP 83001"},
        {"Geneva Identification System", "GEN# +1.00152798"},
        {"Smithsonian Astrophysical Observation", "SAO 227494"},
        {"Wilson Evans Batten Catalogue", "WEB 14032"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.41772620),
        dec: Angle.Degrees(-45.34696516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210794"},
        {"Hipparcos Number", "HIP 109757"},
        {"Smithsonian Astrophysical Observation", "SAO 231042"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47212724),
        dec: Angle.Degrees(-45.34671142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144338"},
        {"Hipparcos Number", "HIP 78964"},
        {"Smithsonian Astrophysical Observation", "SAO 226513"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.80514900),
        dec: Angle.Degrees(-45.34620059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115397"},
        {"Hipparcos Number", "HIP 64857"},
        {"Smithsonian Astrophysical Observation", "SAO 224041"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40714208),
        dec: Angle.Degrees(-45.34573679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224902"},
        {"Hipparcos Number", "HIP 120"},
        {"Smithsonian Astrophysical Observation", "SAO 231900"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.39598898),
        dec: Angle.Degrees(-45.34468907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19555"},
        {"Hipparcos Number", "HIP 14489"},
        {"Smithsonian Astrophysical Observation", "SAO 216171"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.76623867),
        dec: Angle.Degrees(-45.34341654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20829"},
        {"Hipparcos Number", "HIP 15490"},
        {"Smithsonian Astrophysical Observation", "SAO 216264"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.90819662),
        dec: Angle.Degrees(-45.34210742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35289"},
        {"Hipparcos Number", "HIP 25020"},
        {"Smithsonian Astrophysical Observation", "SAO 217303"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.35897494),
        dec: Angle.Degrees(-45.34124666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103899"},
        {"Hipparcos Number", "HIP 58332"},
        {"Geneva Identification System", "GEN# +1.00103899J"},
        {"Smithsonian Astrophysical Observation", "SAO 223134"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.44150942),
        dec: Angle.Degrees(-45.33973724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73738"},
        {"Hipparcos Number", "HIP 42357"},
        {"Celescope Catalog", "CEL 2728"},
        {"Geneva Identification System", "GEN# +1.00073738"},
        {"Smithsonian Astrophysical Observation", "SAO 220219"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.53917097),
        dec: Angle.Degrees(-45.33842741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39162",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66235"},
        {"Hipparcos Number", "HIP 39162"},
        {"Smithsonian Astrophysical Observation", "SAO 219290"},
    },
    visualMagnitude: 7.70,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.14758364),
        dec: Angle.Degrees(-45.33692813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145158"},
        {"Hipparcos Number", "HIP 79322"},
        {"Geneva Identification System", "GEN# +1.00145158"},
        {"Smithsonian Astrophysical Observation", "SAO 226562"},
        {"Wilson Evans Batten Catalogue", "WEB 13407"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.82862290),
        dec: Angle.Degrees(-45.33328373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155494"},
        {"Hipparcos Number", "HIP 84305"},
        {"Smithsonian Astrophysical Observation", "SAO 227727"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.53860853),
        dec: Angle.Degrees(-45.33221649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221465"},
        {"Hipparcos Number", "HIP 116193"},
        {"Smithsonian Astrophysical Observation", "SAO 231654"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.13765887),
        dec: Angle.Degrees(-45.33182067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55000"},
        {"Hipparcos Number", "HIP 34506"},
        {"Celescope Catalog", "CEL 1627"},
        {"Geneva Identification System", "GEN# +1.00055000"},
        {"Smithsonian Astrophysical Observation", "SAO 218484"},
    },
    visualMagnitude: 7.01,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.24223519),
        dec: Angle.Degrees(-45.33132620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104645",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104645"},
        {"Geneva Identification System", "GEN# +6.20145073"},
    },
    visualMagnitude: 11.95,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)21, (int)11, 53.8200),
        dec: Angle.DegreesMinutesSeconds((int)-45, (int)19, 52.100)
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
    primaryId: "HIP 50791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89987"},
        {"Hipparcos Number", "HIP 50791"},
        {"Smithsonian Astrophysical Observation", "SAO 221996"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.55494268),
        dec: Angle.Degrees(-45.33089036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223194"},
        {"Hipparcos Number", "HIP 117346"},
        {"Renson", "Renson 61180"},
        {"Smithsonian Astrophysical Observation", "SAO 231784"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.90029624),
        dec: Angle.Degrees(-45.32932854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207800"},
        {"Hipparcos Number", "HIP 108000"},
        {"Smithsonian Astrophysical Observation", "SAO 230880"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.20242646),
        dec: Angle.Degrees(-45.32714556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17628"},
        {"Hipparcos Number", "HIP 13083"},
        {"Smithsonian Astrophysical Observation", "SAO 216055"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.04791494),
        dec: Angle.Degrees(-45.32621751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68173"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.34545378),
        dec: Angle.Degrees(-45.32138416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126981"},
        {"Hipparcos Number", "HIP 70915"},
        {"Geneva Identification System", "GEN# +1.00126981J"},
        {"Smithsonian Astrophysical Observation", "SAO 224969"},
        {"Wilson Evans Batten Catalogue", "WEB 12277"},
    },
    visualMagnitude: 5.51,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.53608389),
        dec: Angle.Degrees(-45.32128792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198634"},
        {"Hipparcos Number", "HIP 103095"},
        {"Smithsonian Astrophysical Observation", "SAO 230419"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.33203351),
        dec: Angle.Degrees(-45.31808285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212179"},
        {"Hipparcos Number", "HIP 110516"},
        {"Geneva Identification System", "GEN# +1.00212179"},
        {"Smithsonian Astrophysical Observation", "SAO 231113"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.83098525),
        dec: Angle.Degrees(-45.31568107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30150"},
        {"Hipparcos Number", "HIP 21930"},
        {"Smithsonian Astrophysical Observation", "SAO 216950"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.72995350),
        dec: Angle.Degrees(-45.31552297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1654"},
        {"Smithsonian Astrophysical Observation", "SAO 147225"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.18532728),
        dec: Angle.Degrees(-15.66720786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185709"},
        {"Hipparcos Number", "HIP 96947"},
        {"Smithsonian Astrophysical Observation", "SAO 229821"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.62170115),
        dec: Angle.Degrees(-45.31532182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6791"},
        {"Hipparcos Number", "HIP 5305"},
        {"Smithsonian Astrophysical Observation", "SAO 215375"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.716,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.97461895),
        dec: Angle.Degrees(-45.31386667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46652"},
        {"Hipparcos Number", "HIP 31161"},
        {"Geneva Identification System", "GEN# +1.00046652"},
        {"Smithsonian Astrophysical Observation", "SAO 218002"},
        {"Wilson Evans Batten Catalogue", "WEB 6222"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.08150784),
        dec: Angle.Degrees(-45.31001414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79170"},
        {"Hipparcos Number", "HIP 45072"},
        {"Geneva Identification System", "GEN# +1.00079170J"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.71039567),
        dec: Angle.Degrees(-45.30879534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47147"},
        {"Hipparcos Number", "HIP 31400"},
        {"Geneva Identification System", "GEN# +1.00047147"},
        {"Smithsonian Astrophysical Observation", "SAO 218036"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.73086639),
        dec: Angle.Degrees(-45.30827148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75710"},
        {"Hipparcos Number", "HIP 43347"},
        {"Celescope Catalog", "CEL 2972"},
        {"Fundamental Katalog 5th Edition", "FK5 2698"},
        {"Geneva Identification System", "GEN# +1.00075710"},
        {"Smithsonian Astrophysical Observation", "SAO 220540"},
        {"Wilson Evans Batten Catalogue", "WEB 8350"},
    },
    visualMagnitude: 4.94,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.44853466),
        dec: Angle.Degrees(-45.30790977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88400"},
        {"Hipparcos Number", "HIP 49836"},
        {"Smithsonian Astrophysical Observation", "SAO 221831"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.62914257),
        dec: Angle.Degrees(-45.30783650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43126",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43126"},
        {"Celescope Catalog", "CEL 2903"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.75927262),
        dec: Angle.Degrees(-45.30759642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30012"},
        {"Hipparcos Number", "HIP 21844"},
        {"Smithsonian Astrophysical Observation", "SAO 216938"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.44428650),
        dec: Angle.Degrees(-45.30749604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127922"},
        {"Hipparcos Number", "HIP 71342"},
        {"Smithsonian Astrophysical Observation", "SAO 225041"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.84198980),
        dec: Angle.Degrees(-45.30668329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97843"},
        {"Hipparcos Number", "HIP 54919"},
        {"Smithsonian Astrophysical Observation", "SAO 222666"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.69993535),
        dec: Angle.Degrees(-45.30400467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217595"},
        {"Hipparcos Number", "HIP 113774"},
        {"Geneva Identification System", "GEN# +1.00217595"},
        {"Smithsonian Astrophysical Observation", "SAO 231402"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.61419262),
        dec: Angle.Degrees(-45.30394269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93750"},
        {"Hipparcos Number", "HIP 52866"},
        {"Geneva Identification System", "GEN# +1.00093750"},
        {"Smithsonian Astrophysical Observation", "SAO 222345"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.17366899),
        dec: Angle.Degrees(-45.30360075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210692"},
        {"Hipparcos Number", "HIP 109690"},
        {"Smithsonian Astrophysical Observation", "SAO 231033"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29002770),
        dec: Angle.Degrees(-45.30268856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39841"},
        {"Hipparcos Number", "HIP 27792"},
        {"Smithsonian Astrophysical Observation", "SAO 217595"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.22007823),
        dec: Angle.Degrees(-45.30187841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6042"},
        {"Hipparcos Number", "HIP 4764"},
        {"Smithsonian Astrophysical Observation", "SAO 215328"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.30524450),
        dec: Angle.Degrees(-45.29967671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57415"},
        {"Hipparcos Number", "HIP 35437"},
        {"Geneva Identification System", "GEN# +1.00057415"},
        {"Smithsonian Astrophysical Observation", "SAO 218631"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.73539544),
        dec: Angle.Degrees(-45.29753627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70852",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70852"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.33383931),
        dec: Angle.Degrees(-45.29457035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64905"},
        {"Hipparcos Number", "HIP 38592"},
        {"Celescope Catalog", "CEL 2090"},
        {"Geneva Identification System", "GEN# +1.00064905"},
        {"Smithsonian Astrophysical Observation", "SAO 219125"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.53895943),
        dec: Angle.Degrees(-45.29421948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10911"},
        {"Hipparcos Number", "HIP 8250"},
        {"Smithsonian Astrophysical Observation", "SAO 215641"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.55001651),
        dec: Angle.Degrees(-45.29103812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40940"},
        {"Hipparcos Number", "HIP 28392"},
        {"Geneva Identification System", "GEN# +1.00040940"},
        {"Smithsonian Astrophysical Observation", "SAO 217658"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.95720901),
        dec: Angle.Degrees(-45.29096443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43588"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.15559927),
        dec: Angle.Degrees(-45.29050838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32138"},
        {"Hipparcos Number", "HIP 23146"},
        {"Smithsonian Astrophysical Observation", "SAO 217093"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.70324965),
        dec: Angle.Degrees(-45.29045576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202612"},
        {"Hipparcos Number", "HIP 105180"},
        {"Smithsonian Astrophysical Observation", "SAO 230621"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.60643623),
        dec: Angle.Degrees(-45.29016876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225157"},
        {"Hipparcos Number", "HIP 309"},
        {"Geneva Identification System", "GEN# +1.00225157"},
        {"Smithsonian Astrophysical Observation", "SAO 214946"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.98590855),
        dec: Angle.Degrees(-45.28859728)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62749",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62749"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.86083514),
        dec: Angle.Degrees(-45.28788293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -212.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141687"},
        {"Hipparcos Number", "HIP 77730"},
        {"Geneva Identification System", "GEN# +1.00141687"},
        {"Smithsonian Astrophysical Observation", "SAO 226308"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.887,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.05488753),
        dec: Angle.Degrees(-45.28437278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85980"},
        {"Hipparcos Number", "HIP 48561"},
        {"Geneva Identification System", "GEN# +1.00085980"},
        {"Smithsonian Astrophysical Observation", "SAO 221592"},
        {"Wilson Evans Batten Catalogue", "WEB 9044"},
    },
    visualMagnitude: 5.72,
    bvColour: -0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.57361875),
        dec: Angle.Degrees(-45.28352716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42834"},
        {"Hipparcos Number", "HIP 29304"},
        {"Fundamental Katalog 5th Edition", "FK5 2472"},
        {"Geneva Identification System", "GEN# +1.00042834"},
        {"Smithsonian Astrophysical Observation", "SAO 217758"},
        {"Wilson Evans Batten Catalogue", "WEB 5753"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.66636995),
        dec: Angle.Degrees(-45.28200681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18912"},
        {"Hipparcos Number", "HIP 14046"},
        {"Smithsonian Astrophysical Observation", "SAO 216134"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.22114548),
        dec: Angle.Degrees(-45.28020278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133955"},
        {"Hipparcos Number", "HIP 74117"},
        {"Celescope Catalog", "CEL 4342"},
        {"Geneva Identification System", "GEN# +1.00133955"},
        {"Smithsonian Astrophysical Observation", "SAO 225483"},
        {"Wilson Evans Batten Catalogue", "WEB 12661"},
    },
    visualMagnitude: 4.07,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.21095653),
        dec: Angle.Degrees(-45.27979406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36818"},
        {"Cincinnati Publication", "Ci 20 429"},
        {"Geneva Identification System", "GEN# -0.04503283"},
        {"Wilson Evans Batten Catalogue", "WEB 7317"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.57856357),
        dec: Angle.Degrees(-45.27970610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -311.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 439.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134443"},
        {"Hipparcos Number", "HIP 74329"},
        {"Geneva Identification System", "GEN# +1.00134443"},
        {"Smithsonian Astrophysical Observation", "SAO 225516"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.88299497),
        dec: Angle.Degrees(-45.27908096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114550"},
        {"Hipparcos Number", "HIP 64400"},
        {"Smithsonian Astrophysical Observation", "SAO 223970"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.98724021),
        dec: Angle.Degrees(-45.27878892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185139"},
        {"Hipparcos Number", "HIP 96721"},
        {"Geneva Identification System", "GEN# +1.00185139"},
        {"Renson", "Renson 51090"},
        {"Smithsonian Astrophysical Observation", "SAO 229800"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.92415705),
        dec: Angle.Degrees(-45.27856526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134444"},
        {"Hipparcos Number", "HIP 74336"},
        {"Geneva Identification System", "GEN# +1.00134444J"},
        {"Smithsonian Astrophysical Observation", "SAO 225517"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.89506430),
        dec: Angle.Degrees(-45.27749513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27033"},
        {"Hipparcos Number", "HIP 19765"},
        {"Smithsonian Astrophysical Observation", "SAO 216714"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.57383016),
        dec: Angle.Degrees(-45.27452241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195932"},
        {"Hipparcos Number", "HIP 101635"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.00415923),
        dec: Angle.Degrees(-45.27289368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183806"},
        {"Hipparcos Number", "HIP 96178"},
        {"Fundamental Katalog 5th Edition", "FK5 3558"},
        {"Geneva Identification System", "GEN# +1.00183806"},
        {"Renson", "Renson 50750"},
        {"Smithsonian Astrophysical Observation", "SAO 229741"},
        {"Wilson Evans Batten Catalogue", "WEB 16853"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.34014279),
        dec: Angle.Degrees(-45.27168903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21396"},
        {"Hipparcos Number", "HIP 15947"},
        {"Smithsonian Astrophysical Observation", "SAO 216311"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.33492324),
        dec: Angle.Degrees(-45.27096416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160550"},
        {"Hipparcos Number", "HIP 86693"},
        {"Smithsonian Astrophysical Observation", "SAO 228316"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.70513178),
        dec: Angle.Degrees(-45.27063801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7533"},
        {"Hipparcos Number", "HIP 5819"},
        {"Geneva Identification System", "GEN# +1.00007533"},
        {"Smithsonian Astrophysical Observation", "SAO 215425"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.66888664),
        dec: Angle.Degrees(-45.26782582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67582"},
        {"Hipparcos Number", "HIP 39690"},
        {"Geneva Identification System", "GEN# +1.00067582"},
        {"Smithsonian Astrophysical Observation", "SAO 219422"},
        {"Wilson Evans Batten Catalogue", "WEB 7747"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.66809949),
        dec: Angle.Degrees(-45.26604229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96627"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.69453327),
        dec: Angle.Degrees(-45.26327878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187966"},
        {"Hipparcos Number", "HIP 97976"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.67815920),
        dec: Angle.Degrees(-45.26235645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92861"},
        {"Hipparcos Number", "HIP 52393"},
        {"Smithsonian Astrophysical Observation", "SAO 222269"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.63464976),
        dec: Angle.Degrees(-45.26039153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10789"},
        {"Hipparcos Number", "HIP 8133"},
        {"Geneva Identification System", "GEN# +1.00010789"},
        {"Smithsonian Astrophysical Observation", "SAO 215632"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.14949169),
        dec: Angle.Degrees(-45.25522679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222202"},
        {"Hipparcos Number", "HIP 116680"},
        {"Smithsonian Astrophysical Observation", "SAO 231713"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.68346228),
        dec: Angle.Degrees(-45.25168982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215788"},
        {"Hipparcos Number", "HIP 112602"},
        {"Geneva Identification System", "GEN# +1.00215788J"},
        {"Smithsonian Astrophysical Observation", "SAO 231304"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.08819164),
        dec: Angle.Degrees(-45.24883413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208196"},
        {"Hipparcos Number", "HIP 108248"},
        {"Smithsonian Astrophysical Observation", "SAO 230902"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.95531259),
        dec: Angle.Degrees(-45.24793592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172222"},
        {"Hipparcos Number", "HIP 91641"},
        {"Smithsonian Astrophysical Observation", "SAO 229190"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.32818750),
        dec: Angle.Degrees(-45.24716584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222896"},
        {"Hipparcos Number", "HIP 117130"},
        {"Smithsonian Astrophysical Observation", "SAO 231760"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.19668565),
        dec: Angle.Degrees(-45.24708023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218670"},
        {"Hipparcos Number", "HIP 114421"},
        {"Fundamental Katalog 5th Edition", "FK5 1605"},
        {"Geneva Identification System", "GEN# +1.00218670"},
        {"Smithsonian Astrophysical Observation", "SAO 231468"},
        {"Wilson Evans Batten Catalogue", "WEB 20311"},
    },
    visualMagnitude: 3.88,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.58928308),
        dec: Angle.Degrees(-45.24664747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109907"},
        {"Hipparcos Number", "HIP 61690"},
        {"Smithsonian Astrophysical Observation", "SAO 223568"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68676042),
        dec: Angle.Degrees(-45.24625540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125098"},
        {"Hipparcos Number", "HIP 69915"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.62512599),
        dec: Angle.Degrees(-45.24445090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149174"},
        {"Hipparcos Number", "HIP 81198"},
        {"Geneva Identification System", "GEN# +1.00149174"},
        {"Smithsonian Astrophysical Observation", "SAO 226926"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.78238513),
        dec: Angle.Degrees(-45.24421531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200502"},
        {"Hipparcos Number", "HIP 104095"},
        {"Geneva Identification System", "GEN# +1.00200502"},
        {"Smithsonian Astrophysical Observation", "SAO 230513"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.34673026),
        dec: Angle.Degrees(-45.24173672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153892"},
        {"Hipparcos Number", "HIP 83529"},
        {"Geneva Identification System", "GEN# +1.00153892"},
        {"Smithsonian Astrophysical Observation", "SAO 227595"},
        {"Wilson Evans Batten Catalogue", "WEB 14119"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.06474318),
        dec: Angle.Degrees(-45.24049878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17888"},
        {"Hipparcos Number", "HIP 13273"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.71187640),
        dec: Angle.Degrees(-45.23992104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116386"},
        {"Hipparcos Number", "HIP 65390"},
        {"Smithsonian Astrophysical Observation", "SAO 224113"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.01587333),
        dec: Angle.Degrees(-45.23724208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38343"},
        {"Hipparcos Number", "HIP 26919"},
        {"Smithsonian Astrophysical Observation", "SAO 217485"},
    },
    visualMagnitude: 7.64,
    bvColour: -0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.71079985),
        dec: Angle.Degrees(-45.23550574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79332"},
        {"Hipparcos Number", "HIP 45145"},
        {"Celescope Catalog", "CEL 3212"},
        {"Geneva Identification System", "GEN# +1.00079332"},
        {"Smithsonian Astrophysical Observation", "SAO 220943"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.97048894),
        dec: Angle.Degrees(-45.23476469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2406"},
        {"Hipparcos Number", "HIP 2187"},
        {"Smithsonian Astrophysical Observation", "SAO 215102"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.91139532),
        dec: Angle.Degrees(-45.23450341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83123"},
        {"Hipparcos Number", "HIP 47015"},
        {"Geneva Identification System", "GEN# +1.00083123"},
        {"Smithsonian Astrophysical Observation", "SAO 221301"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.72966284),
        dec: Angle.Degrees(-45.23298086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219610"},
        {"Hipparcos Number", "HIP 115001"},
        {"Smithsonian Astrophysical Observation", "SAO 231536"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.37281859),
        dec: Angle.Degrees(-45.23235245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66438"},
        {"Hipparcos Number", "HIP 39241"},
        {"Smithsonian Astrophysical Observation", "SAO 219315"},
    },
    visualMagnitude: 7.98,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.38478608),
        dec: Angle.Degrees(-45.23145608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73153"},
        {"Hipparcos Number", "HIP 42116"},
        {"Celescope Catalog", "CEL 2678"},
        {"Smithsonian Astrophysical Observation", "SAO 220143"},
    },
    visualMagnitude: 8.86,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.78091162),
        dec: Angle.Degrees(-45.22896361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192633"},
        {"Hipparcos Number", "HIP 100030"},
        {"Geneva Identification System", "GEN# +1.00192633"},
        {"Smithsonian Astrophysical Observation", "SAO 230132"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.41777434),
        dec: Angle.Degrees(-45.22875238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52492"},
        {"Hipparcos Number", "HIP 33636"},
        {"Smithsonian Astrophysical Observation", "SAO 218369"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.81104485),
        dec: Angle.Degrees(-45.22854816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 327507"},
        {"Hipparcos Number", "HIP 77865"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.49923723),
        dec: Angle.Degrees(-45.22681528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214730"},
        {"Hipparcos Number", "HIP 111980"},
        {"Geneva Identification System", "GEN# +1.00214730"},
        {"Smithsonian Astrophysical Observation", "SAO 231247"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.23677093),
        dec: Angle.Degrees(-45.22608858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126341"},
        {"Hipparcos Number", "HIP 70574"},
        {"Celescope Catalog", "CEL 4319"},
        {"Fundamental Katalog 5th Edition", "FK5 1377"},
        {"Geneva Identification System", "GEN# +1.00126341A"},
        {"Smithsonian Astrophysical Observation", "SAO 224919"},
        {"Wilson Evans Batten Catalogue", "WEB 12236"},
    },
    visualMagnitude: 4.56,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.53431272),
        dec: Angle.Degrees(-45.22138996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5366"},
        {"Hipparcos Number", "HIP 4289"},
        {"Smithsonian Astrophysical Observation", "SAO 215287"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.74346483),
        dec: Angle.Degrees(-45.21989511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64716"},
        {"Hipparcos Number", "HIP 38510"},
        {"Celescope Catalog", "CEL 2081"},
        {"Geneva Identification System", "GEN# +1.00064716"},
        {"Smithsonian Astrophysical Observation", "SAO 219105"},
    },
    visualMagnitude: 8.47,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.29952908),
        dec: Angle.Degrees(-45.21875920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197847"},
        {"Hipparcos Number", "HIP 102644"},
        {"Smithsonian Astrophysical Observation", "SAO 230374"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.98723039),
        dec: Angle.Degrees(-45.21738514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65904"},
        {"Hipparcos Number", "HIP 39014"},
        {"Geneva Identification System", "GEN# +1.00065904"},
        {"Renson", "Renson 18070"},
        {"Smithsonian Astrophysical Observation", "SAO 219240"},
        {"Wilson Evans Batten Catalogue", "WEB 7648"},
    },
    visualMagnitude: 5.98,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.75754809),
        dec: Angle.Degrees(-45.21586305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69324"},
        {"Hipparcos Number", "HIP 40371"},
        {"Celescope Catalog", "CEL 2273"},
        {"Geneva Identification System", "GEN# +1.00069324"},
        {"Smithsonian Astrophysical Observation", "SAO 219659"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.63137181),
        dec: Angle.Degrees(-45.21406706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159688"},
        {"Hipparcos Number", "HIP 86324"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.57384852),
        dec: Angle.Degrees(-45.21384143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68214",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68214"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.48605035),
        dec: Angle.Degrees(-45.21219939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82829"},
        {"Hipparcos Number", "HIP 46881"},
        {"Geneva Identification System", "GEN# +1.00082829"},
        {"Renson", "Renson 23600"},
        {"Smithsonian Astrophysical Observation", "SAO 221279"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.30516825),
        dec: Angle.Degrees(-45.20862342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32857"},
        {"Hipparcos Number", "HIP 23565"},
        {"Geneva Identification System", "GEN# +1.00032857"},
        {"Smithsonian Astrophysical Observation", "SAO 217156"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.99967000),
        dec: Angle.Degrees(-45.20832381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73568"},
        {"Hipparcos Number", "HIP 42288"},
        {"Celescope Catalog", "CEL 2715"},
        {"Geneva Identification System", "GEN# +1.00073568"},
        {"Smithsonian Astrophysical Observation", "SAO 220197"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.33119400),
        dec: Angle.Degrees(-45.20722178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34018"},
    },
    visualMagnitude: 9.41,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87749655),
        dec: Angle.Degrees(-45.20640791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217418"},
        {"Hipparcos Number", "HIP 113659"},
        {"Smithsonian Astrophysical Observation", "SAO 231393"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.28319042),
        dec: Angle.Degrees(-45.20506671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214729"},
        {"Hipparcos Number", "HIP 111971"},
        {"Geneva Identification System", "GEN# +1.00214729"},
        {"Smithsonian Astrophysical Observation", "SAO 231244"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.21400425),
        dec: Angle.Degrees(-45.20395726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126110"},
        {"Hipparcos Number", "HIP 70465"},
        {"Geneva Identification System", "GEN# +1.00126110"},
        {"Smithsonian Astrophysical Observation", "SAO 224904"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19719453),
        dec: Angle.Degrees(-45.20392062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180208"},
        {"Hipparcos Number", "HIP 94832"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.44612723),
        dec: Angle.Degrees(-45.19916934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328232"},
        {"Hipparcos Number", "HIP 80771"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.36732573),
        dec: Angle.Degrees(-45.19776588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41701"},
        {"Hipparcos Number", "HIP 28769"},
        {"Smithsonian Astrophysical Observation", "SAO 217703"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.12663391),
        dec: Angle.Degrees(-45.19664124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189563"},
        {"Hipparcos Number", "HIP 98682"},
        {"Geneva Identification System", "GEN# +1.00189563"},
        {"Smithsonian Astrophysical Observation", "SAO 230002"},
    },
    visualMagnitude: 6.56,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.65095358),
        dec: Angle.Degrees(-45.19601780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35366"},
        {"Geneva Identification System", "GEN# +2.23600007"},
        {"New General Catalogue", "NGC 2360 7"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.57919955),
        dec: Angle.Degrees(-15.58318667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32070"},
        {"Geneva Identification System", "GEN# -0.04502687"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.51676977),
        dec: Angle.Degrees(-45.19575431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132456"},
        {"Hipparcos Number", "HIP 73460"},
        {"Smithsonian Astrophysical Observation", "SAO 225368"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.19121301),
        dec: Angle.Degrees(-45.19541576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12464"},
        {"Hipparcos Number", "HIP 9416"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.24743791),
        dec: Angle.Degrees(-45.19528105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88303"},
        {"Hipparcos Number", "HIP 49794"},
        {"Geneva Identification System", "GEN# +1.00088303"},
        {"Smithsonian Astrophysical Observation", "SAO 221817"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.46461455),
        dec: Angle.Degrees(-45.19441493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179433"},
        {"Hipparcos Number", "HIP 94556"},
        {"Geneva Identification System", "GEN# +1.00179433"},
        {"Smithsonian Astrophysical Observation", "SAO 229573"},
    },
    visualMagnitude: 5.91,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.66467390),
        dec: Angle.Degrees(-45.19343079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15999"},
        {"Hipparcos Number", "HIP 11842"},
        {"Smithsonian Astrophysical Observation", "SAO 215938"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.22324587),
        dec: Angle.Degrees(-45.19331522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74167"},
        {"Hipparcos Number", "HIP 42564"},
        {"Geneva Identification System", "GEN# +1.00074167"},
        {"Smithsonian Astrophysical Observation", "SAO 220261"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.14690182),
        dec: Angle.Degrees(-45.19111481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28062",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28062"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.99805290),
        dec: Angle.Degrees(-45.19003722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 208.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125442"},
        {"Hipparcos Number", "HIP 70104"},
        {"Celescope Catalog", "CEL 4313"},
        {"Geneva Identification System", "GEN# +1.00125442"},
        {"Smithsonian Astrophysical Observation", "SAO 224843"},
        {"Wilson Evans Batten Catalogue", "WEB 12186"},
    },
    visualMagnitude: 4.78,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.17729569),
        dec: Angle.Degrees(-45.18688140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114853"},
        {"Hipparcos Number", "HIP 64550"},
        {"Geneva Identification System", "GEN# +1.00114853"},
        {"Smithsonian Astrophysical Observation", "SAO 223987"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.46798635),
        dec: Angle.Degrees(-45.18553071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72231"},
        {"Hipparcos Number", "HIP 41690"},
        {"Geneva Identification System", "GEN# +1.00072231"},
        {"Smithsonian Astrophysical Observation", "SAO 220012"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.48192738),
        dec: Angle.Degrees(-45.18493526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90422"},
        {"Hipparcos Number", "HIP 51028"},
        {"Geneva Identification System", "GEN# +1.00090422"},
        {"Smithsonian Astrophysical Observation", "SAO 222044"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.37306300),
        dec: Angle.Degrees(-45.18263793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187358"},
        {"Hipparcos Number", "HIP 97725"},
        {"Smithsonian Astrophysical Observation", "SAO 229896"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.89147181),
        dec: Angle.Degrees(-45.18258460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56022"},
        {"Hipparcos Number", "HIP 34899"},
        {"Celescope Catalog", "CEL 1688"},
        {"Geneva Identification System", "GEN# +1.00056022"},
        {"Renson", "Renson 15250"},
        {"Smithsonian Astrophysical Observation", "SAO 218546"},
        {"Wilson Evans Batten Catalogue", "WEB 6975"},
    },
    visualMagnitude: 4.87,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.30571289),
        dec: Angle.Degrees(-45.18252474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4130"},
        {"Hipparcos Number", "HIP 3397"},
        {"Smithsonian Astrophysical Observation", "SAO 215208"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.82280285),
        dec: Angle.Degrees(-45.18134654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147556"},
        {"Hipparcos Number", "HIP 80401"},
        {"Smithsonian Astrophysical Observation", "SAO 226726"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.16905317),
        dec: Angle.Degrees(-45.18048636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56781"},
        {"Hipparcos Number", "HIP 35196"},
        {"Geneva Identification System", "GEN# +1.00056781"},
        {"Smithsonian Astrophysical Observation", "SAO 218590"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.09931905),
        dec: Angle.Degrees(-45.17914347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3394"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.771,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.81866644),
        dec: Angle.Degrees(-45.17866872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164546"},
        {"Hipparcos Number", "HIP 88475"},
        {"Celescope Catalog", "CEL 4601"},
        {"Smithsonian Astrophysical Observation", "SAO 228662"},
    },
    visualMagnitude: 7.81,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.98187642),
        dec: Angle.Degrees(-45.17861124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1044",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1044"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.26092514),
        dec: Angle.Degrees(-45.17634037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102964"},
        {"Hipparcos Number", "HIP 57803"},
        {"Fundamental Katalog 5th Edition", "FK5 446"},
        {"Geneva Identification System", "GEN# +1.00102964"},
        {"Smithsonian Astrophysical Observation", "SAO 223062"},
        {"Wilson Evans Batten Catalogue", "WEB 10370"},
    },
    visualMagnitude: 4.47,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.78646511),
        dec: Angle.Degrees(-45.17344950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144197"},
        {"Hipparcos Number", "HIP 78914"},
        {"Fundamental Katalog 5th Edition", "FK5 596"},
        {"Geneva Identification System", "GEN# +1.00144197"},
        {"Renson", "Renson 40840"},
        {"Smithsonian Astrophysical Observation", "SAO 226500"},
        {"Wilson Evans Batten Catalogue", "WEB 13337"},
    },
    visualMagnitude: 4.73,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.62259840),
        dec: Angle.Degrees(-45.17327517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80777"},
        {"Hipparcos Number", "HIP 45796"},
        {"Geneva Identification System", "GEN# +4.27120017"},
        {"Smithsonian Astrophysical Observation", "SAO 221077"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.227,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.06342523),
        dec: Angle.Degrees(-45.17322377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24113"},
        {"Hipparcos Number", "HIP 17795"},
        {"Smithsonian Astrophysical Observation", "SAO 216498"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.14277295),
        dec: Angle.Degrees(-45.17320779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6179"},
        {"Hipparcos Number", "HIP 4839"},
        {"Fundamental Katalog 5th Edition", "FK5 4098"},
        {"Geneva Identification System", "GEN# +1.00006179"},
        {"Smithsonian Astrophysical Observation", "SAO 215337"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.56501153),
        dec: Angle.Degrees(-45.17203060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62644"},
        {"Hipparcos Number", "HIP 37606"},
        {"Cincinnati Publication", "Ci 20 436"},
        {"Geneva Identification System", "GEN# +1.00062644"},
        {"Smithsonian Astrophysical Observation", "SAO 218923"},
        {"Wilson Evans Batten Catalogue", "WEB 7436"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.73817103),
        dec: Angle.Degrees(-45.17177284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -553.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67385"},
        {"Hipparcos Number", "HIP 39613"},
        {"Celescope Catalog", "CEL 2160"},
        {"Geneva Identification System", "GEN# +1.00067385J"},
        {"Smithsonian Astrophysical Observation", "SAO 219406"},
    },
    visualMagnitude: 7.05,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.42945881),
        dec: Angle.Degrees(-45.17121408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170664"},
        {"Hipparcos Number", "HIP 90926"},
        {"Smithsonian Astrophysical Observation", "SAO 229104"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.21518091),
        dec: Angle.Degrees(-45.17090354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20896"},
        {"Hipparcos Number", "HIP 15548"},
        {"Smithsonian Astrophysical Observation", "SAO 216270"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.08180478),
        dec: Angle.Degrees(-45.16958126)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119759"},
        {"Hipparcos Number", "HIP 67187"},
        {"Smithsonian Astrophysical Observation", "SAO 224406"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.52946958),
        dec: Angle.Degrees(-45.16898968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69729"},
        {"Hipparcos Number", "HIP 40516"},
        {"Smithsonian Astrophysical Observation", "SAO 219706"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.08942262),
        dec: Angle.Degrees(-45.16399845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203725"},
        {"Hipparcos Number", "HIP 105779"},
        {"Smithsonian Astrophysical Observation", "SAO 230676"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.34773322),
        dec: Angle.Degrees(-45.16186626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78265"},
        {"Hipparcos Number", "HIP 44630"},
        {"Celescope Catalog", "CEL 3179"},
        {"Geneva Identification System", "GEN# +1.00078265"},
        {"Smithsonian Astrophysical Observation", "SAO 220836"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.41304812),
        dec: Angle.Degrees(-45.16027662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216989"},
        {"Hipparcos Number", "HIP 113401"},
        {"Geneva Identification System", "GEN# +1.00216989"},
        {"Smithsonian Astrophysical Observation", "SAO 231370"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.49277421),
        dec: Angle.Degrees(-45.15818419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85621"},
        {"Hipparcos Number", "HIP 48383"},
        {"Smithsonian Astrophysical Observation", "SAO 221554"},
    },
    visualMagnitude: 7.53,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.94539174),
        dec: Angle.Degrees(-45.15811464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222715"},
        {"Hipparcos Number", "HIP 117015"},
        {"Geneva Identification System", "GEN# +1.00222715"},
        {"Smithsonian Astrophysical Observation", "SAO 231750"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.82163080),
        dec: Angle.Degrees(-45.15783401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58742"},
        {"Hipparcos Number", "HIP 35971"},
        {"Smithsonian Astrophysical Observation", "SAO 218706"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.20762730),
        dec: Angle.Degrees(-45.15755754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131639"},
        {"Hipparcos Number", "HIP 73099"},
        {"Smithsonian Astrophysical Observation", "SAO 225302"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.09538615),
        dec: Angle.Degrees(-45.15620082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206871"},
        {"Hipparcos Number", "HIP 107479"},
        {"Smithsonian Astrophysical Observation", "SAO 230831"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.54004657),
        dec: Angle.Degrees(-45.15483601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154631"},
        {"Hipparcos Number", "HIP 83897"},
        {"Smithsonian Astrophysical Observation", "SAO 227667"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.19885917),
        dec: Angle.Degrees(-45.15454384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220492"},
        {"Hipparcos Number", "HIP 115555"},
        {"Geneva Identification System", "GEN# +1.00220492"},
        {"Smithsonian Astrophysical Observation", "SAO 231593"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.10703498),
        dec: Angle.Degrees(-45.15390588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66587"},
        {"Hipparcos Number", "HIP 39315"},
        {"Smithsonian Astrophysical Observation", "SAO 219331"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.57433297),
        dec: Angle.Degrees(-45.15289208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200321"},
        {"Hipparcos Number", "HIP 104003"},
    },
    visualMagnitude: 10.12,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.06966121),
        dec: Angle.Degrees(-45.15155739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40886",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40886"},
        {"Geneva Identification System", "GEN# -0.04404311"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.14863839),
        dec: Angle.Degrees(-45.14926289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31988"},
        {"Hipparcos Number", "HIP 23074"},
        {"Smithsonian Astrophysical Observation", "SAO 217086"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.47257652),
        dec: Angle.Degrees(-45.14823096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67760"},
        {"Hipparcos Number", "HIP 39758"},
        {"Celescope Catalog", "CEL 2167"},
        {"Geneva Identification System", "GEN# +1.00067760"},
        {"Smithsonian Astrophysical Observation", "SAO 219446"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.88882656),
        dec: Angle.Degrees(-45.14774526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8451"},
        {"Smithsonian Astrophysical Observation", "SAO 148027"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.24043529),
        dec: Angle.Degrees(-15.42791283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216406"},
        {"Hipparcos Number", "HIP 113018"},
        {"Geneva Identification System", "GEN# +1.00216406"},
        {"Smithsonian Astrophysical Observation", "SAO 231341"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.31440298),
        dec: Angle.Degrees(-45.14769490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126801"},
        {"Hipparcos Number", "HIP 70827"},
        {"Smithsonian Astrophysical Observation", "SAO 224954"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.25977373),
        dec: Angle.Degrees(-45.14729553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78708"},
        {"Hipparcos Number", "HIP 44832"},
        {"Smithsonian Astrophysical Observation", "SAO 220884"},
    },
    visualMagnitude: 8.66,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.02658037),
        dec: Angle.Degrees(-45.14387115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173946"},
        {"Hipparcos Number", "HIP 92441"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.58182207),
        dec: Angle.Degrees(-45.14300132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111931"},
        {"Hipparcos Number", "HIP 62887"},
        {"Smithsonian Astrophysical Observation", "SAO 223733"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.32553175),
        dec: Angle.Degrees(-45.14193188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15099"},
        {"Hipparcos Number", "HIP 11230"},
        {"Smithsonian Astrophysical Observation", "SAO 215893"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.13213678),
        dec: Angle.Degrees(-45.14157810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92437",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92437"},
    },
    visualMagnitude: 11.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.57681344),
        dec: Angle.Degrees(-45.14112750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99804"},
        {"Hipparcos Number", "HIP 56004"},
        {"Smithsonian Astrophysical Observation", "SAO 222814"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.15561728),
        dec: Angle.Degrees(-45.14090418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168788"},
        {"Hipparcos Number", "HIP 90151"},
        {"Geneva Identification System", "GEN# +1.00168788"},
        {"Smithsonian Astrophysical Observation", "SAO 228973"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.96204553),
        dec: Angle.Degrees(-45.13962694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130590"},
        {"Hipparcos Number", "HIP 72593"},
        {"Smithsonian Astrophysical Observation", "SAO 225227"},
    },
    visualMagnitude: 8.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.64389413),
        dec: Angle.Degrees(-45.13958066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 329811"},
        {"Hipparcos Number", "HIP 84608"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.42346367),
        dec: Angle.Degrees(-45.13939396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160028"},
        {"Hipparcos Number", "HIP 86464"},
        {"Geneva Identification System", "GEN# +1.00160028"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.99055017),
        dec: Angle.Degrees(-45.13924605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101142"},
        {"Hipparcos Number", "HIP 56748"},
        {"Smithsonian Astrophysical Observation", "SAO 222922"},
    },
    visualMagnitude: 9.03,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.52129876),
        dec: Angle.Degrees(-45.13891762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8305"},
        {"Hipparcos Number", "HIP 6348"},
        {"Geneva Identification System", "GEN# +1.00008305"},
        {"Smithsonian Astrophysical Observation", "SAO 215473"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.38363317),
        dec: Angle.Degrees(-45.13754143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 153.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168821"},
        {"Hipparcos Number", "HIP 90165"},
        {"Smithsonian Astrophysical Observation", "SAO 228978"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.99074759),
        dec: Angle.Degrees(-45.13731945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29446"},
        {"Hipparcos Number", "HIP 21431"},
        {"Geneva Identification System", "GEN# +1.00029446"},
        {"Smithsonian Astrophysical Observation", "SAO 216890"},
        {"Wilson Evans Batten Catalogue", "WEB 4115"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.01853431),
        dec: Angle.Degrees(-45.13638848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74694"},
        {"Hipparcos Number", "HIP 42838"},
        {"Smithsonian Astrophysical Observation", "SAO 220355"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.92433859),
        dec: Angle.Degrees(-45.13623226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218860"},
        {"Hipparcos Number", "HIP 114530"},
        {"Geneva Identification System", "GEN# +1.00218860"},
        {"Smithsonian Astrophysical Observation", "SAO 231485"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.96658872),
        dec: Angle.Degrees(-45.13605843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159039"},
        {"Hipparcos Number", "HIP 86006"},
        {"Geneva Identification System", "GEN# +1.00159039"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.66691639),
        dec: Angle.Degrees(-45.13161807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207812"},
        {"Hipparcos Number", "HIP 108013"},
        {"Smithsonian Astrophysical Observation", "SAO 230884"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.24346794),
        dec: Angle.Degrees(-45.13051761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212131"},
        {"Hipparcos Number", "HIP 110494"},
        {"Geneva Identification System", "GEN# +1.00212131"},
        {"Smithsonian Astrophysical Observation", "SAO 231109"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.73946075),
        dec: Angle.Degrees(-45.12510816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75889"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.50996368),
        dec: Angle.Degrees(-45.12466272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29803"},
        {"Hipparcos Number", "HIP 21698"},
        {"Geneva Identification System", "GEN# +1.00029803J"},
        {"Smithsonian Astrophysical Observation", "SAO 216921"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.88162389),
        dec: Angle.Degrees(-45.12344311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176274"},
        {"Hipparcos Number", "HIP 93422"},
        {"Smithsonian Astrophysical Observation", "SAO 229441"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.39985927),
        dec: Angle.Degrees(-45.12342708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223935"},
        {"Hipparcos Number", "HIP 117831"},
        {"Smithsonian Astrophysical Observation", "SAO 231836"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.46519638),
        dec: Angle.Degrees(-45.12331696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221473"},
        {"Hipparcos Number", "HIP 116204"},
        {"Smithsonian Astrophysical Observation", "SAO 231655"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.16917513),
        dec: Angle.Degrees(-45.12146108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159057"},
        {"Hipparcos Number", "HIP 86021"},
        {"Geneva Identification System", "GEN# +1.00159057"},
        {"Smithsonian Astrophysical Observation", "SAO 228142"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.69331670),
        dec: Angle.Degrees(-45.11986545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 307"},
        {"Hipparcos Number", "HIP 624"},
        {"Geneva Identification System", "GEN# +1.00000307"},
        {"Smithsonian Astrophysical Observation", "SAO 214973"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.90586322),
        dec: Angle.Degrees(-45.11929768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171357"},
        {"Hipparcos Number", "HIP 91243"},
        {"Smithsonian Astrophysical Observation", "SAO 229140"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.17113849),
        dec: Angle.Degrees(-45.11916567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165603"},
        {"Hipparcos Number", "HIP 88912"},
        {"Smithsonian Astrophysical Observation", "SAO 228741"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.24367830),
        dec: Angle.Degrees(-45.11885319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214095"},
        {"Hipparcos Number", "HIP 111623"},
        {"Smithsonian Astrophysical Observation", "SAO 231215"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.19664739),
        dec: Angle.Degrees(-45.11768438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216484"},
        {"Hipparcos Number", "HIP 113061"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.45110715),
        dec: Angle.Degrees(-45.11731329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132016"},
        {"Hipparcos Number", "HIP 73263"},
        {"Geneva Identification System", "GEN# +1.00132016"},
        {"Smithsonian Astrophysical Observation", "SAO 225330"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.59271611),
        dec: Angle.Degrees(-45.11443946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212538"},
        {"Hipparcos Number", "HIP 110720"},
        {"Smithsonian Astrophysical Observation", "SAO 231134"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.48578154),
        dec: Angle.Degrees(-45.11324215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189198"},
        {"Hipparcos Number", "HIP 98512"},
        {"Fundamental Katalog 5th Edition", "FK5 3597"},
        {"Geneva Identification System", "GEN# +1.00189198"},
        {"Smithsonian Astrophysical Observation", "SAO 229981"},
        {"Wilson Evans Batten Catalogue", "WEB 17397"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.20134846),
        dec: Angle.Degrees(-45.11293250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274681"},
        {"Hipparcos Number", "HIP 26242"},
        {"Geneva Identification System", "GEN# +1.00274681"},
        {"Smithsonian Astrophysical Observation", "SAO 217415"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.85890279),
        dec: Angle.Degrees(-45.11022555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112021"},
        {"Hipparcos Number", "HIP 62941"},
        {"Smithsonian Astrophysical Observation", "SAO 223740"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.47644980),
        dec: Angle.Degrees(-45.10917409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127442"},
        {"Hipparcos Number", "HIP 71128"},
        {"Smithsonian Astrophysical Observation", "SAO 225007"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.745,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.19375473),
        dec: Angle.Degrees(-45.10619637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71773"},
        {"Hipparcos Number", "HIP 41459"},
        {"Celescope Catalog", "CEL 2529"},
        {"Smithsonian Astrophysical Observation", "SAO 219947"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.83471640),
        dec: Angle.Degrees(-45.10604562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20819"},
        {"Hipparcos Number", "HIP 15473"},
        {"Smithsonian Astrophysical Observation", "SAO 216260"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.87441540),
        dec: Angle.Degrees(-45.10522358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152476"},
        {"Hipparcos Number", "HIP 82833"},
        {"Smithsonian Astrophysical Observation", "SAO 227442"},
        {"Wilson Evans Batten Catalogue", "WEB 14001"},
    },
    visualMagnitude: 10.32,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.90748945),
        dec: Angle.Degrees(-45.10288784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93021"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.26100700),
        dec: Angle.Degrees(-45.10285511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187702"},
        {"Hipparcos Number", "HIP 97873"},
        {"Smithsonian Astrophysical Observation", "SAO 229913"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.33447935),
        dec: Angle.Degrees(-45.10078499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90752"},
        {"Hipparcos Number", "HIP 51226"},
        {"Smithsonian Astrophysical Observation", "SAO 222074"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.94448863),
        dec: Angle.Degrees(-45.09876478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98022"},
    },
    visualMagnitude: 11.29,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.79299607),
        dec: Angle.Degrees(-45.09716677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21273"},
        {"Hipparcos Number", "HIP 15860"},
        {"Geneva Identification System", "GEN# +1.00021273"},
        {"Smithsonian Astrophysical Observation", "SAO 216299"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.07153764),
        dec: Angle.Degrees(-45.09681223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101864"},
        {"Hipparcos Number", "HIP 57154"},
        {"Smithsonian Astrophysical Observation", "SAO 222977"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.82345132),
        dec: Angle.Degrees(-45.09492747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98495"},
        {"Hipparcos Number", "HIP 55283"},
        {"Smithsonian Astrophysical Observation", "SAO 222716"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.83815204),
        dec: Angle.Degrees(-45.09327671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216938"},
        {"Hipparcos Number", "HIP 113369"},
        {"Smithsonian Astrophysical Observation", "SAO 231366"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.41348965),
        dec: Angle.Degrees(-45.09249551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42168"},
        {"Hipparcos Number", "HIP 28988"},
        {"Geneva Identification System", "GEN# +1.00042168"},
        {"Smithsonian Astrophysical Observation", "SAO 217724"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.75760748),
        dec: Angle.Degrees(-45.09162196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 273649"},
        {"Hipparcos Number", "HIP 24765"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.63614758),
        dec: Angle.Degrees(-45.09072495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17715"},
        {"Hipparcos Number", "HIP 13139"},
        {"Geneva Identification System", "GEN# +1.00017715"},
        {"Smithsonian Astrophysical Observation", "SAO 216059"},
        {"Wilson Evans Batten Catalogue", "WEB 2645"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.24626318),
        dec: Angle.Degrees(-45.08996647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195722"},
        {"Hipparcos Number", "HIP 101547"},
        {"Smithsonian Astrophysical Observation", "SAO 230281"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.68778241),
        dec: Angle.Degrees(-45.08844923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67747",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67747"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.18176897),
        dec: Angle.Degrees(-45.08762828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63342"},
        {"Hipparcos Number", "HIP 37929"},
        {"Smithsonian Astrophysical Observation", "SAO 218980"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.59220172),
        dec: Angle.Degrees(-45.08750653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28743"},
        {"Hipparcos Number", "HIP 20970"},
        {"Smithsonian Astrophysical Observation", "SAO 216833"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.44141935),
        dec: Angle.Degrees(-45.08420780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89339"},
        {"Hipparcos Number", "HIP 50395"},
        {"Smithsonian Astrophysical Observation", "SAO 221935"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.35988789),
        dec: Angle.Degrees(-45.08345320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222803"},
        {"Hipparcos Number", "HIP 117075"},
        {"Fundamental Katalog 5th Edition", "FK5 3903"},
        {"Geneva Identification System", "GEN# +1.00222803"},
        {"Smithsonian Astrophysical Observation", "SAO 231756"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.00438262),
        dec: Angle.Degrees(-45.08312786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 325.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103453"},
        {"Hipparcos Number", "HIP 58076"},
        {"Geneva Identification System", "GEN# +1.00103453"},
        {"Smithsonian Astrophysical Observation", "SAO 223100"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.64995197),
        dec: Angle.Degrees(-45.08184404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10838"},
        {"Hipparcos Number", "HIP 8192"},
        {"Smithsonian Astrophysical Observation", "SAO 215635"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.33289241),
        dec: Angle.Degrees(-45.08125720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96998"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.71998966),
        dec: Angle.Degrees(-45.08084040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -247.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181743"},
        {"Hipparcos Number", "HIP 95333"},
        {"Cincinnati Publication", "Ci 20 1148"},
        {"Geneva Identification System", "GEN# +1.00181743"},
        {"Wilson Evans Batten Catalogue", "WEB 16661"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.92833535),
        dec: Angle.Degrees(-45.08049122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -814.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41742"},
        {"Henry Draper 2", "HD 41742A"},
        {"Hipparcos Number", "HIP 28790"},
        {"Geneva Identification System", "GEN# +1.00041742"},
        {"Smithsonian Astrophysical Observation", "SAO 217706"},
        {"Wilson Evans Batten Catalogue", "WEB 5631"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.16736258),
        dec: Angle.Degrees(-45.07954967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 254.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123683"},
        {"Hipparcos Number", "HIP 69215"},
        {"Smithsonian Astrophysical Observation", "SAO 224738"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.55733870),
        dec: Angle.Degrees(-45.07796644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177897"},
        {"Hipparcos Number", "HIP 94037"},
        {"Smithsonian Astrophysical Observation", "SAO 229515"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.17829454),
        dec: Angle.Degrees(-45.07619116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6851",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9029"},
        {"Hipparcos Number", "HIP 6851"},
        {"Geneva Identification System", "GEN# +1.00009029"},
        {"Smithsonian Astrophysical Observation", "SAO 215515"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.02909188),
        dec: Angle.Degrees(-45.07579614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75241"},
        {"Hipparcos Number", "HIP 43128"},
        {"Celescope Catalog", "CEL 2905"},
        {"Geneva Identification System", "GEN# +1.00075241"},
        {"Smithsonian Astrophysical Observation", "SAO 220452"},
        {"Wilson Evans Batten Catalogue", "WEB 8325"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.77239632),
        dec: Angle.Degrees(-45.07476552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201484"},
        {"Hipparcos Number", "HIP 104613"},
        {"Geneva Identification System", "GEN# +1.00201484"},
        {"Smithsonian Astrophysical Observation", "SAO 230567"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.87484278),
        dec: Angle.Degrees(-45.07434770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47267"},
        {"Hipparcos Number", "HIP 31478"},
        {"Geneva Identification System", "GEN# +1.00047267"},
        {"Smithsonian Astrophysical Observation", "SAO 218043"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89521813),
        dec: Angle.Degrees(-45.07204630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16308"},
        {"Hipparcos Number", "HIP 12071"},
        {"Geneva Identification System", "GEN# +1.00016308"},
        {"Smithsonian Astrophysical Observation", "SAO 215955"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.91083373),
        dec: Angle.Degrees(-45.07005191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91356"},
        {"Hipparcos Number", "HIP 51560"},
        {"Geneva Identification System", "GEN# +1.00091356"},
        {"Smithsonian Astrophysical Observation", "SAO 222125"},
        {"Wilson Evans Batten Catalogue", "WEB 9407"},
    },
    visualMagnitude: 6.04,
    bvColour: -0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.98605873),
        dec: Angle.Degrees(-45.06965570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219071"},
        {"Hipparcos Number", "HIP 114650"},
        {"Smithsonian Astrophysical Observation", "SAO 231496"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.37996107),
        dec: Angle.Degrees(-45.06942034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116992"},
        {"Hipparcos Number", "HIP 65689"},
        {"Smithsonian Astrophysical Observation", "SAO 224156"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02198750),
        dec: Angle.Degrees(-45.06914444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138191"},
        {"Hipparcos Number", "HIP 76073"},
        {"Celescope Catalog", "CEL 4376"},
        {"Geneva Identification System", "GEN# +1.00138191"},
        {"Smithsonian Astrophysical Observation", "SAO 225876"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.05789250),
        dec: Angle.Degrees(-45.06752915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91355"},
        {"Hipparcos Number", "HIP 51561"},
        {"Smithsonian Astrophysical Observation", "SAO 222126"},
        {"Wilson Evans Batten Catalogue", "WEB 9410"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.98937004),
        dec: Angle.Degrees(-45.06671373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79736"},
        {"Hipparcos Number", "HIP 45322"},
        {"Geneva Identification System", "GEN# +1.00079736"},
        {"Smithsonian Astrophysical Observation", "SAO 220973"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.54588631),
        dec: Angle.Degrees(-45.06649247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -155.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173444"},
        {"Hipparcos Number", "HIP 92212"},
        {"Smithsonian Astrophysical Observation", "SAO 229279"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.89449371),
        dec: Angle.Degrees(-45.06634193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77872",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77872"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.53233861),
        dec: Angle.Degrees(-14.97966533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47924"},
        {"Hipparcos Number", "HIP 31784"},
        {"Smithsonian Astrophysical Observation", "SAO 218088"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.68328093),
        dec: Angle.Degrees(-45.06447428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46859"},
        {"Hipparcos Number", "HIP 31270"},
        {"Geneva Identification System", "GEN# +1.00046859"},
        {"Smithsonian Astrophysical Observation", "SAO 218019"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.36622785),
        dec: Angle.Degrees(-45.06366673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18335"},
        {"Hipparcos Number", "HIP 13591"},
        {"Smithsonian Astrophysical Observation", "SAO 216096"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.78278979),
        dec: Angle.Degrees(-45.06024469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31781",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31781"},
        {"Smithsonian Astrophysical Observation", "SAO 218087"},
    },
    visualMagnitude: 8.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.67987524),
        dec: Angle.Degrees(-45.06008208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2586"},
        {"Hipparcos Number", "HIP 2284"},
        {"Smithsonian Astrophysical Observation", "SAO 215109"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.29518408),
        dec: Angle.Degrees(-45.05933608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68892"},
        {"Hipparcos Number", "HIP 40189"},
        {"Geneva Identification System", "GEN# +1.00068892"},
        {"Smithsonian Astrophysical Observation", "SAO 219603"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.857,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.13828046),
        dec: Angle.Degrees(-45.05930642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74194"},
        {"Hipparcos Number", "HIP 42587"},
        {"Celescope Catalog", "CEL 2771"},
        {"Geneva Identification System", "GEN# +1.00074194"},
        {"Smithsonian Astrophysical Observation", "SAO 220270"},
        {"Wilson Evans Batten Catalogue", "WEB 8220"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.19915730),
        dec: Angle.Degrees(-45.05841362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67890"},
        {"Hipparcos Number", "HIP 39810"},
        {"Celescope Catalog", "CEL 2176"},
        {"Geneva Identification System", "GEN# +1.00067890"},
        {"Smithsonian Astrophysical Observation", "SAO 219457"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.02375652),
        dec: Angle.Degrees(-45.05795810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223090"},
        {"Hipparcos Number", "HIP 117269"},
        {"Smithsonian Astrophysical Observation", "SAO 231776"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.68476944),
        dec: Angle.Degrees(-45.05714817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92530"},
        {"Hipparcos Number", "HIP 52229"},
        {"Smithsonian Astrophysical Observation", "SAO 222243"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05970256),
        dec: Angle.Degrees(-45.05491175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54504"},
        {"Hipparcos Number", "HIP 34322"},
        {"Geneva Identification System", "GEN# +1.00054504"},
        {"Smithsonian Astrophysical Observation", "SAO 218463"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.73024397),
        dec: Angle.Degrees(-45.05127355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215571"},
        {"Hipparcos Number", "HIP 112467"},
        {"Geneva Identification System", "GEN# +1.00215571"},
        {"Smithsonian Astrophysical Observation", "SAO 231294"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.71671574),
        dec: Angle.Degrees(-45.05125766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36051"},
        {"Hipparcos Number", "HIP 25461"},
        {"Geneva Identification System", "GEN# +1.00036051"},
        {"Smithsonian Astrophysical Observation", "SAO 217338"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.67765456),
        dec: Angle.Degrees(-45.04980132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97005"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.74418478),
        dec: Angle.Degrees(-45.04932399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50786"},
        {"Hipparcos Number", "HIP 32996"},
        {"Geneva Identification System", "GEN# +1.00050786"},
        {"Smithsonian Astrophysical Observation", "SAO 218271"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.11610961),
        dec: Angle.Degrees(-45.04885510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30908"},
        {"Smithsonian Astrophysical Observation", "SAO 151555"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.31377846),
        dec: Angle.Degrees(-14.35777646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50181"},
        {"Hipparcos Number", "HIP 32762"},
        {"Smithsonian Astrophysical Observation", "SAO 218231"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.46594141),
        dec: Angle.Degrees(-45.04840661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 117.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15433"},
        {"Hipparcos Number", "HIP 11450"},
        {"Smithsonian Astrophysical Observation", "SAO 215909"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.93208197),
        dec: Angle.Degrees(-45.04763062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 272481"},
        {"Hipparcos Number", "HIP 22555"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.80938975),
        dec: Angle.Degrees(-45.04635526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 274680"},
        {"Hipparcos Number", "HIP 26260"},
        {"Geneva Identification System", "GEN# +1.00274680"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.88922125),
        dec: Angle.Degrees(-45.04630340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29814"},
        {"Hipparcos Number", "HIP 21711"},
        {"Geneva Identification System", "GEN# +1.00029814"},
        {"Smithsonian Astrophysical Observation", "SAO 216923"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.92833691),
        dec: Angle.Degrees(-45.04556660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27805"},
        {"Hipparcos Number", "HIP 20323"},
        {"Geneva Identification System", "GEN# +1.00027805"},
        {"Smithsonian Astrophysical Observation", "SAO 216760"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.31251699),
        dec: Angle.Degrees(-45.04382154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80922"},
        {"Hipparcos Number", "HIP 45861"},
        {"Geneva Identification System", "GEN# +1.00080922"},
        {"Smithsonian Astrophysical Observation", "SAO 221089"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.26540971),
        dec: Angle.Degrees(-45.04190874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76566"},
        {"Hipparcos Number", "HIP 43807"},
        {"Celescope Catalog", "CEL 3081"},
        {"Geneva Identification System", "GEN# +1.00076566A"},
        {"Smithsonian Astrophysical Observation", "SAO 220664"},
        {"Wilson Evans Batten Catalogue", "WEB 8424"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.83005467),
        dec: Angle.Degrees(-45.04169055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43372"},
        {"Hipparcos Number", "HIP 29553"},
        {"Geneva Identification System", "GEN# +1.00043372"},
        {"Smithsonian Astrophysical Observation", "SAO 217789"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.41212750),
        dec: Angle.Degrees(-45.03821502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107915"},
        {"Hipparcos Number", "HIP 60512"},
        {"Geneva Identification System", "GEN# +1.00107915"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.07489210),
        dec: Angle.Degrees(-45.03724002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41700"},
        {"Hipparcos Number", "HIP 28764"},
        {"Fundamental Katalog 5th Edition", "FK5 231"},
        {"Geneva Identification System", "GEN# +1.00041700"},
        {"Smithsonian Astrophysical Observation", "SAO 217702"},
        {"Wilson Evans Batten Catalogue", "WEB 5627"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.11878029),
        dec: Angle.Degrees(-45.03720225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 246.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18890"},
        {"Hipparcos Number", "HIP 14025"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.15368584),
        dec: Angle.Degrees(-45.03715661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55939"},
        {"Hipparcos Number", "HIP 34863"},
        {"Smithsonian Astrophysical Observation", "SAO 218540"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.20653378),
        dec: Angle.Degrees(-45.03692025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70218"},
        {"Henry Draper 2", "HD 70218A"},
        {"Hipparcos Number", "HIP 40738"},
        {"Celescope Catalog", "CEL 2361"},
        {"Smithsonian Astrophysical Observation", "SAO 219776"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.72515607),
        dec: Angle.Degrees(-45.03626907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10385"},
        {"Henry Draper 2", "HD 10385A"},
        {"Hipparcos Number", "HIP 7807"},
        {"Geneva Identification System", "GEN# +1.00010385"},
        {"Smithsonian Astrophysical Observation", "SAO 215609"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.10230899),
        dec: Angle.Degrees(-45.03566292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181671"},
        {"Hipparcos Number", "HIP 95305"},
        {"Geneva Identification System", "GEN# +1.00181671"},
        {"Smithsonian Astrophysical Observation", "SAO 229655"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.84799094),
        dec: Angle.Degrees(-45.03282303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110595"},
        {"Hipparcos Number", "HIP 62099"},
        {"Smithsonian Astrophysical Observation", "SAO 223626"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.89403165),
        dec: Angle.Degrees(-45.03212555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35595"},
        {"Hipparcos Number", "HIP 25213"},
        {"Smithsonian Astrophysical Observation", "SAO 217316"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.90416871),
        dec: Angle.Degrees(-45.03096387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112967"},
        {"Hipparcos Number", "HIP 63521"},
        {"Smithsonian Astrophysical Observation", "SAO 223837"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.24510159),
        dec: Angle.Degrees(-45.02905434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61390"},
        {"Hipparcos Number", "HIP 37055"},
        {"Geneva Identification System", "GEN# +1.00061390"},
        {"Smithsonian Astrophysical Observation", "SAO 218842"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.22905480),
        dec: Angle.Degrees(-45.02811577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161579"},
        {"Hipparcos Number", "HIP 87171"},
        {"Smithsonian Astrophysical Observation", "SAO 228436"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.15619064),
        dec: Angle.Degrees(-45.02758394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153339"},
        {"Hipparcos Number", "HIP 83263"},
        {"Smithsonian Astrophysical Observation", "SAO 227550"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.26527577),
        dec: Angle.Degrees(-45.02625543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66105"},
        {"Hipparcos Number", "HIP 39107"},
        {"Smithsonian Astrophysical Observation", "SAO 219268"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.01239765),
        dec: Angle.Degrees(-45.02574626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53524"},
        {"Hipparcos Number", "HIP 33994"},
        {"Geneva Identification System", "GEN# +1.00053524"},
        {"Smithsonian Astrophysical Observation", "SAO 218409"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.80372449),
        dec: Angle.Degrees(-45.02456441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1890"},
        {"Hipparcos Number", "HIP 1820"},
        {"Smithsonian Astrophysical Observation", "SAO 215075"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.76662850),
        dec: Angle.Degrees(-45.02371378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15507"},
        {"Hipparcos Number", "HIP 11514"},
        {"Geneva Identification System", "GEN# +1.00015507"},
        {"Smithsonian Astrophysical Observation", "SAO 215912"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.12003667),
        dec: Angle.Degrees(-45.02295493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62135",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62135"},
    },
    visualMagnitude: 11.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.01826793),
        dec: Angle.Degrees(-45.02202382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202874"},
        {"Hipparcos Number", "HIP 105334"},
        {"Geneva Identification System", "GEN# +1.00202874"},
        {"Smithsonian Astrophysical Observation", "SAO 230635"},
        {"Wilson Evans Batten Catalogue", "WEB 19132"},
    },
    visualMagnitude: 6.15,
    bvColour: 2.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.03951149),
        dec: Angle.Degrees(-45.02189994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139465"},
        {"Hipparcos Number", "HIP 76730"},
        {"Fundamental Katalog 5th Edition", "FK5 5385"},
        {"Geneva Identification System", "GEN# +1.00139465"},
        {"Smithsonian Astrophysical Observation", "SAO 226041"},
        {"Wilson Evans Batten Catalogue", "WEB 13022"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.03850724),
        dec: Angle.Degrees(-45.02125295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4330"},
        {"Hipparcos Number", "HIP 3543"},
        {"Smithsonian Astrophysical Observation", "SAO 215224"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.31572942),
        dec: Angle.Degrees(-45.02040137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84306"},
        {"Hipparcos Number", "HIP 47659"},
        {"Smithsonian Astrophysical Observation", "SAO 221424"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.75947942),
        dec: Angle.Degrees(-45.01592771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203677"},
        {"Hipparcos Number", "HIP 105748"},
        {"Smithsonian Astrophysical Observation", "SAO 230674"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27751190),
        dec: Angle.Degrees(-45.01546169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134557"},
        {"Hipparcos Number", "HIP 74387"},
        {"Celescope Catalog", "CEL 4349"},
        {"Geneva Identification System", "GEN# +1.00134557J"},
        {"Smithsonian Astrophysical Observation", "SAO 225528"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.01801625),
        dec: Angle.Degrees(-45.01256454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80205"},
        {"Hipparcos Number", "HIP 45545"},
        {"Celescope Catalog", "CEL 3253"},
        {"Geneva Identification System", "GEN# +1.00080205"},
        {"Smithsonian Astrophysical Observation", "SAO 221026"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.24164860),
        dec: Angle.Degrees(-45.01197504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182158"},
        {"Hipparcos Number", "HIP 95489"},
        {"Smithsonian Astrophysical Observation", "SAO 229669"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.34786371),
        dec: Angle.Degrees(-45.01185214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201109"},
        {"Hipparcos Number", "HIP 104403"},
        {"Geneva Identification System", "GEN# +1.00201109"},
        {"Smithsonian Astrophysical Observation", "SAO 230545"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.25763224),
        dec: Angle.Degrees(-45.01184399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68533",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68533"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.44176180),
        dec: Angle.Degrees(-45.01146053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30775"},
        {"Hipparcos Number", "HIP 22318"},
        {"Geneva Identification System", "GEN# +1.00030775"},
        {"Smithsonian Astrophysical Observation", "SAO 217003"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.10673329),
        dec: Angle.Degrees(-45.01090045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158411"},
        {"Hipparcos Number", "HIP 85748"},
    },
    visualMagnitude: 9.35,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.83729858),
        dec: Angle.Degrees(-45.01076954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115303",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115303"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.29769971),
        dec: Angle.Degrees(-45.00971368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157316"},
        {"Hipparcos Number", "HIP 85211"},
        {"Geneva Identification System", "GEN# +1.00157316"},
        {"Smithsonian Astrophysical Observation", "SAO 227920"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.17959825),
        dec: Angle.Degrees(-45.00832839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80527"},
        {"Hipparcos Number", "HIP 45690"},
        {"Geneva Identification System", "GEN# +1.00080527"},
        {"Smithsonian Astrophysical Observation", "SAO 221053"},
    },
    visualMagnitude: 7.20,
    bvColour: 1.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.71524352),
        dec: Angle.Degrees(-45.00795032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207699"},
        {"Hipparcos Number", "HIP 107936"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.01316292),
        dec: Angle.Degrees(-45.00734956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158928"},
        {"Hipparcos Number", "HIP 85967"},
        {"Celescope Catalog", "CEL 4532"},
        {"Geneva Identification System", "GEN# +1.00158928"},
        {"Smithsonian Astrophysical Observation", "SAO 228127"},
    },
    visualMagnitude: 7.00,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.54408150),
        dec: Angle.Degrees(-45.00636136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86714"},
        {"Hipparcos Number", "HIP 48950"},
        {"Geneva Identification System", "GEN# +1.00086714"},
        {"Smithsonian Astrophysical Observation", "SAO 221664"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.79454643),
        dec: Angle.Degrees(-45.00623587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213477"},
        {"Hipparcos Number", "HIP 111262"},
        {"Smithsonian Astrophysical Observation", "SAO 231189"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.11233789),
        dec: Angle.Degrees(-45.00463413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24186",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kapteyn's star"},
        {"Common Name 2", "Kapteyn Star"},
        {"Common Name 3", "Kapteyn's"},
        {"Henry Draper", "HD 33793"},
        {"Hipparcos Number", "HIP 24186"},
        {"Cincinnati Publication", "Ci 20 319"},
        {"Geneva Identification System", "GEN# +1.00033793"},
        {"Smithsonian Astrophysical Observation", "SAO 217223"},
        {"Wilson Evans Batten Catalogue", "WEB 4691"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.89672045),
        dec: Angle.Degrees(-45.00448677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6506.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5731.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133437"},
        {"Hipparcos Number", "HIP 73878"},
        {"Smithsonian Astrophysical Observation", "SAO 225440"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.49662317),
        dec: Angle.Degrees(-45.00401517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107435"},
        {"Hipparcos Number", "HIP 60241"},
        {"Smithsonian Astrophysical Observation", "SAO 223367"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.29257336),
        dec: Angle.Degrees(-45.00328391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70717"},
        {"Hipparcos Number", "HIP 40970"},
        {"Geneva Identification System", "GEN# +1.00070717"},
        {"Smithsonian Astrophysical Observation", "SAO 219833"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.41076021),
        dec: Angle.Degrees(-45.00292134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54163",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54163"},
        {"Smithsonian Astrophysical Observation", "SAO 222542"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.19534166),
        dec: Angle.Degrees(-45.00057081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124580"},
        {"Hipparcos Number", "HIP 69671"},
        {"Geneva Identification System", "GEN# +1.00124580"},
        {"Smithsonian Astrophysical Observation", "SAO 224798"},
        {"Wilson Evans Batten Catalogue", "WEB 12131"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.91074870),
        dec: Angle.Degrees(-45.00042116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -137.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205189"},
        {"Hipparcos Number", "HIP 106573"},
        {"Geneva Identification System", "GEN# +1.00205189"},
        {"Smithsonian Astrophysical Observation", "SAO 230743"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.75832954),
        dec: Angle.Degrees(-44.99863887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212565"},
        {"Hipparcos Number", "HIP 110738"},
        {"Smithsonian Astrophysical Observation", "SAO 231135"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.52817781),
        dec: Angle.Degrees(-44.99808509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101910"},
        {"Hipparcos Number", "HIP 57174"},
        {"Smithsonian Astrophysical Observation", "SAO 222979"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.87805084),
        dec: Angle.Degrees(-44.99482208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149406"},
        {"Hipparcos Number", "HIP 81326"},
        {"Smithsonian Astrophysical Observation", "SAO 226955"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.14973379),
        dec: Angle.Degrees(-44.99389787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74319"},
        {"Hipparcos Number", "HIP 42653"},
        {"Celescope Catalog", "CEL 2785"},
        {"Geneva Identification System", "GEN# +1.00074319J"},
        {"Smithsonian Astrophysical Observation", "SAO 220293"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.39547698),
        dec: Angle.Degrees(-44.99193840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19860"},
        {"Hipparcos Number", "HIP 14703"},
        {"Smithsonian Astrophysical Observation", "SAO 216193"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.48553365),
        dec: Angle.Degrees(-44.99177860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91443"},
    },
    visualMagnitude: 11.83,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.73599078),
        dec: Angle.Degrees(-44.99080760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70682"},
        {"Hipparcos Number", "HIP 40948"},
        {"Celescope Catalog", "CEL 2412"},
        {"Smithsonian Astrophysical Observation", "SAO 219824"},
    },
    visualMagnitude: 7.75,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.35637637),
        dec: Angle.Degrees(-44.98996496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123682"},
        {"Hipparcos Number", "HIP 69220"},
        {"Geneva Identification System", "GEN# +1.00123682A"},
        {"Smithsonian Astrophysical Observation", "SAO 224740"},
        {"Wilson Evans Batten Catalogue", "WEB 12080"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.57330534),
        dec: Angle.Degrees(-44.98895584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -312.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217486"},
        {"Hipparcos Number", "HIP 113697"},
        {"Geneva Identification System", "GEN# +1.00217486"},
        {"Smithsonian Astrophysical Observation", "SAO 231396"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.40725639),
        dec: Angle.Degrees(-44.98859996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153234"},
        {"Hipparcos Number", "HIP 83202"},
        {"Fundamental Katalog 5th Edition", "FK5 3350"},
        {"Geneva Identification System", "GEN# +1.00153234"},
        {"Smithsonian Astrophysical Observation", "SAO 227541"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.05941389),
        dec: Angle.Degrees(-44.98846818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61333"},
        {"Hipparcos Number", "HIP 37034"},
        {"Celescope Catalog", "CEL 1953"},
        {"Geneva Identification System", "GEN# +1.00061333"},
        {"Smithsonian Astrophysical Observation", "SAO 218837"},
        {"Wilson Evans Batten Catalogue", "WEB 7347"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.15701145),
        dec: Angle.Degrees(-44.98730889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193363"},
        {"Hipparcos Number", "HIP 100395"},
        {"Smithsonian Astrophysical Observation", "SAO 230166"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.39489868),
        dec: Angle.Degrees(-44.98667753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4238"},
        {"Hipparcos Number", "HIP 3475"},
        {"Smithsonian Astrophysical Observation", "SAO 215218"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.09812157),
        dec: Angle.Degrees(-44.98262939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190269"},
        {"Hipparcos Number", "HIP 99012"},
        {"Geneva Identification System", "GEN# +1.00190269"},
        {"Smithsonian Astrophysical Observation", "SAO 230034"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.51247789),
        dec: Angle.Degrees(-44.98016160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69224",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69224"},
        {"Geneva Identification System", "GEN# +1.00123682B"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.59040865),
        dec: Angle.Degrees(-44.97855266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -314.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186771"},
        {"Hipparcos Number", "HIP 97447"},
        {"Smithsonian Astrophysical Observation", "SAO 229872"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.09527772),
        dec: Angle.Degrees(-44.97756893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163457"},
        {"Hipparcos Number", "HIP 87996"},
        {"Smithsonian Astrophysical Observation", "SAO 228586"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.61653941),
        dec: Angle.Degrees(-44.97736440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47645"},
        {"Hipparcos Number", "HIP 31647"},
        {"Geneva Identification System", "GEN# +1.00047645"},
        {"Smithsonian Astrophysical Observation", "SAO 218065"},
    },
    visualMagnitude: 8.08,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.35422389),
        dec: Angle.Degrees(-44.97606521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49559"},
        {"Hipparcos Number", "HIP 32484"},
        {"Geneva Identification System", "GEN# +1.00049559"},
        {"Smithsonian Astrophysical Observation", "SAO 218185"},
        {"Wilson Evans Batten Catalogue", "WEB 6552"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.69394879),
        dec: Angle.Degrees(-44.97408658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90157",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168802"},
        {"Hipparcos Number", "HIP 90157"},
        {"Geneva Identification System", "GEN# +1.00168802"},
        {"Smithsonian Astrophysical Observation", "SAO 228976"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.97846577),
        dec: Angle.Degrees(-44.96941130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175531"},
        {"Hipparcos Number", "HIP 93096"},
    },
    visualMagnitude: 9.76,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.48604044),
        dec: Angle.Degrees(-44.96836623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100145"},
        {"Hipparcos Number", "HIP 56193"},
        {"Geneva Identification System", "GEN# +1.00100145"},
        {"Smithsonian Astrophysical Observation", "SAO 222835"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.78987328),
        dec: Angle.Degrees(-44.96778888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41113"},
        {"Celescope Catalog", "CEL 2456"},
        {"Smithsonian Astrophysical Observation", "SAO 219863"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.83339854),
        dec: Angle.Degrees(-44.96567313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215657"},
        {"Hipparcos Number", "HIP 112515"},
        {"Geneva Identification System", "GEN# +1.00215657"},
        {"Smithsonian Astrophysical Observation", "SAO 231298"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.86152084),
        dec: Angle.Degrees(-44.96519093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81276"},
        {"Hipparcos Number", "HIP 46024"},
        {"Geneva Identification System", "GEN# +1.00081276"},
        {"Smithsonian Astrophysical Observation", "SAO 221120"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.79591434),
        dec: Angle.Degrees(-44.96505299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54309"},
    },
    visualMagnitude: 12.25,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.65307306),
        dec: Angle.Degrees(-44.96398744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33050"},
        {"Hipparcos Number", "HIP 23676"},
        {"Smithsonian Astrophysical Observation", "SAO 217166"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.34153460),
        dec: Angle.Degrees(-44.96314571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 328736"},
        {"Hipparcos Number", "HIP 81960"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.15018435),
        dec: Angle.Degrees(-44.96303444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19730"},
        {"Hipparcos Number", "HIP 14622"},
        {"Geneva Identification System", "GEN# +1.00019730"},
        {"Smithsonian Astrophysical Observation", "SAO 216183"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.21634061),
        dec: Angle.Degrees(-44.95900688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134704"},
        {"Hipparcos Number", "HIP 74454"},
        {"Geneva Identification System", "GEN# +1.00134704"},
        {"Smithsonian Astrophysical Observation", "SAO 225542"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.22768380),
        dec: Angle.Degrees(-44.95874489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138769"},
        {"Hipparcos Number", "HIP 76371"},
        {"Celescope Catalog", "CEL 4383"},
        {"Geneva Identification System", "GEN# +1.00138769"},
        {"Renson", "Renson 39515"},
        {"Smithsonian Astrophysical Observation", "SAO 225950"},
        {"Wilson Evans Batten Catalogue", "WEB 12962"},
    },
    visualMagnitude: 4.55,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.97193752),
        dec: Angle.Degrees(-44.95833688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115911"},
        {"Hipparcos Number", "HIP 65140"},
        {"Smithsonian Astrophysical Observation", "SAO 224079"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.23254311),
        dec: Angle.Degrees(-44.95796890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102918"},
        {"Hipparcos Number", "HIP 57767"},
        {"Smithsonian Astrophysical Observation", "SAO 223056"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.70169136),
        dec: Angle.Degrees(-44.95773926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142871"},
        {"Hipparcos Number", "HIP 78264"},
        {"Smithsonian Astrophysical Observation", "SAO 226418"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.71074915),
        dec: Angle.Degrees(-44.95761308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61245"},
        {"Hipparcos Number", "HIP 36992"},
        {"Smithsonian Astrophysical Observation", "SAO 218831"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.05741637),
        dec: Angle.Degrees(-44.95758267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206359"},
        {"Hipparcos Number", "HIP 107203"},
        {"Smithsonian Astrophysical Observation", "SAO 230803"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.70213594),
        dec: Angle.Degrees(-44.95706365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
