using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_14() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89923"},
        {"Hipparcos Number", "HIP 50714"},
        {"Smithsonian Astrophysical Observation", "SAO 237971"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.32350098),
        dec: Angle.Degrees(-54.06157565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91101"},
        {"Hipparcos Number", "HIP 51395"},
        {"Smithsonian Astrophysical Observation", "SAO 238119"},
    },
    visualMagnitude: 8.50,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.45962542),
        dec: Angle.Degrees(-54.06065239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95252"},
        {"Hipparcos Number", "HIP 53676"},
        {"Geneva Identification System", "GEN# +1.00095252"},
        {"Smithsonian Astrophysical Observation", "SAO 238651"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.73914732),
        dec: Angle.Degrees(-54.05887103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15111"},
        {"Hipparcos Number", "HIP 11203"},
        {"Geneva Identification System", "GEN# +1.00015111"},
        {"Smithsonian Astrophysical Observation", "SAO 232755"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.06424748),
        dec: Angle.Degrees(-54.05794084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166576"},
        {"Hipparcos Number", "HIP 89380"},
        {"Geneva Identification System", "GEN# +1.00166576"},
        {"Smithsonian Astrophysical Observation", "SAO 245331"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.59744729),
        dec: Angle.Degrees(-54.05711777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78660",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78660"},
    },
    visualMagnitude: 10.84,
    bvColour: 2.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.87932584),
        dec: Angle.Degrees(-54.05681874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106614"},
        {"Hipparcos Number", "HIP 59811"},
        {"Smithsonian Astrophysical Observation", "SAO 239796"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.98165770),
        dec: Angle.Degrees(-54.05678638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139948"},
        {"Hipparcos Number", "HIP 77018"},
        {"Renson", "Renson 39810"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.88640156),
        dec: Angle.Degrees(-54.05569173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1963"},
        {"Hipparcos Number", "HIP 1862"},
        {"Geneva Identification System", "GEN# +1.00001963"},
        {"Smithsonian Astrophysical Observation", "SAO 232017"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.88853018),
        dec: Angle.Degrees(-54.05464046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100559"},
        {"Hipparcos Number", "HIP 56415"},
        {"Smithsonian Astrophysical Observation", "SAO 239173"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.48721835),
        dec: Angle.Degrees(-54.05401254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298609"},
        {"Hipparcos Number", "HIP 47381"},
        {"Smithsonian Astrophysical Observation", "SAO 237189"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.80145730),
        dec: Angle.Degrees(-54.05333593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104310"},
        {"Hipparcos Number", "HIP 58570"},
        {"Smithsonian Astrophysical Observation", "SAO 239577"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.16295611),
        dec: Angle.Degrees(-54.05296779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71900"},
        {"Hipparcos Number", "HIP 41456"},
        {"Smithsonian Astrophysical Observation", "SAO 235997"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.83120376),
        dec: Angle.Degrees(-54.05089060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117133"},
        {"Hipparcos Number", "HIP 65811"},
        {"Smithsonian Astrophysical Observation", "SAO 240882"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.36522282),
        dec: Angle.Degrees(-54.04872293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13696"},
        {"Hipparcos Number", "HIP 10246"},
        {"Geneva Identification System", "GEN# +1.00013696"},
        {"Smithsonian Astrophysical Observation", "SAO 232670"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.95139241),
        dec: Angle.Degrees(-54.04867290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67644"},
        {"Hipparcos Number", "HIP 39665"},
        {"Geneva Identification System", "GEN# +1.00067644"},
        {"Smithsonian Astrophysical Observation", "SAO 235745"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.58451723),
        dec: Angle.Degrees(-54.04609334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167937"},
        {"Hipparcos Number", "HIP 89882"},
        {"Smithsonian Astrophysical Observation", "SAO 245407"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11358980),
        dec: Angle.Degrees(-54.04405854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188606"},
        {"Hipparcos Number", "HIP 98317"},
        {"Smithsonian Astrophysical Observation", "SAO 246360"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63872211),
        dec: Angle.Degrees(-54.04400999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56960"},
        {"Hipparcos Number", "HIP 35172"},
        {"Smithsonian Astrophysical Observation", "SAO 235059"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.04186203),
        dec: Angle.Degrees(-54.04190992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26762"},
        {"Hipparcos Number", "HIP 19543"},
        {"Geneva Identification System", "GEN# +1.00026762"},
        {"Smithsonian Astrophysical Observation", "SAO 233425"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.78659550),
        dec: Angle.Degrees(-54.03937018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177720"},
        {"Hipparcos Number", "HIP 94051"},
        {"Smithsonian Astrophysical Observation", "SAO 245938"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.21301024),
        dec: Angle.Degrees(-54.03803848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79387"},
        {"Hipparcos Number", "HIP 45125"},
        {"Celescope Catalog", "CEL 3213"},
        {"Geneva Identification System", "GEN# +1.00079387"},
        {"Smithsonian Astrophysical Observation", "SAO 236704"},
    },
    visualMagnitude: 6.73,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.90778434),
        dec: Angle.Degrees(-54.03705141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28674"},
        {"Hipparcos Number", "HIP 20868"},
        {"Geneva Identification System", "GEN# +1.00028674"},
        {"Smithsonian Astrophysical Observation", "SAO 233532"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.08972442),
        dec: Angle.Degrees(-54.03568815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110636"},
        {"Hipparcos Number", "HIP 62136"},
        {"Smithsonian Astrophysical Observation", "SAO 240196"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.02107579),
        dec: Angle.Degrees(-54.03516460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169429"},
        {"Hipparcos Number", "HIP 90470"},
        {"Smithsonian Astrophysical Observation", "SAO 245487"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.90975706),
        dec: Angle.Degrees(-54.03376321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105229"},
        {"Hipparcos Number", "HIP 59081"},
        {"Smithsonian Astrophysical Observation", "SAO 239672"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.73895965),
        dec: Angle.Degrees(-54.03232051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299961"},
        {"Hipparcos Number", "HIP 45721"},
        {"Geneva Identification System", "GEN# +1.00299961"},
        {"Smithsonian Astrophysical Observation", "SAO 236845"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.80842320),
        dec: Angle.Degrees(-54.02725244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125446"},
        {"Hipparcos Number", "HIP 70143"},
        {"Geneva Identification System", "GEN# +1.00125446"},
        {"Smithsonian Astrophysical Observation", "SAO 241654"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.28828800),
        dec: Angle.Degrees(-54.02409488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43342",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75792"},
        {"Hipparcos Number", "HIP 43342"},
        {"Smithsonian Astrophysical Observation", "SAO 236318"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.43946457),
        dec: Angle.Degrees(-54.02168515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157786"},
        {"Hipparcos Number", "HIP 85501"},
        {"Smithsonian Astrophysical Observation", "SAO 244767"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.09809530),
        dec: Angle.Degrees(-54.02123036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142919"},
        {"Hipparcos Number", "HIP 78355"},
        {"Geneva Identification System", "GEN# +1.00142919"},
        {"Smithsonian Astrophysical Observation", "SAO 243219"},
        {"Wilson Evans Batten Catalogue", "WEB 13245"},
    },
    visualMagnitude: 6.10,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.97562034),
        dec: Angle.Degrees(-54.02089127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206744"},
        {"Hipparcos Number", "HIP 107460"},
        {"Geneva Identification System", "GEN# +1.00206744"},
        {"Smithsonian Astrophysical Observation", "SAO 247165"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.47258305),
        dec: Angle.Degrees(-54.01974971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -223.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196538"},
        {"Hipparcos Number", "HIP 102023"},
        {"Geneva Identification System", "GEN# +1.00196538"},
        {"Smithsonian Astrophysical Observation", "SAO 246684"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.11668915),
        dec: Angle.Degrees(-54.01957371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -214.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26960"},
        {"Hipparcos Number", "HIP 19683"},
        {"Smithsonian Astrophysical Observation", "SAO 233434"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.25130428),
        dec: Angle.Degrees(-54.01800331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202375"},
        {"Hipparcos Number", "HIP 105098"},
        {"Smithsonian Astrophysical Observation", "SAO 246947"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.34351843),
        dec: Angle.Degrees(-54.01729837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217551"},
        {"Hipparcos Number", "HIP 113761"},
        {"Geneva Identification System", "GEN# +1.00217551"},
        {"Smithsonian Astrophysical Observation", "SAO 247693"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.56908381),
        dec: Angle.Degrees(-54.01669276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21233"},
        {"Hipparcos Number", "HIP 15762"},
        {"Smithsonian Astrophysical Observation", "SAO 233094"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.77164733),
        dec: Angle.Degrees(-54.01568762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50099"},
        {"Hipparcos Number", "HIP 32648"},
        {"Geneva Identification System", "GEN# +1.00050099"},
        {"Smithsonian Astrophysical Observation", "SAO 234727"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.16073548),
        dec: Angle.Degrees(-54.01427463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66973"},
        {"Hipparcos Number", "HIP 39391"},
        {"Geneva Identification System", "GEN# +1.00066973"},
        {"Smithsonian Astrophysical Observation", "SAO 235718"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.79558784),
        dec: Angle.Degrees(-54.01421665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91241"},
        {"Hipparcos Number", "HIP 51476"},
        {"Geneva Identification System", "GEN# +1.00091241"},
        {"Smithsonian Astrophysical Observation", "SAO 238139"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.71513377),
        dec: Angle.Degrees(-54.01326868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1551"},
        {"Hipparcos Number", "HIP 1567"},
        {"Smithsonian Astrophysical Observation", "SAO 232000"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.87276562),
        dec: Angle.Degrees(-54.01151180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140448"},
        {"Hipparcos Number", "HIP 77228"},
        {"Smithsonian Astrophysical Observation", "SAO 242939"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.52565132),
        dec: Angle.Degrees(-54.01146670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11645"},
        {"Hipparcos Number", "HIP 8762"},
        {"Smithsonian Astrophysical Observation", "SAO 232555"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.18619869),
        dec: Angle.Degrees(-54.01143225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11393"},
        {"Hipparcos Number", "HIP 8578"},
        {"Geneva Identification System", "GEN# +1.00011393"},
        {"Smithsonian Astrophysical Observation", "SAO 232541"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.65338052),
        dec: Angle.Degrees(-54.00959827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32590"},
        {"Hipparcos Number", "HIP 23345"},
        {"Geneva Identification System", "GEN# +1.00032590"},
        {"Smithsonian Astrophysical Observation", "SAO 233787"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.31908043),
        dec: Angle.Degrees(-54.00799646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10858"},
        {"Hipparcos Number", "HIP 8176"},
        {"Smithsonian Astrophysical Observation", "SAO 232515"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.28290984),
        dec: Angle.Degrees(-54.00792252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210248"},
        {"Hipparcos Number", "HIP 109449"},
        {"Smithsonian Astrophysical Observation", "SAO 247338"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.60534353),
        dec: Angle.Degrees(-54.00704561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123006"},
        {"Hipparcos Number", "HIP 68926"},
        {"Geneva Identification System", "GEN# +1.00123006"},
        {"Smithsonian Astrophysical Observation", "SAO 241447"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.66441682),
        dec: Angle.Degrees(-54.00656605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102159"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.49805076),
        dec: Angle.Degrees(-54.00627671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216303"},
        {"Hipparcos Number", "HIP 112973"},
        {"Smithsonian Astrophysical Observation", "SAO 247626"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.19116064),
        dec: Angle.Degrees(-54.00463367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36144"},
        {"Hipparcos Number", "HIP 25449"},
        {"Smithsonian Astrophysical Observation", "SAO 233980"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.65488569),
        dec: Angle.Degrees(-54.00332382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 469"},
        {"Hipparcos Number", "HIP 730"},
        {"Geneva Identification System", "GEN# +1.00000469J"},
        {"Smithsonian Astrophysical Observation", "SAO 231943"},
        {"Wilson Evans Batten Catalogue", "WEB 124"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.25978189),
        dec: Angle.Degrees(-54.00196301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39129"},
        {"Hipparcos Number", "HIP 27335"},
        {"Smithsonian Astrophysical Observation", "SAO 234139"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.85230462),
        dec: Angle.Degrees(-53.99662896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10689"},
    },
    visualMagnitude: 12.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)02, (int)17, 33.7800),
        dec: Angle.DegreesMinutesSeconds((int)-53, (int)59, 46.900)
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
    primaryId: "HIP 116075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221285"},
        {"Hipparcos Number", "HIP 116075"},
        {"Smithsonian Astrophysical Observation", "SAO 247911"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.82015434),
        dec: Angle.Degrees(-53.99519249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122296"},
        {"Hipparcos Number", "HIP 68601"},
        {"Smithsonian Astrophysical Observation", "SAO 241385"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63864550),
        dec: Angle.Degrees(-53.99321462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10688",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10688"},
        {"Geneva Identification System", "GEN# -2.05400487"},
    },
    visualMagnitude: 11.48,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.39039667),
        dec: Angle.Degrees(-53.98996844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 463.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 390.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208545"},
        {"Hipparcos Number", "HIP 108482"},
        {"Renson", "Renson 58000"},
        {"Smithsonian Astrophysical Observation", "SAO 247250"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.63734595),
        dec: Angle.Degrees(-53.98769191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186238"},
        {"Hipparcos Number", "HIP 97253"},
        {"Smithsonian Astrophysical Observation", "SAO 246259"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.48125691),
        dec: Angle.Degrees(-53.98721537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2071"},
        {"Hipparcos Number", "HIP 1954"},
        {"Geneva Identification System", "GEN# +1.00002071"},
        {"Smithsonian Astrophysical Observation", "SAO 232028"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.17641442),
        dec: Angle.Degrees(-53.98392993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149193"},
        {"Hipparcos Number", "HIP 81268"},
        {"Smithsonian Astrophysical Observation", "SAO 243976"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98102131),
        dec: Angle.Degrees(-53.98387169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79670"},
        {"Hipparcos Number", "HIP 45243"},
        {"Celescope Catalog", "CEL 3229"},
        {"Geneva Identification System", "GEN# +1.00079670"},
        {"Smithsonian Astrophysical Observation", "SAO 236726"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.32871444),
        dec: Angle.Degrees(-53.98368026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172336"},
        {"Hipparcos Number", "HIP 91762"},
        {"Smithsonian Astrophysical Observation", "SAO 245645"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.68124838),
        dec: Angle.Degrees(-53.98314991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210978"},
        {"Hipparcos Number", "HIP 109887"},
        {"Geneva Identification System", "GEN# +1.00210978"},
        {"Smithsonian Astrophysical Observation", "SAO 247377"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.357,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.83428613),
        dec: Angle.Degrees(-53.98157694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153249"},
        {"Hipparcos Number", "HIP 83272"},
        {"Smithsonian Astrophysical Observation", "SAO 244360"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.28190114),
        dec: Angle.Degrees(-53.98043328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57096"},
        {"Hipparcos Number", "HIP 35223"},
        {"Smithsonian Astrophysical Observation", "SAO 235069"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20013773),
        dec: Angle.Degrees(-53.98034061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44246"},
        {"Hipparcos Number", "HIP 29892"},
        {"Smithsonian Astrophysical Observation", "SAO 234427"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.41451188),
        dec: Angle.Degrees(-53.97878361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206427"},
        {"Hipparcos Number", "HIP 107281"},
        {"Geneva Identification System", "GEN# +1.00206427"},
        {"Smithsonian Astrophysical Observation", "SAO 247150"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.95297874),
        dec: Angle.Degrees(-53.97728001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123187"},
        {"Hipparcos Number", "HIP 69010"},
        {"Smithsonian Astrophysical Observation", "SAO 241463"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.91700778),
        dec: Angle.Degrees(-53.97718476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9836"},
        {"Hipparcos Number", "HIP 7355"},
        {"Smithsonian Astrophysical Observation", "SAO 232468"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.69673391),
        dec: Angle.Degrees(-53.97536904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80931",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80931"},
    },
    visualMagnitude: 13.12,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.88812194),
        dec: Angle.Degrees(-53.97315520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82003"},
        {"Hipparcos Number", "HIP 46372"},
        {"Celescope Catalog", "CEL 3304"},
        {"Geneva Identification System", "GEN# +1.00082003"},
        {"Smithsonian Astrophysical Observation", "SAO 236998"},
    },
    visualMagnitude: 8.44,
    bvColour: -0.073,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.83842678),
        dec: Angle.Degrees(-53.96886999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101541"},
        {"Hipparcos Number", "HIP 56970"},
        {"Geneva Identification System", "GEN# +1.00101541"},
        {"Smithsonian Astrophysical Observation", "SAO 239284"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.17705098),
        dec: Angle.Degrees(-53.96854858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8567"},
        {"Hipparcos Number", "HIP 6504"},
        {"Geneva Identification System", "GEN# +1.00008567"},
        {"Smithsonian Astrophysical Observation", "SAO 232407"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.88350217),
        dec: Angle.Degrees(-53.96734562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108686"},
        {"Henry Draper 2", "HD 108687"},
        {"Hipparcos Number", "HIP 60940"},
        {"Geneva Identification System", "GEN# +1.00108687"},
        {"Smithsonian Astrophysical Observation", "SAO 239990"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.35765208),
        dec: Angle.Degrees(-53.96597367)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217902"},
        {"Hipparcos Number", "HIP 113957"},
        {"Fundamental Katalog 5th Edition", "FK5 3845"},
        {"Geneva Identification System", "GEN# +1.00217902"},
        {"Smithsonian Astrophysical Observation", "SAO 247711"},
        {"Wilson Evans Batten Catalogue", "WEB 20237"},
    },
    visualMagnitude: 5.37,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.16487864),
        dec: Angle.Degrees(-53.96464712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3282",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3282"},
    },
    visualMagnitude: 10.70,
    bvColour: 1.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.46249707),
        dec: Angle.Degrees(-53.96364216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173863"},
        {"Hipparcos Number", "HIP 92462"},
        {"Smithsonian Astrophysical Observation", "SAO 245749"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.65116338),
        dec: Angle.Degrees(-53.96320802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79446"},
        {"Hipparcos Number", "HIP 45165"},
        {"Celescope Catalog", "CEL 3220"},
        {"Geneva Identification System", "GEN# +1.00079446"},
        {"Smithsonian Astrophysical Observation", "SAO 236712"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.01454863),
        dec: Angle.Degrees(-53.96211821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132903"},
        {"Hipparcos Number", "HIP 73693"},
        {"Smithsonian Astrophysical Observation", "SAO 242194"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.94307067),
        dec: Angle.Degrees(-53.95837309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114736",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114736"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.63168160),
        dec: Angle.Degrees(-53.95779937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111437"},
        {"Hipparcos Number", "HIP 62613"},
        {"Smithsonian Astrophysical Observation", "SAO 240290"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.44939933),
        dec: Angle.Degrees(-53.95344682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214293"},
        {"Hipparcos Number", "HIP 111752"},
        {"Smithsonian Astrophysical Observation", "SAO 247525"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.56579179),
        dec: Angle.Degrees(-53.95154804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80267"},
        {"Hipparcos Number", "HIP 45518"},
        {"Celescope Catalog", "CEL 3251"},
        {"Smithsonian Astrophysical Observation", "SAO 236800"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.16470374),
        dec: Angle.Degrees(-53.95073977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91968"},
        {"Hipparcos Number", "HIP 51879"},
        {"Smithsonian Astrophysical Observation", "SAO 238232"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.99127174),
        dec: Angle.Degrees(-53.94961640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114692",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219123"},
        {"Hipparcos Number", "HIP 114692"},
        {"Geneva Identification System", "GEN# +1.00219123"},
        {"Smithsonian Astrophysical Observation", "SAO 247786"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.50471771),
        dec: Angle.Degrees(-53.94954528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214844"},
        {"Hipparcos Number", "HIP 112072"},
        {"Smithsonian Astrophysical Observation", "SAO 247550"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.50082798),
        dec: Angle.Degrees(-53.94922023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187977"},
        {"Hipparcos Number", "HIP 98048"},
        {"Smithsonian Astrophysical Observation", "SAO 246337"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.86972035),
        dec: Angle.Degrees(-53.94720294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93257",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175737"},
        {"Hipparcos Number", "HIP 93257"},
        {"Smithsonian Astrophysical Observation", "SAO 245851"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.94193636),
        dec: Angle.Degrees(-53.94669119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181517"},
        {"Hipparcos Number", "HIP 95322"},
        {"Smithsonian Astrophysical Observation", "SAO 246065"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.90375365),
        dec: Angle.Degrees(-53.94611775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5812"},
        {"Geneva Identification System", "GEN# +6.20145184"},
    },
    visualMagnitude: 11.16,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.64205953),
        dec: Angle.Degrees(-53.94286996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 310.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155672"},
        {"Hipparcos Number", "HIP 84457"},
        {"Smithsonian Astrophysical Observation", "SAO 244566"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.99618591),
        dec: Angle.Degrees(-53.94234869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6929"},
        {"Hipparcos Number", "HIP 5378"},
        {"Smithsonian Astrophysical Observation", "SAO 232309"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.19975380),
        dec: Angle.Degrees(-53.94024089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126390"},
        {"Hipparcos Number", "HIP 70631"},
        {"Geneva Identification System", "GEN# +1.00126390"},
        {"Smithsonian Astrophysical Observation", "SAO 241719"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.72091798),
        dec: Angle.Degrees(-53.93969364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14518"},
        {"Hipparcos Number", "HIP 10797"},
        {"Smithsonian Astrophysical Observation", "SAO 232706"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.74405894),
        dec: Angle.Degrees(-53.93756776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120458"},
        {"Hipparcos Number", "HIP 67577"},
        {"Geneva Identification System", "GEN# +1.00120458"},
        {"Smithsonian Astrophysical Observation", "SAO 241220"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.71102262),
        dec: Angle.Degrees(-53.93416386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117294"},
        {"Hipparcos Number", "HIP 65901"},
        {"Smithsonian Astrophysical Observation", "SAO 240902"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.63059136),
        dec: Angle.Degrees(-53.93273103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124268"},
        {"Hipparcos Number", "HIP 69539"},
        {"Geneva Identification System", "GEN# +1.00124268"},
        {"Smithsonian Astrophysical Observation", "SAO 241556"},
    },
    visualMagnitude: 7.23,
    bvColour: 3.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.53064767),
        dec: Angle.Degrees(-53.93198451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83421",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83421"},
    },
    visualMagnitude: 11.31,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.76201651),
        dec: Angle.Degrees(-53.93164416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114649"},
        {"Hipparcos Number", "HIP 64462"},
        {"Geneva Identification System", "GEN# +1.00114649"},
        {"Smithsonian Astrophysical Observation", "SAO 240651"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.19295885),
        dec: Angle.Degrees(-53.93028943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187633"},
        {"Hipparcos Number", "HIP 97894"},
        {"Smithsonian Astrophysical Observation", "SAO 246322"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.40103162),
        dec: Angle.Degrees(-53.92846762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123319"},
        {"Hipparcos Number", "HIP 69074"},
        {"Smithsonian Astrophysical Observation", "SAO 241472"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.08852111),
        dec: Angle.Degrees(-53.92756708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137520"},
        {"Hipparcos Number", "HIP 75778"},
        {"Geneva Identification System", "GEN# +1.00137520"},
        {"Smithsonian Astrophysical Observation", "SAO 242579"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.20501117),
        dec: Angle.Degrees(-53.92650049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104273"},
        {"Hipparcos Number", "HIP 58547"},
        {"Geneva Identification System", "GEN# +1.00104273"},
        {"Smithsonian Astrophysical Observation", "SAO 239571"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.08034181),
        dec: Angle.Degrees(-53.92302793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194715"},
        {"Hipparcos Number", "HIP 101097"},
        {"Smithsonian Astrophysical Observation", "SAO 246609"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.40115570),
        dec: Angle.Degrees(-53.92077528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152771"},
        {"Hipparcos Number", "HIP 83054"},
        {"Renson", "Renson 43250"},
        {"Smithsonian Astrophysical Observation", "SAO 244311"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.56894728),
        dec: Angle.Degrees(-53.92067955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82135"},
        {"Hipparcos Number", "HIP 46436"},
        {"Geneva Identification System", "GEN# +1.00082135"},
        {"Smithsonian Astrophysical Observation", "SAO 237013"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.05791947),
        dec: Angle.Degrees(-53.92063304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106360"},
        {"Hipparcos Number", "HIP 59675"},
        {"Geneva Identification System", "GEN# +1.00106360"},
        {"Smithsonian Astrophysical Observation", "SAO 239780"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.56104915),
        dec: Angle.Degrees(-53.92013701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103258"},
        {"Hipparcos Number", "HIP 57961"},
        {"Smithsonian Astrophysical Observation", "SAO 239464"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.32536227),
        dec: Angle.Degrees(-53.92002928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78797",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78797"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.29149365),
        dec: Angle.Degrees(-53.91940438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61089"},
        {"Hipparcos Number", "HIP 36860"},
        {"Smithsonian Astrophysical Observation", "SAO 235314"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.67569550),
        dec: Angle.Degrees(-53.91930451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53277",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94530"},
        {"Henry Draper 2", "HD 94531"},
        {"Hipparcos Number", "HIP 53277"},
        {"Smithsonian Astrophysical Observation", "SAO 238580"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.44628912),
        dec: Angle.Degrees(-53.91909899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19779"},
        {"Hipparcos Number", "HIP 14611"},
        {"Smithsonian Astrophysical Observation", "SAO 233005"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.17165038),
        dec: Angle.Degrees(-53.91846776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -168.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116416"},
        {"Hipparcos Number", "HIP 65425"},
        {"Smithsonian Astrophysical Observation", "SAO 240810"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.15036416),
        dec: Angle.Degrees(-53.91445258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87933"},
        {"Hipparcos Number", "HIP 49538"},
        {"Geneva Identification System", "GEN# +1.00087933"},
        {"Smithsonian Astrophysical Observation", "SAO 237701"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.72114111),
        dec: Angle.Degrees(-53.91348194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79523",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79523"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.41351015),
        dec: Angle.Degrees(-53.91309073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75482"},
        {"Hipparcos Number", "HIP 43191"},
        {"Geneva Identification System", "GEN# +1.00075482"},
        {"Smithsonian Astrophysical Observation", "SAO 236285"},
        {"Wilson Evans Batten Catalogue", "WEB 8332"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.99274117),
        dec: Angle.Degrees(-53.91266705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99436",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99436"},
    },
    visualMagnitude: 12.00,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.73765351),
        dec: Angle.Degrees(-53.91038054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 176.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225202"},
        {"Hipparcos Number", "HIP 346"},
        {"Smithsonian Astrophysical Observation", "SAO 231915"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.08780834),
        dec: Angle.Degrees(-53.90948292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18829"},
        {"Hipparcos Number", "HIP 13939"},
        {"Smithsonian Astrophysical Observation", "SAO 232961"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.89398012),
        dec: Angle.Degrees(-53.90858532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147127"},
        {"Hipparcos Number", "HIP 80221"},
        {"Geneva Identification System", "GEN# +1.00147127"},
        {"Smithsonian Astrophysical Observation", "SAO 243710"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.64425412),
        dec: Angle.Degrees(-53.90403883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -336.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90785"},
        {"Hipparcos Number", "HIP 51212"},
        {"Geneva Identification System", "GEN# +1.00090785"},
        {"Smithsonian Astrophysical Observation", "SAO 238080"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.90877695),
        dec: Angle.Degrees(-53.90391844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58270"},
        {"Hipparcos Number", "HIP 35696"},
        {"Smithsonian Astrophysical Observation", "SAO 235142"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.48048904),
        dec: Angle.Degrees(-53.90323211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74561"},
        {"Hipparcos Number", "HIP 42714"},
        {"Geneva Identification System", "GEN# +3.23910035"},
        {"Smithsonian Astrophysical Observation", "SAO 236203"},
        {"Wilson Evans Batten Catalogue", "WEB 8253"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.57600646),
        dec: Angle.Degrees(-53.90232605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103702"},
        {"Hipparcos Number", "HIP 58214"},
        {"Geneva Identification System", "GEN# +1.00103702"},
        {"Smithsonian Astrophysical Observation", "SAO 239507"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.08758631),
        dec: Angle.Degrees(-53.89989885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54611"},
        {"Hipparcos Number", "HIP 34289"},
        {"Smithsonian Astrophysical Observation", "SAO 234926"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.63145505),
        dec: Angle.Degrees(-53.89884814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66371",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118195"},
        {"Hipparcos Number", "HIP 66371"},
        {"Smithsonian Astrophysical Observation", "SAO 240991"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.08657555),
        dec: Angle.Degrees(-53.89516141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56145"},
        {"Hipparcos Number", "HIP 34867"},
        {"Geneva Identification System", "GEN# +1.00056145"},
        {"Smithsonian Astrophysical Observation", "SAO 235016"},
        {"Wilson Evans Batten Catalogue", "WEB 6973"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.21866641),
        dec: Angle.Degrees(-53.89440561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50051"},
        {"Hipparcos Number", "HIP 32634"},
        {"Geneva Identification System", "GEN# +1.00050051"},
        {"Smithsonian Astrophysical Observation", "SAO 234723"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.10711966),
        dec: Angle.Degrees(-53.89362149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223657"},
        {"Hipparcos Number", "HIP 117654"},
        {"Smithsonian Astrophysical Observation", "SAO 248042"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.91275090),
        dec: Angle.Degrees(-53.89302317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90586"},
        {"Hipparcos Number", "HIP 51087"},
        {"Smithsonian Astrophysical Observation", "SAO 238059"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.56519454),
        dec: Angle.Degrees(-53.89147401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84461"},
        {"Hipparcos Number", "HIP 47717"},
        {"Celescope Catalog", "CEL 3371"},
        {"Geneva Identification System", "GEN# +1.00084461"},
        {"Smithsonian Astrophysical Observation", "SAO 237268"},
        {"Wilson Evans Batten Catalogue", "WEB 8942"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.92625551),
        dec: Angle.Degrees(-53.89136176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41652"},
        {"Hipparcos Number", "HIP 28685"},
        {"Geneva Identification System", "GEN# +1.00041652"},
        {"Smithsonian Astrophysical Observation", "SAO 234275"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.84996320),
        dec: Angle.Degrees(-53.89042802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299879"},
        {"Hipparcos Number", "HIP 45050"},
    },
    visualMagnitude: 10.21,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.63602229),
        dec: Angle.Degrees(-53.88804992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24147",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34000"},
        {"Hipparcos Number", "HIP 24147"},
        {"Smithsonian Astrophysical Observation", "SAO 233864"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.78867104),
        dec: Angle.Degrees(-53.88785461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36381"},
        {"Hipparcos Number", "HIP 25617"},
        {"Smithsonian Astrophysical Observation", "SAO 233988"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.08980653),
        dec: Angle.Degrees(-53.88530919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45045",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 299878"},
        {"Hipparcos Number", "HIP 45045"},
        {"Smithsonian Astrophysical Observation", "SAO 236684"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.62265625),
        dec: Angle.Degrees(-53.88451918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209592"},
        {"Hipparcos Number", "HIP 109104"},
        {"Smithsonian Astrophysical Observation", "SAO 247306"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.51166733),
        dec: Angle.Degrees(-53.88222467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31027"},
        {"Hipparcos Number", "HIP 22431"},
        {"Geneva Identification System", "GEN# +1.00031027"},
        {"Smithsonian Astrophysical Observation", "SAO 233697"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.40384235),
        dec: Angle.Degrees(-53.88207928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 231.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298884"},
        {"Hipparcos Number", "HIP 49431"},
        {"Geneva Identification System", "GEN# +1.00298884"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.36457015),
        dec: Angle.Degrees(-53.87808466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60052",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107077"},
        {"Hipparcos Number", "HIP 60052"},
        {"Geneva Identification System", "GEN# +1.00107077"},
        {"Smithsonian Astrophysical Observation", "SAO 239835"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.73823460),
        dec: Angle.Degrees(-53.87250213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110130"},
        {"Hipparcos Number", "HIP 61842"},
        {"Geneva Identification System", "GEN# +1.00110130"},
        {"Smithsonian Astrophysical Observation", "SAO 240133"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.10913909),
        dec: Angle.Degrees(-53.87048901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195389"},
        {"Hipparcos Number", "HIP 101429"},
        {"Smithsonian Astrophysical Observation", "SAO 246630"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.33218968),
        dec: Angle.Degrees(-53.86957734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144855"},
        {"Hipparcos Number", "HIP 79261"},
        {"Geneva Identification System", "GEN# +1.00144855"},
        {"Smithsonian Astrophysical Observation", "SAO 243401"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.65208757),
        dec: Angle.Degrees(-53.86919515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30029"},
        {"Hipparcos Number", "HIP 21801"},
        {"Geneva Identification System", "GEN# +1.00030029"},
        {"Smithsonian Astrophysical Observation", "SAO 233625"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.402,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.25380610),
        dec: Angle.Degrees(-53.86821309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211942"},
        {"Hipparcos Number", "HIP 110432"},
        {"Geneva Identification System", "GEN# +1.00211942"},
        {"Smithsonian Astrophysical Observation", "SAO 247424"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.51676074),
        dec: Angle.Degrees(-53.86401913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129836"},
        {"Hipparcos Number", "HIP 72270"},
        {"Geneva Identification System", "GEN# +1.00129836"},
        {"Smithsonian Astrophysical Observation", "SAO 241986"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.68955028),
        dec: Angle.Degrees(-53.86208437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110851"},
        {"Hipparcos Number", "HIP 62263"},
        {"Smithsonian Astrophysical Observation", "SAO 240219"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.38563367),
        dec: Angle.Degrees(-53.86167726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179504"},
        {"Hipparcos Number", "HIP 94660"},
        {"Smithsonian Astrophysical Observation", "SAO 245994"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.93293822),
        dec: Angle.Degrees(-53.86147440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118816"},
        {"Hipparcos Number", "HIP 66709"},
        {"Celescope Catalog", "CEL 4276"},
        {"Geneva Identification System", "GEN# +1.00118816"},
        {"Renson", "Renson 34330"},
        {"Smithsonian Astrophysical Observation", "SAO 241055"},
    },
    visualMagnitude: 7.82,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.11209954),
        dec: Angle.Degrees(-53.86017654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61378"},
        {"Hipparcos Number", "HIP 36988"},
        {"Smithsonian Astrophysical Observation", "SAO 235344"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.04549582),
        dec: Angle.Degrees(-53.85780430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31840"},
        {"Hipparcos Number", "HIP 22937"},
        {"Smithsonian Astrophysical Observation", "SAO 233739"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.03450697),
        dec: Angle.Degrees(-53.85686189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92155"},
        {"Hipparcos Number", "HIP 51984"},
        {"Geneva Identification System", "GEN# +1.00092155"},
        {"Smithsonian Astrophysical Observation", "SAO 238260"},
        {"Wilson Evans Batten Catalogue", "WEB 9483"},
    },
    visualMagnitude: 6.43,
    bvColour: -0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.31718270),
        dec: Angle.Degrees(-53.85526528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196326"},
        {"Hipparcos Number", "HIP 101902"},
        {"Geneva Identification System", "GEN# +1.00196326"},
        {"Smithsonian Astrophysical Observation", "SAO 246676"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.75587973),
        dec: Angle.Degrees(-53.85505345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112251"},
        {"Hipparcos Number", "HIP 63132"},
        {"Geneva Identification System", "GEN# +1.00112251"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.02124904),
        dec: Angle.Degrees(-53.85245665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74182"},
        {"Hipparcos Number", "HIP 42511"},
        {"Geneva Identification System", "GEN# +3.23910019"},
        {"Smithsonian Astrophysical Observation", "SAO 236162"},
        {"Wilson Evans Batten Catalogue", "WEB 8195"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.01265695),
        dec: Angle.Degrees(-53.85175449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142948"},
        {"Hipparcos Number", "HIP 78378"},
        {"Geneva Identification System", "GEN# +1.00142948"},
        {"Smithsonian Astrophysical Observation", "SAO 243223"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.01014546),
        dec: Angle.Degrees(-53.85140963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28166"},
        {"Hipparcos Number", "HIP 20504"},
        {"Smithsonian Astrophysical Observation", "SAO 233502"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.91576985),
        dec: Angle.Degrees(-53.85111301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8077"},
        {"Hipparcos Number", "HIP 6165"},
        {"Smithsonian Astrophysical Observation", "SAO 232376"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.77315054),
        dec: Angle.Degrees(-53.85049248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169645"},
        {"Hipparcos Number", "HIP 90555"},
        {"Smithsonian Astrophysical Observation", "SAO 245502"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.17039211),
        dec: Angle.Degrees(-53.85026132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6818"},
        {"Hipparcos Number", "HIP 5306"},
        {"Smithsonian Astrophysical Observation", "SAO 232303"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.97502441),
        dec: Angle.Degrees(-53.84561792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197163"},
        {"Hipparcos Number", "HIP 102353"},
        {"Geneva Identification System", "GEN# +1.00197163"},
        {"Smithsonian Astrophysical Observation", "SAO 246710"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.06886210),
        dec: Angle.Degrees(-53.84439211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1532"},
        {"Hipparcos Number", "HIP 1555"},
        {"Smithsonian Astrophysical Observation", "SAO 231998"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.84373680),
        dec: Angle.Degrees(-53.84415142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12310"},
        {"Hipparcos Number", "HIP 9273"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.79560316),
        dec: Angle.Degrees(-53.84215686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1948"},
        {"Hipparcos Number", "HIP 1859"},
        {"Smithsonian Astrophysical Observation", "SAO 232016"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.86496725),
        dec: Angle.Degrees(-53.83984781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161935"},
        {"Hipparcos Number", "HIP 87386"},
        {"Geneva Identification System", "GEN# +1.00161935"},
        {"Smithsonian Astrophysical Observation", "SAO 245075"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.85732973),
        dec: Angle.Degrees(-53.83860054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104283"},
        {"Hipparcos Number", "HIP 58556"},
        {"Smithsonian Astrophysical Observation", "SAO 239572"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.11106036),
        dec: Angle.Degrees(-53.83843409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116561"},
        {"Hipparcos Number", "HIP 65488"},
        {"Geneva Identification System", "GEN# +1.00116561"},
        {"Smithsonian Astrophysical Observation", "SAO 240824"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.33596731),
        dec: Angle.Degrees(-53.83841068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175651"},
        {"Hipparcos Number", "HIP 93221"},
        {"Smithsonian Astrophysical Observation", "SAO 245845"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.83832951),
        dec: Angle.Degrees(-53.83690475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86934"},
        {"Hipparcos Number", "HIP 49035"},
        {"Smithsonian Astrophysical Observation", "SAO 237577"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.06489738),
        dec: Angle.Degrees(-53.83375462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117619"},
        {"Hipparcos Number", "HIP 66070"},
        {"Geneva Identification System", "GEN# +1.00117619"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.17363480),
        dec: Angle.Degrees(-53.83096538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111790"},
        {"Hipparcos Number", "HIP 62821"},
        {"Geneva Identification System", "GEN# +1.00111790J"},
        {"Smithsonian Astrophysical Observation", "SAO 240338"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.10253122),
        dec: Angle.Degrees(-53.82992658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113359"},
        {"Hipparcos Number", "HIP 63744"},
        {"Geneva Identification System", "GEN# +1.00113359"},
        {"Smithsonian Astrophysical Observation", "SAO 240513"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.96662389),
        dec: Angle.Degrees(-53.82602425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14318"},
        {"Hipparcos Number", "HIP 10650"},
        {"Smithsonian Astrophysical Observation", "SAO 232698"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.26671497),
        dec: Angle.Degrees(-53.82556684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93318"},
        {"Hipparcos Number", "HIP 52608"},
        {"Geneva Identification System", "GEN# +1.00093318J"},
        {"Smithsonian Astrophysical Observation", "SAO 238437"},
    },
    visualMagnitude: 8.58,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.37054500),
        dec: Angle.Degrees(-53.82454311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194173"},
        {"Hipparcos Number", "HIP 100822"},
        {"Smithsonian Astrophysical Observation", "SAO 246581"},
    },
    visualMagnitude: 8.38,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.65236137),
        dec: Angle.Degrees(-53.82261809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81353"},
        {"Hipparcos Number", "HIP 46017"},
        {"Geneva Identification System", "GEN# +1.00081353"},
        {"Smithsonian Astrophysical Observation", "SAO 236913"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.77495765),
        dec: Angle.Degrees(-53.82019022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211204"},
        {"Hipparcos Number", "HIP 110010"},
        {"Smithsonian Astrophysical Observation", "SAO 247389"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.22745702),
        dec: Angle.Degrees(-53.81998200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224530"},
        {"Hipparcos Number", "HIP 118211"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.67762898),
        dec: Angle.Degrees(-53.81975748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224164"},
        {"Hipparcos Number", "HIP 117976"},
        {"Geneva Identification System", "GEN# +1.00224164"},
        {"Smithsonian Astrophysical Observation", "SAO 248063"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.93210773),
        dec: Angle.Degrees(-53.81880544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124619"},
        {"Hipparcos Number", "HIP 69720"},
        {"Geneva Identification System", "GEN# +1.00124619"},
        {"Smithsonian Astrophysical Observation", "SAO 241579"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.07091748),
        dec: Angle.Degrees(-53.81716334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220391"},
        {"Hipparcos Number", "HIP 115506"},
        {"Geneva Identification System", "GEN# +1.00220391"},
        {"Smithsonian Astrophysical Observation", "SAO 247853"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.97027629),
        dec: Angle.Degrees(-53.81488961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98327",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188621"},
        {"Hipparcos Number", "HIP 98327"},
        {"Smithsonian Astrophysical Observation", "SAO 246361"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.66584568),
        dec: Angle.Degrees(-53.81262832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146003"},
        {"Hipparcos Number", "HIP 79754"},
        {"Geneva Identification System", "GEN# +1.00146003"},
        {"Smithsonian Astrophysical Observation", "SAO 243526"},
        {"Wilson Evans Batten Catalogue", "WEB 13494"},
    },
    visualMagnitude: 5.45,
    bvColour: 1.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.18029083),
        dec: Angle.Degrees(-53.81110764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212373"},
        {"Hipparcos Number", "HIP 110659"},
        {"Smithsonian Astrophysical Observation", "SAO 247442"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.26279865),
        dec: Angle.Degrees(-53.80989966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118180"},
        {"Geneva Identification System", "GEN# +6.20145147"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.59152194),
        dec: Angle.Degrees(-53.80967654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 115.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220392"},
        {"Hipparcos Number", "HIP 115510"},
        {"Smithsonian Astrophysical Observation", "SAO 247854"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.97686737),
        dec: Angle.Degrees(-53.80865550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40359"},
    },
    visualMagnitude: 10.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.60407299),
        dec: Angle.Degrees(-53.80637055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36969"},
        {"Hipparcos Number", "HIP 25944"},
        {"Geneva Identification System", "GEN# +1.00036969"},
        {"Smithsonian Astrophysical Observation", "SAO 234018"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.04934117),
        dec: Angle.Degrees(-53.80493920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190144"},
        {"Hipparcos Number", "HIP 99019"},
        {"Smithsonian Astrophysical Observation", "SAO 246432"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.53367284),
        dec: Angle.Degrees(-53.80459704)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160177"},
        {"Hipparcos Number", "HIP 86569"},
        {"Geneva Identification System", "GEN# +1.00160177"},
        {"Geneva Identification System 2", "GEN# +2.63970627"},
        {"Smithsonian Astrophysical Observation", "SAO 244944"},
        {"New General Catalogue", "NGC 6397 627"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.36535087),
        dec: Angle.Degrees(-53.80291605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172689"},
        {"Hipparcos Number", "HIP 91938"},
        {"Smithsonian Astrophysical Observation", "SAO 245666"},
    },
    visualMagnitude: 7.21,
    bvColour: -0.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.12715094),
        dec: Angle.Degrees(-53.80175306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43883",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43883"},
        {"Smithsonian Astrophysical Observation", "SAO 236422"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10339654),
        dec: Angle.Degrees(-53.80143184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40923"},
        {"Hipparcos Number", "HIP 28305"},
        {"Geneva Identification System", "GEN# +1.00040923"},
        {"Smithsonian Astrophysical Observation", "SAO 234237"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.72442421),
        dec: Angle.Degrees(-53.80102387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76822"},
        {"Hipparcos Number", "HIP 43885"},
        {"Smithsonian Astrophysical Observation", "SAO 236420"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.10047804),
        dec: Angle.Degrees(-53.79900771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82644"},
        {"Hipparcos Number", "HIP 46715"},
        {"Smithsonian Astrophysical Observation", "SAO 237068"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.84241932),
        dec: Angle.Degrees(-53.79666247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144457"},
        {"Hipparcos Number", "HIP 79095"},
        {"Smithsonian Astrophysical Observation", "SAO 243361"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.17522381),
        dec: Angle.Degrees(-53.79514089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116356"},
        {"Hipparcos Number", "HIP 65394"},
        {"Smithsonian Astrophysical Observation", "SAO 240802"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.03607923),
        dec: Angle.Degrees(-53.79306172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19937"},
        {"Hipparcos Number", "HIP 14706"},
        {"Geneva Identification System", "GEN# +1.00019937"},
        {"Smithsonian Astrophysical Observation", "SAO 233017"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.50452251),
        dec: Angle.Degrees(-53.78952024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68925"},
        {"Hipparcos Number", "HIP 40153"},
        {"Smithsonian Astrophysical Observation", "SAO 235803"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.99765865),
        dec: Angle.Degrees(-53.78833700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217615"},
        {"Hipparcos Number", "HIP 113794"},
        {"Geneva Identification System", "GEN# +1.00217615"},
        {"Smithsonian Astrophysical Observation", "SAO 247696"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.67442498),
        dec: Angle.Degrees(-53.78408072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209736"},
        {"Hipparcos Number", "HIP 109178"},
        {"Smithsonian Astrophysical Observation", "SAO 247312"},
    },
    visualMagnitude: 9.67,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.75430425),
        dec: Angle.Degrees(-53.78059550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26430"},
        {"Hipparcos Number", "HIP 19292"},
        {"Geneva Identification System", "GEN# +1.00026430"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.02815087),
        dec: Angle.Degrees(-53.77881522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4785"},
        {"Hipparcos Number", "HIP 3832"},
        {"Geneva Identification System", "GEN# +1.00004785"},
        {"Smithsonian Astrophysical Observation", "SAO 232195"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.29936838),
        dec: Angle.Degrees(-53.77407890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109313"},
        {"Hipparcos Number", "HIP 61338"},
        {"Geneva Identification System", "GEN# +1.00109313"},
        {"Smithsonian Astrophysical Observation", "SAO 240065"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.52586077),
        dec: Angle.Degrees(-53.77356982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103090"},
        {"Hipparcos Number", "HIP 57867"},
        {"Smithsonian Astrophysical Observation", "SAO 239438"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.03758128),
        dec: Angle.Degrees(-53.77174939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221343"},
        {"Hipparcos Number", "HIP 116122"},
        {"Geneva Identification System", "GEN# +1.00221343"},
        {"Smithsonian Astrophysical Observation", "SAO 247915"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.93398838),
        dec: Angle.Degrees(-53.76982266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67054"},
        {"Smithsonian Astrophysical Observation", "SAO 241124"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.12213618),
        dec: Angle.Degrees(-53.76928937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90073"},
        {"Hipparcos Number", "HIP 50803"},
        {"Geneva Identification System", "GEN# +1.00090073"},
        {"Smithsonian Astrophysical Observation", "SAO 237993"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.58880012),
        dec: Angle.Degrees(-53.76358875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192196"},
        {"Hipparcos Number", "HIP 99906"},
        {"Smithsonian Astrophysical Observation", "SAO 246507"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.05820902),
        dec: Angle.Degrees(-53.75660221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149192"},
        {"Hipparcos Number", "HIP 81262"},
        {"Smithsonian Astrophysical Observation", "SAO 243975"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.96033468),
        dec: Angle.Degrees(-53.75648351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -235.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154290"},
        {"Hipparcos Number", "HIP 83786"},
        {"Smithsonian Astrophysical Observation", "SAO 244447"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.86045546),
        dec: Angle.Degrees(-53.75551364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24124"},
        {"Hipparcos Number", "HIP 17755"},
        {"Geneva Identification System", "GEN# +1.00024124"},
        {"Smithsonian Astrophysical Observation", "SAO 233275"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.01366311),
        dec: Angle.Degrees(-53.75233595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74665"},
        {"Hipparcos Number", "HIP 42767"},
        {"Geneva Identification System", "GEN# +3.23910038"},
        {"Renson", "Renson 20890"},
        {"Smithsonian Astrophysical Observation", "SAO 236214"},
        {"Wilson Evans Batten Catalogue", "WEB 8260"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.72187912),
        dec: Angle.Degrees(-53.75022172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102026"},
        {"Hipparcos Number", "HIP 57238"},
        {"Smithsonian Astrophysical Observation", "SAO 239334"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.04087921),
        dec: Angle.Degrees(-53.74842223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220508"},
        {"Hipparcos Number", "HIP 115580"},
        {"Smithsonian Astrophysical Observation", "SAO 247864"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.18202319),
        dec: Angle.Degrees(-53.74608018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13808"},
        {"Hipparcos Number", "HIP 10301"},
        {"Geneva Identification System", "GEN# +1.00013808"},
        {"Smithsonian Astrophysical Observation", "SAO 232674"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.17929969),
        dec: Angle.Degrees(-53.74396658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22514"},
        {"Hipparcos Number", "HIP 16694"},
        {"Geneva Identification System", "GEN# +1.00022514"},
        {"Smithsonian Astrophysical Observation", "SAO 233170"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.69451834),
        dec: Angle.Degrees(-53.74158243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10647"},
        {"Hipparcos Number", "HIP 7978"},
        {"Geneva Identification System", "GEN# +1.00010647"},
        {"Smithsonian Astrophysical Observation", "SAO 232501"},
        {"Wilson Evans Batten Catalogue", "WEB 1711"},
    },
    visualMagnitude: 5.52,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.62146258),
        dec: Angle.Degrees(-53.74057470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199642"},
        {"Hipparcos Number", "HIP 103693"},
        {"Smithsonian Astrophysical Observation", "SAO 246824"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.18087664),
        dec: Angle.Degrees(-53.73901433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101053"},
        {"Hipparcos Number", "HIP 56688"},
        {"Smithsonian Astrophysical Observation", "SAO 239231"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.35396732),
        dec: Angle.Degrees(-53.73851413)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131577"},
        {"Hipparcos Number", "HIP 73109"},
        {"Geneva Identification System", "GEN# +1.00131577"},
        {"Smithsonian Astrophysical Observation", "SAO 242123"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.12912029),
        dec: Angle.Degrees(-53.73846675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23202"},
        {"Hipparcos Number", "HIP 17171"},
        {"Geneva Identification System", "GEN# +1.00023202"},
        {"Smithsonian Astrophysical Observation", "SAO 233221"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.16741542),
        dec: Angle.Degrees(-53.73821689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199447"},
        {"Hipparcos Number", "HIP 103600"},
        {"Smithsonian Astrophysical Observation", "SAO 246814"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.86433803),
        dec: Angle.Degrees(-53.73809475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81238"},
        {"Hipparcos Number", "HIP 45964"},
        {"Geneva Identification System", "GEN# +1.00081238J"},
        {"Smithsonian Astrophysical Observation", "SAO 236895"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.61825044),
        dec: Angle.Degrees(-53.73678012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34838"},
        {"Hipparcos Number", "HIP 24651"},
    },
    visualMagnitude: 9.32,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.34503630),
        dec: Angle.Degrees(-53.73644581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71367"},
        {"Hipparcos Number", "HIP 41207"},
        {"Smithsonian Astrophysical Observation", "SAO 235949"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.13215748),
        dec: Angle.Degrees(-53.73623797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168240"},
        {"Hipparcos Number", "HIP 89995"},
        {"Smithsonian Astrophysical Observation", "SAO 245424"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.43677010),
        dec: Angle.Degrees(-53.73535858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120491"},
        {"Hipparcos Number", "HIP 67601"},
        {"Smithsonian Astrophysical Observation", "SAO 241223"},
    },
    visualMagnitude: 9.53,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.77541133),
        dec: Angle.Degrees(-53.73483795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12373"},
        {"Hipparcos Number", "HIP 9325"},
        {"Smithsonian Astrophysical Observation", "SAO 232596"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.94101293),
        dec: Angle.Degrees(-53.73217975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217989"},
        {"Hipparcos Number", "HIP 114001"},
        {"Smithsonian Astrophysical Observation", "SAO 247718"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.31302244),
        dec: Angle.Degrees(-53.73185431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214390"},
        {"Hipparcos Number", "HIP 111804"},
        {"Smithsonian Astrophysical Observation", "SAO 247527"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.69065285),
        dec: Angle.Degrees(-53.73142948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167936"},
        {"Hipparcos Number", "HIP 89884"},
        {"Smithsonian Astrophysical Observation", "SAO 245408"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.11580562),
        dec: Angle.Degrees(-53.73028022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119438"},
        {"Hipparcos Number", "HIP 67051"},
        {"Smithsonian Astrophysical Observation", "SAO 241123"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.11399203),
        dec: Angle.Degrees(-53.72995465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171928"},
        {"Hipparcos Number", "HIP 91564"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08729006),
        dec: Angle.Degrees(-53.72961028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116904"},
        {"Hipparcos Number", "HIP 65668"},
        {"Smithsonian Astrophysical Observation", "SAO 240860"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.96957775),
        dec: Angle.Degrees(-53.72310087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33907",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53497"},
        {"Hipparcos Number", "HIP 33907"},
        {"Smithsonian Astrophysical Observation", "SAO 234872"},
    },
    visualMagnitude: 9.37,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.55785838),
        dec: Angle.Degrees(-53.72306584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82365",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82365"},
        {"Geneva Identification System", "GEN# +2.62080054"},
        {"New General Catalogue", "NGC 6208 54"},
    },
    visualMagnitude: 11.48,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.44918871),
        dec: Angle.Degrees(-53.72263510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73904"},
        {"Hipparcos Number", "HIP 42374"},
        {"Geneva Identification System", "GEN# +3.23910006"},
        {"Smithsonian Astrophysical Observation", "SAO 236140"},
        {"Wilson Evans Batten Catalogue", "WEB 8146"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.59973659),
        dec: Angle.Degrees(-53.72183029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3509"},
        {"Hipparcos Number", "HIP 2957"},
        {"Smithsonian Astrophysical Observation", "SAO 232117"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.38882702),
        dec: Angle.Degrees(-53.72103188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94997",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94997"},
        {"Geneva Identification System", "GEN# +6.20145036"},
    },
    visualMagnitude: 12.11,
    bvColour: 1.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.95685643),
        dec: Angle.Degrees(-53.72023821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138826"},
        {"Hipparcos Number", "HIP 76455"},
        {"Smithsonian Astrophysical Observation", "SAO 242757"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.22045415),
        dec: Angle.Degrees(-53.71865878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51523",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91324"},
        {"Hipparcos Number", "HIP 51523"},
        {"Cincinnati Publication", "Ci 20 583"},
        {"Geneva Identification System", "GEN# +1.00091324"},
        {"Smithsonian Astrophysical Observation", "SAO 238146"},
        {"Wilson Evans Batten Catalogue", "WEB 9400"},
    },
    visualMagnitude: 4.89,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.84264509),
        dec: Angle.Degrees(-53.71599280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -418.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 209.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7678"},
        {"Hipparcos Number", "HIP 5895"},
        {"Geneva Identification System", "GEN# +1.00007678"},
        {"Smithsonian Astrophysical Observation", "SAO 232361"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.646,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.93728992),
        dec: Angle.Degrees(-53.71573852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4304"},
        {"Hipparcos Number", "HIP 3527"},
        {"Fundamental Katalog 5th Edition", "FK5 2049"},
        {"Geneva Identification System", "GEN# +1.00004304"},
        {"Smithsonian Astrophysical Observation", "SAO 232168"},
        {"Wilson Evans Batten Catalogue", "WEB 623"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.24883557),
        dec: Angle.Degrees(-53.71490037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47409"},
        {"Hipparcos Number", "HIP 31468"},
        {"Smithsonian Astrophysical Observation", "SAO 234594"},
    },
    visualMagnitude: 9.07,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.87044486),
        dec: Angle.Degrees(-53.71088565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143658"},
        {"Hipparcos Number", "HIP 78731"},
        {"Geneva Identification System", "GEN# +1.00143658"},
        {"Renson", "Renson 40710"},
        {"Smithsonian Astrophysical Observation", "SAO 243296"},
    },
    visualMagnitude: 6.46,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.08885185),
        dec: Angle.Degrees(-53.71033327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5770"},
        {"Hipparcos Number", "HIP 4576"},
        {"Smithsonian Astrophysical Observation", "SAO 232244"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.64975003),
        dec: Angle.Degrees(-53.70844434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204228"},
        {"Hipparcos Number", "HIP 106065"},
        {"Geneva Identification System", "GEN# +1.00204228"},
        {"Smithsonian Astrophysical Observation", "SAO 247043"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.25031910),
        dec: Angle.Degrees(-53.70585019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28481"},
        {"Hipparcos Number", "HIP 20739"},
        {"Geneva Identification System", "GEN# +1.00028481"},
        {"Smithsonian Astrophysical Observation", "SAO 233522"},
        {"Wilson Evans Batten Catalogue", "WEB 3979"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.66224629),
        dec: Angle.Degrees(-53.70435386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 50.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121620"},
        {"Hipparcos Number", "HIP 68213"},
        {"Geneva Identification System", "GEN# +1.00121620"},
        {"Smithsonian Astrophysical Observation", "SAO 241330"},
        {"Wilson Evans Batten Catalogue", "WEB 11966"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.48538802),
        dec: Angle.Degrees(-53.70424657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201266"},
        {"Hipparcos Number", "HIP 104522"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.58572672),
        dec: Angle.Degrees(-53.70396318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69992"},
        {"Hipparcos Number", "HIP 40568"},
        {"Celescope Catalog", "CEL 2319"},
        {"Geneva Identification System", "GEN# +1.00069992"},
        {"Smithsonian Astrophysical Observation", "SAO 235857"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.23848076),
        dec: Angle.Degrees(-53.70254408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164132"},
        {"Hipparcos Number", "HIP 88373"},
        {"Fundamental Katalog 5th Edition", "FK5 5589"},
        {"Geneva Identification System", "GEN# +1.00164132"},
        {"Smithsonian Astrophysical Observation", "SAO 245190"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.68572888),
        dec: Angle.Degrees(-53.70218297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137364"},
        {"Hipparcos Number", "HIP 75699"},
        {"Geneva Identification System", "GEN# +1.00137364"},
        {"Smithsonian Astrophysical Observation", "SAO 242553"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.97115844),
        dec: Angle.Degrees(-53.70182703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126283"},
        {"Hipparcos Number", "HIP 70583"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.57516618),
        dec: Angle.Degrees(-53.69797207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87894"},
        {"Hipparcos Number", "HIP 49516"},
        {"Geneva Identification System", "GEN# +1.00087894"},
        {"Smithsonian Astrophysical Observation", "SAO 237698"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.65325690),
        dec: Angle.Degrees(-53.69641196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146059"},
        {"Hipparcos Number", "HIP 79787"},
        {"Geneva Identification System", "GEN# +1.00146059J"},
        {"Smithsonian Astrophysical Observation", "SAO 243533"},
        {"Wilson Evans Batten Catalogue", "WEB 13502"},
    },
    visualMagnitude: 6.40,
    bvColour: 0.793,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.24577701),
        dec: Angle.Degrees(-53.69595914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144318"},
        {"Hipparcos Number", "HIP 79033"},
        {"Smithsonian Astrophysical Observation", "SAO 243346"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.97208449),
        dec: Angle.Degrees(-53.69362199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115030"},
        {"Hipparcos Number", "HIP 64676"},
        {"Smithsonian Astrophysical Observation", "SAO 240683"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.84370010),
        dec: Angle.Degrees(-53.69329062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69018",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69018"},
        {"Smithsonian Astrophysical Observation", "SAO 241464"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.93575802),
        dec: Angle.Degrees(-53.69108287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18763"},
        {"Hipparcos Number", "HIP 13899"},
        {"Smithsonian Astrophysical Observation", "SAO 232956"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.73919208),
        dec: Angle.Degrees(-53.68949561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76107",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76107"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.790,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.15331152),
        dec: Angle.Degrees(-52.35539226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150459"},
        {"Hipparcos Number", "HIP 81918"},
        {"Smithsonian Astrophysical Observation", "SAO 244096"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.98415568),
        dec: Angle.Degrees(-53.68935124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95376"},
        {"Hipparcos Number", "HIP 53739"},
        {"Smithsonian Astrophysical Observation", "SAO 238666"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.94155713),
        dec: Angle.Degrees(-53.68854584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223528"},
        {"Hipparcos Number", "HIP 117560"},
        {"Smithsonian Astrophysical Observation", "SAO 248036"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.61678438),
        dec: Angle.Degrees(-53.68831498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70543"},
        {"Hipparcos Number", "HIP 40828"},
        {"Smithsonian Astrophysical Observation", "SAO 235891"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.99396584),
        dec: Angle.Degrees(-53.68815466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127019"},
        {"Hipparcos Number", "HIP 70960"},
        {"Geneva Identification System", "GEN# +1.00127019"},
        {"Smithsonian Astrophysical Observation", "SAO 241759"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.71582064),
        dec: Angle.Degrees(-53.68767968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117887"},
        {"Hipparcos Number", "HIP 66224"},
        {"Smithsonian Astrophysical Observation", "SAO 240955"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.59655240),
        dec: Angle.Degrees(-53.68642025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147171"},
        {"Hipparcos Number", "HIP 80249"},
        {"Geneva Identification System", "GEN# +1.00147171"},
        {"Smithsonian Astrophysical Observation", "SAO 243718"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.74798237),
        dec: Angle.Degrees(-53.68611831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69019",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123186"},
        {"Hipparcos Number", "HIP 69019"},
        {"Smithsonian Astrophysical Observation", "SAO 241465"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.93689059),
        dec: Angle.Degrees(-53.68594388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90757"},
        {"Hipparcos Number", "HIP 51202"},
        {"Smithsonian Astrophysical Observation", "SAO 238076"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.87276468),
        dec: Angle.Degrees(-53.67685370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -104.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 63.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39281"},
        {"Hipparcos Number", "HIP 27434"},
        {"Smithsonian Astrophysical Observation", "SAO 234145"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.14233962),
        dec: Angle.Degrees(-53.67613836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82348",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82348"},
        {"Geneva Identification System", "GEN# +2.62080048"},
        {"New General Catalogue", "NGC 6208 48"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.39145288),
        dec: Angle.Degrees(-53.67341164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90676"},
        {"Hipparcos Number", "HIP 51144"},
        {"Geneva Identification System", "GEN# +1.00090676"},
        {"Smithsonian Astrophysical Observation", "SAO 238068"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.71293140),
        dec: Angle.Degrees(-53.67334258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145384"},
        {"Hipparcos Number", "HIP 79490"},
        {"Geneva Identification System", "GEN# +1.00145384"},
        {"Smithsonian Astrophysical Observation", "SAO 243448"},
    },
    visualMagnitude: 6.03,
    bvColour: 1.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.32072380),
        dec: Angle.Degrees(-53.67116378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58657"},
        {"Hipparcos Number", "HIP 35869"},
        {"Geneva Identification System", "GEN# +1.00058657"},
        {"Smithsonian Astrophysical Observation", "SAO 235163"},
        {"Wilson Evans Batten Catalogue", "WEB 7146"},
    },
    visualMagnitude: 7.22,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.92544810),
        dec: Angle.Degrees(-53.66943808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83520"},
        {"Hipparcos Number", "HIP 47204"},
        {"Celescope Catalog", "CEL 3346"},
        {"Geneva Identification System", "GEN# +1.00083520J"},
        {"Smithsonian Astrophysical Observation", "SAO 237149"},
        {"Wilson Evans Batten Catalogue", "WEB 8880"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.30281740),
        dec: Angle.Degrees(-53.66848607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56350"},
        {"Hipparcos Number", "HIP 34929"},
        {"Geneva Identification System", "GEN# +1.00056350"},
        {"Renson", "Renson 15360"},
        {"Smithsonian Astrophysical Observation", "SAO 235022"},
    },
    visualMagnitude: 6.70,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.41618496),
        dec: Angle.Degrees(-53.66781817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97076"},
        {"Hipparcos Number", "HIP 54562"},
        {"Geneva Identification System", "GEN# +1.00097076"},
        {"Smithsonian Astrophysical Observation", "SAO 238829"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.47360415),
        dec: Angle.Degrees(-53.66747251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113888"},
        {"Hipparcos Number", "HIP 64042"},
        {"Celescope Catalog", "CEL 4201"},
        {"Geneva Identification System", "GEN# +1.00113888"},
        {"Smithsonian Astrophysical Observation", "SAO 240570"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.87818862),
        dec: Angle.Degrees(-53.66735802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124147"},
        {"Henry Draper 2", "HD 124148"},
        {"Hipparcos Number", "HIP 69462"},
        {"Celescope Catalog", "CEL 4306"},
        {"Geneva Identification System", "GEN# +1.00124147"},
        {"Smithsonian Astrophysical Observation", "SAO 241543"},
        {"Wilson Evans Batten Catalogue", "WEB 12106"},
    },
    visualMagnitude: 5.53,
    bvColour: 1.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.31841949),
        dec: Angle.Degrees(-53.66565135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187069"},
        {"Hipparcos Number", "HIP 97632"},
        {"Smithsonian Astrophysical Observation", "SAO 246295"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.64914626),
        dec: Angle.Degrees(-53.66515283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89839"},
        {"Hipparcos Number", "HIP 50653"},
        {"Smithsonian Astrophysical Observation", "SAO 237945"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.16895329),
        dec: Angle.Degrees(-53.66412860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123993"},
        {"Hipparcos Number", "HIP 69394"},
        {"Smithsonian Astrophysical Observation", "SAO 241529"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.09244863),
        dec: Angle.Degrees(-53.66031340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51771"},
        {"Hipparcos Number", "HIP 33307"},
        {"Smithsonian Astrophysical Observation", "SAO 234786"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.92089410),
        dec: Angle.Degrees(-53.66012940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134484"},
        {"Hipparcos Number", "HIP 74400"},
        {"Geneva Identification System", "GEN# +1.00134484"},
        {"Smithsonian Astrophysical Observation", "SAO 242303"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.08133815),
        dec: Angle.Degrees(-53.65800738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221580"},
        {"Hipparcos Number", "HIP 116285"},
        {"Geneva Identification System", "GEN# +1.00221580"},
        {"Smithsonian Astrophysical Observation", "SAO 247927"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.41683462),
        dec: Angle.Degrees(-53.65796522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 113.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39754"},
        {"Hipparcos Number", "HIP 27671"},
        {"Geneva Identification System", "GEN# +1.00039754"},
        {"Smithsonian Astrophysical Observation", "SAO 234174"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.87001809),
        dec: Angle.Degrees(-53.65562296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181377"},
        {"Hipparcos Number", "HIP 95280"},
        {"Smithsonian Astrophysical Observation", "SAO 246058"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.76651925),
        dec: Angle.Degrees(-53.65479343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131438"},
        {"Hipparcos Number", "HIP 73042"},
        {"Geneva Identification System", "GEN# +1.00131438"},
        {"Smithsonian Astrophysical Observation", "SAO 242116"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.91442402),
        dec: Angle.Degrees(-53.65331044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12864"},
        {"Hipparcos Number", "HIP 9682"},
        {"Smithsonian Astrophysical Observation", "SAO 232619"},
    },
    visualMagnitude: 9.14,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.13076764),
        dec: Angle.Degrees(-53.65296907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48046"},
        {"Hipparcos Number", "HIP 31746"},
        {"Geneva Identification System", "GEN# +1.00048046"},
        {"Smithsonian Astrophysical Observation", "SAO 234629"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.61044453),
        dec: Angle.Degrees(-53.65220916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142824"},
        {"Hipparcos Number", "HIP 78294"},
        {"Smithsonian Astrophysical Observation", "SAO 243201"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.80694165),
        dec: Angle.Degrees(-53.65183263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157194"},
        {"Hipparcos Number", "HIP 85220"},
        {"Smithsonian Astrophysical Observation", "SAO 244718"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.20766788),
        dec: Angle.Degrees(-53.65175079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102920"},
        {"Hipparcos Number", "HIP 57766"},
        {"Smithsonian Astrophysical Observation", "SAO 239424"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.68991679),
        dec: Angle.Degrees(-53.64901035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149100"},
        {"Hipparcos Number", "HIP 81216"},
        {"Geneva Identification System", "GEN# +1.00149100"},
        {"Smithsonian Astrophysical Observation", "SAO 243965"},
        {"Wilson Evans Batten Catalogue", "WEB 13728"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.83339558),
        dec: Angle.Degrees(-53.64727401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107788"},
        {"Hipparcos Number", "HIP 60429"},
        {"Geneva Identification System", "GEN# +1.00107788"},
        {"Smithsonian Astrophysical Observation", "SAO 239907"},
    },
    visualMagnitude: 8.71,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.85440750),
        dec: Angle.Degrees(-53.64697854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79921"},
        {"Hipparcos Number", "HIP 45369"},
        {"Smithsonian Astrophysical Observation", "SAO 236754"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.68774776),
        dec: Angle.Degrees(-53.64533840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98622"},
        {"Hipparcos Number", "HIP 55373"},
        {"Geneva Identification System", "GEN# +1.00098622"},
        {"Smithsonian Astrophysical Observation", "SAO 238978"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.07279431),
        dec: Angle.Degrees(-53.64214445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86021"},
        {"Hipparcos Number", "HIP 48558"},
        {"Geneva Identification System", "GEN# +1.00086021"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.54600886),
        dec: Angle.Degrees(-53.64111272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57381"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.44414982),
        dec: Angle.Degrees(-53.63882924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8094"},
        {"Hipparcos Number", "HIP 6183"},
        {"Smithsonian Astrophysical Observation", "SAO 232377"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.83485015),
        dec: Angle.Degrees(-53.63644148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130517"},
        {"Hipparcos Number", "HIP 72595"},
        {"Smithsonian Astrophysical Observation", "SAO 242054"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.64694036),
        dec: Angle.Degrees(-53.63538815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169349"},
        {"Hipparcos Number", "HIP 90448"},
        {"Geneva Identification System", "GEN# +1.00169349"},
        {"Smithsonian Astrophysical Observation", "SAO 245482"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.82883572),
        dec: Angle.Degrees(-53.63379505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 84.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97305",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97305"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.63975140),
        dec: Angle.Degrees(-53.63233150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169239"},
        {"Hipparcos Number", "HIP 90408"},
        {"Geneva Identification System", "GEN# +1.00169239"},
        {"Smithsonian Astrophysical Observation", "SAO 245470"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.70628114),
        dec: Angle.Degrees(-53.63131778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44382"},
        {"Hipparcos Number", "HIP 29970"},
        {"Smithsonian Astrophysical Observation", "SAO 234441"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.63513817),
        dec: Angle.Degrees(-53.63099140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218310"},
        {"Hipparcos Number", "HIP 114199"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.90425640),
        dec: Angle.Degrees(-53.62721768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86566",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86566"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.35691373),
        dec: Angle.Degrees(-53.62720057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40557",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40557"},
        {"Geneva Identification System", "GEN# -0.05301602"},
        {"Smithsonian Astrophysical Observation", "SAO 235856"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.22086112),
        dec: Angle.Degrees(-53.62636898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198021"},
        {"Hipparcos Number", "HIP 102816"},
        {"Smithsonian Astrophysical Observation", "SAO 246746"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.44639470),
        dec: Angle.Degrees(-53.62557024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211415"},
        {"Hipparcos Number", "HIP 110109"},
        {"Cincinnati Publication", "Ci 20 1350"},
        {"Geneva Identification System", "GEN# +1.00211415"},
        {"Smithsonian Astrophysical Observation", "SAO 247400"},
        {"Wilson Evans Batten Catalogue", "WEB 19762"},
    },
    visualMagnitude: 5.36,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.56326060),
        dec: Angle.Degrees(-53.62553594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 439.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -632.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99959"},
        {"Hipparcos Number", "HIP 56071"},
        {"Smithsonian Astrophysical Observation", "SAO 239113"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.39113726),
        dec: Angle.Degrees(-53.62549829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33315",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51770"},
        {"Hipparcos Number", "HIP 33315"},
        {"Smithsonian Astrophysical Observation", "SAO 234789"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.94505103),
        dec: Angle.Degrees(-53.62409500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65297"},
        {"Hipparcos Number", "HIP 38701"},
        {"Geneva Identification System", "GEN# +1.00065297"},
        {"Smithsonian Astrophysical Observation", "SAO 235621"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.85115283),
        dec: Angle.Degrees(-53.62295941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133024"},
        {"Hipparcos Number", "HIP 73738"},
        {"Geneva Identification System", "GEN# +1.00133024"},
        {"Smithsonian Astrophysical Observation", "SAO 242204"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.09525527),
        dec: Angle.Degrees(-53.62255499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50337"},
        {"Hipparcos Number", "HIP 32761"},
        {"Geneva Identification System", "GEN# +1.00050337"},
        {"Smithsonian Astrophysical Observation", "SAO 234737"},
        {"Wilson Evans Batten Catalogue", "WEB 6599"},
    },
    visualMagnitude: 4.41,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.46381712),
        dec: Angle.Degrees(-53.62249221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89754"},
        {"Hipparcos Number", "HIP 50586"},
        {"Smithsonian Astrophysical Observation", "SAO 237926"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.00997106),
        dec: Angle.Degrees(-53.62050714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25727"},
        {"Hipparcos Number", "HIP 18830"},
        {"Smithsonian Astrophysical Observation", "SAO 233373"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.54585567),
        dec: Angle.Degrees(-53.61934982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86353"},
        {"Hipparcos Number", "HIP 48720"},
        {"Celescope Catalog", "CEL 3408"},
        {"Geneva Identification System", "GEN# +1.00086353"},
        {"Smithsonian Astrophysical Observation", "SAO 237511"},
    },
    visualMagnitude: 6.80,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.05769420),
        dec: Angle.Degrees(-53.61922086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95881",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182969"},
        {"Hipparcos Number", "HIP 95881"},
        {"Smithsonian Astrophysical Observation", "SAO 246126"},
    },
    visualMagnitude: 7.83,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.50584835),
        dec: Angle.Degrees(-53.61857751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109890"},
        {"Hipparcos Number", "HIP 61691"},
        {"Smithsonian Astrophysical Observation", "SAO 240111"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68771194),
        dec: Angle.Degrees(-53.61782049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110895"},
        {"Hipparcos Number", "HIP 62297"},
        {"Geneva Identification System", "GEN# +1.00110895"},
        {"Smithsonian Astrophysical Observation", "SAO 240225"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.48062480),
        dec: Angle.Degrees(-53.61669097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80649",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80649"},
        {"Smithsonian Astrophysical Observation", "SAO 243837"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.99175928),
        dec: Angle.Degrees(-53.61617998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81352"},
        {"Hipparcos Number", "HIP 46015"},
        {"Smithsonian Astrophysical Observation", "SAO 236911"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.77215806),
        dec: Angle.Degrees(-53.61570166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38698"},
        {"Smithsonian Astrophysical Observation", "SAO 235619"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.84586205),
        dec: Angle.Degrees(-53.61374942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161783"},
        {"Hipparcos Number", "HIP 87314"},
        {"Smithsonian Astrophysical Observation", "SAO 245065"},
        {"Wilson Evans Batten Catalogue", "WEB 14731"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.61829297),
        dec: Angle.Degrees(-53.61238082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52299"},
        {"Hipparcos Number", "HIP 33483"},
        {"Geneva Identification System", "GEN# +1.00052299"},
        {"Smithsonian Astrophysical Observation", "SAO 234814"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.40142047),
        dec: Angle.Degrees(-53.61229365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202689"},
        {"Hipparcos Number", "HIP 105286"},
        {"Smithsonian Astrophysical Observation", "SAO 246962"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.88854848),
        dec: Angle.Degrees(-53.61199916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80598"},
        {"Hipparcos Number", "HIP 45682"},
        {"Celescope Catalog", "CEL 3265"},
        {"Smithsonian Astrophysical Observation", "SAO 236839"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.69695726),
        dec: Angle.Degrees(-53.61174272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111537B"},
        {"Hipparcos Number", "HIP 62672"},
    },
    visualMagnitude: 12.24,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.63889508),
        dec: Angle.Degrees(-53.60972400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111537"},
        {"Hipparcos Number", "HIP 62675"},
        {"Smithsonian Astrophysical Observation", "SAO 240304"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.64277509),
        dec: Angle.Degrees(-53.60756764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108789"},
        {"Hipparcos Number", "HIP 61008"},
        {"Smithsonian Astrophysical Observation", "SAO 240003"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.55152300),
        dec: Angle.Degrees(-53.60657522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136301"},
        {"Hipparcos Number", "HIP 75220"},
        {"Geneva Identification System", "GEN# +1.00136301"},
        {"Smithsonian Astrophysical Observation", "SAO 242452"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.55907267),
        dec: Angle.Degrees(-53.60427330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153829"},
        {"Hipparcos Number", "HIP 83558"},
        {"Geneva Identification System", "GEN# +1.00153829"},
        {"Smithsonian Astrophysical Observation", "SAO 244408"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.14935162),
        dec: Angle.Degrees(-53.60402895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144261"},
        {"Hipparcos Number", "HIP 78997"},
        {"Smithsonian Astrophysical Observation", "SAO 243342"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.88300541),
        dec: Angle.Degrees(-53.60328137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92379"},
        {"Hipparcos Number", "HIP 52117"},
        {"Geneva Identification System", "GEN# +1.00092379"},
        {"Renson", "Renson 26610"},
        {"Smithsonian Astrophysical Observation", "SAO 238294"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.71798122),
        dec: Angle.Degrees(-53.60285004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27242"},
        {"Hipparcos Number", "HIP 19854"},
        {"Geneva Identification System", "GEN# +1.00027242"},
        {"Smithsonian Astrophysical Observation", "SAO 233454"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.85565193),
        dec: Angle.Degrees(-53.60230365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56860"},
        {"Hipparcos Number", "HIP 35131"},
        {"Smithsonian Astrophysical Observation", "SAO 235050"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.94416606),
        dec: Angle.Degrees(-53.60209344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111231"},
        {"Hipparcos Number", "HIP 62491"},
        {"Smithsonian Astrophysical Observation", "SAO 240270"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.08951282),
        dec: Angle.Degrees(-53.59462759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126874"},
        {"Hipparcos Number", "HIP 70903"},
        {"Smithsonian Astrophysical Observation", "SAO 241752"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.48189319),
        dec: Angle.Degrees(-53.59462559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108771"},
        {"Hipparcos Number", "HIP 61001"},
        {"Smithsonian Astrophysical Observation", "SAO 240002"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.54071319),
        dec: Angle.Degrees(-53.59441257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78949"},
        {"Hipparcos Number", "HIP 44904"},
        {"Geneva Identification System", "GEN# +1.00078949"},
        {"Smithsonian Astrophysical Observation", "SAO 236660"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.22264458),
        dec: Angle.Degrees(-53.59344032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113952"},
        {"Hipparcos Number", "HIP 64085"},
        {"Smithsonian Astrophysical Observation", "SAO 240585"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.99339473),
        dec: Angle.Degrees(-53.59340011)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7735",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10330"},
        {"Hipparcos Number", "HIP 7735"},
        {"Geneva Identification System", "GEN# +1.00010330"},
        {"Smithsonian Astrophysical Observation", "SAO 232489"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.90586821),
        dec: Angle.Degrees(-53.59189282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99397",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99397"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.62724218),
        dec: Angle.Degrees(-53.59122656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -254.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116326"},
        {"Hipparcos Number", "HIP 65389"},
        {"Smithsonian Astrophysical Observation", "SAO 240799"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.00530412),
        dec: Angle.Degrees(-53.59079934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198721"},
        {"Hipparcos Number", "HIP 103194"},
        {"Smithsonian Astrophysical Observation", "SAO 246781"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.60091445),
        dec: Angle.Degrees(-53.58950042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86933",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160948"},
        {"Hipparcos Number", "HIP 86933"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.43829613),
        dec: Angle.Degrees(-53.58891596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106166"},
        {"Hipparcos Number", "HIP 59579"},
        {"Smithsonian Astrophysical Observation", "SAO 239761"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.26272737),
        dec: Angle.Degrees(-53.58578110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85249"},
        {"Hipparcos Number", "HIP 48143"},
        {"Geneva Identification System", "GEN# +1.00085249"},
        {"Smithsonian Astrophysical Observation", "SAO 237373"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.21691478),
        dec: Angle.Degrees(-53.58539755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141945"},
        {"Hipparcos Number", "HIP 77879"},
        {"Geneva Identification System", "GEN# +1.00141945"},
        {"Smithsonian Astrophysical Observation", "SAO 243097"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.56067374),
        dec: Angle.Degrees(-53.58290758)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36039"},
        {"Hipparcos Number", "HIP 25383"},
        {"Smithsonian Astrophysical Observation", "SAO 233975"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.46017149),
        dec: Angle.Degrees(-53.58279056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41553"},
        {"Hipparcos Number", "HIP 28636"},
        {"Fundamental Katalog 5th Edition", "FK5 4550"},
        {"Smithsonian Astrophysical Observation", "SAO 234271"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.70100857),
        dec: Angle.Degrees(-53.58277086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162845"},
        {"Hipparcos Number", "HIP 87793"},
        {"Smithsonian Astrophysical Observation", "SAO 245124"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.01828751),
        dec: Angle.Degrees(-53.58245411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147438"},
        {"Henry Draper 2", "HD 147439"},
        {"Hipparcos Number", "HIP 80412"},
        {"Geneva Identification System", "GEN# +1.00147438"},
        {"Smithsonian Astrophysical Observation", "SAO 243760"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.19609649),
        dec: Angle.Degrees(-53.58207822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45844"},
        {"Hipparcos Number", "HIP 30685"},
        {"Geneva Identification System", "GEN# +1.00045844"},
        {"Smithsonian Astrophysical Observation", "SAO 234510"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.72387840),
        dec: Angle.Degrees(-53.58199065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108499"},
        {"Hipparcos Number", "HIP 60839"},
        {"Smithsonian Astrophysical Observation", "SAO 239972"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.05512422),
        dec: Angle.Degrees(-53.57691724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6096"},
        {"Hipparcos Number", "HIP 4784"},
        {"Smithsonian Astrophysical Observation", "SAO 232263"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.35648526),
        dec: Angle.Degrees(-53.57624254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45426"},
        {"Hipparcos Number", "HIP 30465"},
        {"Smithsonian Astrophysical Observation", "SAO 234483"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.806,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.07208494),
        dec: Angle.Degrees(-53.57607889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40274"},
        {"Hipparcos Number", "HIP 27942"},
        {"Smithsonian Astrophysical Observation", "SAO 234198"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.69260711),
        dec: Angle.Degrees(-53.57557805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210837"},
        {"Hipparcos Number", "HIP 109813"},
        {"Smithsonian Astrophysical Observation", "SAO 247371"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.63484488),
        dec: Angle.Degrees(-53.57530039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149856"},
        {"Hipparcos Number", "HIP 81613"},
        {"Smithsonian Astrophysical Observation", "SAO 244049"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.03475824),
        dec: Angle.Degrees(-53.57359144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71793",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128822"},
        {"Hipparcos Number", "HIP 71793"},
        {"Smithsonian Astrophysical Observation", "SAO 241902"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.27925095),
        dec: Angle.Degrees(-53.57236615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84889",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84889"},
        {"Smithsonian Astrophysical Observation", "SAO 244649"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.22940618),
        dec: Angle.Degrees(-53.57220303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107898"},
        {"Hipparcos Number", "HIP 60499"},
        {"Smithsonian Astrophysical Observation", "SAO 239920"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.04515862),
        dec: Angle.Degrees(-53.57144981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45923"},
        {"Hipparcos Number", "HIP 30727"},
        {"Geneva Identification System", "GEN# +1.00045923"},
        {"Smithsonian Astrophysical Observation", "SAO 234518"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.83296481),
        dec: Angle.Degrees(-53.56630628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16070",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16070"},
        {"Smithsonian Astrophysical Observation", "SAO 233120"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.74721774),
        dec: Angle.Degrees(-53.56403798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171211"},
        {"Hipparcos Number", "HIP 91214"},
        {"Smithsonian Astrophysical Observation", "SAO 245582"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11362364),
        dec: Angle.Degrees(-53.56356494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44295"},
        {"Hipparcos Number", "HIP 29929"},
        {"Geneva Identification System", "GEN# +1.00044295"},
        {"Renson", "Renson 11780"},
        {"Smithsonian Astrophysical Observation", "SAO 234434"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.52310436),
        dec: Angle.Degrees(-53.55917269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33485"},
        {"Hipparcos Number", "HIP 23857"},
        {"Geneva Identification System", "GEN# +1.00033485"},
        {"Smithsonian Astrophysical Observation", "SAO 233836"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.91251827),
        dec: Angle.Degrees(-53.55747222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 68.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174662"},
        {"Hipparcos Number", "HIP 92795"},
        {"Smithsonian Astrophysical Observation", "SAO 245795"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.62720643),
        dec: Angle.Degrees(-53.55654005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28426",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28426"},
        {"Smithsonian Astrophysical Observation", "SAO 234244"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.04561348),
        dec: Angle.Degrees(-52.17779459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60649"},
        {"Hipparcos Number", "HIP 36682"},
        {"Smithsonian Astrophysical Observation", "SAO 235283"},
    },
    visualMagnitude: 6.98,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.19232051),
        dec: Angle.Degrees(-53.55526247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110271"},
        {"Hipparcos Number", "HIP 61919"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.35500847),
        dec: Angle.Degrees(-53.55296062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211090"},
        {"Hipparcos Number", "HIP 109956"},
        {"Smithsonian Astrophysical Observation", "SAO 247385"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.03902161),
        dec: Angle.Degrees(-53.55293346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85554"},
        {"Hipparcos Number", "HIP 48299"},
        {"Smithsonian Astrophysical Observation", "SAO 237403"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.70795770),
        dec: Angle.Degrees(-53.55239583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95583"},
        {"Hipparcos Number", "HIP 53863"},
        {"Geneva Identification System", "GEN# +1.00095583"},
        {"Smithsonian Astrophysical Observation", "SAO 238695"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.28514175),
        dec: Angle.Degrees(-53.55222941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77907"},
        {"Hipparcos Number", "HIP 44423"},
        {"Celescope Catalog", "CEL 3168"},
        {"Geneva Identification System", "GEN# +1.00077907"},
        {"Smithsonian Astrophysical Observation", "SAO 236542"},
        {"Wilson Evans Batten Catalogue", "WEB 8516"},
    },
    visualMagnitude: 6.39,
    bvColour: -0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.77229936),
        dec: Angle.Degrees(-53.55039508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208489"},
        {"Hipparcos Number", "HIP 108437"},
        {"Smithsonian Astrophysical Observation", "SAO 247246"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.50291984),
        dec: Angle.Degrees(-53.54930959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3245"},
        {"Hipparcos Number", "HIP 2758"},
        {"Smithsonian Astrophysical Observation", "SAO 232098"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.80290756),
        dec: Angle.Degrees(-53.54876872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27632"},
        {"Hipparcos Number", "HIP 20118"},
        {"Smithsonian Astrophysical Observation", "SAO 233479"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.70794926),
        dec: Angle.Degrees(-53.54665330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55278"},
        {"Hipparcos Number", "HIP 34538"},
        {"Smithsonian Astrophysical Observation", "SAO 234966"},
    },
    visualMagnitude: 8.90,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.33810889),
        dec: Angle.Degrees(-53.54493755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8780"},
        {"Hipparcos Number", "HIP 6662"},
        {"Smithsonian Astrophysical Observation", "SAO 232419"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.37055803),
        dec: Angle.Degrees(-53.54471190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68400"},
        {"Hipparcos Number", "HIP 39956"},
        {"Smithsonian Astrophysical Observation", "SAO 235783"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.742,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.38848968),
        dec: Angle.Degrees(-53.54236114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177101"},
        {"Hipparcos Number", "HIP 93800"},
        {"Smithsonian Astrophysical Observation", "SAO 245919"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.54146435),
        dec: Angle.Degrees(-53.54233113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82737"},
        {"Hipparcos Number", "HIP 46789"},
        {"Celescope Catalog", "CEL 3316"},
        {"Geneva Identification System", "GEN# +1.00082737"},
        {"Smithsonian Astrophysical Observation", "SAO 237075"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.01752156),
        dec: Angle.Degrees(-53.54198064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136223"},
        {"Hipparcos Number", "HIP 75173"},
        {"Smithsonian Astrophysical Observation", "SAO 242443"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.41854186),
        dec: Angle.Degrees(-53.54099910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95263"},
        {"Hipparcos Number", "HIP 53685"},
        {"Geneva Identification System", "GEN# +1.00095263"},
        {"Smithsonian Astrophysical Observation", "SAO 238652"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.76905335),
        dec: Angle.Degrees(-53.53927403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37720"},
        {"Hipparcos Number", "HIP 26454"},
        {"Smithsonian Astrophysical Observation", "SAO 234054"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.41488679),
        dec: Angle.Degrees(-53.53542045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62362"},
        {"Hipparcos Number", "HIP 37402"},
        {"Smithsonian Astrophysical Observation", "SAO 235410"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.19546419),
        dec: Angle.Degrees(-53.53257423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40799"},
        {"Hipparcos Number", "HIP 28242"},
        {"Smithsonian Astrophysical Observation", "SAO 234228"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.52055124),
        dec: Angle.Degrees(-53.53244897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97824"},
        {"Hipparcos Number", "HIP 54911"},
        {"Geneva Identification System", "GEN# +1.00097824"},
        {"Smithsonian Astrophysical Observation", "SAO 238895"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.66803293),
        dec: Angle.Degrees(-53.53050560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97768"},
        {"Hipparcos Number", "HIP 54883"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.868,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.56533292),
        dec: Angle.Degrees(-53.52855477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40306"},
        {"Hipparcos Number", "HIP 27975"},
        {"Geneva Identification System", "GEN# +1.00040306"},
        {"Smithsonian Astrophysical Observation", "SAO 234202"},
        {"Wilson Evans Batten Catalogue", "WEB 5483"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.74757267),
        dec: Angle.Degrees(-53.52765419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170193"},
        {"Hipparcos Number", "HIP 90769"},
        {"Smithsonian Astrophysical Observation", "SAO 245523"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.78688018),
        dec: Angle.Degrees(-53.52757164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12241"},
        {"Hipparcos Number", "HIP 9230"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.66034344),
        dec: Angle.Degrees(-53.52749652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86532",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86532"},
        {"New General Catalogue", "NGC 6397 698"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.25252828),
        dec: Angle.Degrees(-53.52741102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55453"},
        {"Hipparcos Number", "HIP 34602"},
        {"Smithsonian Astrophysical Observation", "SAO 234980"},
    },
    visualMagnitude: 8.75,
    bvColour: -0.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.50315021),
        dec: Angle.Degrees(-53.52694577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222289"},
        {"Hipparcos Number", "HIP 116738"},
        {"Smithsonian Astrophysical Observation", "SAO 247965"},
    },
    visualMagnitude: 10.45,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.87350301),
        dec: Angle.Degrees(-53.52506804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74762"},
        {"Hipparcos Number", "HIP 42829"},
        {"Geneva Identification System", "GEN# +3.23910040"},
        {"Smithsonian Astrophysical Observation", "SAO 236223"},
        {"Wilson Evans Batten Catalogue", "WEB 8275"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.89919372),
        dec: Angle.Degrees(-53.52459653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41186",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71318"},
        {"Hipparcos Number", "HIP 41186"},
        {"Smithsonian Astrophysical Observation", "SAO 235946"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.07134337),
        dec: Angle.Degrees(-53.52301043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123130"},
        {"Hipparcos Number", "HIP 68988"},
        {"Geneva Identification System", "GEN# +1.00123130"},
        {"Smithsonian Astrophysical Observation", "SAO 241458"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.86160462),
        dec: Angle.Degrees(-53.52284542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10939"},
        {"Hipparcos Number", "HIP 8241"},
        {"Fundamental Katalog 5th Edition", "FK5 2118"},
        {"Geneva Identification System", "GEN# +1.00010939"},
        {"Smithsonian Astrophysical Observation", "SAO 232520"},
        {"Wilson Evans Batten Catalogue", "WEB 1756"},
    },
    visualMagnitude: 5.04,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.52557865),
        dec: Angle.Degrees(-53.52218065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 126.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184021"},
        {"Hipparcos Number", "HIP 96326"},
        {"Geneva Identification System", "GEN# +1.00184021"},
        {"Smithsonian Astrophysical Observation", "SAO 246172"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.77262801),
        dec: Angle.Degrees(-53.52089365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22506"},
        {"Hipparcos Number", "HIP 16685"},
        {"Smithsonian Astrophysical Observation", "SAO 233168"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.66107216),
        dec: Angle.Degrees(-53.52048189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63069",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112180"},
        {"Hipparcos Number", "HIP 63069"},
        {"Geneva Identification System", "GEN# +1.00112180"},
        {"Smithsonian Astrophysical Observation", "SAO 240380"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.982,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.83839663),
        dec: Angle.Degrees(-53.52003283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168219"},
        {"Hipparcos Number", "HIP 89991"},
        {"Smithsonian Astrophysical Observation", "SAO 245423"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.42687422),
        dec: Angle.Degrees(-53.51835395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82101"},
        {"Hipparcos Number", "HIP 46421"},
        {"Geneva Identification System", "GEN# +1.00082101"},
        {"Smithsonian Astrophysical Observation", "SAO 237005"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.98919371),
        dec: Angle.Degrees(-53.51726777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85791"},
        {"Hipparcos Number", "HIP 48441"},
        {"Geneva Identification System", "GEN# +1.00085791"},
        {"Smithsonian Astrophysical Observation", "SAO 237437"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.15458043),
        dec: Angle.Degrees(-53.51642346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12976",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12976"},
        {"Smithsonian Astrophysical Observation", "SAO 232889"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.72559767),
        dec: Angle.Degrees(-53.51626680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128013"},
        {"Hipparcos Number", "HIP 71423"},
        {"Smithsonian Astrophysical Observation", "SAO 241835"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.08505281),
        dec: Angle.Degrees(-53.51526870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -113.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44503",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44503"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.99995310),
        dec: Angle.Degrees(-53.51350874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127178"},
        {"Hipparcos Number", "HIP 71037"},
        {"Smithsonian Astrophysical Observation", "SAO 241767"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.92359770),
        dec: Angle.Degrees(-53.51274221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124454"},
        {"Hipparcos Number", "HIP 69655"},
        {"Geneva Identification System", "GEN# +1.00124454"},
        {"Smithsonian Astrophysical Observation", "SAO 241569"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.83886209),
        dec: Angle.Degrees(-53.50992981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58591"},
        {"Hipparcos Number", "HIP 35833"},
        {"Smithsonian Astrophysical Observation", "SAO 235159"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.84281316),
        dec: Angle.Degrees(-53.50818991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176278"},
        {"Hipparcos Number", "HIP 93486"},
        {"Geneva Identification System", "GEN# +1.00176278"},
        {"Smithsonian Astrophysical Observation", "SAO 245874"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.58551253),
        dec: Angle.Degrees(-53.50783166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103775"},
        {"Hipparcos Number", "HIP 58255"},
        {"Smithsonian Astrophysical Observation", "SAO 239513"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.21372711),
        dec: Angle.Degrees(-53.50709831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110634"},
        {"Hipparcos Number", "HIP 62134"},
        {"Geneva Identification System", "GEN# +1.00110634"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.00819201),
        dec: Angle.Degrees(-53.50569430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79625"},
        {"Hipparcos Number", "HIP 45235"},
        {"Celescope Catalog", "CEL 3226"},
        {"Geneva Identification System", "GEN# +1.00079625"},
        {"Smithsonian Astrophysical Observation", "SAO 236721"},
    },
    visualMagnitude: 7.27,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.28626156),
        dec: Angle.Degrees(-53.50482611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55097",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98149"},
        {"Hipparcos Number", "HIP 55097"},
        {"Smithsonian Astrophysical Observation", "SAO 238927"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.21052671),
        dec: Angle.Degrees(-53.50277877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215369"},
        {"Hipparcos Number", "HIP 112374"},
        {"Fundamental Katalog 5th Edition", "FK5 3821"},
        {"Geneva Identification System", "GEN# +1.00215369"},
        {"Smithsonian Astrophysical Observation", "SAO 247570"},
        {"Wilson Evans Batten Catalogue", "WEB 20044"},
    },
    visualMagnitude: 4.84,
    bvColour: 1.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.40771690),
        dec: Angle.Degrees(-53.50016316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157799"},
        {"Hipparcos Number", "HIP 85499"},
        {"Smithsonian Astrophysical Observation", "SAO 244768"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.09301461),
        dec: Angle.Degrees(-53.49991442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104776"},
        {"Hipparcos Number", "HIP 58820"},
        {"Fundamental Katalog 5th Edition", "FK5 5063"},
        {"Geneva Identification System", "GEN# +1.00104776"},
        {"Smithsonian Astrophysical Observation", "SAO 239625"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.96756473),
        dec: Angle.Degrees(-53.49819909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195428"},
        {"Hipparcos Number", "HIP 101451"},
        {"Smithsonian Astrophysical Observation", "SAO 246631"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.41387988),
        dec: Angle.Degrees(-53.49773110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13301"},
        {"Hipparcos Number", "HIP 9968"},
        {"Geneva Identification System", "GEN# +1.00013301"},
        {"Smithsonian Astrophysical Observation", "SAO 232646"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.08852626),
        dec: Angle.Degrees(-53.49115075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132063"},
        {"Hipparcos Number", "HIP 73337"},
        {"Smithsonian Astrophysical Observation", "SAO 242142"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.79800698),
        dec: Angle.Degrees(-53.49019258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132318"},
        {"Hipparcos Number", "HIP 73441"},
        {"Smithsonian Astrophysical Observation", "SAO 242166"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.12087042),
        dec: Angle.Degrees(-53.48935046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167368"},
        {"Hipparcos Number", "HIP 89666"},
        {"Smithsonian Astrophysical Observation", "SAO 245381"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.154,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.46704807),
        dec: Angle.Degrees(-53.48824931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76411",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138756"},
        {"Hipparcos Number", "HIP 76411"},
        {"Smithsonian Astrophysical Observation", "SAO 242751"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.10020054),
        dec: Angle.Degrees(-53.48712144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98257"},
        {"Hipparcos Number", "HIP 55160"},
        {"Smithsonian Astrophysical Observation", "SAO 238941"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.39842132),
        dec: Angle.Degrees(-53.48587068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142064"},
        {"Hipparcos Number", "HIP 77932"},
        {"Smithsonian Astrophysical Observation", "SAO 243109"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.73437473),
        dec: Angle.Degrees(-53.48382694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80091"},
        {"Hipparcos Number", "HIP 45449"},
        {"Smithsonian Astrophysical Observation", "SAO 236778"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.93851503),
        dec: Angle.Degrees(-53.48302844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36008"},
        {"Hipparcos Number", "HIP 25376"},
        {"Geneva Identification System", "GEN# +1.00036008"},
        {"Smithsonian Astrophysical Observation", "SAO 233974"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.42699998),
        dec: Angle.Degrees(-53.48090248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2882"},
        {"Hipparcos Number", "HIP 2504"},
        {"Geneva Identification System", "GEN# +1.00002882"},
        {"Smithsonian Astrophysical Observation", "SAO 232079"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.817,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.93498103),
        dec: Angle.Degrees(-53.48017332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158243"},
        {"Hipparcos Number", "HIP 85729"},
        {"Geneva Identification System", "GEN# +1.00158243"},
        {"Smithsonian Astrophysical Observation", "SAO 244806"},
        {"Wilson Evans Batten Catalogue", "WEB 14468"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.77973232),
        dec: Angle.Degrees(-53.47865499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98558"},
        {"Hipparcos Number", "HIP 55329"},
        {"Smithsonian Astrophysical Observation", "SAO 238967"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.95718972),
        dec: Angle.Degrees(-53.47620914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65066",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115760"},
        {"Hipparcos Number", "HIP 65066"},
        {"Smithsonian Astrophysical Observation", "SAO 240753"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.05406682),
        dec: Angle.Degrees(-53.47343475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94697"},
    },
    visualMagnitude: 10.01,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.04500256),
        dec: Angle.Degrees(-53.46930791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 175.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66657",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118716"},
        {"Hipparcos Number", "HIP 66657"},
        {"Celescope Catalog", "CEL 4275"},
        {"Fundamental Katalog 5th Edition", "FK5 504"},
        {"Geneva Identification System", "GEN# +1.00118716"},
        {"Smithsonian Astrophysical Observation", "SAO 241047"},
        {"Wilson Evans Batten Catalogue", "WEB 11756"},
    },
    visualMagnitude: 2.29,
    bvColour: -0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.97196962),
        dec: Angle.Degrees(-53.46636269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219708"},
        {"Hipparcos Number", "HIP 115084"},
        {"Smithsonian Astrophysical Observation", "SAO 247823"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.64056859),
        dec: Angle.Degrees(-53.46507158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126150"},
        {"Hipparcos Number", "HIP 70515"},
        {"Smithsonian Astrophysical Observation", "SAO 241704"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.36828464),
        dec: Angle.Degrees(-53.46491646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147421"},
        {"Hipparcos Number", "HIP 80408"},
        {"Geneva Identification System", "GEN# +1.00147421"},
        {"Smithsonian Astrophysical Observation", "SAO 243759"},
        {"Wilson Evans Batten Catalogue", "WEB 13606"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.18906568),
        dec: Angle.Degrees(-53.46424079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155298"},
        {"Hipparcos Number", "HIP 84268"},
        {"Smithsonian Astrophysical Observation", "SAO 244532"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.38799621),
        dec: Angle.Degrees(-53.46241872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39336"},
        {"Hipparcos Number", "HIP 27463"},
        {"Geneva Identification System", "GEN# +1.00039336"},
        {"Smithsonian Astrophysical Observation", "SAO 234147"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.882,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.23471290),
        dec: Angle.Degrees(-53.46239469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31203"},
        {"Hipparcos Number", "HIP 22531"},
        {"Geneva Identification System", "GEN# +1.00031203"},
        {"Smithsonian Astrophysical Observation", "SAO 233709"},
        {"Wilson Evans Batten Catalogue", "WEB 4349"},
    },
    visualMagnitude: 5.58,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.73077622),
        dec: Angle.Degrees(-53.46172112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 87.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31204"},
        {"Hipparcos Number", "HIP 22534"},
        {"Geneva Identification System", "GEN# +1.00031204"},
        {"Smithsonian Astrophysical Observation", "SAO 233710"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.73574565),
        dec: Angle.Degrees(-53.45990399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113902"},
        {"Hipparcos Number", "HIP 64053"},
        {"Celescope Catalog", "CEL 4202"},
        {"Fundamental Katalog 5th Edition", "FK5 1340"},
        {"Geneva Identification System", "GEN# +1.00113902"},
        {"Smithsonian Astrophysical Observation", "SAO 240573"},
        {"Wilson Evans Batten Catalogue", "WEB 11320"},
    },
    visualMagnitude: 5.70,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.90966874),
        dec: Angle.Degrees(-53.45971466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92532"},
        {"Hipparcos Number", "HIP 52208"},
        {"Geneva Identification System", "GEN# +1.00092532"},
        {"Smithsonian Astrophysical Observation", "SAO 238322"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.99548439),
        dec: Angle.Degrees(-53.45859084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28897"},
        {"Hipparcos Number", "HIP 21007"},
        {"Smithsonian Astrophysical Observation", "SAO 233544"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.56979822),
        dec: Angle.Degrees(-53.45467082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70530",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126198"},
        {"Hipparcos Number", "HIP 70530"},
        {"Geneva Identification System", "GEN# +1.00126198"},
        {"Renson", "Renson 35970"},
        {"Smithsonian Astrophysical Observation", "SAO 241708"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.43293263),
        dec: Angle.Degrees(-53.45416327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48292"},
        {"Hipparcos Number", "HIP 31871"},
        {"Smithsonian Astrophysical Observation", "SAO 234644"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.93047326),
        dec: Angle.Degrees(-53.45135316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202730"},
        {"Hipparcos Number", "HIP 105319"},
        {"Geneva Identification System", "GEN# +1.00202730"},
        {"Renson", "Renson 56500"},
        {"Smithsonian Astrophysical Observation", "SAO 246965"},
        {"Wilson Evans Batten Catalogue", "WEB 19127"},
    },
    visualMagnitude: 4.39,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.96618253),
        dec: Angle.Degrees(-53.44926434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 107.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88772"},
        {"Hipparcos Number", "HIP 50041"},
        {"Smithsonian Astrophysical Observation", "SAO 237795"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.24972156),
        dec: Angle.Degrees(-53.44894878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130378"},
        {"Hipparcos Number", "HIP 72532"},
        {"Geneva Identification System", "GEN# +1.00130378"},
        {"Smithsonian Astrophysical Observation", "SAO 242040"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.44552181),
        dec: Angle.Degrees(-53.44812448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137502"},
        {"Hipparcos Number", "HIP 75781"},
        {"Geneva Identification System", "GEN# +1.00137502"},
        {"Smithsonian Astrophysical Observation", "SAO 242581"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.21261257),
        dec: Angle.Degrees(-53.44665117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104022"},
        {"Hipparcos Number", "HIP 58415"},
        {"Geneva Identification System", "GEN# +1.00104022"},
        {"Smithsonian Astrophysical Observation", "SAO 239541"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.66128380),
        dec: Angle.Degrees(-53.44501323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111268"},
        {"Hipparcos Number", "HIP 62514"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.16783482),
        dec: Angle.Degrees(-53.44497575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 397"},
        {"Hipparcos Number", "HIP 685"},
        {"Smithsonian Astrophysical Observation", "SAO 231941"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.11205680),
        dec: Angle.Degrees(-53.44318788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199529"},
        {"Hipparcos Number", "HIP 103643"},
        {"Smithsonian Astrophysical Observation", "SAO 246819"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.98966240),
        dec: Angle.Degrees(-53.44141041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74071"},
        {"Hipparcos Number", "HIP 42459"},
        {"Celescope Catalog", "CEL 2750"},
        {"Geneva Identification System", "GEN# +3.23910013"},
        {"Smithsonian Astrophysical Observation", "SAO 236151"},
        {"Wilson Evans Batten Catalogue", "WEB 8170"},
    },
    visualMagnitude: 5.45,
    bvColour: -0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.84944512),
        dec: Angle.Degrees(-53.43982462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10241B"},
        {"Hipparcos Number", "HIP 7674"},
        {"Smithsonian Astrophysical Observation", "SAO 232484"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.70699477),
        dec: Angle.Degrees(-53.43950586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10241"},
        {"Hipparcos Number", "HIP 7673"},
        {"Geneva Identification System", "GEN# +1.00010241J"},
        {"Smithsonian Astrophysical Observation", "SAO 232483"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.70232210),
        dec: Angle.Degrees(-53.43878433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69191",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123569"},
        {"Hipparcos Number", "HIP 69191"},
        {"Geneva Identification System", "GEN# +1.00123569"},
        {"Smithsonian Astrophysical Observation", "SAO 241496"},
        {"Wilson Evans Batten Catalogue", "WEB 12075"},
    },
    visualMagnitude: 4.74,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.47898599),
        dec: Angle.Degrees(-53.43872584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -144.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140355"},
        {"Hipparcos Number", "HIP 77182"},
        {"Smithsonian Astrophysical Observation", "SAO 242928"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.40261203),
        dec: Angle.Degrees(-53.43782411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77758",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141646"},
        {"Hipparcos Number", "HIP 77758"},
        {"Smithsonian Astrophysical Observation", "SAO 243068"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.16022373),
        dec: Angle.Degrees(-53.43748824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174745"},
        {"Hipparcos Number", "HIP 92840"},
        {"Geneva Identification System", "GEN# +1.00174745"},
        {"Smithsonian Astrophysical Observation", "SAO 245798"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.74535773),
        dec: Angle.Degrees(-53.43702667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111554"},
        {"Hipparcos Number", "HIP 62679"},
        {"Smithsonian Astrophysical Observation", "SAO 240308"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.65868622),
        dec: Angle.Degrees(-53.43563827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84716"},
        {"Hipparcos Number", "HIP 47858"},
        {"Geneva Identification System", "GEN# +1.00084716"},
        {"Smithsonian Astrophysical Observation", "SAO 237303"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31744949),
        dec: Angle.Degrees(-53.43465809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81261"},
        {"Hipparcos Number", "HIP 45981"},
        {"Renson", "Renson 23060"},
        {"Smithsonian Astrophysical Observation", "SAO 236900"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.65341917),
        dec: Angle.Degrees(-53.43377116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147746"},
        {"Hipparcos Number", "HIP 80529"},
        {"Smithsonian Astrophysical Observation", "SAO 243799"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.59439881),
        dec: Angle.Degrees(-53.43233611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66182",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66182"},
    },
    visualMagnitude: 12.96,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.46586742),
        dec: Angle.Degrees(-53.43178743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 219.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -150.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30526"},
        {"Hipparcos Number", "HIP 22116"},
        {"Smithsonian Astrophysical Observation", "SAO 233669"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.39641224),
        dec: Angle.Degrees(-53.43091717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117809"},
        {"Hipparcos Number", "HIP 66183"},
        {"Geneva Identification System", "GEN# +1.00117809"},
        {"Smithsonian Astrophysical Observation", "SAO 240946"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.47050177),
        dec: Angle.Degrees(-53.42921332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35782"},
        {"Hipparcos Number", "HIP 25263"},
        {"Smithsonian Astrophysical Observation", "SAO 233962"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.04065313),
        dec: Angle.Degrees(-53.42878101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158851"},
        {"Hipparcos Number", "HIP 85991"},
        {"Smithsonian Astrophysical Observation", "SAO 244857"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.62383716),
        dec: Angle.Degrees(-53.42747228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168563"},
        {"Hipparcos Number", "HIP 90108"},
        {"Geneva Identification System", "GEN# +1.00168563"},
        {"Smithsonian Astrophysical Observation", "SAO 245437"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.82436447),
        dec: Angle.Degrees(-53.42664505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40665"},
        {"Hipparcos Number", "HIP 28180"},
        {"Geneva Identification System", "GEN# +1.00040665"},
        {"Smithsonian Astrophysical Observation", "SAO 234224"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.30985167),
        dec: Angle.Degrees(-53.42569340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162361"},
        {"Hipparcos Number", "HIP 87602"},
        {"Smithsonian Astrophysical Observation", "SAO 245099"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.41992410),
        dec: Angle.Degrees(-53.42495610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103368",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103368"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.13754559),
        dec: Angle.Degrees(-53.42377207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 280.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222595"},
        {"Hipparcos Number", "HIP 116937"},
        {"Geneva Identification System", "GEN# +1.00222595"},
        {"Smithsonian Astrophysical Observation", "SAO 247988"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.55198471),
        dec: Angle.Degrees(-53.42334105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219825"},
        {"Hipparcos Number", "HIP 115139"},
        {"Smithsonian Astrophysical Observation", "SAO 247829"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.84733416),
        dec: Angle.Degrees(-53.41984412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221120"},
        {"Hipparcos Number", "HIP 115961"},
        {"Smithsonian Astrophysical Observation", "SAO 247903"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.41093299),
        dec: Angle.Degrees(-53.41893489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40643"},
        {"Hipparcos Number", "HIP 28173"},
        {"Smithsonian Astrophysical Observation", "SAO 234222"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28805864),
        dec: Angle.Degrees(-53.41731224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39607"},
        {"Hipparcos Number", "HIP 27599"},
        {"Geneva Identification System", "GEN# +1.00039607"},
        {"Smithsonian Astrophysical Observation", "SAO 234165"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.65592792),
        dec: Angle.Degrees(-53.41719690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114211"},
        {"Hipparcos Number", "HIP 64233"},
        {"Smithsonian Astrophysical Observation", "SAO 240607"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.47824670),
        dec: Angle.Degrees(-53.41241134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -146.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26833"},
        {"Hipparcos Number", "HIP 19597"},
        {"Fundamental Katalog 5th Edition", "FK5 2303"},
        {"Smithsonian Astrophysical Observation", "SAO 233431"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.99539546),
        dec: Angle.Degrees(-53.41207607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81638"},
        {"Hipparcos Number", "HIP 46172"},
        {"Celescope Catalog", "CEL 3286"},
        {"Geneva Identification System", "GEN# +1.00081638"},
        {"Smithsonian Astrophysical Observation", "SAO 236943"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.23475929),
        dec: Angle.Degrees(-53.41081412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16561",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16561"},
        {"Smithsonian Astrophysical Observation", "SAO 233156"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.30577957),
        dec: Angle.Degrees(-53.41046489)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132181"},
        {"Hipparcos Number", "HIP 73381"},
        {"Geneva Identification System", "GEN# +1.00132181"},
    },
    visualMagnitude: 9.00,
    bvColour: 2.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.93333516),
        dec: Angle.Degrees(-53.40780235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213883"},
        {"Hipparcos Number", "HIP 111514"},
        {"Smithsonian Astrophysical Observation", "SAO 247503"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.90139420),
        dec: Angle.Degrees(-53.40670507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103839"},
    },
    visualMagnitude: 12.60,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.62037623),
        dec: Angle.Degrees(-53.40656757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85938"},
        {"Hipparcos Number", "HIP 48514"},
        {"Geneva Identification System", "GEN# +1.00085938"},
        {"Smithsonian Astrophysical Observation", "SAO 237463"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.40546210),
        dec: Angle.Degrees(-53.40645833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31261"},
        {"Hipparcos Number", "HIP 22562"},
        {"Geneva Identification System", "GEN# +1.00031261"},
        {"Smithsonian Astrophysical Observation", "SAO 233713"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.83596730),
        dec: Angle.Degrees(-53.40608216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 84.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28574"},
        {"Hipparcos Number", "HIP 20799"},
        {"Renson", "Renson 7350"},
        {"Smithsonian Astrophysical Observation", "SAO 233528"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.85051250),
        dec: Angle.Degrees(-53.40434919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125255"},
        {"Hipparcos Number", "HIP 70039"},
        {"Smithsonian Astrophysical Observation", "SAO 241638"},
    },
    visualMagnitude: 9.13,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.97414109),
        dec: Angle.Degrees(-53.40340886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113419"},
        {"Hipparcos Number", "HIP 63771"},
        {"Smithsonian Astrophysical Observation", "SAO 240518"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.07226711),
        dec: Angle.Degrees(-53.39468724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196478"},
        {"Hipparcos Number", "HIP 101975"},
        {"Geneva Identification System", "GEN# +1.00196478"},
        {"Smithsonian Astrophysical Observation", "SAO 246681"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.302,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.98241274),
        dec: Angle.Degrees(-53.39275737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14208"},
        {"Hipparcos Number", "HIP 10572"},
        {"Smithsonian Astrophysical Observation", "SAO 232693"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.02560835),
        dec: Angle.Degrees(-53.39177360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154608"},
        {"Hipparcos Number", "HIP 83934"},
        {"Geneva Identification System", "GEN# +1.00154608"},
        {"Smithsonian Astrophysical Observation", "SAO 244467"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.34400621),
        dec: Angle.Degrees(-53.39154969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139616"},
        {"Hipparcos Number", "HIP 76849"},
        {"Smithsonian Astrophysical Observation", "SAO 242835"},
    },
    visualMagnitude: 6.92,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.37767810),
        dec: Angle.Degrees(-53.39125204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107284"},
        {"Hipparcos Number", "HIP 60163"},
        {"Smithsonian Astrophysical Observation", "SAO 239854"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.06302736),
        dec: Angle.Degrees(-53.38835827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222271"},
        {"Hipparcos Number", "HIP 116729"},
        {"Smithsonian Astrophysical Observation", "SAO 247963"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.84391657),
        dec: Angle.Degrees(-53.38718670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180134"},
        {"Hipparcos Number", "HIP 94858"},
        {"Geneva Identification System", "GEN# +1.00180134"},
        {"Smithsonian Astrophysical Observation", "SAO 246017"},
        {"Wilson Evans Batten Catalogue", "WEB 16556"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.54065361),
        dec: Angle.Degrees(-53.38688837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156239"},
        {"Hipparcos Number", "HIP 84737"},
        {"Smithsonian Astrophysical Observation", "SAO 244621"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.83241217),
        dec: Angle.Degrees(-53.38533680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213304"},
        {"Hipparcos Number", "HIP 111190"},
        {"Smithsonian Astrophysical Observation", "SAO 247471"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.88856517),
        dec: Angle.Degrees(-53.38249153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107736"},
        {"Hipparcos Number", "HIP 60397"},
        {"Geneva Identification System", "GEN# +1.00107736"},
        {"Renson", "Renson 31240"},
        {"Smithsonian Astrophysical Observation", "SAO 239904"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.75055039),
        dec: Angle.Degrees(-53.38202663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81848"},
        {"Hipparcos Number", "HIP 46283"},
        {"Celescope Catalog", "CEL 3294"},
        {"Geneva Identification System", "GEN# +1.00081848"},
        {"Smithsonian Astrophysical Observation", "SAO 236972"},
        {"Wilson Evans Batten Catalogue", "WEB 8754"},
    },
    visualMagnitude: 5.09,
    bvColour: -0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.57490643),
        dec: Angle.Degrees(-53.37893587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43638"},
        {"Hipparcos Number", "HIP 29598"},
        {"Smithsonian Astrophysical Observation", "SAO 234393"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.55838018),
        dec: Angle.Degrees(-53.37753016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27032",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27032"},
        {"Smithsonian Astrophysical Observation", "SAO 234110"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.00174848),
        dec: Angle.Degrees(-53.37740251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155066"},
        {"Hipparcos Number", "HIP 84148"},
        {"Fundamental Katalog 5th Edition", "FK5 5518"},
        {"Smithsonian Astrophysical Observation", "SAO 244511"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.06099006),
        dec: Angle.Degrees(-53.37608845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92642"},
        {"Hipparcos Number", "HIP 52269"},
        {"Smithsonian Astrophysical Observation", "SAO 238338"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.20798270),
        dec: Angle.Degrees(-53.37569185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19394",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19394"},
        {"Cincinnati Publication", "Ci 20 284"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.31102050),
        dec: Angle.Degrees(-53.37511256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1043.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 581.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109549"},
        {"Hipparcos Number", "HIP 61484"},
        {"Geneva Identification System", "GEN# +1.00109549"},
        {"Smithsonian Astrophysical Observation", "SAO 240083"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.96828534),
        dec: Angle.Degrees(-53.37470894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137866"},
        {"Hipparcos Number", "HIP 75956"},
        {"Smithsonian Astrophysical Observation", "SAO 242636"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.70075210),
        dec: Angle.Degrees(-53.37425663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120908"},
        {"Hipparcos Number", "HIP 67836"},
        {"Celescope Catalog", "CEL 4284"},
        {"Geneva Identification System", "GEN# +1.00120908"},
        {"Smithsonian Astrophysical Observation", "SAO 241262"},
        {"Wilson Evans Batten Catalogue", "WEB 11925"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.42962680),
        dec: Angle.Degrees(-53.37328052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156260"},
        {"Hipparcos Number", "HIP 84746"},
        {"Geneva Identification System", "GEN# +1.00156260"},
        {"Smithsonian Astrophysical Observation", "SAO 244624"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.85214519),
        dec: Angle.Degrees(-53.37308355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149714"},
        {"Hipparcos Number", "HIP 81546"},
        {"Smithsonian Astrophysical Observation", "SAO 244029"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.83012854),
        dec: Angle.Degrees(-53.37269214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98922"},
        {"Hipparcos Number", "HIP 55537"},
        {"Smithsonian Astrophysical Observation", "SAO 239007"},
    },
    visualMagnitude: 6.77,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.63201268),
        dec: Angle.Degrees(-53.36984937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101082"},
        {"Hipparcos Number", "HIP 56707"},
        {"Smithsonian Astrophysical Observation", "SAO 239234"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.40119953),
        dec: Angle.Degrees(-53.36949051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9438"},
        {"Hipparcos Number", "HIP 7111"},
        {"Geneva Identification System", "GEN# +1.00009438"},
        {"Smithsonian Astrophysical Observation", "SAO 232450"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.89706074),
        dec: Angle.Degrees(-53.36947814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5107"},
        {"Hipparcos Number", "HIP 4076"},
        {"Smithsonian Astrophysical Observation", "SAO 232213"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.07045079),
        dec: Angle.Degrees(-53.36902897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82812"},
        {"Hipparcos Number", "HIP 46836"},
        {"Celescope Catalog", "CEL 3318"},
        {"Geneva Identification System", "GEN# +1.00082812J"},
        {"Smithsonian Astrophysical Observation", "SAO 237084"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.16276233),
        dec: Angle.Degrees(-53.36868404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179391"},
        {"Hipparcos Number", "HIP 94611"},
        {"Geneva Identification System", "GEN# +1.00179391"},
        {"Smithsonian Astrophysical Observation", "SAO 245991"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.80428637),
        dec: Angle.Degrees(-53.36840852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130572"},
        {"Hipparcos Number", "HIP 72617"},
        {"Geneva Identification System", "GEN# +1.00130572"},
        {"Smithsonian Astrophysical Observation", "SAO 242061"},
    },
    visualMagnitude: 6.56,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71158366),
        dec: Angle.Degrees(-53.36824067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221314"},
        {"Hipparcos Number", "HIP 116100"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.87116795),
        dec: Angle.Degrees(-53.36752108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9121"},
        {"Hipparcos Number", "HIP 6883"},
        {"Renson", "Renson 2200"},
        {"Smithsonian Astrophysical Observation", "SAO 232430"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.16514753),
        dec: Angle.Degrees(-53.36512295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87152"},
        {"Hipparcos Number", "HIP 49137"},
        {"Celescope Catalog", "CEL 3423"},
        {"Geneva Identification System", "GEN# +1.00087152"},
        {"Smithsonian Astrophysical Observation", "SAO 237612"},
        {"Wilson Evans Batten Catalogue", "WEB 9105"},
    },
    visualMagnitude: 6.20,
    bvColour: -0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.41968900),
        dec: Angle.Degrees(-53.36411581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81565",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149768"},
        {"Hipparcos Number", "HIP 81565"},
        {"Geneva Identification System", "GEN# +1.00149768"},
        {"Smithsonian Astrophysical Observation", "SAO 244036"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.862,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.87992155),
        dec: Angle.Degrees(-53.36155308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52787"},
        {"Hipparcos Number", "HIP 33659"},
        {"Smithsonian Astrophysical Observation", "SAO 234842"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.88982029),
        dec: Angle.Degrees(-53.36119639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 54.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183356"},
        {"Hipparcos Number", "HIP 96056"},
        {"Smithsonian Astrophysical Observation", "SAO 246142"},
    },
    visualMagnitude: 8.45,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.96533979),
        dec: Angle.Degrees(-53.36041345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133119"},
        {"Hipparcos Number", "HIP 73780"},
        {"Geneva Identification System", "GEN# +1.00133119"},
        {"Smithsonian Astrophysical Observation", "SAO 242210"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.21025475),
        dec: Angle.Degrees(-53.35989190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85061"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.75978121),
        dec: Angle.Degrees(-52.15322898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115916"},
        {"Hipparcos Number", "HIP 65167"},
        {"Smithsonian Astrophysical Observation", "SAO 240772"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.31394648),
        dec: Angle.Degrees(-53.35719852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86168"},
    },
    visualMagnitude: 11.47,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.13136181),
        dec: Angle.Degrees(-53.35659390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209954"},
        {"Hipparcos Number", "HIP 109287"},
        {"Smithsonian Astrophysical Observation", "SAO 247323"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.10265037),
        dec: Angle.Degrees(-53.35624477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81562",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 81562"},
    },
    visualMagnitude: 12.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.87313416),
        dec: Angle.Degrees(-53.35611062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159018"},
        {"Hipparcos Number", "HIP 86064"},
        {"Geneva Identification System", "GEN# +1.00159018"},
        {"Smithsonian Astrophysical Observation", "SAO 244870"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.83296419),
        dec: Angle.Degrees(-53.35288403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6710"},
        {"Hipparcos Number", "HIP 5235"},
        {"Smithsonian Astrophysical Observation", "SAO 232298"},
    },
    visualMagnitude: 9.73,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.73655912),
        dec: Angle.Degrees(-53.35284883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93978"},
    },
    visualMagnitude: 12.90,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.02067337),
        dec: Angle.Degrees(-53.35115260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203011"},
        {"Hipparcos Number", "HIP 105450"},
        {"Geneva Identification System", "GEN# +1.00203011"},
        {"Smithsonian Astrophysical Observation", "SAO 246987"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.37539490),
        dec: Angle.Degrees(-53.35073442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109196"},
        {"Hipparcos Number", "HIP 61262"},
        {"Smithsonian Astrophysical Observation", "SAO 240053"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.32696269),
        dec: Angle.Degrees(-53.35070162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218570"},
        {"Hipparcos Number", "HIP 114362"},
        {"Smithsonian Astrophysical Observation", "SAO 247759"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.42339774),
        dec: Angle.Degrees(-53.35029243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72281"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.71811785),
        dec: Angle.Degrees(-53.34941086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205082"},
        {"Hipparcos Number", "HIP 106547"},
        {"Smithsonian Astrophysical Observation", "SAO 247092"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.68369165),
        dec: Angle.Degrees(-53.34853437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99909"},
        {"Hipparcos Number", "HIP 56041"},
        {"Smithsonian Astrophysical Observation", "SAO 239107"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.28526347),
        dec: Angle.Degrees(-53.34780588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162894"},
        {"Hipparcos Number", "HIP 87814"},
        {"Smithsonian Astrophysical Observation", "SAO 245126"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.08011374),
        dec: Angle.Degrees(-53.34493561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130809"},
        {"Hipparcos Number", "HIP 72727"},
        {"Geneva Identification System", "GEN# +1.00130809"},
        {"Smithsonian Astrophysical Observation", "SAO 242072"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.04065029),
        dec: Angle.Degrees(-53.34451838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83002"},
        {"Hipparcos Number", "HIP 46908"},
        {"Celescope Catalog", "CEL 3327"},
        {"Renson", "Renson 23670"},
        {"Smithsonian Astrophysical Observation", "SAO 237100"},
    },
    visualMagnitude: 9.06,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.40184740),
        dec: Angle.Degrees(-53.34428710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91140"},
        {"Hipparcos Number", "HIP 51422"},
        {"Smithsonian Astrophysical Observation", "SAO 238122"},
    },
    visualMagnitude: 8.01,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.52984609),
        dec: Angle.Degrees(-53.34358746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44108",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77233"},
        {"Hipparcos Number", "HIP 44108"},
        {"Geneva Identification System", "GEN# +1.00077233"},
        {"Smithsonian Astrophysical Observation", "SAO 236464"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.75752900),
        dec: Angle.Degrees(-53.34349428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100179"},
    },
    visualMagnitude: 11.56,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79672749),
        dec: Angle.Degrees(-53.34274809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207453"},
        {"Hipparcos Number", "HIP 107831"},
        {"Smithsonian Astrophysical Observation", "SAO 247203"},
    },
    visualMagnitude: 10.21,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.68228936),
        dec: Angle.Degrees(-53.34120891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79625"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.72813957),
        dec: Angle.Degrees(-53.33842304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100541"},
        {"Hipparcos Number", "HIP 56406"},
        {"Fundamental Katalog 5th Edition", "FK5 5019"},
        {"Geneva Identification System", "GEN# +1.00100541"},
        {"Smithsonian Astrophysical Observation", "SAO 239171"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.45986767),
        dec: Angle.Degrees(-53.33733330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10834"},
        {"Hipparcos Number", "HIP 8150"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.19812094),
        dec: Angle.Degrees(-53.33612176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192779"},
        {"Hipparcos Number", "HIP 100175"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.79195258),
        dec: Angle.Degrees(-53.33588112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38336",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38336"},
    },
    visualMagnitude: 12.08,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.78765791),
        dec: Angle.Degrees(-53.33419972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63666"},
        {"Hipparcos Number", "HIP 38007"},
        {"Celescope Catalog", "CEL 2041"},
        {"Geneva Identification System", "GEN# +1.00063666"},
        {"Smithsonian Astrophysical Observation", "SAO 235515"},
    },
    visualMagnitude: 7.60,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.84828959),
        dec: Angle.Degrees(-53.33247076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4709"},
        {"Hipparcos Number", "HIP 3776"},
        {"Smithsonian Astrophysical Observation", "SAO 232189"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.13666700),
        dec: Angle.Degrees(-53.33246585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93790"},
        {"Hipparcos Number", "HIP 52872"},
        {"Smithsonian Astrophysical Observation", "SAO 238503"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.18610308),
        dec: Angle.Degrees(-53.32792041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124649"},
        {"Hipparcos Number", "HIP 69730"},
        {"Smithsonian Astrophysical Observation", "SAO 241582"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.659,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.09222277),
        dec: Angle.Degrees(-53.32677896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181650"},
        {"Hipparcos Number", "HIP 95360"},
        {"Geneva Identification System", "GEN# +1.00181650"},
        {"Smithsonian Astrophysical Observation", "SAO 246067"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.01043204),
        dec: Angle.Degrees(-53.32614650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161672"},
        {"Hipparcos Number", "HIP 87260"},
        {"Geneva Identification System", "GEN# +1.00161672"},
        {"Smithsonian Astrophysical Observation", "SAO 245059"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.46396367),
        dec: Angle.Degrees(-53.32610594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76187"},
        {"Hipparcos Number", "HIP 43568"},
        {"Celescope Catalog", "CEL 3022"},
        {"Geneva Identification System", "GEN# +1.00076187"},
        {"Smithsonian Astrophysical Observation", "SAO 236353"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.09862914),
        dec: Angle.Degrees(-53.32584451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178533"},
        {"Hipparcos Number", "HIP 94310"},
        {"Smithsonian Astrophysical Observation", "SAO 245963"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.94066310),
        dec: Angle.Degrees(-53.32276602)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66865"},
        {"Hipparcos Number", "HIP 39368"},
        {"Geneva Identification System", "GEN# +1.00066865"},
        {"Smithsonian Astrophysical Observation", "SAO 235712"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.72424473),
        dec: Angle.Degrees(-53.32080752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16990"},
        {"Hipparcos Number", "HIP 12546"},
        {"Smithsonian Astrophysical Observation", "SAO 232860"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.35937779),
        dec: Angle.Degrees(-53.32011827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79982"},
        {"Hipparcos Number", "HIP 45400"},
        {"Celescope Catalog", "CEL 3244"},
        {"Geneva Identification System", "GEN# +1.00079982"},
        {"Smithsonian Astrophysical Observation", "SAO 236766"},
    },
    visualMagnitude: 7.80,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.78268843),
        dec: Angle.Degrees(-53.31958824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6143"},
        {"Hipparcos Number", "HIP 4805"},
        {"Geneva Identification System", "GEN# +1.00006143"},
        {"Smithsonian Astrophysical Observation", "SAO 232264"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.42600399),
        dec: Angle.Degrees(-53.31936055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100656",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193791"},
        {"Hipparcos Number", "HIP 100656"},
        {"Smithsonian Astrophysical Observation", "SAO 246566"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.14598338),
        dec: Angle.Degrees(-53.31862798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102258"},
        {"Hipparcos Number", "HIP 57388"},
        {"Smithsonian Astrophysical Observation", "SAO 239355"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.48754341),
        dec: Angle.Degrees(-53.31582461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15355"},
        {"Hipparcos Number", "HIP 11379"},
        {"Smithsonian Astrophysical Observation", "SAO 232768"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.62986876),
        dec: Angle.Degrees(-53.31575984)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35417"},
        {"Hipparcos Number", "HIP 25031"},
        {"Smithsonian Astrophysical Observation", "SAO 233945"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.937,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.40091835),
        dec: Angle.Degrees(-53.31424910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145974"},
        {"Hipparcos Number", "HIP 79736"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.09628191),
        dec: Angle.Degrees(-53.31280105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27274"},
        {"Hipparcos Number", "HIP 19884"},
        {"Cincinnati Publication", "Ci 20 291"},
        {"Geneva Identification System", "GEN# +1.00027274"},
        {"Smithsonian Astrophysical Observation", "SAO 233456"},
        {"Wilson Evans Batten Catalogue", "WEB 3800"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.98389879),
        dec: Angle.Degrees(-53.31077121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 784.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 396.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185011"},
        {"Hipparcos Number", "HIP 96737"},
        {"Smithsonian Astrophysical Observation", "SAO 246202"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.97086531),
        dec: Angle.Degrees(-53.30985789)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215921"},
        {"Hipparcos Number", "HIP 112715"},
        {"Smithsonian Astrophysical Observation", "SAO 247604"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.39602746),
        dec: Angle.Degrees(-53.30934986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11233"},
        {"Hipparcos Number", "HIP 8456"},
        {"Smithsonian Astrophysical Observation", "SAO 232532"},
    },
    visualMagnitude: 9.48,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.25881315),
        dec: Angle.Degrees(-53.30924803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119555"},
        {"Hipparcos Number", "HIP 67102"},
        {"Smithsonian Astrophysical Observation", "SAO 241135"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.30332991),
        dec: Angle.Degrees(-53.30864051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139068"},
        {"Hipparcos Number", "HIP 76581"},
        {"Smithsonian Astrophysical Observation", "SAO 242785"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.60485921),
        dec: Angle.Degrees(-53.30511660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62087",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110566"},
        {"Hipparcos Number", "HIP 62087"},
        {"Geneva Identification System", "GEN# +1.00110566"},
        {"Smithsonian Astrophysical Observation", "SAO 240187"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.87743990),
        dec: Angle.Degrees(-53.30337829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210797"},
        {"Hipparcos Number", "HIP 109787"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.57651256),
        dec: Angle.Degrees(-53.29987655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 259.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40272",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40272"},
    },
    visualMagnitude: 12.03,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)13, 25.8700),
        dec: Angle.DegreesMinutesSeconds((int)-53, (int)17, 38.000)
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
    primaryId: "HIP 49041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86933"},
        {"Hipparcos Number", "HIP 49041"},
        {"Smithsonian Astrophysical Observation", "SAO 237578"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.09048060),
        dec: Angle.Degrees(-53.29083482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189271"},
        {"Hipparcos Number", "HIP 98616"},
        {"Smithsonian Astrophysical Observation", "SAO 246395"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.44631139),
        dec: Angle.Degrees(-53.29013294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87461"},
    },
    visualMagnitude: 10.60,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.06164945),
        dec: Angle.Degrees(-53.28932730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42538"},
        {"Hipparcos Number", "HIP 29094"},
        {"Geneva Identification System", "GEN# +1.00042538"},
        {"Smithsonian Astrophysical Observation", "SAO 234334"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.05684032),
        dec: Angle.Degrees(-53.28294240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 66.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119857"},
        {"Hipparcos Number", "HIP 67253"},
        {"Smithsonian Astrophysical Observation", "SAO 241164"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.76451003),
        dec: Angle.Degrees(-53.28257797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47286"},
        {"Hipparcos Number", "HIP 31394"},
        {"Smithsonian Astrophysical Observation", "SAO 234588"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.71658390),
        dec: Angle.Degrees(-53.28189273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82997",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152688"},
        {"Hipparcos Number", "HIP 82997"},
        {"Smithsonian Astrophysical Observation", "SAO 244298"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.40724919),
        dec: Angle.Degrees(-53.28169828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138708"},
        {"Hipparcos Number", "HIP 76379"},
        {"Smithsonian Astrophysical Observation", "SAO 242745"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.99740577),
        dec: Angle.Degrees(-53.27823340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130909"},
        {"Hipparcos Number", "HIP 72787"},
        {"Geneva Identification System", "GEN# +1.00130909"},
        {"Smithsonian Astrophysical Observation", "SAO 242080"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.16625869),
        dec: Angle.Degrees(-53.27686793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93515"},
        {"Hipparcos Number", "HIP 52729"},
        {"Smithsonian Astrophysical Observation", "SAO 238464"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.69493830),
        dec: Angle.Degrees(-53.27671038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13426"},
        {"Hipparcos Number", "HIP 10075"},
        {"Geneva Identification System", "GEN# +1.00013426"},
        {"Smithsonian Astrophysical Observation", "SAO 232655"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.40338651),
        dec: Angle.Degrees(-53.27604068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185259"},
        {"Hipparcos Number", "HIP 96835"},
        {"Smithsonian Astrophysical Observation", "SAO 246210"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.22929748),
        dec: Angle.Degrees(-53.27568506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223041"},
        {"Henry Draper 2", "HD 223041A"},
        {"Hipparcos Number", "HIP 117240"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.58992796),
        dec: Angle.Degrees(-53.27523507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61966"},
        {"Hipparcos Number", "HIP 37248"},
        {"Celescope Catalog", "CEL 1967"},
        {"Geneva Identification System", "GEN# +1.00061966"},
        {"Renson", "Renson 17010"},
        {"Smithsonian Astrophysical Observation", "SAO 235391"},
    },
    visualMagnitude: 6.06,
    bvColour: -0.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.75139782),
        dec: Angle.Degrees(-53.27337970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198472"},
        {"Hipparcos Number", "HIP 103048"},
        {"Geneva Identification System", "GEN# +1.00198472"},
        {"Smithsonian Astrophysical Observation", "SAO 246765"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.17329087),
        dec: Angle.Degrees(-53.27327565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129439"},
        {"Hipparcos Number", "HIP 72063"},
        {"Smithsonian Astrophysical Observation", "SAO 241962"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.10545603),
        dec: Angle.Degrees(-53.27224567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96507"},
        {"Hipparcos Number", "HIP 54293"},
        {"Geneva Identification System", "GEN# +1.00096507"},
        {"Smithsonian Astrophysical Observation", "SAO 238777"},
    },
    visualMagnitude: 7.94,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.62214999),
        dec: Angle.Degrees(-53.27171642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81451"},
        {"Hipparcos Number", "HIP 46074"},
        {"Celescope Catalog", "CEL 3283"},
        {"Geneva Identification System", "GEN# +1.00081451"},
        {"Smithsonian Astrophysical Observation", "SAO 236926"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.93624728),
        dec: Angle.Degrees(-53.27150419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104251"},
        {"Hipparcos Number", "HIP 58538"},
        {"Smithsonian Astrophysical Observation", "SAO 239570"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.06506030),
        dec: Angle.Degrees(-53.27039024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54298",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54298"},
    },
    visualMagnitude: 11.69,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.62786165),
        dec: Angle.Degrees(-53.26885914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 272.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126489"},
        {"Hipparcos Number", "HIP 70699"},
        {"Geneva Identification System", "GEN# +1.00126489"},
        {"Smithsonian Astrophysical Observation", "SAO 241726"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.90000391),
        dec: Angle.Degrees(-53.26856141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200920"},
        {"Hipparcos Number", "HIP 104359"},
        {"Smithsonian Astrophysical Observation", "SAO 246884"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.11984557),
        dec: Angle.Degrees(-53.26673030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36567"},
        {"Hipparcos Number", "HIP 25739"},
        {"Geneva Identification System", "GEN# +1.00036567"},
        {"Smithsonian Astrophysical Observation", "SAO 233998"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.43685719),
        dec: Angle.Degrees(-53.26562472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60930"},
        {"Hipparcos Number", "HIP 36799"},
        {"Smithsonian Astrophysical Observation", "SAO 235306"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.52481500),
        dec: Angle.Degrees(-53.26488580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202103"},
        {"Hipparcos Number", "HIP 104978"},
        {"Fundamental Katalog 5th Edition", "FK5 796"},
        {"Geneva Identification System", "GEN# +1.00202103J"},
        {"Renson", "Renson 56340"},
        {"Smithsonian Astrophysical Observation", "SAO 246929"},
    },
    visualMagnitude: 5.73,
    bvColour: 0.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.94098443),
        dec: Angle.Degrees(-53.26304998)
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
    primaryId: "HIP 31122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46684"},
        {"Hipparcos Number", "HIP 31122"},
        {"Geneva Identification System", "GEN# +1.00046684"},
        {"Smithsonian Astrophysical Observation", "SAO 234557"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.95840549),
        dec: Angle.Degrees(-53.26269590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 165.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30415"},
        {"Hipparcos Number", "HIP 22048"},
        {"Smithsonian Astrophysical Observation", "SAO 233658"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.13486300),
        dec: Angle.Degrees(-53.26093008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132983"},
        {"Hipparcos Number", "HIP 73719"},
        {"Smithsonian Astrophysical Observation", "SAO 242198"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.03654036),
        dec: Angle.Degrees(-53.26033901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88028"},
        {"Hipparcos Number", "HIP 49611"},
        {"Smithsonian Astrophysical Observation", "SAO 237711"},
    },
    visualMagnitude: 7.01,
    bvColour: 2.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.88679959),
        dec: Angle.Degrees(-53.26016190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72200"},
        {"Hipparcos Number", "HIP 41625"},
        {"Smithsonian Astrophysical Observation", "SAO 236023"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.29065460),
        dec: Angle.Degrees(-53.25983809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73681"},
        {"Hipparcos Number", "HIP 42274"},
        {"Geneva Identification System", "GEN# +3.23910003"},
        {"Smithsonian Astrophysical Observation", "SAO 236125"},
        {"Wilson Evans Batten Catalogue", "WEB 8121"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.29423104),
        dec: Angle.Degrees(-53.25936138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83881"},
        {"Hipparcos Number", "HIP 47414"},
        {"Celescope Catalog", "CEL 3357"},
        {"Geneva Identification System", "GEN# +1.00083881"},
        {"Smithsonian Astrophysical Observation", "SAO 237199"},
        {"Wilson Evans Batten Catalogue", "WEB 8901"},
    },
    visualMagnitude: 7.57,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.92020278),
        dec: Angle.Degrees(-53.25793082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93499"},
        {"Hipparcos Number", "HIP 52713"},
        {"Smithsonian Astrophysical Observation", "SAO 238462"},
    },
    visualMagnitude: 8.67,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.66201483),
        dec: Angle.Degrees(-53.25788858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183294"},
        {"Hipparcos Number", "HIP 96035"},
        {"Geneva Identification System", "GEN# +1.00183294"},
        {"Smithsonian Astrophysical Observation", "SAO 246141"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.90163711),
        dec: Angle.Degrees(-53.25750022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91267"},
        {"Hipparcos Number", "HIP 51510"},
        {"Geneva Identification System", "GEN# +1.00091267"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.78578114),
        dec: Angle.Degrees(-53.25739085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106905"},
        {"Hipparcos Number", "HIP 59948"},
        {"Smithsonian Astrophysical Observation", "SAO 239818"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.44488706),
        dec: Angle.Degrees(-53.25424335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185430"},
        {"Hipparcos Number", "HIP 96893"},
        {"Smithsonian Astrophysical Observation", "SAO 246220"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.43490150),
        dec: Angle.Degrees(-53.25219755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81734"},
        {"Hipparcos Number", "HIP 46236"},
        {"Geneva Identification System", "GEN# +1.00081734"},
        {"Smithsonian Astrophysical Observation", "SAO 236956"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.40145593),
        dec: Angle.Degrees(-53.25163120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68454"},
        {"Hipparcos Number", "HIP 39980"},
        {"Geneva Identification System", "GEN# +1.00068454"},
        {"Smithsonian Astrophysical Observation", "SAO 235787"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.47042261),
        dec: Angle.Degrees(-53.25074673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84715"},
        {"Hipparcos Number", "HIP 47861"},
        {"Smithsonian Astrophysical Observation", "SAO 237304"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.623,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.31939235),
        dec: Angle.Degrees(-53.25020411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121277"},
        {"Hipparcos Number", "HIP 68044"},
        {"Smithsonian Astrophysical Observation", "SAO 241304"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.98200788),
        dec: Angle.Degrees(-53.24965659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11714"},
        {"Hipparcos Number", "HIP 8831"},
        {"Smithsonian Astrophysical Observation", "SAO 232561"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.38172364),
        dec: Angle.Degrees(-53.24964177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29515"},
        {"Hipparcos Number", "HIP 21427"},
        {"Smithsonian Astrophysical Observation", "SAO 233587"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.00275249),
        dec: Angle.Degrees(-53.24913154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216215"},
        {"Hipparcos Number", "HIP 112913"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.99837144),
        dec: Angle.Degrees(-53.24537246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152770"},
        {"Hipparcos Number", "HIP 83044"},
        {"Smithsonian Astrophysical Observation", "SAO 244310"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.53738628),
        dec: Angle.Degrees(-53.24436247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24307"},
        {"Hipparcos Number", "HIP 17866"},
        {"Geneva Identification System", "GEN# +1.00024307"},
        {"Smithsonian Astrophysical Observation", "SAO 233290"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.34927652),
        dec: Angle.Degrees(-53.24307671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100724"},
        {"Hipparcos Number", "HIP 56506"},
        {"Geneva Identification System", "GEN# +1.00100724"},
        {"Smithsonian Astrophysical Observation", "SAO 239196"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.76371136),
        dec: Angle.Degrees(-53.24223502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120858"},
        {"Hipparcos Number", "HIP 67801"},
        {"Smithsonian Astrophysical Observation", "SAO 241258"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.33803000),
        dec: Angle.Degrees(-53.24162850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88877"},
        {"Hipparcos Number", "HIP 50101"},
        {"Geneva Identification System", "GEN# +1.00088877"},
        {"Smithsonian Astrophysical Observation", "SAO 237817"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.43848503),
        dec: Angle.Degrees(-53.24093541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103569"},
        {"Hipparcos Number", "HIP 58144"},
        {"Smithsonian Astrophysical Observation", "SAO 239491"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.86877194),
        dec: Angle.Degrees(-53.23972057)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33651"},
        {"Hipparcos Number", "HIP 23942"},
        {"Smithsonian Astrophysical Observation", "SAO 233842"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.18296788),
        dec: Angle.Degrees(-53.23796848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136316"},
        {"Hipparcos Number", "HIP 75221"},
        {"Geneva Identification System", "GEN# +1.00136316"},
        {"Smithsonian Astrophysical Observation", "SAO 242453"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.57487940),
        dec: Angle.Degrees(-53.23740228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110188"},
        {"Hipparcos Number", "HIP 61879"},
        {"Geneva Identification System", "GEN# +1.00110188"},
        {"Smithsonian Astrophysical Observation", "SAO 240143"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.20669311),
        dec: Angle.Degrees(-53.23719655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205069"},
        {"Hipparcos Number", "HIP 106528"},
        {"Smithsonian Astrophysical Observation", "SAO 247090"},
    },
    visualMagnitude: 9.22,
    bvColour: 1.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.64248367),
        dec: Angle.Degrees(-53.23717039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59636"},
        {"Hipparcos Number", "HIP 36263"},
        {"Smithsonian Astrophysical Observation", "SAO 235216"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.00754513),
        dec: Angle.Degrees(-53.23686227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153580"},
        {"Hipparcos Number", "HIP 83431"},
        {"Geneva Identification System", "GEN# +1.00153580"},
        {"Smithsonian Astrophysical Observation", "SAO 244388"},
        {"Wilson Evans Batten Catalogue", "WEB 14101"},
    },
    visualMagnitude: 5.27,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.78628886),
        dec: Angle.Degrees(-53.23662642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -165.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4331"},
        {"Hipparcos Number", "HIP 3537"},
        {"Smithsonian Astrophysical Observation", "SAO 232169"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.27559124),
        dec: Angle.Degrees(-53.23528087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89064"},
        {"Hipparcos Number", "HIP 50227"},
        {"Smithsonian Astrophysical Observation", "SAO 237831"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.79486568),
        dec: Angle.Degrees(-53.23431305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23708"},
        {"Hipparcos Number", "HIP 17477"},
        {"Smithsonian Astrophysical Observation", "SAO 233253"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.17562455),
        dec: Angle.Degrees(-53.23313134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97651"},
        {"Hipparcos Number", "HIP 54840"},
        {"Geneva Identification System", "GEN# +1.00097651"},
        {"Smithsonian Astrophysical Observation", "SAO 238878"},
    },
    visualMagnitude: 5.75,
    bvColour: 1.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.41420693),
        dec: Angle.Degrees(-53.23190310)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76062"},
        {"Hipparcos Number", "HIP 43500"},
        {"Smithsonian Astrophysical Observation", "SAO 236335"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.90650680),
        dec: Angle.Degrees(-53.22789230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68948",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123025"},
        {"Hipparcos Number", "HIP 68948"},
        {"Smithsonian Astrophysical Observation", "SAO 241449"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.70715332),
        dec: Angle.Degrees(-53.22729693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113596",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 113596"},
    },
    visualMagnitude: 10.55,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.10913413),
        dec: Angle.Degrees(-53.22723553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1872"},
        {"Hipparcos Number", "HIP 1800"},
        {"Geneva Identification System", "GEN# +1.00001872"},
        {"Smithsonian Astrophysical Observation", "SAO 232012"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.70944305),
        dec: Angle.Degrees(-53.22406613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135330"},
        {"Hipparcos Number", "HIP 74762"},
        {"Smithsonian Astrophysical Observation", "SAO 242375"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.19497396),
        dec: Angle.Degrees(-53.22376790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157676"},
        {"Hipparcos Number", "HIP 85435"},
        {"Smithsonian Astrophysical Observation", "SAO 244757"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.88989474),
        dec: Angle.Degrees(-53.22249415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9990"},
        {"Hipparcos Number", "HIP 7479"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.08007842),
        dec: Angle.Degrees(-53.22246592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64957",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115566"},
        {"Hipparcos Number", "HIP 64957"},
        {"Geneva Identification System", "GEN# +1.00115566"},
        {"Smithsonian Astrophysical Observation", "SAO 240732"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.72143493),
        dec: Angle.Degrees(-53.22155768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -148.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27244",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38973"},
        {"Hipparcos Number", "HIP 27244"},
        {"Geneva Identification System", "GEN# +1.00038973"},
        {"Smithsonian Astrophysical Observation", "SAO 234128"},
    },
    visualMagnitude: 6.63,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.61647159),
        dec: Angle.Degrees(-53.21898343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113704"},
        {"Hipparcos Number", "HIP 63947"},
        {"Smithsonian Astrophysical Observation", "SAO 240546"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.58124751),
        dec: Angle.Degrees(-53.21819653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26721",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38149"},
        {"Hipparcos Number", "HIP 26721"},
        {"Smithsonian Astrophysical Observation", "SAO 234085"},
    },
    visualMagnitude: 7.58,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.17744336),
        dec: Angle.Degrees(-53.21726242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55913"},
        {"Hipparcos Number", "HIP 34788"},
        {"Smithsonian Astrophysical Observation", "SAO 235006"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.02400593),
        dec: Angle.Degrees(-53.21643334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83369"},
        {"Hipparcos Number", "HIP 47126"},
        {"Celescope Catalog", "CEL 3339"},
        {"Geneva Identification System", "GEN# +1.00083369"},
        {"Smithsonian Astrophysical Observation", "SAO 237134"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.04570626),
        dec: Angle.Degrees(-53.21455953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115433"},
        {"Hipparcos Number", "HIP 64891"},
        {"Smithsonian Astrophysical Observation", "SAO 240716"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.52043829),
        dec: Angle.Degrees(-53.21239856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72738"},
        {"Henry Draper 2", "HD 72737"},
        {"Hipparcos Number", "HIP 41861"},
        {"Geneva Identification System", "GEN# +1.00072737"},
        {"Smithsonian Astrophysical Observation", "SAO 236062"},
        {"Wilson Evans Batten Catalogue", "WEB 8058"},
    },
    visualMagnitude: 5.68,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.02072039),
        dec: Angle.Degrees(-53.21196039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3888"},
        {"Hipparcos Number", "HIP 3210"},
        {"Geneva Identification System", "GEN# +1.00003888"},
        {"Smithsonian Astrophysical Observation", "SAO 232148"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.21444826),
        dec: Angle.Degrees(-53.20980159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141168"},
        {"Hipparcos Number", "HIP 77562"},
        {"Geneva Identification System", "GEN# +1.00141168"},
        {"Smithsonian Astrophysical Observation", "SAO 243022"},
        {"Wilson Evans Batten Catalogue", "WEB 13129"},
    },
    visualMagnitude: 5.78,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.52962796),
        dec: Angle.Degrees(-53.20967534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208739"},
        {"Hipparcos Number", "HIP 108595"},
        {"Smithsonian Astrophysical Observation", "SAO 247258"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.97626711),
        dec: Angle.Degrees(-53.20753620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94958"},
        {"Hipparcos Number", "HIP 53520"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.22550428),
        dec: Angle.Degrees(-53.20717483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110283",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110283"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.08192634),
        dec: Angle.Degrees(-53.20641166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 160.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22596"},
        {"Hipparcos Number", "HIP 16762"},
        {"Geneva Identification System", "GEN# +1.00022596"},
        {"Smithsonian Astrophysical Observation", "SAO 233174"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.92702612),
        dec: Angle.Degrees(-53.20600838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121640"},
        {"Hipparcos Number", "HIP 68225"},
        {"Geneva Identification System", "GEN# +1.00121640"},
        {"Smithsonian Astrophysical Observation", "SAO 241331"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.50392516),
        dec: Angle.Degrees(-53.20363622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127751"},
        {"Hipparcos Number", "HIP 71312"},
        {"Smithsonian Astrophysical Observation", "SAO 241810"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.74445936),
        dec: Angle.Degrees(-53.20100401)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148852"},
        {"Hipparcos Number", "HIP 81079"},
        {"Geneva Identification System", "GEN# +1.00148852"},
        {"Smithsonian Astrophysical Observation", "SAO 243945"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.883,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.39968115),
        dec: Angle.Degrees(-53.20010138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9925"},
        {"Hipparcos Number", "HIP 7430"},
        {"Smithsonian Astrophysical Observation", "SAO 232471"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.92961973),
        dec: Angle.Degrees(-53.19995737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4000"},
        {"Hipparcos Number", "HIP 3292"},
        {"Smithsonian Astrophysical Observation", "SAO 232153"},
        {"Wilson Evans Batten Catalogue", "WEB 586"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.50357246),
        dec: Angle.Degrees(-53.19931955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 144.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9892",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13183"},
        {"Hipparcos Number", "HIP 9892"},
        {"Geneva Identification System", "GEN# +1.00013183"},
        {"Smithsonian Astrophysical Observation", "SAO 232639"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.82489917),
        dec: Angle.Degrees(-53.19898114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97395"},
        {"Hipparcos Number", "HIP 54701"},
        {"Smithsonian Astrophysical Observation", "SAO 238851"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.97940559),
        dec: Angle.Degrees(-53.19660408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2633",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3062"},
        {"Hipparcos Number", "HIP 2633"},
        {"Geneva Identification System", "GEN# +1.00003062"},
        {"Smithsonian Astrophysical Observation", "SAO 232085"},
    },
    visualMagnitude: 9.60,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.35679702),
        dec: Angle.Degrees(-53.19608363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62483"},
        {"Hipparcos Number", "HIP 37471"},
        {"Geneva Identification System", "GEN# +1.00062483"},
        {"Smithsonian Astrophysical Observation", "SAO 235418"},
        {"Wilson Evans Batten Catalogue", "WEB 7412"},
    },
    visualMagnitude: 8.24,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.37054147),
        dec: Angle.Degrees(-53.19476892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108900"},
        {"Hipparcos Number", "HIP 61062"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)12, (int)31, 02.2100),
        dec: Angle.DegreesMinutesSeconds((int)-53, (int)11, 33.900)
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
    primaryId: "HIP 4360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5474"},
        {"Hipparcos Number", "HIP 4360"},
        {"Smithsonian Astrophysical Observation", "SAO 232227"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.97062058),
        dec: Angle.Degrees(-53.19241511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118256"},
        {"Hipparcos Number", "HIP 66390"},
        {"Celescope Catalog", "CEL 4269"},
        {"Geneva Identification System", "GEN# +1.00118256"},
        {"Smithsonian Astrophysical Observation", "SAO 240996"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.18147234),
        dec: Angle.Degrees(-53.19148264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99065"},
        {"Hipparcos Number", "HIP 55611"},
        {"Smithsonian Astrophysical Observation", "SAO 239024"},
    },
    visualMagnitude: 9.00,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.89732484),
        dec: Angle.Degrees(-53.18656008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183552"},
        {"Hipparcos Number", "HIP 96141"},
        {"Geneva Identification System", "GEN# +1.00183552"},
        {"Renson", "Renson 50700"},
        {"Smithsonian Astrophysical Observation", "SAO 246151"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.22412548),
        dec: Angle.Degrees(-53.18560103)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61063"},
    },
    visualMagnitude: 10.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.76375481),
        dec: Angle.Degrees(-53.18481579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85594"},
        {"Hipparcos Number", "HIP 48338"},
        {"Geneva Identification System", "GEN# +4.27160001"},
        {"Smithsonian Astrophysical Observation", "SAO 237408"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.79522926),
        dec: Angle.Degrees(-53.18300230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24224"},
        {"Hipparcos Number", "HIP 17820"},
        {"Geneva Identification System", "GEN# +1.00024224"},
        {"Smithsonian Astrophysical Observation", "SAO 233282"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.19730875),
        dec: Angle.Degrees(-53.18226904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220082"},
        {"Hipparcos Number", "HIP 115328"},
        {"Smithsonian Astrophysical Observation", "SAO 247840"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.794,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.38903389),
        dec: Angle.Degrees(-53.17708373)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 255.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125869"},
        {"Hipparcos Number", "HIP 70363"},
        {"Geneva Identification System", "GEN# +1.00125869"},
        {"Smithsonian Astrophysical Observation", "SAO 241691"},
    },
    visualMagnitude: 5.99,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.95265857),
        dec: Angle.Degrees(-53.17620992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24904"},
        {"Hipparcos Number", "HIP 18323"},
        {"Smithsonian Astrophysical Observation", "SAO 233326"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.76011640),
        dec: Angle.Degrees(-53.17280646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16039"},
        {"Geneva Identification System", "GEN# -0.05300566"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.865,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.64088817),
        dec: Angle.Degrees(-53.16212447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 295.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 222.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152980"},
        {"Hipparcos Number", "HIP 83153"},
        {"Fundamental Katalog 5th Edition", "FK5 632"},
        {"Geneva Identification System", "GEN# +1.00152980"},
        {"Smithsonian Astrophysical Observation", "SAO 244331"},
        {"Wilson Evans Batten Catalogue", "WEB 14051"},
    },
    visualMagnitude: 4.06,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.89602773),
        dec: Angle.Degrees(-53.16049005)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143657"},
        {"Hipparcos Number", "HIP 78730"},
        {"Smithsonian Astrophysical Observation", "SAO 243294"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.08259104),
        dec: Angle.Degrees(-53.16016105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99575"},
        {"Henry Draper 2", "HD 99574"},
        {"Hipparcos Number", "HIP 55849"},
        {"Geneva Identification System", "GEN# +1.00099574J"},
        {"Smithsonian Astrophysical Observation", "SAO 239074"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.69710349),
        dec: Angle.Degrees(-53.15995577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102366"},
        {"Hipparcos Number", "HIP 57461"},
        {"Smithsonian Astrophysical Observation", "SAO 239369"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.67806730),
        dec: Angle.Degrees(-53.15854136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6158"},
        {"Hipparcos Number", "HIP 4818"},
        {"Geneva Identification System", "GEN# +1.00006158"},
        {"Smithsonian Astrophysical Observation", "SAO 232266"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.45456067),
        dec: Angle.Degrees(-53.15831499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13215",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13215"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.52332551),
        dec: Angle.Degrees(-53.15553365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150576"},
        {"Hipparcos Number", "HIP 81966"},
        {"Fundamental Katalog 5th Edition", "FK5 3327"},
        {"Geneva Identification System", "GEN# +1.00150576"},
        {"Smithsonian Astrophysical Observation", "SAO 244106"},
    },
    visualMagnitude: 5.96,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.16564097),
        dec: Angle.Degrees(-53.15228963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204424"},
        {"Hipparcos Number", "HIP 106164"},
        {"Geneva Identification System", "GEN# +1.00204424"},
        {"Smithsonian Astrophysical Observation", "SAO 247053"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.56462571),
        dec: Angle.Degrees(-53.14903652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16734"},
        {"Hipparcos Number", "HIP 12357"},
        {"Smithsonian Astrophysical Observation", "SAO 232846"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.76972690),
        dec: Angle.Degrees(-53.14891511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63053"},
        {"Hipparcos Number", "HIP 37728"},
        {"Smithsonian Astrophysical Observation", "SAO 235466"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.07316080),
        dec: Angle.Degrees(-53.14877169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87295"},
        {"Hipparcos Number", "HIP 49203"},
        {"Celescope Catalog", "CEL 3427"},
        {"Geneva Identification System", "GEN# +1.00087295"},
        {"Smithsonian Astrophysical Observation", "SAO 237627"},
    },
    visualMagnitude: 7.68,
    bvColour: -0.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.64066517),
        dec: Angle.Degrees(-53.14840486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113474"},
        {"Hipparcos Number", "HIP 63807"},
        {"Smithsonian Astrophysical Observation", "SAO 240524"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.17839187),
        dec: Angle.Degrees(-53.14740185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144440"},
        {"Hipparcos Number", "HIP 79077"},
        {"Smithsonian Astrophysical Observation", "SAO 243359"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.13385226),
        dec: Angle.Degrees(-53.14468208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203759"},
        {"Hipparcos Number", "HIP 105828"},
        {"Smithsonian Astrophysical Observation", "SAO 247026"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.51680198),
        dec: Angle.Degrees(-53.14140998)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7887"},
        {"Hipparcos Number", "HIP 6041"},
        {"Smithsonian Astrophysical Observation", "SAO 232364"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.39788055),
        dec: Angle.Degrees(-53.14074239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13218",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13218"},
        {"Cincinnati Publication", "Ci 20 188"},
    },
    visualMagnitude: 10.72,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.54102469),
        dec: Angle.Degrees(-53.14019279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 502.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91491"},
        {"Hipparcos Number", "HIP 51615"},
        {"Geneva Identification System", "GEN# +1.00091491"},
        {"Smithsonian Astrophysical Observation", "SAO 238164"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.17687568),
        dec: Angle.Degrees(-53.14008399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172210"},
        {"Hipparcos Number", "HIP 91693"},
        {"Smithsonian Astrophysical Observation", "SAO 245640"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.46903949),
        dec: Angle.Degrees(-53.13964024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142081"},
        {"Hipparcos Number", "HIP 77944"},
        {"Geneva Identification System", "GEN# +1.00142081"},
        {"Smithsonian Astrophysical Observation", "SAO 243113"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.75870576),
        dec: Angle.Degrees(-53.13766007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112951"},
        {"Hipparcos Number", "HIP 63527"},
        {"Geneva Identification System", "GEN# +1.00112951"},
        {"Smithsonian Astrophysical Observation", "SAO 240476"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.26831642),
        dec: Angle.Degrees(-53.13569861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149210"},
        {"Hipparcos Number", "HIP 81275"},
        {"Smithsonian Astrophysical Observation", "SAO 243977"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.99154728),
        dec: Angle.Degrees(-53.13277738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161917"},
        {"Hipparcos Number", "HIP 87379"},
        {"Geneva Identification System", "GEN# +1.00161917"},
        {"Smithsonian Astrophysical Observation", "SAO 245072"},
    },
    visualMagnitude: 6.09,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.79596178),
        dec: Angle.Degrees(-53.13027030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214034"},
        {"Hipparcos Number", "HIP 111609"},
        {"Smithsonian Astrophysical Observation", "SAO 247511"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.16012019),
        dec: Angle.Degrees(-53.12690721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207926"},
        {"Hipparcos Number", "HIP 108109"},
        {"Geneva Identification System", "GEN# +1.00207926"},
        {"Smithsonian Astrophysical Observation", "SAO 247220"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.55349663),
        dec: Angle.Degrees(-53.12493474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7527"},
        {"Hipparcos Number", "HIP 5797"},
        {"Smithsonian Astrophysical Observation", "SAO 232352"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.59127282),
        dec: Angle.Degrees(-53.12414922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184100"},
        {"Hipparcos Number", "HIP 96358"},
        {"Smithsonian Astrophysical Observation", "SAO 246175"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.87741912),
        dec: Angle.Degrees(-53.11946243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99746"},
        {"Hipparcos Number", "HIP 55954"},
        {"Smithsonian Astrophysical Observation", "SAO 239092"},
    },
    visualMagnitude: 8.78,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.99526507),
        dec: Angle.Degrees(-53.11878020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2871"},
        {"Hipparcos Number", "HIP 2489"},
        {"Smithsonian Astrophysical Observation", "SAO 232078"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.89854845),
        dec: Angle.Degrees(-53.11792927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42726",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74560"},
        {"Hipparcos Number", "HIP 42726"},
        {"Celescope Catalog", "CEL 2807"},
        {"Geneva Identification System", "GEN# +3.23910034"},
        {"Renson", "Renson 20840"},
        {"Smithsonian Astrophysical Observation", "SAO 236205"},
        {"Wilson Evans Batten Catalogue", "WEB 8254"},
    },
    visualMagnitude: 4.83,
    bvColour: -0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.60587670),
        dec: Angle.Degrees(-53.11404062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28349"},
        {"Hipparcos Number", "HIP 20650"},
        {"Smithsonian Astrophysical Observation", "SAO 233512"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.37355632),
        dec: Angle.Degrees(-53.11188516)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95509"},
        {"Hipparcos Number", "HIP 53811"},
        {"Smithsonian Astrophysical Observation", "SAO 238687"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.15138517),
        dec: Angle.Degrees(-53.11186852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194002"},
        {"Hipparcos Number", "HIP 100752"},
        {"Smithsonian Astrophysical Observation", "SAO 246575"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.41331447),
        dec: Angle.Degrees(-53.10936293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190484"},
        {"Hipparcos Number", "HIP 99146"},
        {"Smithsonian Astrophysical Observation", "SAO 246448"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.93094406),
        dec: Angle.Degrees(-53.10867791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96135"},
        {"Hipparcos Number", "HIP 54129"},
        {"Renson", "Renson 27690"},
        {"Smithsonian Astrophysical Observation", "SAO 238734"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.12009223),
        dec: Angle.Degrees(-53.10852961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67364"},
        {"Hipparcos Number", "HIP 39566"},
        {"Geneva Identification System", "GEN# +1.00067364"},
        {"Smithsonian Astrophysical Observation", "SAO 235735"},
        {"Wilson Evans Batten Catalogue", "WEB 7734"},
    },
    visualMagnitude: 5.52,
    bvColour: 1.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.26544452),
        dec: Angle.Degrees(-53.10791360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146920"},
        {"Hipparcos Number", "HIP 80132"},
        {"Smithsonian Astrophysical Observation", "SAO 243681"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34480552),
        dec: Angle.Degrees(-53.10762186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155284"},
        {"Hipparcos Number", "HIP 84255"},
        {"Smithsonian Astrophysical Observation", "SAO 244529"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.34679561),
        dec: Angle.Degrees(-53.10587009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206759"},
        {"Hipparcos Number", "HIP 107463"},
        {"Smithsonian Astrophysical Observation", "SAO 247166"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.48968814),
        dec: Angle.Degrees(-53.10561327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112243"},
        {"Hipparcos Number", "HIP 63111"},
        {"Smithsonian Astrophysical Observation", "SAO 240386"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.97679619),
        dec: Angle.Degrees(-53.10536432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125574"},
        {"Hipparcos Number", "HIP 70207"},
        {"Smithsonian Astrophysical Observation", "SAO 241668"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.46369556),
        dec: Angle.Degrees(-53.10417248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75660"},
        {"Hipparcos Number", "HIP 43281"},
        {"Celescope Catalog", "CEL 2954"},
        {"Geneva Identification System", "GEN# +1.00075660"},
        {"Smithsonian Astrophysical Observation", "SAO 236302"},
    },
    visualMagnitude: 8.19,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.25787243),
        dec: Angle.Degrees(-53.10316540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33559",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33559"},
        {"Smithsonian Astrophysical Observation", "SAO 234820"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.60605757),
        dec: Angle.Degrees(-53.10204538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80141",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146921"},
        {"Hipparcos Number", "HIP 80141"},
        {"Smithsonian Astrophysical Observation", "SAO 243684"},
    },
    visualMagnitude: 8.36,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.36301319),
        dec: Angle.Degrees(-53.10080161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74535"},
        {"Hipparcos Number", "HIP 42715"},
        {"Geneva Identification System", "GEN# +3.23910031"},
        {"Renson", "Renson 20800"},
        {"Smithsonian Astrophysical Observation", "SAO 236202"},
        {"Wilson Evans Batten Catalogue", "WEB 8252"},
    },
    visualMagnitude: 5.49,
    bvColour: -0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.57922931),
        dec: Angle.Degrees(-53.10011485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163636"},
        {"Hipparcos Number", "HIP 88130"},
        {"Smithsonian Astrophysical Observation", "SAO 245162"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.01960136),
        dec: Angle.Degrees(-53.09841738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224782"},
        {"Hipparcos Number", "HIP 50"},
        {"Smithsonian Astrophysical Observation", "SAO 248097"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.616,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.14287059),
        dec: Angle.Degrees(-53.09766277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117411"},
        {"Hipparcos Number", "HIP 65952"},
        {"Smithsonian Astrophysical Observation", "SAO 240914"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.81773434),
        dec: Angle.Degrees(-53.09655045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182823"},
        {"Hipparcos Number", "HIP 95801"},
        {"Smithsonian Astrophysical Observation", "SAO 246117"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.29596309),
        dec: Angle.Degrees(-53.09624210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154289"},
        {"Hipparcos Number", "HIP 83776"},
        {"Smithsonian Astrophysical Observation", "SAO 244446"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.83723844),
        dec: Angle.Degrees(-53.09618904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11071",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11071"},
    },
    visualMagnitude: 10.67,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.62945843),
        dec: Angle.Degrees(-53.09449825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 244.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 126.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88142"},
        {"Hipparcos Number", "HIP 49676"},
        {"Geneva Identification System", "GEN# +1.00088142"},
        {"Smithsonian Astrophysical Observation", "SAO 237724"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.11427878),
        dec: Angle.Degrees(-53.09433862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142790"},
        {"Hipparcos Number", "HIP 78273"},
        {"Smithsonian Astrophysical Observation", "SAO 243193"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.73758087),
        dec: Angle.Degrees(-53.09399842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105974"},
        {"Hipparcos Number", "HIP 59464"},
        {"Smithsonian Astrophysical Observation", "SAO 239740"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.95149693),
        dec: Angle.Degrees(-53.09320334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34542"},
        {"Hipparcos Number", "HIP 24485"},
        {"Smithsonian Astrophysical Observation", "SAO 233892"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.81023820),
        dec: Angle.Degrees(-53.09303252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87990",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 87990"},
    },
    visualMagnitude: 11.57,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.60180226),
        dec: Angle.Degrees(-52.00100288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97856",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187580"},
        {"Hipparcos Number", "HIP 97856"},
        {"Smithsonian Astrophysical Observation", "SAO 246316"},
    },
    visualMagnitude: 6.99,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.29383455),
        dec: Angle.Degrees(-53.09240882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208998"},
        {"Hipparcos Number", "HIP 108736"},
        {"Cincinnati Publication", "Ci 20 1328"},
        {"Geneva Identification System", "GEN# +1.00208998"},
        {"Smithsonian Astrophysical Observation", "SAO 247274"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.40196827),
        dec: Angle.Degrees(-53.09235478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -504.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73952"},
        {"Hipparcos Number", "HIP 42400"},
        {"Celescope Catalog", "CEL 2742"},
        {"Geneva Identification System", "GEN# +3.23910008"},
        {"Smithsonian Astrophysical Observation", "SAO 236142"},
        {"Wilson Evans Batten Catalogue", "WEB 8150"},
    },
    visualMagnitude: 6.45,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.68679697),
        dec: Angle.Degrees(-53.09043371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71935"},
        {"Hipparcos Number", "HIP 41483"},
        {"Geneva Identification System", "GEN# +1.00071935"},
        {"Smithsonian Astrophysical Observation", "SAO 236002"},
        {"Wilson Evans Batten Catalogue", "WEB 8019"},
    },
    visualMagnitude: 5.08,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.90271156),
        dec: Angle.Degrees(-53.08853976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137542"},
        {"Hipparcos Number", "HIP 75787"},
        {"Smithsonian Astrophysical Observation", "SAO 242584"},
    },
    visualMagnitude: 8.17,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.23221954),
        dec: Angle.Degrees(-53.08792959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140175"},
        {"Hipparcos Number", "HIP 77099"},
        {"Geneva Identification System", "GEN# +1.00140175J"},
        {"Smithsonian Astrophysical Observation", "SAO 242897"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.14462313),
        dec: Angle.Degrees(-53.08753363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146145"},
        {"Hipparcos Number", "HIP 79812"},
        {"Geneva Identification System", "GEN# +1.00146145"},
        {"Smithsonian Astrophysical Observation", "SAO 243544"},
        {"Wilson Evans Batten Catalogue", "WEB 13511"},
    },
    visualMagnitude: 6.30,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.33739454),
        dec: Angle.Degrees(-53.08626474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206120"},
        {"Hipparcos Number", "HIP 107106"},
        {"Smithsonian Astrophysical Observation", "SAO 247137"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.43065460),
        dec: Angle.Degrees(-53.08563409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28928",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42192"},
        {"Hipparcos Number", "HIP 28928"},
        {"Smithsonian Astrophysical Observation", "SAO 234310"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.59082250),
        dec: Angle.Degrees(-53.08555890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45570",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45570"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.31968000),
        dec: Angle.Degrees(-53.08487131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70604"},
        {"Hipparcos Number", "HIP 40869"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.09655388),
        dec: Angle.Degrees(-53.08120809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209214"},
        {"Hipparcos Number", "HIP 108852"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.759,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.77537489),
        dec: Angle.Degrees(-53.08095580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45567"},
    },
    visualMagnitude: 12.56,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.31201494),
        dec: Angle.Degrees(-53.08093913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102755"},
        {"Hipparcos Number", "HIP 57674"},
        {"Smithsonian Astrophysical Observation", "SAO 239402"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.43449089),
        dec: Angle.Degrees(-53.07972651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43677"},
        {"Hipparcos Number", "HIP 29622"},
        {"Smithsonian Astrophysical Observation", "SAO 234397"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.62902318),
        dec: Angle.Degrees(-53.07951683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85391"},
        {"Hipparcos Number", "HIP 48216"},
        {"Smithsonian Astrophysical Observation", "SAO 237384"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.45499879),
        dec: Angle.Degrees(-53.07925898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144386"},
        {"Hipparcos Number", "HIP 79055"},
        {"Smithsonian Astrophysical Observation", "SAO 243355"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.04515910),
        dec: Angle.Degrees(-53.07895041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166679"},
        {"Hipparcos Number", "HIP 89402"},
        {"Smithsonian Astrophysical Observation", "SAO 245333"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.246,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.67159325),
        dec: Angle.Degrees(-53.07829628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22758"},
        {"Hipparcos Number", "HIP 16866"},
        {"Smithsonian Astrophysical Observation", "SAO 233183"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.26393270),
        dec: Angle.Degrees(-53.07785179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109854"},
        {"Hipparcos Number", "HIP 61660"},
        {"Smithsonian Astrophysical Observation", "SAO 240108"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.60203958),
        dec: Angle.Degrees(-53.07671855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158991"},
        {"Hipparcos Number", "HIP 86055"},
        {"Geneva Identification System", "GEN# +1.00158991"},
        {"Smithsonian Astrophysical Observation", "SAO 244867"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.80443786),
        dec: Angle.Degrees(-53.07650332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151117"},
        {"Hipparcos Number", "HIP 82237"},
        {"Smithsonian Astrophysical Observation", "SAO 244149"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.02202651),
        dec: Angle.Degrees(-53.07479727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38148"},
        {"Hipparcos Number", "HIP 26723"},
        {"Geneva Identification System", "GEN# +1.00038148"},
        {"Smithsonian Astrophysical Observation", "SAO 234086"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.18164694),
        dec: Angle.Degrees(-53.07432553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 53.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73105"},
        {"Hipparcos Number", "HIP 42038"},
        {"Celescope Catalog", "CEL 2666"},
        {"Geneva Identification System", "GEN# +1.00073105"},
        {"Smithsonian Astrophysical Observation", "SAO 236091"},
        {"Wilson Evans Batten Catalogue", "WEB 8085"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.53999045),
        dec: Angle.Degrees(-53.07153173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149138"},
        {"Hipparcos Number", "HIP 81240"},
        {"Smithsonian Astrophysical Observation", "SAO 243971"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.88403127),
        dec: Angle.Degrees(-53.06552512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90341",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90341"},
    },
    visualMagnitude: 10.52,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.48913178),
        dec: Angle.Degrees(-53.06495150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196084"},
        {"Hipparcos Number", "HIP 101749"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.33564951),
        dec: Angle.Degrees(-53.06275553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128154"},
        {"Hipparcos Number", "HIP 71494"},
        {"Smithsonian Astrophysical Observation", "SAO 241848"},
    },
    visualMagnitude: 6.49,
    bvColour: 1.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.30178173),
        dec: Angle.Degrees(-53.06074908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2262"},
        {"Smithsonian Astrophysical Observation", "SAO 232059"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.20998867),
        dec: Angle.Degrees(-53.05924116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46610",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46610"},
        {"Wilson Evans Batten Catalogue", "WEB 8794"},
    },
    visualMagnitude: 11.86,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.56602343),
        dec: Angle.Degrees(-53.05869811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136947"},
        {"Hipparcos Number", "HIP 75522"},
        {"Geneva Identification System", "GEN# +1.00136947"},
        {"Smithsonian Astrophysical Observation", "SAO 242504"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.43674113),
        dec: Angle.Degrees(-53.05796415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165537"},
        {"Hipparcos Number", "HIP 88949"},
        {"Smithsonian Astrophysical Observation", "SAO 245269"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.35080271),
        dec: Angle.Degrees(-53.05729812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116981",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222666"},
        {"Hipparcos Number", "HIP 116981"},
        {"Smithsonian Astrophysical Observation", "SAO 247994"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.72400188),
        dec: Angle.Degrees(-53.05666562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21002"},
        {"Hipparcos Number", "HIP 15613"},
        {"Smithsonian Astrophysical Observation", "SAO 233077"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.25564882),
        dec: Angle.Degrees(-53.05540599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74146"},
        {"Hipparcos Number", "HIP 42504"},
        {"Celescope Catalog", "CEL 2756"},
        {"Geneva Identification System", "GEN# +3.23910016"},
        {"Smithsonian Astrophysical Observation", "SAO 236157"},
        {"Wilson Evans Batten Catalogue", "WEB 8188"},
    },
    visualMagnitude: 5.18,
    bvColour: -0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.99009397),
        dec: Angle.Degrees(-53.05478181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104488"},
        {"Geneva Identification System", "GEN# +6.20145072"},
    },
    visualMagnitude: 11.65,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.50153395),
        dec: Angle.Degrees(-53.05460633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -155.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115418",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220250"},
        {"Hipparcos Number", "HIP 115418"},
        {"Smithsonian Astrophysical Observation", "SAO 247845"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.70190288),
        dec: Angle.Degrees(-53.05456040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167917"},
        {"Hipparcos Number", "HIP 89864"},
        {"Smithsonian Astrophysical Observation", "SAO 245406"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.07779034),
        dec: Angle.Degrees(-53.05410385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222594"},
        {"Hipparcos Number", "HIP 116930"},
        {"Smithsonian Astrophysical Observation", "SAO 247985"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.52770289),
        dec: Angle.Degrees(-53.05320200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87433"},
        {"Hipparcos Number", "HIP 49272"},
        {"Smithsonian Astrophysical Observation", "SAO 237647"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.86943565),
        dec: Angle.Degrees(-53.05304172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208251"},
        {"Hipparcos Number", "HIP 108305"},
        {"Smithsonian Astrophysical Observation", "SAO 247237"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.259,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.12133843),
        dec: Angle.Degrees(-53.04834041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12112",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16405"},
        {"Hipparcos Number", "HIP 12112"},
        {"Smithsonian Astrophysical Observation", "SAO 232828"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.00725465),
        dec: Angle.Degrees(-53.04598971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45063",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79206"},
        {"Hipparcos Number", "HIP 45063"},
        {"Celescope Catalog", "CEL 3202"},
        {"Geneva Identification System", "GEN# +1.00079206"},
        {"Smithsonian Astrophysical Observation", "SAO 236685"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.67510770),
        dec: Angle.Degrees(-53.04583465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119486"},
        {"Hipparcos Number", "HIP 67073"},
        {"Smithsonian Astrophysical Observation", "SAO 241129"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.20143008),
        dec: Angle.Degrees(-53.04168387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105856"},
        {"Hipparcos Number", "HIP 59395"},
        {"Smithsonian Astrophysical Observation", "SAO 239726"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.77195364),
        dec: Angle.Degrees(-53.03810955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73503"},
        {"Hipparcos Number", "HIP 42216"},
        {"Geneva Identification System", "GEN# +3.23910002"},
        {"Smithsonian Astrophysical Observation", "SAO 236118"},
        {"Wilson Evans Batten Catalogue", "WEB 8112"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.09844792),
        dec: Angle.Degrees(-53.03653461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93125"},
        {"Hipparcos Number", "HIP 52515"},
        {"Smithsonian Astrophysical Observation", "SAO 238403"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.06434260),
        dec: Angle.Degrees(-53.03607830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12712"},
        {"Hipparcos Number", "HIP 9571"},
        {"Geneva Identification System", "GEN# +1.00012712"},
        {"Smithsonian Astrophysical Observation", "SAO 232614"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.74350960),
        dec: Angle.Degrees(-53.03607010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193732"},
        {"Hipparcos Number", "HIP 100627"},
        {"Smithsonian Astrophysical Observation", "SAO 246563"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.06304565),
        dec: Angle.Degrees(-53.03498796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201152"},
        {"Hipparcos Number", "HIP 104470"},
        {"Smithsonian Astrophysical Observation", "SAO 246890"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.43867468),
        dec: Angle.Degrees(-53.03486697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -110.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120782"},
        {"Hipparcos Number", "HIP 67764"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.667,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.22495144),
        dec: Angle.Degrees(-53.03475547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146919"},
        {"Hipparcos Number", "HIP 80136"},
        {"Geneva Identification System", "GEN# +1.00146919"},
        {"Smithsonian Astrophysical Observation", "SAO 243682"},
        {"Wilson Evans Batten Catalogue", "WEB 13564"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.34817378),
        dec: Angle.Degrees(-53.03447042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202917"},
        {"Hipparcos Number", "HIP 105388"},
        {"Geneva Identification System", "GEN# +1.00202917"},
        {"Smithsonian Astrophysical Observation", "SAO 246975"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.20803012),
        dec: Angle.Degrees(-53.03397741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47177"},
        {"Geneva Identification System", "GEN# -0.05202616"},
    },
    visualMagnitude: 10.20,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.21446217),
        dec: Angle.Degrees(-53.03280690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148342"},
        {"Hipparcos Number", "HIP 80811"},
        {"Geneva Identification System", "GEN# +1.00148342"},
        {"Smithsonian Astrophysical Observation", "SAO 243885"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.53099235),
        dec: Angle.Degrees(-53.02907308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100663"},
        {"Hipparcos Number", "HIP 56470"},
        {"Smithsonian Astrophysical Observation", "SAO 239183"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.66573306),
        dec: Angle.Degrees(-53.02873551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31890"},
        {"Hipparcos Number", "HIP 22968"},
        {"Smithsonian Astrophysical Observation", "SAO 233744"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.13554129),
        dec: Angle.Degrees(-53.02733157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107152"},
        {"Hipparcos Number", "HIP 60099"},
        {"Smithsonian Astrophysical Observation", "SAO 239848"},
    },
    visualMagnitude: 8.59,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.87497611),
        dec: Angle.Degrees(-53.02523215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49054"},
        {"Hipparcos Number", "HIP 32218"},
        {"Smithsonian Astrophysical Observation", "SAO 234675"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.88786278),
        dec: Angle.Degrees(-53.02396782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152920"},
        {"Hipparcos Number", "HIP 83121"},
        {"Smithsonian Astrophysical Observation", "SAO 244321"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.79323143),
        dec: Angle.Degrees(-53.02360712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55723",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99311"},
        {"Hipparcos Number", "HIP 55723"},
        {"Smithsonian Astrophysical Observation", "SAO 239047"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.26788273),
        dec: Angle.Degrees(-53.02205264)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207178"},
        {"Hipparcos Number", "HIP 107682"},
        {"Smithsonian Astrophysical Observation", "SAO 247189"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.18888082),
        dec: Angle.Degrees(-53.01786699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74196"},
        {"Hipparcos Number", "HIP 42535"},
        {"Celescope Catalog", "CEL 2764"},
        {"Geneva Identification System", "GEN# +3.23910021"},
        {"Renson", "Renson 20680"},
        {"Smithsonian Astrophysical Observation", "SAO 236165"},
        {"Wilson Evans Batten Catalogue", "WEB 8205"},
        {"New General Catalogue", "NGC 2391 21"},
    },
    visualMagnitude: 5.56,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07287030),
        dec: Angle.Degrees(-53.01545412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11240"},
        {"Hipparcos Number", "HIP 8462"},
        {"Smithsonian Astrophysical Observation", "SAO 232533"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.28327583),
        dec: Angle.Degrees(-53.01137564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122924"},
        {"Hipparcos Number", "HIP 68884"},
        {"Smithsonian Astrophysical Observation", "SAO 241441"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.56337321),
        dec: Angle.Degrees(-53.00990743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27199"},
        {"Hipparcos Number", "HIP 19826"},
        {"Smithsonian Astrophysical Observation", "SAO 233449"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.77246661),
        dec: Angle.Degrees(-53.00904394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32556"},
        {"Hipparcos Number", "HIP 23334"},
        {"Smithsonian Astrophysical Observation", "SAO 233785"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.28811010),
        dec: Angle.Degrees(-53.00887572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184192"},
        {"Hipparcos Number", "HIP 96399"},
        {"Smithsonian Astrophysical Observation", "SAO 246178"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.98837611),
        dec: Angle.Degrees(-53.00796334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202233"},
        {"Hipparcos Number", "HIP 105031"},
        {"Smithsonian Astrophysical Observation", "SAO 246939"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.11221288),
        dec: Angle.Degrees(-53.00439653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128636"},
        {"Hipparcos Number", "HIP 71693"},
        {"Geneva Identification System", "GEN# +1.00128636J"},
        {"Smithsonian Astrophysical Observation", "SAO 241889"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.98876823),
        dec: Angle.Degrees(-53.00143181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112779"},
        {"Hipparcos Number", "HIP 63430"},
        {"Smithsonian Astrophysical Observation", "SAO 240460"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.97632050),
        dec: Angle.Degrees(-53.00122844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68248"},
        {"Hipparcos Number", "HIP 39900"},
        {"Smithsonian Astrophysical Observation", "SAO 235773"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.24088211),
        dec: Angle.Degrees(-53.00119165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154076"},
        {"Hipparcos Number", "HIP 83667"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.52996800),
        dec: Angle.Degrees(-53.00072070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151821"},
        {"Hipparcos Number", "HIP 82555"},
        {"Smithsonian Astrophysical Observation", "SAO 244223"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.11723182),
        dec: Angle.Degrees(-52.99877174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176520"},
        {"Hipparcos Number", "HIP 93579"},
        {"Geneva Identification System", "GEN# +1.00176520"},
        {"Smithsonian Astrophysical Observation", "SAO 245892"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.88379175),
        dec: Angle.Degrees(-52.99786625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156086"},
        {"Hipparcos Number", "HIP 84661"},
        {"Smithsonian Astrophysical Observation", "SAO 244604"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.196,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.60767035),
        dec: Angle.Degrees(-52.99688090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103179"},
        {"Hipparcos Number", "HIP 57916"},
        {"Smithsonian Astrophysical Observation", "SAO 239452"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.18486198),
        dec: Angle.Degrees(-52.99393475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192816"},
        {"Hipparcos Number", "HIP 100189"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.83160523),
        dec: Angle.Degrees(-52.98778451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86249",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159406"},
        {"Hipparcos Number", "HIP 86249"},
        {"Smithsonian Astrophysical Observation", "SAO 244890"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.36484299),
        dec: Angle.Degrees(-52.98721750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63040"},
    },
    visualMagnitude: 12.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.76656722),
        dec: Angle.Degrees(-52.98642868)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171650"},
        {"Hipparcos Number", "HIP 91445"},
        {"Smithsonian Astrophysical Observation", "SAO 245605"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.74706360),
        dec: Angle.Degrees(-52.98588458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28826"},
        {"Hipparcos Number", "HIP 20973"},
        {"Geneva Identification System", "GEN# +1.00028826"},
        {"Smithsonian Astrophysical Observation", "SAO 233540"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.45873820),
        dec: Angle.Degrees(-52.98509441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65575"},
        {"Hipparcos Number", "HIP 38827"},
        {"Celescope Catalog", "CEL 2112"},
        {"Fundamental Katalog 5th Edition", "FK5 303"},
        {"Geneva Identification System", "GEN# +1.00065575"},
        {"Renson", "Renson 17960"},
        {"Smithsonian Astrophysical Observation", "SAO 235635"},
        {"Wilson Evans Batten Catalogue", "WEB 7602"},
    },
    visualMagnitude: 3.46,
    bvColour: -0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.19475729),
        dec: Angle.Degrees(-52.98240062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189228"},
        {"Hipparcos Number", "HIP 98586"},
        {"Smithsonian Astrophysical Observation", "SAO 246390"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.38213329),
        dec: Angle.Degrees(-52.98213090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211680"},
        {"Hipparcos Number", "HIP 110263"},
        {"Smithsonian Astrophysical Observation", "SAO 247407"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.01883326),
        dec: Angle.Degrees(-52.97941352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86288"},
        {"Hipparcos Number", "HIP 48697"},
        {"Celescope Catalog", "CEL 3406"},
        {"Geneva Identification System", "GEN# +1.00086288"},
        {"Smithsonian Astrophysical Observation", "SAO 237504"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.96733891),
        dec: Angle.Degrees(-52.97907807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26265"},
        {"Hipparcos Number", "HIP 19179"},
        {"Smithsonian Astrophysical Observation", "SAO 233399"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.66469071),
        dec: Angle.Degrees(-52.97867204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156869"},
        {"Hipparcos Number", "HIP 85044"},
        {"Geneva Identification System", "GEN# +1.00156869"},
        {"Renson", "Renson 44130"},
        {"Smithsonian Astrophysical Observation", "SAO 244683"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.71758963),
        dec: Angle.Degrees(-52.97809958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142118"},
        {"Hipparcos Number", "HIP 77954"},
        {"Geneva Identification System", "GEN# +1.00142118"},
        {"Smithsonian Astrophysical Observation", "SAO 243116"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.80106115),
        dec: Angle.Degrees(-52.97626778)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31407",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47306"},
        {"Hipparcos Number", "HIP 31407"},
        {"Fundamental Katalog 5th Edition", "FK5 2508"},
        {"Geneva Identification System", "GEN# +1.00047306"},
        {"Smithsonian Astrophysical Observation", "SAO 234589"},
        {"Wilson Evans Batten Catalogue", "WEB 6287"},
    },
    visualMagnitude: 4.35,
    bvColour: -0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.74411397),
        dec: Angle.Degrees(-52.97563454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24369",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34348"},
        {"Hipparcos Number", "HIP 24369"},
        {"Fundamental Katalog 5th Edition", "FK5 4477"},
        {"Geneva Identification System", "GEN# +1.00034348"},
        {"Smithsonian Astrophysical Observation", "SAO 233884"},
    },
    visualMagnitude: 7.52,
    bvColour: 1.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.43130218),
        dec: Angle.Degrees(-52.97547398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59172"},
    },
    visualMagnitude: 10.19,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.01630934),
        dec: Angle.Degrees(-52.97407390)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110784"},
        {"Hipparcos Number", "HIP 62203"},
        {"Smithsonian Astrophysical Observation", "SAO 240207"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.23098552),
        dec: Angle.Degrees(-52.97337060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140094"},
        {"Hipparcos Number", "HIP 77068"},
        {"Smithsonian Astrophysical Observation", "SAO 242890"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.04333579),
        dec: Angle.Degrees(-52.97317169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75105"},
        {"Hipparcos Number", "HIP 42988"},
        {"Celescope Catalog", "CEL 2875"},
        {"Geneva Identification System", "GEN# +3.23910046"},
        {"Renson", "Renson 21000"},
        {"Smithsonian Astrophysical Observation", "SAO 236249"},
        {"New General Catalogue", "NGC 2669 2"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.43177634),
        dec: Angle.Degrees(-52.97170703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98105",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98105"},
    },
    visualMagnitude: 10.58,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.06587327),
        dec: Angle.Degrees(-52.97099474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39987",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39987"},
        {"Cincinnati Publication", "Ci 20 463"},
        {"Geneva Identification System", "GEN# +9.86242066"},
    },
    visualMagnitude: 11.74,
    bvColour: 1.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.49395940),
        dec: Angle.Degrees(-52.96979883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -516.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 669.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61033"},
        {"Hipparcos Number", "HIP 36832"},
        {"Geneva Identification System", "GEN# +1.00061033"},
        {"Smithsonian Astrophysical Observation", "SAO 235307"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.61694655),
        dec: Angle.Degrees(-52.96883889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 279.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74516"},
        {"Hipparcos Number", "HIP 42702"},
        {"Celescope Catalog", "CEL 2803"},
        {"Geneva Identification System", "GEN# +3.23910029"},
        {"Smithsonian Astrophysical Observation", "SAO 236198"},
        {"Wilson Evans Batten Catalogue", "WEB 8247"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.54158740),
        dec: Angle.Degrees(-52.96773884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124527"},
        {"Hipparcos Number", "HIP 69672"},
        {"Smithsonian Astrophysical Observation", "SAO 241573"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.91244016),
        dec: Angle.Degrees(-52.96770276)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1424"},
        {"Hipparcos Number", "HIP 1457"},
        {"Smithsonian Astrophysical Observation", "SAO 231991"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.54156724),
        dec: Angle.Degrees(-52.96753468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151053"},
        {"Hipparcos Number", "HIP 82208"},
        {"Smithsonian Astrophysical Observation", "SAO 244146"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.91745537),
        dec: Angle.Degrees(-52.96726492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91539"},
        {"Hipparcos Number", "HIP 51647"},
        {"Smithsonian Astrophysical Observation", "SAO 238170"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.28233232),
        dec: Angle.Degrees(-52.96718151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165027"},
        {"Hipparcos Number", "HIP 88736"},
        {"Geneva Identification System", "GEN# +1.00165027"},
        {"Smithsonian Astrophysical Observation", "SAO 245245"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.72923531),
        dec: Angle.Degrees(-52.96695617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -102.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215496"},
        {"Hipparcos Number", "HIP 112439"},
        {"Smithsonian Astrophysical Observation", "SAO 247577"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.63057786),
        dec: Angle.Degrees(-52.96547331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217614"},
        {"Hipparcos Number", "HIP 113799"},
        {"Geneva Identification System", "GEN# +1.00217614"},
        {"Smithsonian Astrophysical Observation", "SAO 247697"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.68420364),
        dec: Angle.Degrees(-52.96533786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15279"},
        {"Hipparcos Number", "HIP 11337"},
        {"Geneva Identification System", "GEN# +1.00015279"},
        {"Smithsonian Astrophysical Observation", "SAO 232765"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.46716038),
        dec: Angle.Degrees(-52.96440555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10940",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14745"},
        {"Hipparcos Number", "HIP 10940"},
        {"Geneva Identification System", "GEN# +1.00014745"},
        {"Smithsonian Astrophysical Observation", "SAO 232725"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.22491638),
        dec: Angle.Degrees(-52.96377042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212649"},
        {"Hipparcos Number", "HIP 110811"},
        {"Smithsonian Astrophysical Observation", "SAO 247450"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.75745183),
        dec: Angle.Degrees(-52.96280842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61948"},
        {"Hipparcos Number", "HIP 37245"},
        {"Geneva Identification System", "GEN# +1.00061948"},
        {"Smithsonian Astrophysical Observation", "SAO 235389"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.74413886),
        dec: Angle.Degrees(-52.96202824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72164"},
        {"Hipparcos Number", "HIP 41606"},
        {"Smithsonian Astrophysical Observation", "SAO 236020"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.22907006),
        dec: Angle.Degrees(-52.96119696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97553"},
        {"Hipparcos Number", "HIP 54784"},
        {"Smithsonian Astrophysical Observation", "SAO 238866"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.880,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.23669795),
        dec: Angle.Degrees(-52.95751896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27739"},
        {"Hipparcos Number", "HIP 20217"},
        {"Smithsonian Astrophysical Observation", "SAO 233487"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.556,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.98363837),
        dec: Angle.Degrees(-52.95724859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88318",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164039"},
        {"Hipparcos Number", "HIP 88318"},
        {"Smithsonian Astrophysical Observation", "SAO 245185"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.54845599),
        dec: Angle.Degrees(-52.95701256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2458"},
        {"Hipparcos Number", "HIP 2218"},
        {"Smithsonian Astrophysical Observation", "SAO 232052"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.00905287),
        dec: Angle.Degrees(-52.95232677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16699"},
        {"Hipparcos Number", "HIP 12326"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.68419973),
        dec: Angle.Degrees(-52.95096711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96538"},
        {"Hipparcos Number", "HIP 54317"},
        {"Smithsonian Astrophysical Observation", "SAO 238781"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.67883733),
        dec: Angle.Degrees(-52.95068316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185559"},
        {"Hipparcos Number", "HIP 96934"},
        {"Smithsonian Astrophysical Observation", "SAO 246224"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.56608407),
        dec: Angle.Degrees(-52.94916720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142258"},
        {"Hipparcos Number", "HIP 78037"},
        {"Smithsonian Astrophysical Observation", "SAO 243136"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.01375928),
        dec: Angle.Degrees(-52.94892531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47172",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83465"},
        {"Hipparcos Number", "HIP 47172"},
        {"Geneva Identification System", "GEN# +1.00083465"},
        {"Smithsonian Astrophysical Observation", "SAO 237144"},
        {"Wilson Evans Batten Catalogue", "WEB 8872"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.19337925),
        dec: Angle.Degrees(-52.94390589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 96.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83853"},
        {"Hipparcos Number", "HIP 47394"},
        {"Fundamental Katalog 5th Edition", "FK5 4856"},
        {"Geneva Identification System", "GEN# +1.00083853"},
        {"Smithsonian Astrophysical Observation", "SAO 237191"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.84741410),
        dec: Angle.Degrees(-52.94331288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208985"},
        {"Hipparcos Number", "HIP 108729"},
        {"Geneva Identification System", "GEN# +1.00208985"},
        {"Smithsonian Astrophysical Observation", "SAO 247272"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.37785253),
        dec: Angle.Degrees(-52.94199150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151231"},
        {"Hipparcos Number", "HIP 82292"},
        {"Smithsonian Astrophysical Observation", "SAO 244158"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.22402362),
        dec: Angle.Degrees(-52.94081511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175510"},
        {"Hipparcos Number", "HIP 93148"},
        {"Fundamental Katalog 5th Edition", "FK5 708"},
        {"Geneva Identification System", "GEN# +1.00175510"},
        {"Smithsonian Astrophysical Observation", "SAO 245834"},
        {"Wilson Evans Batten Catalogue", "WEB 16137"},
    },
    visualMagnitude: 4.85,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.61564682),
        dec: Angle.Degrees(-52.93860748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16743"},
        {"Hipparcos Number", "HIP 12361"},
        {"Geneva Identification System", "GEN# +1.00016743"},
        {"Smithsonian Astrophysical Observation", "SAO 232847"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.78121504),
        dec: Angle.Degrees(-52.93492756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 49.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172"},
        {"Hipparcos Number", "HIP 534"},
        {"Smithsonian Astrophysical Observation", "SAO 231926"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.349,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.61464392),
        dec: Angle.Degrees(-52.93312701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10555"},
        {"Hipparcos Number", "HIP 7899"},
        {"Geneva Identification System", "GEN# +1.00010555"},
        {"Smithsonian Astrophysical Observation", "SAO 232496"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.39730887),
        dec: Angle.Degrees(-52.93237494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 144.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48024"},
        {"Hipparcos Number", "HIP 31738"},
        {"Smithsonian Astrophysical Observation", "SAO 234627"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.59594423),
        dec: Angle.Degrees(-52.93212768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25061"},
        {"Hipparcos Number", "HIP 18427"},
        {"Geneva Identification System", "GEN# +1.00025061"},
        {"Smithsonian Astrophysical Observation", "SAO 233333"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.843,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.10444660),
        dec: Angle.Degrees(-52.93145865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 240.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 243.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207043"},
        {"Hipparcos Number", "HIP 107620"},
        {"Geneva Identification System", "GEN# +1.00207043"},
        {"Smithsonian Astrophysical Observation", "SAO 247185"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.97994773),
        dec: Angle.Degrees(-52.93042289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 101.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25913"},
        {"Hipparcos Number", "HIP 18952"},
        {"Geneva Identification System", "GEN# +1.00025913"},
        {"Smithsonian Astrophysical Observation", "SAO 233384"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.91874106),
        dec: Angle.Degrees(-52.92897013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20612"},
        {"Hipparcos Number", "HIP 15255"},
        {"Smithsonian Astrophysical Observation", "SAO 233059"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.19071688),
        dec: Angle.Degrees(-52.92815258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 298390"},
        {"Hipparcos Number", "HIP 45687"},
        {"Smithsonian Astrophysical Observation", "SAO 236840"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.70830309),
        dec: Angle.Degrees(-52.92513505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74195"},
        {"Hipparcos Number", "HIP 42536"},
        {"Celescope Catalog", "CEL 2762"},
        {"Fundamental Katalog 5th Edition", "FK5 1227"},
        {"Geneva Identification System", "GEN# +3.23910020"},
        {"Smithsonian Astrophysical Observation", "SAO 236164"},
        {"Wilson Evans Batten Catalogue", "WEB 8204"},
    },
    visualMagnitude: 3.60,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.07337168),
        dec: Angle.Degrees(-52.92197259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9467"},
        {"Hipparcos Number", "HIP 7121"},
        {"Smithsonian Astrophysical Observation", "SAO 232452"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.93893135),
        dec: Angle.Degrees(-52.92088328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156238"},
        {"Hipparcos Number", "HIP 84733"},
        {"Smithsonian Astrophysical Observation", "SAO 244620"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.709,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.81795141),
        dec: Angle.Degrees(-52.91827091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87254",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161656"},
        {"Hipparcos Number", "HIP 87254"},
        {"Smithsonian Astrophysical Observation", "SAO 245057"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.42856012),
        dec: Angle.Degrees(-52.91664965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111114"},
    },
    visualMagnitude: 11.19,
    bvColour: 0.860,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.64453838),
        dec: Angle.Degrees(-52.91655484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 222.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85615",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85615"},
    },
    visualMagnitude: 11.45,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.43145294),
        dec: Angle.Degrees(-52.91655091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17096",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Tupi"},
        {"Henry Draper", "HD 23079"},
        {"Hipparcos Number", "HIP 17096"},
        {"Geneva Identification System", "GEN# +1.00023079"},
        {"Smithsonian Astrophysical Observation", "SAO 233208"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.93034384),
        dec: Angle.Degrees(-52.91561462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31671"},
        {"Hipparcos Number", "HIP 22839"},
        {"Smithsonian Astrophysical Observation", "SAO 233731"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.71020636),
        dec: Angle.Degrees(-52.91522584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79361",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79361"},
        {"Cincinnati Publication", "Ci 20 970"},
        {"Geneva Identification System", "GEN# -0.05209317"},
    },
    visualMagnitude: 10.50,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.95710430),
        dec: Angle.Degrees(-52.91452189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -238.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -359.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200541"},
        {"Hipparcos Number", "HIP 104155"},
        {"Geneva Identification System", "GEN# +1.00200541"},
        {"Smithsonian Astrophysical Observation", "SAO 246867"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.52579809),
        dec: Angle.Degrees(-52.91413106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133535"},
        {"Hipparcos Number", "HIP 73978"},
        {"Smithsonian Astrophysical Observation", "SAO 242232"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.78092269),
        dec: Angle.Degrees(-52.91198244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114351"},
        {"Hipparcos Number", "HIP 64307"},
        {"Smithsonian Astrophysical Observation", "SAO 240623"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.70777345),
        dec: Angle.Degrees(-52.90757683)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113901"},
        {"Hipparcos Number", "HIP 64044"},
        {"Smithsonian Astrophysical Observation", "SAO 240571"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.88972892),
        dec: Angle.Degrees(-52.90543870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145255"},
        {"Hipparcos Number", "HIP 79424"},
        {"Smithsonian Astrophysical Observation", "SAO 243433"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.271,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.14299263),
        dec: Angle.Degrees(-52.90446675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27553"},
        {"Hipparcos Number", "HIP 20074"},
        {"Geneva Identification System", "GEN# +1.00027553"},
        {"Smithsonian Astrophysical Observation", "SAO 233472"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.56360246),
        dec: Angle.Degrees(-52.90248623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 72.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38690",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65249"},
        {"Hipparcos Number", "HIP 38690"},
        {"Geneva Identification System", "GEN# +1.00065249"},
        {"Smithsonian Astrophysical Observation", "SAO 235617"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.81564511),
        dec: Angle.Degrees(-52.90241261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 38.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115303"},
        {"Hipparcos Number", "HIP 64817"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.29589572),
        dec: Angle.Degrees(-52.90186082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78026"},
        {"Hipparcos Number", "HIP 44491"},
        {"Smithsonian Astrophysical Observation", "SAO 236550"},
    },
    visualMagnitude: 7.82,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.97137688),
        dec: Angle.Degrees(-52.89862257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60227"},
        {"Hipparcos Number", "HIP 36510"},
        {"Geneva Identification System", "GEN# +1.00060227"},
        {"Smithsonian Astrophysical Observation", "SAO 235256"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.66604841),
        dec: Angle.Degrees(-52.89730737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120208"},
        {"Hipparcos Number", "HIP 67441"},
        {"Smithsonian Astrophysical Observation", "SAO 241201"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.32542796),
        dec: Angle.Degrees(-52.89642241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70850",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126788"},
        {"Hipparcos Number", "HIP 70850"},
        {"Geneva Identification System", "GEN# +1.00126788"},
        {"Smithsonian Astrophysical Observation", "SAO 241745"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.32826905),
        dec: Angle.Degrees(-52.89461844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41779"},
        {"Hipparcos Number", "HIP 28741"},
        {"Geneva Identification System", "GEN# +1.00041779"},
        {"Smithsonian Astrophysical Observation", "SAO 234287"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.05008006),
        dec: Angle.Degrees(-52.89364894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86601"},
        {"Hipparcos Number", "HIP 48868"},
        {"Celescope Catalog", "CEL 3417"},
        {"Geneva Identification System", "GEN# +1.00086601"},
        {"Smithsonian Astrophysical Observation", "SAO 237542"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50381031),
        dec: Angle.Degrees(-52.89308372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170873"},
        {"Hipparcos Number", "HIP 91062"},
        {"Geneva Identification System", "GEN# +1.00170873"},
        {"Smithsonian Astrophysical Observation", "SAO 245559"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.62972810),
        dec: Angle.Degrees(-52.89141853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101117"},
        {"Hipparcos Number", "HIP 56725"},
        {"Geneva Identification System", "GEN# +1.00101117"},
        {"Smithsonian Astrophysical Observation", "SAO 239239"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.45024166),
        dec: Angle.Degrees(-52.89098526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200114"},
        {"Hipparcos Number", "HIP 103934"},
        {"Geneva Identification System", "GEN# +1.00200114"},
        {"Smithsonian Astrophysical Observation", "SAO 246838"},
        {"Wilson Evans Batten Catalogue", "WEB 18925"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.88129565),
        dec: Angle.Degrees(-52.88917188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20092"},
        {"Hipparcos Number", "HIP 14836"},
        {"Smithsonian Astrophysical Observation", "SAO 233030"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.90051851),
        dec: Angle.Degrees(-52.88916816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14196"},
        {"Hipparcos Number", "HIP 10570"},
        {"Geneva Identification System", "GEN# +1.00014196"},
        {"Smithsonian Astrophysical Observation", "SAO 232692"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.01187443),
        dec: Angle.Degrees(-52.88873196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165561"},
        {"Hipparcos Number", "HIP 88956"},
        {"Smithsonian Astrophysical Observation", "SAO 245270"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.36669062),
        dec: Angle.Degrees(-52.88869947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85623"},
        {"Hipparcos Number", "HIP 48350"},
        {"Geneva Identification System", "GEN# +1.00085623"},
        {"Smithsonian Astrophysical Observation", "SAO 237414"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.84001844),
        dec: Angle.Degrees(-52.88868163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 121.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186756"},
        {"Hipparcos Number", "HIP 97491"},
        {"Fundamental Katalog 5th Edition", "FK5 3581"},
        {"Geneva Identification System", "GEN# +1.00186756"},
        {"Smithsonian Astrophysical Observation", "SAO 246277"},
    },
    visualMagnitude: 6.27,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.22947412),
        dec: Angle.Degrees(-52.88799211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140623"},
        {"Hipparcos Number", "HIP 77311"},
        {"Smithsonian Astrophysical Observation", "SAO 242956"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.75111973),
        dec: Angle.Degrees(-52.88791917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18109"},
        {"Hipparcos Number", "HIP 13400"},
        {"Smithsonian Astrophysical Observation", "SAO 232925"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.11934865),
        dec: Angle.Degrees(-52.88733020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189406"},
        {"Hipparcos Number", "HIP 98669"},
        {"Geneva Identification System", "GEN# +1.00189406"},
        {"Smithsonian Astrophysical Observation", "SAO 246402"},
        {"Wilson Evans Batten Catalogue", "WEB 17462"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.61481264),
        dec: Angle.Degrees(-52.88668515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81351"},
        {"Hipparcos Number", "HIP 46020"},
        {"Geneva Identification System", "GEN# +1.00081351"},
        {"Smithsonian Astrophysical Observation", "SAO 236912"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.77968509),
        dec: Angle.Degrees(-52.88580464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171210"},
        {"Hipparcos Number", "HIP 91207"},
        {"Smithsonian Astrophysical Observation", "SAO 245579"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.08755609),
        dec: Angle.Degrees(-52.88337671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12963"},
        {"Hipparcos Number", "HIP 9741"},
        {"Smithsonian Astrophysical Observation", "SAO 232625"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.32556419),
        dec: Angle.Degrees(-52.88331029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186877"},
        {"Hipparcos Number", "HIP 97541"},
        {"Smithsonian Astrophysical Observation", "SAO 246281"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.37150453),
        dec: Angle.Degrees(-52.88319076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123626"},
        {"Hipparcos Number", "HIP 69218"},
        {"Geneva Identification System", "GEN# +1.00123626"},
        {"Smithsonian Astrophysical Observation", "SAO 241499"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.542,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.56567115),
        dec: Angle.Degrees(-52.88316369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156792"},
        {"Hipparcos Number", "HIP 84994"},
        {"Smithsonian Astrophysical Observation", "SAO 244671"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.58782043),
        dec: Angle.Degrees(-52.88238967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -121.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190421"},
        {"Hipparcos Number", "HIP 99120"},
        {"Fundamental Katalog 5th Edition", "FK5 755"},
        {"Geneva Identification System", "GEN# +1.00190421"},
        {"Smithsonian Astrophysical Observation", "SAO 246443"},
        {"Wilson Evans Batten Catalogue", "WEB 17634"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.84653576),
        dec: Angle.Degrees(-52.88080972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75227"},
        {"Hipparcos Number", "HIP 43083"},
        {"Geneva Identification System", "GEN# +2.26690004"},
        {"Smithsonian Astrophysical Observation", "SAO 236263"},
        {"New General Catalogue", "NGC 2669 4"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.63041712),
        dec: Angle.Degrees(-52.87820815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133755"},
        {"Hipparcos Number", "HIP 74071"},
        {"Renson", "Renson 37950"},
        {"Smithsonian Astrophysical Observation", "SAO 242247"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.05773398),
        dec: Angle.Degrees(-52.87748015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16361"},
        {"Hipparcos Number", "HIP 12074"},
        {"Smithsonian Astrophysical Observation", "SAO 232827"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.91202515),
        dec: Angle.Degrees(-52.87647884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88321"},
        {"Hipparcos Number", "HIP 49781"},
        {"Celescope Catalog", "CEL 3452"},
        {"Smithsonian Astrophysical Observation", "SAO 237747"},
    },
    visualMagnitude: 8.03,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.42506747),
        dec: Angle.Degrees(-52.87589402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111708",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111708"},
        {"Geneva Identification System", "GEN# -0.05310320"},
        {"Smithsonian Astrophysical Observation", "SAO 247519"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.946,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.43310530),
        dec: Angle.Degrees(-52.87582539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111715",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111715"},
    },
    visualMagnitude: 12.09,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.44463077),
        dec: Angle.Degrees(-52.87357098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46435"},
        {"Hipparcos Number", "HIP 30995"},
        {"Geneva Identification System", "GEN# +1.00046435"},
        {"Smithsonian Astrophysical Observation", "SAO 234548"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.58021620),
        dec: Angle.Degrees(-52.87154544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23696",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23696"},
        {"Geneva Identification System", "GEN# -0.05300794"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.38444638),
        dec: Angle.Degrees(-52.86864417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125532"},
        {"Hipparcos Number", "HIP 70184"},
        {"Geneva Identification System", "GEN# +1.00125532"},
        {"Renson", "Renson 35850"},
        {"Smithsonian Astrophysical Observation", "SAO 241663"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.38852092),
        dec: Angle.Degrees(-52.86610171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172494"},
        {"Hipparcos Number", "HIP 91832"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.84565687),
        dec: Angle.Degrees(-52.86229397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27604"},
        {"Hipparcos Number", "HIP 20109"},
        {"Fundamental Katalog 5th Edition", "FK5 2318"},
        {"Geneva Identification System", "GEN# +1.00027604"},
        {"Smithsonian Astrophysical Observation", "SAO 233476"},
        {"Wilson Evans Batten Catalogue", "WEB 3840"},
    },
    visualMagnitude: 6.08,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.66658653),
        dec: Angle.Degrees(-52.86027488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156220"},
        {"Hipparcos Number", "HIP 84730"},
        {"Smithsonian Astrophysical Observation", "SAO 244617"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.79631838),
        dec: Angle.Degrees(-52.85886283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158008"},
        {"Hipparcos Number", "HIP 85604"},
        {"Smithsonian Astrophysical Observation", "SAO 244786"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.39986071),
        dec: Angle.Degrees(-52.85866092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17196"},
        {"Hipparcos Number", "HIP 12727"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.89950688),
        dec: Angle.Degrees(-52.85635584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20732"},
        {"Hipparcos Number", "HIP 15359"},
        {"Smithsonian Astrophysical Observation", "SAO 233066"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.51576704),
        dec: Angle.Degrees(-52.85589372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97689"},
        {"Hipparcos Number", "HIP 54854"},
        {"Geneva Identification System", "GEN# +1.00097689"},
        {"Renson", "Renson 28180"},
        {"Smithsonian Astrophysical Observation", "SAO 238882"},
        {"Wilson Evans Batten Catalogue", "WEB 9898"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.46137724),
        dec: Angle.Degrees(-52.85575290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21036"},
        {"Hipparcos Number", "HIP 15642"},
        {"Geneva Identification System", "GEN# +1.00021036"},
        {"Smithsonian Astrophysical Observation", "SAO 233079"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.34893066),
        dec: Angle.Degrees(-52.85544515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 130.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164441"},
        {"Hipparcos Number", "HIP 88487"},
        {"Smithsonian Astrophysical Observation", "SAO 245212"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.02751917),
        dec: Angle.Degrees(-52.85518219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104250"},
        {"Hipparcos Number", "HIP 58534"},
        {"Smithsonian Astrophysical Observation", "SAO 239568"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.05714822),
        dec: Angle.Degrees(-52.85400185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136739"},
        {"Hipparcos Number", "HIP 75430"},
        {"Geneva Identification System", "GEN# +1.00136739"},
        {"Smithsonian Astrophysical Observation", "SAO 242485"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.15975672),
        dec: Angle.Degrees(-52.85385483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14834",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14834"},
        {"Smithsonian Astrophysical Observation", "SAO 233028"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.88507901),
        dec: Angle.Degrees(-52.85071492)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75466"},
        {"Hipparcos Number", "HIP 43195"},
        {"Celescope Catalog", "CEL 2934"},
        {"Geneva Identification System", "GEN# +3.23910050"},
        {"Smithsonian Astrophysical Observation", "SAO 236284"},
        {"Wilson Evans Batten Catalogue", "WEB 8331"},
    },
    visualMagnitude: 6.29,
    bvColour: -0.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.00101403),
        dec: Angle.Degrees(-52.85020780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31946"},
        {"Hipparcos Number", "HIP 23005"},
        {"Renson", "Renson 8110"},
        {"Smithsonian Astrophysical Observation", "SAO 233750"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.22088992),
        dec: Angle.Degrees(-52.84987032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173684"},
        {"Hipparcos Number", "HIP 92368"},
        {"Smithsonian Astrophysical Observation", "SAO 245734"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.36481668),
        dec: Angle.Degrees(-52.84891669)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137754"},
        {"Hipparcos Number", "HIP 75887"},
        {"Smithsonian Astrophysical Observation", "SAO 242615"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.50106896),
        dec: Angle.Degrees(-52.84746163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75202"},
        {"Hipparcos Number", "HIP 43071"},
        {"Geneva Identification System", "GEN# +3.23910049"},
        {"Renson", "Renson 21060"},
        {"Smithsonian Astrophysical Observation", "SAO 236261"},
        {"New General Catalogue", "NGC 2669 3"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59666548),
        dec: Angle.Degrees(-52.84376324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224645"},
        {"Hipparcos Number", "HIP 118288"},
        {"Geneva Identification System", "GEN# +1.00224645"},
        {"Smithsonian Astrophysical Observation", "SAO 248091"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.88362552),
        dec: Angle.Degrees(-52.84351374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99130"},
        {"Hipparcos Number", "HIP 55634"},
        {"Geneva Identification System", "GEN# +1.00099130"},
        {"Smithsonian Astrophysical Observation", "SAO 239030"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.96306882),
        dec: Angle.Degrees(-52.84211724)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44510",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44510"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.03810013),
        dec: Angle.Degrees(-52.84110031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 74.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 363.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11938"},
        {"Hipparcos Number", "HIP 8987"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.95413022),
        dec: Angle.Degrees(-52.84090003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 40.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103857"},
        {"Hipparcos Number", "HIP 58311"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.36273588),
        dec: Angle.Degrees(-52.84051623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62941"},
        {"Hipparcos Number", "HIP 37663"},
        {"Geneva Identification System", "GEN# +1.00062941"},
        {"Smithsonian Astrophysical Observation", "SAO 235449"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.91739088),
        dec: Angle.Degrees(-52.83954714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195488"},
        {"Hipparcos Number", "HIP 101479"},
        {"Geneva Identification System", "GEN# +1.00195488"},
        {"Smithsonian Astrophysical Observation", "SAO 246633"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.48342973),
        dec: Angle.Degrees(-52.83911819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219620"},
        {"Hipparcos Number", "HIP 115020"},
        {"Smithsonian Astrophysical Observation", "SAO 247816"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.985,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.43313005),
        dec: Angle.Degrees(-52.83781172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6535"},
        {"Hipparcos Number", "HIP 5098"},
        {"Smithsonian Astrophysical Observation", "SAO 232291"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.34100142),
        dec: Angle.Degrees(-52.83735552)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173603"},
        {"Hipparcos Number", "HIP 92328"},
        {"Geneva Identification System", "GEN# +1.00173603"},
        {"Smithsonian Astrophysical Observation", "SAO 245727"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.26044888),
        dec: Angle.Degrees(-52.83496759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31860",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48267"},
        {"Hipparcos Number", "HIP 31860"},
        {"Smithsonian Astrophysical Observation", "SAO 234643"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.90568182),
        dec: Angle.Degrees(-52.83246681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82932"},
        {"Hipparcos Number", "HIP 46887"},
        {"Celescope Catalog", "CEL 3324"},
        {"Geneva Identification System", "GEN# +1.00082932"},
        {"Smithsonian Astrophysical Observation", "SAO 237093"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.31910575),
        dec: Angle.Degrees(-52.83021629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67401",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120129"},
        {"Hipparcos Number", "HIP 67401"},
        {"Smithsonian Astrophysical Observation", "SAO 241194"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.20168496),
        dec: Angle.Degrees(-52.82986630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19369"},
        {"Hipparcos Number", "HIP 14326"},
        {"Smithsonian Astrophysical Observation", "SAO 232987"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.19456866),
        dec: Angle.Degrees(-52.82937216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88157"},
        {"Hipparcos Number", "HIP 49683"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.13258255),
        dec: Angle.Degrees(-52.82704640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76008"},
        {"Hipparcos Number", "HIP 43468"},
        {"Smithsonian Astrophysical Observation", "SAO 236328"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.81403528),
        dec: Angle.Degrees(-52.82650171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220442"},
        {"Hipparcos Number", "HIP 115534"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.769,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.04530121),
        dec: Angle.Degrees(-52.82423424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146942"},
        {"Hipparcos Number", "HIP 80143"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.37165822),
        dec: Angle.Degrees(-52.82392680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217272"},
        {"Hipparcos Number", "HIP 113575"},
        {"Smithsonian Astrophysical Observation", "SAO 247675"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.06790533),
        dec: Angle.Degrees(-52.82186435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106013",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204128"},
        {"Hipparcos Number", "HIP 106013"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.08279269),
        dec: Angle.Degrees(-52.82071170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106"},
        {"Hipparcos Number", "HIP 486"},
        {"Smithsonian Astrophysical Observation", "SAO 231924"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.45705278),
        dec: Angle.Degrees(-52.82010001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87253"},
        {"Hipparcos Number", "HIP 49181"},
        {"Smithsonian Astrophysical Observation", "SAO 237624"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.56496421),
        dec: Angle.Degrees(-52.81950532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171563"},
        {"Hipparcos Number", "HIP 91404"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.61767406),
        dec: Angle.Degrees(-52.81946690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7125"},
        {"Hipparcos Number", "HIP 5503"},
        {"Smithsonian Astrophysical Observation", "SAO 232326"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.62487952),
        dec: Angle.Degrees(-52.81912446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86570"},
        {"Hipparcos Number", "HIP 48848"},
        {"Smithsonian Astrophysical Observation", "SAO 237535"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.45271790),
        dec: Angle.Degrees(-52.81823095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145927"},
        {"Hipparcos Number", "HIP 79715"},
        {"Geneva Identification System", "GEN# +1.00145927"},
        {"Smithsonian Astrophysical Observation", "SAO 243520"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.02721093),
        dec: Angle.Degrees(-52.81452662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97961"},
        {"Hipparcos Number", "HIP 54977"},
        {"Geneva Identification System", "GEN# +1.00097961"},
        {"Smithsonian Astrophysical Observation", "SAO 238908"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.765,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.85802906),
        dec: Angle.Degrees(-52.81324155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186404"},
        {"Hipparcos Number", "HIP 97323"},
        {"Smithsonian Astrophysical Observation", "SAO 246264"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.67468911),
        dec: Angle.Degrees(-52.81266350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114512"},
        {"Hipparcos Number", "HIP 64391"},
        {"Fundamental Katalog 5th Edition", "FK5 5164"},
        {"Smithsonian Astrophysical Observation", "SAO 240641"},
    },
    visualMagnitude: 7.02,
    bvColour: 1.705,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.96825087),
        dec: Angle.Degrees(-52.81229305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120642"},
        {"Hipparcos Number", "HIP 67703"},
        {"Celescope Catalog", "CEL 4283"},
        {"Geneva Identification System", "GEN# +1.00120642A"},
        {"Smithsonian Astrophysical Observation", "SAO 241239"},
        {"Wilson Evans Batten Catalogue", "WEB 11908"},
    },
    visualMagnitude: 5.26,
    bvColour: -0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.02041654),
        dec: Angle.Degrees(-52.81146355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15087"},
        {"Hipparcos Number", "HIP 11187"},
        {"Geneva Identification System", "GEN# +1.00015087"},
        {"Smithsonian Astrophysical Observation", "SAO 232751"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.870,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.01548338),
        dec: Angle.Degrees(-52.81047454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61055"},
        {"Hipparcos Number", "HIP 36854"},
        {"Smithsonian Astrophysical Observation", "SAO 235311"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.66267771),
        dec: Angle.Degrees(-52.81002258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67702",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120641"},
        {"Hipparcos Number", "HIP 67702"},
        {"Geneva Identification System", "GEN# +1.00120641"},
        {"Smithsonian Astrophysical Observation", "SAO 241238"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.01253487),
        dec: Angle.Degrees(-52.80985105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131562"},
        {"Hipparcos Number", "HIP 73095"},
        {"Fundamental Katalog 5th Edition", "FK5 3176"},
        {"Geneva Identification System", "GEN# +1.00131562"},
        {"Smithsonian Astrophysical Observation", "SAO 242120"},
        {"Wilson Evans Batten Catalogue", "WEB 12530"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.07177099),
        dec: Angle.Degrees(-52.80956707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16879"},
        {"Hipparcos Number", "HIP 12462"},
        {"Smithsonian Astrophysical Observation", "SAO 232855"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.11835211),
        dec: Angle.Degrees(-52.80890689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194970"},
        {"Hipparcos Number", "HIP 101201"},
        {"Fundamental Katalog 5th Edition", "FK5 5809"},
        {"Smithsonian Astrophysical Observation", "SAO 246618"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.70247528),
        dec: Angle.Degrees(-52.80800659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71722"},
        {"Hipparcos Number", "HIP 41373"},
        {"Fundamental Katalog 5th Edition", "FK5 2661"},
        {"Geneva Identification System", "GEN# +1.00071722"},
        {"Smithsonian Astrophysical Observation", "SAO 235976"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.60517431),
        dec: Angle.Degrees(-52.80750215)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196191"},
        {"Hipparcos Number", "HIP 101819"},
        {"Geneva Identification System", "GEN# +1.00196191"},
        {"Smithsonian Astrophysical Observation", "SAO 246668"},
    },
    visualMagnitude: 8.66,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.49588039),
        dec: Angle.Degrees(-52.80585528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21396",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29455"},
        {"Hipparcos Number", "HIP 21396"},
        {"Smithsonian Astrophysical Observation", "SAO 233581"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.89366944),
        dec: Angle.Degrees(-52.80567754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1408",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1408"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.41138633),
        dec: Angle.Degrees(-52.80123958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 97.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78405"},
        {"Hipparcos Number", "HIP 44655"},
        {"Celescope Catalog", "CEL 3182"},
        {"Geneva Identification System", "GEN# +1.00078405"},
        {"Smithsonian Astrophysical Observation", "SAO 236596"},
    },
    visualMagnitude: 8.28,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.48746455),
        dec: Angle.Degrees(-52.80096077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32796",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50415"},
        {"Hipparcos Number", "HIP 32796"},
        {"Smithsonian Astrophysical Observation", "SAO 234740"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.55799922),
        dec: Angle.Degrees(-52.80004275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42836"},
        {"Hipparcos Number", "HIP 29250"},
        {"Geneva Identification System", "GEN# +1.00042836"},
        {"Smithsonian Astrophysical Observation", "SAO 234355"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.50712340),
        dec: Angle.Degrees(-52.79947246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224851"},
        {"Hipparcos Number", "HIP 98"},
        {"Smithsonian Astrophysical Observation", "SAO 248102"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.30717811),
        dec: Angle.Degrees(-52.79857954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160307"},
        {"Hipparcos Number", "HIP 86632"},
        {"Smithsonian Astrophysical Observation", "SAO 244953"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.52057288),
        dec: Angle.Degrees(-52.79713759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40869"},
        {"Hipparcos Number", "HIP 28292"},
        {"Geneva Identification System", "GEN# +1.00040869"},
        {"Renson", "Renson 10920"},
        {"Smithsonian Astrophysical Observation", "SAO 234233"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.291,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.67139327),
        dec: Angle.Degrees(-52.79234881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108924"},
        {"Hipparcos Number", "HIP 61093"},
        {"Smithsonian Astrophysical Observation", "SAO 240023"},
    },
    visualMagnitude: 7.35,
    bvColour: 1.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.81503886),
        dec: Angle.Degrees(-52.79234314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118003",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224211"},
        {"Hipparcos Number", "HIP 118003"},
        {"Geneva Identification System", "GEN# +1.00224211"},
        {"Smithsonian Astrophysical Observation", "SAO 248065"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.03027457),
        dec: Angle.Degrees(-52.78803605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12798",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17278"},
        {"Hipparcos Number", "HIP 12798"},
        {"Geneva Identification System", "GEN# +1.00017278"},
        {"Smithsonian Astrophysical Observation", "SAO 232874"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.12182705),
        dec: Angle.Degrees(-52.78758923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37611"},
        {"Hipparcos Number", "HIP 26357"},
        {"Smithsonian Astrophysical Observation", "SAO 234048"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.18804574),
        dec: Angle.Degrees(-52.78743037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111588"},
        {"Hipparcos Number", "HIP 62703"},
        {"Fundamental Katalog 5th Edition", "FK5 3023"},
        {"Geneva Identification System", "GEN# +1.00111588"},
        {"Renson", "Renson 32380"},
        {"Smithsonian Astrophysical Observation", "SAO 240314"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.74126496),
        dec: Angle.Degrees(-52.78739520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125791"},
        {"Hipparcos Number", "HIP 70329"},
        {"Smithsonian Astrophysical Observation", "SAO 241685"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.84638166),
        dec: Angle.Degrees(-52.78147864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218217"},
        {"Hipparcos Number", "HIP 114138"},
        {"Smithsonian Astrophysical Observation", "SAO 247735"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.895,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.73715251),
        dec: Angle.Degrees(-52.78057351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22688"},
        {"Hipparcos Number", "HIP 16825"},
        {"Fundamental Katalog 5th Edition", "FK5 4322"},
        {"Geneva Identification System", "GEN# +1.00022688"},
        {"Smithsonian Astrophysical Observation", "SAO 233178"},
        {"Wilson Evans Batten Catalogue", "WEB 3201"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12221561),
        dec: Angle.Degrees(-52.77775122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106101"},
        {"Hipparcos Number", "HIP 59541"},
        {"Geneva Identification System", "GEN# +1.00106101"},
        {"Smithsonian Astrophysical Observation", "SAO 239753"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.14926722),
        dec: Angle.Degrees(-52.77746449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78362",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78362"},
    },
    visualMagnitude: 9.42,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.98473402),
        dec: Angle.Degrees(-52.77563858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137864"},
        {"Hipparcos Number", "HIP 75945"},
        {"Smithsonian Astrophysical Observation", "SAO 242635"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.802,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.67429768),
        dec: Angle.Degrees(-52.77123656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62626"},
        {"Hipparcos Number", "HIP 37539"},
        {"Smithsonian Astrophysical Observation", "SAO 235426"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.56386831),
        dec: Angle.Degrees(-52.77082866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
