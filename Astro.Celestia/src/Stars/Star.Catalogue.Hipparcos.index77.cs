using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_77() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103354"},
        {"Hipparcos Number", "HIP 58034"},
        {"Geneva Identification System", "GEN# +1.00103354"},
        {"Smithsonian Astrophysical Observation", "SAO 99853"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.53221248),
        dec: Angle.Degrees(+18.16961407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39455"},
        {"Hipparcos Number", "HIP 27841"},
        {"Geneva Identification System", "GEN# +1.00039455"},
        {"Smithsonian Astrophysical Observation", "SAO 94961"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.36190924),
        dec: Angle.Degrees(+18.16997032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75560",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9634 AB"},
        {"Henry Draper", "HD 137557"},
        {"Hipparcos Number", "HIP 75560"},
        {"Smithsonian Astrophysical Observation", "SAO 101554"},
        {"Wilson Evans Batten Catalogue", "WEB 12875"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.53713360),
        dec: Angle.Degrees(+18.17119738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20477"},
        {"Hipparcos Number", "HIP 15381"},
        {"Geneva Identification System", "GEN# +1.00020477"},
        {"Smithsonian Astrophysical Observation", "SAO 93376"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.58347719),
        dec: Angle.Degrees(+18.17187524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73607",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73607"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.68625415),
        dec: Angle.Degrees(+18.17255137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63086",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63086"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.89015185),
        dec: Angle.Degrees(+18.17268579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2946",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2946"},
        {"Smithsonian Astrophysical Observation", "SAO 92002"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.34635330),
        dec: Angle.Degrees(+18.17297131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348533"},
        {"Hipparcos Number", "HIP 89972"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.35879156),
        dec: Angle.Degrees(+18.17380522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192323"},
        {"Hipparcos Number", "HIP 99682"},
        {"Smithsonian Astrophysical Observation", "SAO 105860"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.42607827),
        dec: Angle.Degrees(+18.17412770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85525",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158448"},
        {"Hipparcos Number", "HIP 85525"},
        {"Smithsonian Astrophysical Observation", "SAO 102847"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.17163235),
        dec: Angle.Degrees(+18.17415573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230010"},
        {"Hipparcos Number", "HIP 92803"},
        {"Smithsonian Astrophysical Observation", "SAO 104249"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.64176769),
        dec: Angle.Degrees(+18.17463470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42436"},
        {"New General Catalogue", "NGC 2632 4745"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.79579133),
        dec: Angle.Degrees(+18.17601841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6975"},
        {"Hipparcos Number", "HIP 5500"},
        {"Smithsonian Astrophysical Observation", "SAO 92291"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.60515448),
        dec: Angle.Degrees(+18.17702942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1373"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.29797289),
        dec: Angle.Degrees(+18.17840415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6681"},
        {"Hipparcos Number", "HIP 5293"},
        {"Smithsonian Astrophysical Observation", "SAO 92259"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.93420380),
        dec: Angle.Degrees(+18.17853923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70770",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70770"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.11096485),
        dec: Angle.Degrees(+18.17871788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37622",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37622"},
        {"Geneva Identification System", "GEN# +0.01801719"},
    },
    visualMagnitude: 11.32,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.79902286),
        dec: Angle.Degrees(+18.17956161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -473.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74720"},
        {"Hipparcos Number", "HIP 43044"},
        {"Geneva Identification System", "GEN# +1.00074720"},
        {"Smithsonian Astrophysical Observation", "SAO 98107"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.54896514),
        dec: Angle.Degrees(+18.17974958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19186"},
        {"Hipparcos Number", "HIP 14403"},
        {"Smithsonian Astrophysical Observation", "SAO 93270"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.44739639),
        dec: Angle.Degrees(+18.17979315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173880"},
        {"Hipparcos Number", "HIP 92161"},
        {"Fundamental Katalog 5th Edition", "FK5 1491"},
        {"Geneva Identification System", "GEN# +1.00173880"},
        {"Renson", "Renson 48730"},
        {"Smithsonian Astrophysical Observation", "SAO 104093"},
        {"Wilson Evans Batten Catalogue", "WEB 15889"},
    },
    visualMagnitude: 4.34,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.75509317),
        dec: Angle.Degrees(+18.18122968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 83.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 119.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60676"},
        {"Hipparcos Number", "HIP 37009"},
        {"Smithsonian Astrophysical Observation", "SAO 97072"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.10261598),
        dec: Angle.Degrees(+18.18190356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41041"},
        {"Hipparcos Number", "HIP 28692"},
        {"Smithsonian Astrophysical Observation", "SAO 95168"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.86841322),
        dec: Angle.Degrees(+18.18327576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109045"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.35074125),
        dec: Angle.Degrees(+18.18367716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81085"},
        {"Hipparcos Number", "HIP 46100"},
        {"Smithsonian Astrophysical Observation", "SAO 98546"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.02214092),
        dec: Angle.Degrees(+18.18523093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195993"},
        {"Hipparcos Number", "HIP 101490"},
        {"Smithsonian Astrophysical Observation", "SAO 106253"},
        {"Wilson Evans Batten Catalogue", "WEB 18338"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.50536294),
        dec: Angle.Degrees(+18.18550131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163285"},
        {"Hipparcos Number", "HIP 87692"},
        {"Smithsonian Astrophysical Observation", "SAO 103203"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.66896292),
        dec: Angle.Degrees(+18.18568485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229631"},
        {"Hipparcos Number", "HIP 92374"},
        {"Smithsonian Astrophysical Observation", "SAO 104148"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.37548674),
        dec: Angle.Degrees(+18.18706571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88133"},
        {"Hipparcos Number", "HIP 49813"},
        {"Cincinnati Publication", "Ci 18 1215"},
        {"Geneva Identification System", "GEN# +1.00088133"},
        {"Smithsonian Astrophysical Observation", "SAO 98978"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.53201372),
        dec: Angle.Degrees(+18.18751247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -263.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55486",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8140 A"},
        {"Henry Draper", "HD 98736"},
        {"Hipparcos Number", "HIP 55486"},
        {"Geneva Identification System", "GEN# +1.00098736"},
        {"Smithsonian Astrophysical Observation", "SAO 99573"},
        {"Wilson Evans Batten Catalogue", "WEB 9980"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.45598085),
        dec: Angle.Degrees(+18.19023277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63299"},
        {"Hipparcos Number", "HIP 38135"},
        {"Smithsonian Astrophysical Observation", "SAO 97268"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.22377195),
        dec: Angle.Degrees(+18.19035011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81559"},
        {"Smithsonian Astrophysical Observation", "SAO 102297"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.85439491),
        dec: Angle.Degrees(+18.19337099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5447 AB"},
        {"Henry Draper", "HD 49059"},
        {"Hipparcos Number", "HIP 32539"},
        {"Geneva Identification System", "GEN# +1.00049059J"},
        {"Smithsonian Astrophysical Observation", "SAO 96111"},
        {"Wilson Evans Batten Catalogue", "WEB 6562"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.84773812),
        dec: Angle.Degrees(+18.19355653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25202"},
        {"Hipparcos Number", "HIP 18735"},
        {"Fundamental Katalog 5th Edition", "FK5 2288"},
        {"Geneva Identification System", "GEN# +5.20250137"},
        {"Smithsonian Astrophysical Observation", "SAO 93721"},
        {"Wilson Evans Batten Catalogue", "WEB 3607"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.20285787),
        dec: Angle.Degrees(+18.19406866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216774"},
        {"Hipparcos Number", "HIP 113211"},
        {"Geneva Identification System", "GEN# +1.00216774"},
        {"Smithsonian Astrophysical Observation", "SAO 108261"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.89261624),
        dec: Angle.Degrees(+18.19611778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173368"},
        {"Hipparcos Number", "HIP 91913"},
        {"Smithsonian Astrophysical Observation", "SAO 104044"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.05840995),
        dec: Angle.Degrees(+18.19768128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4689",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 827 AB"},
        {"Henry Draper", "HD 5857"},
        {"Hipparcos Number", "HIP 4689"},
        {"Geneva Identification System", "GEN# +1.00005857"},
        {"Smithsonian Astrophysical Observation", "SAO 92194"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.06549267),
        dec: Angle.Degrees(+18.19920433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130652"},
        {"Hipparcos Number", "HIP 72446"},
        {"Smithsonian Astrophysical Observation", "SAO 101226"},
        {"Wilson Evans Batten Catalogue", "WEB 12451"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.21440241),
        dec: Angle.Degrees(+18.19970621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105156"},
        {"Hipparcos Number", "HIP 59049"},
        {"Geneva Identification System", "GEN# +1.00105156"},
        {"Smithsonian Astrophysical Observation", "SAO 99940"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.59343033),
        dec: Angle.Degrees(+18.20078456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187282"},
        {"Hipparcos Number", "HIP 97456"},
        {"Geneva Identification System", "GEN# +1.00187282"},
        {"Wilson Evans Batten Catalogue", "WEB 17128"},
    },
    visualMagnitude: 10.43,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.13415370),
        dec: Angle.Degrees(+18.20104002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48562"},
        {"Smithsonian Astrophysical Observation", "SAO 98837"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.57261818),
        dec: Angle.Degrees(+18.20237197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8739"},
        {"Hipparcos Number", "HIP 6722"},
        {"Geneva Identification System", "GEN# +1.00008739"},
        {"Smithsonian Astrophysical Observation", "SAO 92442"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.62972027),
        dec: Angle.Degrees(+18.20307556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171623"},
        {"Hipparcos Number", "HIP 91118"},
        {"Geneva Identification System", "GEN# +1.00171623"},
        {"Smithsonian Astrophysical Observation", "SAO 103879"},
        {"Wilson Evans Batten Catalogue", "WEB 15640"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.80245637),
        dec: Angle.Degrees(+18.20339202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197150"},
        {"Hipparcos Number", "HIP 102076"},
        {"Smithsonian Astrophysical Observation", "SAO 106383"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.30033700),
        dec: Angle.Degrees(+18.20382661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85172"},
        {"Smithsonian Astrophysical Observation", "SAO 102802"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.08670030),
        dec: Angle.Degrees(+18.20562418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17282"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.50786370),
        dec: Angle.Degrees(+18.20571467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20780",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3226 A"},
        {"Henry Draper", "HD 28150"},
        {"Hipparcos Number", "HIP 20780"},
        {"Geneva Identification System", "GEN# +1.00028150"},
        {"Smithsonian Astrophysical Observation", "SAO 93942"},
        {"Wilson Evans Batten Catalogue", "WEB 3986"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.77024275),
        dec: Angle.Degrees(+18.20758048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3226 B"},
        {"Hipparcos Number", "HIP 20782"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.77489846),
        dec: Angle.Degrees(+18.21034817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 448"},
        {"Hipparcos Number", "HIP 729"},
        {"Geneva Identification System", "GEN# +1.00000448"},
        {"Smithsonian Astrophysical Observation", "SAO 91734"},
        {"Wilson Evans Batten Catalogue", "WEB 123"},
    },
    visualMagnitude: 5.57,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.25974230),
        dec: Angle.Degrees(+18.21202529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 140.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36755"},
        {"Smithsonian Astrophysical Observation", "SAO 97013"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.39002789),
        dec: Angle.Degrees(+18.21324828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222419"},
        {"Hipparcos Number", "HIP 116798"},
        {"Smithsonian Astrophysical Observation", "SAO 108760"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.06837582),
        dec: Angle.Degrees(+18.21429270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6297",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1094 AB"},
        {"Henry Draper", "HD 8118"},
        {"Hipparcos Number", "HIP 6297"},
        {"Smithsonian Astrophysical Observation", "SAO 92381"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.20259642),
        dec: Angle.Degrees(+18.21464265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140320"},
        {"Hipparcos Number", "HIP 76926"},
        {"Geneva Identification System", "GEN# +1.00140320"},
        {"Smithsonian Astrophysical Observation", "SAO 101692"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.61215373),
        dec: Angle.Degrees(+18.21598872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285844"},
        {"Hipparcos Number", "HIP 21173"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.08993184),
        dec: Angle.Degrees(+18.21620105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146264"},
        {"Hipparcos Number", "HIP 79618"},
        {"Smithsonian Astrophysical Observation", "SAO 102033"},
        {"Wilson Evans Batten Catalogue", "WEB 13474"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.69985651),
        dec: Angle.Degrees(+18.21661764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116499"},
        {"Hipparcos Number", "HIP 65365"},
        {"Geneva Identification System", "GEN# +1.00116499"},
        {"Smithsonian Astrophysical Observation", "SAO 100550"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.94406753),
        dec: Angle.Degrees(+18.21702719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103923"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.84093981),
        dec: Angle.Degrees(+18.21817401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92696"},
        {"Hipparcos Number", "HIP 52392"},
        {"Smithsonian Astrophysical Observation", "SAO 99258"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.63217053),
        dec: Angle.Degrees(+18.21996883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87195"},
        {"Hipparcos Number", "HIP 49297"},
        {"Geneva Identification System", "GEN# +1.00087195"},
        {"Smithsonian Astrophysical Observation", "SAO 98927"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.93532329),
        dec: Angle.Degrees(+18.22009794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159644"},
        {"Hipparcos Number", "HIP 86039"},
        {"Geneva Identification System", "GEN# +1.00159644"},
        {"Smithsonian Astrophysical Observation", "SAO 102937"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.75771409),
        dec: Angle.Degrees(+18.22291525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117336"},
        {"Geneva Identification System", "GEN# +9.80030013"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.87759582),
        dec: Angle.Degrees(+18.22346620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 269.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45353"},
        {"Hipparcos Number", "HIP 30749"},
        {"Geneva Identification System", "GEN# +1.00045353"},
        {"Smithsonian Astrophysical Observation", "SAO 95703"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91931514),
        dec: Angle.Degrees(+18.22381529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116159"},
        {"Hipparcos Number", "HIP 65190"},
        {"Geneva Identification System", "GEN# +1.00116159"},
        {"Smithsonian Astrophysical Observation", "SAO 100529"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.39647101),
        dec: Angle.Degrees(+18.22484933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22045"},
        {"Hipparcos Number", "HIP 16613"},
        {"Smithsonian Astrophysical Observation", "SAO 93491"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.45190171),
        dec: Angle.Degrees(+18.22779338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285846"},
        {"Hipparcos Number", "HIP 20990"},
        {"Wilson Evans Batten Catalogue", "WEB 4040"},
    },
    visualMagnitude: 11.03,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.51660572),
        dec: Angle.Degrees(+18.23045225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71144"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.24933439),
        dec: Angle.Degrees(+18.23102546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46357",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46357"},
        {"Smithsonian Astrophysical Observation", "SAO 98576"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.77518015),
        dec: Angle.Degrees(+18.23169300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286130"},
        {"Hipparcos Number", "HIP 22799"},
    },
    visualMagnitude: 11.01,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.56774013),
        dec: Angle.Degrees(+18.23215428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153146"},
        {"Hipparcos Number", "HIP 82947"},
        {"Smithsonian Astrophysical Observation", "SAO 102491"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.25722093),
        dec: Angle.Degrees(+18.23379501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101"},
        {"Hipparcos Number", "HIP 493"},
        {"Geneva Identification System", "GEN# +1.00000101"},
        {"Smithsonian Astrophysical Observation", "SAO 91706"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.47850515),
        dec: Angle.Degrees(+18.23536692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -149.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72845",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Arcalis"},
        {"Henry Draper", "HD 131496"},
        {"Hipparcos Number", "HIP 72845"},
        {"Smithsonian Astrophysical Observation", "SAO 101274"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.34583911),
        dec: Angle.Degrees(+18.23548983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102688"},
        {"Hipparcos Number", "HIP 57655"},
        {"Geneva Identification System", "GEN# +1.00102688"},
        {"Smithsonian Astrophysical Observation", "SAO 99813"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.36286904),
        dec: Angle.Degrees(+18.23553425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138935"},
        {"Hipparcos Number", "HIP 76261"},
        {"Smithsonian Astrophysical Observation", "SAO 101622"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.65705718),
        dec: Angle.Degrees(+18.24153736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101753"},
        {"Hipparcos Number", "HIP 57126"},
        {"Geneva Identification System", "GEN# +1.00101753"},
        {"Renson", "Renson 29335"},
        {"Smithsonian Astrophysical Observation", "SAO 99749"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.68340601),
        dec: Angle.Degrees(+18.24204779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38753"},
        {"Hipparcos Number", "HIP 27450"},
        {"Geneva Identification System", "GEN# +1.00038753"},
        {"Smithsonian Astrophysical Observation", "SAO 94874"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.18633850),
        dec: Angle.Degrees(+18.24326956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36320"},
        {"Hipparcos Number", "HIP 25893"},
        {"Smithsonian Astrophysical Observation", "SAO 94617"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.91327118),
        dec: Angle.Degrees(+18.24420389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190751"},
        {"Hipparcos Number", "HIP 98996"},
        {"Smithsonian Astrophysical Observation", "SAO 105679"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.47920077),
        dec: Angle.Degrees(+18.24452464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12642",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12642"},
    },
    visualMagnitude: 11.98,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.60596880),
        dec: Angle.Degrees(+18.24479241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65736"},
        {"Hipparcos Number", "HIP 39169"},
        {"Geneva Identification System", "GEN# +1.00065736"},
        {"Smithsonian Astrophysical Observation", "SAO 97468"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.17186033),
        dec: Angle.Degrees(+18.24558602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171216"},
        {"Hipparcos Number", "HIP 90917"},
        {"Smithsonian Astrophysical Observation", "SAO 103832"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.19588514),
        dec: Angle.Degrees(+18.24633723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120335"},
        {"Hipparcos Number", "HIP 67362"},
        {"Geneva Identification System", "GEN# +1.00120335"},
        {"Smithsonian Astrophysical Observation", "SAO 100716"},
        {"Wilson Evans Batten Catalogue", "WEB 11850"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.10188109),
        dec: Angle.Degrees(+18.24894709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224396"},
        {"Hipparcos Number", "HIP 118111"},
        {"Smithsonian Astrophysical Observation", "SAO 108929"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.38192145),
        dec: Angle.Degrees(+18.24999512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183849"},
        {"Hipparcos Number", "HIP 95957"},
        {"Smithsonian Astrophysical Observation", "SAO 104924"},
        {"Wilson Evans Batten Catalogue", "WEB 16805"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.70702308),
        dec: Angle.Degrees(+18.25067910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46662"},
        {"Geneva Identification System", "GEN# +0.01802213"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.70836281),
        dec: Angle.Degrees(+18.25306701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -287.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12594"},
        {"Hipparcos Number", "HIP 9627"},
        {"Geneva Identification System", "GEN# +1.00012594"},
        {"Smithsonian Astrophysical Observation", "SAO 92774"},
        {"Wilson Evans Batten Catalogue", "WEB 2021"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.92755689),
        dec: Angle.Degrees(+18.25328848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32561"},
        {"Hipparcos Number", "HIP 23632"},
        {"Smithsonian Astrophysical Observation", "SAO 94294"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.20857480),
        dec: Angle.Degrees(+18.25396986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126440"},
        {"Hipparcos Number", "HIP 70491"},
        {"Smithsonian Astrophysical Observation", "SAO 101017"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.27205990),
        dec: Angle.Degrees(+18.25430955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61748"},
        {"Hipparcos Number", "HIP 37472"},
        {"Smithsonian Astrophysical Observation", "SAO 97146"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.37094673),
        dec: Angle.Degrees(+18.25599741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101857"},
        {"Hipparcos Number", "HIP 57166"},
        {"Smithsonian Astrophysical Observation", "SAO 99755"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.86510007),
        dec: Angle.Degrees(+18.25627604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27149"},
        {"Hipparcos Number", "HIP 20056"},
        {"Geneva Identification System", "GEN# +5.20250023"},
        {"Smithsonian Astrophysical Observation", "SAO 93849"},
        {"Wilson Evans Batten Catalogue", "WEB 3827"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.50736633),
        dec: Angle.Degrees(+18.25688078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219499"},
        {"Hipparcos Number", "HIP 114877"},
        {"Geneva Identification System", "GEN# +1.00219499"},
        {"Smithsonian Astrophysical Observation", "SAO 108501"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.03311000),
        dec: Angle.Degrees(+18.25768703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79374"},
        {"Hipparcos Number", "HIP 45327"},
        {"Smithsonian Astrophysical Observation", "SAO 98446"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.56604431),
        dec: Angle.Degrees(+18.25769554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30355"},
        {"Hipparcos Number", "HIP 22265"},
        {"Geneva Identification System", "GEN# +5.20250114"},
        {"Smithsonian Astrophysical Observation", "SAO 94120"},
        {"Wilson Evans Batten Catalogue", "WEB 4285"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.90633846),
        dec: Angle.Degrees(+18.25881521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80499",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80499"},
        {"Smithsonian Astrophysical Observation", "SAO 102163"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.47840478),
        dec: Angle.Degrees(+18.25929305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121829"},
        {"Hipparcos Number", "HIP 68189"},
        {"Geneva Identification System", "GEN# +1.00121829"},
        {"Smithsonian Astrophysical Observation", "SAO 100792"},
        {"Wilson Evans Batten Catalogue", "WEB 11961"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.39681703),
        dec: Angle.Degrees(+18.26067853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231533"},
        {"Hipparcos Number", "HIP 95756"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.14886974),
        dec: Angle.Degrees(+18.26333025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -201.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349141"},
        {"Hipparcos Number", "HIP 91561"},
        {"Smithsonian Astrophysical Observation", "SAO 103977"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08323891),
        dec: Angle.Degrees(+18.26412084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41101"},
        {"Hipparcos Number", "HIP 28708"},
        {"Celescope Catalog", "CEL 1066"},
        {"Smithsonian Astrophysical Observation", "SAO 95174"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.95056814),
        dec: Angle.Degrees(+18.26479470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118839"},
        {"Hipparcos Number", "HIP 66594"},
        {"Geneva Identification System", "GEN# +1.00118839"},
        {"Smithsonian Astrophysical Observation", "SAO 100650"},
        {"Wilson Evans Batten Catalogue", "WEB 11746"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.75963775),
        dec: Angle.Degrees(+18.26537190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108816",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108816"},
        {"Smithsonian Astrophysical Observation", "SAO 107614"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.67151064),
        dec: Angle.Degrees(+18.26571604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27525"},
        {"Hipparcos Number", "HIP 20336"},
        {"Smithsonian Astrophysical Observation", "SAO 93880"},
        {"Wilson Evans Batten Catalogue", "WEB 3883"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.34975516),
        dec: Angle.Degrees(+18.26633441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196610"},
        {"Hipparcos Number", "HIP 101810"},
        {"Geneva Identification System", "GEN# +1.00196610"},
        {"Smithsonian Astrophysical Observation", "SAO 106329"},
        {"Wilson Evans Batten Catalogue", "WEB 18395"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.47794330),
        dec: Angle.Degrees(+18.26843117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44739"},
        {"Smithsonian Astrophysical Observation", "SAO 98369"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.76127978),
        dec: Angle.Degrees(+18.26952079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57703"},
        {"Hipparcos Number", "HIP 35803"},
        {"Geneva Identification System", "GEN# +1.00057703"},
        {"Smithsonian Astrophysical Observation", "SAO 96837"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.76928744),
        dec: Angle.Degrees(+18.27351374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68857",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68857"},
        {"Smithsonian Astrophysical Observation", "SAO 100846"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.49129003),
        dec: Angle.Degrees(+18.27431816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12019"},
        {"Hipparcos Number", "HIP 9193"},
        {"Smithsonian Astrophysical Observation", "SAO 92728"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.58924662),
        dec: Angle.Degrees(+18.27438568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352680"},
        {"Hipparcos Number", "HIP 101689"},
        {"Geneva Identification System", "GEN# +1.00352680"},
        {"Smithsonian Astrophysical Observation", "SAO 106300"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.17472257),
        dec: Angle.Degrees(+18.27612190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116379"},
        {"Hipparcos Number", "HIP 65304"},
        {"Geneva Identification System", "GEN# +1.00116379"},
        {"Smithsonian Astrophysical Observation", "SAO 100542"},
        {"Wilson Evans Batten Catalogue", "WEB 11527"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.76303751),
        dec: Angle.Degrees(+18.27833884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105653"},
        {"Geneva Identification System", "GEN# +0.01704572"},
        {"Smithsonian Astrophysical Observation", "SAO 107100"},
        {"Wilson Evans Batten Catalogue", "WEB 19176"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.00101495),
        dec: Angle.Degrees(+18.27885898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77661"},
        {"Hipparcos Number", "HIP 44529"},
        {"Smithsonian Astrophysical Observation", "SAO 98335"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.09235745),
        dec: Angle.Degrees(+18.27901892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210890"},
        {"Hipparcos Number", "HIP 109691"},
        {"Geneva Identification System", "GEN# +1.00210890"},
        {"Smithsonian Astrophysical Observation", "SAO 107740"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.29172389),
        dec: Angle.Degrees(+18.27990063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17459"},
        {"Hipparcos Number", "HIP 13108"},
        {"Geneva Identification System", "GEN# +1.00017459"},
        {"Smithsonian Astrophysical Observation", "SAO 93118"},
        {"Wilson Evans Batten Catalogue", "WEB 2642"},
    },
    visualMagnitude: 5.83,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.13359632),
        dec: Angle.Degrees(+18.28387012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265574"},
        {"Hipparcos Number", "HIP 33067"},
        {"Smithsonian Astrophysical Observation", "SAO 96234"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.30718726),
        dec: Angle.Degrees(+18.28391946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23586"},
        {"Hipparcos Number", "HIP 17657"},
        {"Geneva Identification System", "GEN# +1.00023586"},
        {"Smithsonian Astrophysical Observation", "SAO 93592"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.73155153),
        dec: Angle.Degrees(+18.28399831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352682"},
        {"Hipparcos Number", "HIP 101780"},
        {"Wilson Evans Batten Catalogue", "WEB 18391"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.41703282),
        dec: Angle.Degrees(+18.28437539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82604"},
        {"Hipparcos Number", "HIP 46900"},
        {"Smithsonian Astrophysical Observation", "SAO 98638"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.36197115),
        dec: Angle.Degrees(+18.28580083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62230",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62230"},
        {"Smithsonian Astrophysical Observation", "SAO 100234"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.31195591),
        dec: Angle.Degrees(+18.28674398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166580"},
        {"Hipparcos Number", "HIP 89056"},
        {"Smithsonian Astrophysical Observation", "SAO 103453"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65236817),
        dec: Angle.Degrees(+18.28868539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68075",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68075"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.07421003),
        dec: Angle.Degrees(+18.28966370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117138"},
        {"Hipparcos Number", "HIP 65692"},
        {"Geneva Identification System", "GEN# +1.00117138"},
        {"Smithsonian Astrophysical Observation", "SAO 100576"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.02523252),
        dec: Angle.Degrees(+18.28977337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11326"},
        {"Hipparcos Number", "HIP 8689"},
        {"Geneva Identification System", "GEN# +1.00011326"},
        {"Smithsonian Astrophysical Observation", "SAO 92666"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.94666692),
        dec: Angle.Degrees(+18.29028452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81412"},
        {"Smithsonian Astrophysical Observation", "SAO 102276"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.40830201),
        dec: Angle.Degrees(+18.29087624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 265304"},
        {"Hipparcos Number", "HIP 32983"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.06806869),
        dec: Angle.Degrees(+18.29209705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348635"},
        {"Hipparcos Number", "HIP 90312"},
        {"Geneva Identification System", "GEN# +1.00348635"},
        {"Wilson Evans Batten Catalogue", "WEB 15457"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.41130282),
        dec: Angle.Degrees(+18.29447158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190151"},
        {"Hipparcos Number", "HIP 98718"},
        {"Geneva Identification System", "GEN# +1.00190151"},
        {"Smithsonian Astrophysical Observation", "SAO 105603"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.76064400),
        dec: Angle.Degrees(+18.29552862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183143"},
        {"Hipparcos Number", "HIP 95657"},
        {"Geneva Identification System", "GEN# +1.00183143"},
        {"Smithsonian Astrophysical Observation", "SAO 104860"},
        {"Wilson Evans Batten Catalogue", "WEB 16730"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.86068417),
        dec: Angle.Degrees(+18.29590039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199557"},
        {"Hipparcos Number", "HIP 103444"},
        {"Smithsonian Astrophysical Observation", "SAO 106703"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.36418446),
        dec: Angle.Degrees(+18.29679779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43185"},
        {"Hipparcos Number", "HIP 29731"},
        {"Geneva Identification System", "GEN# +1.00043185"},
        {"Smithsonian Astrophysical Observation", "SAO 95456"},
        {"Wilson Evans Batten Catalogue", "WEB 5864"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.92233379),
        dec: Angle.Degrees(+18.29750308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128750"},
        {"Hipparcos Number", "HIP 71571"},
        {"Fundamental Katalog 5th Edition", "FK5 3160"},
        {"Geneva Identification System", "GEN# +1.00128750"},
        {"Smithsonian Astrophysical Observation", "SAO 101121"},
        {"Wilson Evans Batten Catalogue", "WEB 12341"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.55835502),
        dec: Angle.Degrees(+18.29853624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154275"},
        {"Hipparcos Number", "HIP 83485"},
        {"Smithsonian Astrophysical Observation", "SAO 102566"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.94034290),
        dec: Angle.Degrees(+18.29908173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116067"},
        {"Smithsonian Astrophysical Observation", "SAO 108655"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.77386697),
        dec: Angle.Degrees(+18.29916392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54183"},
        {"Hipparcos Number", "HIP 34464"},
        {"Smithsonian Astrophysical Observation", "SAO 96538"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.15503135),
        dec: Angle.Degrees(+18.30135646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231440"},
        {"Hipparcos Number", "HIP 95617"},
        {"Smithsonian Astrophysical Observation", "SAO 104845"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.72778549),
        dec: Angle.Degrees(+18.30239262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209379"},
        {"Hipparcos Number", "HIP 108815"},
        {"Smithsonian Astrophysical Observation", "SAO 107613"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.66773437),
        dec: Angle.Degrees(+18.30379060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59234"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.23157045),
        dec: Angle.Degrees(+18.30404143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20065"},
        {"Hipparcos Number", "HIP 15062"},
        {"Geneva Identification System", "GEN# +1.00020065"},
        {"Smithsonian Astrophysical Observation", "SAO 93347"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.51999411),
        dec: Angle.Degrees(+18.30436667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -227.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115011",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16650 AB"},
        {"Henry Draper", "HD 219675"},
        {"Hipparcos Number", "HIP 115011"},
        {"Renson", "Renson 60310"},
        {"Smithsonian Astrophysical Observation", "SAO 108515"},
        {"Wilson Evans Batten Catalogue", "WEB 20374"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.40551032),
        dec: Angle.Degrees(+18.30485888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205484"},
        {"Hipparcos Number", "HIP 106579"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.79065270),
        dec: Angle.Degrees(+18.30606023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76706"},
        {"Hipparcos Number", "HIP 44056"},
        {"Fundamental Katalog 5th Edition", "FK5 2711"},
        {"Geneva Identification System", "GEN# +1.00076706"},
        {"Smithsonian Astrophysical Observation", "SAO 98265"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.57627527),
        dec: Angle.Degrees(+18.30832589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28815",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4654 AB"},
        {"Henry Draper", "HD 41284"},
        {"Hipparcos Number", "HIP 28815"},
        {"Smithsonian Astrophysical Observation", "SAO 95202"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.24581923),
        dec: Angle.Degrees(+18.31105391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92884"},
        {"Hipparcos Number", "HIP 52484"},
        {"Smithsonian Astrophysical Observation", "SAO 99266"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.95450815),
        dec: Angle.Degrees(+18.31309309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4670"},
        {"Hipparcos Number", "HIP 3798"},
        {"Fundamental Katalog 5th Edition", "FK5 4069"},
        {"Smithsonian Astrophysical Observation", "SAO 92097"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.20006473),
        dec: Angle.Degrees(+18.31409668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6316"},
        {"Smithsonian Astrophysical Observation", "SAO 92386"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.28067980),
        dec: Angle.Degrees(+18.31499955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109179"},
        {"Smithsonian Astrophysical Observation", "SAO 107670"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.75514720),
        dec: Angle.Degrees(+18.31699232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88354"},
        {"Hipparcos Number", "HIP 49928"},
        {"Geneva Identification System", "GEN# +1.00088354"},
        {"Smithsonian Astrophysical Observation", "SAO 98989"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.90499854),
        dec: Angle.Degrees(+18.31741978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151766"},
        {"Hipparcos Number", "HIP 82276"},
        {"Geneva Identification System", "GEN# +1.00151766"},
        {"Smithsonian Astrophysical Observation", "SAO 102402"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.17803063),
        dec: Angle.Degrees(+18.31887132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69717"},
        {"Hipparcos Number", "HIP 40733"},
        {"Smithsonian Astrophysical Observation", "SAO 97723"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.71617050),
        dec: Angle.Degrees(+18.31965631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59238"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.25847472),
        dec: Angle.Degrees(+18.32160820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49058"},
        {"Hipparcos Number", "HIP 32532"},
        {"Smithsonian Astrophysical Observation", "SAO 96110"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.83030167),
        dec: Angle.Degrees(+18.32283341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166801"},
        {"Hipparcos Number", "HIP 89141"},
        {"Smithsonian Astrophysical Observation", "SAO 103465"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.89045358),
        dec: Angle.Degrees(+18.32406747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143292"},
        {"Hipparcos Number", "HIP 78283"},
        {"Geneva Identification System", "GEN# +1.00143292"},
        {"Smithsonian Astrophysical Observation", "SAO 101852"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.75774281),
        dec: Angle.Degrees(+18.32587066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3280"},
        {"Geneva Identification System", "GEN# +9.80032041"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.45323010),
        dec: Angle.Degrees(+18.32655867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123860"},
        {"Hipparcos Number", "HIP 69186"},
        {"Smithsonian Astrophysical Observation", "SAO 100884"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.43811460),
        dec: Angle.Degrees(+18.32700869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10905 AB"},
        {"Henry Draper", "HD 163640"},
        {"Hipparcos Number", "HIP 87823"},
        {"Geneva Identification System", "GEN# +1.00163640J"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.10172065),
        dec: Angle.Degrees(+18.32702523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12559"},
        {"Hipparcos Number", "HIP 9602"},
        {"Smithsonian Astrophysical Observation", "SAO 92772"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.87225807),
        dec: Angle.Degrees(+18.32761785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100084",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13662 AB"},
        {"Henry Draper", "HD 193161"},
        {"Hipparcos Number", "HIP 100084"},
        {"Geneva Identification System", "GEN# +1.00193161J"},
        {"Renson", "Renson 53910"},
        {"Smithsonian Astrophysical Observation", "SAO 105940"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.56001827),
        dec: Angle.Degrees(+18.32819041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205422"},
        {"Hipparcos Number", "HIP 106550"},
        {"Smithsonian Astrophysical Observation", "SAO 107250"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.69120431),
        dec: Angle.Degrees(+18.32890166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14132",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2301 AB"},
        {"Hipparcos Number", "HIP 14132"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.56461752),
        dec: Angle.Degrees(+18.32933368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108547"},
        {"Hipparcos Number", "HIP 60833"},
        {"Geneva Identification System", "GEN# +1.00108547"},
        {"Smithsonian Astrophysical Observation", "SAO 100110"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.02161587),
        dec: Angle.Degrees(+18.33065128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18191"},
        {"Hipparcos Number", "HIP 13654"},
        {"Geneva Identification System", "GEN# +1.00018191"},
        {"Smithsonian Astrophysical Observation", "SAO 93189"},
        {"Wilson Evans Batten Catalogue", "WEB 2710"},
    },
    visualMagnitude: 5.76,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.95209490),
        dec: Angle.Degrees(+18.33167607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85702"},
        {"Smithsonian Astrophysical Observation", "SAO 102875"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.70544994),
        dec: Angle.Degrees(+18.33207059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 71.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53873"},
        {"Hipparcos Number", "HIP 34372"},
        {"Smithsonian Astrophysical Observation", "SAO 96508"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.87420343),
        dec: Angle.Degrees(+18.33226145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70569"},
        {"Hipparcos Number", "HIP 41117"},
        {"Fundamental Katalog 5th Edition", "FK5 1220"},
        {"Geneva Identification System", "GEN# +1.00070569"},
        {"Smithsonian Astrophysical Observation", "SAO 97781"},
        {"Wilson Evans Batten Catalogue", "WEB 7963"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.84113148),
        dec: Angle.Degrees(+18.33228008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104290"},
        {"Hipparcos Number", "HIP 58568"},
        {"Geneva Identification System", "GEN# +1.00104290"},
        {"Smithsonian Astrophysical Observation", "SAO 99904"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.15839722),
        dec: Angle.Degrees(+18.33471894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63210"},
        {"Hipparcos Number", "HIP 38092"},
        {"Smithsonian Astrophysical Observation", "SAO 97260"},
        {"Wilson Evans Batten Catalogue", "WEB 7508"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.09415874),
        dec: Angle.Degrees(+18.33683542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67157"},
        {"Smithsonian Astrophysical Observation", "SAO 100698"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.43999367),
        dec: Angle.Degrees(+18.33744107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189530"},
        {"Hipparcos Number", "HIP 98423"},
        {"Smithsonian Astrophysical Observation", "SAO 105516"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.97137717),
        dec: Angle.Degrees(+18.34001743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194036"},
        {"Hipparcos Number", "HIP 100514"},
        {"Smithsonian Astrophysical Observation", "SAO 106045"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.72610832),
        dec: Angle.Degrees(+18.34012270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130342"},
        {"Hipparcos Number", "HIP 72303"},
        {"Geneva Identification System", "GEN# +1.00130342"},
        {"Smithsonian Astrophysical Observation", "SAO 101211"},
        {"Wilson Evans Batten Catalogue", "WEB 12433"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.77975333),
        dec: Angle.Degrees(+18.34056514)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188949"},
        {"Hipparcos Number", "HIP 98181"},
        {"Smithsonian Astrophysical Observation", "SAO 105457"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.28278562),
        dec: Angle.Degrees(+18.34198585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111526"},
        {"Hipparcos Number", "HIP 62612"},
        {"Geneva Identification System", "GEN# +1.00111526"},
        {"Smithsonian Astrophysical Observation", "SAO 100289"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.44712924),
        dec: Angle.Degrees(+18.34287340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19617"},
        {"Hipparcos Number", "HIP 14721"},
        {"Geneva Identification System", "GEN# +1.00019617"},
        {"Smithsonian Astrophysical Observation", "SAO 93314"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.54085358),
        dec: Angle.Degrees(+18.34570873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129080"},
        {"Hipparcos Number", "HIP 71716"},
        {"Smithsonian Astrophysical Observation", "SAO 101134"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.04370813),
        dec: Angle.Degrees(+18.34917954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91988"},
        {"Hipparcos Number", "HIP 52015"},
        {"Geneva Identification System", "GEN# +1.00091988"},
        {"Smithsonian Astrophysical Observation", "SAO 99216"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.40324906),
        dec: Angle.Degrees(+18.34985293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -135.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162571"},
        {"Hipparcos Number", "HIP 87355"},
        {"Smithsonian Astrophysical Observation", "SAO 103149"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.74523244),
        dec: Angle.Degrees(+18.35011459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155712"},
        {"Hipparcos Number", "HIP 84195"},
        {"Smithsonian Astrophysical Observation", "SAO 102651"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.941,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.15649995),
        dec: Angle.Degrees(+18.35147880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215215"},
        {"Hipparcos Number", "HIP 112194"},
        {"Smithsonian Astrophysical Observation", "SAO 108130"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.85083671),
        dec: Angle.Degrees(+18.35244232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48843",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48843"},
        {"Smithsonian Astrophysical Observation", "SAO 98866"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.44016376),
        dec: Angle.Degrees(+18.35308628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192937"},
        {"Hipparcos Number", "HIP 99978"},
        {"Smithsonian Astrophysical Observation", "SAO 105923"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.24068184),
        dec: Angle.Degrees(+18.35376446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9100"},
        {"Hipparcos Number", "HIP 6981"},
        {"Geneva Identification System", "GEN# +1.00009100"},
        {"Smithsonian Astrophysical Observation", "SAO 92463"},
        {"Wilson Evans Batten Catalogue", "WEB 1512"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.47011303),
        dec: Angle.Degrees(+18.35567537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12082"},
        {"Hipparcos Number", "HIP 9248"},
        {"Geneva Identification System", "GEN# +1.00012082"},
        {"Smithsonian Astrophysical Observation", "SAO 92735"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.72686472),
        dec: Angle.Degrees(+18.35814840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117619"},
        {"Smithsonian Astrophysical Observation", "SAO 108869"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.81052910),
        dec: Angle.Degrees(+18.35909478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 195.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35275",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35275"},
        {"Smithsonian Astrophysical Observation", "SAO 96723"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.32154543),
        dec: Angle.Degrees(+18.36159884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16811"},
        {"Smithsonian Astrophysical Observation", "SAO 93508"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.09678528),
        dec: Angle.Degrees(+18.36198786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25702",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4073 AB"},
        {"Henry Draper", "HD 35985"},
        {"Hipparcos Number", "HIP 25702"},
        {"Celescope Catalog", "CEL 729"},
        {"Geneva Identification System", "GEN# +1.00035985J"},
        {"Smithsonian Astrophysical Observation", "SAO 94586"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.32979469),
        dec: Angle.Degrees(+18.36571192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36660",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6156 AB"},
        {"Henry Draper", "HD 59800"},
        {"Hipparcos Number", "HIP 36660"},
        {"Smithsonian Astrophysical Observation", "SAO 96995"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.11246073),
        dec: Angle.Degrees(+18.36632931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80853"},
        {"Geneva Identification System", "GEN# +0.01803186"},
        {"Wilson Evans Batten Catalogue", "WEB 13675"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67014163),
        dec: Angle.Degrees(+18.36677644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187323"},
        {"Hipparcos Number", "HIP 97479"},
        {"Smithsonian Astrophysical Observation", "SAO 105291"},
        {"Wilson Evans Batten Catalogue", "WEB 17137"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.19120326),
        dec: Angle.Degrees(+18.36881753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52829"},
        {"Hipparcos Number", "HIP 34012"},
        {"Smithsonian Astrophysical Observation", "SAO 96427"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87076967),
        dec: Angle.Degrees(+18.36997934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60326",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60326"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.53840518),
        dec: Angle.Degrees(+18.37096819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97105"},
        {"Hipparcos Number", "HIP 54629"},
        {"Smithsonian Astrophysical Observation", "SAO 99486"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.72774824),
        dec: Angle.Degrees(+18.37226963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63497",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8735 A"},
        {"Henry Draper", "HD 113022"},
        {"Hipparcos Number", "HIP 63497"},
        {"Geneva Identification System", "GEN# +1.00113022A"},
        {"Smithsonian Astrophysical Observation", "SAO 100366"},
        {"Wilson Evans Batten Catalogue", "WEB 11237"},
    },
    visualMagnitude: 6.20,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.16190005),
        dec: Angle.Degrees(+18.37286539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -234.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15718"},
        {"Hipparcos Number", "HIP 11781"},
        {"Smithsonian Astrophysical Observation", "SAO 92990"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.01208659),
        dec: Angle.Degrees(+18.37367173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116516"},
        {"Hipparcos Number", "HIP 65370"},
        {"Geneva Identification System", "GEN# +1.00116516"},
        {"Smithsonian Astrophysical Observation", "SAO 100551"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.96313844),
        dec: Angle.Degrees(+18.37565894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8600 A"},
        {"Henry Draper", "HD 109511"},
        {"Hipparcos Number", "HIP 61418"},
        {"Fundamental Katalog 5th Edition", "FK5 473"},
        {"Geneva Identification System", "GEN# +1.00109511"},
        {"Smithsonian Astrophysical Observation", "SAO 100160"},
        {"Wilson Evans Batten Catalogue", "WEB 10932"},
    },
    visualMagnitude: 5.03,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.78234382),
        dec: Angle.Degrees(+18.37700118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8600 B"},
        {"Henry Draper", "HD 109510"},
        {"Hipparcos Number", "HIP 61415"},
        {"Geneva Identification System", "GEN# +1.00109510"},
        {"Renson", "Renson 31760"},
        {"Smithsonian Astrophysical Observation", "SAO 100159"},
        {"Wilson Evans Batten Catalogue", "WEB 10931"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.77644434),
        dec: Angle.Degrees(+18.37703366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58309",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8362 AB"},
        {"Hipparcos Number", "HIP 58309"},
        {"Smithsonian Astrophysical Observation", "SAO 99884"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.36039496),
        dec: Angle.Degrees(+18.37726175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64386",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64386"},
        {"Geneva Identification System", "GEN# +9.80063007"},
        {"Geneva Identification System 2", "GEN# +0.01902646"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.95092336),
        dec: Angle.Degrees(+18.37979547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285540"},
        {"Hipparcos Number", "HIP 19549"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.80451594),
        dec: Angle.Degrees(+18.38022219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168363"},
        {"Hipparcos Number", "HIP 89711"},
        {"Geneva Identification System", "GEN# +1.00168363"},
        {"Smithsonian Astrophysical Observation", "SAO 103587"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.63443278),
        dec: Angle.Degrees(+18.38101398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92748"},
        {"Hipparcos Number", "HIP 52415"},
        {"Geneva Identification System", "GEN# +1.00092748"},
        {"Smithsonian Astrophysical Observation", "SAO 99262"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.71940367),
        dec: Angle.Degrees(+18.38216489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112496"},
        {"Cincinnati Publication", "Ci 18 2974"},
        {"Geneva Identification System", "GEN# +0.01704808"},
        {"Smithsonian Astrophysical Observation", "SAO 108174"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.80606144),
        dec: Angle.Degrees(+18.38428573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 252.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111418"},
        {"Smithsonian Astrophysical Observation", "SAO 108008"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.60225630),
        dec: Angle.Degrees(+18.38486516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22694"},
        {"Hipparcos Number", "HIP 17076"},
        {"Geneva Identification System", "GEN# +1.00022694"},
        {"Smithsonian Astrophysical Observation", "SAO 93538"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.88950964),
        dec: Angle.Degrees(+18.38538271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -193.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159153"},
        {"Hipparcos Number", "HIP 85832"},
        {"Smithsonian Astrophysical Observation", "SAO 102898"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.07648457),
        dec: Angle.Degrees(+18.38635658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65824"},
        {"Hipparcos Number", "HIP 39215"},
        {"Geneva Identification System", "GEN# +1.00065824"},
        {"Smithsonian Astrophysical Observation", "SAO 97480"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.31646780),
        dec: Angle.Degrees(+18.38969503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217184"},
        {"Hipparcos Number", "HIP 113457"},
        {"Geneva Identification System", "GEN# +1.00217184"},
        {"Smithsonian Astrophysical Observation", "SAO 108303"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.65664468),
        dec: Angle.Degrees(+18.39181061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7046"},
        {"Hipparcos Number", "HIP 5537"},
        {"Smithsonian Astrophysical Observation", "SAO 92299"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.74565792),
        dec: Angle.Degrees(+18.39215453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5154"},
        {"Hipparcos Number", "HIP 4190"},
        {"Geneva Identification System", "GEN# +1.00005154"},
        {"Smithsonian Astrophysical Observation", "SAO 92138"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.37870687),
        dec: Angle.Degrees(+18.39385948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2953"},
        {"Hipparcos Number", "HIP 2597"},
        {"Geneva Identification System", "GEN# +1.00002953"},
        {"Smithsonian Astrophysical Observation", "SAO 91958"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.24723006),
        dec: Angle.Degrees(+18.39523211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72604"},
        {"Hipparcos Number", "HIP 42058"},
        {"Smithsonian Astrophysical Observation", "SAO 97918"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.59719634),
        dec: Angle.Degrees(+18.39765466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67927",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Muphrid"},
        {"Henry Draper", "HD 121370"},
        {"Hipparcos Number", "HIP 67927"},
        {"Fundamental Katalog 5th Edition", "FK5 513"},
        {"Geneva Identification System", "GEN# +1.00121370"},
        {"Smithsonian Astrophysical Observation", "SAO 100766"},
        {"Wilson Evans Batten Catalogue", "WEB 11935"},
    },
    visualMagnitude: 2.68,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67131750),
        dec: Angle.Degrees(+18.39858742)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208156"},
        {"Hipparcos Number", "HIP 108098"},
        {"Smithsonian Astrophysical Observation", "SAO 107481"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.52077630),
        dec: Angle.Degrees(+18.39934364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222133"},
        {"Hipparcos Number", "HIP 116611"},
        {"Fundamental Katalog 5th Edition", "FK5 3896"},
        {"Geneva Identification System", "GEN# +1.00222133"},
        {"Smithsonian Astrophysical Observation", "SAO 108732"},
        {"Wilson Evans Batten Catalogue", "WEB 20586"},
    },
    visualMagnitude: 5.49,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.48655342),
        dec: Angle.Degrees(+18.40062425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41788"},
        {"Hipparcos Number", "HIP 29073"},
        {"Geneva Identification System", "GEN# +1.00041788"},
        {"Smithsonian Astrophysical Observation", "SAO 95263"},
        {"Wilson Evans Batten Catalogue", "WEB 5696"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.99201284),
        dec: Angle.Degrees(+18.40126249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47104"},
        {"Hipparcos Number", "HIP 31686"},
        {"Smithsonian Astrophysical Observation", "SAO 95913"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.44094307),
        dec: Angle.Degrees(+18.40157683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229678"},
        {"Hipparcos Number", "HIP 92435"},
        {"Smithsonian Astrophysical Observation", "SAO 104166"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.56537028),
        dec: Angle.Degrees(+18.40346082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61215"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.16162232),
        dec: Angle.Degrees(+18.40702502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70539"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.45364277),
        dec: Angle.Degrees(+18.40881386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100006"},
        {"Hipparcos Number", "HIP 56146"},
        {"Fundamental Katalog 5th Edition", "FK5 2918"},
        {"Geneva Identification System", "GEN# +1.00100006"},
        {"Smithsonian Astrophysical Observation", "SAO 99637"},
        {"Wilson Evans Batten Catalogue", "WEB 10081"},
    },
    visualMagnitude: 5.54,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.62117030),
        dec: Angle.Degrees(+18.40973855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218602"},
        {"Hipparcos Number", "HIP 114320"},
        {"Geneva Identification System", "GEN# +1.00218602"},
        {"Smithsonian Astrophysical Observation", "SAO 108430"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.28097264),
        dec: Angle.Degrees(+18.41024269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148316"},
        {"Hipparcos Number", "HIP 80536"},
        {"Geneva Identification System", "GEN# +1.00148316"},
        {"Smithsonian Astrophysical Observation", "SAO 102169"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.62619954),
        dec: Angle.Degrees(+18.41027821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205012"},
        {"Hipparcos Number", "HIP 106315"},
        {"Geneva Identification System", "GEN# +1.00205012"},
        {"Smithsonian Astrophysical Observation", "SAO 107208"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.98386467),
        dec: Angle.Degrees(+18.41028566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14687"},
        {"Hipparcos Number", "HIP 11083"},
        {"Cincinnati Publication", "Ci 18 303"},
        {"Geneva Identification System", "GEN# +1.00014687"},
        {"Smithsonian Astrophysical Observation", "SAO 92908"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.67285683),
        dec: Angle.Degrees(+18.41044053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 86.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85347"},
        {"Hipparcos Number", "HIP 48366"},
        {"Geneva Identification System", "GEN# +1.00085347"},
        {"Smithsonian Astrophysical Observation", "SAO 98811"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.90434996),
        dec: Angle.Degrees(+18.41128155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80725",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10075 AB"},
        {"Aitken 2", "ADS 10075"},
        {"Henry Draper", "HD 148653"},
        {"Hipparcos Number", "HIP 80725"},
        {"Cincinnati Publication", "Ci 20 991"},
        {"Geneva Identification System", "GEN# +1.00148653J"},
        {"Smithsonian Astrophysical Observation", "SAO 102200"},
        {"Wilson Evans Batten Catalogue", "WEB 13655"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.22032652),
        dec: Angle.Degrees(+18.41311655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -345.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 385.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29023"},
        {"Hipparcos Number", "HIP 21350"},
        {"Celescope Catalog", "CEL 433"},
        {"Geneva Identification System", "GEN# +1.00029023"},
        {"Smithsonian Astrophysical Observation", "SAO 94017"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.71966364),
        dec: Angle.Degrees(+18.41341334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92621"},
        {"Hipparcos Number", "HIP 52356"},
        {"Smithsonian Astrophysical Observation", "SAO 99254"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.49863304),
        dec: Angle.Degrees(+18.41424732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118066"},
        {"Hipparcos Number", "HIP 66205"},
        {"Geneva Identification System", "GEN# +1.00118066"},
        {"Smithsonian Astrophysical Observation", "SAO 100623"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.55031514),
        dec: Angle.Degrees(+18.41578666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25745",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4087 A"},
        {"Henry Draper", "HD 36073"},
        {"Hipparcos Number", "HIP 25745"},
        {"Smithsonian Astrophysical Observation", "SAO 94589"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.45739496),
        dec: Angle.Degrees(+18.41628884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27534"},
        {"Hipparcos Number", "HIP 20350"},
        {"Geneva Identification System", "GEN# +5.20250036"},
        {"Smithsonian Astrophysical Observation", "SAO 93883"},
        {"Wilson Evans Batten Catalogue", "WEB 3886"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38416813),
        dec: Angle.Degrees(+18.41765943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211646"},
        {"Hipparcos Number", "HIP 110098"},
        {"Geneva Identification System", "GEN# +1.00211646"},
        {"Smithsonian Astrophysical Observation", "SAO 107809"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.54417941),
        dec: Angle.Degrees(+18.42208732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26345"},
        {"Hipparcos Number", "HIP 19504"},
        {"Geneva Identification System", "GEN# +5.20250013"},
        {"Smithsonian Astrophysical Observation", "SAO 93801"},
        {"Wilson Evans Batten Catalogue", "WEB 3735"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.67620064),
        dec: Angle.Degrees(+18.42332910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176439"},
        {"Hipparcos Number", "HIP 93246"},
        {"Smithsonian Astrophysical Observation", "SAO 104323"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.90812631),
        dec: Angle.Degrees(+18.42425492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109555"},
        {"Wilson Evans Batten Catalogue", "WEB 19684"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.87454924),
        dec: Angle.Degrees(+18.42575716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 329.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 178.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254874"},
        {"Hipparcos Number", "HIP 29986"},
        {"Smithsonian Astrophysical Observation", "SAO 95512"},
        {"Wilson Evans Batten Catalogue", "WEB 5955"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.68809745),
        dec: Angle.Degrees(+18.42810520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61059"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.872,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.72512630),
        dec: Angle.Degrees(+18.42818809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4087 CD"},
        {"Henry Draper", "HD 36072"},
        {"Hipparcos Number", "HIP 25747"},
        {"Smithsonian Astrophysical Observation", "SAO 94590"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.46333738),
        dec: Angle.Degrees(+18.43077790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82802",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10262 A"},
        {"Henry Draper", "HD 152879"},
        {"Hipparcos Number", "HIP 82802"},
        {"Geneva Identification System", "GEN# +1.00152879"},
        {"Smithsonian Astrophysical Observation", "SAO 102476"},
        {"Wilson Evans Batten Catalogue", "WEB 13998"},
    },
    visualMagnitude: 5.35,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.84265772),
        dec: Angle.Degrees(+18.43318381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106972"},
        {"Hipparcos Number", "HIP 59980"},
        {"Smithsonian Astrophysical Observation", "SAO 100028"},
        {"Wilson Evans Batten Catalogue", "WEB 10659"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.51729634),
        dec: Angle.Degrees(+18.43505947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145314"},
        {"Hipparcos Number", "HIP 79184"},
        {"Smithsonian Astrophysical Observation", "SAO 101977"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.41810081),
        dec: Angle.Degrees(+18.43803020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136711"},
        {"Hipparcos Number", "HIP 75174"},
        {"Geneva Identification System", "GEN# +1.00136711"},
        {"Smithsonian Astrophysical Observation", "SAO 101504"},
        {"Wilson Evans Batten Catalogue", "WEB 12824"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.43218238),
        dec: Angle.Degrees(+18.43933332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24612",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3854 AB"},
        {"Henry Draper", "HD 34251"},
        {"Hipparcos Number", "HIP 24612"},
        {"Geneva Identification System", "GEN# +1.00034251J"},
        {"Smithsonian Astrophysical Observation", "SAO 94431"},
        {"Wilson Evans Batten Catalogue", "WEB 4763"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.18283129),
        dec: Angle.Degrees(+18.43954308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172134"},
        {"Hipparcos Number", "HIP 91339"},
        {"Smithsonian Astrophysical Observation", "SAO 103929"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.45189622),
        dec: Angle.Degrees(+18.44145844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74000",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9505 AB"},
        {"Henry Draper", "HD 134064"},
        {"Hipparcos Number", "HIP 74000"},
        {"Geneva Identification System", "GEN# +1.00134064J"},
        {"Smithsonian Astrophysical Observation", "SAO 101379"},
        {"Wilson Evans Batten Catalogue", "WEB 12637"},
    },
    visualMagnitude: 6.03,
    bvColour: 0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.83476051),
        dec: Angle.Degrees(+18.44194658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221914"},
        {"Hipparcos Number", "HIP 116478"},
        {"Cincinnati Publication", "Ci 20 1438"},
        {"Cincinnati Publication 2", "Ci 18 3096"},
        {"Geneva Identification System", "GEN# +1.00221914"},
        {"Smithsonian Astrophysical Observation", "SAO 108707"},
        {"Wilson Evans Batten Catalogue", "WEB 20573"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.02324395),
        dec: Angle.Degrees(+18.44220190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 682.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 217.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14141",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14141"},
        {"Smithsonian Astrophysical Observation", "SAO 93247"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.58352758),
        dec: Angle.Degrees(+18.44378549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212670"},
        {"Hipparcos Number", "HIP 110696"},
        {"Fundamental Katalog 5th Edition", "FK5 1586"},
        {"Geneva Identification System", "GEN# +1.00212670"},
        {"Smithsonian Astrophysical Observation", "SAO 107906"},
        {"Wilson Evans Batten Catalogue", "WEB 19832"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.41950724),
        dec: Angle.Degrees(+18.44424558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39168"},
        {"Hipparcos Number", "HIP 27666"},
        {"Geneva Identification System", "GEN# +1.00039168"},
        {"Smithsonian Astrophysical Observation", "SAO 94927"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86607429),
        dec: Angle.Degrees(+18.44425077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3570"},
        {"Smithsonian Astrophysical Observation", "SAO 92065"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.40562063),
        dec: Angle.Degrees(+18.44522623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165507"},
        {"Hipparcos Number", "HIP 88616"},
        {"Smithsonian Astrophysical Observation", "SAO 103372"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38989120),
        dec: Angle.Degrees(+18.44557218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11790"},
        {"Henry Draper 2", "HD 11783"},
        {"Hipparcos Number", "HIP 9012"},
        {"Smithsonian Astrophysical Observation", "SAO 92703"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.00493047),
        dec: Angle.Degrees(+18.44601718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100886"},
        {"Hipparcos Number", "HIP 56637"},
        {"Smithsonian Astrophysical Observation", "SAO 99692"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.17877253),
        dec: Angle.Degrees(+18.44629734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180025"},
        {"Hipparcos Number", "HIP 94514"},
        {"Smithsonian Astrophysical Observation", "SAO 104632"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.54729933),
        dec: Angle.Degrees(+18.44817353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14147"},
        {"Hipparcos Number", "HIP 10701"},
        {"Geneva Identification System", "GEN# +1.00014147"},
        {"Smithsonian Astrophysical Observation", "SAO 92873"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.43907135),
        dec: Angle.Degrees(+18.45494401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44697"},
        {"Hipparcos Number", "HIP 30428"},
        {"Geneva Identification System", "GEN# +1.00044697"},
        {"Smithsonian Astrophysical Observation", "SAO 95623"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.96467659),
        dec: Angle.Degrees(+18.45702990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9640"},
        {"Hipparcos Number", "HIP 7359"},
        {"Geneva Identification System", "GEN# +1.00009640"},
        {"Smithsonian Astrophysical Observation", "SAO 92520"},
        {"Wilson Evans Batten Catalogue", "WEB 1579"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.70436400),
        dec: Angle.Degrees(+18.46067238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129814"},
        {"Hipparcos Number", "HIP 72043"},
        {"Geneva Identification System", "GEN# +1.00129814"},
        {"Smithsonian Astrophysical Observation", "SAO 101175"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.04890709),
        dec: Angle.Degrees(+18.46246786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203991"},
        {"Hipparcos Number", "HIP 105753"},
        {"Smithsonian Astrophysical Observation", "SAO 107115"},
        {"Wilson Evans Batten Catalogue", "WEB 19193"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.28947519),
        dec: Angle.Degrees(+18.46262995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176646"},
        {"Hipparcos Number", "HIP 93331"},
        {"Geneva Identification System", "GEN# +1.00176646"},
        {"Smithsonian Astrophysical Observation", "SAO 104349"},
        {"Wilson Evans Batten Catalogue", "WEB 16183"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.14367787),
        dec: Angle.Degrees(+18.46346834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140232"},
        {"Hipparcos Number", "HIP 76878"},
        {"Geneva Identification System", "GEN# +1.00140232"},
        {"Renson", "Renson 39860"},
        {"Smithsonian Astrophysical Observation", "SAO 101686"},
        {"Wilson Evans Batten Catalogue", "WEB 13041"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.47815864),
        dec: Angle.Degrees(+18.46389861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186201"},
        {"Hipparcos Number", "HIP 96936"},
        {"Smithsonian Astrophysical Observation", "SAO 105163"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.58046891),
        dec: Angle.Degrees(+18.46563124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 351759"},
        {"Hipparcos Number", "HIP 99792"},
    },
    visualMagnitude: 10.46,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.70846620),
        dec: Angle.Degrees(+18.46569345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -693.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192663"},
        {"Hipparcos Number", "HIP 99833"},
        {"Geneva Identification System", "GEN# +1.00192663"},
        {"Smithsonian Astrophysical Observation", "SAO 105900"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.84128524),
        dec: Angle.Degrees(+18.46599827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116011",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116011"},
        {"Cincinnati Publication", "Ci 20 1429"},
        {"Geneva Identification System", "GEN# +9.80068022"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.57874753),
        dec: Angle.Degrees(+18.46642958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 556.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -429.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45452"},
        {"Hipparcos Number", "HIP 30801"},
        {"Geneva Identification System", "GEN# +1.00045452"},
        {"Smithsonian Astrophysical Observation", "SAO 95715"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.07439925),
        dec: Angle.Degrees(+18.46856352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20527"},
        {"Hipparcos Number", "HIP 15412"},
        {"Geneva Identification System", "GEN# +1.00020527"},
        {"Smithsonian Astrophysical Observation", "SAO 93378"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.67180094),
        dec: Angle.Degrees(+18.47296130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285444"},
        {"Hipparcos Number", "HIP 19470"},
        {"Smithsonian Astrophysical Observation", "SAO 93796"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.54904541),
        dec: Angle.Degrees(+18.47452135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167538"},
        {"Hipparcos Number", "HIP 89421"},
        {"Geneva Identification System", "GEN# +1.00167538"},
        {"Smithsonian Astrophysical Observation", "SAO 103524"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.73967157),
        dec: Angle.Degrees(+18.47460234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31734"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.58841583),
        dec: Angle.Degrees(+18.48041090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191878"},
        {"Hipparcos Number", "HIP 99494"},
        {"Geneva Identification System", "GEN# +1.00191878"},
        {"Smithsonian Astrophysical Observation", "SAO 105802"},
        {"Wilson Evans Batten Catalogue", "WEB 17790"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.87547733),
        dec: Angle.Degrees(+18.48042400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16944",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16944"},
        {"Smithsonian Astrophysical Observation", "SAO 93525"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51280177),
        dec: Angle.Degrees(+18.48099719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12870"},
        {"Hipparcos Number", "HIP 9824"},
        {"Smithsonian Astrophysical Observation", "SAO 92794"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.61796622),
        dec: Angle.Degrees(+18.48173012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1642"},
        {"Hipparcos Number", "HIP 1664"},
        {"Geneva Identification System", "GEN# +1.00001642"},
        {"Smithsonian Astrophysical Observation", "SAO 91857"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.20880347),
        dec: Angle.Degrees(+18.48207664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129358"},
        {"Hipparcos Number", "HIP 71827"},
        {"Geneva Identification System", "GEN# +1.00129358"},
        {"Smithsonian Astrophysical Observation", "SAO 101150"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.39717775),
        dec: Angle.Degrees(+18.48424700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348638"},
        {"Hipparcos Number", "HIP 90270"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.28354002),
        dec: Angle.Degrees(+18.48543014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107870"},
        {"Smithsonian Astrophysical Observation", "SAO 107440"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.83721556),
        dec: Angle.Degrees(+18.48566380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146101"},
        {"Hipparcos Number", "HIP 79544"},
        {"Geneva Identification System", "GEN# +1.00146101"},
        {"Smithsonian Astrophysical Observation", "SAO 102024"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.47440792),
        dec: Angle.Degrees(+18.48569345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348412"},
        {"Hipparcos Number", "HIP 89749"},
        {"Smithsonian Astrophysical Observation", "SAO 103601"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.73313146),
        dec: Angle.Degrees(+18.48580603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -183.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353091"},
        {"Hipparcos Number", "HIP 102778"},
        {"Smithsonian Astrophysical Observation", "SAO 106534"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.33262312),
        dec: Angle.Degrees(+18.48750490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173720"},
        {"Hipparcos Number", "HIP 92089"},
        {"Smithsonian Astrophysical Observation", "SAO 104078"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.51877465),
        dec: Angle.Degrees(+18.48784966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50887"},
        {"Hipparcos Number", "HIP 33326"},
        {"Geneva Identification System", "GEN# +1.00050887"},
        {"Smithsonian Astrophysical Observation", "SAO 96277"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.97263014),
        dec: Angle.Degrees(+18.49173004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129391"},
        {"Hipparcos Number", "HIP 71854"},
        {"Smithsonian Astrophysical Observation", "SAO 101156"},
        {"Wilson Evans Batten Catalogue", "WEB 12377"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.46482233),
        dec: Angle.Degrees(+18.49599650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 241630"},
        {"Hipparcos Number", "HIP 24317"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.27040161),
        dec: Angle.Degrees(+18.49868852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131583"},
        {"Hipparcos Number", "HIP 72901"},
        {"Smithsonian Astrophysical Observation", "SAO 101278"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.922,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.49643820),
        dec: Angle.Degrees(+18.49978406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138174"},
        {"Hipparcos Number", "HIP 75871"},
        {"Smithsonian Astrophysical Observation", "SAO 101581"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.46130220),
        dec: Angle.Degrees(+18.49984597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348282"},
        {"Hipparcos Number", "HIP 89449"},
        {"Geneva Identification System", "GEN# +1.00348282"},
        {"Wilson Evans Batten Catalogue", "WEB 15221"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.82607189),
        dec: Angle.Degrees(+18.49985259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8553"},
        {"Hipparcos Number", "HIP 6613"},
        {"Cincinnati Publication", "Ci 20 101"},
        {"Geneva Identification System", "GEN# +1.00008553"},
        {"Smithsonian Astrophysical Observation", "SAO 92422"},
        {"Wilson Evans Batten Catalogue", "WEB 1447"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.22336474),
        dec: Angle.Degrees(+18.50039482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 545.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -191.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87768",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87768"},
        {"Geneva Identification System", "GEN# +0.01803497"},
        {"Smithsonian Astrophysical Observation", "SAO 103221"},
        {"Wilson Evans Batten Catalogue", "WEB 14813"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.93719440),
        dec: Angle.Degrees(+18.50050011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190211"},
        {"Hipparcos Number", "HIP 98738"},
        {"Geneva Identification System", "GEN# +1.00190211A"},
        {"Smithsonian Astrophysical Observation", "SAO 105608"},
        {"Wilson Evans Batten Catalogue", "WEB 17488"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.81830316),
        dec: Angle.Degrees(+18.50104063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78898",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78898"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.59429089),
        dec: Angle.Degrees(+18.50175141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166621"},
        {"Hipparcos Number", "HIP 89070"},
        {"Smithsonian Astrophysical Observation", "SAO 103456"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.68277403),
        dec: Angle.Degrees(+18.50436782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72289"},
    },
    visualMagnitude: 10.65,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.75486207),
        dec: Angle.Degrees(+18.50608768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11309"},
        {"Hipparcos Number", "HIP 8654"},
        {"Fundamental Katalog 5th Edition", "FK5 4169"},
        {"Geneva Identification System", "GEN# +1.00011309"},
        {"Smithsonian Astrophysical Observation", "SAO 92662"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.88439594),
        dec: Angle.Degrees(+18.50816274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223333"},
        {"Hipparcos Number", "HIP 117428"},
        {"Smithsonian Astrophysical Observation", "SAO 108849"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.15983538),
        dec: Angle.Degrees(+18.50869278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62721"},
        {"Hipparcos Number", "HIP 37908"},
        {"Fundamental Katalog 5th Edition", "FK5 1200"},
        {"Geneva Identification System", "GEN# +1.00062721"},
        {"Smithsonian Astrophysical Observation", "SAO 97221"},
        {"Wilson Evans Batten Catalogue", "WEB 7482"},
    },
    visualMagnitude: 4.89,
    bvColour: 1.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.53122379),
        dec: Angle.Degrees(+18.51016877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17363"},
        {"Hipparcos Number", "HIP 13038"},
        {"Smithsonian Astrophysical Observation", "SAO 93106"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.88848049),
        dec: Angle.Degrees(+18.51040599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87805"},
        {"Hipparcos Number", "HIP 49635"},
        {"Smithsonian Astrophysical Observation", "SAO 98962"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.95859799),
        dec: Angle.Degrees(+18.51338771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180377"},
        {"Hipparcos Number", "HIP 94646"},
        {"Geneva Identification System", "GEN# +1.00180377"},
        {"Smithsonian Astrophysical Observation", "SAO 104662"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88904113),
        dec: Angle.Degrees(+18.51632809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68331"},
        {"Hipparcos Number", "HIP 40187"},
        {"Geneva Identification System", "GEN# +1.00068331"},
        {"Smithsonian Astrophysical Observation", "SAO 97648"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.13287424),
        dec: Angle.Degrees(+18.51694595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36122",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6073 A"},
        {"Henry Draper", "HD 58453"},
        {"Hipparcos Number", "HIP 36122"},
        {"Geneva Identification System", "GEN# +1.00058453"},
        {"Smithsonian Astrophysical Observation", "SAO 96897"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.61394777),
        dec: Angle.Degrees(+18.51696364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218235"},
        {"Hipparcos Number", "HIP 114081"},
        {"Geneva Identification System", "GEN# +1.00218235"},
        {"Smithsonian Astrophysical Observation", "SAO 108400"},
        {"Wilson Evans Batten Catalogue", "WEB 20258"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.57500937),
        dec: Angle.Degrees(+18.51761428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57202"},
        {"Geneva Identification System", "GEN# +0.01902495"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.94888047),
        dec: Angle.Degrees(+18.52240718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -151.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7640"},
        {"Hipparcos Number", "HIP 5952"},
        {"Cincinnati Publication", "Ci 18 163"},
        {"Geneva Identification System", "GEN# +1.00007640"},
        {"Smithsonian Astrophysical Observation", "SAO 92344"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.15116542),
        dec: Angle.Degrees(+18.52261574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5908"},
        {"Hipparcos Number", "HIP 4733"},
        {"Geneva Identification System", "GEN# +1.00005908"},
        {"Smithsonian Astrophysical Observation", "SAO 92200"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.20034842),
        dec: Angle.Degrees(+18.52563700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85002"},
        {"Hipparcos Number", "HIP 48189"},
        {"Geneva Identification System", "GEN# +1.00085002"},
        {"Smithsonian Astrophysical Observation", "SAO 98787"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.35489754),
        dec: Angle.Degrees(+18.52595836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88009"},
        {"Hipparcos Number", "HIP 49729"},
        {"Fundamental Katalog 5th Edition", "FK5 4904"},
        {"Geneva Identification System", "GEN# +1.00088009"},
        {"Smithsonian Astrophysical Observation", "SAO 98969"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.28501139),
        dec: Angle.Degrees(+18.53074651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80194"},
    },
    visualMagnitude: 11.84,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.57124091),
        dec: Angle.Degrees(+18.53395307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59550"},
        {"Smithsonian Astrophysical Observation", "SAO 99987"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.19511981),
        dec: Angle.Degrees(+18.53396999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187076J"},
        {"Henry Draper 2", "HD 187076"},
        {"Henry Draper 3", "HD 187077"},
        {"Hipparcos Number", "HIP 97365"},
        {"Fundamental Katalog 5th Edition", "FK5 743"},
        {"Geneva Identification System", "GEN# +1.00187076"},
        {"Geneva Identification System 2", "GEN# +1.00187077"},
        {"Smithsonian Astrophysical Observation", "SAO 105259"},
        {"Wilson Evans Batten Catalogue", "WEB 17111"},
    },
    visualMagnitude: 3.68,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.84693842),
        dec: Angle.Degrees(+18.53425912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217661"},
        {"Hipparcos Number", "HIP 113751"},
        {"Smithsonian Astrophysical Observation", "SAO 108352"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.54730401),
        dec: Angle.Degrees(+18.53503818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80190"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.56728762),
        dec: Angle.Degrees(+18.53717648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5986"},
        {"Hipparcos Number", "HIP 4785"},
        {"Geneva Identification System", "GEN# +1.00005986"},
        {"Smithsonian Astrophysical Observation", "SAO 92208"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.35748000),
        dec: Angle.Degrees(+18.53724321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220989"},
        {"Hipparcos Number", "HIP 115847"},
        {"Geneva Identification System", "GEN# +1.00220989"},
        {"Smithsonian Astrophysical Observation", "SAO 108625"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.05353386),
        dec: Angle.Degrees(+18.53828093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113761"},
        {"Hipparcos Number", "HIP 63898"},
        {"Geneva Identification System", "GEN# +1.00113761"},
        {"Smithsonian Astrophysical Observation", "SAO 100410"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.43158187),
        dec: Angle.Degrees(+18.53879435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50936"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.766,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.04986540),
        dec: Angle.Degrees(+18.53901636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36576"},
        {"Hipparcos Number", "HIP 26064"},
        {"Celescope Catalog", "CEL 782"},
        {"Geneva Identification System", "GEN# +1.00036576"},
        {"Smithsonian Astrophysical Observation", "SAO 94649"},
        {"Wilson Evans Batten Catalogue", "WEB 5068"},
    },
    visualMagnitude: 5.67,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.38179070),
        dec: Angle.Degrees(+18.54023092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90750",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90750"},
    },
    visualMagnitude: 12.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.74600550),
        dec: Angle.Degrees(+41.89439523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29260"},
        {"Hipparcos Number", "HIP 21517"},
        {"Geneva Identification System", "GEN# +1.00029260"},
        {"Smithsonian Astrophysical Observation", "SAO 94036"},
        {"Wilson Evans Batten Catalogue", "WEB 4129"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.31158471),
        dec: Angle.Degrees(+18.54304801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94588"},
        {"Hipparcos Number", "HIP 53413"},
        {"Geneva Identification System", "GEN# +1.00094588"},
        {"Smithsonian Astrophysical Observation", "SAO 99355"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.86983116),
        dec: Angle.Degrees(+18.54596606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195409"},
        {"Hipparcos Number", "HIP 101188"},
        {"Fundamental Katalog 5th Edition", "FK5 5808"},
        {"Smithsonian Astrophysical Observation", "SAO 106185"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.64987877),
        dec: Angle.Degrees(+18.54976908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54404"},
        {"Hipparcos Number", "HIP 34545"},
        {"Smithsonian Astrophysical Observation", "SAO 96567"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.35617575),
        dec: Angle.Degrees(+18.54987144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39097"},
        {"Hipparcos Number", "HIP 27642"},
        {"Smithsonian Astrophysical Observation", "SAO 94920"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.76927674),
        dec: Angle.Degrees(+18.55131834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117983"},
        {"Hipparcos Number", "HIP 66159"},
        {"Geneva Identification System", "GEN# +1.00117983"},
        {"Smithsonian Astrophysical Observation", "SAO 100617"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.42178901),
        dec: Angle.Degrees(+18.55268613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73577"},
        {"Hipparcos Number", "HIP 42487"},
        {"Smithsonian Astrophysical Observation", "SAO 98008"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.92901260),
        dec: Angle.Degrees(+18.55291555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15808"},
        {"Smithsonian Astrophysical Observation", "SAO 93409"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.91481176),
        dec: Angle.Degrees(+18.55577943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153560"},
        {"Hipparcos Number", "HIP 83144"},
        {"Smithsonian Astrophysical Observation", "SAO 102513"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.87562476),
        dec: Angle.Degrees(+18.55580403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31713",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31713"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.50309449),
        dec: Angle.Degrees(+18.55752123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86321"},
        {"Cincinnati Publication", "Ci 18 2348"},
        {"Geneva Identification System", "GEN# +0.01803423"},
        {"Smithsonian Astrophysical Observation", "SAO 102986"},
        {"Wilson Evans Batten Catalogue", "WEB 14566"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.56552133),
        dec: Angle.Degrees(+18.55757479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -205.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70324"},
        {"Cincinnati Publication", "Ci 18 1888"},
        {"Smithsonian Astrophysical Observation", "SAO 101003"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.83438339),
        dec: Angle.Degrees(+18.56006679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -334.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55727"},
        {"Hipparcos Number", "HIP 35041"},
        {"Smithsonian Astrophysical Observation", "SAO 96676"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.71121774),
        dec: Angle.Degrees(+18.56191680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178356"},
        {"Hipparcos Number", "HIP 93928"},
        {"Smithsonian Astrophysical Observation", "SAO 104500"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.88825942),
        dec: Angle.Degrees(+18.56256929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87626"},
        {"Smithsonian Astrophysical Observation", "SAO 103192"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.49559600),
        dec: Angle.Degrees(+18.56428731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286061"},
        {"Hipparcos Number", "HIP 22311"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.08058545),
        dec: Angle.Degrees(+18.56570140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49869",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49869"},
        {"Smithsonian Astrophysical Observation", "SAO 98987"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.74438002),
        dec: Angle.Degrees(+18.56627725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23465"},
        {"Hipparcos Number", "HIP 17586"},
        {"Smithsonian Astrophysical Observation", "SAO 93587"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.50418799),
        dec: Angle.Degrees(+18.56674046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151071"},
        {"Hipparcos Number", "HIP 81951"},
        {"Smithsonian Astrophysical Observation", "SAO 102354"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.10868991),
        dec: Angle.Degrees(+18.56863816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56713"},
        {"Hipparcos Number", "HIP 35438"},
        {"Geneva Identification System", "GEN# +1.00056713"},
        {"Smithsonian Astrophysical Observation", "SAO 96760"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.74213606),
        dec: Angle.Degrees(+18.56912311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245089"},
        {"Hipparcos Number", "HIP 26214"},
        {"Smithsonian Astrophysical Observation", "SAO 94667"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80424025),
        dec: Angle.Degrees(+18.57102116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77787"},
        {"Smithsonian Astrophysical Observation", "SAO 101791"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.25921314),
        dec: Angle.Degrees(+18.57106780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109945",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109945"},
        {"Smithsonian Astrophysical Observation", "SAO 107781"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.00396179),
        dec: Angle.Degrees(+18.57139139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83824",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83824"},
    },
    visualMagnitude: 9.91,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.97758447),
        dec: Angle.Degrees(+18.57198351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2220"},
        {"Hipparcos Number", "HIP 2068"},
        {"Smithsonian Astrophysical Observation", "SAO 91893"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.54576573),
        dec: Angle.Degrees(+18.57263410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78832"},
        {"Smithsonian Astrophysical Observation", "SAO 101915"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.38455230),
        dec: Angle.Degrees(+18.57379885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47795"},
        {"Hipparcos Number", "HIP 32005"},
        {"Smithsonian Astrophysical Observation", "SAO 95992"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.30497210),
        dec: Angle.Degrees(+18.57634863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197852"},
        {"Hipparcos Number", "HIP 102456"},
        {"Smithsonian Astrophysical Observation", "SAO 106460"},
    },
    visualMagnitude: 8.54,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.42201040),
        dec: Angle.Degrees(+18.57655818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7847"},
        {"Hipparcos Number", "HIP 6106"},
        {"Geneva Identification System", "GEN# +1.00007847"},
        {"Smithsonian Astrophysical Observation", "SAO 92359"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.59615941),
        dec: Angle.Degrees(+18.57729854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204725"},
        {"Hipparcos Number", "HIP 106152"},
        {"Geneva Identification System", "GEN# +1.00204725"},
        {"Smithsonian Astrophysical Observation", "SAO 107181"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.52858403),
        dec: Angle.Degrees(+18.57854756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1953"},
        {"Hipparcos Number", "HIP 1888"},
        {"Geneva Identification System", "GEN# +1.00001953"},
        {"Smithsonian Astrophysical Observation", "SAO 91876"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.96596065),
        dec: Angle.Degrees(+18.57943547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114173"},
        {"Hipparcos Number", "HIP 64142"},
        {"Geneva Identification System", "GEN# +1.00114173"},
        {"Smithsonian Astrophysical Observation", "SAO 100433"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.18034660),
        dec: Angle.Degrees(+18.58004552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63870",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63870"},
        {"Smithsonian Astrophysical Observation", "SAO 100406"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.35723552),
        dec: Angle.Degrees(+18.58096316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14523"},
        {"Hipparcos Number", "HIP 10955"},
        {"Smithsonian Astrophysical Observation", "SAO 92896"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.27871977),
        dec: Angle.Degrees(+18.58457428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176007"},
        {"Hipparcos Number", "HIP 93067"},
        {"Smithsonian Astrophysical Observation", "SAO 104288"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.35819688),
        dec: Angle.Degrees(+18.58730174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170698"},
        {"Hipparcos Number", "HIP 90673"},
        {"Smithsonian Astrophysical Observation", "SAO 103785"},
        {"Wilson Evans Batten Catalogue", "WEB 15532"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.51651216),
        dec: Angle.Degrees(+18.58830106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186569"},
        {"Hipparcos Number", "HIP 97135"},
        {"Geneva Identification System", "GEN# +1.00186569"},
        {"Smithsonian Astrophysical Observation", "SAO 105201"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.13141516),
        dec: Angle.Degrees(+18.58864183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86287",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86287"},
        {"Cincinnati Publication", "Ci 18 2347"},
        {"Cincinnati Publication 2", "Ci 20 1050"},
        {"Geneva Identification System", "GEN# +0.01803421"},
        {"Wilson Evans Batten Catalogue", "WEB 14554"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.46990247),
        dec: Angle.Degrees(+18.58931915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 926.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 983.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63233",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63233"},
        {"Smithsonian Astrophysical Observation", "SAO 100345"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.35591877),
        dec: Angle.Degrees(+18.58982233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61524"},
        {"Hipparcos Number", "HIP 37387"},
        {"Geneva Identification System", "GEN# +1.00061524"},
        {"Smithsonian Astrophysical Observation", "SAO 97134"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.12044273),
        dec: Angle.Degrees(+18.58985023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163150"},
        {"Hipparcos Number", "HIP 87620"},
        {"Smithsonian Astrophysical Observation", "SAO 103191"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.48684558),
        dec: Angle.Degrees(+18.59006428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24571"},
        {"Hipparcos Number", "HIP 18326"},
        {"Geneva Identification System", "GEN# +1.00024571"},
        {"Smithsonian Astrophysical Observation", "SAO 93670"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.77349320),
        dec: Angle.Degrees(+18.59051677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349136"},
        {"Hipparcos Number", "HIP 91493"},
        {"Smithsonian Astrophysical Observation", "SAO 103963"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.89375417),
        dec: Angle.Degrees(+18.59086623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90603"},
        {"Hipparcos Number", "HIP 51241"},
        {"Smithsonian Astrophysical Observation", "SAO 99140"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.99409522),
        dec: Angle.Degrees(+18.59179366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185337"},
        {"Hipparcos Number", "HIP 96571"},
        {"Fundamental Katalog 5th Edition", "FK5 5726"},
        {"Geneva Identification System", "GEN# +1.00185337"},
        {"Smithsonian Astrophysical Observation", "SAO 105078"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.48345695),
        dec: Angle.Degrees(+18.59248247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95036"},
        {"Hipparcos Number", "HIP 53650"},
        {"Smithsonian Astrophysical Observation", "SAO 99381"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.64743777),
        dec: Angle.Degrees(+18.59280173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119036"},
        {"Hipparcos Number", "HIP 66720"},
        {"Geneva Identification System", "GEN# +1.00119036"},
        {"Smithsonian Astrophysical Observation", "SAO 100657"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.14743632),
        dec: Angle.Degrees(+18.59332520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242725"},
        {"Hipparcos Number", "HIP 24910"},
        {"Smithsonian Astrophysical Observation", "SAO 94469"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.08710983),
        dec: Angle.Degrees(+18.59339087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36389"},
        {"Hipparcos Number", "HIP 25945"},
        {"Geneva Identification System", "GEN# +1.00036389"},
        {"Smithsonian Astrophysical Observation", "SAO 94628"},
        {"Wilson Evans Batten Catalogue", "WEB 5046"},
    },
    visualMagnitude: 4.32,
    bvColour: 2.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.05313020),
        dec: Angle.Degrees(+18.59424525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16896",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16896"},
        {"Geneva Identification System", "GEN# +5.20250159"},
        {"Smithsonian Astrophysical Observation", "SAO 93521"},
        {"Wilson Evans Batten Catalogue", "WEB 3214"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.34417225),
        dec: Angle.Degrees(+18.59689473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138666"},
        {"Hipparcos Number", "HIP 76131"},
        {"Smithsonian Astrophysical Observation", "SAO 101608"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.23765505),
        dec: Angle.Degrees(+18.59714525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24278"},
        {"Hipparcos Number", "HIP 18116"},
        {"Smithsonian Astrophysical Observation", "SAO 93644"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.09625279),
        dec: Angle.Degrees(+18.59780203)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75193",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75193"},
    },
    visualMagnitude: 11.94,
    bvColour: 2.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.48657278),
        dec: Angle.Degrees(+18.59809932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61555"},
        {"Smithsonian Astrophysical Observation", "SAO 100174"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.18672832),
        dec: Angle.Degrees(+18.59902633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16646"},
        {"Hipparcos Number", "HIP 12472"},
        {"Geneva Identification System", "GEN# +1.00016646"},
        {"Smithsonian Astrophysical Observation", "SAO 93042"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.13786871),
        dec: Angle.Degrees(+18.59970416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35146"},
        {"Hipparcos Number", "HIP 25204"},
        {"Smithsonian Astrophysical Observation", "SAO 94510"},
        {"Wilson Evans Batten Catalogue", "WEB 4884"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.87767327),
        dec: Angle.Degrees(+18.60071498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62406"},
        {"Hipparcos Number", "HIP 37745"},
        {"Smithsonian Astrophysical Observation", "SAO 97202"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.12344776),
        dec: Angle.Degrees(+18.60139947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211244"},
        {"Hipparcos Number", "HIP 109891"},
        {"Geneva Identification System", "GEN# +1.00211244"},
        {"Smithsonian Astrophysical Observation", "SAO 107770"},
        {"Wilson Evans Batten Catalogue", "WEB 19729"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.86099279),
        dec: Angle.Degrees(+18.60323699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116801"},
        {"Hipparcos Number", "HIP 65510"},
        {"Smithsonian Astrophysical Observation", "SAO 100562"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.527,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.42530119),
        dec: Angle.Degrees(+18.60633661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74307",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74307"},
        {"Smithsonian Astrophysical Observation", "SAO 101420"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.81794318),
        dec: Angle.Degrees(+18.60767872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113768",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16463 AB"},
        {"Henry Draper", "HD 217716"},
        {"Hipparcos Number", "HIP 113768"},
        {"Geneva Identification System", "GEN# +1.00217716J"},
        {"Smithsonian Astrophysical Observation", "SAO 108354"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.59451433),
        dec: Angle.Degrees(+18.60885190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220347"},
        {"Hipparcos Number", "HIP 115432"},
        {"Smithsonian Astrophysical Observation", "SAO 108576"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.73399107),
        dec: Angle.Degrees(+18.60970968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53864"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.28935919),
        dec: Angle.Degrees(+18.61030675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178692"},
        {"Hipparcos Number", "HIP 94057"},
        {"Geneva Identification System", "GEN# +1.00178692"},
        {"Smithsonian Astrophysical Observation", "SAO 104528"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.22656845),
        dec: Angle.Degrees(+18.61077553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83364"},
        {"Smithsonian Astrophysical Observation", "SAO 102546"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.57130374),
        dec: Angle.Degrees(+18.61135177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78144",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78144"},
    },
    visualMagnitude: 11.41,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.35167475),
        dec: Angle.Degrees(+18.61223068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163675"},
        {"Hipparcos Number", "HIP 87834"},
        {"Smithsonian Astrophysical Observation", "SAO 103234"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.15757282),
        dec: Angle.Degrees(+18.61241645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 212.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59293"},
        {"Hipparcos Number", "HIP 36455"},
        {"Smithsonian Astrophysical Observation", "SAO 96955"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.51930034),
        dec: Angle.Degrees(+18.61500749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230002"},
        {"Hipparcos Number", "HIP 92789"},
        {"Smithsonian Astrophysical Observation", "SAO 104248"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62393569),
        dec: Angle.Degrees(+18.61521898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191261"},
        {"Hipparcos Number", "HIP 99203"},
        {"Smithsonian Astrophysical Observation", "SAO 105739"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.09515372),
        dec: Angle.Degrees(+18.61589272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4487"},
        {"Smithsonian Astrophysical Observation", "SAO 92179"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.38441050),
        dec: Angle.Degrees(+18.61636431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27502",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38835"},
        {"Hipparcos Number", "HIP 27502"},
        {"Celescope Catalog", "CEL 993"},
        {"Geneva Identification System", "GEN# +1.00038835"},
        {"Smithsonian Astrophysical Observation", "SAO 94883"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.35503504),
        dec: Angle.Degrees(+18.61819535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199971"},
        {"Hipparcos Number", "HIP 103644"},
        {"Smithsonian Astrophysical Observation", "SAO 106742"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.99282588),
        dec: Angle.Degrees(+18.61894852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202424"},
        {"Hipparcos Number", "HIP 104923"},
        {"Smithsonian Astrophysical Observation", "SAO 106962"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.79943705),
        dec: Angle.Degrees(+18.61925727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59876"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.19284760),
        dec: Angle.Degrees(+18.61958411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142763"},
        {"Hipparcos Number", "HIP 77995"},
        {"Geneva Identification System", "GEN# +1.00142763"},
        {"Smithsonian Astrophysical Observation", "SAO 101821"},
        {"Wilson Evans Batten Catalogue", "WEB 13190"},
    },
    visualMagnitude: 6.26,
    bvColour: -0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.91607323),
        dec: Angle.Degrees(+18.62077132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103376"},
        {"Hipparcos Number", "HIP 58046"},
        {"Geneva Identification System", "GEN# +0.01902515"},
        {"Geneva Identification System 2", "GEN# +1.00103376"},
        {"Wilson Evans Batten Catalogue", "WEB 10396"},
    },
    visualMagnitude: 10.18,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.57155570),
        dec: Angle.Degrees(+18.62297226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24435",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24435"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.63441991),
        dec: Angle.Degrees(+18.62374676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105865"},
        {"Hipparcos Number", "HIP 59391"},
        {"Geneva Identification System", "GEN# +1.00105865"},
        {"Smithsonian Astrophysical Observation", "SAO 99975"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.75924418),
        dec: Angle.Degrees(+18.62505603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285536"},
        {"Hipparcos Number", "HIP 19847"},
        {"Smithsonian Astrophysical Observation", "SAO 93833"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.82259664),
        dec: Angle.Degrees(+18.62538074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114241"},
        {"Hipparcos Number", "HIP 64169"},
        {"Geneva Identification System", "GEN# +1.00114241"},
        {"Smithsonian Astrophysical Observation", "SAO 100435"},
        {"Wilson Evans Batten Catalogue", "WEB 11341"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.27372032),
        dec: Angle.Degrees(+18.62567154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102897"},
        {"Hipparcos Number", "HIP 57768"},
        {"Geneva Identification System", "GEN# +1.00102897"},
        {"Smithsonian Astrophysical Observation", "SAO 99824"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.70293293),
        dec: Angle.Degrees(+18.62570505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113213"},
        {"Hipparcos Number", "HIP 63601"},
        {"Geneva Identification System", "GEN# +1.00113213"},
        {"Smithsonian Astrophysical Observation", "SAO 100383"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.50881112),
        dec: Angle.Degrees(+18.62601665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195668"},
        {"Hipparcos Number", "HIP 101316"},
        {"Geneva Identification System", "GEN# +1.00195668"},
        {"Smithsonian Astrophysical Observation", "SAO 106213"},
        {"Wilson Evans Batten Catalogue", "WEB 18307"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.03324636),
        dec: Angle.Degrees(+18.62763301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72116"},
        {"Smithsonian Astrophysical Observation", "SAO 101182"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.27867372),
        dec: Angle.Degrees(+18.62776542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150683"},
        {"Hipparcos Number", "HIP 81752"},
        {"Geneva Identification System", "GEN# +1.00150683"},
        {"Smithsonian Astrophysical Observation", "SAO 102330"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.47198269),
        dec: Angle.Degrees(+18.62856198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120601"},
        {"Hipparcos Number", "HIP 67521"},
        {"Geneva Identification System", "GEN# +1.00120601"},
        {"Smithsonian Astrophysical Observation", "SAO 100734"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.52605660),
        dec: Angle.Degrees(+18.62899456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61615"},
        {"Smithsonian Astrophysical Observation", "SAO 100183"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.40794941),
        dec: Angle.Degrees(+18.62957773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59292"},
        {"Hipparcos Number", "HIP 36449"},
        {"Smithsonian Astrophysical Observation", "SAO 96953"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50495733),
        dec: Angle.Degrees(+18.62959846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218079"},
        {"Hipparcos Number", "HIP 113981"},
        {"Geneva Identification System", "GEN# +1.00218079"},
        {"Smithsonian Astrophysical Observation", "SAO 108382"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.25249534),
        dec: Angle.Degrees(+18.63120505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148911"},
        {"Hipparcos Number", "HIP 80855"},
        {"Geneva Identification System", "GEN# +1.00148911"},
        {"Smithsonian Astrophysical Observation", "SAO 102215"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.67160954),
        dec: Angle.Degrees(+18.63409704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13496"},
        {"Smithsonian Astrophysical Observation", "SAO 93167"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.44499140),
        dec: Angle.Degrees(+18.63416255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205656"},
        {"Hipparcos Number", "HIP 106678"},
        {"Cincinnati Publication", "Ci 18 2805"},
        {"Geneva Identification System", "GEN# +1.00205656"},
        {"Smithsonian Astrophysical Observation", "SAO 107272"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.10762827),
        dec: Angle.Degrees(+18.63458108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 103.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11098 AB"},
        {"Henry Draper", "HD 166157"},
        {"Hipparcos Number", "HIP 88875"},
        {"Smithsonian Astrophysical Observation", "SAO 103419"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15941396),
        dec: Angle.Degrees(+18.63576769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1098",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 166 AB"},
        {"Henry Draper", "HD 929"},
        {"Hipparcos Number", "HIP 1098"},
        {"Geneva Identification System", "GEN# +1.00000929J"},
        {"Smithsonian Astrophysical Observation", "SAO 91783"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.42924188),
        dec: Angle.Degrees(+18.63580542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 242055"},
        {"Hipparcos Number", "HIP 24533"},
        {"Smithsonian Astrophysical Observation", "SAO 94422"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.95538411),
        dec: Angle.Degrees(+18.63821086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286202"},
        {"Hipparcos Number", "HIP 23134"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.67406842),
        dec: Angle.Degrees(+18.63994204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350185"},
        {"Hipparcos Number", "HIP 96490"},
        {"Smithsonian Astrophysical Observation", "SAO 105050"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.23229237),
        dec: Angle.Degrees(+18.64099989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -159.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30505"},
        {"Hipparcos Number", "HIP 22380"},
        {"Geneva Identification System", "GEN# +5.20250116"},
        {"Smithsonian Astrophysical Observation", "SAO 94143"},
        {"Wilson Evans Batten Catalogue", "WEB 4314"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.833,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.26446034),
        dec: Angle.Degrees(+18.64133790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98017"},
        {"Hipparcos Number", "HIP 55071"},
        {"Geneva Identification System", "GEN# +1.00098017"},
        {"Smithsonian Astrophysical Observation", "SAO 99528"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.12570982),
        dec: Angle.Degrees(+18.64165661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47278",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47278"},
        {"Smithsonian Astrophysical Observation", "SAO 98685"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.52769023),
        dec: Angle.Degrees(+18.64168080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222427"},
        {"Hipparcos Number", "HIP 116802"},
        {"Smithsonian Astrophysical Observation", "SAO 108762"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.09453842),
        dec: Angle.Degrees(+18.64327168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23835",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3701 AB"},
        {"Henry Draper", "HD 32923"},
        {"Hipparcos Number", "HIP 23835"},
        {"Cincinnati Publication", "Ci 20 315"},
        {"Geneva Identification System", "GEN# +1.00032923"},
        {"Smithsonian Astrophysical Observation", "SAO 94332"},
        {"Wilson Evans Batten Catalogue", "WEB 4648"},
    },
    visualMagnitude: 4.91,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.86115023),
        dec: Angle.Degrees(+18.64500711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 536.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230705"},
        {"Hipparcos Number", "HIP 93854"},
        {"Wilson Evans Batten Catalogue", "WEB 16327"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.71606670),
        dec: Angle.Degrees(+18.64515082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219828"},
        {"Hipparcos Number", "HIP 115100"},
        {"Geneva Identification System", "GEN# +1.00219828"},
        {"Smithsonian Astrophysical Observation", "SAO 108536"},
        {"Wilson Evans Batten Catalogue", "WEB 20390"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.69473768),
        dec: Angle.Degrees(+18.64571293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95455",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12416 AB"},
        {"Henry Draper", "HD 231357"},
        {"Hipparcos Number", "HIP 95455"},
        {"Smithsonian Astrophysical Observation", "SAO 104810"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.26388756),
        dec: Angle.Degrees(+18.64985660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131132"},
        {"Hipparcos Number", "HIP 72653"},
        {"Smithsonian Astrophysical Observation", "SAO 101247"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.81679748),
        dec: Angle.Degrees(+18.65008757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 585"},
        {"Hipparcos Number", "HIP 843"},
        {"Geneva Identification System", "GEN# +1.00000585"},
        {"Smithsonian Astrophysical Observation", "SAO 91751"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.58674385),
        dec: Angle.Degrees(+18.65036403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85018"},
        {"Hipparcos Number", "HIP 48196"},
        {"Geneva Identification System", "GEN# +1.00085018"},
        {"Smithsonian Astrophysical Observation", "SAO 98788"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.38272337),
        dec: Angle.Degrees(+18.65106696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10365"},
        {"Hipparcos Number", "HIP 7893"},
        {"Geneva Identification System", "GEN# +1.00010365"},
        {"Smithsonian Astrophysical Observation", "SAO 92579"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.38687488),
        dec: Angle.Degrees(+18.65214745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91770"},
        {"Hipparcos Number", "HIP 51900"},
        {"Smithsonian Astrophysical Observation", "SAO 99200"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.05002538),
        dec: Angle.Degrees(+18.65307951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187258"},
        {"Hipparcos Number", "HIP 97450"},
        {"Geneva Identification System", "GEN# +1.00187258"},
        {"Renson", "Renson 51650"},
        {"Smithsonian Astrophysical Observation", "SAO 105280"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.11690661),
        dec: Angle.Degrees(+18.65505030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48345"},
        {"Hipparcos Number", "HIP 32238"},
        {"Geneva Identification System", "GEN# +1.00048345"},
        {"Smithsonian Astrophysical Observation", "SAO 96047"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.94670070),
        dec: Angle.Degrees(+18.65591739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200788"},
        {"Hipparcos Number", "HIP 104073"},
        {"Smithsonian Astrophysical Observation", "SAO 106825"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.27477539),
        dec: Angle.Degrees(+18.65596476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38321"},
        {"Hipparcos Number", "HIP 27183"},
        {"Geneva Identification System", "GEN# +1.00038321"},
        {"Smithsonian Astrophysical Observation", "SAO 94837"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.41886794),
        dec: Angle.Degrees(+18.65690087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229326"},
        {"Hipparcos Number", "HIP 91897"},
        {"Smithsonian Astrophysical Observation", "SAO 104042"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.01604529),
        dec: Angle.Degrees(+18.66062253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84967"},
        {"Hipparcos Number", "HIP 48182"},
        {"Geneva Identification System", "GEN# +1.00084967"},
        {"Smithsonian Astrophysical Observation", "SAO 98786"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.31722500),
        dec: Angle.Degrees(+18.66135611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18643",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18643"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.85780811),
        dec: Angle.Degrees(+18.66276819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17740",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17740"},
        {"Smithsonian Astrophysical Observation", "SAO 93607"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.98766352),
        dec: Angle.Degrees(+18.66339496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15551"},
        {"Hipparcos Number", "HIP 11667"},
        {"Smithsonian Astrophysical Observation", "SAO 92977"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.62560801),
        dec: Angle.Degrees(+18.66437605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73228"},
        {"Smithsonian Astrophysical Observation", "SAO 101304"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.49552041),
        dec: Angle.Degrees(+18.66462860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116961",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16942 A"},
        {"Henry Draper", "HD 222659"},
        {"Hipparcos Number", "HIP 116961"},
        {"Smithsonian Astrophysical Observation", "SAO 108780"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.63050770),
        dec: Angle.Degrees(+18.66654915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83157"},
    },
    visualMagnitude: 11.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.91090440),
        dec: Angle.Degrees(+18.66793543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108022"},
        {"Hipparcos Number", "HIP 60535"},
        {"Geneva Identification System", "GEN# +1.00108022"},
        {"Smithsonian Astrophysical Observation", "SAO 100085"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.15080193),
        dec: Angle.Degrees(+18.66835998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25445"},
        {"Hipparcos Number", "HIP 18909"},
        {"Smithsonian Astrophysical Observation", "SAO 93739"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.79246159),
        dec: Angle.Degrees(+18.66876941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52996"},
        {"Hipparcos Number", "HIP 34094"},
        {"Smithsonian Astrophysical Observation", "SAO 96439"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.03970140),
        dec: Angle.Degrees(+18.66882038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63513",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63513"},
        {"Smithsonian Astrophysical Observation", "SAO 100371"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.21432972),
        dec: Angle.Degrees(+18.66945601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38332",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38332"},
        {"Smithsonian Astrophysical Observation", "SAO 97305"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.77844673),
        dec: Angle.Degrees(+18.67005278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352476"},
        {"Hipparcos Number", "HIP 101228"},
    },
    visualMagnitude: 9.96,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.78821641),
        dec: Angle.Degrees(+18.67132196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9742 AB"},
        {"Henry Draper", "HD 139939"},
        {"Hipparcos Number", "HIP 76769"},
        {"Renson", "Renson 39800"},
        {"Smithsonian Astrophysical Observation", "SAO 101675"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.11857242),
        dec: Angle.Degrees(+18.67143235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5705"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.34775167),
        dec: Angle.Degrees(+18.67182092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188001"},
        {"Hipparcos Number", "HIP 97796"},
        {"Geneva Identification System", "GEN# +1.00188001"},
        {"Smithsonian Astrophysical Observation", "SAO 105360"},
        {"Wilson Evans Batten Catalogue", "WEB 17205"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.09068778),
        dec: Angle.Degrees(+18.67190024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229752"},
        {"Hipparcos Number", "HIP 92516"},
        {"Smithsonian Astrophysical Observation", "SAO 104182"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.81617760),
        dec: Angle.Degrees(+18.67269017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45179"},
        {"Smithsonian Astrophysical Observation", "SAO 98428"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.10172689),
        dec: Angle.Degrees(+18.67314400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7571"},
        {"Smithsonian Astrophysical Observation", "SAO 92539"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.38330196),
        dec: Angle.Degrees(+18.67536095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112573B"},
        {"Hipparcos Number", "HIP 63239"},
        {"Smithsonian Astrophysical Observation", "SAO 100347"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.36778708),
        dec: Angle.Degrees(+18.67617923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -231.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 114.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43199"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.00734192),
        dec: Angle.Degrees(+18.67715249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10875"},
        {"Hipparcos Number", "HIP 8303"},
        {"Smithsonian Astrophysical Observation", "SAO 92626"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.76610791),
        dec: Angle.Degrees(+18.67775353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102263"},
        {"Hipparcos Number", "HIP 57417"},
        {"Smithsonian Astrophysical Observation", "SAO 99783"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.57684949),
        dec: Angle.Degrees(+18.67957316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42784"},
        {"Hipparcos Number", "HIP 29545"},
        {"Celescope Catalog", "CEL 1125"},
        {"Geneva Identification System", "GEN# +1.00042784"},
        {"Smithsonian Astrophysical Observation", "SAO 95397"},
        {"Wilson Evans Batten Catalogue", "WEB 5807"},
    },
    visualMagnitude: 6.58,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.38853276),
        dec: Angle.Degrees(+18.68038550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56467",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56467"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.66015240),
        dec: Angle.Degrees(+18.68069100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8262"},
        {"Hipparcos Number", "HIP 6405"},
        {"Cincinnati Publication", "Ci 20 98"},
        {"Cincinnati Publication 2", "Ci 18 177"},
        {"Geneva Identification System", "GEN# +1.00008262"},
        {"Smithsonian Astrophysical Observation", "SAO 92398"},
        {"Wilson Evans Batten Catalogue", "WEB 1418"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.57305873),
        dec: Angle.Degrees(+18.68271329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 555.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116618"},
        {"Hipparcos Number", "HIP 65416"},
        {"Geneva Identification System", "GEN# +1.00116618"},
        {"Smithsonian Astrophysical Observation", "SAO 100554"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.12123737),
        dec: Angle.Degrees(+18.68317346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43480"},
        {"Hipparcos Number", "HIP 29856"},
        {"Geneva Identification System", "GEN# +1.00043480"},
        {"Smithsonian Astrophysical Observation", "SAO 95487"},
        {"Wilson Evans Batten Catalogue", "WEB 5911"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.30872184),
        dec: Angle.Degrees(+18.68318743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225000"},
        {"Hipparcos Number", "HIP 201"},
        {"Smithsonian Astrophysical Observation", "SAO 108980"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.63931400),
        dec: Angle.Degrees(+18.68336438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84455"},
        {"Hipparcos Number", "HIP 47909"},
        {"Fundamental Katalog 5th Edition", "FK5 1253"},
        {"Geneva Identification System", "GEN# +1.00084455"},
        {"Smithsonian Astrophysical Observation", "SAO 98750"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.46636307),
        dec: Angle.Degrees(+18.68361587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185605"},
        {"Hipparcos Number", "HIP 96671"},
        {"Smithsonian Astrophysical Observation", "SAO 105099"},
        {"Wilson Evans Batten Catalogue", "WEB 16959"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.80900595),
        dec: Angle.Degrees(+18.68383094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3795",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 673 AB"},
        {"Henry Draper", "HD 4655"},
        {"Hipparcos Number", "HIP 3795"},
        {"Smithsonian Astrophysical Observation", "SAO 92095"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.18675807),
        dec: Angle.Degrees(+18.68565151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77571"},
        {"Hipparcos Number", "HIP 44489"},
        {"Geneva Identification System", "GEN# +1.00077571"},
        {"Smithsonian Astrophysical Observation", "SAO 98329"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.96885077),
        dec: Angle.Degrees(+18.68600498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37869"},
        {"Hipparcos Number", "HIP 26879"},
        {"Geneva Identification System", "GEN# +1.00037869"},
        {"Smithsonian Astrophysical Observation", "SAO 94784"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.60119234),
        dec: Angle.Degrees(+18.68743727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171488"},
        {"Hipparcos Number", "HIP 91043"},
        {"Geneva Identification System", "GEN# +1.00171488"},
        {"Smithsonian Astrophysical Observation", "SAO 103862"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.58381360),
        dec: Angle.Degrees(+18.69018708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67979",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121476"},
        {"Hipparcos Number", "HIP 67979"},
        {"Geneva Identification System", "GEN# +1.00121476"},
        {"Smithsonian Astrophysical Observation", "SAO 100771"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.81793224),
        dec: Angle.Degrees(+18.69023964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5883"},
        {"Hipparcos Number", "HIP 4705"},
        {"Geneva Identification System", "GEN# +1.00005883"},
        {"Smithsonian Astrophysical Observation", "SAO 92196"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.12341109),
        dec: Angle.Degrees(+18.69157610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285238"},
        {"Hipparcos Number", "HIP 18506"},
    },
    visualMagnitude: 10.47,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.35605631),
        dec: Angle.Degrees(+18.69199451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14391"},
    },
    visualMagnitude: 9.97,
    bvColour: 1.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.41506476),
        dec: Angle.Degrees(+18.69205321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97227"},
        {"Hipparcos Number", "HIP 54683"},
        {"Geneva Identification System", "GEN# +1.00097227"},
        {"Smithsonian Astrophysical Observation", "SAO 99491"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.91810213),
        dec: Angle.Degrees(+18.69229829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40483",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6696 A"},
        {"Henry Draper", "HD 69072"},
        {"Hipparcos Number", "HIP 40483"},
        {"Smithsonian Astrophysical Observation", "SAO 97684"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.99355030),
        dec: Angle.Degrees(+18.69393199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219713"},
        {"Hipparcos Number", "HIP 115032"},
        {"Smithsonian Astrophysical Observation", "SAO 108518"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47587512),
        dec: Angle.Degrees(+18.70241815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38247"},
        {"Hipparcos Number", "HIP 27129"},
        {"Geneva Identification System", "GEN# +1.00038247"},
        {"Smithsonian Astrophysical Observation", "SAO 94830"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.29801319),
        dec: Angle.Degrees(+18.70436891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74621"},
        {"Smithsonian Astrophysical Observation", "SAO 101458"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.70516383),
        dec: Angle.Degrees(+18.74344037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206386"},
        {"Hipparcos Number", "HIP 107086"},
        {"Smithsonian Astrophysical Observation", "SAO 107325"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.35311263),
        dec: Angle.Degrees(+18.70440401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231606"},
        {"Hipparcos Number", "HIP 95906"},
        {"Geneva Identification System", "GEN# +1.00231606"},
        {"Smithsonian Astrophysical Observation", "SAO 104907"},
        {"Wilson Evans Batten Catalogue", "WEB 16794"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.56311171),
        dec: Angle.Degrees(+18.70499071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231799"},
        {"Hipparcos Number", "HIP 96191"},
        {"Geneva Identification System", "GEN# +1.00231799"},
        {"Smithsonian Astrophysical Observation", "SAO 104964"},
        {"Wilson Evans Batten Catalogue", "WEB 16856"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.38530404),
        dec: Angle.Degrees(+18.70557776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173833"},
        {"Hipparcos Number", "HIP 92131"},
        {"Geneva Identification System", "GEN# +1.00173833"},
        {"Smithsonian Astrophysical Observation", "SAO 104087"},
        {"Wilson Evans Batten Catalogue", "WEB 15884"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.67230062),
        dec: Angle.Degrees(+18.70596703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30455"},
        {"Hipparcos Number", "HIP 22349"},
        {"Cincinnati Publication", "Ci 20 305"},
        {"Geneva Identification System", "GEN# +1.00030455"},
        {"Smithsonian Astrophysical Observation", "SAO 94136"},
        {"Wilson Evans Batten Catalogue", "WEB 4306"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.17509246),
        dec: Angle.Degrees(+18.71036592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285970"},
        {"Hipparcos Number", "HIP 21946"},
        {"Geneva Identification System", "GEN# +1.20029836"},
        {"Geneva Identification System 2", "GEN# +5.20258028"},
        {"Wilson Evans Batten Catalogue", "WEB 4217"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.75569964),
        dec: Angle.Degrees(+18.71187127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132773"},
        {"Hipparcos Number", "HIP 73430"},
        {"Smithsonian Astrophysical Observation", "SAO 101325"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.09217603),
        dec: Angle.Degrees(+18.71289807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114745"},
        {"Hipparcos Number", "HIP 64429"},
        {"Geneva Identification System", "GEN# +1.00114745"},
        {"Smithsonian Astrophysical Observation", "SAO 100459"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.08872381),
        dec: Angle.Degrees(+18.71330209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224428"},
        {"Hipparcos Number", "HIP 118140"},
        {"Geneva Identification System", "GEN# +1.00224428"},
        {"Smithsonian Astrophysical Observation", "SAO 108932"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.45151244),
        dec: Angle.Degrees(+18.71357761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53116",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53116"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.99768768),
        dec: Angle.Degrees(+18.71374934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94088"},
        {"Hipparcos Number", "HIP 53105"},
        {"Smithsonian Astrophysical Observation", "SAO 99329"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.97118531),
        dec: Angle.Degrees(+18.71930959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29836"},
        {"Hipparcos Number", "HIP 21923"},
        {"Geneva Identification System", "GEN# +1.10029836"},
        {"Geneva Identification System 2", "GEN# +1.00029836"},
        {"Smithsonian Astrophysical Observation", "SAO 94078"},
        {"Wilson Evans Batten Catalogue", "WEB 4212"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.71517818),
        dec: Angle.Degrees(+18.72065703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142356"},
        {"Hipparcos Number", "HIP 77836"},
        {"Geneva Identification System", "GEN# +1.00142356"},
        {"Smithsonian Astrophysical Observation", "SAO 101798"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.39722082),
        dec: Angle.Degrees(+18.72279637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190210"},
        {"Hipparcos Number", "HIP 98742"},
        {"Smithsonian Astrophysical Observation", "SAO 105611"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.83322368),
        dec: Angle.Degrees(+18.72288791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53109"},
        {"Hipparcos Number", "HIP 34130"},
        {"Smithsonian Astrophysical Observation", "SAO 96449"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.15462150),
        dec: Angle.Degrees(+18.72393043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114889"},
        {"Hipparcos Number", "HIP 64496"},
        {"Geneva Identification System", "GEN# +1.00114889"},
        {"Smithsonian Astrophysical Observation", "SAO 100467"},
        {"Wilson Evans Batten Catalogue", "WEB 11401"},
    },
    visualMagnitude: 6.10,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.30223883),
        dec: Angle.Degrees(+18.72712766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186606"},
        {"Hipparcos Number", "HIP 97148"},
        {"Geneva Identification System", "GEN# +1.00186606"},
        {"Smithsonian Astrophysical Observation", "SAO 105205"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.18646932),
        dec: Angle.Degrees(+18.72843672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81032"},
        {"Smithsonian Astrophysical Observation", "SAO 102238"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.24775555),
        dec: Angle.Degrees(+18.72959880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17531"},
        {"Hipparcos Number", "HIP 13158"},
        {"Geneva Identification System", "GEN# +1.00017531"},
        {"Smithsonian Astrophysical Observation", "SAO 93126"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.29955095),
        dec: Angle.Degrees(+18.72985447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29403"},
        {"Hipparcos Number", "HIP 21621"},
        {"Smithsonian Astrophysical Observation", "SAO 94046"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.62940431),
        dec: Angle.Degrees(+18.73374518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30197"},
        {"Hipparcos Number", "HIP 22176"},
        {"Geneva Identification System", "GEN# +5.20250164"},
        {"Geneva Identification System 2", "GEN# +2.16470001"},
        {"Smithsonian Astrophysical Observation", "SAO 94112"},
        {"Wilson Evans Batten Catalogue", "WEB 4265"},
        {"New General Catalogue", "NGC 1647 1"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.56993252),
        dec: Angle.Degrees(+18.73486237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200617"},
        {"Hipparcos Number", "HIP 103970"},
        {"Smithsonian Astrophysical Observation", "SAO 106810"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.98395836),
        dec: Angle.Degrees(+18.73504750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114336",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16547 A"},
        {"Henry Draper", "HD 218624"},
        {"Hipparcos Number", "HIP 114336"},
        {"Smithsonian Astrophysical Observation", "SAO 108432"},
    },
    visualMagnitude: 6.75,
    bvColour: -0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.34447959),
        dec: Angle.Degrees(+18.73596124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82624"},
        {"Hipparcos Number", "HIP 46910"},
        {"Smithsonian Astrophysical Observation", "SAO 98640"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.41086790),
        dec: Angle.Degrees(+18.73661528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15588"},
        {"Smithsonian Astrophysical Observation", "SAO 93399"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.19364839),
        dec: Angle.Degrees(+18.73740784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16271",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16271"},
        {"Smithsonian Astrophysical Observation", "SAO 93455"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.44643652),
        dec: Angle.Degrees(+18.73849123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72764",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9423 AB"},
        {"Henry Draper", "HD 131334"},
        {"Hipparcos Number", "HIP 72764"},
        {"Geneva Identification System", "GEN# +1.00131334"},
        {"Smithsonian Astrophysical Observation", "SAO 101264"},
        {"Wilson Evans Batten Catalogue", "WEB 12504"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12521734),
        dec: Angle.Degrees(+18.73874423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 195.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129228"},
        {"Hipparcos Number", "HIP 71771"},
        {"Smithsonian Astrophysical Observation", "SAO 101142"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.21727980),
        dec: Angle.Degrees(+18.73924996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4913"},
        {"Hipparcos Number", "HIP 3998"},
        {"Cincinnati Publication", "Ci 18 112"},
        {"Geneva Identification System", "GEN# +1.00004913"},
        {"Smithsonian Astrophysical Observation", "SAO 92121"},
        {"Wilson Evans Batten Catalogue", "WEB 716"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.84050486),
        dec: Angle.Degrees(+18.73990110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -267.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188062"},
        {"Hipparcos Number", "HIP 97818"},
        {"Smithsonian Astrophysical Observation", "SAO 105371"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.16180865),
        dec: Angle.Degrees(+18.74069938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182489"},
        {"Hipparcos Number", "HIP 95384"},
        {"Celescope Catalog", "CEL 4743"},
        {"Geneva Identification System", "GEN# +1.00182489"},
        {"Smithsonian Astrophysical Observation", "SAO 104795"},
        {"Wilson Evans Batten Catalogue", "WEB 16670"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.05291092),
        dec: Angle.Degrees(+18.74119711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27429"},
        {"Hipparcos Number", "HIP 20255"},
        {"Geneva Identification System", "GEN# +5.20250032"},
        {"Renson", "Renson 7046"},
        {"Smithsonian Astrophysical Observation", "SAO 93874"},
        {"Wilson Evans Batten Catalogue", "WEB 3868"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.10431578),
        dec: Angle.Degrees(+18.74272543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82712",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82712"},
        {"Smithsonian Astrophysical Observation", "SAO 102465"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.60299219),
        dec: Angle.Degrees(+18.74348622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66851"},
        {"Hipparcos Number", "HIP 39644"},
        {"Smithsonian Astrophysical Observation", "SAO 97553"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51731944),
        dec: Angle.Degrees(+18.74640921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80699"},
        {"Hipparcos Number", "HIP 45917"},
        {"Geneva Identification System", "GEN# +1.00080699"},
        {"Smithsonian Astrophysical Observation", "SAO 98523"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.44647368),
        dec: Angle.Degrees(+18.74660926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224060"},
        {"Hipparcos Number", "HIP 117888"},
        {"Smithsonian Astrophysical Observation", "SAO 108902"},
        {"Wilson Evans Batten Catalogue", "WEB 20734"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.69817053),
        dec: Angle.Degrees(+18.74679281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43223",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43223"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.07401855),
        dec: Angle.Degrees(+18.74841412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114793"},
        {"Hipparcos Number", "HIP 64449"},
        {"Geneva Identification System", "GEN# +1.00114793"},
        {"Smithsonian Astrophysical Observation", "SAO 100461"},
        {"Wilson Evans Batten Catalogue", "WEB 11392"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.14978791),
        dec: Angle.Degrees(+18.75176987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82452"},
        {"Smithsonian Astrophysical Observation", "SAO 102426"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.74986200),
        dec: Angle.Degrees(+18.75333031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285892"},
        {"Hipparcos Number", "HIP 21467"},
        {"Geneva Identification System", "GEN# +1.00285892"},
        {"Wilson Evans Batten Catalogue", "WEB 4120"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.15698893),
        dec: Angle.Degrees(+18.75495912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103072"},
        {"Hipparcos Number", "HIP 57866"},
        {"Cincinnati Publication", "Ci 18 1469"},
        {"Geneva Identification System", "GEN# +1.00103072"},
        {"Smithsonian Astrophysical Observation", "SAO 99832"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.03466294),
        dec: Angle.Degrees(+18.75591791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -300.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21335"},
        {"Hipparcos Number", "HIP 16077"},
        {"Fundamental Katalog 5th Edition", "FK5 2242"},
        {"Geneva Identification System", "GEN# +1.00021335"},
        {"Smithsonian Astrophysical Observation", "SAO 93436"},
        {"Wilson Evans Batten Catalogue", "WEB 3068"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.76332029),
        dec: Angle.Degrees(+18.75654822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30630",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5054 A"},
        {"Henry Draper", "HD 45088"},
        {"Hipparcos Number", "HIP 30630"},
        {"Geneva Identification System", "GEN# +1.00045088"},
        {"Smithsonian Astrophysical Observation", "SAO 95677"},
        {"Wilson Evans Batten Catalogue", "WEB 6110"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.54301206),
        dec: Angle.Degrees(+18.75730314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36911"},
        {"Hipparcos Number", "HIP 26279"},
        {"Smithsonian Astrophysical Observation", "SAO 94678"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.93565153),
        dec: Angle.Degrees(+18.75816015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74780"},
        {"Hipparcos Number", "HIP 43086"},
        {"Smithsonian Astrophysical Observation", "SAO 98114"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.63874281),
        dec: Angle.Degrees(+18.76099327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245213"},
        {"Hipparcos Number", "HIP 26282"},
        {"Smithsonian Astrophysical Observation", "SAO 94679"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.94355840),
        dec: Angle.Degrees(+18.76223472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87867"},
        {"Hipparcos Number", "HIP 49656"},
        {"Geneva Identification System", "GEN# +1.00087867"},
        {"Smithsonian Astrophysical Observation", "SAO 98965"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.06107303),
        dec: Angle.Degrees(+18.76509726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127617"},
        {"Hipparcos Number", "HIP 71064"},
        {"Geneva Identification System", "GEN# +1.00127617"},
        {"Smithsonian Astrophysical Observation", "SAO 101067"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.99815801),
        dec: Angle.Degrees(+18.76690448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231142"},
        {"Hipparcos Number", "HIP 94935"},
        {"Smithsonian Astrophysical Observation", "SAO 104715"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.76694531),
        dec: Angle.Degrees(+18.76832618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100970",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13886 A"},
        {"Henry Draper", "HD 195019"},
        {"Hipparcos Number", "HIP 100970"},
        {"Geneva Identification System", "GEN# +1.00195019"},
        {"Smithsonian Astrophysical Observation", "SAO 106138"},
        {"Wilson Evans Batten Catalogue", "WEB 18239"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.07675395),
        dec: Angle.Degrees(+18.76963484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 349.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110513"},
        {"Hipparcos Number", "HIP 62019"},
        {"Geneva Identification System", "GEN# +1.00110513"},
        {"Smithsonian Astrophysical Observation", "SAO 100216"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.66752182),
        dec: Angle.Degrees(+18.77339698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101742"},
        {"Hipparcos Number", "HIP 57121"},
        {"Smithsonian Astrophysical Observation", "SAO 99747"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.65915935),
        dec: Angle.Degrees(+18.77345718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112756"},
        {"Smithsonian Astrophysical Observation", "SAO 108207"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.52772871),
        dec: Angle.Degrees(+18.77364593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13631",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13631"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.839,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.88386727),
        dec: Angle.Degrees(+18.77415085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 282.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142441"},
        {"Hipparcos Number", "HIP 77868"},
        {"Smithsonian Astrophysical Observation", "SAO 101801"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.50749153),
        dec: Angle.Degrees(+18.77528732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286207"},
        {"Hipparcos Number", "HIP 23401"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.44227227),
        dec: Angle.Degrees(+18.77741666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215107"},
        {"Hipparcos Number", "HIP 112116"},
        {"Smithsonian Astrophysical Observation", "SAO 108118"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.65181934),
        dec: Angle.Degrees(+18.77824378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16808 AB"},
        {"Henry Draper", "HD 221327"},
        {"Hipparcos Number", "HIP 116065"},
        {"Smithsonian Astrophysical Observation", "SAO 108654"},
        {"Wilson Evans Batten Catalogue", "WEB 20519"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.77147724),
        dec: Angle.Degrees(+18.77895521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9535"},
        {"Hipparcos Number", "HIP 7288"},
        {"Geneva Identification System", "GEN# +1.00009535"},
        {"Smithsonian Astrophysical Observation", "SAO 92515"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.47292376),
        dec: Angle.Degrees(+18.78018025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80082"},
        {"Hipparcos Number", "HIP 45648"},
        {"Smithsonian Astrophysical Observation", "SAO 98481"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.57050908),
        dec: Angle.Degrees(+18.78102688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63172"},
    },
    visualMagnitude: 11.10,
    bvColour: 1.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.14700325),
        dec: Angle.Degrees(+18.78139321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -332.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58854"},
        {"Geneva Identification System", "GEN# +0.01902527"},
        {"Wilson Evans Batten Catalogue", "WEB 10485"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.06333999),
        dec: Angle.Degrees(+18.78242632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191498"},
        {"Hipparcos Number", "HIP 99317"},
        {"Smithsonian Astrophysical Observation", "SAO 105768"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.39328343),
        dec: Angle.Degrees(+18.78251621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46281"},
        {"Hipparcos Number", "HIP 31258"},
        {"Smithsonian Astrophysical Observation", "SAO 95826"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.34057922),
        dec: Angle.Degrees(+18.78272167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285289"},
        {"Hipparcos Number", "HIP 18820"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.49670820),
        dec: Angle.Degrees(+18.78699358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3054"},
        {"Hipparcos Number", "HIP 2678"},
        {"Smithsonian Astrophysical Observation", "SAO 91969"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.48620197),
        dec: Angle.Degrees(+18.78820737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62947"},
        {"Hipparcos Number", "HIP 37984"},
        {"Smithsonian Astrophysical Observation", "SAO 97234"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.77944944),
        dec: Angle.Degrees(+18.78866829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79820",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79820"},
        {"Smithsonian Astrophysical Observation", "SAO 102063"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.37112625),
        dec: Angle.Degrees(+18.78942389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4906"},
        {"Hipparcos Number", "HIP 3985"},
        {"Cincinnati Publication", "Ci 18 110"},
        {"Geneva Identification System", "GEN# +1.00004906"},
        {"Smithsonian Astrophysical Observation", "SAO 92118"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.80902948),
        dec: Angle.Degrees(+18.79089929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46299"},
        {"Hipparcos Number", "HIP 31261"},
        {"Smithsonian Astrophysical Observation", "SAO 95827"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.34682748),
        dec: Angle.Degrees(+18.79117505)
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
    primaryId: "HIP 27191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38336"},
        {"Hipparcos Number", "HIP 27191"},
        {"Smithsonian Astrophysical Observation", "SAO 94839"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.45512624),
        dec: Angle.Degrees(+18.79245220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41658"},
        {"Hipparcos Number", "HIP 29013"},
        {"Geneva Identification System", "GEN# +1.00041658J"},
        {"Smithsonian Astrophysical Observation", "SAO 95252"},
        {"Wilson Evans Batten Catalogue", "WEB 5680"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.83325712),
        dec: Angle.Degrees(+18.79379819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79661"},
        {"Hipparcos Number", "HIP 45456"},
        {"Geneva Identification System", "GEN# +1.00079661"},
        {"Smithsonian Astrophysical Observation", "SAO 98460"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.96191021),
        dec: Angle.Degrees(+18.79448046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2911"},
        {"Hipparcos Number", "HIP 2560"},
        {"Geneva Identification System", "GEN# +1.00002911"},
        {"Smithsonian Astrophysical Observation", "SAO 91953"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.13301412),
        dec: Angle.Degrees(+18.79507188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19460"},
        {"Hipparcos Number", "HIP 14586"},
        {"Fundamental Katalog 5th Edition", "FK5 4285"},
        {"Geneva Identification System", "GEN# +1.00019460"},
        {"Smithsonian Astrophysical Observation", "SAO 93293"},
        {"Wilson Evans Batten Catalogue", "WEB 2835"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.08785703),
        dec: Angle.Degrees(+18.79508747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83626"},
        {"Smithsonian Astrophysical Observation", "SAO 102590"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.36312976),
        dec: Angle.Degrees(+18.79587957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49324"},
        {"Geneva Identification System", "GEN# +9.80042035"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.02529966),
        dec: Angle.Degrees(+18.79643566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -153.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -225.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210483"},
        {"Hipparcos Number", "HIP 109450"},
        {"Cincinnati Publication", "Ci 18 2888"},
        {"Geneva Identification System", "GEN# +1.00210483"},
        {"Smithsonian Astrophysical Observation", "SAO 107708"},
        {"Wilson Evans Batten Catalogue", "WEB 19666"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.60810253),
        dec: Angle.Degrees(+18.79717511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 353.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347879"},
        {"Hipparcos Number", "HIP 88503"},
        {"Smithsonian Astrophysical Observation", "SAO 103353"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.08542065),
        dec: Angle.Degrees(+18.79741693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49635"},
        {"Henry Draper 2", "HD 49636"},
        {"Hipparcos Number", "HIP 32797"},
        {"Geneva Identification System", "GEN# +1.00049635"},
        {"Smithsonian Astrophysical Observation", "SAO 96172"},
        {"Wilson Evans Batten Catalogue", "WEB 6604"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.55836673),
        dec: Angle.Degrees(+18.79801176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16374"},
        {"Smithsonian Astrophysical Observation", "SAO 93468"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.73341480),
        dec: Angle.Degrees(+18.79958984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21836"},
        {"Hipparcos Number", "HIP 16441"},
        {"Smithsonian Astrophysical Observation", "SAO 93476"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.93251513),
        dec: Angle.Degrees(+18.80015320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50951"},
        {"Hipparcos Number", "HIP 33350"},
        {"Smithsonian Astrophysical Observation", "SAO 96283"},
    },
    visualMagnitude: 8.09,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.04906573),
        dec: Angle.Degrees(+18.80017164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2042 AB"},
        {"Henry Draper", "HD 16694"},
        {"Hipparcos Number", "HIP 12518"},
        {"Geneva Identification System", "GEN# +1.00016694J"},
        {"Smithsonian Astrophysical Observation", "SAO 93052"},
        {"Wilson Evans Batten Catalogue", "WEB 2560"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.27747796),
        dec: Angle.Degrees(+18.80020649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30179"},
        {"Hipparcos Number", "HIP 22161"},
        {"Geneva Identification System", "GEN# +2.16470002"},
        {"Smithsonian Astrophysical Observation", "SAO 94110"},
        {"New General Catalogue", "NGC 1647 2"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.52125250),
        dec: Angle.Degrees(+18.80074321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38899"},
        {"Smithsonian Astrophysical Observation", "SAO 97416"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.41129520),
        dec: Angle.Degrees(+18.80229626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50375",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50375"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.28476638),
        dec: Angle.Degrees(+18.80311148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84841"},
        {"Hipparcos Number", "HIP 48103"},
        {"Geneva Identification System", "GEN# +1.00084841"},
        {"Smithsonian Astrophysical Observation", "SAO 98775"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.11244754),
        dec: Angle.Degrees(+18.80625603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 254236"},
        {"Hipparcos Number", "HIP 29796"},
        {"Smithsonian Astrophysical Observation", "SAO 95471"},
        {"Wilson Evans Batten Catalogue", "WEB 5888"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.09826943),
        dec: Angle.Degrees(+18.80712204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146388"},
        {"Hipparcos Number", "HIP 79666"},
        {"Geneva Identification System", "GEN# +1.00146388"},
        {"Smithsonian Astrophysical Observation", "SAO 102040"},
        {"Wilson Evans Batten Catalogue", "WEB 13482"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.86948873),
        dec: Angle.Degrees(+18.80829264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79765"},
        {"Hipparcos Number", "HIP 45510"},
        {"Cincinnati Publication", "Ci 18 1094"},
        {"Fundamental Katalog 5th Edition", "FK5 4824"},
        {"Geneva Identification System", "GEN# +1.00079765"},
        {"Smithsonian Astrophysical Observation", "SAO 98468"},
        {"Wilson Evans Batten Catalogue", "WEB 8654"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.11337748),
        dec: Angle.Degrees(+18.81028589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188102"},
        {"Hipparcos Number", "HIP 97840"},
        {"Smithsonian Astrophysical Observation", "SAO 105375"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.22552838),
        dec: Angle.Degrees(+18.81167375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230885"},
        {"Hipparcos Number", "HIP 94396"},
        {"Smithsonian Astrophysical Observation", "SAO 104608"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18738957),
        dec: Angle.Degrees(+18.81234974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 166.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110368"},
        {"Smithsonian Astrophysical Observation", "SAO 107851"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.32017858),
        dec: Angle.Degrees(+18.81289357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185336"},
        {"Hipparcos Number", "HIP 96565"},
        {"Smithsonian Astrophysical Observation", "SAO 105073"},
        {"Wilson Evans Batten Catalogue", "WEB 16945"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.46740388),
        dec: Angle.Degrees(+18.81311825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45413"},
        {"Hipparcos Number", "HIP 30773"},
        {"Geneva Identification System", "GEN# +1.00045413"},
        {"Smithsonian Astrophysical Observation", "SAO 95707"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.99393600),
        dec: Angle.Degrees(+18.81366070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55823"},
        {"Hipparcos Number", "HIP 35082"},
        {"Smithsonian Astrophysical Observation", "SAO 96687"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.83299967),
        dec: Angle.Degrees(+18.81459983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141220"},
        {"Hipparcos Number", "HIP 77351"},
        {"Smithsonian Astrophysical Observation", "SAO 101740"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.85756243),
        dec: Angle.Degrees(+18.81469841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104785"},
        {"Hipparcos Number", "HIP 58831"},
        {"Geneva Identification System", "GEN# +1.00104785"},
        {"Smithsonian Astrophysical Observation", "SAO 99927"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.00447378),
        dec: Angle.Degrees(+18.81478279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74607"},
        {"Hipparcos Number", "HIP 42970"},
        {"Geneva Identification System", "GEN# +1.00074607"},
        {"Smithsonian Astrophysical Observation", "SAO 98098"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.37353467),
        dec: Angle.Degrees(+18.81748568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36831",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36831"},
        {"Smithsonian Astrophysical Observation", "SAO 97026"},
    },
    visualMagnitude: 9.64,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61689579),
        dec: Angle.Degrees(+18.81815082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40331"},
        {"Hipparcos Number", "HIP 28307"},
        {"Fundamental Katalog 5th Edition", "FK5 4543"},
        {"Smithsonian Astrophysical Observation", "SAO 95070"},
        {"Wilson Evans Batten Catalogue", "WEB 5534"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72826576),
        dec: Angle.Degrees(+18.82021023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285842"},
        {"Hipparcos Number", "HIP 21089"},
        {"Geneva Identification System", "GEN# +5.20257248"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.79347689),
        dec: Angle.Degrees(+18.82026827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67510"},
        {"Geneva Identification System", "GEN# +0.01902718"},
        {"Smithsonian Astrophysical Observation", "SAO 100731"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.50285665),
        dec: Angle.Degrees(+18.82073521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100387"},
        {"Hipparcos Number", "HIP 56360"},
        {"Smithsonian Astrophysical Observation", "SAO 99659"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.30367151),
        dec: Angle.Degrees(+18.82100629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85932"},
        {"Hipparcos Number", "HIP 48670"},
        {"Geneva Identification System", "GEN# +1.00085932"},
        {"Smithsonian Astrophysical Observation", "SAO 98846"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.89269833),
        dec: Angle.Degrees(+18.82132785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102618"},
        {"Hipparcos Number", "HIP 57617"},
        {"Geneva Identification System", "GEN# +1.00102618"},
        {"Smithsonian Astrophysical Observation", "SAO 99802"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.21389105),
        dec: Angle.Degrees(+18.82310296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161180"},
        {"Hipparcos Number", "HIP 86727"},
        {"Smithsonian Astrophysical Observation", "SAO 103053"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.82695858),
        dec: Angle.Degrees(+18.82406930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112040"},
    },
    visualMagnitude: 10.82,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.39517621),
        dec: Angle.Degrees(+18.82416945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255957"},
        {"Hipparcos Number", "HIP 30312"},
        {"Smithsonian Astrophysical Observation", "SAO 95594"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.62350869),
        dec: Angle.Degrees(+18.82467329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64072"},
        {"Hipparcos Number", "HIP 38465"},
        {"Geneva Identification System", "GEN# +1.00064072"},
        {"Smithsonian Astrophysical Observation", "SAO 97327"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.18998783),
        dec: Angle.Degrees(+18.82705967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94702"},
        {"Hipparcos Number", "HIP 53459"},
        {"Smithsonian Astrophysical Observation", "SAO 99361"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.04199924),
        dec: Angle.Degrees(+18.82788498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75469"},
        {"Hipparcos Number", "HIP 43427"},
        {"Geneva Identification System", "GEN# +1.00075469"},
        {"Smithsonian Astrophysical Observation", "SAO 98162"},
        {"Wilson Evans Batten Catalogue", "WEB 8371"},
    },
    visualMagnitude: 6.41,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.68804465),
        dec: Angle.Degrees(+18.83223974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71324",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71324"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.78199362),
        dec: Angle.Degrees(+18.83275598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209346"},
        {"Hipparcos Number", "HIP 108793"},
        {"Geneva Identification System", "GEN# +1.00209346"},
        {"Smithsonian Astrophysical Observation", "SAO 107607"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.58879648),
        dec: Angle.Degrees(+18.83311793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139215"},
        {"Hipparcos Number", "HIP 76408"},
        {"Smithsonian Astrophysical Observation", "SAO 101638"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.07893242),
        dec: Angle.Degrees(+18.83436781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225013"},
        {"Hipparcos Number", "HIP 206"},
        {"Smithsonian Astrophysical Observation", "SAO 91673"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.64683993),
        dec: Angle.Degrees(+18.83599601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127667"},
        {"Hipparcos Number", "HIP 71076"},
        {"Geneva Identification System", "GEN# +1.00127667"},
        {"Smithsonian Astrophysical Observation", "SAO 101068"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.01946757),
        dec: Angle.Degrees(+18.83604225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111272"},
        {"Hipparcos Number", "HIP 62459"},
        {"Geneva Identification System", "GEN# +1.00111272"},
        {"Smithsonian Astrophysical Observation", "SAO 100268"},
        {"Wilson Evans Batten Catalogue", "WEB 11088"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.00158898),
        dec: Angle.Degrees(+18.83685148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191202"},
        {"Hipparcos Number", "HIP 99172"},
        {"Smithsonian Astrophysical Observation", "SAO 105732"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.00827157),
        dec: Angle.Degrees(+18.83693103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203290"},
        {"Hipparcos Number", "HIP 105383"},
        {"Geneva Identification System", "GEN# +1.00203290"},
        {"Smithsonian Astrophysical Observation", "SAO 107055"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.19094174),
        dec: Angle.Degrees(+18.83727333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48864"},
        {"Hipparcos Number", "HIP 32451"},
        {"Smithsonian Astrophysical Observation", "SAO 96089"},
        {"Wilson Evans Batten Catalogue", "WEB 6544"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.58788954),
        dec: Angle.Degrees(+18.83772705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96181"},
        {"Hipparcos Number", "HIP 54229"},
        {"Geneva Identification System", "GEN# +1.00096181"},
        {"Smithsonian Astrophysical Observation", "SAO 99432"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.43561168),
        dec: Angle.Degrees(+18.83787253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17221"},
        {"Hipparcos Number", "HIP 12932"},
        {"Geneva Identification System", "GEN# +1.00017221"},
        {"Smithsonian Astrophysical Observation", "SAO 93095"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58458558),
        dec: Angle.Degrees(+18.83794724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30780"},
        {"Hipparcos Number", "HIP 22565"},
        {"Fundamental Katalog 5th Edition", "FK5 1135"},
        {"Geneva Identification System", "GEN# +5.20250123"},
        {"Renson", "Renson 7950"},
        {"Smithsonian Astrophysical Observation", "SAO 94164"},
        {"Wilson Evans Batten Catalogue", "WEB 4361"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.84338884),
        dec: Angle.Degrees(+18.83994085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13845"},
        {"Hipparcos Number", "HIP 10496"},
        {"Smithsonian Astrophysical Observation", "SAO 92856"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.83373777),
        dec: Angle.Degrees(+18.84135337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66552"},
        {"Hipparcos Number", "HIP 39535"},
        {"Geneva Identification System", "GEN# +1.00066552"},
        {"Smithsonian Astrophysical Observation", "SAO 97537"},
        {"Wilson Evans Batten Catalogue", "WEB 7728"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.18882813),
        dec: Angle.Degrees(+18.84206757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65666"},
        {"Hipparcos Number", "HIP 39158"},
        {"Smithsonian Astrophysical Observation", "SAO 97463"},
    },
    visualMagnitude: 7.10,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.13509364),
        dec: Angle.Degrees(+18.84315346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54511"},
        {"Hipparcos Number", "HIP 34594"},
        {"Smithsonian Astrophysical Observation", "SAO 96575"},
    },
    visualMagnitude: 7.71,
    bvColour: -0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.48146443),
        dec: Angle.Degrees(+18.84430665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146698"},
        {"Hipparcos Number", "HIP 79783"},
        {"Smithsonian Astrophysical Observation", "SAO 102059"},
        {"Wilson Evans Batten Catalogue", "WEB 13506"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.23980545),
        dec: Angle.Degrees(+18.84603922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243814"},
        {"Hipparcos Number", "HIP 25523"},
        {"Geneva Identification System", "GEN# +0.01800854"},
        {"Geneva Identification System 2", "GEN# +1.00243814"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.87496560),
        dec: Angle.Degrees(+18.84642874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -346.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180940"},
        {"Hipparcos Number", "HIP 94837"},
        {"Smithsonian Astrophysical Observation", "SAO 104692"},
        {"Wilson Evans Batten Catalogue", "WEB 16553"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.45797821),
        dec: Angle.Degrees(+18.84861828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77352",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77352"},
        {"Smithsonian Astrophysical Observation", "SAO 101741"},
    },
    visualMagnitude: 8.20,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.85765275),
        dec: Angle.Degrees(+18.84943080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348806"},
        {"Hipparcos Number", "HIP 90827"},
        {"Smithsonian Astrophysical Observation", "SAO 103814"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.93565443),
        dec: Angle.Degrees(+18.85067433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157702"},
        {"Hipparcos Number", "HIP 85146"},
        {"Smithsonian Astrophysical Observation", "SAO 102795"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.00040397),
        dec: Angle.Degrees(+18.85089030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40426"},
        {"Hipparcos Number", "HIP 28359"},
        {"Smithsonian Astrophysical Observation", "SAO 95090"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.88245899),
        dec: Angle.Degrees(+18.85213883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6215"},
        {"Hipparcos Number", "HIP 4938"},
        {"Geneva Identification System", "GEN# +1.00006215"},
        {"Smithsonian Astrophysical Observation", "SAO 92221"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.84630247),
        dec: Angle.Degrees(+18.85322693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136097"},
        {"Hipparcos Number", "HIP 74888"},
        {"Smithsonian Astrophysical Observation", "SAO 101479"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.56851735),
        dec: Angle.Degrees(+18.85484518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102927"},
        {"Hipparcos Number", "HIP 57794"},
        {"Geneva Identification System", "GEN# +1.00102927"},
        {"Smithsonian Astrophysical Observation", "SAO 99828"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.76389228),
        dec: Angle.Degrees(+18.85631759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55074",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55074"},
        {"Smithsonian Astrophysical Observation", "SAO 99529"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.13275226),
        dec: Angle.Degrees(+18.85649562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92483"},
        {"Hipparcos Number", "HIP 52282"},
        {"Smithsonian Astrophysical Observation", "SAO 99247"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.25061468),
        dec: Angle.Degrees(+18.85864235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69091"},
        {"Geneva Identification System", "GEN# +0.01902758"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.11752745),
        dec: Angle.Degrees(+18.85894114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1389"},
    },
    visualMagnitude: 10.51,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.34287420),
        dec: Angle.Degrees(+18.85956477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 533.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27218",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4355 AB"},
        {"Henry Draper", "HD 38377"},
        {"Hipparcos Number", "HIP 27218"},
        {"Geneva Identification System", "GEN# +1.00038377J"},
        {"Smithsonian Astrophysical Observation", "SAO 94840"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.53513176),
        dec: Angle.Degrees(+18.86060157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212548"},
        {"Hipparcos Number", "HIP 110638"},
        {"Smithsonian Astrophysical Observation", "SAO 107895"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.18753851),
        dec: Angle.Degrees(+18.86312628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84252"},
        {"Hipparcos Number", "HIP 47779"},
        {"Smithsonian Astrophysical Observation", "SAO 98742"},
        {"Wilson Evans Batten Catalogue", "WEB 8946"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.12501707),
        dec: Angle.Degrees(+18.86362650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20686",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3210 AB"},
        {"Henry Draper", "HD 27989"},
        {"Hipparcos Number", "HIP 20686"},
        {"Geneva Identification System", "GEN# +5.20250058J"},
        {"Smithsonian Astrophysical Observation", "SAO 93926"},
        {"Wilson Evans Batten Catalogue", "WEB 3965"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.46524697),
        dec: Angle.Degrees(+18.86414516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187321"},
        {"Henry Draper 2", "HD 187322"},
        {"Hipparcos Number", "HIP 97476"},
        {"Smithsonian Astrophysical Observation", "SAO 105288"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.856,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.18181457),
        dec: Angle.Degrees(+18.86705896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108187"},
        {"Hipparcos Number", "HIP 60631"},
        {"Geneva Identification System", "GEN# +1.00108187"},
        {"Smithsonian Astrophysical Observation", "SAO 100093"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.39018593),
        dec: Angle.Degrees(+18.86710353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215992"},
        {"Hipparcos Number", "HIP 112644"},
        {"Smithsonian Astrophysical Observation", "SAO 108196"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.21761789),
        dec: Angle.Degrees(+18.86901040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169928"},
        {"Hipparcos Number", "HIP 90357"},
        {"Geneva Identification System", "GEN# +1.00169928"},
        {"Smithsonian Astrophysical Observation", "SAO 103715"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.56466745),
        dec: Angle.Degrees(+18.86943436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352661"},
        {"Hipparcos Number", "HIP 101864"},
        {"Smithsonian Astrophysical Observation", "SAO 106337"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.62487212),
        dec: Angle.Degrees(+18.86968316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73135"},
        {"Hipparcos Number", "HIP 42284"},
        {"Renson", "Renson 20320"},
        {"Smithsonian Astrophysical Observation", "SAO 97971"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.32597154),
        dec: Angle.Degrees(+18.86997397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229358"},
        {"Hipparcos Number", "HIP 91963"},
        {"Smithsonian Astrophysical Observation", "SAO 104055"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.17304412),
        dec: Angle.Degrees(+18.87377096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16674"},
        {"Smithsonian Astrophysical Observation", "SAO 93495"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.64553168),
        dec: Angle.Degrees(+18.87395813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216786"},
        {"Hipparcos Number", "HIP 113217"},
        {"Smithsonian Astrophysical Observation", "SAO 108262"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.91771220),
        dec: Angle.Degrees(+18.87521092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74589"},
        {"Hipparcos Number", "HIP 42952"},
        {"Geneva Identification System", "GEN# +1.00074589"},
        {"Smithsonian Astrophysical Observation", "SAO 98094"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.33563256),
        dec: Angle.Degrees(+18.87542726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117283"},
        {"Hipparcos Number", "HIP 65770"},
        {"Geneva Identification System", "GEN# +1.00117283"},
        {"Smithsonian Astrophysical Observation", "SAO 100589"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.25893092),
        dec: Angle.Degrees(+18.87630562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88067",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88067"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.79788820),
        dec: Angle.Degrees(+18.87664335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347950"},
        {"Hipparcos Number", "HIP 88808"},
        {"Smithsonian Astrophysical Observation", "SAO 103407"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.93901755),
        dec: Angle.Degrees(+18.87798533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15869"},
        {"Hipparcos Number", "HIP 11904"},
        {"Geneva Identification System", "GEN# +1.00015869"},
        {"Smithsonian Astrophysical Observation", "SAO 93002"},
        {"Wilson Evans Batten Catalogue", "WEB 2462"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.40198648),
        dec: Angle.Degrees(+18.87999013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186981"},
        {"Hipparcos Number", "HIP 97331"},
        {"Geneva Identification System", "GEN# +1.00186981"},
        {"Smithsonian Astrophysical Observation", "SAO 105245"},
        {"Wilson Evans Batten Catalogue", "WEB 17105"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.72006312),
        dec: Angle.Degrees(+18.88185962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16136",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16136"},
        {"Smithsonian Astrophysical Observation", "SAO 93442"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.98040081),
        dec: Angle.Degrees(+18.88248201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73045"},
        {"Hipparcos Number", "HIP 42247"},
        {"Geneva Identification System", "GEN# +2.26320538"},
        {"Renson", "Renson 20280"},
        {"Smithsonian Astrophysical Observation", "SAO 97965"},
        {"Wilson Evans Batten Catalogue", "WEB 8117"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.20010576),
        dec: Angle.Degrees(+18.88283422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285763"},
        {"Hipparcos Number", "HIP 20646"},
        {"Smithsonian Astrophysical Observation", "SAO 93921"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.36611977),
        dec: Angle.Degrees(+18.88431270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86063"},
        {"Geneva Identification System", "GEN# +0.01803407"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.83266935),
        dec: Angle.Degrees(+18.88435928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209458"},
        {"Hipparcos Number", "HIP 108859"},
        {"Geneva Identification System", "GEN# +1.00209458"},
        {"Smithsonian Astrophysical Observation", "SAO 107623"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.79481049),
        dec: Angle.Degrees(+18.88436326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130025"},
        {"Hipparcos Number", "HIP 72139"},
        {"Geneva Identification System", "GEN# +1.00130025"},
        {"Smithsonian Astrophysical Observation", "SAO 101187"},
        {"Wilson Evans Batten Catalogue", "WEB 12414"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.33573087),
        dec: Angle.Degrees(+18.88490995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97386"},
        {"Hipparcos Number", "HIP 54755"},
        {"Smithsonian Astrophysical Observation", "SAO 99498"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.16389226),
        dec: Angle.Degrees(+18.88686570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78849"},
        {"Hipparcos Number", "HIP 45074"},
        {"Smithsonian Astrophysical Observation", "SAO 98416"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.72206941),
        dec: Angle.Degrees(+18.88866854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161921"},
        {"Hipparcos Number", "HIP 87069"},
        {"Smithsonian Astrophysical Observation", "SAO 103110"},
        {"Wilson Evans Batten Catalogue", "WEB 14689"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.88279857),
        dec: Angle.Degrees(+18.88935104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108300"},
        {"Hipparcos Number", "HIP 60706"},
        {"Geneva Identification System", "GEN# +1.00108300"},
        {"Smithsonian Astrophysical Observation", "SAO 100098"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.62668211),
        dec: Angle.Degrees(+18.89033510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93257"},
        {"Hipparcos Number", "HIP 52686"},
        {"Fundamental Katalog 5th Edition", "FK5 1279"},
        {"Geneva Identification System", "GEN# +1.00093257"},
        {"Smithsonian Astrophysical Observation", "SAO 99281"},
        {"Wilson Evans Batten Catalogue", "WEB 9594"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.60202972),
        dec: Angle.Degrees(+18.89162177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148206"},
        {"Hipparcos Number", "HIP 80488"},
        {"Geneva Identification System", "GEN# +1.00148206"},
        {"Smithsonian Astrophysical Observation", "SAO 102160"},
        {"Wilson Evans Batten Catalogue", "WEB 13622"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.44784021),
        dec: Angle.Degrees(+18.89248689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2728",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2728"},
        {"Smithsonian Astrophysical Observation", "SAO 91977"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.71254043),
        dec: Angle.Degrees(+18.89299488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134248"},
        {"Hipparcos Number", "HIP 74068"},
        {"Geneva Identification System", "GEN# +1.00134248"},
        {"Smithsonian Astrophysical Observation", "SAO 101395"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.647,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05386286),
        dec: Angle.Degrees(+18.89319880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26711"},
        {"Hipparcos Number", "HIP 19763"},
        {"Geneva Identification System", "GEN# +1.00026711"},
        {"Smithsonian Astrophysical Observation", "SAO 93825"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.56229774),
        dec: Angle.Degrees(+18.89403430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75699"},
        {"Hipparcos Number", "HIP 43540"},
        {"Smithsonian Astrophysical Observation", "SAO 98182"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.01489964),
        dec: Angle.Degrees(+18.89438191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6360"},
        {"Hipparcos Number", "HIP 5071"},
        {"Geneva Identification System", "GEN# +1.00006360"},
        {"Smithsonian Astrophysical Observation", "SAO 92228"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.20806662),
        dec: Angle.Degrees(+18.89493807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120772"},
        {"Hipparcos Number", "HIP 67614"},
        {"Smithsonian Astrophysical Observation", "SAO 100739"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.81499712),
        dec: Angle.Degrees(+18.89515340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17421"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.98629702),
        dec: Angle.Degrees(+18.89618885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 243081"},
        {"Hipparcos Number", "HIP 25154"},
        {"Smithsonian Astrophysical Observation", "SAO 94504"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.74817654),
        dec: Angle.Degrees(+18.89864132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2730",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2730"},
        {"Smithsonian Astrophysical Observation", "SAO 91979"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.72237245),
        dec: Angle.Degrees(+18.90010037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4490 AB"},
        {"Henry Draper", "HD 39588"},
        {"Hipparcos Number", "HIP 27911"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.59323732),
        dec: Angle.Degrees(+18.90045160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151995"},
        {"Hipparcos Number", "HIP 82389"},
        {"Geneva Identification System", "GEN# +1.00151995"},
        {"Smithsonian Astrophysical Observation", "SAO 102421"},
        {"Wilson Evans Batten Catalogue", "WEB 13909"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.52213546),
        dec: Angle.Degrees(+18.90058890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81418"},
        {"Hipparcos Number", "HIP 46272"},
        {"Smithsonian Astrophysical Observation", "SAO 98565"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.51124734),
        dec: Angle.Degrees(+18.90064151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2975",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2975"},
        {"Smithsonian Astrophysical Observation", "SAO 92003"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.46373286),
        dec: Angle.Degrees(+18.90078001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4538"},
        {"Hipparcos Number", "HIP 3705"},
        {"Smithsonian Astrophysical Observation", "SAO 92085"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.89138173),
        dec: Angle.Degrees(+18.90105369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108613"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.03354982),
        dec: Angle.Degrees(+18.90142963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210957"},
        {"Hipparcos Number", "HIP 109729"},
        {"Geneva Identification System", "GEN# +1.00210957"},
        {"Smithsonian Astrophysical Observation", "SAO 107745"},
        {"Wilson Evans Batten Catalogue", "WEB 19712"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.41088181),
        dec: Angle.Degrees(+18.90280553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22225"},
        {"Hipparcos Number", "HIP 16737"},
        {"Geneva Identification System", "GEN# +1.00022225"},
        {"Smithsonian Astrophysical Observation", "SAO 93501"},
        {"Wilson Evans Batten Catalogue", "WEB 3186"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.82653314),
        dec: Angle.Degrees(+18.90317971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115381"},
        {"Hipparcos Number", "HIP 64781"},
        {"Geneva Identification System", "GEN# +1.00115381"},
        {"Smithsonian Astrophysical Observation", "SAO 100489"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.15309873),
        dec: Angle.Degrees(+18.90325985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88015"},
        {"Fundamental Katalog 5th Edition", "FK5 5583"},
        {"Smithsonian Astrophysical Observation", "SAO 103264"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66780625),
        dec: Angle.Degrees(+18.90438894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15084"},
        {"Hipparcos Number", "HIP 11355"},
        {"Geneva Identification System", "GEN# +1.00015084"},
        {"Smithsonian Astrophysical Observation", "SAO 92946"},
        {"Wilson Evans Batten Catalogue", "WEB 2372"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.55876026),
        dec: Angle.Degrees(+18.90526577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285441"},
        {"Hipparcos Number", "HIP 19403"},
        {"Smithsonian Astrophysical Observation", "SAO 93788"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.34413141),
        dec: Angle.Degrees(+18.90678484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34926"},
        {"Hipparcos Number", "HIP 25035"},
        {"Fundamental Katalog 5th Edition", "FK5 4490"},
        {"Geneva Identification System", "GEN# +1.00034926"},
        {"Smithsonian Astrophysical Observation", "SAO 94488"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.41630461),
        dec: Angle.Degrees(+18.90681601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218807"},
        {"Hipparcos Number", "HIP 114450"},
        {"Cincinnati Publication", "Ci 18 3032"},
        {"Geneva Identification System", "GEN# +1.00218807"},
        {"Smithsonian Astrophysical Observation", "SAO 108444"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.68173907),
        dec: Angle.Degrees(+18.90950188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57978"},
        {"Hipparcos Number", "HIP 35928"},
        {"Smithsonian Astrophysical Observation", "SAO 96864"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.10188972),
        dec: Angle.Degrees(+18.91029313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90649"},
        {"Hipparcos Number", "HIP 51264"},
        {"Smithsonian Astrophysical Observation", "SAO 99142"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.07581648),
        dec: Angle.Degrees(+18.91249706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27877"},
        {"Hipparcos Number", "HIP 20600"},
        {"Geneva Identification System", "GEN# +1.00027877"},
        {"Smithsonian Astrophysical Observation", "SAO 93915"},
        {"Wilson Evans Batten Catalogue", "WEB 3946"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.17897407),
        dec: Angle.Degrees(+18.91311358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171286"},
        {"Hipparcos Number", "HIP 90955"},
        {"Fundamental Katalog 5th Edition", "FK5 5630"},
        {"Smithsonian Astrophysical Observation", "SAO 103839"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.31107027),
        dec: Angle.Degrees(+18.91573202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205437"},
        {"Hipparcos Number", "HIP 106563"},
        {"Geneva Identification System", "GEN# +1.00205437"},
        {"Smithsonian Astrophysical Observation", "SAO 107252"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.72065356),
        dec: Angle.Degrees(+18.91718251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183301"},
        {"Hipparcos Number", "HIP 95721"},
        {"Geneva Identification System", "GEN# +1.00183301"},
        {"Smithsonian Astrophysical Observation", "SAO 104875"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.05038177),
        dec: Angle.Degrees(+18.91747925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24262"},
        {"Hipparcos Number", "HIP 18110"},
        {"Smithsonian Astrophysical Observation", "SAO 93643"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.07767591),
        dec: Angle.Degrees(+18.91767228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60915"},
        {"Hipparcos Number", "HIP 37107"},
        {"Geneva Identification System", "GEN# +1.00060915"},
        {"Smithsonian Astrophysical Observation", "SAO 97087"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.37708491),
        dec: Angle.Degrees(+18.91801725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190514"},
        {"Hipparcos Number", "HIP 98871"},
        {"Smithsonian Astrophysical Observation", "SAO 105649"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.17998512),
        dec: Angle.Degrees(+18.91823971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136923"},
        {"Hipparcos Number", "HIP 75277"},
        {"Cincinnati Publication", "Ci 18 2058"},
        {"Geneva Identification System", "GEN# +1.00136923"},
        {"Smithsonian Astrophysical Observation", "SAO 101515"},
        {"Wilson Evans Batten Catalogue", "WEB 12841"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.804,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.69573224),
        dec: Angle.Degrees(+18.91877181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115166"},
        {"Hipparcos Number", "HIP 64654"},
        {"Geneva Identification System", "GEN# +1.00115166"},
        {"Smithsonian Astrophysical Observation", "SAO 100476"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.79266577),
        dec: Angle.Degrees(+18.91888227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55333"},
        {"Hipparcos Number", "HIP 34900"},
        {"Smithsonian Astrophysical Observation", "SAO 96635"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.31031376),
        dec: Angle.Degrees(+18.92137601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150632"},
        {"Hipparcos Number", "HIP 81721"},
        {"Smithsonian Astrophysical Observation", "SAO 102321"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.38809463),
        dec: Angle.Degrees(+18.92146579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248236"},
        {"Hipparcos Number", "HIP 27594"},
        {"Smithsonian Astrophysical Observation", "SAO 94905"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.64595378),
        dec: Angle.Degrees(+18.92252714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267021"},
        {"Hipparcos Number", "HIP 33524"},
        {"Smithsonian Astrophysical Observation", "SAO 96323"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.51293986),
        dec: Angle.Degrees(+18.92646101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85115",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85115"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.93055982),
        dec: Angle.Degrees(+18.92812727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83083"},
        {"Hipparcos Number", "HIP 47148"},
        {"Smithsonian Astrophysical Observation", "SAO 98668"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.10868648),
        dec: Angle.Degrees(+18.92864002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6961"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.40133135),
        dec: Angle.Degrees(+18.92954646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -141.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57949",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57949"},
        {"Geneva Identification System", "GEN# +6.20030622"},
    },
    visualMagnitude: 11.70,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.27181443),
        dec: Angle.Degrees(+18.92983268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110951",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110951"},
    },
    visualMagnitude: 10.73,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.19097878),
        dec: Angle.Degrees(+18.93200777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47837"},
        {"Hipparcos Number", "HIP 32023"},
        {"Smithsonian Astrophysical Observation", "SAO 95993"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.34538168),
        dec: Angle.Degrees(+18.93328955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74050"},
        {"Hipparcos Number", "HIP 42705"},
        {"Geneva Identification System", "GEN# +2.26320449"},
        {"Smithsonian Astrophysical Observation", "SAO 98054"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.54512363),
        dec: Angle.Degrees(+18.93440618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102715"},
        {"Hipparcos Number", "HIP 57666"},
        {"Geneva Identification System", "GEN# +1.00102715"},
        {"Smithsonian Astrophysical Observation", "SAO 99816"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.41138492),
        dec: Angle.Degrees(+18.93545349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111981"},
        {"Geneva Identification System", "GEN# +9.80067011"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.24334636),
        dec: Angle.Degrees(+18.93572758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 159.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129270"},
        {"Hipparcos Number", "HIP 71799"},
        {"Smithsonian Astrophysical Observation", "SAO 101146"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.29732645),
        dec: Angle.Degrees(+18.93616216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88404"},
        {"Hipparcos Number", "HIP 49955"},
        {"Geneva Identification System", "GEN# +1.00088404"},
        {"Smithsonian Astrophysical Observation", "SAO 98995"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.99248035),
        dec: Angle.Degrees(+18.93874182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206485"},
        {"Hipparcos Number", "HIP 107126"},
        {"Smithsonian Astrophysical Observation", "SAO 107334"},
        {"Wilson Evans Batten Catalogue", "WEB 19350"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.49974650),
        dec: Angle.Degrees(+18.93893785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348274"},
        {"Hipparcos Number", "HIP 89490"},
        {"Cincinnati Publication", "Ci 20 1081"},
        {"Geneva Identification System", "GEN# +9.80183033"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.93172764),
        dec: Angle.Degrees(+18.93980767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -429.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6861"},
        {"Hipparcos Number", "HIP 5429"},
        {"Geneva Identification System", "GEN# +1.00006861"},
        {"Smithsonian Astrophysical Observation", "SAO 92281"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.34487723),
        dec: Angle.Degrees(+18.94104633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 263791"},
        {"Hipparcos Number", "HIP 32554"},
        {"Smithsonian Astrophysical Observation", "SAO 96114"},
    },
    visualMagnitude: 8.98,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.88910367),
        dec: Angle.Degrees(+18.94184420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71907"},
        {"Hipparcos Number", "HIP 41727"},
        {"Smithsonian Astrophysical Observation", "SAO 97864"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.62926893),
        dec: Angle.Degrees(+18.94300253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19895"},
        {"Hipparcos Number", "HIP 14929"},
        {"Geneva Identification System", "GEN# +1.00019895"},
        {"Smithsonian Astrophysical Observation", "SAO 93336"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.13710356),
        dec: Angle.Degrees(+18.94362786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121956"},
        {"Hipparcos Number", "HIP 68249"},
        {"Geneva Identification System", "GEN# +1.00121956"},
        {"Smithsonian Astrophysical Observation", "SAO 100799"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.58346291),
        dec: Angle.Degrees(+18.94430836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85660"},
        {"Hipparcos Number", "HIP 48521"},
        {"Smithsonian Astrophysical Observation", "SAO 98831"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.43211504),
        dec: Angle.Degrees(+18.94442672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120232"},
        {"Hipparcos Number", "HIP 67325"},
        {"Geneva Identification System", "GEN# +1.00120232"},
        {"Smithsonian Astrophysical Observation", "SAO 100713"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.98903010),
        dec: Angle.Degrees(+18.94444151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248178"},
        {"Hipparcos Number", "HIP 27569"},
        {"Smithsonian Astrophysical Observation", "SAO 94899"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.57876314),
        dec: Angle.Degrees(+18.94572245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171974"},
        {"Hipparcos Number", "HIP 91255"},
        {"Smithsonian Astrophysical Observation", "SAO 103905"},
        {"Wilson Evans Batten Catalogue", "WEB 15677"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.20400928),
        dec: Angle.Degrees(+18.94659051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69369",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69369"},
        {"Smithsonian Astrophysical Observation", "SAO 100906"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.99629866),
        dec: Angle.Degrees(+18.94701833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59152",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59152"},
        {"Smithsonian Astrophysical Observation", "SAO 99955"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.881,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.96186436),
        dec: Angle.Degrees(+18.94901489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 120.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285631"},
        {"Hipparcos Number", "HIP 19988"},
    },
    visualMagnitude: 10.89,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.31025469),
        dec: Angle.Degrees(+18.94929492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47545"},
        {"Smithsonian Astrophysical Observation", "SAO 98712"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.39837971),
        dec: Angle.Degrees(+18.94951304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87211"},
        {"Hipparcos Number", "HIP 49307"},
        {"Geneva Identification System", "GEN# +1.00087211"},
        {"Smithsonian Astrophysical Observation", "SAO 98929"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.97117143),
        dec: Angle.Degrees(+18.95120352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78658"},
        {"Hipparcos Number", "HIP 45005"},
        {"Smithsonian Astrophysical Observation", "SAO 98406"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.49951707),
        dec: Angle.Degrees(+18.95413025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81232"},
        {"Smithsonian Astrophysical Observation", "SAO 102260"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.86048303),
        dec: Angle.Degrees(+18.95609846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33172"},
        {"Hipparcos Number", "HIP 23976"},
        {"Geneva Identification System", "GEN# +1.00033172"},
        {"Smithsonian Astrophysical Observation", "SAO 94351"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.29913142),
        dec: Angle.Degrees(+18.95863665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285968"},
        {"Hipparcos Number", "HIP 21932"},
        {"Cincinnati Publication", "Ci 20 303"},
        {"Geneva Identification System", "GEN# +1.00285968"},
        {"Geneva Identification System 2", "GEN# +0.01800683"},
        {"Wilson Evans Batten Catalogue", "WEB 4214"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.73070762),
        dec: Angle.Degrees(+18.96088078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 659.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1114.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40697"},
        {"Hipparcos Number", "HIP 28534"},
        {"Smithsonian Astrophysical Observation", "SAO 95127"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.33699184),
        dec: Angle.Degrees(+18.96131720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194405"},
        {"Hipparcos Number", "HIP 100694"},
        {"Smithsonian Astrophysical Observation", "SAO 106081"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.21172212),
        dec: Angle.Degrees(+18.96165800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59374"},
        {"Hipparcos Number", "HIP 36491"},
        {"Cincinnati Publication", "Ci 20 425"},
        {"Cincinnati Publication 2", "Ci 18 899"},
        {"Geneva Identification System", "GEN# +1.00059374"},
        {"Smithsonian Astrophysical Observation", "SAO 96962"},
        {"Wilson Evans Batten Catalogue", "WEB 7258"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62082914),
        dec: Angle.Degrees(+18.96234411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -436.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93459"},
        {"Hipparcos Number", "HIP 52803"},
        {"Geneva Identification System", "GEN# +1.00093459"},
        {"Smithsonian Astrophysical Observation", "SAO 99294"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.92194959),
        dec: Angle.Degrees(+18.96270315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202698"},
        {"Hipparcos Number", "HIP 105069"},
        {"Smithsonian Astrophysical Observation", "SAO 106992"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.26949193),
        dec: Angle.Degrees(+18.96299069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5074"},
        {"Hipparcos Number", "HIP 4119"},
        {"Smithsonian Astrophysical Observation", "SAO 92130"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.19385983),
        dec: Angle.Degrees(+18.96328661)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40700"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.62132370),
        dec: Angle.Degrees(+18.96474148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117696"},
        {"Hipparcos Number", "HIP 65984"},
        {"Geneva Identification System", "GEN# +1.00117696"},
        {"Smithsonian Astrophysical Observation", "SAO 100606"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.92530794),
        dec: Angle.Degrees(+18.96635539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106607",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205524"},
        {"Hipparcos Number", "HIP 106607"},
        {"Geneva Identification System", "GEN# +1.00205524"},
        {"Smithsonian Astrophysical Observation", "SAO 107258"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.87191174),
        dec: Angle.Degrees(+18.96728920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347949"},
        {"Hipparcos Number", "HIP 88858"},
        {"Smithsonian Astrophysical Observation", "SAO 103417"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.12253779),
        dec: Angle.Degrees(+18.96786592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71988"},
        {"Hipparcos Number", "HIP 41765"},
        {"Smithsonian Astrophysical Observation", "SAO 97869"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.75204574),
        dec: Angle.Degrees(+18.96839171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66348"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.97543976),
        dec: Angle.Degrees(+18.97283965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20043"},
        {"Hipparcos Number", "HIP 15048"},
        {"Smithsonian Astrophysical Observation", "SAO 93345"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47862459),
        dec: Angle.Degrees(+18.97331129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59571",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59571"},
        {"Smithsonian Astrophysical Observation", "SAO 99992"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23880415),
        dec: Angle.Degrees(+18.97462521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206000"},
        {"Hipparcos Number", "HIP 106867"},
        {"Smithsonian Astrophysical Observation", "SAO 107298"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.66930249),
        dec: Angle.Degrees(+18.97559532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134943"},
        {"Hipparcos Number", "HIP 74386"},
        {"Fundamental Katalog 5th Edition", "FK5 3199"},
        {"Geneva Identification System", "GEN# +1.00134943J"},
        {"Smithsonian Astrophysical Observation", "SAO 101429"},
        {"Wilson Evans Batten Catalogue", "WEB 12695"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.01780223),
        dec: Angle.Degrees(+18.97600352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180684"},
        {"Hipparcos Number", "HIP 94751"},
        {"Geneva Identification System", "GEN# +1.00180684"},
        {"Smithsonian Astrophysical Observation", "SAO 104678"},
        {"Wilson Evans Batten Catalogue", "WEB 16532"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.20243822),
        dec: Angle.Degrees(+18.97645669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185225"},
        {"Hipparcos Number", "HIP 96524"},
        {"Smithsonian Astrophysical Observation", "SAO 105065"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.34770465),
        dec: Angle.Degrees(+18.97654009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59310"},
        {"Geneva Identification System", "GEN# +0.01902536"},
    },
    visualMagnitude: 10.06,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.51895337),
        dec: Angle.Degrees(+18.97680996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -157.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40330"},
        {"Hipparcos Number", "HIP 28312"},
        {"Geneva Identification System", "GEN# +1.00040330"},
        {"Smithsonian Astrophysical Observation", "SAO 95071"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.73776699),
        dec: Angle.Degrees(+18.97998340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37940"},
        {"Hipparcos Number", "HIP 26925"},
        {"Celescope Catalog", "CEL 939"},
        {"Smithsonian Astrophysical Observation", "SAO 94793"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.72365382),
        dec: Angle.Degrees(+18.98038940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220527"},
        {"Hipparcos Number", "HIP 115546"},
        {"Smithsonian Astrophysical Observation", "SAO 108593"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.07654298),
        dec: Angle.Degrees(+18.98243809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111430",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111430"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.62756776),
        dec: Angle.Degrees(+18.98352504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352974"},
        {"Hipparcos Number", "HIP 102539"},
        {"Smithsonian Astrophysical Observation", "SAO 106482"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.69199729),
        dec: Angle.Degrees(+18.98453866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132296"},
        {"Hipparcos Number", "HIP 73211"},
        {"Smithsonian Astrophysical Observation", "SAO 101303"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.43771777),
        dec: Angle.Degrees(+18.98686651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76953"},
        {"Smithsonian Astrophysical Observation", "SAO 101695"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.69315005),
        dec: Angle.Degrees(+18.98731699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44090",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44090"},
        {"Smithsonian Astrophysical Observation", "SAO 98269"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.70791975),
        dec: Angle.Degrees(+18.98764934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37881"},
        {"Hipparcos Number", "HIP 26886"},
        {"Smithsonian Astrophysical Observation", "SAO 94787"},
        {"Wilson Evans Batten Catalogue", "WEB 5302"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.61987575),
        dec: Angle.Degrees(+18.98768334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72115"},
        {"Hipparcos Number", "HIP 41833"},
        {"Smithsonian Astrophysical Observation", "SAO 97884"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.92213478),
        dec: Angle.Degrees(+18.98778412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218234"},
        {"Hipparcos Number", "HIP 114075"},
        {"Smithsonian Astrophysical Observation", "SAO 108399"},
        {"Wilson Evans Batten Catalogue", "WEB 20256"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.55530039),
        dec: Angle.Degrees(+18.99034796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11941"},
        {"Hipparcos Number", "HIP 9119"},
        {"Smithsonian Astrophysical Observation", "SAO 92722"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.38419584),
        dec: Angle.Degrees(+18.99144460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86828",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10756 AB"},
        {"Henry Draper", "HD 161384"},
        {"Hipparcos Number", "HIP 86828"},
        {"Smithsonian Astrophysical Observation", "SAO 103073"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.13394995),
        dec: Angle.Degrees(+18.99220836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285101"},
        {"Hipparcos Number", "HIP 23109"},
        {"Smithsonian Astrophysical Observation", "SAO 94233"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.58944032),
        dec: Angle.Degrees(+18.99337988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12187",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12187"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.24461394),
        dec: Angle.Degrees(+18.99406405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148415"},
        {"Hipparcos Number", "HIP 80584"},
        {"Geneva Identification System", "GEN# +1.00148415"},
        {"Smithsonian Astrophysical Observation", "SAO 102181"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.80117294),
        dec: Angle.Degrees(+18.99412314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54697"},
        {"Wilson Evans Batten Catalogue", "WEB 9874"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.96995128),
        dec: Angle.Degrees(+18.99613105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -167.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219780"},
        {"Hipparcos Number", "HIP 115071"},
        {"Geneva Identification System", "GEN# +1.00219780"},
        {"Smithsonian Astrophysical Observation", "SAO 108533"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.60370347),
        dec: Angle.Degrees(+18.99629068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8257 A"},
        {"Henry Draper", "HD 101302"},
        {"Hipparcos Number", "HIP 56875"},
        {"Geneva Identification System", "GEN# +1.00101302A"},
        {"Smithsonian Astrophysical Observation", "SAO 99718"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.90221132),
        dec: Angle.Degrees(+18.99674689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284930"},
        {"Hipparcos Number", "HIP 22654"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.09784427),
        dec: Angle.Degrees(+18.99699317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33565",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33565"},
        {"Geneva Identification System", "GEN# +9.80088001"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.61570821),
        dec: Angle.Degrees(+18.99734386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -116.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 349006"},
        {"Hipparcos Number", "HIP 91236"},
        {"Smithsonian Astrophysical Observation", "SAO 103902"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.15685933),
        dec: Angle.Degrees(+18.99892976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56872",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8257 B"},
        {"Henry Draper", "HD 101301"},
        {"Hipparcos Number", "HIP 56872"},
        {"Geneva Identification System", "GEN# +1.00101301"},
        {"Smithsonian Astrophysical Observation", "SAO 99717"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.89692145),
        dec: Angle.Degrees(+19.00014485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70876",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70876"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.41089542),
        dec: Angle.Degrees(+19.00251349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84266"},
        {"Hipparcos Number", "HIP 47786"},
        {"Geneva Identification System", "GEN# +1.00084266"},
        {"Smithsonian Astrophysical Observation", "SAO 98743"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.14766650),
        dec: Angle.Degrees(+19.00282322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184722"},
        {"Hipparcos Number", "HIP 96329"},
        {"Geneva Identification System", "GEN# +1.00184722"},
        {"Smithsonian Astrophysical Observation", "SAO 105005"},
        {"Wilson Evans Batten Catalogue", "WEB 16890"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.78168777),
        dec: Angle.Degrees(+19.00499804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58162"},
        {"Hipparcos Number", "HIP 36000"},
        {"Smithsonian Astrophysical Observation", "SAO 96872"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.29076542),
        dec: Angle.Degrees(+19.00551354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353271"},
        {"Hipparcos Number", "HIP 103378"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.16333218),
        dec: Angle.Degrees(+19.00664361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231197"},
        {"Hipparcos Number", "HIP 95078"},
        {"Smithsonian Astrophysical Observation", "SAO 104745"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.16120820),
        dec: Angle.Degrees(+19.00843242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81110",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81110"},
        {"Smithsonian Astrophysical Observation", "SAO 102246"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.48862671),
        dec: Angle.Degrees(+19.00876876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83647",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83647"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.44770571),
        dec: Angle.Degrees(+19.00880613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42758"},
        {"Hipparcos Number", "HIP 29522"},
        {"Celescope Catalog", "CEL 1123"},
        {"Geneva Identification System", "GEN# +1.00042758"},
        {"Smithsonian Astrophysical Observation", "SAO 95390"},
        {"Wilson Evans Batten Catalogue", "WEB 5801"},
    },
    visualMagnitude: 7.41,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.29516559),
        dec: Angle.Degrees(+19.00927920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245506"},
        {"Hipparcos Number", "HIP 26411"},
        {"Smithsonian Astrophysical Observation", "SAO 94703"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.31813025),
        dec: Angle.Degrees(+19.01053298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35062"},
        {"Hipparcos Number", "HIP 25134"},
        {"Smithsonian Astrophysical Observation", "SAO 94501"},
        {"Wilson Evans Batten Catalogue", "WEB 4875"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.68943461),
        dec: Angle.Degrees(+19.01158628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48936"},
    },
    visualMagnitude: 10.15,
    bvColour: 1.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.76380186),
        dec: Angle.Degrees(+19.01211880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68424"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.10788679),
        dec: Angle.Degrees(+19.01249494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285837"},
        {"Hipparcos Number", "HIP 21261"},
        {"Geneva Identification System", "GEN# +5.20252065"},
    },
    visualMagnitude: 10.74,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.42443980),
        dec: Angle.Degrees(+19.01411670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83936",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10371 AB"},
        {"Hipparcos Number", "HIP 83936"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.34937184),
        dec: Angle.Degrees(+19.01619548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112461"},
        {"Smithsonian Astrophysical Observation", "SAO 108168"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.70744674),
        dec: Angle.Degrees(+19.01735044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -171.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158956"},
        {"Hipparcos Number", "HIP 85740"},
        {"Smithsonian Astrophysical Observation", "SAO 102882"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.82265137),
        dec: Angle.Degrees(+19.01745047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148619"},
        {"Hipparcos Number", "HIP 80703"},
        {"Geneva Identification System", "GEN# +1.00148619"},
        {"Smithsonian Astrophysical Observation", "SAO 102194"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.15781509),
        dec: Angle.Degrees(+19.01861519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6338",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6338"},
        {"Smithsonian Astrophysical Observation", "SAO 92389"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.35943632),
        dec: Angle.Degrees(+19.01952329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208897"},
        {"Hipparcos Number", "HIP 108513"},
        {"Smithsonian Astrophysical Observation", "SAO 107561"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.74851699),
        dec: Angle.Degrees(+19.02038379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115558"},
        {"Hipparcos Number", "HIP 64855"},
        {"Geneva Identification System", "GEN# +1.00115558"},
        {"Smithsonian Astrophysical Observation", "SAO 100502"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.40489853),
        dec: Angle.Degrees(+19.02178702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244429"},
        {"Hipparcos Number", "HIP 25867"},
        {"Smithsonian Astrophysical Observation", "SAO 94609"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.83479803),
        dec: Angle.Degrees(+19.02359001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111238"},
        {"Hipparcos Number", "HIP 62438"},
        {"Geneva Identification System", "GEN# +1.00111238"},
        {"Smithsonian Astrophysical Observation", "SAO 100263"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.95370772),
        dec: Angle.Degrees(+19.02430465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54519"},
    },
    visualMagnitude: 11.07,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.32151708),
        dec: Angle.Degrees(+19.02590463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138215"},
        {"Hipparcos Number", "HIP 75898"},
        {"Smithsonian Astrophysical Observation", "SAO 101582"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.53940621),
        dec: Angle.Degrees(+19.02905165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348713"},
        {"Hipparcos Number", "HIP 90458"},
        {"Smithsonian Astrophysical Observation", "SAO 103735"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.87256953),
        dec: Angle.Degrees(+19.03048651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100111"},
    },
    visualMagnitude: 11.54,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.62751329),
        dec: Angle.Degrees(+19.03105653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14675"},
        {"Smithsonian Astrophysical Observation", "SAO 93305"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.39950052),
        dec: Angle.Degrees(+19.03171674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2316"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.38579681),
        dec: Angle.Degrees(+19.03398006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74307"},
        {"Hipparcos Number", "HIP 42853"},
        {"Geneva Identification System", "GEN# +2.26320552"},
        {"Smithsonian Astrophysical Observation", "SAO 98075"},
        {"Wilson Evans Batten Catalogue", "WEB 8280"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.98395321),
        dec: Angle.Degrees(+19.03417141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98958"},
        {"Hipparcos Number", "HIP 55602"},
        {"Smithsonian Astrophysical Observation", "SAO 99582"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.85261340),
        dec: Angle.Degrees(+19.03482322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116545"},
        {"Smithsonian Astrophysical Observation", "SAO 108723"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.29032561),
        dec: Angle.Degrees(+19.03551178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77174"},
        {"Hipparcos Number", "HIP 44312"},
        {"Smithsonian Astrophysical Observation", "SAO 98297"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.36207769),
        dec: Angle.Degrees(+19.03727551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 348265"},
        {"Hipparcos Number", "HIP 89610"},
        {"Smithsonian Astrophysical Observation", "SAO 103564"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.30386053),
        dec: Angle.Degrees(+19.03838014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134353"},
        {"Hipparcos Number", "HIP 74118"},
        {"Smithsonian Astrophysical Observation", "SAO 101404"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.21694544),
        dec: Angle.Degrees(+19.03871605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211624"},
        {"Hipparcos Number", "HIP 110086"},
        {"Smithsonian Astrophysical Observation", "SAO 107805"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.50105571),
        dec: Angle.Degrees(+19.04043145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212302"},
        {"Hipparcos Number", "HIP 110492"},
        {"Smithsonian Astrophysical Observation", "SAO 107869"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.72816551),
        dec: Angle.Degrees(+19.04208269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27901"},
        {"Hipparcos Number", "HIP 20614"},
        {"Geneva Identification System", "GEN# +5.20250053"},
        {"Smithsonian Astrophysical Observation", "SAO 93918"},
        {"Wilson Evans Batten Catalogue", "WEB 3948"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.23774871),
        dec: Angle.Degrees(+19.04209230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54322"},
        {"Hipparcos Number", "HIP 34524"},
        {"Geneva Identification System", "GEN# +1.00054322"},
        {"Smithsonian Astrophysical Observation", "SAO 96561"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.30615181),
        dec: Angle.Degrees(+19.04274041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63017"},
        {"Hipparcos Number", "HIP 38027"},
        {"Smithsonian Astrophysical Observation", "SAO 97245"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.89612502),
        dec: Angle.Degrees(+19.04494024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58781"},
        {"Hipparcos Number", "HIP 36249"},
        {"Geneva Identification System", "GEN# +1.00058781"},
        {"Smithsonian Astrophysical Observation", "SAO 96918"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.96128684),
        dec: Angle.Degrees(+19.04496380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67711"},
        {"Hipparcos Number", "HIP 39991"},
        {"Smithsonian Astrophysical Observation", "SAO 97613"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.50584623),
        dec: Angle.Degrees(+19.04732191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167493"},
        {"Hipparcos Number", "HIP 89406"},
        {"Smithsonian Astrophysical Observation", "SAO 103518"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.68050945),
        dec: Angle.Degrees(+19.04900351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74656"},
        {"Hipparcos Number", "HIP 42993"},
        {"Renson", "Renson 20880"},
        {"Smithsonian Astrophysical Observation", "SAO 98100"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.44399818),
        dec: Angle.Degrees(+19.04949474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130396"},
        {"Hipparcos Number", "HIP 72336"},
        {"Geneva Identification System", "GEN# +1.00130396"},
        {"Smithsonian Astrophysical Observation", "SAO 101216"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88285110),
        dec: Angle.Degrees(+19.05002956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95517"},
        {"Hipparcos Number", "HIP 53908"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.717,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.45753508),
        dec: Angle.Degrees(+19.05021495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40202"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.17029850),
        dec: Angle.Degrees(+19.05134396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115319"},
        {"Hipparcos Number", "HIP 64751"},
        {"Geneva Identification System", "GEN# +1.00115319"},
        {"Smithsonian Astrophysical Observation", "SAO 100484"},
        {"Wilson Evans Batten Catalogue", "WEB 11445"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.05977711),
        dec: Angle.Degrees(+19.05171640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43282"},
        {"Hipparcos Number", "HIP 29775"},
        {"Geneva Identification System", "GEN# +1.00043282"},
        {"Smithsonian Astrophysical Observation", "SAO 95461"},
        {"Wilson Evans Batten Catalogue", "WEB 5878"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.03882749),
        dec: Angle.Degrees(+19.05516176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120147"},
        {"Hipparcos Number", "HIP 67278"},
        {"Smithsonian Astrophysical Observation", "SAO 100710"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.82357657),
        dec: Angle.Degrees(+19.05685069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104679"},
        {"Smithsonian Astrophysical Observation", "SAO 106914"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.05439416),
        dec: Angle.Degrees(+19.05706700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112084"},
        {"Hipparcos Number", "HIP 62930"},
        {"Geneva Identification System", "GEN# +1.00112084"},
        {"Smithsonian Astrophysical Observation", "SAO 100323"},
        {"Wilson Evans Batten Catalogue", "WEB 11159"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.44969373),
        dec: Angle.Degrees(+19.05737785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153993"},
        {"Hipparcos Number", "HIP 83345"},
        {"Smithsonian Astrophysical Observation", "SAO 102539"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.50581473),
        dec: Angle.Degrees(+19.05812816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79968"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.83871420),
        dec: Angle.Degrees(+19.05885012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70373",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70373"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.97269283),
        dec: Angle.Degrees(+19.05908848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13788"},
        {"Hipparcos Number", "HIP 10451"},
        {"Smithsonian Astrophysical Observation", "SAO 92848"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.66948210),
        dec: Angle.Degrees(+19.05948786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81506"},
        {"Hipparcos Number", "HIP 46304"},
        {"Smithsonian Astrophysical Observation", "SAO 98567"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.64360383),
        dec: Angle.Degrees(+19.05989484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117434"},
        {"Hipparcos Number", "HIP 65867"},
        {"Geneva Identification System", "GEN# +1.00117434"},
        {"Smithsonian Astrophysical Observation", "SAO 100600"},
        {"Wilson Evans Batten Catalogue", "WEB 11654"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.50488115),
        dec: Angle.Degrees(+19.06183912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 112.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35086",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5922 AB"},
        {"Henry Draper", "HD 55822"},
        {"Hipparcos Number", "HIP 35086"},
        {"Renson", "Renson 15190"},
        {"Smithsonian Astrophysical Observation", "SAO 96691"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.84436609),
        dec: Angle.Degrees(+19.06220333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94520",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12201 AB"},
        {"Henry Draper", "HD 180054"},
        {"Hipparcos Number", "HIP 94520"},
        {"Smithsonian Astrophysical Observation", "SAO 104635"},
        {"Wilson Evans Batten Catalogue", "WEB 16474"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.56520563),
        dec: Angle.Degrees(+19.06407953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131362"},
        {"Hipparcos Number", "HIP 72783"},
        {"Geneva Identification System", "GEN# +1.00131362"},
        {"Smithsonian Astrophysical Observation", "SAO 101266"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16007784),
        dec: Angle.Degrees(+19.06423113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14686"},
        {"Hipparcos Number", "HIP 11081"},
        {"Smithsonian Astrophysical Observation", "SAO 92907"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.67082465),
        dec: Angle.Degrees(+19.06439057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125450"},
        {"Hipparcos Number", "HIP 69969"},
        {"Smithsonian Astrophysical Observation", "SAO 100973"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.76677074),
        dec: Angle.Degrees(+19.06541591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2412",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2412"},
        {"Geneva Identification System", "GEN# +0.01800062"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.68544261),
        dec: Angle.Degrees(+19.06728651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196552"},
        {"Hipparcos Number", "HIP 101782"},
        {"Smithsonian Astrophysical Observation", "SAO 106323"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.42317376),
        dec: Angle.Degrees(+19.07029395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1078",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1078"},
        {"Geneva Identification System", "GEN# +0.01800015"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.35151982),
        dec: Angle.Degrees(+19.07164311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 442.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31072"},
        {"Hipparcos Number", "HIP 22745"},
        {"Smithsonian Astrophysical Observation", "SAO 94183"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.39799711),
        dec: Angle.Degrees(+19.07293096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191446"},
        {"Hipparcos Number", "HIP 99281"},
        {"Smithsonian Astrophysical Observation", "SAO 105760"},
        {"Wilson Evans Batten Catalogue", "WEB 17700"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.852,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.30579208),
        dec: Angle.Degrees(+19.07314959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110350"},
        {"Hipparcos Number", "HIP 61917"},
        {"Smithsonian Astrophysical Observation", "SAO 100206"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.35188254),
        dec: Angle.Degrees(+19.07496117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2174"},
        {"Hipparcos Number", "HIP 2048"},
        {"Smithsonian Astrophysical Observation", "SAO 91890"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.48989194),
        dec: Angle.Degrees(+19.07574150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230409"},
        {"Hipparcos Number", "HIP 93341"},
        {"Cincinnati Publication", "Ci 20 1122"},
        {"Cincinnati Publication 2", "Ci 18 2483"},
        {"Geneva Identification System", "GEN# +1.00230409"},
        {"Smithsonian Astrophysical Observation", "SAO 104353"},
        {"Wilson Evans Batten Catalogue", "WEB 16185"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.18118739),
        dec: Angle.Degrees(+19.07592021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -558.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20629"},
        {"Hipparcos Number", "HIP 15506"},
        {"Geneva Identification System", "GEN# +1.00020629"},
        {"Renson", "Renson 5160"},
        {"Smithsonian Astrophysical Observation", "SAO 93386"},
    },
    visualMagnitude: 7.43,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.94898638),
        dec: Angle.Degrees(+19.07627217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 247901"},
        {"Hipparcos Number", "HIP 27465"},
    },
    visualMagnitude: 10.27,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.24449218),
        dec: Angle.Degrees(+19.07678873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 230659"},
        {"Hipparcos Number", "HIP 93765"},
        {"Smithsonian Astrophysical Observation", "SAO 104470"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.43526017),
        dec: Angle.Degrees(+19.07806902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203601"},
        {"Hipparcos Number", "HIP 105564"},
        {"Smithsonian Astrophysical Observation", "SAO 107084"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.71104596),
        dec: Angle.Degrees(+19.08052774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 350913"},
        {"Hipparcos Number", "HIP 98092"},
        {"Geneva Identification System", "GEN# +1.00350913"},
        {"Smithsonian Astrophysical Observation", "SAO 105440"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.03232576),
        dec: Angle.Degrees(+19.08145590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112389",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112389"},
    },
    visualMagnitude: 10.76,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.44712904),
        dec: Angle.Degrees(+19.08161751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98469"},
        {"Hipparcos Number", "HIP 55331"},
        {"Smithsonian Astrophysical Observation", "SAO 99557"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.96047218),
        dec: Angle.Degrees(+19.08234930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108443",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108443"},
        {"Smithsonian Astrophysical Observation", "SAO 107548"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.51285814),
        dec: Angle.Degrees(+19.08257102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14140"},
    },
    visualMagnitude: 9.88,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.58214617),
        dec: Angle.Degrees(+19.08550603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159241"},
        {"Hipparcos Number", "HIP 85869"},
        {"Smithsonian Astrophysical Observation", "SAO 102906"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.20892545),
        dec: Angle.Degrees(+19.08628627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66397"},
    },
    visualMagnitude: 12.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.19942067),
        dec: Angle.Degrees(+19.08776249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -604.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -343.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72689"},
        {"Smithsonian Astrophysical Observation", "SAO 101256"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.761,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.92591218),
        dec: Angle.Degrees(+19.08923689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133288"},
        {"Hipparcos Number", "HIP 73632"},
        {"Geneva Identification System", "GEN# +1.00133288"},
        {"Smithsonian Astrophysical Observation", "SAO 101352"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.77112412),
        dec: Angle.Degrees(+19.08939867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80495"},
        {"Hipparcos Number", "HIP 45826"},
        {"Geneva Identification System", "GEN# +1.00080495"},
        {"Smithsonian Astrophysical Observation", "SAO 98510"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.15796223),
        dec: Angle.Degrees(+19.09065919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116497"},
        {"Hipparcos Number", "HIP 65363"},
        {"Geneva Identification System", "GEN# +1.00116497"},
        {"Smithsonian Astrophysical Observation", "SAO 100549"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.93644026),
        dec: Angle.Degrees(+19.09124166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252537"},
        {"Hipparcos Number", "HIP 29221"},
        {"Geneva Identification System", "GEN# +1.00252537"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.42459484),
        dec: Angle.Degrees(+19.09329016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -170.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166957"},
        {"Hipparcos Number", "HIP 89196"},
        {"Smithsonian Astrophysical Observation", "SAO 103474"},
    },
    visualMagnitude: 8.10,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.04551003),
        dec: Angle.Degrees(+19.09371187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285220"},
        {"Hipparcos Number", "HIP 23579"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.04000945),
        dec: Angle.Degrees(+19.09467160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5142"},
        {"Hipparcos Number", "HIP 4184"},
        {"Smithsonian Astrophysical Observation", "SAO 92137"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.36762165),
        dec: Angle.Degrees(+19.09470047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135080"},
        {"Hipparcos Number", "HIP 74437"},
        {"Smithsonian Astrophysical Observation", "SAO 101436"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.19012619),
        dec: Angle.Degrees(+19.09522368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95060",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181633"},
        {"Hipparcos Number", "HIP 95060"},
        {"Smithsonian Astrophysical Observation", "SAO 104739"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.12410412),
        dec: Angle.Degrees(+19.09642269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104416"},
    },
    visualMagnitude: 11.13,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.28218105),
        dec: Angle.Degrees(+19.09670984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207267"},
        {"Hipparcos Number", "HIP 107583"},
        {"Fundamental Katalog 5th Edition", "FK5 5924"},
        {"Smithsonian Astrophysical Observation", "SAO 107399"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.84116935),
        dec: Angle.Degrees(+19.09740664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50207",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50207"},
        {"Smithsonian Astrophysical Observation", "SAO 99022"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.74626075),
        dec: Angle.Degrees(+19.09823088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36174",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36174"},
        {"Geneva Identification System", "GEN# +0.01901730"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.75986963),
        dec: Angle.Degrees(+19.09930006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46570"},
        {"Smithsonian Astrophysical Observation", "SAO 98603"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.45869716),
        dec: Angle.Degrees(+19.09942816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152762"},
        {"Hipparcos Number", "HIP 82721"},
        {"Smithsonian Astrophysical Observation", "SAO 102466"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.62765777),
        dec: Angle.Degrees(+19.09983123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72659",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9413 AB"},
        {"Henry Draper", "HD 131156"},
        {"Hipparcos Number", "HIP 72659"},
        {"Geneva Identification System", "GEN# +1.00131156"},
        {"Smithsonian Astrophysical Observation", "SAO 101250"},
        {"Wilson Evans Batten Catalogue", "WEB 12488"},
    },
    visualMagnitude: 4.54,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.84701756),
        dec: Angle.Degrees(+19.10063329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69284",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124065"},
        {"Hipparcos Number", "HIP 69284"},
        {"Smithsonian Astrophysical Observation", "SAO 100897"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.73948310),
        dec: Angle.Degrees(+19.10066344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145912"},
        {"Hipparcos Number", "HIP 79453"},
        {"Smithsonian Astrophysical Observation", "SAO 102014"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.21444190),
        dec: Angle.Degrees(+19.10156113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53640"},
        {"Hipparcos Number", "HIP 34300"},
        {"Smithsonian Astrophysical Observation", "SAO 96493"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.65207123),
        dec: Angle.Degrees(+19.10937386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76298"},
    },
    visualMagnitude: 10.95,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.78570141),
        dec: Angle.Degrees(+19.11215454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196592"},
        {"Hipparcos Number", "HIP 101795"},
        {"Smithsonian Astrophysical Observation", "SAO 106326"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.45078431),
        dec: Angle.Degrees(+19.11239176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204979"},
        {"Hipparcos Number", "HIP 106301"},
        {"Smithsonian Astrophysical Observation", "SAO 107207"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.94901212),
        dec: Angle.Degrees(+19.11365404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 353181"},
        {"Hipparcos Number", "HIP 103101"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.34486738),
        dec: Angle.Degrees(+19.11557779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 489"},
        {"Hipparcos Number", "HIP 768"},
        {"Cincinnati Publication", "Ci 18 13"},
        {"Geneva Identification System", "GEN# +1.00000489"},
        {"Smithsonian Astrophysical Observation", "SAO 91742"},
        {"Wilson Evans Batten Catalogue", "WEB 131"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.36659201),
        dec: Angle.Degrees(+19.11569982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 276.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28139"},
        {"Hipparcos Number", "HIP 20769"},
        {"Wilson Evans Batten Catalogue", "WEB 3984"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.75234339),
        dec: Angle.Degrees(+19.11796681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 285938"},
        {"Hipparcos Number", "HIP 21687"},
        {"Smithsonian Astrophysical Observation", "SAO 94055"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.84455713),
        dec: Angle.Degrees(+19.11862320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223768"},
        {"Hipparcos Number", "HIP 117718"},
        {"Fundamental Katalog 5th Edition", "FK5 898"},
        {"Geneva Identification System", "GEN# +1.00223768"},
        {"Smithsonian Astrophysical Observation", "SAO 108878"},
        {"Wilson Evans Batten Catalogue", "WEB 20716"},
    },
    visualMagnitude: 5.06,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.12205065),
        dec: Angle.Degrees(+19.12037002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36406"},
        {"Hipparcos Number", "HIP 25965"},
        {"Geneva Identification System", "GEN# +1.00036406"},
        {"Smithsonian Astrophysical Observation", "SAO 94634"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.09183789),
        dec: Angle.Degrees(+19.12259223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50223",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7695 AB"},
        {"Henry Draper", "HD 88829"},
        {"Hipparcos Number", "HIP 50223"},
        {"Smithsonian Astrophysical Observation", "SAO 99023"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.78619721),
        dec: Angle.Degrees(+19.12431621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93453",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11957 A"},
        {"Henry Draper", "HD 176973"},
        {"Hipparcos Number", "HIP 93453"},
        {"Geneva Identification System", "GEN# +1.00176973"},
        {"Smithsonian Astrophysical Observation", "SAO 104384"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.48999747),
        dec: Angle.Degrees(+19.12479517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 352975"},
        {"Hipparcos Number", "HIP 102458"},
        {"Smithsonian Astrophysical Observation", "SAO 106461"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.42643797),
        dec: Angle.Degrees(+19.12579445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7393"},
        {"Hipparcos Number", "HIP 5800"},
        {"Geneva Identification System", "GEN# +1.00007393"},
        {"Smithsonian Astrophysical Observation", "SAO 92329"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.60376955),
        dec: Angle.Degrees(+19.12686780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153268"},
        {"Hipparcos Number", "HIP 83002"},
        {"Smithsonian Astrophysical Observation", "SAO 102498"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.41963477),
        dec: Angle.Degrees(+19.12922863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1757"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.56838406),
        dec: Angle.Degrees(+19.12935707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222788"},
        {"Hipparcos Number", "HIP 117042"},
        {"Smithsonian Astrophysical Observation", "SAO 108793"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.89463578),
        dec: Angle.Degrees(+19.12992053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89930"},
        {"Hipparcos Number", "HIP 50848"},
        {"Geneva Identification System", "GEN# +1.00089930"},
        {"Smithsonian Astrophysical Observation", "SAO 99092"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.74683239),
        dec: Angle.Degrees(+19.13093205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188061"},
        {"Hipparcos Number", "HIP 97814"},
        {"Smithsonian Astrophysical Observation", "SAO 105369"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.14882740),
        dec: Angle.Degrees(+19.13635485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122602"},
        {"Hipparcos Number", "HIP 68603"},
        {"Geneva Identification System", "GEN# +1.00122602"},
        {"Smithsonian Astrophysical Observation", "SAO 100824"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.64115078),
        dec: Angle.Degrees(+19.13706021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86022",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159583"},
        {"Hipparcos Number", "HIP 86022"},
        {"Geneva Identification System", "GEN# +1.00159583"},
        {"Smithsonian Astrophysical Observation", "SAO 102931"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.69539288),
        dec: Angle.Degrees(+19.13732946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94418",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12172 AB"},
        {"Henry Draper", "HD 179757"},
        {"Hipparcos Number", "HIP 94418"},
        {"Smithsonian Astrophysical Observation", "SAO 104614"},
        {"Wilson Evans Batten Catalogue", "WEB 16454"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.25917452),
        dec: Angle.Degrees(+19.13899555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216201"},
        {"Hipparcos Number", "HIP 112803"},
        {"Smithsonian Astrophysical Observation", "SAO 108211"},
        {"Wilson Evans Batten Catalogue", "WEB 20095"},
    },
    visualMagnitude: 6.52,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.66291969),
        dec: Angle.Degrees(+19.14121395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97496",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12973 AB"},
        {"Henry Draper", "HD 187362"},
        {"Hipparcos Number", "HIP 97496"},
        {"Geneva Identification System", "GEN# +1.00187362J"},
        {"Smithsonian Astrophysical Observation", "SAO 105298"},
        {"Wilson Evans Batten Catalogue", "WEB 17141"},
    },
    visualMagnitude: 5.01,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.24437005),
        dec: Angle.Degrees(+19.14197806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60404",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60404"},
        {"Geneva Identification System", "GEN# +0.01902559"},
        {"Smithsonian Astrophysical Observation", "SAO 100070"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.77681177),
        dec: Angle.Degrees(+19.14394204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177649"},
        {"Hipparcos Number", "HIP 93705"},
        {"Smithsonian Astrophysical Observation", "SAO 104454"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.21918056),
        dec: Angle.Degrees(+19.14423492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95116",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12336 AB"},
        {"Henry Draper", "HD 181752"},
        {"Hipparcos Number", "HIP 95116"},
        {"Geneva Identification System", "GEN# +1.00181752"},
        {"Smithsonian Astrophysical Observation", "SAO 104753"},
        {"Wilson Evans Batten Catalogue", "WEB 16612"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.24938579),
        dec: Angle.Degrees(+19.14538595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111669"},
        {"Smithsonian Astrophysical Observation", "SAO 108048"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.32600590),
        dec: Angle.Degrees(+19.14594388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4166",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4166"},
        {"Geneva Identification System", "GEN# +0.01800115"},
        {"Smithsonian Astrophysical Observation", "SAO 92135"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.30840777),
        dec: Angle.Degrees(+19.14682051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 261.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139244"},
        {"Hipparcos Number", "HIP 76418"},
        {"Smithsonian Astrophysical Observation", "SAO 101643"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.11417964),
        dec: Angle.Degrees(+19.14716350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160865"},
        {"Hipparcos Number", "HIP 86576"},
        {"Smithsonian Astrophysical Observation", "SAO 103025"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.38453458),
        dec: Angle.Degrees(+19.14732664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60005"},
        {"Geneva Identification System", "GEN# +0.01902550"},
        {"Smithsonian Astrophysical Observation", "SAO 100031"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.59961279),
        dec: Angle.Degrees(+19.14755548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118659"},
        {"Hipparcos Number", "HIP 66509"},
        {"Cincinnati Publication", "Ci 18 1765"},
        {"Geneva Identification System", "GEN# +1.00118659"},
        {"Smithsonian Astrophysical Observation", "SAO 100642"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.50161906),
        dec: Angle.Degrees(+19.14886662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 133.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -321.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169222"},
        {"Hipparcos Number", "HIP 90076"},
        {"Smithsonian Astrophysical Observation", "SAO 103658"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.72977361),
        dec: Angle.Degrees(+19.14926415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248587"},
        {"Hipparcos Number", "HIP 27745"},
        {"Geneva Identification System", "GEN# +1.00248587"},
        {"Smithsonian Astrophysical Observation", "SAO 94943"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09507129),
        dec: Angle.Degrees(+19.14970625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140121"},
        {"Hipparcos Number", "HIP 76839"},
        {"Smithsonian Astrophysical Observation", "SAO 101680"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.33291673),
        dec: Angle.Degrees(+19.14990327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131511"},
        {"Hipparcos Number", "HIP 72848"},
        {"Cincinnati Publication", "Ci 20 894"},
        {"Geneva Identification System", "GEN# +1.00131511"},
        {"Smithsonian Astrophysical Observation", "SAO 101276"},
        {"Wilson Evans Batten Catalogue", "WEB 12513"},
    },
    visualMagnitude: 6.00,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.35016578),
        dec: Angle.Degrees(+19.15227142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -442.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 216.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25868"},
        {"Hipparcos Number", "HIP 19175"},
        {"Geneva Identification System", "GEN# +1.00025868"},
        {"Smithsonian Astrophysical Observation", "SAO 93763"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.65571324),
        dec: Angle.Degrees(+19.15275802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10022 A"},
        {"Henry Draper", "HD 147547"},
        {"Hipparcos Number", "HIP 80170"},
        {"Fundamental Katalog 5th Edition", "FK5 609"},
        {"Geneva Identification System", "GEN# +1.00147547"},
        {"Smithsonian Astrophysical Observation", "SAO 102107"},
        {"Wilson Evans Batten Catalogue", "WEB 13572"},
    },
    visualMagnitude: 3.74,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.48018203),
        dec: Angle.Degrees(+19.15302185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29650",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4842 A"},
        {"Henry Draper", "HD 43042"},
        {"Hipparcos Number", "HIP 29650"},
        {"Geneva Identification System", "GEN# +1.00043042"},
        {"Smithsonian Astrophysical Observation", "SAO 95432"},
        {"Wilson Evans Batten Catalogue", "WEB 5840"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.71223277),
        dec: Angle.Degrees(+19.15688949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -181.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105848"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.57863184),
        dec: Angle.Degrees(+19.15706047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135791"},
        {"Hipparcos Number", "HIP 74735"},
        {"Geneva Identification System", "GEN# +1.00135791"},
        {"Smithsonian Astrophysical Observation", "SAO 101472"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.10852548),
        dec: Angle.Degrees(+19.15894486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46984"},
        {"Hipparcos Number", "HIP 31618"},
        {"Smithsonian Astrophysical Observation", "SAO 95902"},
        {"Wilson Evans Batten Catalogue", "WEB 6326"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.25842133),
        dec: Angle.Degrees(+19.16021999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17659"},
        {"Hipparcos Number", "HIP 13269"},
        {"Geneva Identification System", "GEN# +1.00017659"},
        {"Smithsonian Astrophysical Observation", "SAO 93140"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.67705747),
        dec: Angle.Degrees(+19.16065245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102190"},
        {"Wilson Evans Batten Catalogue", "WEB 18490"},
    },
    visualMagnitude: 12.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.58478341),
        dec: Angle.Degrees(+19.16093980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105103",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105103"},
        {"Smithsonian Astrophysical Observation", "SAO 106996"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.35458172),
        dec: Angle.Degrees(+19.16110731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111718"},
        {"Hipparcos Number", "HIP 62724"},
        {"Geneva Identification System", "GEN# +1.00111718"},
        {"Smithsonian Astrophysical Observation", "SAO 100300"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.80071311),
        dec: Angle.Degrees(+19.16134107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186655"},
        {"Hipparcos Number", "HIP 97175"},
        {"Smithsonian Astrophysical Observation", "SAO 105212"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.26490778),
        dec: Angle.Degrees(+19.16447060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11855"},
    },
    visualMagnitude: 12.08,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.25180448),
        dec: Angle.Degrees(+19.16651876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49539"},
        {"Hipparcos Number", "HIP 32727"},
        {"Smithsonian Astrophysical Observation", "SAO 96153"},
    },
    visualMagnitude: 8.18,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.40596134),
        dec: Angle.Degrees(+19.16772646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62782",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8690 B"},
        {"Henry Draper", "HD 111844"},
        {"Hipparcos Number", "HIP 62782"},
        {"Geneva Identification System", "GEN# +1.00111844A"},
        {"Smithsonian Astrophysical Observation", "SAO 100306"},
        {"Wilson Evans Batten Catalogue", "WEB 11131"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.97684407),
        dec: Angle.Degrees(+19.16805500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107087"},
        {"Hipparcos Number", "HIP 60039"},
        {"Geneva Identification System", "GEN# +1.00107087"},
        {"Smithsonian Astrophysical Observation", "SAO 100033"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.69266406),
        dec: Angle.Degrees(+19.16816761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78890",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78890"},
        {"Smithsonian Astrophysical Observation", "SAO 101930"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.56379928),
        dec: Angle.Degrees(+19.16869292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185663"},
        {"Hipparcos Number", "HIP 96700"},
        {"Geneva Identification System", "GEN# +1.00185663"},
        {"Smithsonian Astrophysical Observation", "SAO 105109"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.88556138),
        dec: Angle.Degrees(+19.16961097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11956 AB"},
        {"Henry Draper", "HD 176972"},
        {"Hipparcos Number", "HIP 93448"},
        {"Smithsonian Astrophysical Observation", "SAO 104383"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.47155953),
        dec: Angle.Degrees(+19.16986472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70842"},
        {"Hipparcos Number", "HIP 41233"},
        {"Smithsonian Astrophysical Observation", "SAO 97798"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.20699647),
        dec: Angle.Degrees(+19.17029473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168605"},
        {"Hipparcos Number", "HIP 89824"},
        {"Geneva Identification System", "GEN# +1.00168605"},
        {"Renson", "Renson 47250"},
        {"Smithsonian Astrophysical Observation", "SAO 103618"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.95971108),
        dec: Angle.Degrees(+19.17129006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62783",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8690 A"},
        {"Henry Draper", "HD 111845"},
        {"Hipparcos Number", "HIP 62783"},
        {"Geneva Identification System", "GEN# +1.00111845"},
        {"Renson", "Renson 32450"},
        {"Smithsonian Astrophysical Observation", "SAO 100307"},
        {"Wilson Evans Batten Catalogue", "WEB 11132"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.97855818),
        dec: Angle.Degrees(+19.17217538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8723"},
        {"Hipparcos Number", "HIP 6706"},
        {"Geneva Identification System", "GEN# +1.00008723"},
        {"Smithsonian Astrophysical Observation", "SAO 92436"},
        {"Wilson Evans Batten Catalogue", "WEB 1465"},
    },
    visualMagnitude: 5.35,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.56366085),
        dec: Angle.Degrees(+19.17232096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217243"},
        {"Hipparcos Number", "HIP 113500"},
        {"Geneva Identification System", "GEN# +1.00217243"},
        {"Smithsonian Astrophysical Observation", "SAO 108308"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.79219307),
        dec: Angle.Degrees(+19.17242676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208109"},
        {"Hipparcos Number", "HIP 108061"},
        {"Smithsonian Astrophysical Observation", "SAO 107473"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.40703190),
        dec: Angle.Degrees(+19.17493973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122946"},
        {"Hipparcos Number", "HIP 68770"},
        {"Geneva Identification System", "GEN# +1.00122946"},
        {"Smithsonian Astrophysical Observation", "SAO 100838"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.13533123),
        dec: Angle.Degrees(+19.17761367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136776"},
        {"Hipparcos Number", "HIP 75191"},
        {"Geneva Identification System", "GEN# +1.00136776"},
        {"Smithsonian Astrophysical Observation", "SAO 101507"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.48342149),
        dec: Angle.Degrees(+19.17937519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -179.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155979"},
        {"Hipparcos Number", "HIP 84307"},
        {"Geneva Identification System", "GEN# +1.00155979"},
        {"Smithsonian Astrophysical Observation", "SAO 102674"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.54216363),
        dec: Angle.Degrees(+19.17953036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125771"},
        {"Hipparcos Number", "HIP 70145"},
        {"Smithsonian Astrophysical Observation", "SAO 100986"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.28909815),
        dec: Angle.Degrees(+19.18018328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77627",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9809 AB"},
        {"Henry Draper", "HD 141894"},
        {"Hipparcos Number", "HIP 77627"},
        {"Smithsonian Astrophysical Observation", "SAO 101773"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.72217070),
        dec: Angle.Degrees(+19.18036877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15566",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2478 AB"},
        {"Henry Draper", "HD 20698"},
        {"Hipparcos Number", "HIP 15566"},
        {"Smithsonian Astrophysical Observation", "SAO 93396"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.14225491),
        dec: Angle.Degrees(+19.18042159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20889",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Ain"},
        {"Henry Draper", "HD 28305"},
        {"Hipparcos Number", "HIP 20889"},
        {"Fundamental Katalog 5th Edition", "FK5 164"},
        {"Geneva Identification System", "GEN# +5.20250070"},
        {"Smithsonian Astrophysical Observation", "SAO 93954"},
        {"Wilson Evans Batten Catalogue", "WEB 4009"},
    },
    visualMagnitude: 3.53,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.15388879),
        dec: Angle.Degrees(+19.18052092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187014"},
        {"Hipparcos Number", "HIP 97339"},
        {"Smithsonian Astrophysical Observation", "SAO 105249"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.74852175),
        dec: Angle.Degrees(+19.18072207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169955"},
        {"Hipparcos Number", "HIP 90364"},
        {"Smithsonian Astrophysical Observation", "SAO 103718"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.58990281),
        dec: Angle.Degrees(+19.18137829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58635",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58635"},
        {"Smithsonian Astrophysical Observation", "SAO 99912"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.36241777),
        dec: Angle.Degrees(+19.18235887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116518",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116518"},
        {"Smithsonian Astrophysical Observation", "SAO 108712"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.18952700),
        dec: Angle.Degrees(+19.18327440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69673",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Arcturus"},
        {"Henry Draper", "HD 124897"},
        {"Hipparcos Number", "HIP 69673"},
        {"Cincinnati Publication", "Ci 20 843"},
        {"Fundamental Katalog 5th Edition", "FK5 526"},
        {"Geneva Identification System", "GEN# +1.00124897"},
        {"Smithsonian Astrophysical Observation", "SAO 100944"},
        {"Wilson Evans Batten Catalogue", "WEB 12132"},
    },
    visualMagnitude: -0.05,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.91811403),
        dec: Angle.Degrees(+19.18726997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1093.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1999.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16109",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2542 AB"},
        {"Hipparcos Number", "HIP 16109"},
        {"Smithsonian Astrophysical Observation", "SAO 93440"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.88360848),
        dec: Angle.Degrees(+19.18729616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188856"},
        {"Hipparcos Number", "HIP 98120"},
        {"Smithsonian Astrophysical Observation", "SAO 105446"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.12420672),
        dec: Angle.Degrees(+19.18734897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12729"},
        {"Hipparcos Number", "HIP 9725"},
        {"Smithsonian Astrophysical Observation", "SAO 92783"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.27810498),
        dec: Angle.Degrees(+19.18754877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12248"},
        {"Hipparcos Number", "HIP 9379"},
        {"Smithsonian Astrophysical Observation", "SAO 92747"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.13179980),
        dec: Angle.Degrees(+19.18784962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4140",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4140"},
    },
    visualMagnitude: 11.34,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.23829813),
        dec: Angle.Degrees(+48.86065601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110549",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110549"},
        {"Smithsonian Astrophysical Observation", "SAO 107880"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.91928499),
        dec: Angle.Degrees(+19.18816344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 746 AB"},
        {"Henry Draper", "HD 5267"},
        {"Hipparcos Number", "HIP 4267"},
        {"Geneva Identification System", "GEN# +1.00005267"},
        {"Smithsonian Astrophysical Observation", "SAO 92145"},
        {"Wilson Evans Batten Catalogue", "WEB 763"},
    },
    visualMagnitude: 5.80,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.64674999),
        dec: Angle.Degrees(+19.18843611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35693",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35693"},
        {"Smithsonian Astrophysical Observation", "SAO 96814"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.46856483),
        dec: Angle.Degrees(+19.18989751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56055",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56055"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.33040917),
        dec: Angle.Degrees(+19.19007599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 231621"},
        {"Hipparcos Number", "HIP 95914"},
        {"Geneva Identification System", "GEN# +1.00231621"},
        {"Wilson Evans Batten Catalogue", "WEB 16797"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.58878324),
        dec: Angle.Degrees(+19.19295398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80329",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80329"},
        {"Smithsonian Astrophysical Observation", "SAO 102132"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.99252483),
        dec: Angle.Degrees(+19.19504283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6409"},
        {"Hipparcos Number", "HIP 5091"},
        {"Smithsonian Astrophysical Observation", "SAO 92233"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.30086396),
        dec: Angle.Degrees(+19.19781259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119056"},
        {"Hipparcos Number", "HIP 66730"},
        {"Geneva Identification System", "GEN# +1.00119056"},
        {"Smithsonian Astrophysical Observation", "SAO 100658"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.17019218),
        dec: Angle.Degrees(+19.20031593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284839"},
        {"Hipparcos Number", "HIP 22185"},
        {"Geneva Identification System", "GEN# +2.16470094"},
        {"Smithsonian Astrophysical Observation", "SAO 94113"},
        {"New General Catalogue", "NGC 1647 94"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.59315551),
        dec: Angle.Degrees(+19.20524799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179585"},
        {"Hipparcos Number", "HIP 94369"},
        {"Smithsonian Astrophysical Observation", "SAO 104595"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.11180631),
        dec: Angle.Degrees(+19.20853080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126631"},
        {"Hipparcos Number", "HIP 70579"},
        {"Smithsonian Astrophysical Observation", "SAO 101022"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.55037954),
        dec: Angle.Degrees(+19.20924714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201545"},
        {"Hipparcos Number", "HIP 104471"},
        {"Geneva Identification System", "GEN# +1.00201545"},
        {"Smithsonian Astrophysical Observation", "SAO 106883"},
        {"Wilson Evans Batten Catalogue", "WEB 19018"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.44119442),
        dec: Angle.Degrees(+19.21070295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220872"},
        {"Hipparcos Number", "HIP 115766"},
        {"Smithsonian Astrophysical Observation", "SAO 108614"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.80876930),
        dec: Angle.Degrees(+19.21421968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175613"},
        {"Hipparcos Number", "HIP 92867"},
        {"Smithsonian Astrophysical Observation", "SAO 104262"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.84850795),
        dec: Angle.Degrees(+19.21482450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128220"},
        {"Hipparcos Number", "HIP 71332"},
        {"Geneva Identification System", "GEN# +1.00128220"},
        {"Renson", "Renson 36420"},
        {"Smithsonian Astrophysical Observation", "SAO 101094"},
        {"Wilson Evans Batten Catalogue", "WEB 12318"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.81576748),
        dec: Angle.Degrees(+19.21515091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115537"},
        {"Hipparcos Number", "HIP 64849"},
        {"Geneva Identification System", "GEN# +1.00115537"},
        {"Smithsonian Astrophysical Observation", "SAO 100499"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.39420985),
        dec: Angle.Degrees(+19.21520279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67346"},
        {"Hipparcos Number", "HIP 39816"},
        {"Geneva Identification System", "GEN# +1.00067346"},
        {"Smithsonian Astrophysical Observation", "SAO 97579"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.03616559),
        dec: Angle.Degrees(+19.21617086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40039"},
        {"Hipparcos Number", "HIP 28170"},
        {"Celescope Catalog", "CEL 1043"},
        {"Geneva Identification System", "GEN# +1.00040039"},
        {"Smithsonian Astrophysical Observation", "SAO 95031"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28442736),
        dec: Angle.Degrees(+19.21674601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37246"},
    },
    visualMagnitude: 10.84,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.74622001),
        dec: Angle.Degrees(+19.21768909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203217"},
        {"Hipparcos Number", "HIP 105355"},
        {"Smithsonian Astrophysical Observation", "SAO 107045"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.09370483),
        dec: Angle.Degrees(+19.22089587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51531"},
        {"Hipparcos Number", "HIP 33572"},
        {"Smithsonian Astrophysical Observation", "SAO 96335"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.63288258),
        dec: Angle.Degrees(+19.22197722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52828"},
        {"Hipparcos Number", "HIP 34016"},
        {"Renson", "Renson 14490"},
        {"Smithsonian Astrophysical Observation", "SAO 96426"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.87405916),
        dec: Angle.Degrees(+19.22212054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112523"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.87708109),
        dec: Angle.Degrees(+19.22445172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126661"},
        {"Hipparcos Number", "HIP 70602"},
        {"Fundamental Katalog 5th Edition", "FK5 1378"},
        {"Geneva Identification System", "GEN# +1.00126661"},
        {"Renson", "Renson 36070"},
        {"Smithsonian Astrophysical Observation", "SAO 101025"},
        {"Wilson Evans Batten Catalogue", "WEB 12240"},
    },
    visualMagnitude: 5.40,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.61420112),
        dec: Angle.Degrees(+19.22683490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24691"},
        {"Hipparcos Number", "HIP 18409"},
        {"Smithsonian Astrophysical Observation", "SAO 93678"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.03700108),
        dec: Angle.Degrees(+19.22841086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8690 C"},
        {"Henry Draper", "HD 111814"},
        {"Hipparcos Number", "HIP 62769"},
        {"Geneva Identification System", "GEN# +1.00111814"},
        {"Smithsonian Astrophysical Observation", "SAO 100304"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.93979830),
        dec: Angle.Degrees(+19.22880427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13855",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13855"},
        {"Smithsonian Astrophysical Observation", "SAO 93211"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.59891963),
        dec: Angle.Degrees(+19.22943106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52525"},
        {"Hipparcos Number", "HIP 33926"},
        {"Smithsonian Astrophysical Observation", "SAO 96404"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.59701210),
        dec: Angle.Degrees(+19.22991553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 284931"},
        {"Hipparcos Number", "HIP 22623"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.01464502),
        dec: Angle.Degrees(+19.23013995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42067"},
        {"Hipparcos Number", "HIP 29190"},
        {"Geneva Identification System", "GEN# +1.00042067"},
        {"Smithsonian Astrophysical Observation", "SAO 95297"},
        {"Wilson Evans Batten Catalogue", "WEB 5725"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.36430809),
        dec: Angle.Degrees(+19.23180736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27406"},
        {"Hipparcos Number", "HIP 20237"},
        {"Geneva Identification System", "GEN# +5.20250031"},
        {"Smithsonian Astrophysical Observation", "SAO 93873"},
        {"Wilson Evans Batten Catalogue", "WEB 3861"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.05373248),
        dec: Angle.Degrees(+19.23356253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60675"},
        {"Hipparcos Number", "HIP 37011"},
        {"Smithsonian Astrophysical Observation", "SAO 97071"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.10410937),
        dec: Angle.Degrees(+19.23711239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64468"},
        {"Hipparcos Number", "HIP 38657"},
        {"Cincinnati Publication", "Ci 20 444"},
        {"Geneva Identification System", "GEN# +1.00064468"},
        {"Smithsonian Astrophysical Observation", "SAO 97359"},
        {"Wilson Evans Batten Catalogue", "WEB 7587"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.72504040),
        dec: Angle.Degrees(+19.23744468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -454.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148128"},
        {"Hipparcos Number", "HIP 80444"},
        {"Smithsonian Astrophysical Observation", "SAO 102152"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.31599222),
        dec: Angle.Degrees(+19.23981417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59723",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59723"},
        {"Geneva Identification System", "GEN# +0.02002698"},
        {"Smithsonian Astrophysical Observation", "SAO 100005"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.72487275),
        dec: Angle.Degrees(+19.24005424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7874 AB"},
        {"Henry Draper", "HD 92337"},
        {"Hipparcos Number", "HIP 52212"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.01346513),
        dec: Angle.Degrees(+19.24043311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8763"},
        {"Hipparcos Number", "HIP 6732"},
        {"Fundamental Katalog 5th Edition", "FK5 1039"},
        {"Geneva Identification System", "GEN# +1.00008763"},
        {"Smithsonian Astrophysical Observation", "SAO 92444"},
        {"Wilson Evans Batten Catalogue", "WEB 1471"},
    },
    visualMagnitude: 5.50,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.67352916),
        dec: Angle.Degrees(+19.24056476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159520"},
        {"Hipparcos Number", "HIP 85981"},
        {"Geneva Identification System", "GEN# +1.00159520"},
        {"Smithsonian Astrophysical Observation", "SAO 102927"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.59459136),
        dec: Angle.Degrees(+19.24192917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137356"},
        {"Hipparcos Number", "HIP 75469"},
        {"Smithsonian Astrophysical Observation", "SAO 101535"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.25616336),
        dec: Angle.Degrees(+19.24364089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75666",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75666"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.88977324),
        dec: Angle.Degrees(+19.24744301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100034",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193080"},
        {"Hipparcos Number", "HIP 100034"},
        {"Geneva Identification System", "GEN# +1.00193080"},
        {"Smithsonian Astrophysical Observation", "SAO 105932"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.43254383),
        dec: Angle.Degrees(+19.24794767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 347827"},
        {"Hipparcos Number", "HIP 88242"},
        {"Geneva Identification System", "GEN# +1.00347827"},
        {"Wilson Evans Batten Catalogue", "WEB 14909"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.28844380),
        dec: Angle.Degrees(+19.24911139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71260"},
        {"Hipparcos Number", "HIP 41440"},
        {"Geneva Identification System", "GEN# +1.00071260"},
        {"Smithsonian Astrophysical Observation", "SAO 97823"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.77057617),
        dec: Angle.Degrees(+19.25380094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66808"},
        {"Geneva Identification System", "GEN# +0.01902704"},
        {"Smithsonian Astrophysical Observation", "SAO 100666"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.41315690),
        dec: Angle.Degrees(+19.25412347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24029"},
        {"Hipparcos Number", "HIP 17961"},
        {"Geneva Identification System", "GEN# +1.00024029"},
        {"Smithsonian Astrophysical Observation", "SAO 93629"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.59814631),
        dec: Angle.Degrees(+19.25435961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3232"},
        {"Geneva Identification System", "GEN# +0.01800092"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.28196824),
        dec: Angle.Degrees(+19.25461642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 371.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87192",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162161"},
        {"Hipparcos Number", "HIP 87192"},
        {"Geneva Identification System", "GEN# +1.00162161"},
        {"Smithsonian Astrophysical Observation", "SAO 103131"},
        {"Wilson Evans Batten Catalogue", "WEB 14711"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.19949521),
        dec: Angle.Degrees(+19.25499439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219186"},
        {"Hipparcos Number", "HIP 114683"},
        {"Cincinnati Publication", "Ci 18 3040"},
        {"Smithsonian Astrophysical Observation", "SAO 108470"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.48760447),
        dec: Angle.Degrees(+19.25513476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159332"},
        {"Hipparcos Number", "HIP 85912"},
        {"Fundamental Katalog 5th Edition", "FK5 3393"},
        {"Geneva Identification System", "GEN# +1.00159332"},
        {"Smithsonian Astrophysical Observation", "SAO 102912"},
        {"Wilson Evans Batten Catalogue", "WEB 14497"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.34517510),
        dec: Angle.Degrees(+19.25689917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206313"},
        {"Hipparcos Number", "HIP 107051"},
        {"Smithsonian Astrophysical Observation", "SAO 107320"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.22053802),
        dec: Angle.Degrees(+19.25726396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199192"},
        {"Hipparcos Number", "HIP 103249"},
        {"Smithsonian Astrophysical Observation", "SAO 106652"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.76304724),
        dec: Angle.Degrees(+19.25906438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190719"},
        {"Hipparcos Number", "HIP 98969"},
        {"Smithsonian Astrophysical Observation", "SAO 105670"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.39976652),
        dec: Angle.Degrees(+19.26057065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219293"},
        {"Hipparcos Number", "HIP 114749"},
        {"Geneva Identification System", "GEN# +1.00219293"},
        {"Smithsonian Astrophysical Observation", "SAO 108483"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.66571823),
        dec: Angle.Degrees(+19.26346189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116395"},
        {"Hipparcos Number", "HIP 65308"},
        {"Smithsonian Astrophysical Observation", "SAO 100543"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.76962661),
        dec: Angle.Degrees(+19.26693241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73210"},
        {"Hipparcos Number", "HIP 42327"},
        {"Geneva Identification System", "GEN# +2.26320050"},
        {"Smithsonian Astrophysical Observation", "SAO 97976"},
        {"Wilson Evans Batten Catalogue", "WEB 8137"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.44493739),
        dec: Angle.Degrees(+19.26725017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177676"},
        {"Hipparcos Number", "HIP 93715"},
        {"Smithsonian Astrophysical Observation", "SAO 104456"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.23276258),
        dec: Angle.Degrees(+19.26889637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217577"},
        {"Hipparcos Number", "HIP 113688"},
        {"Fundamental Katalog 5th Edition", "FK5 6040"},
        {"Geneva Identification System", "GEN# +1.00217577"},
        {"Smithsonian Astrophysical Observation", "SAO 108337"},
        {"Wilson Evans Batten Catalogue", "WEB 20200"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.38777313),
        dec: Angle.Degrees(+19.26976998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38561"},
        {"Geneva Identification System", "GEN# +0.01901865"},
        {"Wilson Evans Batten Catalogue", "WEB 7576"},
    },
    visualMagnitude: 11.97,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.43107629),
        dec: Angle.Degrees(+19.27338198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58701",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8399 AB"},
        {"Hipparcos Number", "HIP 58701"},
        {"Smithsonian Astrophysical Observation", "SAO 99917"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.59407218),
        dec: Angle.Degrees(+19.27387632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
