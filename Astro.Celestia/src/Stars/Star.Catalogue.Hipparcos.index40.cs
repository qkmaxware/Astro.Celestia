using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_40() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90496",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Kaus Borealis"},
        {"Henry Draper", "HD 169916"},
        {"Hipparcos Number", "HIP 90496"},
        {"Fundamental Katalog 5th Edition", "FK5 692"},
        {"Geneva Identification System", "GEN# +1.00169916"},
        {"Smithsonian Astrophysical Observation", "SAO 186841"},
        {"Wilson Evans Batten Catalogue", "WEB 15500"},
    },
    visualMagnitude: 2.82,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.99278955),
        dec: Angle.Degrees(-25.42124732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -186.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220978"},
        {"Hipparcos Number", "HIP 115858"},
        {"Fundamental Katalog 5th Edition", "FK5 3879"},
        {"Smithsonian Astrophysical Observation", "SAO 191931"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.10519643),
        dec: Angle.Degrees(-25.42049980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40972"},
        {"Hipparcos Number", "HIP 28520"},
        {"Fundamental Katalog 5th Edition", "FK5 2460"},
        {"Geneva Identification System", "GEN# +1.00040972"},
        {"Smithsonian Astrophysical Observation", "SAO 171138"},
        {"Wilson Evans Batten Catalogue", "WEB 5576"},
    },
    visualMagnitude: 6.04,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.30460500),
        dec: Angle.Degrees(-25.41771238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29087",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4742 AB"},
        {"Henry Draper", "HD 42163"},
        {"Hipparcos Number", "HIP 29087"},
        {"Renson", "Renson 11270"},
        {"Smithsonian Astrophysical Observation", "SAO 171278"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.03605620),
        dec: Angle.Degrees(-25.41623754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76988",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9754 AB"},
        {"Henry Draper", "HD 140192"},
        {"Hipparcos Number", "HIP 76988"},
        {"Smithsonian Astrophysical Observation", "SAO 183731"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.79809836),
        dec: Angle.Degrees(-25.41554790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147648"},
        {"Hipparcos Number", "HIP 80338"},
        {"Geneva Identification System", "GEN# +1.00147648"},
        {"Smithsonian Astrophysical Observation", "SAO 184360"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.01209031),
        dec: Angle.Degrees(-25.41494974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33575",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5651 A"},
        {"Henry Draper", "HD 52018"},
        {"Hipparcos Number", "HIP 33575"},
        {"Celescope Catalog", "CEL 1468"},
        {"Geneva Identification System", "GEN# +5.11210040"},
        {"Smithsonian Astrophysical Observation", "SAO 172669"},
        {"Wilson Evans Batten Catalogue", "WEB 6752"},
    },
    visualMagnitude: 5.59,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.64959747),
        dec: Angle.Degrees(-25.41416976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66149"},
        {"Hipparcos Number", "HIP 39214"},
        {"Smithsonian Astrophysical Observation", "SAO 174988"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.30925787),
        dec: Angle.Degrees(-25.41340601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204822"},
        {"Hipparcos Number", "HIP 106310"},
        {"Smithsonian Astrophysical Observation", "SAO 190412"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.96389254),
        dec: Angle.Degrees(-25.41268980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141442"},
        {"Hipparcos Number", "HIP 77552"},
        {"Geneva Identification System", "GEN# +1.00141442"},
        {"Smithsonian Astrophysical Observation", "SAO 183838"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.50879642),
        dec: Angle.Degrees(-25.40979677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44263"},
        {"Hipparcos Number", "HIP 30080"},
        {"Smithsonian Astrophysical Observation", "SAO 171579"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.95037891),
        dec: Angle.Degrees(-25.40616195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218932"},
        {"Hipparcos Number", "HIP 114547"},
        {"Smithsonian Astrophysical Observation", "SAO 191718"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.03896994),
        dec: Angle.Degrees(-25.40385811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123767"},
        {"Hipparcos Number", "HIP 69211"},
        {"Geneva Identification System", "GEN# +1.00123767"},
        {"Smithsonian Astrophysical Observation", "SAO 182302"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.55160891),
        dec: Angle.Degrees(-25.40065116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3244"},
        {"Hipparcos Number", "HIP 2788"},
        {"Geneva Identification System", "GEN# +1.00003244"},
        {"Smithsonian Astrophysical Observation", "SAO 166387"},
        {"Wilson Evans Batten Catalogue", "WEB 500"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.88732191),
        dec: Angle.Degrees(-25.39983681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4572"},
        {"Hipparcos Number", "HIP 3706"},
        {"Geneva Identification System", "GEN# +1.00004572"},
        {"Smithsonian Astrophysical Observation", "SAO 166579"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.89508667),
        dec: Angle.Degrees(-25.39495810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60834"},
        {"Hipparcos Number", "HIP 36929"},
        {"Geneva Identification System", "GEN# +1.00060834"},
        {"Smithsonian Astrophysical Observation", "SAO 174062"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.87336173),
        dec: Angle.Degrees(-25.39455366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27905"},
        {"Hipparcos Number", "HIP 20478"},
        {"Geneva Identification System", "GEN# +1.00027905"},
        {"Smithsonian Astrophysical Observation", "SAO 169396"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.83391442),
        dec: Angle.Degrees(-25.39434745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -268.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70695"},
        {"Hipparcos Number", "HIP 41035"},
        {"Smithsonian Astrophysical Observation", "SAO 175697"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.61693688),
        dec: Angle.Degrees(-25.39289516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26240"},
        {"Hipparcos Number", "HIP 19297"},
        {"Smithsonian Astrophysical Observation", "SAO 169160"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.05130727),
        dec: Angle.Degrees(-25.39262520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88239"},
        {"Hipparcos Number", "HIP 49796"},
        {"Geneva Identification System", "GEN# +1.00088239"},
        {"Smithsonian Astrophysical Observation", "SAO 178487"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.47171942),
        dec: Angle.Degrees(-25.39261753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135328"},
        {"Hipparcos Number", "HIP 74655"},
        {"Smithsonian Astrophysical Observation", "SAO 183310"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.82027747),
        dec: Angle.Degrees(-25.38950996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74879"},
        {"Hipparcos Number", "HIP 43002"},
        {"Geneva Identification System", "GEN# +1.00074879"},
        {"Renson", "Renson 20940"},
        {"Smithsonian Astrophysical Observation", "SAO 176439"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.45541393),
        dec: Angle.Degrees(-25.38810636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125130"},
        {"Hipparcos Number", "HIP 69890"},
        {"Smithsonian Astrophysical Observation", "SAO 182427"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.54403959),
        dec: Angle.Degrees(-25.38803995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7123"},
        {"Hipparcos Number", "HIP 5546"},
        {"Smithsonian Astrophysical Observation", "SAO 166856"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.78507135),
        dec: Angle.Degrees(-25.38562626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65481",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116642"},
        {"Hipparcos Number", "HIP 65481"},
        {"Smithsonian Astrophysical Observation", "SAO 181632"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.31363020),
        dec: Angle.Degrees(-25.38501164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149446"},
        {"Hipparcos Number", "HIP 81265"},
        {"Smithsonian Astrophysical Observation", "SAO 184482"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.96824750),
        dec: Angle.Degrees(-25.38148341)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199604"},
        {"Hipparcos Number", "HIP 103572"},
        {"Geneva Identification System", "GEN# +1.00199604"},
        {"Smithsonian Astrophysical Observation", "SAO 189900"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77154597),
        dec: Angle.Degrees(-25.38026168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -236.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4389"},
        {"Hipparcos Number", "HIP 3596"},
        {"Geneva Identification System", "GEN# +1.00004389"},
        {"Smithsonian Astrophysical Observation", "SAO 166548"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.51017446),
        dec: Angle.Degrees(-25.37966503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16117"},
        {"Hipparcos Number", "HIP 11992"},
        {"Smithsonian Astrophysical Observation", "SAO 167888"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.66004138),
        dec: Angle.Degrees(-25.37943719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112349"},
    },
    visualMagnitude: 10.83,
    bvColour: 2.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.34406946),
        dec: Angle.Degrees(-25.37791062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144823"},
        {"Hipparcos Number", "HIP 79097"},
        {"Smithsonian Astrophysical Observation", "SAO 184161"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.18198613),
        dec: Angle.Degrees(-25.37677858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186416"},
        {"Hipparcos Number", "HIP 97186"},
        {"Smithsonian Astrophysical Observation", "SAO 188523"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.29669036),
        dec: Angle.Degrees(-25.37620318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40609"},
        {"Hipparcos Number", "HIP 28299"},
        {"Smithsonian Astrophysical Observation", "SAO 171097"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.71565464),
        dec: Angle.Degrees(-25.37568431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33906"},
        {"Hipparcos Number", "HIP 24265"},
        {"Smithsonian Astrophysical Observation", "SAO 170188"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.12118047),
        dec: Angle.Degrees(-25.37521158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89796"},
        {"Hipparcos Number", "HIP 50719"},
        {"Smithsonian Astrophysical Observation", "SAO 178717"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.33976946),
        dec: Angle.Degrees(-25.37299496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63233"},
        {"Hipparcos Number", "HIP 37968"},
        {"Fundamental Katalog 5th Edition", "FK5 4703"},
        {"Smithsonian Astrophysical Observation", "SAO 174524"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.73803618),
        dec: Angle.Degrees(-25.37038785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210466"},
        {"Hipparcos Number", "HIP 109523"},
        {"Geneva Identification System", "GEN# +1.00210466"},
        {"Smithsonian Astrophysical Observation", "SAO 190946"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.79557008),
        dec: Angle.Degrees(-25.36986094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173098"},
        {"Hipparcos Number", "HIP 91962"},
        {"Geneva Identification System", "GEN# +1.00173098"},
        {"Smithsonian Astrophysical Observation", "SAO 187212"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.17239173),
        dec: Angle.Degrees(-25.36983187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32078"},
        {"Hipparcos Number", "HIP 23202"},
        {"Geneva Identification System", "GEN# +1.00032078"},
        {"Smithsonian Astrophysical Observation", "SAO 169950"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.89945648),
        dec: Angle.Degrees(-25.36936809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50261"},
        {"Hipparcos Number", "HIP 32911"},
        {"Smithsonian Astrophysical Observation", "SAO 172447"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.86006757),
        dec: Angle.Degrees(-25.36935252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220517"},
        {"Hipparcos Number", "HIP 115565"},
        {"Smithsonian Astrophysical Observation", "SAO 191877"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.13403868),
        dec: Angle.Degrees(-25.36792595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11808"},
        {"Hipparcos Number", "HIP 8949"},
        {"Geneva Identification System", "GEN# +1.00011808"},
        {"Renson", "Renson 3020"},
        {"Smithsonian Astrophysical Observation", "SAO 167394"},
        {"Wilson Evans Batten Catalogue", "WEB 1880"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.81394277),
        dec: Angle.Degrees(-25.36715649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36762"},
        {"Hipparcos Number", "HIP 26005"},
        {"Smithsonian Astrophysical Observation", "SAO 170542"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.25734075),
        dec: Angle.Degrees(-25.36709130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124807"},
        {"Hipparcos Number", "HIP 69718"},
        {"Smithsonian Astrophysical Observation", "SAO 182391"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.05915833),
        dec: Angle.Degrees(-25.36583799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16586"},
        {"Hipparcos Number", "HIP 12333"},
        {"Geneva Identification System", "GEN# +1.00016586"},
        {"Smithsonian Astrophysical Observation", "SAO 167943"},
        {"Wilson Evans Batten Catalogue", "WEB 2530"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.70466450),
        dec: Angle.Degrees(-25.36574633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212034"},
        {"Hipparcos Number", "HIP 110413"},
        {"Smithsonian Astrophysical Observation", "SAO 191087"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.47953082),
        dec: Angle.Degrees(-25.36529404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37173",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6246 AB"},
        {"Henry Draper", "HD 61429"},
        {"Hipparcos Number", "HIP 37173"},
        {"Geneva Identification System", "GEN# +1.00061429"},
        {"Smithsonian Astrophysical Observation", "SAO 174175"},
        {"Wilson Evans Batten Catalogue", "WEB 7367"},
    },
    visualMagnitude: 4.69,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.57519746),
        dec: Angle.Degrees(-25.36478805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5524"},
        {"Hipparcos Number", "HIP 4442"},
        {"Geneva Identification System", "GEN# +1.00005524"},
        {"Smithsonian Astrophysical Observation", "SAO 166699"},
        {"Wilson Evans Batten Catalogue", "WEB 799"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.20451862),
        dec: Angle.Degrees(-25.36336916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69834"},
        {"Hipparcos Number", "HIP 40652"},
        {"Geneva Identification System", "GEN# +1.00069834"},
        {"Smithsonian Astrophysical Observation", "SAO 175537"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.47748438),
        dec: Angle.Degrees(-25.36116670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31639",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 31639"},
        {"Smithsonian Astrophysical Observation", "SAO 172042"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.31116050),
        dec: Angle.Degrees(-25.36070776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2572",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 456 A"},
        {"Henry Draper", "HD 2947"},
        {"Hipparcos Number", "HIP 2572"},
        {"Smithsonian Astrophysical Observation", "SAO 166344"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.16412581),
        dec: Angle.Degrees(-25.35958222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58322"},
        {"Hipparcos Number", "HIP 35911"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.04470369),
        dec: Angle.Degrees(-25.35897872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222737"},
        {"Hipparcos Number", "HIP 117019"},
        {"Geneva Identification System", "GEN# +1.00222737"},
        {"Smithsonian Astrophysical Observation", "SAO 192107"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.83788876),
        dec: Angle.Degrees(-25.35805529)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23757"},
        {"Hipparcos Number", "HIP 17635"},
        {"Smithsonian Astrophysical Observation", "SAO 168823"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.67410656),
        dec: Angle.Degrees(-25.35730703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 268"},
        {"Hipparcos Number", "HIP 606"},
        {"Geneva Identification System", "GEN# +1.00000268"},
        {"Smithsonian Astrophysical Observation", "SAO 166063"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.84336535),
        dec: Angle.Degrees(-25.35632439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 210.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -133.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34473"},
        {"Hipparcos Number", "HIP 24598"},
        {"Smithsonian Astrophysical Observation", "SAO 170265"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.14749520),
        dec: Angle.Degrees(-25.33200050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147809"},
        {"Hipparcos Number", "HIP 80425"},
        {"Geneva Identification System", "GEN# +1.00147809"},
        {"Smithsonian Astrophysical Observation", "SAO 184372"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.24647312),
        dec: Angle.Degrees(-25.35493573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212536"},
        {"Hipparcos Number", "HIP 110685"},
        {"Smithsonian Astrophysical Observation", "SAO 191126"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.36659999),
        dec: Angle.Degrees(-25.35477865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208770"},
        {"Hipparcos Number", "HIP 108520"},
        {"Smithsonian Astrophysical Observation", "SAO 190789"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.77754315),
        dec: Angle.Degrees(-25.35428908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120425"},
        {"Hipparcos Number", "HIP 67490"},
        {"Smithsonian Astrophysical Observation", "SAO 181995"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.45209833),
        dec: Angle.Degrees(-25.35307700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44623"},
        {"Hipparcos Number", "HIP 30236"},
        {"Geneva Identification System", "GEN# +1.00044623"},
        {"Smithsonian Astrophysical Observation", "SAO 171626"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.41772264),
        dec: Angle.Degrees(-25.35137974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22700",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3507 A"},
        {"Henry Draper", "HD 31199"},
        {"Hipparcos Number", "HIP 22700"},
        {"Smithsonian Astrophysical Observation", "SAO 169838"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.20670475),
        dec: Angle.Degrees(-25.35129992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214852"},
        {"Hipparcos Number", "HIP 112015"},
        {"Geneva Identification System", "GEN# +1.00214852"},
        {"Smithsonian Astrophysical Observation", "SAO 191328"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.34423241),
        dec: Angle.Degrees(-25.35029308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 162.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174578"},
        {"Hipparcos Number", "HIP 92610"},
        {"Geneva Identification System", "GEN# +1.00174578"},
        {"Smithsonian Astrophysical Observation", "SAO 187382"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.215,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.05526469),
        dec: Angle.Degrees(-25.34965234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35993"},
        {"Hipparcos Number", "HIP 25521"},
        {"Geneva Identification System", "GEN# +1.00035993"},
        {"Smithsonian Astrophysical Observation", "SAO 170442"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.86499657),
        dec: Angle.Degrees(-25.34165721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60879"},
        {"Hipparcos Number", "HIP 36944"},
        {"Smithsonian Astrophysical Observation", "SAO 174075"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.92276491),
        dec: Angle.Degrees(-25.34058517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75735"},
        {"Smithsonian Astrophysical Observation", "SAO 183493"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.08455427),
        dec: Angle.Degrees(-25.33821178)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86245"},
        {"Hipparcos Number", "HIP 48757"},
        {"Geneva Identification System", "GEN# +1.00086245"},
        {"Smithsonian Astrophysical Observation", "SAO 178213"},
        {"Wilson Evans Batten Catalogue", "WEB 9067"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.17207140),
        dec: Angle.Degrees(-25.33724834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81542"},
        {"Hipparcos Number", "HIP 46238"},
        {"Fundamental Katalog 5th Edition", "FK5 4841"},
        {"Smithsonian Astrophysical Observation", "SAO 177427"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.40447765),
        dec: Angle.Degrees(-25.33709790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17320"},
        {"Hipparcos Number", "HIP 12920"},
        {"Smithsonian Astrophysical Observation", "SAO 168034"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.53362258),
        dec: Angle.Degrees(-25.33453558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61071"},
        {"Hipparcos Number", "HIP 37025"},
        {"Geneva Identification System", "GEN# +1.00061071J"},
        {"Smithsonian Astrophysical Observation", "SAO 174112"},
        {"Wilson Evans Batten Catalogue", "WEB 7344"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13259979),
        dec: Angle.Degrees(-25.33279413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17029 A"},
        {"Henry Draper", "HD 223466"},
        {"Hipparcos Number", "HIP 117510"},
        {"Renson", "Renson 61232"},
        {"Smithsonian Astrophysical Observation", "SAO 192180"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.45670537),
        dec: Angle.Degrees(-25.33128970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63776",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63776"},
        {"Smithsonian Astrophysical Observation", "SAO 181363"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.08088287),
        dec: Angle.Degrees(-25.33056673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108479"},
        {"Hipparcos Number", "HIP 60811"},
        {"Smithsonian Astrophysical Observation", "SAO 180816"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.95947689),
        dec: Angle.Degrees(-25.32823219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -173.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77840",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9823 AB"},
        {"Henry Draper", "HD 142114"},
        {"Hipparcos Number", "HIP 77840"},
        {"Celescope Catalog", "CEL 4399"},
        {"Geneva Identification System", "GEN# +1.00142114J"},
        {"Smithsonian Astrophysical Observation", "SAO 183896"},
        {"Wilson Evans Batten Catalogue", "WEB 13164"},
    },
    visualMagnitude: 4.59,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.40303498),
        dec: Angle.Degrees(-25.32708018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64685",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64685"},
        {"Smithsonian Astrophysical Observation", "SAO 181489"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.86559125),
        dec: Angle.Degrees(-25.32520513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9205"},
        {"Hipparcos Number", "HIP 7006"},
        {"Geneva Identification System", "GEN# +1.00009205"},
        {"Smithsonian Astrophysical Observation", "SAO 167091"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.54516689),
        dec: Angle.Degrees(-25.32271464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123905"},
        {"Hipparcos Number", "HIP 69279"},
        {"Smithsonian Astrophysical Observation", "SAO 182316"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.72793383),
        dec: Angle.Degrees(-25.32100731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166193"},
        {"Hipparcos Number", "HIP 89057"},
        {"Smithsonian Astrophysical Observation", "SAO 186407"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.65230714),
        dec: Angle.Degrees(-25.32052838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6581",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1127 AB"},
        {"Henry Draper", "HD 8603"},
        {"Hipparcos Number", "HIP 6581"},
        {"Geneva Identification System", "GEN# +1.00008603J"},
        {"Smithsonian Astrophysical Observation", "SAO 167024"},
        {"Wilson Evans Batten Catalogue", "WEB 1444"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.13392808),
        dec: Angle.Degrees(-25.31971217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134114"},
        {"Hipparcos Number", "HIP 74114"},
        {"Geneva Identification System", "GEN# +1.00134114"},
        {"Smithsonian Astrophysical Observation", "SAO 183208"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.20054853),
        dec: Angle.Degrees(-25.31965174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16988"},
        {"Hipparcos Number", "HIP 12666"},
        {"Geneva Identification System", "GEN# +1.00016988"},
        {"Smithsonian Astrophysical Observation", "SAO 167993"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.68565039),
        dec: Angle.Degrees(-25.31909305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126191"},
        {"Hipparcos Number", "HIP 70442"},
        {"Smithsonian Astrophysical Observation", "SAO 182515"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.15670047),
        dec: Angle.Degrees(-25.31835621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205343"},
        {"Hipparcos Number", "HIP 106591"},
        {"Fundamental Katalog 5th Edition", "FK5 5907"},
        {"Geneva Identification System", "GEN# +1.00205343"},
        {"Smithsonian Astrophysical Observation", "SAO 190470"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.82303289),
        dec: Angle.Degrees(-25.31811305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72156"},
        {"Hipparcos Number", "HIP 41718"},
        {"Smithsonian Astrophysical Observation", "SAO 175969"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.60395202),
        dec: Angle.Degrees(-25.31755593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7625 A"},
        {"Henry Draper", "HD 87318"},
        {"Hipparcos Number", "HIP 49294"},
        {"Geneva Identification System", "GEN# +1.00008731"},
        {"Smithsonian Astrophysical Observation", "SAO 178357"},
    },
    visualMagnitude: 6.71,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.92345878),
        dec: Angle.Degrees(-25.31673522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127269"},
        {"Hipparcos Number", "HIP 70972"},
        {"Smithsonian Astrophysical Observation", "SAO 182624"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.75294441),
        dec: Angle.Degrees(-25.31495708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100582"},
        {"Hipparcos Number", "HIP 56451"},
        {"Smithsonian Astrophysical Observation", "SAO 179996"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.61758728),
        dec: Angle.Degrees(-25.31467998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97995"},
        {"Hipparcos Number", "HIP 55041"},
        {"Smithsonian Astrophysical Observation", "SAO 179709"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.01385773),
        dec: Angle.Degrees(-25.31445816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164741"},
        {"Hipparcos Number", "HIP 88463"},
        {"Geneva Identification System", "GEN# +1.00164741"},
        {"Smithsonian Astrophysical Observation", "SAO 186193"},
        {"Wilson Evans Batten Catalogue", "WEB 14961"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.93367418),
        dec: Angle.Degrees(-25.31251891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30983"},
        {"Hipparcos Number", "HIP 22543"},
        {"Smithsonian Astrophysical Observation", "SAO 169815"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.78151466),
        dec: Angle.Degrees(-25.31000262)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134987"},
        {"Hipparcos Number", "HIP 74500"},
        {"Cincinnati Publication", "Ci 20 916"},
        {"Geneva Identification System", "GEN# +1.00134987"},
        {"Smithsonian Astrophysical Observation", "SAO 183275"},
        {"Wilson Evans Batten Catalogue", "WEB 12710"},
    },
    visualMagnitude: 6.47,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.37052116),
        dec: Angle.Degrees(-25.30916439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -399.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6189"},
        {"Hipparcos Number", "HIP 4874"},
        {"Geneva Identification System", "GEN# +1.00006189"},
        {"Smithsonian Astrophysical Observation", "SAO 166763"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.66501836),
        dec: Angle.Degrees(-25.30834160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 281.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108725"},
        {"Hipparcos Number", "HIP 60954"},
        {"Smithsonian Astrophysical Observation", "SAO 180840"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.42105836),
        dec: Angle.Degrees(-25.30796601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16929"},
        {"Hipparcos Number", "HIP 12615"},
        {"Smithsonian Astrophysical Observation", "SAO 167980"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.54036454),
        dec: Angle.Degrees(-25.30755620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156061"},
        {"Hipparcos Number", "HIP 84494"},
        {"Smithsonian Astrophysical Observation", "SAO 185219"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.11531171),
        dec: Angle.Degrees(-25.30542304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187383"},
        {"Hipparcos Number", "HIP 97637"},
        {"Smithsonian Astrophysical Observation", "SAO 188619"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.66519801),
        dec: Angle.Degrees(-25.30533583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18290"},
        {"Hipparcos Number", "HIP 13626"},
        {"Smithsonian Astrophysical Observation", "SAO 168150"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.87329003),
        dec: Angle.Degrees(-25.30450033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118102"},
        {"Hipparcos Number", "HIP 66281"},
        {"Geneva Identification System", "GEN# +1.00118102"},
        {"Smithsonian Astrophysical Observation", "SAO 181770"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.77139077),
        dec: Angle.Degrees(-25.30419519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38594",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38594"},
        {"Smithsonian Astrophysical Observation", "SAO 174768"},
    },
    visualMagnitude: 9.75,
    bvColour: 1.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.54615276),
        dec: Angle.Degrees(-25.30366157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -299.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 200.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79977"},
        {"Hipparcos Number", "HIP 45512"},
        {"Smithsonian Astrophysical Observation", "SAO 177198"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.11948898),
        dec: Angle.Degrees(-25.30299403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14464"},
        {"Hipparcos Number", "HIP 10841"},
        {"Smithsonian Astrophysical Observation", "SAO 167703"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.88932347),
        dec: Angle.Degrees(-25.30255746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56067"},
        {"Hipparcos Number", "HIP 35012"},
        {"Celescope Catalog", "CEL 1703"},
        {"Smithsonian Astrophysical Observation", "SAO 173276"},
    },
    visualMagnitude: 7.32,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64246819),
        dec: Angle.Degrees(-25.30239673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204781"},
        {"Hipparcos Number", "HIP 106289"},
        {"Geneva Identification System", "GEN# +1.00204781"},
        {"Smithsonian Astrophysical Observation", "SAO 190409"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.91610739),
        dec: Angle.Degrees(-25.30108605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138065"},
        {"Hipparcos Number", "HIP 75927"},
        {"Smithsonian Astrophysical Observation", "SAO 183528"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.61480705),
        dec: Angle.Degrees(-25.30002704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224226"},
        {"Hipparcos Number", "HIP 118000"},
        {"Smithsonian Astrophysical Observation", "SAO 192249"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.02922730),
        dec: Angle.Degrees(-25.29845585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83332"},
        {"Hipparcos Number", "HIP 47187"},
        {"Geneva Identification System", "GEN# +1.00083332"},
        {"Smithsonian Astrophysical Observation", "SAO 177748"},
        {"Wilson Evans Batten Catalogue", "WEB 8876"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.25103185),
        dec: Angle.Degrees(-25.29684739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111431"},
        {"Hipparcos Number", "HIP 62583"},
        {"Geneva Identification System", "GEN# +1.00111431"},
        {"Smithsonian Astrophysical Observation", "SAO 181131"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.35607117),
        dec: Angle.Degrees(-25.29623180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -112.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 543"},
        {"Smithsonian Astrophysical Observation", "SAO 166048"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.65072541),
        dec: Angle.Degrees(-25.29566618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26777"},
        {"Hipparcos Number", "HIP 19698"},
        {"Smithsonian Astrophysical Observation", "SAO 169234"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.29981480),
        dec: Angle.Degrees(-25.29324255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36239"},
        {"Hipparcos Number", "HIP 25697"},
        {"Smithsonian Astrophysical Observation", "SAO 170477"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.32110066),
        dec: Angle.Degrees(-25.29012999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17643"},
        {"Hipparcos Number", "HIP 13156"},
        {"Smithsonian Astrophysical Observation", "SAO 168071"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.29507002),
        dec: Angle.Degrees(-25.28906814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89537"},
        {"Hipparcos Number", "HIP 50541"},
        {"Smithsonian Astrophysical Observation", "SAO 178681"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.85140296),
        dec: Angle.Degrees(-25.28752838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153592"},
        {"Hipparcos Number", "HIP 83301"},
        {"Geneva Identification System", "GEN# +1.00153592"},
        {"Smithsonian Astrophysical Observation", "SAO 184927"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.36427228),
        dec: Angle.Degrees(-25.28751225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191301"},
        {"Hipparcos Number", "HIP 99365"},
        {"Geneva Identification System", "GEN# +1.00191301"},
        {"Smithsonian Astrophysical Observation", "SAO 188977"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.52808721),
        dec: Angle.Degrees(-25.28399088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2426"},
        {"Hipparcos Number", "HIP 2203"},
        {"Smithsonian Astrophysical Observation", "SAO 166286"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.96308823),
        dec: Angle.Degrees(-25.28186263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73714",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Brachium"},
        {"Henry Draper", "HD 133216"},
        {"Hipparcos Number", "HIP 73714"},
        {"Fundamental Katalog 5th Edition", "FK5 556"},
        {"Geneva Identification System", "GEN# +1.00133216"},
        {"Smithsonian Astrophysical Observation", "SAO 183139"},
        {"Wilson Evans Batten Catalogue", "WEB 12601"},
    },
    visualMagnitude: 3.25,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.01775793),
        dec: Angle.Degrees(-25.28185602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23519"},
    },
    visualMagnitude: 11.96,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.84510795),
        dec: Angle.Degrees(-25.16373896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11889"},
        {"Hipparcos Number", "HIP 9029"},
        {"Smithsonian Astrophysical Observation", "SAO 167412"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.07411686),
        dec: Angle.Degrees(-25.28072599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 125.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65719"},
        {"Hipparcos Number", "HIP 39020"},
        {"Smithsonian Astrophysical Observation", "SAO 174933"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.77167258),
        dec: Angle.Degrees(-25.27694643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42416"},
        {"Hipparcos Number", "HIP 29199"},
        {"Geneva Identification System", "GEN# +1.00042416"},
        {"Smithsonian Astrophysical Observation", "SAO 171311"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.38622052),
        dec: Angle.Degrees(-25.27557676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18692"},
        {"Hipparcos Number", "HIP 13942"},
        {"Geneva Identification System", "GEN# +1.00018692"},
        {"Smithsonian Astrophysical Observation", "SAO 168209"},
        {"Wilson Evans Batten Catalogue", "WEB 2750"},
    },
    visualMagnitude: 5.69,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.90027293),
        dec: Angle.Degrees(-25.27433851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 181.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73045"},
        {"Smithsonian Astrophysical Observation", "SAO 183004"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.92514069),
        dec: Angle.Degrees(-25.27192213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157883"},
        {"Hipparcos Number", "HIP 85395"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.75359642),
        dec: Angle.Degrees(-25.27152566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197692"},
        {"Hipparcos Number", "HIP 102485"},
        {"Fundamental Katalog 5th Edition", "FK5 779"},
        {"Geneva Identification System", "GEN# +1.00197692"},
        {"Smithsonian Astrophysical Observation", "SAO 189664"},
        {"Wilson Evans Batten Catalogue", "WEB 18561"},
    },
    visualMagnitude: 4.13,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.52402547),
        dec: Angle.Degrees(-25.27051682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106767"},
        {"Hipparcos Number", "HIP 59871"},
        {"Smithsonian Astrophysical Observation", "SAO 180639"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.605,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.18293173),
        dec: Angle.Degrees(-25.26986872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42949"},
        {"Hipparcos Number", "HIP 29474"},
        {"Smithsonian Astrophysical Observation", "SAO 171391"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.15521594),
        dec: Angle.Degrees(-25.26863705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152228"},
        {"Hipparcos Number", "HIP 82600"},
        {"Smithsonian Astrophysical Observation", "SAO 184750"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.28553330),
        dec: Angle.Degrees(-25.26858245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109223"},
        {"Hipparcos Number", "HIP 61263"},
        {"Smithsonian Astrophysical Observation", "SAO 180892"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.32932009),
        dec: Angle.Degrees(-25.26737818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52568"},
        {"Hipparcos Number", "HIP 33759"},
        {"Smithsonian Astrophysical Observation", "SAO 172747"},
    },
    visualMagnitude: 10.03,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.17574362),
        dec: Angle.Degrees(-25.26616604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155430"},
        {"Hipparcos Number", "HIP 84186"},
        {"Smithsonian Astrophysical Observation", "SAO 185146"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13764869),
        dec: Angle.Degrees(-25.26521435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44785"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.91509928),
        dec: Angle.Degrees(-25.26188737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -255.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 56.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225070"},
        {"Hipparcos Number", "HIP 251"},
        {"Smithsonian Astrophysical Observation", "SAO 166015"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.77540550),
        dec: Angle.Degrees(-25.26104885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36088",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36088"},
        {"Geneva Identification System", "GEN# -0.02504516"},
        {"Wilson Evans Batten Catalogue", "WEB 7189"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.53000500),
        dec: Angle.Degrees(-25.25737034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94643",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12214 AB"},
        {"Henry Draper", "HD 179950"},
        {"Hipparcos Number", "HIP 94643"},
        {"Geneva Identification System", "GEN# +1.00179950"},
        {"Renson", "Renson 49940"},
        {"Smithsonian Astrophysical Observation", "SAO 187882"},
        {"Wilson Evans Batten Catalogue", "WEB 16497"},
        {"Wilson Evans Batten Catalogue 2", "WEB 16502"},
    },
    visualMagnitude: 4.86,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.88498822),
        dec: Angle.Degrees(-25.25660677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170235"},
        {"Hipparcos Number", "HIP 90610"},
        {"Geneva Identification System", "GEN# +1.00170235"},
        {"Smithsonian Astrophysical Observation", "SAO 186873"},
        {"Wilson Evans Batten Catalogue", "WEB 15517"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.34161167),
        dec: Angle.Degrees(-25.25658911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115682"},
        {"Hipparcos Number", "HIP 64966"},
        {"Smithsonian Astrophysical Observation", "SAO 181545"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.73865836),
        dec: Angle.Degrees(-25.25548067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155379"},
        {"Hipparcos Number", "HIP 84147"},
        {"Geneva Identification System", "GEN# +1.00155379"},
        {"Renson", "Renson 43930"},
        {"Smithsonian Astrophysical Observation", "SAO 185138"},
    },
    visualMagnitude: 6.52,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.05676354),
        dec: Angle.Degrees(-25.25503146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39914"},
        {"Hipparcos Number", "HIP 27927"},
        {"Smithsonian Astrophysical Observation", "SAO 170998"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.64101185),
        dec: Angle.Degrees(-25.25398722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220067"},
        {"Hipparcos Number", "HIP 115296"},
        {"Smithsonian Astrophysical Observation", "SAO 191838"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.27233608),
        dec: Angle.Degrees(-25.25308693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34690"},
        {"Hipparcos Number", "HIP 24736"},
        {"Geneva Identification System", "GEN# +1.00034690"},
        {"Smithsonian Astrophysical Observation", "SAO 170291"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.56469261),
        dec: Angle.Degrees(-25.25217004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76105"},
        {"Hipparcos Number", "HIP 43641"},
        {"Smithsonian Astrophysical Observation", "SAO 176637"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.33093555),
        dec: Angle.Degrees(-25.24696143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29449",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4817 AB"},
        {"Henry Draper", "HD 42899"},
        {"Hipparcos Number", "HIP 29449"},
        {"Smithsonian Astrophysical Observation", "SAO 171379"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.07376080),
        dec: Angle.Degrees(-25.24504831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99461"},
        {"Hipparcos Number", "HIP 55824"},
        {"Smithsonian Astrophysical Observation", "SAO 179886"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.61689777),
        dec: Angle.Degrees(-25.24447473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142301"},
        {"Hipparcos Number", "HIP 77909"},
        {"Celescope Catalog", "CEL 4403"},
        {"Geneva Identification System", "GEN# +1.00142301"},
        {"Renson", "Renson 40380"},
        {"Smithsonian Astrophysical Observation", "SAO 183914"},
        {"Wilson Evans Batten Catalogue", "WEB 13174"},
    },
    visualMagnitude: 5.87,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.66474184),
        dec: Angle.Degrees(-25.24367939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37688"},
        {"Hipparcos Number", "HIP 26610"},
        {"Geneva Identification System", "GEN# +1.00037688"},
        {"Smithsonian Astrophysical Observation", "SAO 170649"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.85089447),
        dec: Angle.Degrees(-25.24323339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111391",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111391"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.50230691),
        dec: Angle.Degrees(-25.24169067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -302.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168710"},
        {"Hipparcos Number", "HIP 90019"},
        {"Geneva Identification System", "GEN# +1.00168710"},
        {"Smithsonian Astrophysical Observation", "SAO 186718"},
        {"Wilson Evans Batten Catalogue", "WEB 15378"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.52825966),
        dec: Angle.Degrees(-25.23991574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133931"},
        {"Hipparcos Number", "HIP 74038"},
        {"Geneva Identification System", "GEN# +1.00133931"},
        {"Smithsonian Astrophysical Observation", "SAO 183198"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.96544151),
        dec: Angle.Degrees(-25.23907894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203931"},
        {"Hipparcos Number", "HIP 105814"},
        {"Smithsonian Astrophysical Observation", "SAO 190329"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.45158967),
        dec: Angle.Degrees(-25.23786515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21136"},
        {"Hipparcos Number", "HIP 15828"},
        {"Smithsonian Astrophysical Observation", "SAO 168509"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.97553271),
        dec: Angle.Degrees(-25.23720194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215452"},
        {"Hipparcos Number", "HIP 112362"},
        {"Smithsonian Astrophysical Observation", "SAO 191382"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.38482554),
        dec: Angle.Degrees(-25.23694138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41196"},
        {"Hipparcos Number", "HIP 28619"},
        {"Smithsonian Astrophysical Observation", "SAO 171165"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.61991563),
        dec: Angle.Degrees(-25.23644567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7279"},
        {"Hipparcos Number", "HIP 5663"},
        {"Geneva Identification System", "GEN# +1.00007279"},
        {"Smithsonian Astrophysical Observation", "SAO 166878"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.19186846),
        dec: Angle.Degrees(-25.23562704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 128.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193992"},
        {"Hipparcos Number", "HIP 100611"},
        {"Smithsonian Astrophysical Observation", "SAO 189239"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.02623758),
        dec: Angle.Degrees(-25.23376491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54912"},
        {"Hipparcos Number", "HIP 34579"},
        {"Celescope Catalog", "CEL 1630"},
        {"Geneva Identification System", "GEN# +1.00054912J"},
        {"Smithsonian Astrophysical Observation", "SAO 173101"},
        {"Wilson Evans Batten Catalogue", "WEB 6920"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.42928078),
        dec: Angle.Degrees(-25.23104384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177213"},
        {"Hipparcos Number", "HIP 93691"},
        {"Smithsonian Astrophysical Observation", "SAO 187644"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.19105393),
        dec: Angle.Degrees(-25.23103408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152486"},
        {"Hipparcos Number", "HIP 82736"},
        {"Smithsonian Astrophysical Observation", "SAO 184781"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.66602210),
        dec: Angle.Degrees(-25.22970306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193193"},
        {"Hipparcos Number", "HIP 100233"},
        {"Geneva Identification System", "GEN# +1.00193193"},
        {"Smithsonian Astrophysical Observation", "SAO 189151"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.93859756),
        dec: Angle.Degrees(-25.22824312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155415"},
        {"Hipparcos Number", "HIP 84181"},
        {"Geneva Identification System", "GEN# +1.00155415"},
        {"Smithsonian Astrophysical Observation", "SAO 185145"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.13028581),
        dec: Angle.Degrees(-25.22703170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98403"},
        {"Hipparcos Number", "HIP 55255"},
        {"Fundamental Katalog 5th Edition", "FK5 4995"},
        {"Geneva Identification System", "GEN# +1.00098403"},
        {"Smithsonian Astrophysical Observation", "SAO 179763"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.75330548),
        dec: Angle.Degrees(-25.22626866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13610"},
    },
    visualMagnitude: 11.38,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.84582721),
        dec: Angle.Degrees(-25.22454236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 315.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -107.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206020"},
        {"Hipparcos Number", "HIP 106975"},
        {"Smithsonian Astrophysical Observation", "SAO 190529"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.98096177),
        dec: Angle.Degrees(-25.22419931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -74.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91123"},
        {"Hipparcos Number", "HIP 51469"},
        {"Smithsonian Astrophysical Observation", "SAO 178914"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.70015185),
        dec: Angle.Degrees(-25.22325307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67122"},
        {"Hipparcos Number", "HIP 39600"},
        {"Smithsonian Astrophysical Observation", "SAO 175150"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.38755562),
        dec: Angle.Degrees(-25.22161337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116635",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16883 A"},
        {"Henry Draper", "HD 222134"},
        {"Hipparcos Number", "HIP 116635"},
        {"Smithsonian Astrophysical Observation", "SAO 192048"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.54113906),
        dec: Angle.Degrees(-25.22106096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 132.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39484"},
        {"Hipparcos Number", "HIP 27698"},
        {"Smithsonian Astrophysical Observation", "SAO 170941"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.97633400),
        dec: Angle.Degrees(-25.21923397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58612"},
        {"Hipparcos Number", "HIP 36024"},
        {"Celescope Catalog", "CEL 1840"},
        {"Fundamental Katalog 5th Edition", "FK5 2574"},
        {"Geneva Identification System", "GEN# +5.11210047"},
        {"Smithsonian Astrophysical Observation", "SAO 173697"},
        {"Wilson Evans Batten Catalogue", "WEB 7174"},
    },
    visualMagnitude: 5.79,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.35530599),
        dec: Angle.Degrees(-25.21776450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173618"},
        {"Hipparcos Number", "HIP 92185"},
        {"Smithsonian Astrophysical Observation", "SAO 187280"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.82437952),
        dec: Angle.Degrees(-25.21623250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52670"},
        {"Hipparcos Number", "HIP 33804"},
        {"Celescope Catalog", "CEL 1508"},
        {"Geneva Identification System", "GEN# +1.00052670"},
        {"Smithsonian Astrophysical Observation", "SAO 172763"},
        {"Wilson Evans Batten Catalogue", "WEB 6785"},
    },
    visualMagnitude: 5.64,
    bvColour: -0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.27478853),
        dec: Angle.Degrees(-25.21564581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141091"},
        {"Hipparcos Number", "HIP 77399"},
        {"Smithsonian Astrophysical Observation", "SAO 183802"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.01378482),
        dec: Angle.Degrees(-25.21555184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1797"},
        {"Hipparcos Number", "HIP 1754"},
        {"Geneva Identification System", "GEN# +1.00001797"},
        {"Smithsonian Astrophysical Observation", "SAO 166220"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.55813896),
        dec: Angle.Degrees(-25.21502749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114963"},
        {"Hipparcos Number", "HIP 64589"},
        {"Smithsonian Astrophysical Observation", "SAO 181474"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.58028482),
        dec: Angle.Degrees(-25.21376721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117104"},
        {"Hipparcos Number", "HIP 65726"},
        {"Fundamental Katalog 5th Edition", "FK5 5187"},
        {"Geneva Identification System", "GEN# +1.00117104"},
        {"Smithsonian Astrophysical Observation", "SAO 181681"},
        {"Wilson Evans Batten Catalogue", "WEB 11631"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.11112189),
        dec: Angle.Degrees(-25.21283366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107956"},
        {"Hipparcos Number", "HIP 60519"},
        {"Geneva Identification System", "GEN# +1.00107956"},
        {"Smithsonian Astrophysical Observation", "SAO 180766"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.09023345),
        dec: Angle.Degrees(-25.21111754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84974"},
        {"Hipparcos Number", "HIP 48091"},
        {"Smithsonian Astrophysical Observation", "SAO 178015"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.07327728),
        dec: Angle.Degrees(-25.20824824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216403"},
        {"Hipparcos Number", "HIP 112985"},
        {"Smithsonian Astrophysical Observation", "SAO 191463"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.21610713),
        dec: Angle.Degrees(-25.20692295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64174"},
        {"Hipparcos Number", "HIP 38376"},
        {"Smithsonian Astrophysical Observation", "SAO 174683"},
    },
    visualMagnitude: 8.41,
    bvColour: -0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.93591223),
        dec: Angle.Degrees(-25.20689332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52726"},
        {"Hipparcos Number", "HIP 33828"},
        {"Smithsonian Astrophysical Observation", "SAO 172776"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.34009743),
        dec: Angle.Degrees(-25.20606173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187828"},
        {"Hipparcos Number", "HIP 97835"},
        {"Smithsonian Astrophysical Observation", "SAO 188665"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.21272043),
        dec: Angle.Degrees(-25.20516690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28936"},
        {"Hipparcos Number", "HIP 21193"},
        {"Smithsonian Astrophysical Observation", "SAO 169551"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.15760236),
        dec: Angle.Degrees(-25.20492473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105646",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203607"},
        {"Hipparcos Number", "HIP 105646"},
        {"Smithsonian Astrophysical Observation", "SAO 190292"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.98274393),
        dec: Angle.Degrees(-25.20242815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106792"},
    },
    visualMagnitude: 11.11,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.45461176),
        dec: Angle.Degrees(-25.20017020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 208.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14768"},
        {"Hipparcos Number", "HIP 11041"},
        {"Smithsonian Astrophysical Observation", "SAO 167733"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.54780537),
        dec: Angle.Degrees(-25.19947168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143472"},
        {"Hipparcos Number", "HIP 78494"},
        {"Renson", "Renson 40618"},
        {"Smithsonian Astrophysical Observation", "SAO 184032"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.36103498),
        dec: Angle.Degrees(-25.19844128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3917"},
        {"Hipparcos Number", "HIP 3266"},
        {"Smithsonian Astrophysical Observation", "SAO 166490"},
    },
    visualMagnitude: 6.55,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.39362990),
        dec: Angle.Degrees(-25.19645782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98828"},
        {"Hipparcos Number", "HIP 55519"},
        {"Smithsonian Astrophysical Observation", "SAO 179816"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.56712943),
        dec: Angle.Degrees(-25.19497617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3257 A"},
        {"Henry Draper", "HD 28521"},
        {"Hipparcos Number", "HIP 20909"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.22552204),
        dec: Angle.Degrees(-25.19487050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204609"},
        {"Hipparcos Number", "HIP 106185"},
        {"Geneva Identification System", "GEN# +1.00204609"},
        {"Smithsonian Astrophysical Observation", "SAO 190394"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.60844588),
        dec: Angle.Degrees(-25.19322939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51286"},
        {"Hipparcos Number", "HIP 33311"},
        {"Geneva Identification System", "GEN# +1.00051286"},
        {"Smithsonian Astrophysical Observation", "SAO 172587"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.93107712),
        dec: Angle.Degrees(-25.19232615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4998"},
        {"Hipparcos Number", "HIP 4043"},
        {"Smithsonian Astrophysical Observation", "SAO 166635"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.95912475),
        dec: Angle.Degrees(-25.19227510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18923"},
        {"Hipparcos Number", "HIP 14100"},
        {"Smithsonian Astrophysical Observation", "SAO 168240"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46365943),
        dec: Angle.Degrees(-25.19019908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163777"},
        {"Hipparcos Number", "HIP 88049"},
        {"Geneva Identification System", "GEN# +1.00163777"},
        {"Smithsonian Astrophysical Observation", "SAO 186038"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.75776237),
        dec: Angle.Degrees(-25.18955699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161626"},
        {"Hipparcos Number", "HIP 87093"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.93241935),
        dec: Angle.Degrees(-25.18882649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11644",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15634"},
        {"Hipparcos Number", "HIP 11644"},
        {"Geneva Identification System", "GEN# +1.00015634"},
        {"Smithsonian Astrophysical Observation", "SAO 167837"},
        {"Wilson Evans Batten Catalogue", "WEB 2424"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.55697441),
        dec: Angle.Degrees(-25.18651726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124026"},
        {"Hipparcos Number", "HIP 69349"},
        {"Smithsonian Astrophysical Observation", "SAO 182330"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.90069903),
        dec: Angle.Degrees(-25.18186344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210848"},
        {"Hipparcos Number", "HIP 109737"},
        {"Geneva Identification System", "GEN# +1.00210848"},
        {"Smithsonian Astrophysical Observation", "SAO 190976"},
        {"Wilson Evans Batten Catalogue", "WEB 19714"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.43494738),
        dec: Angle.Degrees(-25.18092537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24892"},
        {"Hipparcos Number", "HIP 18432"},
        {"Geneva Identification System", "GEN# +1.00024892"},
        {"Smithsonian Astrophysical Observation", "SAO 168977"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.11916193),
        dec: Angle.Degrees(-25.18066027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 106.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6111"},
        {"Smithsonian Astrophysical Observation", "SAO 166942"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.61337830),
        dec: Angle.Degrees(-25.18057853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125885"},
        {"Hipparcos Number", "HIP 70292"},
        {"Smithsonian Astrophysical Observation", "SAO 182481"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.72242903),
        dec: Angle.Degrees(-25.17961257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -176.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156492"},
        {"Hipparcos Number", "HIP 84695"},
        {"Smithsonian Astrophysical Observation", "SAO 185253"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.71030042),
        dec: Angle.Degrees(-25.17695705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25386"},
        {"Hipparcos Number", "HIP 18753"},
        {"Smithsonian Astrophysical Observation", "SAO 169032"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.25227535),
        dec: Angle.Degrees(-25.17503577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29422"},
        {"Hipparcos Number", "HIP 21498"},
        {"Smithsonian Astrophysical Observation", "SAO 169614"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.25861147),
        dec: Angle.Degrees(-25.17280723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58010"},
        {"Hipparcos Number", "HIP 35773"},
        {"Geneva Identification System", "GEN# +1.00058010"},
        {"Smithsonian Astrophysical Observation", "SAO 173583"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.68823785),
        dec: Angle.Degrees(-25.17162227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137613"},
        {"Hipparcos Number", "HIP 75694"},
        {"Geneva Identification System", "GEN# +1.00137613"},
        {"Smithsonian Astrophysical Observation", "SAO 183485"},
        {"Wilson Evans Batten Catalogue", "WEB 12886"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.95131661),
        dec: Angle.Degrees(-25.16945975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23470"},
        {"Hipparcos Number", "HIP 17463"},
        {"Smithsonian Astrophysical Observation", "SAO 168787"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.13755673),
        dec: Angle.Degrees(-25.16723398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44204",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7134 A"},
        {"Henry Draper", "HD 77203"},
        {"Hipparcos Number", "HIP 44204"},
        {"Smithsonian Astrophysical Observation", "SAO 176814"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.06717030),
        dec: Angle.Degrees(-25.16686488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214324"},
        {"Hipparcos Number", "HIP 111703"},
        {"Smithsonian Astrophysical Observation", "SAO 191277"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.42177388),
        dec: Angle.Degrees(-25.16653788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63296",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112615"},
        {"Hipparcos Number", "HIP 63296"},
        {"Smithsonian Astrophysical Observation", "SAO 181276"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.57579369),
        dec: Angle.Degrees(-25.16496935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203368"},
        {"Hipparcos Number", "HIP 105529"},
        {"Smithsonian Astrophysical Observation", "SAO 190273"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.60037523),
        dec: Angle.Degrees(-25.16411207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217303"},
        {"Hipparcos Number", "HIP 113562"},
        {"Geneva Identification System", "GEN# +1.00217303"},
        {"Smithsonian Astrophysical Observation", "SAO 191554"},
        {"Wilson Evans Batten Catalogue", "WEB 20187"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.02402543),
        dec: Angle.Degrees(-25.16398677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15190",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2441 AB"},
        {"Henry Draper", "HD 20376"},
        {"Hipparcos Number", "HIP 15190"},
        {"Smithsonian Astrophysical Observation", "SAO 168419"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.94449391),
        dec: Angle.Degrees(-25.16125793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30369"},
        {"Hipparcos Number", "HIP 22159"},
        {"Geneva Identification System", "GEN# +1.00030369"},
        {"Smithsonian Astrophysical Observation", "SAO 169744"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.51953565),
        dec: Angle.Degrees(-25.15925478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56637"},
        {"Hipparcos Number", "HIP 35229"},
        {"Geneva Identification System", "GEN# +1.00056637"},
        {"Smithsonian Astrophysical Observation", "SAO 173371"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20941877),
        dec: Angle.Degrees(-25.15901583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9907"},
        {"Smithsonian Astrophysical Observation", "SAO 167567"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.88312124),
        dec: Angle.Degrees(-25.15570155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47424"},
        {"Hipparcos Number", "HIP 31654"},
        {"Smithsonian Astrophysical Observation", "SAO 172046"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.37696326),
        dec: Angle.Degrees(-25.15474708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220023"},
        {"Hipparcos Number", "HIP 115264"},
        {"Geneva Identification System", "GEN# +1.00220023"},
        {"Smithsonian Astrophysical Observation", "SAO 191835"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.19332257),
        dec: Angle.Degrees(-25.15473532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166807"},
        {"Hipparcos Number", "HIP 89307"},
        {"Renson", "Renson 46930"},
        {"Smithsonian Astrophysical Observation", "SAO 186484"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.34385703),
        dec: Angle.Degrees(-25.15130042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15349 AB"},
        {"Henry Draper", "HD 207477"},
        {"Hipparcos Number", "HIP 107765"},
        {"Smithsonian Astrophysical Observation", "SAO 190661"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.46998023),
        dec: Angle.Degrees(-25.15117522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141441"},
        {"Hipparcos Number", "HIP 77545"},
        {"Smithsonian Astrophysical Observation", "SAO 183836"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.49913654),
        dec: Angle.Degrees(-25.15093207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148212"},
        {"Hipparcos Number", "HIP 80609"},
        {"Geneva Identification System", "GEN# +1.00148212"},
        {"Smithsonian Astrophysical Observation", "SAO 184399"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.88107705),
        dec: Angle.Degrees(-25.15048453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12406"},
        {"Hipparcos Number", "HIP 9425"},
        {"Smithsonian Astrophysical Observation", "SAO 167488"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.26905962),
        dec: Angle.Degrees(-25.14896179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4258 AB"},
        {"Henry Draper", "HD 37713"},
        {"Hipparcos Number", "HIP 26626"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.89273869),
        dec: Angle.Degrees(-25.14821050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216432"},
        {"Hipparcos Number", "HIP 113002"},
        {"Geneva Identification System", "GEN# +1.00216432"},
        {"Smithsonian Astrophysical Observation", "SAO 191464"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.27741129),
        dec: Angle.Degrees(-25.14803788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148579"},
        {"Hipparcos Number", "HIP 80804"},
        {"Geneva Identification System", "GEN# +1.00148579"},
        {"Renson", "Renson 41980"},
        {"Smithsonian Astrophysical Observation", "SAO 184425"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.49672405),
        dec: Angle.Degrees(-25.14771672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103606"},
        {"Hipparcos Number", "HIP 58169"},
        {"Smithsonian Astrophysical Observation", "SAO 180308"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.94710874),
        dec: Angle.Degrees(-25.14643943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59652"},
        {"Hipparcos Number", "HIP 36451"},
        {"Geneva Identification System", "GEN# +1.00059652"},
        {"Smithsonian Astrophysical Observation", "SAO 173873"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50880593),
        dec: Angle.Degrees(-25.14622463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76662",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76662"},
        {"Smithsonian Astrophysical Observation", "SAO 183663"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.82383419),
        dec: Angle.Degrees(-25.14602098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223366"},
        {"Hipparcos Number", "HIP 117454"},
        {"Smithsonian Astrophysical Observation", "SAO 192169"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.23724556),
        dec: Angle.Degrees(-25.14459928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53805",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53805"},
        {"Geneva Identification System", "GEN# -0.02409457"},
        {"Smithsonian Astrophysical Observation", "SAO 179424"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.788,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.13582701),
        dec: Angle.Degrees(-25.14318077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154702"},
        {"Hipparcos Number", "HIP 83840"},
        {"Smithsonian Astrophysical Observation", "SAO 185053"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.01108048),
        dec: Angle.Degrees(-25.14316202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214383"},
        {"Hipparcos Number", "HIP 111742"},
        {"Geneva Identification System", "GEN# +1.00214383"},
        {"Smithsonian Astrophysical Observation", "SAO 191285"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.53284307),
        dec: Angle.Degrees(-25.14128398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6761 AB"},
        {"Henry Draper", "HD 70393"},
        {"Hipparcos Number", "HIP 40900"},
        {"Renson", "Renson 19435"},
        {"Smithsonian Astrophysical Observation", "SAO 175645"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.19953418),
        dec: Angle.Degrees(-25.13424836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26601"},
        {"Hipparcos Number", "HIP 19567"},
        {"Wilson Evans Batten Catalogue", "WEB 3744"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.87929126),
        dec: Angle.Degrees(-25.13394336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184392"},
        {"Hipparcos Number", "HIP 96333"},
        {"Smithsonian Astrophysical Observation", "SAO 188308"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.79033698),
        dec: Angle.Degrees(-25.13361246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -308.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25791"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.60998226),
        dec: Angle.Degrees(-25.13163080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -85.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9075"},
        {"Hipparcos Number", "HIP 6902"},
        {"Smithsonian Astrophysical Observation", "SAO 167081"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.22083713),
        dec: Angle.Degrees(-25.13119330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86463"},
        {"Hipparcos Number", "HIP 48884"},
        {"Smithsonian Astrophysical Observation", "SAO 178247"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.55834184),
        dec: Angle.Degrees(-25.13112151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116481"},
        {"Hipparcos Number", "HIP 65400"},
        {"Smithsonian Astrophysical Observation", "SAO 181622"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.06239637),
        dec: Angle.Degrees(-25.12889331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12656"},
        {"Hipparcos Number", "HIP 9592"},
        {"Smithsonian Astrophysical Observation", "SAO 167524"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85398449),
        dec: Angle.Degrees(-25.12757861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144748"},
        {"Hipparcos Number", "HIP 79064"},
        {"Geneva Identification System", "GEN# +1.00144748"},
        {"Renson", "Renson 41020"},
        {"Smithsonian Astrophysical Observation", "SAO 184150"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.08667567),
        dec: Angle.Degrees(-25.12710329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34867"},
        {"Hipparcos Number", "HIP 24840"},
        {"Smithsonian Astrophysical Observation", "SAO 170313"},
    },
    visualMagnitude: 6.94,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.87993331),
        dec: Angle.Degrees(-25.12411950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1589"},
        {"Hipparcos Number", "HIP 1597"},
        {"Geneva Identification System", "GEN# +1.00001589"},
        {"Smithsonian Astrophysical Observation", "SAO 166193"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.99148067),
        dec: Angle.Degrees(-25.12166685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146156"},
        {"Hipparcos Number", "HIP 79684"},
        {"Geneva Identification System", "GEN# +1.00146156"},
        {"Smithsonian Astrophysical Observation", "SAO 184267"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.94534740),
        dec: Angle.Degrees(-25.12126747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128204"},
        {"Hipparcos Number", "HIP 71414"},
        {"Geneva Identification System", "GEN# +1.00128204"},
        {"Smithsonian Astrophysical Observation", "SAO 182689"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.06449760),
        dec: Angle.Degrees(-25.12122288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209548"},
        {"Hipparcos Number", "HIP 108985"},
        {"Smithsonian Astrophysical Observation", "SAO 190867"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.18462726),
        dec: Angle.Degrees(-25.12017125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167522"},
        {"Hipparcos Number", "HIP 89573"},
        {"Smithsonian Astrophysical Observation", "SAO 186577"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.17619084),
        dec: Angle.Degrees(-25.11889103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145277"},
        {"Hipparcos Number", "HIP 79301"},
        {"Smithsonian Astrophysical Observation", "SAO 184198"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.75760910),
        dec: Angle.Degrees(-25.11779814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46685",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7410 A"},
        {"Henry Draper", "HD 82398"},
        {"Hipparcos Number", "HIP 46685"},
        {"Geneva Identification System", "GEN# +1.00082398"},
        {"Smithsonian Astrophysical Observation", "SAO 177590"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.76010238),
        dec: Angle.Degrees(-25.11517428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -331.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148605"},
        {"Hipparcos Number", "HIP 80815"},
        {"Geneva Identification System", "GEN# +1.00148605"},
        {"Smithsonian Astrophysical Observation", "SAO 184429"},
        {"Wilson Evans Batten Catalogue", "WEB 13666"},
    },
    visualMagnitude: 4.79,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.55199128),
        dec: Angle.Degrees(-25.11515935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147032"},
        {"Hipparcos Number", "HIP 80049"},
        {"Smithsonian Astrophysical Observation", "SAO 184324"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.08983157),
        dec: Angle.Degrees(-25.11495995)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138600"},
        {"Hipparcos Number", "HIP 76201"},
        {"Geneva Identification System", "GEN# +1.00138600"},
        {"Smithsonian Astrophysical Observation", "SAO 183572"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.47842611),
        dec: Angle.Degrees(-25.11046348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129417"},
        {"Hipparcos Number", "HIP 71970"},
        {"Geneva Identification System", "GEN# +1.00129417"},
        {"Smithsonian Astrophysical Observation", "SAO 182794"},
        {"Wilson Evans Batten Catalogue", "WEB 12389"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.79198203),
        dec: Angle.Degrees(-25.11010396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196385"},
        {"Hipparcos Number", "HIP 101808"},
        {"Geneva Identification System", "GEN# +1.00196385"},
        {"Smithsonian Astrophysical Observation", "SAO 189503"},
        {"Wilson Evans Batten Catalogue", "WEB 18394"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.46742044),
        dec: Angle.Degrees(-25.10918309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55619",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55619"},
        {"Smithsonian Astrophysical Observation", "SAO 179836"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.92930904),
        dec: Angle.Degrees(-25.10836546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -166.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42144",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6887 AB"},
        {"Henry Draper", "HD 73071"},
        {"Hipparcos Number", "HIP 42144"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.778,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.86340684),
        dec: Angle.Degrees(-25.10822331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78160"},
        {"Hipparcos Number", "HIP 44660"},
        {"Geneva Identification System", "GEN# +1.00078160"},
        {"Smithsonian Astrophysical Observation", "SAO 176949"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.50304017),
        dec: Angle.Degrees(-25.10821887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3605"},
        {"Hipparcos Number", "HIP 3056"},
        {"Smithsonian Astrophysical Observation", "SAO 166443"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.70310992),
        dec: Angle.Degrees(-25.10776606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81648"},
        {"Hipparcos Number", "HIP 46285"},
        {"Smithsonian Astrophysical Observation", "SAO 177449"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.58423820),
        dec: Angle.Degrees(-25.10564724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138790"},
        {"Hipparcos Number", "HIP 76293"},
        {"Geneva Identification System", "GEN# +1.00138790"},
        {"Smithsonian Astrophysical Observation", "SAO 183591"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.77609185),
        dec: Angle.Degrees(-25.10555683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156251"},
        {"Hipparcos Number", "HIP 84593"},
        {"Smithsonian Astrophysical Observation", "SAO 185231"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.39311977),
        dec: Angle.Degrees(-25.10513004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197672"},
        {"Hipparcos Number", "HIP 102477"},
        {"Smithsonian Astrophysical Observation", "SAO 189662"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.50067679),
        dec: Angle.Degrees(-25.10415022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8176"},
        {"Hipparcos Number", "HIP 6293"},
        {"Smithsonian Astrophysical Observation", "SAO 166976"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.19138793),
        dec: Angle.Degrees(-25.10374385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64399"},
        {"Hipparcos Number", "HIP 38470"},
        {"Geneva Identification System", "GEN# +2.24670096"},
        {"Smithsonian Astrophysical Observation", "SAO 174716"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.19292530),
        dec: Angle.Degrees(-25.10198393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206291"},
        {"Hipparcos Number", "HIP 107112"},
        {"Geneva Identification System", "GEN# +1.00206291"},
        {"Smithsonian Astrophysical Observation", "SAO 190555"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.44259610),
        dec: Angle.Degrees(-25.10152851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53728"},
        {"Hipparcos Number", "HIP 34167"},
        {"Celescope Catalog", "CEL 1564"},
        {"Geneva Identification System", "GEN# +1.00053728"},
        {"Smithsonian Astrophysical Observation", "SAO 172926"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.27897594),
        dec: Angle.Degrees(-25.10057137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72795"},
        {"Hipparcos Number", "HIP 42029"},
        {"Fundamental Katalog 5th Edition", "FK5 4771"},
        {"Smithsonian Astrophysical Observation", "SAO 176089"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.50715276),
        dec: Angle.Degrees(-25.09939886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157234"},
        {"Hipparcos Number", "HIP 85071"},
        {"Geneva Identification System", "GEN# +1.00157234"},
        {"Smithsonian Astrophysical Observation", "SAO 185346"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.79042823),
        dec: Angle.Degrees(-25.09752978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91689"},
        {"Hipparcos Number", "HIP 51780"},
        {"Geneva Identification System", "GEN# +1.00091689"},
        {"Smithsonian Astrophysical Observation", "SAO 178992"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70602406),
        dec: Angle.Degrees(-25.09626946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26518"},
        {"Hipparcos Number", "HIP 19507"},
        {"Geneva Identification System", "GEN# +1.00026518"},
        {"Smithsonian Astrophysical Observation", "SAO 169198"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.68522167),
        dec: Angle.Degrees(-25.09593165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221655"},
        {"Hipparcos Number", "HIP 116318"},
        {"Smithsonian Astrophysical Observation", "SAO 191998"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.52645183),
        dec: Angle.Degrees(-25.09528989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12511"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.24651899),
        dec: Angle.Degrees(-25.09495177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14976"},
        {"Hipparcos Number", "HIP 11204"},
        {"Smithsonian Astrophysical Observation", "SAO 167754"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.06516709),
        dec: Angle.Degrees(-25.09462487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217629"},
        {"Hipparcos Number", "HIP 113754"},
        {"Smithsonian Astrophysical Observation", "SAO 191599"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.55311567),
        dec: Angle.Degrees(-25.09334609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153336"},
        {"Hipparcos Number", "HIP 83176"},
        {"Geneva Identification System", "GEN# +1.00153336"},
        {"Smithsonian Astrophysical Observation", "SAO 184892"},
        {"Wilson Evans Batten Catalogue", "WEB 14060"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.99043286),
        dec: Angle.Degrees(-25.09216189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73736"},
        {"Hipparcos Number", "HIP 42414"},
        {"Geneva Identification System", "GEN# +1.00073736"},
        {"Smithsonian Astrophysical Observation", "SAO 176223"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.74759519),
        dec: Angle.Degrees(-25.09100938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188658"},
        {"Hipparcos Number", "HIP 98178"},
        {"Smithsonian Astrophysical Observation", "SAO 188746"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.27834022),
        dec: Angle.Degrees(-25.08939498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132976"},
        {"Hipparcos Number", "HIP 73604"},
        {"Smithsonian Astrophysical Observation", "SAO 183111"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.67777942),
        dec: Angle.Degrees(-25.08856306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52473",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7906 AB"},
        {"Henry Draper", "HD 92944"},
        {"Hipparcos Number", "HIP 52473"},
        {"Smithsonian Astrophysical Observation", "SAO 179169"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.90354530),
        dec: Angle.Degrees(-25.08697436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102593"},
        {"Hipparcos Number", "HIP 57597"},
        {"Smithsonian Astrophysical Observation", "SAO 180205"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.12705795),
        dec: Angle.Degrees(-25.08585425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53344"},
        {"Hipparcos Number", "HIP 34041"},
        {"Celescope Catalog", "CEL 1543"},
        {"Geneva Identification System", "GEN# +1.00053344"},
        {"Smithsonian Astrophysical Observation", "SAO 172872"},
        {"Wilson Evans Batten Catalogue", "WEB 6824"},
    },
    visualMagnitude: 6.86,
    bvColour: -0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.92881287),
        dec: Angle.Degrees(-25.08392110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45232",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45232"},
        {"Smithsonian Astrophysical Observation", "SAO 177122"},
    },
    visualMagnitude: 10.34,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.27355307),
        dec: Angle.Degrees(-25.08382673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -273.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 138.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163516"},
        {"Hipparcos Number", "HIP 87919"},
        {"Smithsonian Astrophysical Observation", "SAO 185991"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.39325688),
        dec: Angle.Degrees(-25.08236806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71619"},
        {"Hipparcos Number", "HIP 41476"},
        {"Smithsonian Astrophysical Observation", "SAO 175875"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.88906108),
        dec: Angle.Degrees(-25.08048700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89256"},
        {"Hipparcos Number", "HIP 50390"},
        {"Smithsonian Astrophysical Observation", "SAO 178623"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.32565054),
        dec: Angle.Degrees(-25.08032269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48722",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86151"},
        {"Hipparcos Number", "HIP 48722"},
        {"Smithsonian Astrophysical Observation", "SAO 178202"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.06215220),
        dec: Angle.Degrees(-25.08025746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184778"},
        {"Hipparcos Number", "HIP 96494"},
        {"Geneva Identification System", "GEN# +1.00184778"},
        {"Smithsonian Astrophysical Observation", "SAO 188347"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.25841820),
        dec: Angle.Degrees(-25.08008016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178224"},
        {"Hipparcos Number", "HIP 94045"},
        {"Geneva Identification System", "GEN# +1.00178224"},
        {"Smithsonian Astrophysical Observation", "SAO 187728"},
        {"Wilson Evans Batten Catalogue", "WEB 16370"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.19528344),
        dec: Angle.Degrees(-25.07932419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3745",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 666 A"},
        {"Henry Draper", "HD 4631"},
        {"Hipparcos Number", "HIP 3745"},
        {"Geneva Identification System", "GEN# +1.00004631"},
        {"Smithsonian Astrophysical Observation", "SAO 166586"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.01491791),
        dec: Angle.Degrees(-25.07904214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 186.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23019"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.25724878),
        dec: Angle.Degrees(-25.07862227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16021"},
        {"Hipparcos Number", "HIP 11914"},
        {"Smithsonian Astrophysical Observation", "SAO 167880"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.45253997),
        dec: Angle.Degrees(-25.07806374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90970"},
        {"Hipparcos Number", "HIP 51383"},
        {"Smithsonian Astrophysical Observation", "SAO 178892"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.41590370),
        dec: Angle.Degrees(-25.07641966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200299"},
        {"Hipparcos Number", "HIP 103916"},
        {"Smithsonian Astrophysical Observation", "SAO 189968"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.82417736),
        dec: Angle.Degrees(-25.07416623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58421"},
        {"Smithsonian Astrophysical Observation", "SAO 180347"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.67901959),
        dec: Angle.Degrees(-25.07338337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -197.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207053"},
        {"Hipparcos Number", "HIP 107552"},
        {"Fundamental Katalog 5th Edition", "FK5 5923"},
        {"Geneva Identification System", "GEN# +1.00207053"},
        {"Smithsonian Astrophysical Observation", "SAO 190619"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.74811418),
        dec: Angle.Degrees(-25.07336444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180570"},
        {"Hipparcos Number", "HIP 94853"},
        {"Smithsonian Astrophysical Observation", "SAO 187935"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.50904701),
        dec: Angle.Degrees(-25.07220814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152366"},
        {"Hipparcos Number", "HIP 82667"},
        {"Geneva Identification System", "GEN# +1.00152366"},
        {"Renson", "Renson 43130"},
        {"Smithsonian Astrophysical Observation", "SAO 184762"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.49043139),
        dec: Angle.Degrees(-25.06923832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146266"},
        {"Hipparcos Number", "HIP 79734"},
        {"Geneva Identification System", "GEN# +1.00146266"},
        {"Smithsonian Astrophysical Observation", "SAO 184276"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.09562780),
        dec: Angle.Degrees(-25.06291780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107005"},
        {"Hipparcos Number", "HIP 60001"},
        {"Smithsonian Astrophysical Observation", "SAO 180664"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.58991322),
        dec: Angle.Degrees(-25.06083458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70813"},
        {"Hipparcos Number", "HIP 41102"},
        {"Geneva Identification System", "GEN# +1.00070813"},
        {"Smithsonian Astrophysical Observation", "SAO 175714"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.841,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.78098717),
        dec: Angle.Degrees(-25.06054549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31813"},
        {"Hipparcos Number", "HIP 23070"},
        {"Smithsonian Astrophysical Observation", "SAO 169923"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.45613841),
        dec: Angle.Degrees(-25.06042671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77164",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77164"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.34894436),
        dec: Angle.Degrees(-25.05974453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114129",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114129"},
        {"Smithsonian Astrophysical Observation", "SAO 191654"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.71439847),
        dec: Angle.Degrees(-25.05855319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190304"},
        {"Hipparcos Number", "HIP 98931"},
        {"Smithsonian Astrophysical Observation", "SAO 188893"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.30849258),
        dec: Angle.Degrees(-25.05802444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217323"},
        {"Hipparcos Number", "HIP 113570"},
        {"Smithsonian Astrophysical Observation", "SAO 191558"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.04261032),
        dec: Angle.Degrees(-25.05678016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188676"},
        {"Hipparcos Number", "HIP 98200"},
        {"Smithsonian Astrophysical Observation", "SAO 188751"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.32424349),
        dec: Angle.Degrees(-25.05627128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32135"},
        {"Hipparcos Number", "HIP 23233"},
        {"Geneva Identification System", "GEN# +1.00032135"},
        {"Smithsonian Astrophysical Observation", "SAO 169957"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.99110578),
        dec: Angle.Degrees(-25.05456642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134155"},
        {"Hipparcos Number", "HIP 74136"},
        {"Smithsonian Astrophysical Observation", "SAO 183213"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24460652),
        dec: Angle.Degrees(-25.05363504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1394 AB"},
        {"Henry Draper", "HD 10830"},
        {"Hipparcos Number", "HIP 8209"},
        {"Fundamental Katalog 5th Edition", "FK5 61"},
        {"Geneva Identification System", "GEN# +1.00010830"},
        {"Smithsonian Astrophysical Observation", "SAO 167275"},
        {"Wilson Evans Batten Catalogue", "WEB 1746"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.41106016),
        dec: Angle.Degrees(-25.05243403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196859"},
        {"Hipparcos Number", "HIP 102047"},
        {"Smithsonian Astrophysical Observation", "SAO 189565"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.20681720),
        dec: Angle.Degrees(-25.04962208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129681"},
        {"Hipparcos Number", "HIP 72078"},
        {"Smithsonian Astrophysical Observation", "SAO 182830"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.15807139),
        dec: Angle.Degrees(-25.04917680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33211"},
        {"Hipparcos Number", "HIP 23859"},
        {"Smithsonian Astrophysical Observation", "SAO 170094"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91872175),
        dec: Angle.Degrees(-25.04887817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84490"},
        {"Hipparcos Number", "HIP 47841"},
        {"Smithsonian Astrophysical Observation", "SAO 177932"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.26713369),
        dec: Angle.Degrees(-25.04851617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59097"},
        {"Hipparcos Number", "HIP 36218"},
        {"Smithsonian Astrophysical Observation", "SAO 173773"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.161,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.87952631),
        dec: Angle.Degrees(-25.04842869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158941"},
        {"Hipparcos Number", "HIP 85882"},
        {"Smithsonian Astrophysical Observation", "SAO 185495"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.26673888),
        dec: Angle.Degrees(-25.04757562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123402"},
        {"Hipparcos Number", "HIP 69042"},
        {"Geneva Identification System", "GEN# +1.00123402"},
        {"Smithsonian Astrophysical Observation", "SAO 182270"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.98828426),
        dec: Angle.Degrees(-25.04616430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92929",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11832 A"},
        {"Henry Draper", "HD 175345"},
        {"Hipparcos Number", "HIP 92929"},
        {"Smithsonian Astrophysical Observation", "SAO 187465"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.00163692),
        dec: Angle.Degrees(-25.04587509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11480"},
        {"Hipparcos Number", "HIP 8730"},
        {"Geneva Identification System", "GEN# +1.00011480"},
        {"Renson", "Renson 2910"},
        {"Smithsonian Astrophysical Observation", "SAO 167365"},
        {"Wilson Evans Batten Catalogue", "WEB 1842"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.08621541),
        dec: Angle.Degrees(-25.04494658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 742 B"},
        {"Henry Draper", "HD 5251"},
        {"Hipparcos Number", "HIP 4234"},
        {"Geneva Identification System", "GEN# +1.00005251"},
        {"Smithsonian Astrophysical Observation", "SAO 166662"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.50004605),
        dec: Angle.Degrees(-25.04462483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90574",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11378"},
        {"Aitken 2", "ADS 11378 AB"},
        {"Henry Draper", "HD 170121"},
        {"Hipparcos Number", "HIP 90574"},
        {"Smithsonian Astrophysical Observation", "SAO 186864"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.23638102),
        dec: Angle.Degrees(-25.04283982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 742 A"},
        {"Henry Draper", "HD 5250"},
        {"Hipparcos Number", "HIP 4233"},
        {"Geneva Identification System", "GEN# +1.00005250"},
        {"Smithsonian Astrophysical Observation", "SAO 166661"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.49687763),
        dec: Angle.Degrees(-25.04248124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26428"},
        {"Hipparcos Number", "HIP 19453"},
        {"Smithsonian Astrophysical Observation", "SAO 169185"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.49561815),
        dec: Angle.Degrees(-25.04191837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37506",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37506"},
    },
    visualMagnitude: 10.66,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.45718651),
        dec: Angle.Degrees(-25.04180149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110664"},
        {"Hipparcos Number", "HIP 62123"},
        {"Smithsonian Astrophysical Observation", "SAO 181061"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.97271994),
        dec: Angle.Degrees(-25.04146416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29198"},
        {"Hipparcos Number", "HIP 21354"},
        {"Geneva Identification System", "GEN# +1.00029198"},
        {"Smithsonian Astrophysical Observation", "SAO 169585"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.72755543),
        dec: Angle.Degrees(-25.03891866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83523"},
        {"Smithsonian Astrophysical Observation", "SAO 184984"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.04083788),
        dec: Angle.Degrees(-25.03785333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217866"},
        {"Hipparcos Number", "HIP 113895"},
        {"Smithsonian Astrophysical Observation", "SAO 191617"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.98503189),
        dec: Angle.Degrees(-25.03708693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66433"},
        {"Hipparcos Number", "HIP 39346"},
        {"Geneva Identification System", "GEN# +1.00066433"},
        {"Smithsonian Astrophysical Observation", "SAO 175048"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.64861755),
        dec: Angle.Degrees(-25.03687165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155235"},
        {"Hipparcos Number", "HIP 84076"},
        {"Geneva Identification System", "GEN# +1.00155235"},
        {"Smithsonian Astrophysical Observation", "SAO 185120"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.83722942),
        dec: Angle.Degrees(-25.03150499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114347"},
        {"Hipparcos Number", "HIP 64276"},
        {"Geneva Identification System", "GEN# +1.00114347"},
        {"Smithsonian Astrophysical Observation", "SAO 181427"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.59241168),
        dec: Angle.Degrees(-25.02920736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128756"},
        {"Hipparcos Number", "HIP 71652"},
        {"Fundamental Katalog 5th Edition", "FK5 5300"},
        {"Smithsonian Astrophysical Observation", "SAO 182735"},
        {"Wilson Evans Batten Catalogue", "WEB 12351"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.84164350),
        dec: Angle.Degrees(-25.02855575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138503"},
        {"Hipparcos Number", "HIP 76161"},
        {"Geneva Identification System", "GEN# +1.00138503"},
        {"Smithsonian Astrophysical Observation", "SAO 183569"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.32880249),
        dec: Angle.Degrees(-25.02694876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41628"},
        {"Hipparcos Number", "HIP 28840"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.31636561),
        dec: Angle.Degrees(-25.02669502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52615",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7918 AB"},
        {"Henry Draper", "HD 93227"},
        {"Hipparcos Number", "HIP 52615"},
        {"Smithsonian Astrophysical Observation", "SAO 179198"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.38709275),
        dec: Angle.Degrees(-25.02611822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80371",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10034 A"},
        {"Henry Draper", "HD 147701"},
        {"Hipparcos Number", "HIP 80371"},
        {"Geneva Identification System", "GEN# +1.00147701"},
        {"Smithsonian Astrophysical Observation", "SAO 184363"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.08885742),
        dec: Angle.Degrees(-25.02534295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202739"},
        {"Hipparcos Number", "HIP 105195"},
        {"Smithsonian Astrophysical Observation", "SAO 190215"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.64036994),
        dec: Angle.Degrees(-25.02503426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27518"},
        {"Hipparcos Number", "HIP 20194"},
        {"Geneva Identification System", "GEN# +1.00027518"},
        {"Smithsonian Astrophysical Observation", "SAO 169344"},
        {"Wilson Evans Batten Catalogue", "WEB 3851"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.92666544),
        dec: Angle.Degrees(-25.02482282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16358"},
        {"Hipparcos Number", "HIP 12167"},
        {"Geneva Identification System", "GEN# +1.00016358"},
        {"Smithsonian Astrophysical Observation", "SAO 167920"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.19911800),
        dec: Angle.Degrees(-25.02359487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7676",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1298 A"},
        {"Henry Draper", "HD 10161"},
        {"Hipparcos Number", "HIP 7676"},
        {"Geneva Identification System", "GEN# +1.00010161A"},
        {"Smithsonian Astrophysical Observation", "SAO 167199"},
        {"Wilson Evans Batten Catalogue", "WEB 1641"},
    },
    visualMagnitude: 6.69,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.70830289),
        dec: Angle.Degrees(-25.02221382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96237"},
        {"Hipparcos Number", "HIP 54215"},
        {"Geneva Identification System", "GEN# +1.00096237"},
        {"Renson", "Renson 27720"},
        {"Smithsonian Astrophysical Observation", "SAO 179516"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.39186265),
        dec: Angle.Degrees(-25.01924347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26339"},
        {"Hipparcos Number", "HIP 19374"},
        {"Smithsonian Astrophysical Observation", "SAO 169170"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.25075826),
        dec: Angle.Degrees(-25.01779779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111214"},
        {"Hipparcos Number", "HIP 62447"},
        {"Smithsonian Astrophysical Observation", "SAO 181104"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.97224291),
        dec: Angle.Degrees(-25.01527784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10001"},
        {"Hipparcos Number", "HIP 7541"},
        {"Geneva Identification System", "GEN# +1.00010001"},
        {"Smithsonian Astrophysical Observation", "SAO 167178"},
        {"Wilson Evans Batten Catalogue", "WEB 1612"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.29029463),
        dec: Angle.Degrees(-25.01522579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141938"},
        {"Hipparcos Number", "HIP 77754"},
        {"Smithsonian Astrophysical Observation", "SAO 183883"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.14772271),
        dec: Angle.Degrees(-25.01516632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208250"},
        {"Hipparcos Number", "HIP 108223"},
        {"Smithsonian Astrophysical Observation", "SAO 190738"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.87327786),
        dec: Angle.Degrees(-25.01509671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143715"},
        {"Hipparcos Number", "HIP 78602"},
        {"Smithsonian Astrophysical Observation", "SAO 184058"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.71649622),
        dec: Angle.Degrees(-25.01424432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54510"},
        {"Smithsonian Astrophysical Observation", "SAO 179589"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.29183566),
        dec: Angle.Degrees(-25.01397973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44102"},
        {"Hipparcos Number", "HIP 30004"},
        {"Smithsonian Astrophysical Observation", "SAO 171552"},
    },
    visualMagnitude: 7.04,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.73162666),
        dec: Angle.Degrees(-25.01277949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26956"},
        {"Hipparcos Number", "HIP 19807"},
        {"Smithsonian Astrophysical Observation", "SAO 169262"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.71390276),
        dec: Angle.Degrees(-25.01112331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173117"},
        {"Hipparcos Number", "HIP 91974"},
        {"Geneva Identification System", "GEN# +1.00173117"},
        {"Smithsonian Astrophysical Observation", "SAO 187216"},
        {"Wilson Evans Batten Catalogue", "WEB 15839"},
    },
    visualMagnitude: 5.82,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.20667981),
        dec: Angle.Degrees(-25.01086335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209069"},
        {"Hipparcos Number", "HIP 108705"},
        {"Smithsonian Astrophysical Observation", "SAO 190829"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.30268232),
        dec: Angle.Degrees(-25.01059725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122066"},
        {"Hipparcos Number", "HIP 68390"},
        {"Fundamental Katalog 5th Edition", "FK5 1361"},
        {"Geneva Identification System", "GEN# +1.00122066"},
        {"Smithsonian Astrophysical Observation", "SAO 182152"},
        {"Wilson Evans Batten Catalogue", "WEB 11992"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.00102545),
        dec: Angle.Degrees(-25.01017978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28324"},
        {"Hipparcos Number", "HIP 20783"},
        {"Smithsonian Astrophysical Observation", "SAO 169459"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.77522682),
        dec: Angle.Degrees(-25.00977153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150080"},
        {"Hipparcos Number", "HIP 81582"},
        {"Smithsonian Astrophysical Observation", "SAO 184528"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.92074317),
        dec: Angle.Degrees(-25.00847042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53885"},
        {"Hipparcos Number", "HIP 34227"},
        {"Smithsonian Astrophysical Observation", "SAO 172947"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.44190032),
        dec: Angle.Degrees(-25.00785375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14632 A"},
        {"Henry Draper", "HD 200914"},
        {"Hipparcos Number", "HIP 104234"},
        {"Fundamental Katalog 5th Edition", "FK5 791"},
        {"Geneva Identification System", "GEN# +1.00200914"},
        {"Smithsonian Astrophysical Observation", "SAO 190025"},
        {"Wilson Evans Batten Catalogue", "WEB 18988"},
    },
    visualMagnitude: 4.49,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.78202266),
        dec: Angle.Degrees(-25.00574796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69755"},
        {"Hipparcos Number", "HIP 40622"},
        {"Smithsonian Astrophysical Observation", "SAO 175522"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.39365646),
        dec: Angle.Degrees(-25.00234793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219731"},
        {"Hipparcos Number", "HIP 115068"},
        {"Smithsonian Astrophysical Observation", "SAO 191806"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.60002594),
        dec: Angle.Degrees(-25.00223002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99934"},
        {"Hipparcos Number", "HIP 56085"},
        {"Geneva Identification System", "GEN# +1.00099934"},
        {"Smithsonian Astrophysical Observation", "SAO 179938"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.43897225),
        dec: Angle.Degrees(-25.00197072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149201"},
        {"Hipparcos Number", "HIP 81138"},
        {"Smithsonian Astrophysical Observation", "SAO 184466"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.55170164),
        dec: Angle.Degrees(-25.00100244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135951"},
        {"Hipparcos Number", "HIP 74923"},
        {"Smithsonian Astrophysical Observation", "SAO 183358"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.65667524),
        dec: Angle.Degrees(-25.00035337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157056"},
        {"Hipparcos Number", "HIP 84970"},
        {"Fundamental Katalog 5th Edition", "FK5 644"},
        {"Geneva Identification System", "GEN# +1.00157056"},
        {"Smithsonian Astrophysical Observation", "SAO 185320"},
        {"Wilson Evans Batten Catalogue", "WEB 14352"},
    },
    visualMagnitude: 3.27,
    bvColour: -0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.50243371),
        dec: Angle.Degrees(-24.99948797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115064",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115064"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.59588872),
        dec: Angle.Degrees(-24.99848154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154679"},
        {"Hipparcos Number", "HIP 83828"},
        {"Fundamental Katalog 5th Edition", "FK5 5510"},
        {"Geneva Identification System", "GEN# +1.00154679"},
        {"Smithsonian Astrophysical Observation", "SAO 185049"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.98417550),
        dec: Angle.Degrees(-24.99813086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6463"},
        {"Geneva Identification System", "GEN# -0.02500551"},
        {"Smithsonian Astrophysical Observation", "SAO 167004"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.78270385),
        dec: Angle.Degrees(-24.99804553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49940"},
        {"Hipparcos Number", "HIP 32756"},
        {"Smithsonian Astrophysical Observation", "SAO 172393"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.45787138),
        dec: Angle.Degrees(-24.99782570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129433"},
        {"Hipparcos Number", "HIP 71974"},
        {"Geneva Identification System", "GEN# +1.00129433"},
        {"Smithsonian Astrophysical Observation", "SAO 182795"},
        {"Wilson Evans Batten Catalogue", "WEB 12390"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.80652349),
        dec: Angle.Degrees(-24.99773099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153916"},
        {"Hipparcos Number", "HIP 83450"},
        {"Smithsonian Astrophysical Observation", "SAO 184960"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.82729338),
        dec: Angle.Degrees(-24.99557933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217416"},
        {"Hipparcos Number", "HIP 113623"},
        {"Smithsonian Astrophysical Observation", "SAO 191573"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.18093753),
        dec: Angle.Degrees(-24.99443998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84416",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84416"},
        {"Smithsonian Astrophysical Observation", "SAO 185202"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.86681097),
        dec: Angle.Degrees(-24.99261378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147284"},
        {"Hipparcos Number", "HIP 80171"},
        {"Geneva Identification System", "GEN# +1.00147284"},
        {"Smithsonian Astrophysical Observation", "SAO 184342"},
        {"Wilson Evans Batten Catalogue", "WEB 13570"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.48149073),
        dec: Angle.Degrees(-24.99103045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -184.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -112.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211105"},
        {"Hipparcos Number", "HIP 109884"},
        {"Smithsonian Astrophysical Observation", "SAO 191001"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.82900434),
        dec: Angle.Degrees(-24.99071884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110560"},
        {"Hipparcos Number", "HIP 62062"},
        {"Smithsonian Astrophysical Observation", "SAO 181047"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.80451717),
        dec: Angle.Degrees(-24.99048817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153363"},
        {"Hipparcos Number", "HIP 83196"},
        {"Geneva Identification System", "GEN# +1.00153363"},
        {"Smithsonian Astrophysical Observation", "SAO 184897"},
        {"Wilson Evans Batten Catalogue", "WEB 14062"},
    },
    visualMagnitude: 5.74,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.03949377),
        dec: Angle.Degrees(-24.98893659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146285"},
        {"Hipparcos Number", "HIP 79739"},
        {"Geneva Identification System", "GEN# +1.00146285"},
        {"Smithsonian Astrophysical Observation", "SAO 184277"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.10491737),
        dec: Angle.Degrees(-24.98868668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75573",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75573"},
        {"Smithsonian Astrophysical Observation", "SAO 183468"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.57335813),
        dec: Angle.Degrees(-24.98854430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172491"},
        {"Hipparcos Number", "HIP 91669"},
        {"Smithsonian Astrophysical Observation", "SAO 187139"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.40348641),
        dec: Angle.Degrees(-24.98812824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88953"},
        {"Hipparcos Number", "HIP 50219"},
        {"Smithsonian Astrophysical Observation", "SAO 178579"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.77845299),
        dec: Angle.Degrees(-24.98777565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223786"},
        {"Hipparcos Number", "HIP 117737"},
        {"Smithsonian Astrophysical Observation", "SAO 192211"},
    },
    visualMagnitude: 6.77,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.17033914),
        dec: Angle.Degrees(-24.98519935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198354"},
        {"Hipparcos Number", "HIP 102869"},
        {"Geneva Identification System", "GEN# +1.00198354"},
        {"Smithsonian Astrophysical Observation", "SAO 189757"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.62577827),
        dec: Angle.Degrees(-24.98255113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -78.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135812"},
        {"Hipparcos Number", "HIP 74860"},
        {"Smithsonian Astrophysical Observation", "SAO 183350"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.47185791),
        dec: Angle.Degrees(-24.98197597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15470"},
        {"Hipparcos Number", "HIP 11549"},
        {"Smithsonian Astrophysical Observation", "SAO 167816"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.20365928),
        dec: Angle.Degrees(-24.98180987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216580"},
        {"Hipparcos Number", "HIP 113107"},
        {"Smithsonian Astrophysical Observation", "SAO 191481"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.58018708),
        dec: Angle.Degrees(-24.98029176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21071",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3282 A"},
        {"Henry Draper", "HD 28753"},
        {"Hipparcos Number", "HIP 21071"},
        {"Smithsonian Astrophysical Observation", "SAO 169530"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.74838597),
        dec: Angle.Degrees(-24.97987462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120572"},
        {"Hipparcos Number", "HIP 67569"},
        {"Smithsonian Astrophysical Observation", "SAO 182015"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.69658898),
        dec: Angle.Degrees(-24.97969151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148562"},
        {"Hipparcos Number", "HIP 80799"},
        {"Geneva Identification System", "GEN# +1.00148562"},
        {"Smithsonian Astrophysical Observation", "SAO 184424"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.47751960),
        dec: Angle.Degrees(-24.97940346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57433",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102300"},
        {"Hipparcos Number", "HIP 57433"},
        {"Geneva Identification System", "GEN# +1.00102300"},
        {"Smithsonian Astrophysical Observation", "SAO 180174"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.61421446),
        dec: Angle.Degrees(-24.97617036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 199.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2242 C"},
        {"Henry Draper", "HD 18445"},
        {"Hipparcos Number", "HIP 13769"},
        {"Geneva Identification System", "GEN# +1.00018445"},
        {"Smithsonian Astrophysical Observation", "SAO 168180"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.30490789),
        dec: Angle.Degrees(-24.97504103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44144"},
        {"Hipparcos Number", "HIP 30039"},
        {"Smithsonian Astrophysical Observation", "SAO 171562"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.81371677),
        dec: Angle.Degrees(-24.97493633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145209"},
        {"Hipparcos Number", "HIP 79268"},
        {"Geneva Identification System", "GEN# +1.00145209"},
        {"Smithsonian Astrophysical Observation", "SAO 184191"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.66378661),
        dec: Angle.Degrees(-24.97407696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63598"},
        {"Hipparcos Number", "HIP 38134"},
        {"Geneva Identification System", "GEN# +1.00063598"},
        {"Smithsonian Astrophysical Observation", "SAO 174589"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.22276268),
        dec: Angle.Degrees(-24.97283770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 152.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -239.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121847"},
        {"Hipparcos Number", "HIP 68269"},
        {"Fundamental Katalog 5th Edition", "FK5 515"},
        {"Geneva Identification System", "GEN# +1.00121847"},
        {"Smithsonian Astrophysical Observation", "SAO 182134"},
        {"Wilson Evans Batten Catalogue", "WEB 11975"},
    },
    visualMagnitude: 5.20,
    bvColour: -0.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.62990869),
        dec: Angle.Degrees(-24.97217754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76253",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76253"},
        {"Smithsonian Astrophysical Observation", "SAO 183581"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.64167715),
        dec: Angle.Degrees(-24.97207761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90283"},
        {"Hipparcos Number", "HIP 50981"},
        {"Smithsonian Astrophysical Observation", "SAO 178789"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.20820559),
        dec: Angle.Degrees(-24.97203513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77298"},
        {"Hipparcos Number", "HIP 44276"},
        {"Geneva Identification System", "GEN# +1.00077298"},
        {"Smithsonian Astrophysical Observation", "SAO 176825"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.24040328),
        dec: Angle.Degrees(-24.96995300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13772",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2242 AB"},
        {"Henry Draper", "HD 18455"},
        {"Hipparcos Number", "HIP 13772"},
        {"Geneva Identification System", "GEN# +1.00018455J"},
        {"Smithsonian Astrophysical Observation", "SAO 168181"},
    },
    visualMagnitude: 7.33,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.31121634),
        dec: Angle.Degrees(-24.96941710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51576"},
        {"Hipparcos Number", "HIP 33408"},
        {"Smithsonian Astrophysical Observation", "SAO 172619"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.22353754),
        dec: Angle.Degrees(-24.96919378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36461"},
        {"Hipparcos Number", "HIP 25824"},
        {"Smithsonian Astrophysical Observation", "SAO 170501"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71513752),
        dec: Angle.Degrees(-24.96847918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47641"},
        {"Hipparcos Number", "HIP 31762"},
        {"Smithsonian Astrophysical Observation", "SAO 172078"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.65078147),
        dec: Angle.Degrees(-24.96582192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159845"},
        {"Hipparcos Number", "HIP 86291"},
        {"Geneva Identification System", "GEN# +1.00159845"},
        {"Smithsonian Astrophysical Observation", "SAO 185569"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.47840896),
        dec: Angle.Degrees(-24.96580913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74631"},
        {"Hipparcos Number", "HIP 42873"},
        {"Renson", "Renson 20860"},
        {"Smithsonian Astrophysical Observation", "SAO 176380"},
    },
    visualMagnitude: 9.47,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.05396811),
        dec: Angle.Degrees(-24.96554961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54173"},
        {"Hipparcos Number", "HIP 34318"},
        {"Geneva Identification System", "GEN# +1.00054173"},
        {"Smithsonian Astrophysical Observation", "SAO 172986"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.71868219),
        dec: Angle.Degrees(-24.96058078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50074"},
        {"Hipparcos Number", "HIP 32823"},
        {"Geneva Identification System", "GEN# +1.00050074"},
        {"Smithsonian Astrophysical Observation", "SAO 172415"},
    },
    visualMagnitude: 9.35,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.63610537),
        dec: Angle.Degrees(-24.95908404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105766"},
        {"Hipparcos Number", "HIP 59350"},
        {"Smithsonian Astrophysical Observation", "SAO 180536"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.61929994),
        dec: Angle.Degrees(-24.95885974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19024"},
        {"Hipparcos Number", "HIP 14185"},
        {"Smithsonian Astrophysical Observation", "SAO 168258"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.72495644),
        dec: Angle.Degrees(-24.95847694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30040"},
        {"Smithsonian Astrophysical Observation", "SAO 171563"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.81619105),
        dec: Angle.Degrees(-24.95831113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24404"},
        {"Hipparcos Number", "HIP 18093"},
        {"Smithsonian Astrophysical Observation", "SAO 168901"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.01088867),
        dec: Angle.Degrees(-24.95761348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35461",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5985 A"},
        {"Henry Draper", "HD 57192"},
        {"Hipparcos Number", "HIP 35461"},
        {"Celescope Catalog", "CEL 1776"},
        {"Fundamental Katalog 5th Edition", "FK5 4659"},
        {"Geneva Identification System", "GEN# +2.23620046"},
        {"Smithsonian Astrophysical Observation", "SAO 173464"},
        {"Wilson Evans Batten Catalogue", "WEB 7073"},
        {"New General Catalogue", "NGC 2362 46"},
    },
    visualMagnitude: 6.82,
    bvColour: -0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.80319902),
        dec: Angle.Degrees(-24.95572192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112207"},
        {"Hipparcos Number", "HIP 63055"},
        {"Smithsonian Astrophysical Observation", "SAO 181222"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.79522654),
        dec: Angle.Degrees(-24.95562051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1045"},
        {"Smithsonian Astrophysical Observation", "SAO 166119"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.26509483),
        dec: Angle.Degrees(-24.95462638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35415",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5977 A"},
        {"Henry Draper", "HD 57061"},
        {"Hipparcos Number", "HIP 35415"},
        {"Celescope Catalog", "CEL 1763"},
        {"Geneva Identification System", "GEN# +2.23620023"},
        {"Smithsonian Astrophysical Observation", "SAO 173446"},
        {"Wilson Evans Batten Catalogue", "WEB 7067"},
        {"New General Catalogue", "NGC 2362 23"},
    },
    visualMagnitude: 4.37,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.67703283),
        dec: Angle.Degrees(-24.95438447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5145"},
        {"Hipparcos Number", "HIP 4154"},
        {"Geneva Identification System", "GEN# +1.00005145"},
        {"Smithsonian Astrophysical Observation", "SAO 166649"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.27066379),
        dec: Angle.Degrees(-24.95163131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15367"},
        {"Smithsonian Astrophysical Observation", "SAO 168450"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.53152778),
        dec: Angle.Degrees(-24.95136411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8038"},
        {"Hipparcos Number", "HIP 6197"},
        {"Fundamental Katalog 5th Edition", "FK5 4117"},
        {"Geneva Identification System", "GEN# +1.00008038"},
        {"Smithsonian Astrophysical Observation", "SAO 166958"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.87115849),
        dec: Angle.Degrees(-24.95091069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -122.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3954"},
        {"Hipparcos Number", "HIP 3295"},
        {"Smithsonian Astrophysical Observation", "SAO 166494"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.50915404),
        dec: Angle.Degrees(-24.95060356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205219"},
        {"Hipparcos Number", "HIP 106520"},
        {"Geneva Identification System", "GEN# +1.00205219"},
        {"Smithsonian Astrophysical Observation", "SAO 190452"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.62433294),
        dec: Angle.Degrees(-24.95020886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3291",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3291"},
    },
    visualMagnitude: 11.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.50105935),
        dec: Angle.Degrees(-24.94898489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194412"},
        {"Hipparcos Number", "HIP 100796"},
        {"Smithsonian Astrophysical Observation", "SAO 189278"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.56307580),
        dec: Angle.Degrees(-24.94701706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19415"},
        {"Hipparcos Number", "HIP 14459"},
        {"Geneva Identification System", "GEN# +1.00019415"},
        {"Smithsonian Astrophysical Observation", "SAO 168308"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.64711805),
        dec: Angle.Degrees(-24.94584193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225041"},
        {"Hipparcos Number", "HIP 226"},
        {"Geneva Identification System", "GEN# +1.00225041"},
        {"Smithsonian Astrophysical Observation", "SAO 166011"},
        {"Wilson Evans Batten Catalogue", "WEB 38"},
    },
    visualMagnitude: 10.30,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.70031218),
        dec: Angle.Degrees(-24.94525463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1745",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1745"},
        {"Geneva Identification System", "GEN# -0.02500112"},
        {"Smithsonian Astrophysical Observation", "SAO 166216"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.51718620),
        dec: Angle.Degrees(-24.94445082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6807",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6807"},
        {"Geneva Identification System", "GEN# +9.85827229"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.89716433),
        dec: Angle.Degrees(-24.94390513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 220.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195549"},
        {"Hipparcos Number", "HIP 101384"},
        {"Geneva Identification System", "GEN# +1.00195549"},
        {"Smithsonian Astrophysical Observation", "SAO 189416"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.21813716),
        dec: Angle.Degrees(-24.94372528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49485"},
        {"Hipparcos Number", "HIP 32561"},
        {"Smithsonian Astrophysical Observation", "SAO 172339"},
    },
    visualMagnitude: 8.00,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.91328005),
        dec: Angle.Degrees(-24.94337632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176246"},
        {"Hipparcos Number", "HIP 93315"},
        {"Geneva Identification System", "GEN# +1.00176246"},
        {"Smithsonian Astrophysical Observation", "SAO 187562"},
        {"Wilson Evans Batten Catalogue", "WEB 16181"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.10324474),
        dec: Angle.Degrees(-24.94227120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56066"},
        {"Hipparcos Number", "HIP 35009"},
        {"Celescope Catalog", "CEL 1702"},
        {"Smithsonian Astrophysical Observation", "SAO 173275"},
    },
    visualMagnitude: 8.70,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.64038812),
        dec: Angle.Degrees(-24.93790935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144367"},
        {"Hipparcos Number", "HIP 78904"},
        {"Smithsonian Astrophysical Observation", "SAO 184117"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.60732897),
        dec: Angle.Degrees(-24.93644274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87871"},
        {"Hipparcos Number", "HIP 49591"},
        {"Smithsonian Astrophysical Observation", "SAO 178435"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.85289738),
        dec: Angle.Degrees(-24.93524941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40343",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69040"},
        {"Hipparcos Number", "HIP 40343"},
        {"Geneva Identification System", "GEN# +1.00069040"},
        {"Smithsonian Astrophysical Observation", "SAO 175425"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.55464618),
        dec: Angle.Degrees(-24.93245738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2582"},
        {"Hipparcos Number", "HIP 2288"},
        {"Geneva Identification System", "GEN# +1.00002582"},
        {"Smithsonian Astrophysical Observation", "SAO 166308"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.30744524),
        dec: Angle.Degrees(-24.93058702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17850"},
        {"Smithsonian Astrophysical Observation", "SAO 168859"},
    },
    visualMagnitude: 9.69,
    bvColour: 1.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.29511026),
        dec: Angle.Degrees(-24.93001838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64339"},
        {"Hipparcos Number", "HIP 38440"},
        {"Smithsonian Astrophysical Observation", "SAO 174707"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.12528233),
        dec: Angle.Degrees(-24.92684546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41898"},
        {"Hipparcos Number", "HIP 28966"},
        {"Geneva Identification System", "GEN# +1.00041898"},
        {"Smithsonian Astrophysical Observation", "SAO 171247"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.384,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.68608013),
        dec: Angle.Degrees(-24.92684270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63157"},
        {"Geneva Identification System", "GEN# -0.02410619"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.12511776),
        dec: Angle.Degrees(-24.92494587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -220.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51038"},
        {"Hipparcos Number", "HIP 33211"},
        {"Celescope Catalog", "CEL 1432"},
        {"Geneva Identification System", "GEN# +5.11210013"},
        {"Smithsonian Astrophysical Observation", "SAO 172560"},
    },
    visualMagnitude: 9.12,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.67741178),
        dec: Angle.Degrees(-24.92466491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215935"},
        {"Hipparcos Number", "HIP 112671"},
        {"Fundamental Katalog 5th Edition", "FK5 6012"},
        {"Geneva Identification System", "GEN# +1.00215935"},
        {"Smithsonian Astrophysical Observation", "SAO 191422"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.25427330),
        dec: Angle.Degrees(-24.92287321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3786 AB"},
        {"Henry Draper", "HD 33888"},
        {"Hipparcos Number", "HIP 24257"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.10813949),
        dec: Angle.Degrees(-24.92220939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41757"},
        {"Hipparcos Number", "HIP 28896"},
        {"Renson", "Renson 11140"},
        {"Smithsonian Astrophysical Observation", "SAO 171229"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.50754418),
        dec: Angle.Degrees(-24.92204929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152987"},
        {"Hipparcos Number", "HIP 83017"},
        {"Smithsonian Astrophysical Observation", "SAO 184839"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.46690077),
        dec: Angle.Degrees(-24.91855283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168574"},
        {"Hipparcos Number", "HIP 89980"},
        {"Geneva Identification System", "GEN# +1.00168574"},
        {"Smithsonian Astrophysical Observation", "SAO 186699"},
        {"Wilson Evans Batten Catalogue", "WEB 15368"},
    },
    visualMagnitude: 6.19,
    bvColour: 1.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.38068395),
        dec: Angle.Degrees(-24.91527108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197765"},
        {"Hipparcos Number", "HIP 102516"},
        {"Geneva Identification System", "GEN# +1.00197765"},
        {"Smithsonian Astrophysical Observation", "SAO 189678"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.63217634),
        dec: Angle.Degrees(-24.91433704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7228",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7228"},
        {"Geneva Identification System", "GEN# -0.02500636"},
        {"Smithsonian Astrophysical Observation", "SAO 167133"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.28823888),
        dec: Angle.Degrees(-24.91381749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -215.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96918",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96918"},
        {"Geneva Identification System", "GEN# -0.02514263"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.51456479),
        dec: Angle.Degrees(-24.91331565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63660"},
        {"Hipparcos Number", "HIP 38146"},
        {"Geneva Identification System", "GEN# +1.00063660"},
        {"Smithsonian Astrophysical Observation", "SAO 174592"},
        {"Wilson Evans Batten Catalogue", "WEB 7518"},
    },
    visualMagnitude: 5.32,
    bvColour: 0.751,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.25706910),
        dec: Angle.Degrees(-24.91224336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206707"},
        {"Hipparcos Number", "HIP 107351"},
        {"Geneva Identification System", "GEN# +1.00206707"},
        {"Smithsonian Astrophysical Observation", "SAO 190592"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.13530461),
        dec: Angle.Degrees(-24.91036064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50647"},
        {"Hipparcos Number", "HIP 33057"},
        {"Geneva Identification System", "GEN# +1.00050647"},
        {"Smithsonian Astrophysical Observation", "SAO 172508"},
    },
    visualMagnitude: 9.08,
    bvColour: -0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.28330575),
        dec: Angle.Degrees(-24.90759330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77802",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77802"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.30115673),
        dec: Angle.Degrees(-24.90713239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179233"},
        {"Hipparcos Number", "HIP 94399"},
        {"Smithsonian Astrophysical Observation", "SAO 187823"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.19279854),
        dec: Angle.Degrees(-24.90625458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156992"},
        {"Hipparcos Number", "HIP 84947"},
        {"Smithsonian Astrophysical Observation", "SAO 185313"},
        {"Wilson Evans Batten Catalogue", "WEB 14344"},
    },
    visualMagnitude: 6.36,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.42326204),
        dec: Angle.Degrees(-24.90600939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57911"},
        {"Hipparcos Number", "HIP 35747"},
        {"Smithsonian Astrophysical Observation", "SAO 173569"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.59826240),
        dec: Angle.Degrees(-24.90390782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79485"},
        {"Hipparcos Number", "HIP 45285"},
        {"Smithsonian Astrophysical Observation", "SAO 177140"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.44512283),
        dec: Angle.Degrees(-24.90379027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104892"},
        {"Hipparcos Number", "HIP 58892"},
        {"Smithsonian Astrophysical Observation", "SAO 180432"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.17238609),
        dec: Angle.Degrees(-24.90112227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170743"},
        {"Hipparcos Number", "HIP 90859"},
        {"Smithsonian Astrophysical Observation", "SAO 186931"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.02960864),
        dec: Angle.Degrees(-24.90036263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187516"},
        {"Hipparcos Number", "HIP 97692"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.81040020),
        dec: Angle.Degrees(-24.89857677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43030"},
        {"Hipparcos Number", "HIP 29505"},
        {"Smithsonian Astrophysical Observation", "SAO 171400"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24449383),
        dec: Angle.Degrees(-24.89773039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10461"},
        {"Hipparcos Number", "HIP 7892"},
        {"Smithsonian Astrophysical Observation", "SAO 167234"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.38430765),
        dec: Angle.Degrees(-24.89764447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101307"},
        {"Hipparcos Number", "HIP 56852"},
        {"Smithsonian Astrophysical Observation", "SAO 180071"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.84292948),
        dec: Angle.Degrees(-24.89642481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22381"},
        {"Hipparcos Number", "HIP 16736"},
        {"Smithsonian Astrophysical Observation", "SAO 168653"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.82393926),
        dec: Angle.Degrees(-24.89612800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21667"},
        {"Hipparcos Number", "HIP 16225"},
        {"Geneva Identification System", "GEN# +1.00021667"},
        {"Smithsonian Astrophysical Observation", "SAO 168575"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.25550068),
        dec: Angle.Degrees(-24.89554353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109745"},
        {"Hipparcos Number", "HIP 61587"},
        {"Smithsonian Astrophysical Observation", "SAO 180958"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.29886661),
        dec: Angle.Degrees(-24.89253839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27881"},
        {"Hipparcos Number", "HIP 20465"},
        {"Fundamental Katalog 5th Edition", "FK5 2323"},
        {"Geneva Identification System", "GEN# +1.00027881"},
        {"Smithsonian Astrophysical Observation", "SAO 169391"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.77358735),
        dec: Angle.Degrees(-24.89211883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34785",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 34785"},
    },
    visualMagnitude: 10.37,
    bvColour: 1.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.02034398),
        dec: Angle.Degrees(-24.89207132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170531"},
        {"Hipparcos Number", "HIP 90756"},
        {"Smithsonian Astrophysical Observation", "SAO 186906"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.75913845),
        dec: Angle.Degrees(-24.89200795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71668"},
        {"Hipparcos Number", "HIP 41496"},
        {"Smithsonian Astrophysical Observation", "SAO 175880"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.94370014),
        dec: Angle.Degrees(-24.89147324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24685"},
        {"Hipparcos Number", "HIP 18271"},
        {"Geneva Identification System", "GEN# +1.00024685"},
        {"Smithsonian Astrophysical Observation", "SAO 168938"},
        {"Wilson Evans Batten Catalogue", "WEB 3530"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.63010457),
        dec: Angle.Degrees(-24.89084204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11785"},
        {"Hipparcos Number", "HIP 8936"},
        {"Smithsonian Astrophysical Observation", "SAO 167392"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.76811731),
        dec: Angle.Degrees(-24.88974461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19632"},
        {"Hipparcos Number", "HIP 14623"},
        {"Fundamental Katalog 5th Edition", "FK5 4286"},
        {"Geneva Identification System", "GEN# +1.00019632"},
        {"Smithsonian Astrophysical Observation", "SAO 168331"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.21791685),
        dec: Angle.Degrees(-24.88797952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 225.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149827"},
        {"Hipparcos Number", "HIP 81457"},
        {"Geneva Identification System", "GEN# +1.00149827"},
        {"Smithsonian Astrophysical Observation", "SAO 184507"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.56079812),
        dec: Angle.Degrees(-24.88745008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162978"},
        {"Hipparcos Number", "HIP 87706"},
        {"Geneva Identification System", "GEN# +1.00162978"},
        {"Smithsonian Astrophysical Observation", "SAO 185928"},
        {"Wilson Evans Batten Catalogue", "WEB 14802"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.72517769),
        dec: Angle.Degrees(-24.88708859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199408"},
        {"Hipparcos Number", "HIP 103462"},
        {"Smithsonian Astrophysical Observation", "SAO 189876"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.42530972),
        dec: Angle.Degrees(-24.88594574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96465",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12654 A"},
        {"Henry Draper", "HD 184707"},
        {"Hipparcos Number", "HIP 96465"},
        {"Fundamental Katalog 5th Edition", "FK5 736"},
        {"Geneva Identification System", "GEN# +1.00184707"},
        {"Smithsonian Astrophysical Observation", "SAO 188337"},
        {"Wilson Evans Batten Catalogue", "WEB 16923"},
    },
    visualMagnitude: 4.59,
    bvColour: -0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.17662107),
        dec: Angle.Degrees(-24.88356664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37665"},
        {"Hipparcos Number", "HIP 26593"},
        {"Smithsonian Astrophysical Observation", "SAO 170639"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.79637193),
        dec: Angle.Degrees(-24.88074685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24742"},
        {"Hipparcos Number", "HIP 18331"},
        {"Geneva Identification System", "GEN# +1.00024742"},
        {"Smithsonian Astrophysical Observation", "SAO 168948"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.78111622),
        dec: Angle.Degrees(-24.87957950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 90.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222100"},
        {"Hipparcos Number", "HIP 116603"},
        {"Geneva Identification System", "GEN# +1.00222100"},
        {"Smithsonian Astrophysical Observation", "SAO 192042"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.46276045),
        dec: Angle.Degrees(-24.87848782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97294",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12883 AB"},
        {"Henry Draper", "HD 186613"},
        {"Hipparcos Number", "HIP 97294"},
        {"Smithsonian Astrophysical Observation", "SAO 188547"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.60593487),
        dec: Angle.Degrees(-24.87837891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44801"},
        {"Hipparcos Number", "HIP 30330"},
        {"Smithsonian Astrophysical Observation", "SAO 171652"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.69726064),
        dec: Angle.Degrees(-24.87815927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175852"},
        {"Hipparcos Number", "HIP 93132"},
        {"Geneva Identification System", "GEN# +1.00175852"},
        {"Smithsonian Astrophysical Observation", "SAO 187517"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.58541625),
        dec: Angle.Degrees(-24.87685166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53019"},
        {"Hipparcos Number", "HIP 33935"},
        {"Smithsonian Astrophysical Observation", "SAO 172826"},
    },
    visualMagnitude: 9.59,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.62115787),
        dec: Angle.Degrees(-24.87683586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2550",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2550"},
        {"Smithsonian Astrophysical Observation", "SAO 166340"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.10503623),
        dec: Angle.Degrees(-24.87622499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20154"},
        {"Hipparcos Number", "HIP 15016"},
        {"Geneva Identification System", "GEN# +1.00020154"},
        {"Smithsonian Astrophysical Observation", "SAO 168394"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.39081719),
        dec: Angle.Degrees(-24.87604485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159173"},
        {"Hipparcos Number", "HIP 85974"},
        {"Smithsonian Astrophysical Observation", "SAO 185514"},
    },
    visualMagnitude: 8.04,
    bvColour: 2.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.56090035),
        dec: Angle.Degrees(-24.87590456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18951",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25702"},
        {"Hipparcos Number", "HIP 18951"},
        {"Smithsonian Astrophysical Observation", "SAO 169081"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91589498),
        dec: Angle.Degrees(-24.87558817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200172"},
        {"Hipparcos Number", "HIP 103844"},
        {"Geneva Identification System", "GEN# +1.00200172"},
        {"Smithsonian Astrophysical Observation", "SAO 189957"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.63085555),
        dec: Angle.Degrees(-24.87525279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75403",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75403"},
        {"Smithsonian Astrophysical Observation", "SAO 183437"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.10891057),
        dec: Angle.Degrees(-24.87396356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102276"},
        {"Hipparcos Number", "HIP 57411"},
        {"Smithsonian Astrophysical Observation", "SAO 180169"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.54145925),
        dec: Angle.Degrees(-24.87339721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4168"},
        {"Hipparcos Number", "HIP 3443"},
        {"Smithsonian Astrophysical Observation", "SAO 166521"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.99558074),
        dec: Angle.Degrees(-24.87244013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56043"},
        {"Hipparcos Number", "HIP 34997"},
        {"Smithsonian Astrophysical Observation", "SAO 173270"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.61174785),
        dec: Angle.Degrees(-24.87149042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107756"},
        {"Hipparcos Number", "HIP 60396"},
        {"Smithsonian Astrophysical Observation", "SAO 180742"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.75055093),
        dec: Angle.Degrees(-24.87131004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195470"},
        {"Hipparcos Number", "HIP 101336"},
        {"Smithsonian Astrophysical Observation", "SAO 189406"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.07888269),
        dec: Angle.Degrees(-24.87045456)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191934"},
        {"Hipparcos Number", "HIP 99627"},
        {"Smithsonian Astrophysical Observation", "SAO 189034"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.28711385),
        dec: Angle.Degrees(-24.86756792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31533",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47141"},
        {"Hipparcos Number", "HIP 31533"},
        {"Smithsonian Astrophysical Observation", "SAO 172003"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.02256523),
        dec: Angle.Degrees(-24.86605750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108742",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209133"},
        {"Hipparcos Number", "HIP 108742"},
        {"Geneva Identification System", "GEN# +1.00209133"},
        {"Smithsonian Astrophysical Observation", "SAO 190833"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.41979199),
        dec: Angle.Degrees(-24.86563287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3234"},
        {"Hipparcos Number", "HIP 2775"},
        {"Geneva Identification System", "GEN# +1.00003234"},
        {"Smithsonian Astrophysical Observation", "SAO 166386"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.85437665),
        dec: Angle.Degrees(-24.86418887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118709"},
        {"Hipparcos Number", "HIP 66592"},
        {"Fundamental Katalog 5th Edition", "FK5 5206"},
        {"Smithsonian Astrophysical Observation", "SAO 181831"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.75660599),
        dec: Angle.Degrees(-24.86260616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38170",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Azmidi"},
        {"Common Name 2", "Asmidiske"},
        {"Common Name 3", "Azmidiske"},
        {"Aitken", "ADS 6393 A"},
        {"Henry Draper", "HD 63700"},
        {"Hipparcos Number", "HIP 38170"},
        {"Fundamental Katalog 5th Edition", "FK5 1204"},
        {"Geneva Identification System", "GEN# +1.00063700"},
        {"Smithsonian Astrophysical Observation", "SAO 174601"},
        {"Wilson Evans Batten Catalogue", "WEB 7525"},
    },
    visualMagnitude: 3.34,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.32357809),
        dec: Angle.Degrees(-24.85978401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221647"},
        {"Hipparcos Number", "HIP 116315"},
        {"Geneva Identification System", "GEN# +1.00221647"},
        {"Smithsonian Astrophysical Observation", "SAO 191996"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.50096840),
        dec: Angle.Degrees(-24.85964985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185905"},
        {"Hipparcos Number", "HIP 96938"},
        {"Geneva Identification System", "GEN# +1.00185905"},
        {"Smithsonian Astrophysical Observation", "SAO 188470"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.59430506),
        dec: Angle.Degrees(-24.85924653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103581"},
        {"Hipparcos Number", "HIP 58148"},
        {"Smithsonian Astrophysical Observation", "SAO 180301"},
    },
    visualMagnitude: 6.80,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.87666637),
        dec: Angle.Degrees(-24.85775711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -72.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48979",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48979"},
        {"Geneva Identification System", "GEN# -0.02408642"},
        {"Smithsonian Astrophysical Observation", "SAO 178281"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.89513394),
        dec: Angle.Degrees(-24.85718727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23756"},
        {"Hipparcos Number", "HIP 17638"},
        {"Smithsonian Astrophysical Observation", "SAO 168825"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.68686367),
        dec: Angle.Degrees(-24.85579318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6669"},
        {"Hipparcos Number", "HIP 5256"},
        {"Smithsonian Astrophysical Observation", "SAO 166813"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.79672237),
        dec: Angle.Degrees(-24.85509871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56995"},
        {"Hipparcos Number", "HIP 35370"},
        {"Celescope Catalog", "CEL 1755"},
        {"Geneva Identification System", "GEN# +2.23620068"},
        {"New General Catalogue", "NGC 2362 68"},
    },
    visualMagnitude: 8.91,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.59140355),
        dec: Angle.Degrees(-24.85330052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219339"},
        {"Hipparcos Number", "HIP 114802"},
        {"Geneva Identification System", "GEN# +1.00219339"},
        {"Smithsonian Astrophysical Observation", "SAO 191760"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.83048337),
        dec: Angle.Degrees(-24.85181411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111226"},
        {"Hipparcos Number", "HIP 62448"},
        {"Celescope Catalog", "CEL 4157"},
        {"Fundamental Katalog 5th Edition", "FK5 1329"},
        {"Geneva Identification System", "GEN# +1.00111226"},
        {"Smithsonian Astrophysical Observation", "SAO 181105"},
        {"Wilson Evans Batten Catalogue", "WEB 11085"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.97363562),
        dec: Angle.Degrees(-24.85174736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17144"},
        {"Hipparcos Number", "HIP 12788"},
        {"Smithsonian Astrophysical Observation", "SAO 168013"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.08909830),
        dec: Angle.Degrees(-24.85133707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2207",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 370 AB"},
        {"Henry Draper", "HD 2425"},
        {"Hipparcos Number", "HIP 2207"},
        {"Smithsonian Astrophysical Observation", "SAO 166288"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.97457625),
        dec: Angle.Degrees(-24.84840670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2014"},
        {"Hipparcos Number", "HIP 1933"},
        {"Geneva Identification System", "GEN# +1.00002014"},
        {"Smithsonian Astrophysical Observation", "SAO 166241"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.904,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.09100626),
        dec: Angle.Degrees(-24.84827512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 293.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176704"},
        {"Hipparcos Number", "HIP 93498"},
        {"Geneva Identification System", "GEN# +1.00176704"},
        {"Smithsonian Astrophysical Observation", "SAO 187599"},
        {"Wilson Evans Batten Catalogue", "WEB 16230"},
    },
    visualMagnitude: 5.63,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.61537869),
        dec: Angle.Degrees(-24.84639516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -177.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108923",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15581 A"},
        {"Henry Draper", "HD 209426"},
        {"Henry Draper 2", "HD 209426A"},
        {"Hipparcos Number", "HIP 108923"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.97012213),
        dec: Angle.Degrees(-24.84633856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 211.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201921"},
        {"Hipparcos Number", "HIP 104751"},
        {"Smithsonian Astrophysical Observation", "SAO 190133"},
        {"Wilson Evans Batten Catalogue", "WEB 19053"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.32847273),
        dec: Angle.Degrees(-24.84594913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98588",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98588"},
        {"Smithsonian Astrophysical Observation", "SAO 188831"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.38278718),
        dec: Angle.Degrees(-24.84572720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223611"},
        {"Hipparcos Number", "HIP 117608"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.78028169),
        dec: Angle.Degrees(-24.84562060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76799"},
        {"Hipparcos Number", "HIP 44007"},
        {"Smithsonian Astrophysical Observation", "SAO 176747"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.41825967),
        dec: Angle.Degrees(-24.84103810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107815"},
        {"Hipparcos Number", "HIP 60425"},
        {"Geneva Identification System", "GEN# +1.00107815"},
        {"Smithsonian Astrophysical Observation", "SAO 180747"},
        {"Wilson Evans Batten Catalogue", "WEB 10746"},
    },
    visualMagnitude: 5.66,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.83999906),
        dec: Angle.Degrees(-24.84062116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82397"},
        {"Hipparcos Number", "HIP 46691"},
        {"Smithsonian Astrophysical Observation", "SAO 177591"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.77663177),
        dec: Angle.Degrees(-24.84012069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19899"},
        {"Hipparcos Number", "HIP 14798"},
        {"Smithsonian Astrophysical Observation", "SAO 168364"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.77908603),
        dec: Angle.Degrees(-24.83944271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185742"},
        {"Hipparcos Number", "HIP 96879"},
        {"Geneva Identification System", "GEN# +1.00185742"},
        {"Smithsonian Astrophysical Observation", "SAO 188448"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.39787546),
        dec: Angle.Degrees(-24.83764329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151902"},
        {"Hipparcos Number", "HIP 82474"},
        {"Smithsonian Astrophysical Observation", "SAO 184715"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.83967831),
        dec: Angle.Degrees(-24.83415718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142990"},
        {"Hipparcos Number", "HIP 78246"},
        {"Geneva Identification System", "GEN# +1.00142990"},
        {"Renson", "Renson 40530"},
        {"Smithsonian Astrophysical Observation", "SAO 183982"},
        {"Wilson Evans Batten Catalogue", "WEB 13231"},
    },
    visualMagnitude: 5.43,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.64530965),
        dec: Angle.Degrees(-24.83142974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106137"},
        {"Hipparcos Number", "HIP 59563"},
        {"Smithsonian Astrophysical Observation", "SAO 180566"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.22005153),
        dec: Angle.Degrees(-24.82818548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201553"},
        {"Hipparcos Number", "HIP 104575"},
        {"Smithsonian Astrophysical Observation", "SAO 190093"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.958,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.75783656),
        dec: Angle.Degrees(-24.82769786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73932",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73932"},
        {"Smithsonian Astrophysical Observation", "SAO 183177"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.62453143),
        dec: Angle.Degrees(-24.82723625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201422"},
        {"Hipparcos Number", "HIP 104504"},
        {"Smithsonian Astrophysical Observation", "SAO 190082"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.53256014),
        dec: Angle.Degrees(-24.82301810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198242"},
        {"Hipparcos Number", "HIP 102822"},
        {"Smithsonian Astrophysical Observation", "SAO 189745"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.45430955),
        dec: Angle.Degrees(-24.82160900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150470"},
        {"Hipparcos Number", "HIP 81773"},
        {"Smithsonian Astrophysical Observation", "SAO 184555"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.272,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.53833559),
        dec: Angle.Degrees(-24.81907974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171593"},
        {"Hipparcos Number", "HIP 91254"},
        {"Smithsonian Astrophysical Observation", "SAO 187043"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.20127761),
        dec: Angle.Degrees(-24.81730404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206957"},
        {"Hipparcos Number", "HIP 107484"},
        {"Geneva Identification System", "GEN# +1.00206957"},
        {"Smithsonian Astrophysical Observation", "SAO 190610"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.55435683),
        dec: Angle.Degrees(-24.81722255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177242"},
        {"Hipparcos Number", "HIP 93699"},
        {"Smithsonian Astrophysical Observation", "SAO 187645"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.20370848),
        dec: Angle.Degrees(-24.81580525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37680",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37680"},
    },
    visualMagnitude: 10.45,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.95860978),
        dec: Angle.Degrees(-24.81362609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80831"},
        {"Hipparcos Number", "HIP 45890"},
        {"Geneva Identification System", "GEN# +1.00080831"},
        {"Smithsonian Astrophysical Observation", "SAO 177319"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35264331),
        dec: Angle.Degrees(-24.81241846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15469"},
        {"Hipparcos Number", "HIP 11552"},
        {"Smithsonian Astrophysical Observation", "SAO 167817"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.21447423),
        dec: Angle.Degrees(-24.81224798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65588"},
        {"Hipparcos Number", "HIP 38970"},
        {"Smithsonian Astrophysical Observation", "SAO 174903"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.60980996),
        dec: Angle.Degrees(-24.81023946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111261"},
        {"Hipparcos Number", "HIP 62472"},
        {"Smithsonian Astrophysical Observation", "SAO 181110"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.04544948),
        dec: Angle.Degrees(-24.80701330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -312.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 170.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126218"},
        {"Hipparcos Number", "HIP 70469"},
        {"Fundamental Katalog 5th Edition", "FK5 1376"},
        {"Geneva Identification System", "GEN# +1.00126218"},
        {"Smithsonian Astrophysical Observation", "SAO 182517"},
        {"Wilson Evans Batten Catalogue", "WEB 12225"},
    },
    visualMagnitude: 5.34,
    bvColour: 0.962,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.20275252),
        dec: Angle.Degrees(-24.80626639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111261B"},
        {"Hipparcos Number", "HIP 62471"},
        {"Smithsonian Astrophysical Observation", "SAO 181109"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.04248374),
        dec: Angle.Degrees(-24.80499362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 174.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191845"},
        {"Hipparcos Number", "HIP 99603"},
        {"Smithsonian Astrophysical Observation", "SAO 189028"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.19711045),
        dec: Angle.Degrees(-24.80440944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17527"},
        {"Hipparcos Number", "HIP 13066"},
        {"Smithsonian Astrophysical Observation", "SAO 168059"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.99026460),
        dec: Angle.Degrees(-24.79957724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36564"},
        {"Hipparcos Number", "HIP 25891"},
        {"Smithsonian Astrophysical Observation", "SAO 170514"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.90847083),
        dec: Angle.Degrees(-24.79825603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193379"},
        {"Hipparcos Number", "HIP 100322"},
        {"Smithsonian Astrophysical Observation", "SAO 189178"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.18809537),
        dec: Angle.Degrees(-24.79807304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9063"},
        {"Hipparcos Number", "HIP 6897"},
        {"Geneva Identification System", "GEN# +1.00009063"},
        {"Smithsonian Astrophysical Observation", "SAO 167078"},
        {"Wilson Evans Batten Catalogue", "WEB 1503"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.19959646),
        dec: Angle.Degrees(-24.79791674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13765"},
        {"Hipparcos Number", "HIP 10367"},
        {"Geneva Identification System", "GEN# +1.00013765"},
        {"Smithsonian Astrophysical Observation", "SAO 167645"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.40034840),
        dec: Angle.Degrees(-24.79028505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103896"},
        {"Hipparcos Number", "HIP 58335"},
        {"Smithsonian Astrophysical Observation", "SAO 180334"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.44565673),
        dec: Angle.Degrees(-24.78914688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12629"},
        {"Hipparcos Number", "HIP 9587"},
        {"Smithsonian Astrophysical Observation", "SAO 167521"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.79563792),
        dec: Angle.Degrees(-24.78730653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122584"},
        {"Hipparcos Number", "HIP 68666"},
        {"Smithsonian Astrophysical Observation", "SAO 182195"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.84258320),
        dec: Angle.Degrees(-24.78654975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70694"},
        {"Hipparcos Number", "HIP 41033"},
        {"Smithsonian Astrophysical Observation", "SAO 175696"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.61440086),
        dec: Angle.Degrees(-24.78128207)
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
    primaryId: "HIP 22007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30117"},
        {"Hipparcos Number", "HIP 22007"},
        {"Smithsonian Astrophysical Observation", "SAO 169703"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.95756105),
        dec: Angle.Degrees(-24.77939104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67858",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67858"},
        {"Smithsonian Astrophysical Observation", "SAO 182058"},
    },
    visualMagnitude: 10.14,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48338650),
        dec: Angle.Degrees(-24.77781967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -138.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55505",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8141 AB"},
        {"Henry Draper", "HD 98800"},
        {"Hipparcos Number", "HIP 55505"},
        {"Geneva Identification System", "GEN# +1.00098800"},
        {"Smithsonian Astrophysical Observation", "SAO 179815"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.52226953),
        dec: Angle.Degrees(-24.77762990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -85.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4164",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 733"},
        {"Henry Draper", "HD 5156"},
        {"Hipparcos Number", "HIP 4164"},
        {"Geneva Identification System", "GEN# +1.00005156J"},
        {"Smithsonian Astrophysical Observation", "SAO 166651"},
        {"Wilson Evans Batten Catalogue", "WEB 747"},
    },
    visualMagnitude: 6.44,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.30164021),
        dec: Angle.Degrees(-24.77697293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108322"},
        {"Hipparcos Number", "HIP 60736"},
        {"Smithsonian Astrophysical Observation", "SAO 180802"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.71654588),
        dec: Angle.Degrees(-24.77668207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59707",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8474 A"},
        {"Henry Draper", "HD 106453"},
        {"Hipparcos Number", "HIP 59707"},
        {"Geneva Identification System", "GEN# +1.00106453"},
        {"Smithsonian Astrophysical Observation", "SAO 180598"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.67627238),
        dec: Angle.Degrees(-24.77510351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -292.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36239",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59137"},
        {"Hipparcos Number", "HIP 36239"},
        {"Smithsonian Astrophysical Observation", "SAO 173783"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.93733159),
        dec: Angle.Degrees(-24.77405077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190705"},
        {"Hipparcos Number", "HIP 99098"},
        {"Smithsonian Astrophysical Observation", "SAO 188926"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.77835223),
        dec: Angle.Degrees(-24.77384698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25045",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3954 AB"},
        {"Hipparcos Number", "HIP 25045"},
        {"Geneva Identification System", "GEN# +1.00035162J"},
    },
    visualMagnitude: 5.06,
    bvColour: 0.662,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.44278196),
        dec: Angle.Degrees(-24.77294996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14035"},
        {"Hipparcos Number", "HIP 10543"},
        {"Smithsonian Astrophysical Observation", "SAO 167667"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.634,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.94748550),
        dec: Angle.Degrees(-24.77247379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169091"},
        {"Hipparcos Number", "HIP 90169"},
        {"Smithsonian Astrophysical Observation", "SAO 186765"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.99936376),
        dec: Angle.Degrees(-24.77043517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174996"},
        {"Hipparcos Number", "HIP 92780"},
        {"Smithsonian Astrophysical Observation", "SAO 187431"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.59491315),
        dec: Angle.Degrees(-24.76897159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2941",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 520 AB"},
        {"Henry Draper", "HD 3443"},
        {"Hipparcos Number", "HIP 2941"},
        {"Cincinnati Publication", "Ci 20 39"},
        {"Geneva Identification System", "GEN# +1.00003443"},
        {"Smithsonian Astrophysical Observation", "SAO 166418"},
        {"Wilson Evans Batten Catalogue", "WEB 532"},
    },
    visualMagnitude: 5.57,
    bvColour: 0.715,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.33244613),
        dec: Angle.Degrees(-24.76722545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1422.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8176 AB"},
        {"Henry Draper", "HD 99837"},
        {"Hipparcos Number", "HIP 56025"},
        {"Smithsonian Astrophysical Observation", "SAO 179926"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.24436759),
        dec: Angle.Degrees(-24.76686121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77184",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77184"},
        {"Smithsonian Astrophysical Observation", "SAO 183762"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.41223208),
        dec: Angle.Degrees(-24.76620263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100748"},
        {"Hipparcos Number", "HIP 56539"},
        {"Smithsonian Astrophysical Observation", "SAO 180014"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.89430791),
        dec: Angle.Degrees(-24.76551773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222828"},
        {"Hipparcos Number", "HIP 117068"},
        {"Geneva Identification System", "GEN# +1.00222828"},
        {"Renson", "Renson 61105"},
        {"Smithsonian Astrophysical Observation", "SAO 192114"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.99229714),
        dec: Angle.Degrees(-24.76471351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212271"},
        {"Hipparcos Number", "HIP 110529"},
        {"Geneva Identification System", "GEN# +1.00212271"},
        {"Smithsonian Astrophysical Observation", "SAO 191105"},
        {"Wilson Evans Batten Catalogue", "WEB 19810"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.87827430),
        dec: Angle.Degrees(-24.76265507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 97.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14568"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.02695028),
        dec: Angle.Degrees(-24.75994464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 303.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 122.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16923",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22659"},
        {"Hipparcos Number", "HIP 16923"},
        {"Smithsonian Astrophysical Observation", "SAO 168689"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.44827818),
        dec: Angle.Degrees(-24.75994250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148352"},
        {"Hipparcos Number", "HIP 80685"},
        {"Geneva Identification System", "GEN# +1.00148352"},
        {"Smithsonian Astrophysical Observation", "SAO 184405"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.10497685),
        dec: Angle.Degrees(-24.75011993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6001"},
        {"Hipparcos Number", "HIP 4753"},
        {"Smithsonian Astrophysical Observation", "SAO 166748"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.27521151),
        dec: Angle.Degrees(-24.74819135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75844"},
        {"Hipparcos Number", "HIP 43504"},
        {"Smithsonian Astrophysical Observation", "SAO 176589"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.91413568),
        dec: Angle.Degrees(-24.74806611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218422"},
        {"Hipparcos Number", "HIP 114242"},
        {"Geneva Identification System", "GEN# +1.00218422"},
        {"Smithsonian Astrophysical Observation", "SAO 191672"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.06338007),
        dec: Angle.Degrees(-24.74291973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -166.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123106"},
        {"Hipparcos Number", "HIP 68873"},
        {"Smithsonian Astrophysical Observation", "SAO 182240"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.54691400),
        dec: Angle.Degrees(-24.74052926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72259"},
        {"Smithsonian Astrophysical Observation", "SAO 182862"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.64680210),
        dec: Angle.Degrees(-24.73926668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2050"},
        {"Hipparcos Number", "HIP 1944"},
        {"Geneva Identification System", "GEN# +1.00002050"},
        {"Smithsonian Astrophysical Observation", "SAO 166245"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.14184785),
        dec: Angle.Degrees(-24.73908220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50155"},
        {"Hipparcos Number", "HIP 32861"},
        {"Geneva Identification System", "GEN# +1.00050155"},
        {"Smithsonian Astrophysical Observation", "SAO 172429"},
    },
    visualMagnitude: 9.05,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.73301596),
        dec: Angle.Degrees(-24.73788780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118029",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224283"},
        {"Hipparcos Number", "HIP 118029"},
        {"Fundamental Katalog 5th Edition", "FK5 3922"},
        {"Geneva Identification System", "GEN# +1.00224283"},
        {"Smithsonian Astrophysical Observation", "SAO 192252"},
    },
    visualMagnitude: 6.31,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.12476549),
        dec: Angle.Degrees(-24.73724204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73897"},
        {"Hipparcos Number", "HIP 42501"},
        {"Smithsonian Astrophysical Observation", "SAO 176257"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.96933453),
        dec: Angle.Degrees(-24.73425838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116321"},
        {"Hipparcos Number", "HIP 65312"},
        {"Geneva Identification System", "GEN# +1.00116321"},
        {"Smithsonian Astrophysical Observation", "SAO 181609"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.79143967),
        dec: Angle.Degrees(-24.73414616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170766"},
        {"Hipparcos Number", "HIP 90861"},
        {"Smithsonian Astrophysical Observation", "SAO 186933"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.03249371),
        dec: Angle.Degrees(-24.73313725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4129"},
        {"Hipparcos Number", "HIP 3423"},
        {"Geneva Identification System", "GEN# +1.00004129"},
        {"Smithsonian Astrophysical Observation", "SAO 166516"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.90417006),
        dec: Angle.Degrees(-24.72935674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59199",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Alchiba"},
        {"Henry Draper", "HD 105452"},
        {"Hipparcos Number", "HIP 59199"},
        {"Geneva Identification System", "GEN# +1.00105452"},
        {"Smithsonian Astrophysical Observation", "SAO 180505"},
        {"Wilson Evans Batten Catalogue", "WEB 10532"},
    },
    visualMagnitude: 4.02,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.10313607),
        dec: Angle.Degrees(-24.72877993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212563"},
        {"Hipparcos Number", "HIP 110695"},
        {"Geneva Identification System", "GEN# +1.00212563"},
        {"Smithsonian Astrophysical Observation", "SAO 191129"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.41844019),
        dec: Angle.Degrees(-24.72873317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155831"},
        {"Hipparcos Number", "HIP 84378"},
        {"Smithsonian Astrophysical Observation", "SAO 185191"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.75257503),
        dec: Angle.Degrees(-24.72770120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108442"},
        {"Hipparcos Number", "HIP 60801"},
        {"Smithsonian Astrophysical Observation", "SAO 180814"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.91736029),
        dec: Angle.Degrees(-24.72724786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27643"},
        {"Hipparcos Number", "HIP 20275"},
        {"Smithsonian Astrophysical Observation", "SAO 169355"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.18721811),
        dec: Angle.Degrees(-24.72652565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143900"},
        {"Hipparcos Number", "HIP 78699"},
        {"Geneva Identification System", "GEN# +1.00143900"},
        {"Smithsonian Astrophysical Observation", "SAO 184075"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.97794097),
        dec: Angle.Degrees(-24.72632678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95666"},
        {"Hipparcos Number", "HIP 53941"},
        {"Smithsonian Astrophysical Observation", "SAO 179454"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.55813766),
        dec: Angle.Degrees(-24.72368858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37354",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61777"},
        {"Hipparcos Number", "HIP 37354"},
        {"Smithsonian Astrophysical Observation", "SAO 174245"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.00671200),
        dec: Angle.Degrees(-24.72223486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101259"},
        {"Hipparcos Number", "HIP 56830"},
        {"Fundamental Katalog 5th Edition", "FK5 2933"},
        {"Geneva Identification System", "GEN# +1.00101259"},
        {"Smithsonian Astrophysical Observation", "SAO 180065"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.75175926),
        dec: Angle.Degrees(-24.72050905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -240.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184552"},
        {"Hipparcos Number", "HIP 96406"},
        {"Geneva Identification System", "GEN# +1.00184552"},
        {"Renson", "Renson 50920"},
        {"Smithsonian Astrophysical Observation", "SAO 188326"},
        {"Wilson Evans Batten Catalogue", "WEB 16908"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.00687266),
        dec: Angle.Degrees(-24.71901737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180067"},
        {"Hipparcos Number", "HIP 94690"},
        {"Smithsonian Astrophysical Observation", "SAO 187895"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.01187811),
        dec: Angle.Degrees(-24.71721415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166001"},
        {"Hipparcos Number", "HIP 88978"},
        {"Fundamental Katalog 5th Edition", "FK5 5600"},
        {"Smithsonian Astrophysical Observation", "SAO 186377"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.42242563),
        dec: Angle.Degrees(-24.71554311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49533",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7644"},
        {"Aitken 2", "ADS 7644 AB"},
        {"Henry Draper", "HD 87793"},
        {"Hipparcos Number", "HIP 49533"},
        {"Smithsonian Astrophysical Observation", "SAO 178425"},
    },
    visualMagnitude: 7.15,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.71042676),
        dec: Angle.Degrees(-24.71548385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210437"},
        {"Hipparcos Number", "HIP 109498"},
        {"Smithsonian Astrophysical Observation", "SAO 190943"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.72883075),
        dec: Angle.Degrees(-24.71422259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85"},
        {"Geneva Identification System", "GEN# -0.02516747"},
        {"Renson", "Renson 61640"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.25600730),
        dec: Angle.Degrees(-24.71404902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60345"},
        {"Hipparcos Number", "HIP 36721"},
        {"Geneva Identification System", "GEN# +1.00060345"},
        {"Smithsonian Astrophysical Observation", "SAO 173987"},
    },
    visualMagnitude: 5.84,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.29074012),
        dec: Angle.Degrees(-24.71078019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80268",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80268"},
        {"Cincinnati Publication", "Ci 20 984"},
        {"Geneva Identification System", "GEN# +6.10010620"},
        {"Geneva Identification System 2", "GEN# -0.02412677"},
    },
    visualMagnitude: 10.23,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78276639),
        dec: Angle.Degrees(-24.70813989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -346.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -676.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172035"},
        {"Hipparcos Number", "HIP 91441"},
        {"Smithsonian Astrophysical Observation", "SAO 187084"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.73336941),
        dec: Angle.Degrees(-24.70801554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177294"},
        {"Hipparcos Number", "HIP 93723"},
        {"Geneva Identification System", "GEN# +1.00177294"},
        {"Smithsonian Astrophysical Observation", "SAO 187647"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24980175),
        dec: Angle.Degrees(-24.66697503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105446",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14888 AB"},
        {"Henry Draper", "HD 203210"},
        {"Hipparcos Number", "HIP 105446"},
        {"Smithsonian Astrophysical Observation", "SAO 190258"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37056265),
        dec: Angle.Degrees(-24.70729924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62790",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8688 AB"},
        {"Henry Draper", "HD 111785"},
        {"Hipparcos Number", "HIP 62790"},
        {"Smithsonian Astrophysical Observation", "SAO 181170"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.99531095),
        dec: Angle.Degrees(-24.70713985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151271"},
        {"Hipparcos Number", "HIP 82176"},
        {"Smithsonian Astrophysical Observation", "SAO 184636"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84071877),
        dec: Angle.Degrees(-24.70632094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50176"},
        {"Hipparcos Number", "HIP 32882"},
        {"Geneva Identification System", "GEN# +1.00050176"},
    },
    visualMagnitude: 10.31,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.77620534),
        dec: Angle.Degrees(-24.70627523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216846"},
        {"Hipparcos Number", "HIP 113295"},
        {"Smithsonian Astrophysical Observation", "SAO 191510"},
    },
    visualMagnitude: 9.93,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.13815383),
        dec: Angle.Degrees(-24.70611441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84861",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84861"},
        {"Smithsonian Astrophysical Observation", "SAO 185285"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.16256165),
        dec: Angle.Degrees(-24.70476948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213218"},
        {"Hipparcos Number", "HIP 111083"},
        {"Smithsonian Astrophysical Observation", "SAO 191193"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.56046265),
        dec: Angle.Degrees(-24.70437597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37327"},
        {"Hipparcos Number", "HIP 26355"},
        {"Smithsonian Astrophysical Observation", "SAO 170594"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.18356762),
        dec: Angle.Degrees(-24.70332816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83261"},
        {"Hipparcos Number", "HIP 47159"},
        {"Geneva Identification System", "GEN# +1.00083261J"},
        {"Smithsonian Astrophysical Observation", "SAO 177738"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.14058925),
        dec: Angle.Degrees(-24.70295642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13167"},
        {"Hipparcos Number", "HIP 9960"},
        {"Geneva Identification System", "GEN# +1.00013167"},
        {"Smithsonian Astrophysical Observation", "SAO 167577"},
        {"Wilson Evans Batten Catalogue", "WEB 2088"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.05730960),
        dec: Angle.Degrees(-24.69531682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206062"},
        {"Hipparcos Number", "HIP 106997"},
        {"Smithsonian Astrophysical Observation", "SAO 190535"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.04448419),
        dec: Angle.Degrees(-24.69290609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6674",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6674"},
        {"Smithsonian Astrophysical Observation", "SAO 167041"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.40936295),
        dec: Angle.Degrees(-24.69190748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197300"},
        {"Hipparcos Number", "HIP 102290"},
        {"Smithsonian Astrophysical Observation", "SAO 189614"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.89208493),
        dec: Angle.Degrees(-24.69170384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5410"},
        {"Geneva Identification System", "GEN# +9.80268130"},
    },
    visualMagnitude: 12.38,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.30128688),
        dec: Angle.Degrees(-24.68920246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35513"},
        {"Hipparcos Number", "HIP 25273"},
        {"Geneva Identification System", "GEN# +1.00035513"},
        {"Smithsonian Astrophysical Observation", "SAO 170395"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.06891775),
        dec: Angle.Degrees(-24.68917560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87453",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87453"},
    },
    visualMagnitude: 12.09,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.03807347),
        dec: Angle.Degrees(-24.66686690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35473"},
        {"Geneva Identification System", "GEN# -0.02405190"},
        {"Smithsonian Astrophysical Observation", "SAO 173469"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.83675970),
        dec: Angle.Degrees(-24.68753874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50711"},
        {"Hipparcos Number", "HIP 33081"},
        {"Geneva Identification System", "GEN# +5.11210003"},
        {"Smithsonian Astrophysical Observation", "SAO 172516"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.34207027),
        dec: Angle.Degrees(-24.68435217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161136"},
        {"Hipparcos Number", "HIP 86866"},
        {"Smithsonian Astrophysical Observation", "SAO 185688"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.22720308),
        dec: Angle.Degrees(-24.68399259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156899"},
        {"Hipparcos Number", "HIP 84907"},
        {"Geneva Identification System", "GEN# +1.00156899"},
        {"Smithsonian Astrophysical Observation", "SAO 185299"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.28158022),
        dec: Angle.Degrees(-24.68352982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142505"},
        {"Hipparcos Number", "HIP 78008"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.93890950),
        dec: Angle.Degrees(-24.68251757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39695",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39695"},
        {"Smithsonian Astrophysical Observation", "SAO 175191"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.69416207),
        dec: Angle.Degrees(-24.68115039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165016"},
        {"Hipparcos Number", "HIP 88560"},
        {"Celescope Catalog", "CEL 4613"},
        {"Geneva Identification System", "GEN# +1.00165016"},
        {"Smithsonian Astrophysical Observation", "SAO 186240"},
        {"Wilson Evans Batten Catalogue", "WEB 14994"},
    },
    visualMagnitude: 7.33,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.24245590),
        dec: Angle.Degrees(-24.68080487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121394"},
        {"Hipparcos Number", "HIP 68010"},
        {"Smithsonian Astrophysical Observation", "SAO 182089"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.91206676),
        dec: Angle.Degrees(-24.68041946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37716"},
        {"Smithsonian Astrophysical Observation", "SAO 174415"},
    },
    visualMagnitude: 10.17,
    bvColour: -0.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.04889583),
        dec: Angle.Degrees(-24.67892439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51285"},
        {"Hipparcos Number", "HIP 33309"},
        {"Celescope Catalog", "CEL 1441"},
        {"Geneva Identification System", "GEN# +1.00051285"},
        {"Smithsonian Astrophysical Observation", "SAO 172584"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.92851507),
        dec: Angle.Degrees(-24.67884130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74931"},
        {"Hipparcos Number", "HIP 43040"},
        {"Smithsonian Astrophysical Observation", "SAO 176443"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.54056061),
        dec: Angle.Degrees(-24.67844592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19047"},
        {"Hipparcos Number", "HIP 14199"},
        {"Smithsonian Astrophysical Observation", "SAO 168262"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.77916813),
        dec: Angle.Degrees(-24.67737462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62747"},
        {"Hipparcos Number", "HIP 37751"},
        {"Geneva Identification System", "GEN# +1.00062747"},
        {"Smithsonian Astrophysical Observation", "SAO 174433"},
        {"Wilson Evans Batten Catalogue", "WEB 7461"},
    },
    visualMagnitude: 5.62,
    bvColour: -0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.14238612),
        dec: Angle.Degrees(-24.67409186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157987"},
        {"Hipparcos Number", "HIP 85440"},
        {"Smithsonian Astrophysical Observation", "SAO 185419"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.90526440),
        dec: Angle.Degrees(-24.66786200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59841"},
        {"Hipparcos Number", "HIP 36532"},
        {"Celescope Catalog", "CEL 1902"},
        {"Geneva Identification System", "GEN# +1.00059841"},
        {"Smithsonian Astrophysical Observation", "SAO 173905"},
    },
    visualMagnitude: 8.17,
    bvColour: -0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.73491266),
        dec: Angle.Degrees(-24.66716252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113103"},
        {"Hipparcos Number", "HIP 63569"},
        {"Geneva Identification System", "GEN# +1.00113103"},
        {"Smithsonian Astrophysical Observation", "SAO 181325"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.40272138),
        dec: Angle.Degrees(-24.66627362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68587",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9087 AB"},
        {"Henry Draper", "HD 122445"},
        {"Hipparcos Number", "HIP 68587"},
        {"Smithsonian Astrophysical Observation", "SAO 182184"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.685,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.61457457),
        dec: Angle.Degrees(-24.66461569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -123.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5377"},
        {"Hipparcos Number", "HIP 4326"},
        {"Fundamental Katalog 5th Edition", "FK5 4081"},
        {"Geneva Identification System", "GEN# +1.00005377"},
        {"Smithsonian Astrophysical Observation", "SAO 166682"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.84487241),
        dec: Angle.Degrees(-24.66019794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29557"},
        {"Hipparcos Number", "HIP 21605"},
        {"Smithsonian Astrophysical Observation", "SAO 169629"},
    },
    visualMagnitude: 8.60,
    bvColour: -0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.56738612),
        dec: Angle.Degrees(-24.65856452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178075"},
        {"Hipparcos Number", "HIP 93993"},
        {"Geneva Identification System", "GEN# +1.00178075"},
        {"Smithsonian Astrophysical Observation", "SAO 187718"},
        {"Wilson Evans Batten Catalogue", "WEB 16355"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.06066188),
        dec: Angle.Degrees(-24.65734762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116333"},
        {"Hipparcos Number", "HIP 65324"},
        {"Smithsonian Astrophysical Observation", "SAO 181611"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.83327714),
        dec: Angle.Degrees(-24.65564465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139347"},
        {"Hipparcos Number", "HIP 76578"},
        {"Smithsonian Astrophysical Observation", "SAO 183647"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.59222127),
        dec: Angle.Degrees(-24.65493437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174521"},
        {"Hipparcos Number", "HIP 92576"},
        {"Smithsonian Astrophysical Observation", "SAO 187372"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.96560698),
        dec: Angle.Degrees(-24.65441817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131386"},
        {"Hipparcos Number", "HIP 72910"},
        {"Smithsonian Astrophysical Observation", "SAO 182979"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.52288122),
        dec: Angle.Degrees(-24.65440403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107124",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15221 A"},
        {"Henry Draper", "HD 206319"},
        {"Hipparcos Number", "HIP 107124"},
        {"Smithsonian Astrophysical Observation", "SAO 190558"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.49645017),
        dec: Angle.Degrees(-24.65321532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62888"},
        {"Hipparcos Number", "HIP 37812"},
        {"Geneva Identification System", "GEN# +1.00062888"},
        {"Smithsonian Astrophysical Observation", "SAO 174454"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.29086727),
        dec: Angle.Degrees(-24.65268168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17242"},
        {"Hipparcos Number", "HIP 12864"},
        {"Geneva Identification System", "GEN# +1.00017242"},
        {"Smithsonian Astrophysical Observation", "SAO 168027"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.34484690),
        dec: Angle.Degrees(-24.65218025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200883"},
        {"Hipparcos Number", "HIP 104221"},
        {"Geneva Identification System", "GEN# +1.00200883"},
        {"Smithsonian Astrophysical Observation", "SAO 190017"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71868030),
        dec: Angle.Degrees(-24.65215435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23148"},
        {"Hipparcos Number", "HIP 17276"},
        {"Geneva Identification System", "GEN# +1.00023148"},
        {"Smithsonian Astrophysical Observation", "SAO 168751"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.49622425),
        dec: Angle.Degrees(-24.65215153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 163.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1868"},
        {"Geneva Identification System", "GEN# -0.02500123"},
        {"Smithsonian Astrophysical Observation", "SAO 166233"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.90944142),
        dec: Angle.Degrees(-24.64882739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 131.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2544",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2916"},
        {"Hipparcos Number", "HIP 2544"},
        {"Geneva Identification System", "GEN# +1.00002916"},
        {"Smithsonian Astrophysical Observation", "SAO 166339"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.09205264),
        dec: Angle.Degrees(-24.64626669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 130.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85114"},
        {"Hipparcos Number", "HIP 48180"},
        {"Smithsonian Astrophysical Observation", "SAO 178042"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.30868143),
        dec: Angle.Degrees(-24.64613584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224662"},
        {"Hipparcos Number", "HIP 118302"},
        {"Smithsonian Astrophysical Observation", "SAO 192298"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.93239965),
        dec: Angle.Degrees(-24.64519826)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131430"},
        {"Hipparcos Number", "HIP 72929"},
        {"Geneva Identification System", "GEN# +1.00131430"},
        {"Smithsonian Astrophysical Observation", "SAO 182983"},
        {"Wilson Evans Batten Catalogue", "WEB 12515"},
    },
    visualMagnitude: 5.27,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.58390100),
        dec: Angle.Degrees(-24.64213517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2527"},
        {"Hipparcos Number", "HIP 2263"},
        {"Geneva Identification System", "GEN# +1.00002527J"},
        {"Smithsonian Astrophysical Observation", "SAO 166303"},
        {"Wilson Evans Batten Catalogue", "WEB 421"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.21142753),
        dec: Angle.Degrees(-24.63668428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164266"},
        {"Hipparcos Number", "HIP 88256"},
        {"Smithsonian Astrophysical Observation", "SAO 186111"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.33386446),
        dec: Angle.Degrees(-24.63217537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181154"},
        {"Hipparcos Number", "HIP 95040"},
        {"Smithsonian Astrophysical Observation", "SAO 187987"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.07280338),
        dec: Angle.Degrees(-24.63169242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24975"},
        {"Hipparcos Number", "HIP 18492"},
        {"Smithsonian Astrophysical Observation", "SAO 168983"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.29998188),
        dec: Angle.Degrees(-24.63160844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33478",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5629 AB"},
        {"Henry Draper", "HD 51733"},
        {"Hipparcos Number", "HIP 33478"},
        {"Geneva Identification System", "GEN# +1.00051733J"},
        {"Smithsonian Astrophysical Observation", "SAO 172644"},
        {"Wilson Evans Batten Catalogue", "WEB 6733"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.39153761),
        dec: Angle.Degrees(-24.63105594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 88.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14157"},
        {"Hipparcos Number", "HIP 10635"},
        {"Geneva Identification System", "GEN# +1.00014157"},
        {"Smithsonian Astrophysical Observation", "SAO 167676"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.22092335),
        dec: Angle.Degrees(-24.63082254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184228"},
        {"Hipparcos Number", "HIP 96260"},
        {"Smithsonian Astrophysical Observation", "SAO 188291"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.58661082),
        dec: Angle.Degrees(-24.62955674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159397"},
        {"Hipparcos Number", "HIP 86086"},
        {"Geneva Identification System", "GEN# +1.00159397"},
        {"Smithsonian Astrophysical Observation", "SAO 185532"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.89190069),
        dec: Angle.Degrees(-24.62812775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81253"},
        {"Hipparcos Number", "HIP 46091"},
        {"Smithsonian Astrophysical Observation", "SAO 177394"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.98165363),
        dec: Angle.Degrees(-24.62808565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7993",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7993"},
    },
    visualMagnitude: 11.93,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.66301417),
        dec: Angle.Degrees(-24.62768965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79433"},
        {"Hipparcos Number", "HIP 45245"},
        {"Smithsonian Astrophysical Observation", "SAO 177126"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.33639603),
        dec: Angle.Degrees(-24.62656818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90197"},
        {"Hipparcos Number", "HIP 50941"},
        {"Geneva Identification System", "GEN# +1.00090197"},
        {"Smithsonian Astrophysical Observation", "SAO 178775"},
        {"Wilson Evans Batten Catalogue", "WEB 9319"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.05856623),
        dec: Angle.Degrees(-24.60669081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -342.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 70.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194565"},
        {"Hipparcos Number", "HIP 100864"},
        {"Smithsonian Astrophysical Observation", "SAO 189293"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.77484691),
        dec: Angle.Degrees(-24.62584370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210899"},
        {"Hipparcos Number", "HIP 109768"},
        {"Smithsonian Astrophysical Observation", "SAO 190981"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.50741865),
        dec: Angle.Degrees(-24.62511997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43827",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43827"},
        {"Smithsonian Astrophysical Observation", "SAO 176698"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.89360213),
        dec: Angle.Degrees(-24.62415100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175526"},
        {"Hipparcos Number", "HIP 92994"},
        {"Smithsonian Astrophysical Observation", "SAO 187483"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.17970961),
        dec: Angle.Degrees(-24.62069565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189"},
        {"Hipparcos Number", "HIP 547"},
        {"Geneva Identification System", "GEN# +1.00000189"},
        {"Smithsonian Astrophysical Observation", "SAO 166051"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.66505810),
        dec: Angle.Degrees(-24.62067192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64996",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115740"},
        {"Hipparcos Number", "HIP 64996"},
        {"Geneva Identification System", "GEN# +1.00115740"},
        {"Smithsonian Astrophysical Observation", "SAO 181550"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.84032860),
        dec: Angle.Degrees(-24.61932029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213565"},
        {"Hipparcos Number", "HIP 111289"},
        {"Geneva Identification System", "GEN# +1.00213565"},
        {"Smithsonian Astrophysical Observation", "SAO 191215"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.17800885),
        dec: Angle.Degrees(-24.61840756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22052"},
        {"Hipparcos Number", "HIP 16500"},
        {"Geneva Identification System", "GEN# +1.00022052"},
        {"Smithsonian Astrophysical Observation", "SAO 168617"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10990452),
        dec: Angle.Degrees(-24.61644779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69924"},
        {"Hipparcos Number", "HIP 40688"},
        {"Smithsonian Astrophysical Observation", "SAO 175555"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.59488447),
        dec: Angle.Degrees(-24.61622240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220350"},
        {"Hipparcos Number", "HIP 115454"},
        {"Geneva Identification System", "GEN# +1.00220350"},
        {"Smithsonian Astrophysical Observation", "SAO 191861"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.80438469),
        dec: Angle.Degrees(-24.61603904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24587"},
        {"Hipparcos Number", "HIP 18216"},
        {"Geneva Identification System", "GEN# +1.00024587"},
        {"Renson", "Renson 6296"},
        {"Smithsonian Astrophysical Observation", "SAO 168925"},
        {"Wilson Evans Batten Catalogue", "WEB 3518"},
    },
    visualMagnitude: 4.64,
    bvColour: -0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.42784574),
        dec: Angle.Degrees(-24.61221253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5998"},
        {"Smithsonian Astrophysical Observation", "SAO 166926"},
    },
    visualMagnitude: 10.48,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.28277957),
        dec: Angle.Degrees(-24.60981435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61025"},
        {"Hipparcos Number", "HIP 37006"},
        {"Smithsonian Astrophysical Observation", "SAO 174101"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.07548711),
        dec: Angle.Degrees(-24.60981104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17620"},
        {"Hipparcos Number", "HIP 13134"},
        {"Geneva Identification System", "GEN# +1.00017620"},
        {"Smithsonian Astrophysical Observation", "SAO 168069"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.23244648),
        dec: Angle.Degrees(-24.60979413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6871 AB"},
        {"Henry Draper", "HD 72626"},
        {"Hipparcos Number", "HIP 41949"},
        {"Geneva Identification System", "GEN# +1.00072626J"},
        {"Smithsonian Astrophysical Observation", "SAO 176061"},
        {"Wilson Evans Batten Catalogue", "WEB 8075"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.27019048),
        dec: Angle.Degrees(-24.60689225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66555"},
        {"Hipparcos Number", "HIP 39389"},
        {"Geneva Identification System", "GEN# +1.00066555"},
        {"Smithsonian Astrophysical Observation", "SAO 175065"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.878,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.79514895),
        dec: Angle.Degrees(-24.60661870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209068"},
        {"Hipparcos Number", "HIP 108702"},
        {"Geneva Identification System", "GEN# +1.00209068"},
        {"Smithsonian Astrophysical Observation", "SAO 190827"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.29914704),
        dec: Angle.Degrees(-24.60398780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9310"},
        {"Hipparcos Number", "HIP 7077"},
        {"Geneva Identification System", "GEN# +1.00009310"},
        {"Smithsonian Astrophysical Observation", "SAO 167104"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.80445690),
        dec: Angle.Degrees(-24.60315442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 528",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 528"},
        {"Smithsonian Astrophysical Observation", "SAO 166046"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.59090838),
        dec: Angle.Degrees(-24.60254997)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219518"},
        {"Hipparcos Number", "HIP 114916"},
        {"Geneva Identification System", "GEN# +1.00219518"},
        {"Smithsonian Astrophysical Observation", "SAO 191781"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.15352665),
        dec: Angle.Degrees(-24.59846500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54532"},
        {"Geneva Identification System", "GEN# -0.02309765"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.38273459),
        dec: Angle.Degrees(-24.59755801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -796.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -446.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61261"},
        {"Hipparcos Number", "HIP 37109"},
        {"Smithsonian Astrophysical Observation", "SAO 174149"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.38331522),
        dec: Angle.Degrees(-24.59691988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -199.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7079"},
        {"Hipparcos Number", "HIP 5532"},
        {"Geneva Identification System", "GEN# +1.00007079"},
        {"Smithsonian Astrophysical Observation", "SAO 166854"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.71033132),
        dec: Angle.Degrees(-24.59647032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73679"},
        {"Smithsonian Astrophysical Observation", "SAO 183131"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.90854973),
        dec: Angle.Degrees(-24.59614905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75777",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75777"},
        {"Smithsonian Astrophysical Observation", "SAO 183504"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.19642224),
        dec: Angle.Degrees(-24.59360360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159722"},
        {"Hipparcos Number", "HIP 86226"},
        {"Smithsonian Astrophysical Observation", "SAO 185552"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.31705808),
        dec: Angle.Degrees(-24.59335353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24621"},
        {"Smithsonian Astrophysical Observation", "SAO 170271"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.20650699),
        dec: Angle.Degrees(-24.59148737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204943"},
        {"Hipparcos Number", "HIP 106363"},
        {"Fundamental Katalog 5th Edition", "FK5 3720"},
        {"Geneva Identification System", "GEN# +1.00204943"},
        {"Smithsonian Astrophysical Observation", "SAO 190423"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.13841001),
        dec: Angle.Degrees(-24.59043287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225076"},
        {"Hipparcos Number", "HIP 255"},
        {"Geneva Identification System", "GEN# +1.00225076"},
        {"Smithsonian Astrophysical Observation", "SAO 166017"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.79452371),
        dec: Angle.Degrees(-24.58828778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93380"},
        {"Hipparcos Number", "HIP 52708"},
        {"Geneva Identification System", "GEN# +1.00093380"},
        {"Smithsonian Astrophysical Observation", "SAO 179214"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.65413534),
        dec: Angle.Degrees(-24.58521552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96707"},
        {"Smithsonian Astrophysical Observation", "SAO 188402"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.89418176),
        dec: Angle.Degrees(-24.58370212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211157"},
        {"Hipparcos Number", "HIP 109912"},
        {"Geneva Identification System", "GEN# +1.00211157"},
        {"Smithsonian Astrophysical Observation", "SAO 191004"},
    },
    visualMagnitude: 9.38,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.91346990),
        dec: Angle.Degrees(-24.58348154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53123"},
        {"Hipparcos Number", "HIP 33970"},
        {"Celescope Catalog", "CEL 1533"},
        {"Geneva Identification System", "GEN# +1.00053123"},
        {"Smithsonian Astrophysical Observation", "SAO 172837"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.72734383),
        dec: Angle.Degrees(-24.58314664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79229",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145127"},
        {"Hipparcos Number", "HIP 79229"},
        {"Geneva Identification System", "GEN# +1.00145127"},
        {"Smithsonian Astrophysical Observation", "SAO 184182"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.54121342),
        dec: Angle.Degrees(-24.58233700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183450"},
        {"Hipparcos Number", "HIP 95936"},
        {"Smithsonian Astrophysical Observation", "SAO 188211"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.65569209),
        dec: Angle.Degrees(-24.58195149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43364",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75565"},
        {"Hipparcos Number", "HIP 43364"},
        {"Smithsonian Astrophysical Observation", "SAO 176540"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.49446094),
        dec: Angle.Degrees(-24.57972182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189966"},
        {"Hipparcos Number", "HIP 98765"},
        {"Smithsonian Astrophysical Observation", "SAO 188859"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.89758700),
        dec: Angle.Degrees(-24.57795403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21307"},
        {"Hipparcos Number", "HIP 15952"},
        {"Smithsonian Astrophysical Observation", "SAO 168533"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.34847657),
        dec: Angle.Degrees(-24.57787324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63485"},
        {"Hipparcos Number", "HIP 38079"},
        {"Smithsonian Astrophysical Observation", "SAO 174563"},
    },
    visualMagnitude: 6.85,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.05203349),
        dec: Angle.Degrees(-24.57721426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60246"},
        {"Hipparcos Number", "HIP 36667"},
        {"Smithsonian Astrophysical Observation", "SAO 173966"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.15714045),
        dec: Angle.Degrees(-24.57284124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35597",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35597"},
        {"Smithsonian Astrophysical Observation", "SAO 173512"},
    },
    visualMagnitude: 9.96,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.19281005),
        dec: Angle.Degrees(-24.57204418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114597"},
        {"Hipparcos Number", "HIP 64396"},
        {"Geneva Identification System", "GEN# +1.00114597"},
        {"Smithsonian Astrophysical Observation", "SAO 181450"},
        {"Wilson Evans Batten Catalogue", "WEB 11380"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.97512352),
        dec: Angle.Degrees(-24.56906165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13499"},
        {"Hipparcos Number", "HIP 10214"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.84197603),
        dec: Angle.Degrees(-24.56783454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35128",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35128"},
        {"Geneva Identification System", "GEN# -0.02405089"},
        {"Smithsonian Astrophysical Observation", "SAO 173318"},
    },
    visualMagnitude: 9.49,
    bvColour: -0.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.93140959),
        dec: Angle.Degrees(-24.56628606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51923"},
        {"Smithsonian Astrophysical Observation", "SAO 179019"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.09876216),
        dec: Angle.Degrees(-24.56586599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169937"},
        {"Hipparcos Number", "HIP 90505"},
        {"Smithsonian Astrophysical Observation", "SAO 186844"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.178,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.01941285),
        dec: Angle.Degrees(-24.56244379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215722"},
        {"Hipparcos Number", "HIP 112524"},
        {"Geneva Identification System", "GEN# +1.00215722"},
        {"Smithsonian Astrophysical Observation", "SAO 191404"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.88079552),
        dec: Angle.Degrees(-24.56030998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13197",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2167 A"},
        {"Henry Draper", "HD 17713"},
        {"Hipparcos Number", "HIP 13197"},
        {"Geneva Identification System", "GEN# +1.00017713"},
        {"Smithsonian Astrophysical Observation", "SAO 168081"},
        {"Wilson Evans Batten Catalogue", "WEB 2652"},
    },
    visualMagnitude: 6.14,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.46247539),
        dec: Angle.Degrees(-24.55999911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140702"},
        {"Hipparcos Number", "HIP 77213"},
        {"Smithsonian Astrophysical Observation", "SAO 183769"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.47672502),
        dec: Angle.Degrees(-24.55940652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127391"},
        {"Hipparcos Number", "HIP 71045"},
        {"Smithsonian Astrophysical Observation", "SAO 182635"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.94592379),
        dec: Angle.Degrees(-24.55903492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57060"},
        {"Hipparcos Number", "HIP 35412"},
        {"Celescope Catalog", "CEL 1760"},
        {"Geneva Identification System", "GEN# +1.00057060"},
        {"Smithsonian Astrophysical Observation", "SAO 173444"},
        {"Wilson Evans Batten Catalogue", "WEB 7066"},
    },
    visualMagnitude: 4.88,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.66825335),
        dec: Angle.Degrees(-24.55870761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11807"},
        {"Hipparcos Number", "HIP 8955"},
        {"Smithsonian Astrophysical Observation", "SAO 167395"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.82926013),
        dec: Angle.Degrees(-24.55824030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86705"},
        {"Smithsonian Astrophysical Observation", "SAO 185648"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.750,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.74441105),
        dec: Angle.Degrees(-24.55638396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44821"},
        {"Hipparcos Number", "HIP 30344"},
        {"Geneva Identification System", "GEN# +1.00044821"},
        {"Smithsonian Astrophysical Observation", "SAO 171659"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.74030304),
        dec: Angle.Degrees(-24.55604925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69846",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125065"},
        {"Hipparcos Number", "HIP 69846"},
        {"Smithsonian Astrophysical Observation", "SAO 182420"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.42123409),
        dec: Angle.Degrees(-24.55524315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13118"},
        {"Hipparcos Number", "HIP 9931"},
        {"Smithsonian Astrophysical Observation", "SAO 167571"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.96368440),
        dec: Angle.Degrees(-24.55279493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5867"},
        {"Hipparcos Number", "HIP 4656"},
        {"Smithsonian Astrophysical Observation", "SAO 166727"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.95979743),
        dec: Angle.Degrees(-24.55237935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93474"},
        {"Hipparcos Number", "HIP 52751"},
        {"Geneva Identification System", "GEN# +1.00093474"},
        {"Smithsonian Astrophysical Observation", "SAO 179224"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.78602142),
        dec: Angle.Degrees(-24.54918451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3530"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.25376216),
        dec: Angle.Degrees(-24.54910414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100221"},
        {"Hipparcos Number", "HIP 56248"},
        {"Smithsonian Astrophysical Observation", "SAO 179965"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.95261241),
        dec: Angle.Degrees(-24.53915525)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50853"},
        {"Hipparcos Number", "HIP 33126"},
        {"Celescope Catalog", "CEL 1424"},
        {"Geneva Identification System", "GEN# +5.11210002"},
        {"Smithsonian Astrophysical Observation", "SAO 172531"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48106510),
        dec: Angle.Degrees(-24.53875948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148428"},
        {"Hipparcos Number", "HIP 80736"},
        {"Geneva Identification System", "GEN# +1.00148428"},
        {"Smithsonian Astrophysical Observation", "SAO 184412"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.24603913),
        dec: Angle.Degrees(-24.53751306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8083",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8083"},
        {"Geneva Identification System", "GEN# +6.10161126"},
    },
    visualMagnitude: 11.77,
    bvColour: -0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.95204639),
        dec: Angle.Degrees(-24.08605939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82928"},
        {"Hipparcos Number", "HIP 46975"},
        {"Smithsonian Astrophysical Observation", "SAO 177680"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.61559608),
        dec: Angle.Degrees(-24.53656431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110919"},
        {"Hipparcos Number", "HIP 62274"},
        {"Smithsonian Astrophysical Observation", "SAO 181082"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.42582986),
        dec: Angle.Degrees(-24.53599597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142165"},
        {"Hipparcos Number", "HIP 77858"},
        {"Celescope Catalog", "CEL 4400"},
        {"Geneva Identification System", "GEN# +1.00142165"},
        {"Smithsonian Astrophysical Observation", "SAO 183900"},
        {"Wilson Evans Batten Catalogue", "WEB 13168"},
    },
    visualMagnitude: 5.38,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.47467996),
        dec: Angle.Degrees(-24.53309547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29239"},
        {"Hipparcos Number", "HIP 21381"},
        {"Geneva Identification System", "GEN# +1.00029239"},
        {"Smithsonian Astrophysical Observation", "SAO 169589"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.82375747),
        dec: Angle.Degrees(-24.53296265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11712"},
        {"Hipparcos Number", "HIP 8889"},
        {"Smithsonian Astrophysical Observation", "SAO 167384"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.60605706),
        dec: Angle.Degrees(-24.53067515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30459"},
    },
    visualMagnitude: 10.82,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.04671299),
        dec: Angle.Degrees(-24.53061276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8636"},
        {"Hipparcos Number", "HIP 6610"},
        {"Smithsonian Astrophysical Observation", "SAO 167031"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.21340934),
        dec: Angle.Degrees(-24.52937808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38316",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6414 AB"},
        {"Henry Draper", "HD 64042"},
        {"Hipparcos Number", "HIP 38316"},
        {"Geneva Identification System", "GEN# +1.00064042J"},
        {"Smithsonian Astrophysical Observation", "SAO 174658"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.75034183),
        dec: Angle.Degrees(-24.52848631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74494"},
        {"Hipparcos Number", "HIP 42825"},
        {"Renson", "Renson 20750"},
        {"Smithsonian Astrophysical Observation", "SAO 176362"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.89557698),
        dec: Angle.Degrees(-24.52758940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151415"},
        {"Hipparcos Number", "HIP 82245"},
        {"Geneva Identification System", "GEN# +1.00151415"},
        {"Smithsonian Astrophysical Observation", "SAO 184652"},
        {"Wilson Evans Batten Catalogue", "WEB 13885"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.05765385),
        dec: Angle.Degrees(-24.52661848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75617",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75617"},
        {"Smithsonian Astrophysical Observation", "SAO 183477"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.75843216),
        dec: Angle.Degrees(-24.52626211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177822"},
        {"Hipparcos Number", "HIP 93901"},
        {"Smithsonian Astrophysical Observation", "SAO 187694"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.81112103),
        dec: Angle.Degrees(-24.52389508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3677"},
        {"Hipparcos Number", "HIP 3099"},
        {"Geneva Identification System", "GEN# +1.00003677"},
        {"Smithsonian Astrophysical Observation", "SAO 166459"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.86150349),
        dec: Angle.Degrees(-24.52353210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29459"},
        {"Smithsonian Astrophysical Observation", "SAO 171380"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.11253846),
        dec: Angle.Degrees(-24.52257633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63659"},
        {"Hipparcos Number", "HIP 38151"},
        {"Smithsonian Astrophysical Observation", "SAO 174594"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.27707252),
        dec: Angle.Degrees(-24.52147822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22958"},
        {"Hipparcos Number", "HIP 17144"},
        {"Smithsonian Astrophysical Observation", "SAO 168725"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.07654585),
        dec: Angle.Degrees(-24.51799656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 100.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113428"},
        {"Hipparcos Number", "HIP 63751"},
        {"Fundamental Katalog 5th Edition", "FK5 5155"},
        {"Smithsonian Astrophysical Observation", "SAO 181361"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.98305310),
        dec: Angle.Degrees(-24.51728631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51575"},
        {"Hipparcos Number", "HIP 33410"},
        {"Celescope Catalog", "CEL 1451"},
        {"Geneva Identification System", "GEN# +1.00051575J"},
        {"Smithsonian Astrophysical Observation", "SAO 172618"},
    },
    visualMagnitude: 8.95,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.22495805),
        dec: Angle.Degrees(-24.51419984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38396"},
        {"Geneva Identification System", "GEN# -0.02406080"},
        {"Smithsonian Astrophysical Observation", "SAO 174690"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.99108731),
        dec: Angle.Degrees(-24.51202584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13434"},
        {"Hipparcos Number", "HIP 10170"},
        {"Smithsonian Astrophysical Observation", "SAO 167614"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.70298300),
        dec: Angle.Degrees(-24.51013712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115870"},
        {"Hipparcos Number", "HIP 65071"},
        {"Smithsonian Astrophysical Observation", "SAO 181562"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.07767414),
        dec: Angle.Degrees(-24.50978499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182369"},
        {"Hipparcos Number", "HIP 95477"},
        {"Geneva Identification System", "GEN# +1.00182369J"},
        {"Renson", "Renson 50430"},
        {"Smithsonian Astrophysical Observation", "SAO 188101"},
        {"Wilson Evans Batten Catalogue", "WEB 16692"},
    },
    visualMagnitude: 5.02,
    bvColour: 0.235,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.31854426),
        dec: Angle.Degrees(-24.50844892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82770",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10252 AB"},
        {"Henry Draper", "HD 152535"},
        {"Hipparcos Number", "HIP 82770"},
        {"Smithsonian Astrophysical Observation", "SAO 184791"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.73829408),
        dec: Angle.Degrees(-24.50824690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125540"},
        {"Hipparcos Number", "HIP 70092"},
        {"Smithsonian Astrophysical Observation", "SAO 182453"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.14972758),
        dec: Angle.Degrees(-24.50678387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27118"},
        {"Hipparcos Number", "HIP 19887"},
        {"Geneva Identification System", "GEN# +1.00027118"},
        {"Smithsonian Astrophysical Observation", "SAO 169277"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.99190700),
        dec: Angle.Degrees(-24.50595733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85246",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85246"},
        {"Smithsonian Astrophysical Observation", "SAO 185376"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.29490631),
        dec: Angle.Degrees(-24.50559069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8649"},
        {"Hipparcos Number", "HIP 6623"},
        {"Smithsonian Astrophysical Observation", "SAO 167034"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.24918565),
        dec: Angle.Degrees(-24.50546123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9527"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.63484278),
        dec: Angle.Degrees(-24.50490480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11600 AB"},
        {"Henry Draper", "HD 172893"},
        {"Hipparcos Number", "HIP 91858"},
        {"Smithsonian Astrophysical Observation", "SAO 187190"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.91751440),
        dec: Angle.Degrees(-24.50487543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9832"},
        {"Hipparcos Number", "HIP 7415"},
        {"Smithsonian Astrophysical Observation", "SAO 167162"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.89543971),
        dec: Angle.Degrees(-24.50401738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3404"},
        {"Hipparcos Number", "HIP 2902"},
        {"Geneva Identification System", "GEN# +1.00003404"},
        {"Smithsonian Astrophysical Observation", "SAO 166411"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.824,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.19507750),
        dec: Angle.Degrees(-24.50078757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5720"},
        {"Smithsonian Astrophysical Observation", "SAO 166881"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.38982493),
        dec: Angle.Degrees(-24.49700197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3403"},
        {"Hipparcos Number", "HIP 2909"},
        {"Geneva Identification System", "GEN# +1.00003403"},
        {"Smithsonian Astrophysical Observation", "SAO 166413"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.21355240),
        dec: Angle.Degrees(-24.49605646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -232.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16805"},
        {"Hipparcos Number", "HIP 12521"},
        {"Smithsonian Astrophysical Observation", "SAO 167972"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.28347439),
        dec: Angle.Degrees(-24.49589175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129381"},
        {"Hipparcos Number", "HIP 71943"},
        {"Geneva Identification System", "GEN# +1.00129381"},
        {"Smithsonian Astrophysical Observation", "SAO 182787"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.71728453),
        dec: Angle.Degrees(-24.49176806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -248.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9689 ABC"},
        {"Henry Draper", "HD 138488"},
        {"Hipparcos Number", "HIP 76143"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.28972685),
        dec: Angle.Degrees(-24.49034196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52595"},
        {"Hipparcos Number", "HIP 33784"},
        {"Smithsonian Astrophysical Observation", "SAO 172757"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.22633728),
        dec: Angle.Degrees(-24.48983401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199407"},
        {"Hipparcos Number", "HIP 103456"},
        {"Geneva Identification System", "GEN# +1.00199407"},
        {"Smithsonian Astrophysical Observation", "SAO 189874"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.41618646),
        dec: Angle.Degrees(-24.48916792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179232"},
        {"Hipparcos Number", "HIP 94397"},
        {"Smithsonian Astrophysical Observation", "SAO 187822"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.18966863),
        dec: Angle.Degrees(-24.48721852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55692",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8152 AB"},
        {"Henry Draper", "HD 99183"},
        {"Hipparcos Number", "HIP 55692"},
        {"Smithsonian Astrophysical Observation", "SAO 179853"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.17273385),
        dec: Angle.Degrees(-24.48552894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1103"},
        {"Hipparcos Number", "HIP 1220"},
        {"Smithsonian Astrophysical Observation", "SAO 166148"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.80512762),
        dec: Angle.Degrees(-24.48509485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102310"},
        {"Hipparcos Number", "HIP 57436"},
        {"Smithsonian Astrophysical Observation", "SAO 180176"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.62184078),
        dec: Angle.Degrees(-24.48440338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203968"},
        {"Hipparcos Number", "HIP 105831"},
        {"Geneva Identification System", "GEN# +1.00203968"},
        {"Smithsonian Astrophysical Observation", "SAO 190331"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.53039155),
        dec: Angle.Degrees(-24.48417231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29737"},
        {"Hipparcos Number", "HIP 21743"},
        {"Fundamental Katalog 5th Edition", "FK5 1127"},
        {"Geneva Identification System", "GEN# +1.00029737"},
        {"Smithsonian Astrophysical Observation", "SAO 169650"},
        {"Wilson Evans Batten Catalogue", "WEB 4181"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.02852595),
        dec: Angle.Degrees(-24.48241131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16689"},
        {"Hipparcos Number", "HIP 12425"},
        {"Geneva Identification System", "GEN# +1.00016689"},
        {"Smithsonian Astrophysical Observation", "SAO 167960"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.98487800),
        dec: Angle.Degrees(-24.48112391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14506"},
        {"Hipparcos Number", "HIP 10879"},
        {"Smithsonian Astrophysical Observation", "SAO 167709"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.00070583),
        dec: Angle.Degrees(-24.47994913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154282"},
        {"Hipparcos Number", "HIP 83637"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.39131136),
        dec: Angle.Degrees(-24.47911891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223183"},
        {"Hipparcos Number", "HIP 117330"},
        {"Smithsonian Astrophysical Observation", "SAO 192151"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.85875161),
        dec: Angle.Degrees(-24.47812969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74830",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74830"},
        {"Smithsonian Astrophysical Observation", "SAO 183344"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.39554772),
        dec: Angle.Degrees(-24.47721988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39436"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.92030983),
        dec: Angle.Degrees(-24.47647733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128278"},
        {"Hipparcos Number", "HIP 71450"},
        {"Smithsonian Astrophysical Observation", "SAO 182700"},
    },
    visualMagnitude: 9.17,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.17825581),
        dec: Angle.Degrees(-24.47527881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9345",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9345"},
        {"Smithsonian Astrophysical Observation", "SAO 167473"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.99922635),
        dec: Angle.Degrees(-24.47497082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103191"},
        {"Hipparcos Number", "HIP 57927"},
        {"Geneva Identification System", "GEN# +1.00103191"},
        {"Smithsonian Astrophysical Observation", "SAO 180261"},
        {"Wilson Evans Batten Catalogue", "WEB 10384"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.719,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.19787421),
        dec: Angle.Degrees(-24.47343737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -239.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 162.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220878"},
        {"Hipparcos Number", "HIP 115795"},
        {"Smithsonian Astrophysical Observation", "SAO 191918"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.88281280),
        dec: Angle.Degrees(-24.47301651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115998"},
        {"Hipparcos Number", "HIP 65151"},
        {"Smithsonian Astrophysical Observation", "SAO 181577"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.27000102),
        dec: Angle.Degrees(-24.47024364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150366"},
        {"Hipparcos Number", "HIP 81728"},
        {"Fundamental Katalog 5th Edition", "FK5 3322"},
        {"Geneva Identification System", "GEN# +1.00150366"},
        {"Renson", "Renson 42530"},
        {"Smithsonian Astrophysical Observation", "SAO 184549"},
        {"Wilson Evans Batten Catalogue", "WEB 13803"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.40089052),
        dec: Angle.Degrees(-24.46793930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147889"},
        {"Hipparcos Number", "HIP 80462"},
        {"Geneva Identification System", "GEN# +1.00147889"},
        {"Smithsonian Astrophysical Observation", "SAO 184376"},
        {"Wilson Evans Batten Catalogue", "WEB 13610"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.35132580),
        dec: Angle.Degrees(-24.46565140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17346"},
        {"Geneva Identification System", "GEN# -0.02401826"},
        {"Smithsonian Astrophysical Observation", "SAO 168764"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.68608585),
        dec: Angle.Degrees(-24.46541637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -373.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34165"},
        {"Hipparcos Number", "HIP 24421"},
        {"Smithsonian Astrophysical Observation", "SAO 170226"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.59282177),
        dec: Angle.Degrees(-24.46410453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8183 A"},
        {"Henry Draper", "HD 99922"},
        {"Henry Draper 2", "HD 99922A"},
        {"Hipparcos Number", "HIP 56078"},
        {"Geneva Identification System", "GEN# +1.00099922"},
        {"Smithsonian Astrophysical Observation", "SAO 179935"},
    },
    visualMagnitude: 5.77,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.41103268),
        dec: Angle.Degrees(-24.46405831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38949"},
        {"Hipparcos Number", "HIP 27417"},
        {"Geneva Identification System", "GEN# +1.00038949"},
        {"Smithsonian Astrophysical Observation", "SAO 170859"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.08365922),
        dec: Angle.Degrees(-24.46376184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144661"},
        {"Hipparcos Number", "HIP 79031"},
        {"Geneva Identification System", "GEN# +1.00144661"},
        {"Renson", "Renson 41000"},
        {"Smithsonian Astrophysical Observation", "SAO 184142"},
        {"Wilson Evans Batten Catalogue", "WEB 13357"},
    },
    visualMagnitude: 6.32,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.96622959),
        dec: Angle.Degrees(-24.46229118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103330"},
        {"Hipparcos Number", "HIP 58009"},
        {"Smithsonian Astrophysical Observation", "SAO 180277"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46838727),
        dec: Angle.Degrees(-24.46022316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25675"},
        {"Hipparcos Number", "HIP 18931"},
        {"Geneva Identification System", "GEN# +1.00025675"},
        {"Smithsonian Astrophysical Observation", "SAO 169075"},
        {"Wilson Evans Batten Catalogue", "WEB 3641"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.87051519),
        dec: Angle.Degrees(-24.46002285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58559"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.11747504),
        dec: Angle.Degrees(-24.45807252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80372"},
        {"Hipparcos Number", "HIP 45685"},
        {"Smithsonian Astrophysical Observation", "SAO 177256"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.70275516),
        dec: Angle.Degrees(-24.45768554)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3241 AB"},
        {"Henry Draper", "HD 28368"},
        {"Hipparcos Number", "HIP 20807"},
        {"Smithsonian Astrophysical Observation", "SAO 169469"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.88198863),
        dec: Angle.Degrees(-24.45719531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73427",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73427"},
        {"Smithsonian Astrophysical Observation", "SAO 183077"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.08135877),
        dec: Angle.Degrees(-24.45401387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315258"},
        {"Hipparcos Number", "HIP 89149"},
        {"Smithsonian Astrophysical Observation", "SAO 186436"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.92281551),
        dec: Angle.Degrees(-24.45285161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205677"},
        {"Hipparcos Number", "HIP 106759"},
        {"Geneva Identification System", "GEN# +1.00205677"},
        {"Smithsonian Astrophysical Observation", "SAO 190501"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.39215905),
        dec: Angle.Degrees(-24.45249836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137859"},
        {"Hipparcos Number", "HIP 75806"},
        {"Smithsonian Astrophysical Observation", "SAO 183513"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.29133280),
        dec: Angle.Degrees(-24.45148395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112401"},
        {"Hipparcos Number", "HIP 63188"},
        {"Smithsonian Astrophysical Observation", "SAO 181250"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.17776602),
        dec: Angle.Degrees(-24.45073860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205889"},
        {"Hipparcos Number", "HIP 106887"},
        {"Smithsonian Astrophysical Observation", "SAO 190517"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.74097395),
        dec: Angle.Degrees(-24.44976007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33698"},
        {"Hipparcos Number", "HIP 24138"},
        {"Smithsonian Astrophysical Observation", "SAO 170158"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.76140656),
        dec: Angle.Degrees(-24.44838764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7652"},
        {"Smithsonian Astrophysical Observation", "SAO 167194"},
    },
    visualMagnitude: 10.67,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.63493561),
        dec: Angle.Degrees(-24.44735606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192331"},
        {"Hipparcos Number", "HIP 99817"},
        {"Smithsonian Astrophysical Observation", "SAO 189066"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.79501191),
        dec: Angle.Degrees(-24.44708575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151692"},
        {"Hipparcos Number", "HIP 82370"},
        {"Geneva Identification System", "GEN# +1.00151692"},
        {"Smithsonian Astrophysical Observation", "SAO 184686"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.47222482),
        dec: Angle.Degrees(-24.44667893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -276.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82818"},
        {"Smithsonian Astrophysical Observation", "SAO 184802"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.87859058),
        dec: Angle.Degrees(-24.44537370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43879"},
        {"Hipparcos Number", "HIP 29888"},
        {"Geneva Identification System", "GEN# +1.00043879"},
        {"Smithsonian Astrophysical Observation", "SAO 171521"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.40579635),
        dec: Angle.Degrees(-24.44443333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1498"},
        {"Hipparcos Number", "HIP 1527"},
        {"Geneva Identification System", "GEN# +1.00001498"},
        {"Smithsonian Astrophysical Observation", "SAO 166182"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.75252177),
        dec: Angle.Degrees(-24.44285831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43922",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43922"},
        {"Smithsonian Astrophysical Observation", "SAO 176735"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.20770878),
        dec: Angle.Degrees(-24.44262065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212644"},
        {"Hipparcos Number", "HIP 110747"},
        {"Smithsonian Astrophysical Observation", "SAO 191145"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.54649562),
        dec: Angle.Degrees(-24.44068003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74367"},
        {"Hipparcos Number", "HIP 42757"},
        {"Smithsonian Astrophysical Observation", "SAO 176344"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.70105891),
        dec: Angle.Degrees(-24.43915154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56639",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8240 A"},
        {"Henry Draper", "HD 100908"},
        {"Hipparcos Number", "HIP 56639"},
        {"Smithsonian Astrophysical Observation", "SAO 180033"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.19043054),
        dec: Angle.Degrees(-24.43910201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187668"},
        {"Hipparcos Number", "HIP 97770"},
        {"Geneva Identification System", "GEN# +1.00187668"},
        {"Smithsonian Astrophysical Observation", "SAO 188646"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.01906909),
        dec: Angle.Degrees(-24.43834117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315033"},
        {"Hipparcos Number", "HIP 88506"},
        {"Geneva Identification System", "GEN# +2.65300059"},
        {"Wilson Evans Batten Catalogue", "WEB 14974"},
        {"New General Catalogue", "NGC 6530 59"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.09677916),
        dec: Angle.Degrees(-24.43797111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39651"},
        {"Hipparcos Number", "HIP 27796"},
        {"Smithsonian Astrophysical Observation", "SAO 170963"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.23433011),
        dec: Angle.Degrees(-24.43758965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5866"},
        {"Hipparcos Number", "HIP 4662"},
        {"Geneva Identification System", "GEN# +1.00005866"},
        {"Smithsonian Astrophysical Observation", "SAO 166731"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.97470261),
        dec: Angle.Degrees(-24.43682018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315260"},
        {"Hipparcos Number", "HIP 89043"},
        {"Smithsonian Astrophysical Observation", "SAO 186399"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.61058064),
        dec: Angle.Degrees(-24.43666965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171496"},
        {"Hipparcos Number", "HIP 91182"},
        {"Geneva Identification System", "GEN# +1.00171496"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.03124657),
        dec: Angle.Degrees(-24.43648209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89886"},
        {"Hipparcos Number", "HIP 50757"},
        {"Geneva Identification System", "GEN# +1.00089886"},
        {"Smithsonian Astrophysical Observation", "SAO 178730"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.46062119),
        dec: Angle.Degrees(-24.43588700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117393"},
        {"Hipparcos Number", "HIP 65885"},
        {"Smithsonian Astrophysical Observation", "SAO 181704"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.58566808),
        dec: Angle.Degrees(-24.43459838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188846"},
        {"Hipparcos Number", "HIP 98261"},
        {"Smithsonian Astrophysical Observation", "SAO 188763"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.49560807),
        dec: Angle.Degrees(-24.43377125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186911"},
        {"Hipparcos Number", "HIP 97424"},
        {"Smithsonian Astrophysical Observation", "SAO 188578"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.01244492),
        dec: Angle.Degrees(-24.42871442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74850",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74850"},
        {"Smithsonian Astrophysical Observation", "SAO 183347"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.43803553),
        dec: Angle.Degrees(-24.42868191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76891"},
        {"Hipparcos Number", "HIP 44051"},
        {"Smithsonian Astrophysical Observation", "SAO 176753"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.56736864),
        dec: Angle.Degrees(-24.42862992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11369"},
        {"Hipparcos Number", "HIP 8620"},
        {"Geneva Identification System", "GEN# +1.00011369"},
        {"Smithsonian Astrophysical Observation", "SAO 167351"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.79778212),
        dec: Angle.Degrees(-24.42839609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106181",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15023 AB"},
        {"Henry Draper", "HD 204608"},
        {"Hipparcos Number", "HIP 106181"},
        {"Smithsonian Astrophysical Observation", "SAO 190393"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.59810512),
        dec: Angle.Degrees(-24.42743648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58512"},
        {"Hipparcos Number", "HIP 35988"},
        {"Celescope Catalog", "CEL 1836"},
        {"Geneva Identification System", "GEN# +1.00058512"},
        {"Smithsonian Astrophysical Observation", "SAO 173681"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.24606531),
        dec: Angle.Degrees(-24.42634928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23950",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23950"},
        {"Smithsonian Astrophysical Observation", "SAO 170116"},
    },
    visualMagnitude: 9.28,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.21204806),
        dec: Angle.Degrees(-24.42475700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5976"},
        {"Hipparcos Number", "HIP 4739"},
        {"Geneva Identification System", "GEN# +1.00005976"},
        {"Smithsonian Astrophysical Observation", "SAO 166746"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.21733793),
        dec: Angle.Degrees(-24.42391700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203652"},
        {"Hipparcos Number", "HIP 105683"},
        {"Geneva Identification System", "GEN# +1.00203652"},
        {"Smithsonian Astrophysical Observation", "SAO 190299"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.08642851),
        dec: Angle.Degrees(-24.42243730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9967 AB"},
        {"Henry Draper", "HD 145792"},
        {"Hipparcos Number", "HIP 79530"},
        {"Geneva Identification System", "GEN# +1.00145792"},
        {"Renson", "Renson 41280"},
        {"Smithsonian Astrophysical Observation", "SAO 184241"},
        {"Wilson Evans Batten Catalogue", "WEB 13461"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.43960040),
        dec: Angle.Degrees(-24.42204574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12369"},
        {"Hipparcos Number", "HIP 9392"},
        {"Geneva Identification System", "GEN# +1.00012369"},
        {"Smithsonian Astrophysical Observation", "SAO 167481"},
        {"Wilson Evans Batten Catalogue", "WEB 1972"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.17645219),
        dec: Angle.Degrees(-24.42159584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126832"},
        {"Hipparcos Number", "HIP 70777"},
        {"Smithsonian Astrophysical Observation", "SAO 182575"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.12411699),
        dec: Angle.Degrees(-24.42084428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63719",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63719"},
        {"Geneva Identification System", "GEN# -0.02310879"},
        {"Smithsonian Astrophysical Observation", "SAO 181351"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.86468647),
        dec: Angle.Degrees(-24.41996637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3180"},
        {"Hipparcos Number", "HIP 2737"},
        {"Geneva Identification System", "GEN# +1.00003180"},
        {"Smithsonian Astrophysical Observation", "SAO 166377"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.74491029),
        dec: Angle.Degrees(-24.41911310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 182.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35539",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5998 AB"},
        {"Henry Draper", "HD 57372"},
        {"Hipparcos Number", "HIP 35539"},
        {"Renson", "Renson 15680"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.01129596),
        dec: Angle.Degrees(-24.41598478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17152"},
        {"Hipparcos Number", "HIP 12797"},
        {"Geneva Identification System", "GEN# +1.00017152"},
        {"Smithsonian Astrophysical Observation", "SAO 168014"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.12074309),
        dec: Angle.Degrees(-24.41502518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -257.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62295",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62295"},
    },
    visualMagnitude: 10.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45, 54.9200),
        dec: Angle.DegreesMinutesSeconds((int)-24, (int)24, 53.200)
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
    primaryId: "HIP 90266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169292"},
        {"Hipparcos Number", "HIP 90266"},
        {"Geneva Identification System", "GEN# +1.00169292"},
        {"Smithsonian Astrophysical Observation", "SAO 186787"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.27017289),
        dec: Angle.Degrees(-24.41441729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121631"},
        {"Hipparcos Number", "HIP 68143"},
        {"Smithsonian Astrophysical Observation", "SAO 182112"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.27270684),
        dec: Angle.Degrees(-24.41391640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62292",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62292"},
        {"Smithsonian Astrophysical Observation", "SAO 181088"},
    },
    visualMagnitude: 10.89,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)45, 54.1000),
        dec: Angle.DegreesMinutesSeconds((int)-24, (int)24, 47.700)
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
    primaryId: "HIP 95486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182391"},
        {"Hipparcos Number", "HIP 95486"},
        {"Smithsonian Astrophysical Observation", "SAO 188102"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.34308566),
        dec: Angle.Degrees(-24.41209452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54962"},
        {"Hipparcos Number", "HIP 34599"},
        {"Renson", "Renson 15010"},
        {"Smithsonian Astrophysical Observation", "SAO 173110"},
    },
    visualMagnitude: 9.33,
    bvColour: -0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.49332460),
        dec: Angle.Degrees(-24.40978124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38055"},
        {"Hipparcos Number", "HIP 26840"},
        {"Smithsonian Astrophysical Observation", "SAO 170706"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.48860561),
        dec: Angle.Degrees(-24.40433910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150345"},
        {"Hipparcos Number", "HIP 81713"},
        {"Smithsonian Astrophysical Observation", "SAO 184545"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.36076082),
        dec: Angle.Degrees(-24.40231970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26404",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4227 AB"},
        {"Henry Draper", "HD 37391"},
        {"Hipparcos Number", "HIP 26404"},
        {"Smithsonian Astrophysical Observation", "SAO 170600"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.30682808),
        dec: Angle.Degrees(-24.40210332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201385"},
        {"Hipparcos Number", "HIP 104476"},
        {"Geneva Identification System", "GEN# +1.00201385"},
        {"Smithsonian Astrophysical Observation", "SAO 190074"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.46486595),
        dec: Angle.Degrees(-24.40074016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10663"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.30603512),
        dec: Angle.Degrees(-24.39887183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139843"},
        {"Hipparcos Number", "HIP 76834"},
        {"Geneva Identification System", "GEN# +1.00139843"},
        {"Smithsonian Astrophysical Observation", "SAO 183700"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.31560884),
        dec: Angle.Degrees(-24.39873659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165052"},
        {"Hipparcos Number", "HIP 88581"},
        {"Celescope Catalog", "CEL 4614"},
        {"Geneva Identification System", "GEN# +2.65300118"},
        {"Smithsonian Astrophysical Observation", "SAO 186247"},
        {"Wilson Evans Batten Catalogue", "WEB 15001"},
        {"New General Catalogue", "NGC 6530 118"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.29395598),
        dec: Angle.Degrees(-24.39856335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93264",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176164"},
        {"Hipparcos Number", "HIP 93264"},
        {"Smithsonian Astrophysical Observation", "SAO 187551"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.97419711),
        dec: Angle.Degrees(-24.39845884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50154"},
        {"Hipparcos Number", "HIP 32867"},
        {"Celescope Catalog", "CEL 1408"},
        {"Geneva Identification System", "GEN# +1.00050154"},
        {"Smithsonian Astrophysical Observation", "SAO 172430"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.74205027),
        dec: Angle.Degrees(-24.39827929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153082"},
        {"Hipparcos Number", "HIP 83061"},
        {"Smithsonian Astrophysical Observation", "SAO 184853"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.58594327),
        dec: Angle.Degrees(-24.39792634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140419"},
        {"Hipparcos Number", "HIP 77077"},
        {"Geneva Identification System", "GEN# +1.00140419"},
        {"Renson", "Renson 39913"},
        {"Smithsonian Astrophysical Observation", "SAO 183745"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.07369712),
        dec: Angle.Degrees(-24.39540342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76378"},
        {"Hipparcos Number", "HIP 43771"},
        {"Geneva Identification System", "GEN# +1.00076378"},
        {"Smithsonian Astrophysical Observation", "SAO 176685"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.73942174),
        dec: Angle.Degrees(-24.39464323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -341.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 145.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75178"},
        {"Hipparcos Number", "HIP 43173"},
        {"Smithsonian Astrophysical Observation", "SAO 176478"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.90913681),
        dec: Angle.Degrees(-24.39367831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209967"},
        {"Hipparcos Number", "HIP 109222"},
        {"Smithsonian Astrophysical Observation", "SAO 190900"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.90622172),
        dec: Angle.Degrees(-24.39350733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90795"},
        {"Hipparcos Number", "HIP 51293"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.15479167),
        dec: Angle.Degrees(-24.39196756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108109"},
        {"Hipparcos Number", "HIP 60600"},
        {"Smithsonian Astrophysical Observation", "SAO 180785"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.32328160),
        dec: Angle.Degrees(-24.39136762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23686"},
        {"Hipparcos Number", "HIP 17600"},
        {"Smithsonian Astrophysical Observation", "SAO 168815"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.55481645),
        dec: Angle.Degrees(-24.39103073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 315032"},
        {"Hipparcos Number", "HIP 88496"},
        {"Geneva Identification System", "GEN# +2.65300042"},
        {"Wilson Evans Batten Catalogue", "WEB 14970"},
        {"New General Catalogue", "NGC 6530 42"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.06260839),
        dec: Angle.Degrees(-24.39102635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167978"},
        {"Hipparcos Number", "HIP 89727"},
        {"Smithsonian Astrophysical Observation", "SAO 186630"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.66877161),
        dec: Angle.Degrees(-24.39002413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120690"},
        {"Hipparcos Number", "HIP 67620"},
        {"Cincinnati Publication", "Ci 20 816"},
        {"Geneva Identification System", "GEN# +1.00120690"},
        {"Smithsonian Astrophysical Observation", "SAO 182026"},
        {"Wilson Evans Batten Catalogue", "WEB 11890"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.83625055),
        dec: Angle.Degrees(-24.38977243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -580.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -244.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23554",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32667"},
        {"Hipparcos Number", "HIP 23554"},
        {"Geneva Identification System", "GEN# +1.00032667"},
        {"Renson", "Renson 8370"},
        {"Smithsonian Astrophysical Observation", "SAO 170029"},
        {"Wilson Evans Batten Catalogue", "WEB 4590"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.97189741),
        dec: Angle.Degrees(-24.38805735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101696"},
        {"Hipparcos Number", "HIP 57072"},
        {"Geneva Identification System", "GEN# +1.00101696"},
        {"Renson", "Renson 29295"},
        {"Smithsonian Astrophysical Observation", "SAO 180116"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.49153487),
        dec: Angle.Degrees(-24.38572852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85388",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10549 AB"},
        {"Henry Draper", "HD 157863"},
        {"Hipparcos Number", "HIP 85388"},
        {"Smithsonian Astrophysical Observation", "SAO 185405"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.752,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.71436903),
        dec: Angle.Degrees(-24.38508465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48240"},
        {"Hipparcos Number", "HIP 32031"},
        {"Smithsonian Astrophysical Observation", "SAO 172169"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.36452191),
        dec: Angle.Degrees(-24.38306507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147384"},
        {"Hipparcos Number", "HIP 80224"},
        {"Geneva Identification System", "GEN# +1.00147384"},
        {"Smithsonian Astrophysical Observation", "SAO 184347"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.65304850),
        dec: Angle.Degrees(-24.38290142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224193"},
        {"Hipparcos Number", "HIP 117985"},
        {"Smithsonian Astrophysical Observation", "SAO 192246"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.97563348),
        dec: Angle.Degrees(-24.38066033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215146"},
        {"Hipparcos Number", "HIP 112200"},
        {"Smithsonian Astrophysical Observation", "SAO 191353"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.86609180),
        dec: Angle.Degrees(-24.38055359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54148"},
        {"Hipparcos Number", "HIP 34314"},
        {"Smithsonian Astrophysical Observation", "SAO 172983"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.71204596),
        dec: Angle.Degrees(-24.38026971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185969"},
        {"Hipparcos Number", "HIP 96967"},
        {"Geneva Identification System", "GEN# +1.00185969"},
        {"Smithsonian Astrophysical Observation", "SAO 188473"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.65469451),
        dec: Angle.Degrees(-24.37939444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1652 C"},
        {"Henry Draper", "HD 12873"},
        {"Hipparcos Number", "HIP 9769"},
        {"Cincinnati Publication", "Ci 20 144"},
        {"Geneva Identification System", "GEN# +1.00012873"},
        {"Smithsonian Astrophysical Observation", "SAO 167543"},
        {"Wilson Evans Batten Catalogue", "WEB 2054"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.40506005),
        dec: Angle.Degrees(-24.37934951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 412.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135066"},
        {"Hipparcos Number", "HIP 74540"},
        {"Geneva Identification System", "GEN# +1.00135066"},
        {"Smithsonian Astrophysical Observation", "SAO 183286"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.47482050),
        dec: Angle.Degrees(-24.37873839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155722"},
        {"Hipparcos Number", "HIP 84319"},
        {"Smithsonian Astrophysical Observation", "SAO 185180"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.56959310),
        dec: Angle.Degrees(-24.37694347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119233"},
        {"Hipparcos Number", "HIP 66884"},
        {"Geneva Identification System", "GEN# +1.00119233"},
        {"Smithsonian Astrophysical Observation", "SAO 181882"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.60355215),
        dec: Angle.Degrees(-24.37600159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1652 AB"},
        {"Henry Draper", "HD 12889"},
        {"Hipparcos Number", "HIP 9774"},
        {"Cincinnati Publication", "Ci 20 145"},
        {"Geneva Identification System", "GEN# +1.00012889"},
        {"Smithsonian Astrophysical Observation", "SAO 167545"},
        {"Wilson Evans Batten Catalogue", "WEB 2055"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.42185328),
        dec: Angle.Degrees(-24.37590050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 420.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184532"},
        {"Hipparcos Number", "HIP 96394"},
        {"Smithsonian Astrophysical Observation", "SAO 188323"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.98067418),
        dec: Angle.Degrees(-24.37504192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196080"},
        {"Hipparcos Number", "HIP 101624"},
        {"Smithsonian Astrophysical Observation", "SAO 189469"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.95415744),
        dec: Angle.Degrees(-24.37343534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196374"},
        {"Hipparcos Number", "HIP 101781"},
        {"Smithsonian Astrophysical Observation", "SAO 189498"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.41854336),
        dec: Angle.Degrees(-24.37279855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35853"},
        {"Hipparcos Number", "HIP 25458"},
        {"Smithsonian Astrophysical Observation", "SAO 170429"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.67266367),
        dec: Angle.Degrees(-24.37102513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22491",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mouhoun"},
        {"Henry Draper", "HD 30856"},
        {"Hipparcos Number", "HIP 22491"},
        {"Geneva Identification System", "GEN# +1.00030856"},
        {"Smithsonian Astrophysical Observation", "SAO 169805"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.57437448),
        dec: Angle.Degrees(-24.36879540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46502"},
        {"Hipparcos Number", "HIP 31210"},
        {"Smithsonian Astrophysical Observation", "SAO 171924"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.20689948),
        dec: Angle.Degrees(-24.36864045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31045"},
        {"Hipparcos Number", "HIP 22594"},
        {"Smithsonian Astrophysical Observation", "SAO 169823"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.92521762),
        dec: Angle.Degrees(-24.36749218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6396",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6396"},
        {"Smithsonian Astrophysical Observation", "SAO 166995"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.54083947),
        dec: Angle.Degrees(-24.36609912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13251"},
        {"Hipparcos Number", "HIP 10020"},
        {"Smithsonian Astrophysical Observation", "SAO 167588"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.25736484),
        dec: Angle.Degrees(-24.36467402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176752"},
        {"Hipparcos Number", "HIP 93516"},
        {"Smithsonian Astrophysical Observation", "SAO 187602"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.67820565),
        dec: Angle.Degrees(-24.36455073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66884"},
        {"Hipparcos Number", "HIP 39520"},
        {"Geneva Identification System", "GEN# +1.00066884"},
        {"Smithsonian Astrophysical Observation", "SAO 175116"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.299,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.16027046),
        dec: Angle.Degrees(-24.36386577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124162"},
        {"Hipparcos Number", "HIP 69398"},
        {"Geneva Identification System", "GEN# +1.00124162"},
        {"Smithsonian Astrophysical Observation", "SAO 182343"},
    },
    visualMagnitude: 6.35,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.10230839),
        dec: Angle.Degrees(-24.36333964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147343"},
        {"Hipparcos Number", "HIP 80196"},
        {"Geneva Identification System", "GEN# +1.00147343"},
        {"Smithsonian Astrophysical Observation", "SAO 184345"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.58296964),
        dec: Angle.Degrees(-24.36332748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83926",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83926"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.31338796),
        dec: Angle.Degrees(-24.36119571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164794"},
        {"Hipparcos Number", "HIP 88469"},
        {"Celescope Catalog", "CEL 4606"},
        {"Geneva Identification System", "GEN# +2.65300007"},
        {"Smithsonian Astrophysical Observation", "SAO 186204"},
        {"Wilson Evans Batten Catalogue", "WEB 14962"},
        {"New General Catalogue", "NGC 6530 7"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.96851862),
        dec: Angle.Degrees(-24.36072589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172547"},
        {"Hipparcos Number", "HIP 91686"},
        {"Geneva Identification System", "GEN# +1.00172547"},
        {"Smithsonian Astrophysical Observation", "SAO 187145"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.45955594),
        dec: Angle.Degrees(-24.35416781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190079"},
        {"Hipparcos Number", "HIP 98812"},
        {"Smithsonian Astrophysical Observation", "SAO 188868"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.01025892),
        dec: Angle.Degrees(-24.35310077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6507",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1113 AB"},
        {"Henry Draper", "HD 8487"},
        {"Hipparcos Number", "HIP 6507"},
        {"Geneva Identification System", "GEN# +1.00008487J"},
        {"Smithsonian Astrophysical Observation", "SAO 167011"},
        {"Wilson Evans Batten Catalogue", "WEB 1435"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.89560160),
        dec: Angle.Degrees(-24.35277479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119904"},
        {"Hipparcos Number", "HIP 67228"},
        {"Smithsonian Astrophysical Observation", "SAO 181945"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.64364658),
        dec: Angle.Degrees(-24.35245987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56694"},
        {"Hipparcos Number", "HIP 35267"},
        {"Celescope Catalog", "CEL 1740"},
        {"Geneva Identification System", "GEN# +1.00056694"},
        {"Smithsonian Astrophysical Observation", "SAO 173378"},
    },
    visualMagnitude: 7.85,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.29280252),
        dec: Angle.Degrees(-24.35209497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218048"},
        {"Hipparcos Number", "HIP 114002"},
        {"Smithsonian Astrophysical Observation", "SAO 191635"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.31435305),
        dec: Angle.Degrees(-24.34987329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14178"},
        {"Hipparcos Number", "HIP 10651"},
        {"Smithsonian Astrophysical Observation", "SAO 167678"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.27057728),
        dec: Angle.Degrees(-24.34962800)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33709"},
        {"Hipparcos Number", "HIP 24148"},
        {"Geneva Identification System", "GEN# +1.00033709"},
        {"Smithsonian Astrophysical Observation", "SAO 170161"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.79322281),
        dec: Angle.Degrees(-24.34926108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127746"},
        {"Hipparcos Number", "HIP 71212"},
        {"Smithsonian Astrophysical Observation", "SAO 182661"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.44701643),
        dec: Angle.Degrees(-24.34644902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1248",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 201 AB"},
        {"Henry Draper", "HD 1136"},
        {"Hipparcos Number", "HIP 1248"},
        {"Geneva Identification System", "GEN# +1.00001136"},
        {"Smithsonian Astrophysical Observation", "SAO 166151"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.89260477),
        dec: Angle.Degrees(-24.34634539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55040"},
        {"Hipparcos Number", "HIP 34637"},
        {"Celescope Catalog", "CEL 1640"},
        {"Geneva Identification System", "GEN# +1.00055040"},
        {"Smithsonian Astrophysical Observation", "SAO 173125"},
    },
    visualMagnitude: 8.55,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.61058562),
        dec: Angle.Degrees(-24.34626904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13305"},
        {"Hipparcos Number", "HIP 10069"},
        {"Fundamental Katalog 5th Edition", "FK5 2147"},
        {"Geneva Identification System", "GEN# +1.00013305"},
        {"Smithsonian Astrophysical Observation", "SAO 167599"},
    },
    visualMagnitude: 6.48,
    bvColour: 0.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.39508853),
        dec: Angle.Degrees(-24.34568294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13557"},
        {"Hipparcos Number", "HIP 10247"},
        {"Smithsonian Astrophysical Observation", "SAO 167622"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.95327362),
        dec: Angle.Degrees(-24.34521088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46712",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82432"},
        {"Hipparcos Number", "HIP 46712"},
        {"Smithsonian Astrophysical Observation", "SAO 177599"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.83365721),
        dec: Angle.Degrees(-24.34370197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98346"},
        {"Hipparcos Number", "HIP 55228"},
        {"Smithsonian Astrophysical Observation", "SAO 179760"},
    },
    visualMagnitude: 6.69,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.65226214),
        dec: Angle.Degrees(-24.34330234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9051"},
        {"Hipparcos Number", "HIP 6894"},
        {"Geneva Identification System", "GEN# +1.00009051"},
        {"Smithsonian Astrophysical Observation", "SAO 167076"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.19361761),
        dec: Angle.Degrees(-24.34035906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36964"},
        {"Hipparcos Number", "HIP 26127"},
        {"Renson", "Renson 9784"},
        {"Smithsonian Astrophysical Observation", "SAO 170569"},
    },
    visualMagnitude: 9.62,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.57056940),
        dec: Angle.Degrees(-24.33884143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16610"},
        {"Hipparcos Number", "HIP 12360"},
        {"Geneva Identification System", "GEN# +1.00016610"},
        {"Smithsonian Astrophysical Observation", "SAO 167948"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.77779685),
        dec: Angle.Degrees(-24.33863233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26060",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4157 A"},
        {"Henry Draper", "HD 36846"},
        {"Henry Draper 2", "HD 36846A"},
        {"Hipparcos Number", "HIP 26060"},
        {"Smithsonian Astrophysical Observation", "SAO 170549"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.37649299),
        dec: Angle.Degrees(-24.33749229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -174.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188639"},
        {"Hipparcos Number", "HIP 98172"},
        {"Geneva Identification System", "GEN# +1.00188639"},
        {"Smithsonian Astrophysical Observation", "SAO 188744"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.25842379),
        dec: Angle.Degrees(-24.33697145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76313"},
    },
    visualMagnitude: 11.44,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.82018131),
        dec: Angle.Degrees(-24.33675737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158213"},
        {"Hipparcos Number", "HIP 85548"},
        {"Smithsonian Astrophysical Observation", "SAO 185442"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.25084702),
        dec: Angle.Degrees(-24.33642708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38655",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38655"},
        {"Geneva Identification System", "GEN# +2.24820008"},
        {"New General Catalogue", "NGC 2482 8"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.72254060),
        dec: Angle.Degrees(-24.33632101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86540"},
        {"Hipparcos Number", "HIP 48906"},
        {"Geneva Identification System", "GEN# +1.00086540"},
        {"Smithsonian Astrophysical Observation", "SAO 178259"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.64413887),
        dec: Angle.Degrees(-24.33619922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142667"},
        {"Hipparcos Number", "HIP 78083"},
        {"Smithsonian Astrophysical Observation", "SAO 183953"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.15654779),
        dec: Angle.Degrees(-24.33602327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 734",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 734"},
        {"Smithsonian Astrophysical Observation", "SAO 166080"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26186026),
        dec: Angle.Degrees(-24.33505454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90027"},
        {"Hipparcos Number", "HIP 50849"},
        {"Geneva Identification System", "GEN# +1.00090027"},
        {"Smithsonian Astrophysical Observation", "SAO 178755"},
    },
    visualMagnitude: 6.83,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.74688246),
        dec: Angle.Degrees(-24.33361782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53276",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7970 AB"},
        {"Henry Draper", "HD 94429"},
        {"Hipparcos Number", "HIP 53276"},
        {"Smithsonian Astrophysical Observation", "SAO 179314"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.44472377),
        dec: Angle.Degrees(-24.33213489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78510",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9882 AB"},
        {"Henry Draper", "HD 143518"},
        {"Hipparcos Number", "HIP 78510"},
        {"Smithsonian Astrophysical Observation", "SAO 184038"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.41893768),
        dec: Angle.Degrees(-24.32520195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158940"},
        {"Hipparcos Number", "HIP 85877"},
        {"Geneva Identification System", "GEN# +1.00158940"},
        {"Smithsonian Astrophysical Observation", "SAO 185494"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.25152983),
        dec: Angle.Degrees(-24.32292229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103957",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14584 AB"},
        {"Henry Draper", "HD 200379"},
        {"Hipparcos Number", "HIP 103957"},
        {"Smithsonian Astrophysical Observation", "SAO 189975"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.95099806),
        dec: Angle.Degrees(-24.32235446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76812"},
        {"Smithsonian Astrophysical Observation", "SAO 183699"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.24985100),
        dec: Angle.Degrees(-24.32217455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92206",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173678"},
        {"Hipparcos Number", "HIP 92206"},
        {"Smithsonian Astrophysical Observation", "SAO 187284"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.88040493),
        dec: Angle.Degrees(-24.31993939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51036"},
        {"Hipparcos Number", "HIP 33215"},
        {"Celescope Catalog", "CEL 1433"},
        {"Geneva Identification System", "GEN# +5.11210010"},
        {"Smithsonian Astrophysical Observation", "SAO 172562"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.68600784),
        dec: Angle.Degrees(-24.31605276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53342"},
        {"Hipparcos Number", "HIP 34044"},
        {"Celescope Catalog", "CEL 1544"},
        {"Geneva Identification System", "GEN# +1.00053342"},
        {"Smithsonian Astrophysical Observation", "SAO 172873"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.93715795),
        dec: Angle.Degrees(-24.31086198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54862"},
        {"Hipparcos Number", "HIP 34564"},
        {"Smithsonian Astrophysical Observation", "SAO 173091"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.39264698),
        dec: Angle.Degrees(-24.30786749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22356"},
        {"Hipparcos Number", "HIP 16717"},
        {"Smithsonian Astrophysical Observation", "SAO 168651"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.76565424),
        dec: Angle.Degrees(-24.30739372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77456",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77456"},
    },
    visualMagnitude: 12.41,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.21229350),
        dec: Angle.Degrees(-24.30685133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101273"},
        {"Hipparcos Number", "HIP 56834"},
        {"Smithsonian Astrophysical Observation", "SAO 180066"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.76440744),
        dec: Angle.Degrees(-24.30567881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39757",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tureis"},
        {"Henry Draper", "HD 67523"},
        {"Hipparcos Number", "HIP 39757"},
        {"Fundamental Katalog 5th Edition", "FK5 308"},
        {"Geneva Identification System", "GEN# +1.00067523"},
        {"Renson", "Renson 18660"},
        {"Smithsonian Astrophysical Observation", "SAO 175217"},
        {"Wilson Evans Batten Catalogue", "WEB 7758"},
    },
    visualMagnitude: 2.83,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.88625899),
        dec: Angle.Degrees(-24.30443677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75242",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75242"},
        {"Smithsonian Astrophysical Observation", "SAO 183412"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.62194533),
        dec: Angle.Degrees(-24.30367921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18361"},
        {"Hipparcos Number", "HIP 13696"},
        {"Smithsonian Astrophysical Observation", "SAO 168161"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.09533532),
        dec: Angle.Degrees(-24.30346968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130992"},
        {"Hipparcos Number", "HIP 72688"},
        {"Cincinnati Publication", "Ci 20 889"},
        {"Geneva Identification System", "GEN# +1.00130992"},
        {"Smithsonian Astrophysical Observation", "SAO 182935"},
        {"Wilson Evans Batten Catalogue", "WEB 12497"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.92112320),
        dec: Angle.Degrees(-24.30308356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -943.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -431.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91606"},
        {"Hipparcos Number", "HIP 51733"},
        {"Geneva Identification System", "GEN# +1.00091606"},
        {"Smithsonian Astrophysical Observation", "SAO 178983"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.55542057),
        dec: Angle.Degrees(-24.30212979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73379"},
        {"Hipparcos Number", "HIP 42289"},
        {"Smithsonian Astrophysical Observation", "SAO 176179"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.33238429),
        dec: Angle.Degrees(-24.30199211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30023"},
        {"Hipparcos Number", "HIP 21940"},
        {"Geneva Identification System", "GEN# +1.00030023"},
        {"Smithsonian Astrophysical Observation", "SAO 169689"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.74491855),
        dec: Angle.Degrees(-24.30135917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21174"},
        {"Hipparcos Number", "HIP 15859"},
        {"Smithsonian Astrophysical Observation", "SAO 168518"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.06747973),
        dec: Angle.Degrees(-24.30073340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43687",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43687"},
        {"Smithsonian Astrophysical Observation", "SAO 176658"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.48523311),
        dec: Angle.Degrees(-24.30068689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44427"},
        {"Hipparcos Number", "HIP 30159"},
        {"Smithsonian Astrophysical Observation", "SAO 171607"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.19520467),
        dec: Angle.Degrees(-24.30016179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75934",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75934"},
        {"Smithsonian Astrophysical Observation", "SAO 183530"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.64368475),
        dec: Angle.Degrees(-24.29945927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8107",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10709"},
        {"Hipparcos Number", "HIP 8107"},
        {"Smithsonian Astrophysical Observation", "SAO 167262"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.05005510),
        dec: Angle.Degrees(-24.29941631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61160"},
        {"Hipparcos Number", "HIP 37058"},
        {"Smithsonian Astrophysical Observation", "SAO 174125"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.23849263),
        dec: Angle.Degrees(-24.29695481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20199"},
        {"Hipparcos Number", "HIP 15051"},
        {"Smithsonian Astrophysical Observation", "SAO 168399"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.49167618),
        dec: Angle.Degrees(-24.29604927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29773",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29773"},
    },
    visualMagnitude: 11.66,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.03552697),
        dec: Angle.Degrees(-24.29574880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -189.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223118"},
        {"Hipparcos Number", "HIP 117277"},
        {"Geneva Identification System", "GEN# +1.00223118"},
        {"Smithsonian Astrophysical Observation", "SAO 192145"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.71583460),
        dec: Angle.Degrees(-24.29362782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116858"},
        {"Hipparcos Number", "HIP 65574"},
        {"Geneva Identification System", "GEN# +1.00116858A"},
        {"Smithsonian Astrophysical Observation", "SAO 181657"},
        {"Wilson Evans Batten Catalogue", "WEB 11589"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.66571598),
        dec: Angle.Degrees(-24.29319925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -335.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6670 AB"},
        {"Henry Draper", "HD 68821"},
        {"Hipparcos Number", "HIP 40252"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.31850581),
        dec: Angle.Degrees(-24.29255191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20351",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27724"},
        {"Hipparcos Number", "HIP 20351"},
        {"Smithsonian Astrophysical Observation", "SAO 169367"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.38436086),
        dec: Angle.Degrees(-24.29199246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3020"},
        {"Hipparcos Number", "HIP 2622"},
        {"Geneva Identification System", "GEN# +1.00003020"},
        {"Smithsonian Astrophysical Observation", "SAO 166359"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.32019716),
        dec: Angle.Degrees(-24.29148908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160730"},
        {"Hipparcos Number", "HIP 86673"},
        {"Geneva Identification System", "GEN# +1.00160730"},
        {"Smithsonian Astrophysical Observation", "SAO 185641"},
        {"Wilson Evans Batten Catalogue", "WEB 14613"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.62701848),
        dec: Angle.Degrees(-24.29089038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149149"},
        {"Hipparcos Number", "HIP 81097"},
        {"Smithsonian Astrophysical Observation", "SAO 184460"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.46280097),
        dec: Angle.Degrees(-24.29047237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116920"},
        {"Hipparcos Number", "HIP 65602"},
        {"Geneva Identification System", "GEN# +1.00116920"},
        {"Smithsonian Astrophysical Observation", "SAO 181663"},
        {"Wilson Evans Batten Catalogue", "WEB 11601"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.76299862),
        dec: Angle.Degrees(-24.29029460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -337.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117036",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117036"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.88345066),
        dec: Angle.Degrees(-24.28726516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -221.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34343"},
        {"Hipparcos Number", "HIP 24530"},
        {"Geneva Identification System", "GEN# +1.00034343"},
        {"Smithsonian Astrophysical Observation", "SAO 170247"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.93885616),
        dec: Angle.Degrees(-24.28719316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84626",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10442 A"},
        {"Henry Draper", "HD 156349"},
        {"Hipparcos Number", "HIP 84626"},
        {"Geneva Identification System", "GEN# +1.00156349A"},
        {"Smithsonian Astrophysical Observation", "SAO 185238"},
        {"Wilson Evans Batten Catalogue", "WEB 14289"},
    },
    visualMagnitude: 5.14,
    bvColour: 1.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.50298647),
        dec: Angle.Degrees(-24.28688289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2069"},
        {"Hipparcos Number", "HIP 1958"},
        {"Geneva Identification System", "GEN# +1.00002069"},
        {"Smithsonian Astrophysical Observation", "SAO 166248"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.19137776),
        dec: Angle.Degrees(-24.28598703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87427"},
        {"Hipparcos Number", "HIP 49339"},
        {"Fundamental Katalog 5th Edition", "FK5 1260"},
        {"Geneva Identification System", "GEN# +1.00087427"},
        {"Smithsonian Astrophysical Observation", "SAO 178367"},
        {"Wilson Evans Batten Catalogue", "WEB 9124"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.08756962),
        dec: Angle.Degrees(-24.28559599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8831 AB"},
        {"Henry Draper", "HD 114993"},
        {"Hipparcos Number", "HIP 64603"},
        {"Geneva Identification System", "GEN# +1.00114993"},
        {"Renson", "Renson 33270"},
        {"Smithsonian Astrophysical Observation", "SAO 181476"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.61491384),
        dec: Angle.Degrees(-24.28427154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164031"},
        {"Hipparcos Number", "HIP 88142"},
        {"Smithsonian Astrophysical Observation", "SAO 186074"},
        {"Wilson Evans Batten Catalogue", "WEB 14890"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.04803588),
        dec: Angle.Degrees(-24.28418385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84625",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10442 B"},
        {"Henry Draper", "HD 156350"},
        {"Hipparcos Number", "HIP 84625"},
        {"Geneva Identification System", "GEN# +1.00156350"},
        {"Smithsonian Astrophysical Observation", "SAO 185237"},
        {"Wilson Evans Batten Catalogue", "WEB 14290"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.50267465),
        dec: Angle.Degrees(-24.28408423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164584"},
        {"Hipparcos Number", "HIP 88380"},
        {"Geneva Identification System", "GEN# +2.65300004"},
        {"Renson", "Renson 46510"},
        {"Smithsonian Astrophysical Observation", "SAO 186163"},
        {"Wilson Evans Batten Catalogue", "WEB 14939"},
        {"New General Catalogue", "NGC 6530 4"},
    },
    visualMagnitude: 5.37,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.71290783),
        dec: Angle.Degrees(-24.28242475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146284"},
        {"Hipparcos Number", "HIP 79740"},
        {"Geneva Identification System", "GEN# +1.00146284J"},
        {"Smithsonian Astrophysical Observation", "SAO 184278"},
        {"Wilson Evans Batten Catalogue", "WEB 13492"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.11126539),
        dec: Angle.Degrees(-24.28194415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38703"},
        {"Geneva Identification System", "GEN# +2.24820036"},
        {"New General Catalogue", "NGC 2482 36"},
    },
    visualMagnitude: 11.39,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.85400350),
        dec: Angle.Degrees(-24.28073927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166853"},
        {"Hipparcos Number", "HIP 89328"},
        {"Smithsonian Astrophysical Observation", "SAO 186491"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.886,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.39975637),
        dec: Angle.Degrees(-24.28057730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131698"},
        {"Hipparcos Number", "HIP 73059"},
        {"Smithsonian Astrophysical Observation", "SAO 183005"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.95319021),
        dec: Angle.Degrees(-24.28056195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198867"},
        {"Hipparcos Number", "HIP 103158"},
        {"Geneva Identification System", "GEN# +1.00198867"},
        {"Smithsonian Astrophysical Observation", "SAO 189814"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.50452069),
        dec: Angle.Degrees(-24.28049863)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82234"},
        {"Hipparcos Number", "HIP 46609"},
        {"Smithsonian Astrophysical Observation", "SAO 177561"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.55883189),
        dec: Angle.Degrees(-24.27411862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6353"},
        {"Hipparcos Number", "HIP 5020"},
        {"Geneva Identification System", "GEN# +1.00006353"},
        {"Smithsonian Astrophysical Observation", "SAO 166777"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.07911503),
        dec: Angle.Degrees(-24.27397838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108255"},
        {"Hipparcos Number", "HIP 60691"},
        {"Geneva Identification System", "GEN# +1.00108255"},
        {"Smithsonian Astrophysical Observation", "SAO 180797"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.58100293),
        dec: Angle.Degrees(-24.27210820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5961"},
        {"Hipparcos Number", "HIP 4730"},
        {"Geneva Identification System", "GEN# +1.00005961"},
        {"Smithsonian Astrophysical Observation", "SAO 166744"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.18460522),
        dec: Angle.Degrees(-24.27151254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70886"},
        {"Hipparcos Number", "HIP 41139"},
        {"Smithsonian Astrophysical Observation", "SAO 175732"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.90660643),
        dec: Angle.Degrees(-24.27097693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75012",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9586 AB"},
        {"Henry Draper", "HD 136121"},
        {"Hipparcos Number", "HIP 75012"},
        {"Smithsonian Astrophysical Observation", "SAO 183377"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.91834508),
        dec: Angle.Degrees(-24.26992490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 314773"},
        {"Henry Draper 2", "HD 314774"},
        {"Hipparcos Number", "HIP 87940"},
        {"Smithsonian Astrophysical Observation", "SAO 186004"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.47461728),
        dec: Angle.Degrees(-24.26894810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100068",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100068"},
        {"Smithsonian Astrophysical Observation", "SAO 189117"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.52827096),
        dec: Angle.Degrees(-24.26881689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143440"},
        {"Hipparcos Number", "HIP 78471"},
        {"Smithsonian Astrophysical Observation", "SAO 184027"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.28364569),
        dec: Angle.Degrees(-24.26660080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51263",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51263"},
        {"Geneva Identification System", "GEN# -0.02309305"},
        {"Smithsonian Astrophysical Observation", "SAO 178854"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.07207856),
        dec: Angle.Degrees(-24.26580792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 95.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140167"},
        {"Hipparcos Number", "HIP 76969"},
        {"Smithsonian Astrophysical Observation", "SAO 183725"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.74796213),
        dec: Angle.Degrees(-24.26523515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118893"},
        {"Hipparcos Number", "HIP 66685"},
        {"Geneva Identification System", "GEN# +1.00118893"},
        {"Smithsonian Astrophysical Observation", "SAO 181846"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.04928623),
        dec: Angle.Degrees(-24.26403474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52302",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52302"},
        {"Smithsonian Astrophysical Observation", "SAO 179115"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.29450577),
        dec: Angle.Degrees(-24.26287398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68330",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121971"},
        {"Hipparcos Number", "HIP 68330"},
        {"Smithsonian Astrophysical Observation", "SAO 182144"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.81767149),
        dec: Angle.Degrees(-24.26272055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125360"},
        {"Hipparcos Number", "HIP 70005"},
        {"Smithsonian Astrophysical Observation", "SAO 182444"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.86812204),
        dec: Angle.Degrees(-24.26133508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36153"},
        {"Hipparcos Number", "HIP 25651"},
        {"Renson", "Renson 9344"},
        {"Smithsonian Astrophysical Observation", "SAO 170469"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.19859980),
        dec: Angle.Degrees(-24.26100926)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131830"},
        {"Hipparcos Number", "HIP 73110"},
        {"Smithsonian Astrophysical Observation", "SAO 183017"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.13154873),
        dec: Angle.Degrees(-24.25830686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63028"},
        {"Hipparcos Number", "HIP 37880"},
        {"Geneva Identification System", "GEN# +1.00063028"},
        {"Smithsonian Astrophysical Observation", "SAO 174475"},
        {"Wilson Evans Batten Catalogue", "WEB 7479"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.46607741),
        dec: Angle.Degrees(-24.25606945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67349",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67349"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.05800679),
        dec: Angle.Degrees(-24.25582505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -317.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51013"},
        {"Hipparcos Number", "HIP 33208"},
        {"Celescope Catalog", "CEL 1431"},
        {"Geneva Identification System", "GEN# +5.11210012"},
        {"Smithsonian Astrophysical Observation", "SAO 172558"},
    },
    visualMagnitude: 8.80,
    bvColour: -0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.67169763),
        dec: Angle.Degrees(-24.25568805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194142"},
        {"Hipparcos Number", "HIP 100675"},
        {"Renson", "Renson 54185"},
        {"Smithsonian Astrophysical Observation", "SAO 189253"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17901083),
        dec: Angle.Degrees(-24.25554043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145810"},
        {"Hipparcos Number", "HIP 79534"},
        {"Geneva Identification System", "GEN# +1.00145810"},
        {"Smithsonian Astrophysical Observation", "SAO 184242"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.45062660),
        dec: Angle.Degrees(-24.25548803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5610"},
        {"Smithsonian Astrophysical Observation", "SAO 166867"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.98684708),
        dec: Angle.Degrees(-24.25536764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26003",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4153 AB"},
        {"Henry Draper", "HD 36745"},
        {"Hipparcos Number", "HIP 26003"},
        {"Geneva Identification System", "GEN# +1.00036745J"},
        {"Smithsonian Astrophysical Observation", "SAO 170540"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.24922513),
        dec: Angle.Degrees(-24.25515195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1504"},
        {"Hipparcos Number", "HIP 1537"},
        {"Smithsonian Astrophysical Observation", "SAO 166186"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.78799483),
        dec: Angle.Degrees(-24.25277968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1678"},
    },
    visualMagnitude: 10.86,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.25227826),
        dec: Angle.Degrees(-24.25272016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9394 A"},
        {"Henry Draper", "HD 130529"},
        {"Hipparcos Number", "HIP 72488"},
        {"Geneva Identification System", "GEN# +1.00130529"},
        {"Smithsonian Astrophysical Observation", "SAO 182898"},
        {"Wilson Evans Batten Catalogue", "WEB 12457"},
    },
    visualMagnitude: 5.68,
    bvColour: 1.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.32815984),
        dec: Angle.Degrees(-24.25146951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218708"},
        {"Hipparcos Number", "HIP 114423"},
        {"Smithsonian Astrophysical Observation", "SAO 191698"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.59548829),
        dec: Angle.Degrees(-24.25064697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16703 AB"},
        {"Henry Draper", "HD 220230"},
        {"Hipparcos Number", "HIP 115377"},
        {"Smithsonian Astrophysical Observation", "SAO 191848"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.902,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.58228692),
        dec: Angle.Degrees(-24.25049893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42389"},
        {"Hipparcos Number", "HIP 29194"},
        {"Smithsonian Astrophysical Observation", "SAO 171310"},
    },
    visualMagnitude: 8.37,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.37199943),
        dec: Angle.Degrees(-24.24967646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77610"},
        {"Hipparcos Number", "HIP 44417"},
        {"Smithsonian Astrophysical Observation", "SAO 176871"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.71939264),
        dec: Angle.Degrees(-24.24957260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135950"},
        {"Hipparcos Number", "HIP 74920"},
        {"Smithsonian Astrophysical Observation", "SAO 183357"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.64949728),
        dec: Angle.Degrees(-24.24919889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157588"},
        {"Hipparcos Number", "HIP 85242"},
        {"Geneva Identification System", "GEN# +1.00157588"},
        {"Smithsonian Astrophysical Observation", "SAO 185374"},
        {"Wilson Evans Batten Catalogue", "WEB 14391"},
    },
    visualMagnitude: 6.17,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.27594197),
        dec: Angle.Degrees(-24.24371231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153942"},
        {"Hipparcos Number", "HIP 83461"},
        {"Smithsonian Astrophysical Observation", "SAO 184964"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.87525329),
        dec: Angle.Degrees(-24.24131506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154104"},
        {"Hipparcos Number", "HIP 83540"},
        {"Smithsonian Astrophysical Observation", "SAO 184991"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.11516745),
        dec: Angle.Degrees(-24.24028411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77841"},
        {"Hipparcos Number", "HIP 44515"},
        {"Smithsonian Astrophysical Observation", "SAO 176903"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.05111303),
        dec: Angle.Degrees(-24.24025857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45551"},
        {"Hipparcos Number", "HIP 30710"},
        {"Smithsonian Astrophysical Observation", "SAO 171769"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.79027709),
        dec: Angle.Degrees(-24.23858138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75907",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75907"},
        {"Smithsonian Astrophysical Observation", "SAO 183524"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.56868179),
        dec: Angle.Degrees(-24.23820957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
