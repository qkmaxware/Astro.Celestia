using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_69() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20125"},
        {"Hipparcos Number", "HIP 15077"},
        {"Geneva Identification System", "GEN# +1.00020125"},
        {"Smithsonian Astrophysical Observation", "SAO 111065"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.59800588),
        dec: Angle.Degrees(+09.20172655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48976"},
        {"Hipparcos Number", "HIP 32464"},
        {"Smithsonian Astrophysical Observation", "SAO 114387"},
        {"Wilson Evans Batten Catalogue", "WEB 6546"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.63687161),
        dec: Angle.Degrees(+09.20424214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286915"},
        {"Hipparcos Number", "HIP 21432"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.01921413),
        dec: Angle.Degrees(+09.20482091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126569"},
        {"Hipparcos Number", "HIP 70570"},
        {"Smithsonian Astrophysical Observation", "SAO 120458"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.52705485),
        dec: Angle.Degrees(+09.20872445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25463"},
        {"Hipparcos Number", "HIP 18893"},
        {"Geneva Identification System", "GEN# +1.00025463"},
        {"Smithsonian Astrophysical Observation", "SAO 111577"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74772307),
        dec: Angle.Degrees(+09.20888472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115289"},
        {"Hipparcos Number", "HIP 64727"},
        {"Geneva Identification System", "GEN# +1.00115289"},
        {"Smithsonian Astrophysical Observation", "SAO 119839"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.00099659),
        dec: Angle.Degrees(+09.20967831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170008"},
        {"Hipparcos Number", "HIP 90427"},
        {"Geneva Identification System", "GEN# +1.00170008"},
        {"Smithsonian Astrophysical Observation", "SAO 123495"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.844,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.75693612),
        dec: Angle.Degrees(+09.20971695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8924"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.72550395),
        dec: Angle.Degrees(+09.20973348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 85.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 257662"},
        {"Hipparcos Number", "HIP 30746"},
        {"Geneva Identification System", "GEN# +1.00257662"},
        {"Smithsonian Astrophysical Observation", "SAO 113914"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.91046375),
        dec: Angle.Degrees(+09.20994786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50203",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88830"},
        {"Hipparcos Number", "HIP 50203"},
        {"Geneva Identification System", "GEN# +1.00088830"},
        {"Smithsonian Astrophysical Observation", "SAO 118183"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.73965838),
        dec: Angle.Degrees(+09.21135148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85876",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159184"},
        {"Hipparcos Number", "HIP 85876"},
        {"Smithsonian Astrophysical Observation", "SAO 122493"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.24637545),
        dec: Angle.Degrees(+09.21176146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89417"},
        {"Hipparcos Number", "HIP 50539"},
        {"Geneva Identification System", "GEN# +1.00089417"},
        {"Smithsonian Astrophysical Observation", "SAO 118218"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.84195504),
        dec: Angle.Degrees(+09.21293084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24730",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34500"},
        {"Hipparcos Number", "HIP 24730"},
        {"Smithsonian Astrophysical Observation", "SAO 112606"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.54652368),
        dec: Angle.Degrees(+09.21653650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75855",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138102"},
        {"Hipparcos Number", "HIP 75855"},
        {"Smithsonian Astrophysical Observation", "SAO 121031"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.41404252),
        dec: Angle.Degrees(+09.21943316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4619"},
        {"Hipparcos Number", "HIP 3753"},
        {"Smithsonian Astrophysical Observation", "SAO 109466"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.04504409),
        dec: Angle.Degrees(+09.22164519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156147"},
        {"Hipparcos Number", "HIP 84426"},
        {"Smithsonian Astrophysical Observation", "SAO 122216"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.90756873),
        dec: Angle.Degrees(+09.22294656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142639"},
        {"Hipparcos Number", "HIP 77966"},
        {"Smithsonian Astrophysical Observation", "SAO 121262"},
        {"Wilson Evans Batten Catalogue", "WEB 13186"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.83994478),
        dec: Angle.Degrees(+09.22346120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27505"},
        {"Hipparcos Number", "HIP 20281"},
        {"Geneva Identification System", "GEN# +1.00027505"},
        {"Smithsonian Astrophysical Observation", "SAO 111759"},
        {"Wilson Evans Batten Catalogue", "WEB 3877"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.20434267),
        dec: Angle.Degrees(+09.22478950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94012"},
        {"Hipparcos Number", "HIP 53049"},
        {"Geneva Identification System", "GEN# +1.00094012"},
        {"Smithsonian Astrophysical Observation", "SAO 118535"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.80770739),
        dec: Angle.Degrees(+09.22496270)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -209.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74016",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9507 AB"},
        {"Henry Draper", "HD 134066"},
        {"Hipparcos Number", "HIP 74016"},
        {"Geneva Identification System", "GEN# +1.00134066"},
        {"Wilson Evans Batten Catalogue", "WEB 12640"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.88775067),
        dec: Angle.Degrees(+09.22597488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36376"},
        {"Hipparcos Number", "HIP 25896"},
        {"Celescope Catalog", "CEL 755"},
        {"Geneva Identification System", "GEN# +1.00036376"},
        {"Smithsonian Astrophysical Observation", "SAO 112868"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.92098030),
        dec: Angle.Degrees(+09.22599969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186205"},
        {"Hipparcos Number", "HIP 96969"},
        {"Geneva Identification System", "GEN# +1.00186205"},
        {"Renson", "Renson 51340"},
        {"Smithsonian Astrophysical Observation", "SAO 124962"},
        {"Wilson Evans Batten Catalogue", "WEB 17017"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.65771196),
        dec: Angle.Degrees(+09.22751626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223973"},
        {"Hipparcos Number", "HIP 117845"},
        {"Smithsonian Astrophysical Observation", "SAO 128450"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.51821612),
        dec: Angle.Degrees(+09.22765167)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25375",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4018 AB"},
        {"Henry Draper", "HD 35534"},
        {"Hipparcos Number", "HIP 25375"},
        {"Smithsonian Astrophysical Observation", "SAO 112749"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.42522568),
        dec: Angle.Degrees(+09.22858133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4886"},
        {"Hipparcos Number", "HIP 3969"},
        {"Smithsonian Astrophysical Observation", "SAO 109503"},
    },
    visualMagnitude: 8.96,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.75862557),
        dec: Angle.Degrees(+09.22876303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5465"},
        {"Hipparcos Number", "HIP 4413"},
        {"Smithsonian Astrophysical Observation", "SAO 109540"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.13709642),
        dec: Angle.Degrees(+09.22912265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35103"},
        {"Hipparcos Number", "HIP 25123"},
        {"Smithsonian Astrophysical Observation", "SAO 112691"},
    },
    visualMagnitude: 8.56,
    bvColour: 1.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.66550007),
        dec: Angle.Degrees(+09.22928168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35519",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 35519"},
        {"Cincinnati Publication", "Ci 18 877"},
        {"Cincinnati Publication 2", "Ci 20 420"},
        {"Smithsonian Astrophysical Observation", "SAO 115271"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.97365142),
        dec: Angle.Degrees(+09.22967182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -461.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17047"},
        {"Hipparcos Number", "HIP 12794"},
        {"Smithsonian Astrophysical Observation", "SAO 110716"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.10708305),
        dec: Angle.Degrees(+09.23003014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70786"},
        {"Hipparcos Number", "HIP 41183"},
        {"Smithsonian Astrophysical Observation", "SAO 116719"},
    },
    visualMagnitude: 8.81,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.05938621),
        dec: Angle.Degrees(+09.23314507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9202"},
        {"Smithsonian Astrophysical Observation", "SAO 110250"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.60461826),
        dec: Angle.Degrees(+09.23748347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 252117"},
        {"Hipparcos Number", "HIP 29054"},
        {"Smithsonian Astrophysical Observation", "SAO 113478"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.93824785),
        dec: Angle.Degrees(+09.23862448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190434"},
        {"Hipparcos Number", "HIP 98862"},
        {"Smithsonian Astrophysical Observation", "SAO 125416"},
    },
    visualMagnitude: 7.78,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.14384026),
        dec: Angle.Degrees(+09.24008496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75299",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75299"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.77341088),
        dec: Angle.Degrees(+09.24299016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63385"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.83315801),
        dec: Angle.Degrees(+09.24315656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 27111"},
        {"Cincinnati Publication", "Ci 20 347"},
        {"Wilson Evans Batten Catalogue", "WEB 5336"},
    },
    visualMagnitude: 11.35,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.23652511),
        dec: Angle.Degrees(+09.24379111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -703.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15374",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15374"},
    },
    visualMagnitude: 11.91,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.56261220),
        dec: Angle.Degrees(+09.24511119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24507"},
        {"Hipparcos Number", "HIP 18252"},
        {"Geneva Identification System", "GEN# +1.00024507"},
        {"Smithsonian Astrophysical Observation", "SAO 111486"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.55912290),
        dec: Angle.Degrees(+09.24823128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27734"},
        {"Hipparcos Number", "HIP 20458"},
        {"Smithsonian Astrophysical Observation", "SAO 111781"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.74863187),
        dec: Angle.Degrees(+09.24904160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142535"},
        {"Hipparcos Number", "HIP 77917"},
        {"Smithsonian Astrophysical Observation", "SAO 121256"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.68492124),
        dec: Angle.Degrees(+09.25010034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55058",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55058"},
        {"Smithsonian Astrophysical Observation", "SAO 118760"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.07122603),
        dec: Angle.Degrees(+09.25254323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107698"},
        {"Smithsonian Astrophysical Observation", "SAO 127081"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.24476814),
        dec: Angle.Degrees(+09.25301968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45199",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45199"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.15916192),
        dec: Angle.Degrees(+09.25313595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70928",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70928"},
    },
    visualMagnitude: 10.69,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.57953082),
        dec: Angle.Degrees(+09.25531020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16096",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16096"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.83781113),
        dec: Angle.Degrees(+09.25616982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214491"},
        {"Hipparcos Number", "HIP 111770"},
        {"Smithsonian Astrophysical Observation", "SAO 127652"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.61221812),
        dec: Angle.Degrees(+09.25841929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49827"},
        {"Hipparcos Number", "HIP 32829"},
        {"Smithsonian Astrophysical Observation", "SAO 114497"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.66082444),
        dec: Angle.Degrees(+09.25879059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199320"},
        {"Hipparcos Number", "HIP 103333"},
        {"Smithsonian Astrophysical Observation", "SAO 126383"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.02249244),
        dec: Angle.Degrees(+09.26048371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92225",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11687 AB"},
        {"Henry Draper", "HD 173923"},
        {"Hipparcos Number", "HIP 92225"},
        {"Smithsonian Astrophysical Observation", "SAO 123925"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.93541407),
        dec: Angle.Degrees(+09.26318630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174854"},
        {"Hipparcos Number", "HIP 92617"},
        {"Smithsonian Astrophysical Observation", "SAO 123997"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.07185569),
        dec: Angle.Degrees(+09.26344498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19740",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3072 AB"},
        {"Henry Draper", "HD 26722"},
        {"Hipparcos Number", "HIP 19740"},
        {"Geneva Identification System", "GEN# +1.00026722"},
        {"Smithsonian Astrophysical Observation", "SAO 111674"},
        {"Wilson Evans Batten Catalogue", "WEB 3767"},
    },
    visualMagnitude: 4.84,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.48496228),
        dec: Angle.Degrees(+09.26389844)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37685"},
        {"Hipparcos Number", "HIP 26729"},
        {"Geneva Identification System", "GEN# +1.00037685"},
        {"Smithsonian Astrophysical Observation", "SAO 113028"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.19327446),
        dec: Angle.Degrees(+09.26561527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66573"},
        {"Hipparcos Number", "HIP 39506"},
        {"Geneva Identification System", "GEN# +1.00066573"},
        {"Smithsonian Astrophysical Observation", "SAO 116302"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.12369019),
        dec: Angle.Degrees(+09.26788722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 268.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86962",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86962"},
        {"Smithsonian Astrophysical Observation", "SAO 122728"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.55685435),
        dec: Angle.Degrees(+09.26869829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148297"},
        {"Hipparcos Number", "HIP 80546"},
        {"Smithsonian Astrophysical Observation", "SAO 121602"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.67165991),
        dec: Angle.Degrees(+09.27292643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97958",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188369"},
        {"Hipparcos Number", "HIP 97958"},
        {"Smithsonian Astrophysical Observation", "SAO 125216"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.197,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.62101673),
        dec: Angle.Degrees(+09.27595793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143645"},
        {"Hipparcos Number", "HIP 78488"},
        {"Smithsonian Astrophysical Observation", "SAO 121318"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.34352839),
        dec: Angle.Degrees(+09.27605488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58367"},
        {"Hipparcos Number", "HIP 36041"},
        {"Geneva Identification System", "GEN# +1.00058367"},
        {"Smithsonian Astrophysical Observation", "SAO 115425"},
        {"Wilson Evans Batten Catalogue", "WEB 7177"},
    },
    visualMagnitude: 4.99,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.41207798),
        dec: Angle.Degrees(+09.27611835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11087"},
        {"Hipparcos Number", "HIP 8467"},
        {"Smithsonian Astrophysical Observation", "SAO 110146"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.29509329),
        dec: Angle.Degrees(+09.27690143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108633",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108633"},
        {"Smithsonian Astrophysical Observation", "SAO 127226"},
    },
    visualMagnitude: 9.36,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.11453072),
        dec: Angle.Degrees(+09.27867548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251452"},
        {"Hipparcos Number", "HIP 28848"},
        {"Smithsonian Astrophysical Observation", "SAO 113436"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.34499715),
        dec: Angle.Degrees(+09.27963411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225293"},
        {"Hipparcos Number", "HIP 415"},
        {"Smithsonian Astrophysical Observation", "SAO 108999"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.26379805),
        dec: Angle.Degrees(+09.28002796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11211",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11211"},
        {"Smithsonian Astrophysical Observation", "SAO 110515"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.690,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.08045414),
        dec: Angle.Degrees(+09.28262655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60823"},
        {"Hipparcos Number", "HIP 37038"},
        {"Smithsonian Astrophysical Observation", "SAO 115695"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.17459711),
        dec: Angle.Degrees(+09.28450460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144603"},
        {"Hipparcos Number", "HIP 78903"},
        {"Smithsonian Astrophysical Observation", "SAO 121370"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.60030301),
        dec: Angle.Degrees(+09.28545578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105364"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.999,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.12640142),
        dec: Angle.Degrees(+09.28920642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125321"},
        {"Hipparcos Number", "HIP 69921"},
        {"Smithsonian Astrophysical Observation", "SAO 120389"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.63527739),
        dec: Angle.Degrees(+09.29082716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59286",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105637"},
        {"Hipparcos Number", "HIP 59286"},
        {"Smithsonian Astrophysical Observation", "SAO 119246"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.42490242),
        dec: Angle.Degrees(+09.29132437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37160"},
        {"Hipparcos Number", "HIP 26366"},
        {"Geneva Identification System", "GEN# +1.00037160"},
        {"Smithsonian Astrophysical Observation", "SAO 112958"},
        {"Wilson Evans Batten Catalogue", "WEB 5200"},
    },
    visualMagnitude: 4.09,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.22637775),
        dec: Angle.Degrees(+09.29141200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130343"},
        {"Hipparcos Number", "HIP 72317"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.83236509),
        dec: Angle.Degrees(+09.29152125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35310",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5958 AB"},
        {"Henry Draper", "HD 56515"},
        {"Hipparcos Number", "HIP 35310"},
        {"Smithsonian Astrophysical Observation", "SAO 115211"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.41048910),
        dec: Angle.Degrees(+09.29236217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189338"},
        {"Hipparcos Number", "HIP 98370"},
        {"Geneva Identification System", "GEN# +1.00189338"},
        {"Smithsonian Astrophysical Observation", "SAO 125309"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.78525529),
        dec: Angle.Degrees(+09.29438858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201140"},
        {"Hipparcos Number", "HIP 104274"},
        {"Smithsonian Astrophysical Observation", "SAO 126555"},
    },
    visualMagnitude: 7.49,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.86357466),
        dec: Angle.Degrees(+09.29589034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196506"},
        {"Hipparcos Number", "HIP 101776"},
        {"Smithsonian Astrophysical Observation", "SAO 126033"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.40639557),
        dec: Angle.Degrees(+09.29790975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71459",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71459"},
        {"Smithsonian Astrophysical Observation", "SAO 120562"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.20644964),
        dec: Angle.Degrees(+09.29796212)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122387"},
        {"Hipparcos Number", "HIP 68508"},
        {"Smithsonian Astrophysical Observation", "SAO 120232"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.35925911),
        dec: Angle.Degrees(+09.29882132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27336"},
        {"Hipparcos Number", "HIP 20165"},
        {"Geneva Identification System", "GEN# +1.00027336"},
        {"Smithsonian Astrophysical Observation", "SAO 111744"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.82825509),
        dec: Angle.Degrees(+09.29904983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13690"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.08009194),
        dec: Angle.Degrees(+09.30100230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182295"},
        {"Hipparcos Number", "HIP 95331"},
        {"Smithsonian Astrophysical Observation", "SAO 124581"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.91892085),
        dec: Angle.Degrees(+09.30174860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8655",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11327"},
        {"Hipparcos Number", "HIP 8655"},
        {"Smithsonian Astrophysical Observation", "SAO 110175"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.88548360),
        dec: Angle.Degrees(+09.30200001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140006"},
        {"Hipparcos Number", "HIP 76820"},
        {"Geneva Identification System", "GEN# +1.00140006"},
        {"Smithsonian Astrophysical Observation", "SAO 121126"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.26850462),
        dec: Angle.Degrees(+09.30249734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54978",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54978"},
        {"Smithsonian Astrophysical Observation", "SAO 118748"},
    },
    visualMagnitude: 9.65,
    bvColour: 1.258,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.86313348),
        dec: Angle.Degrees(+09.30262288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2748"},
        {"Hipparcos Number", "HIP 2441"},
        {"Smithsonian Astrophysical Observation", "SAO 109247"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.76633986),
        dec: Angle.Degrees(+09.30549444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286572"},
        {"Hipparcos Number", "HIP 19441"},
        {"Geneva Identification System", "GEN# +5.20257115"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.45524024),
        dec: Angle.Degrees(+09.30550501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91316"},
        {"Hipparcos Number", "HIP 51624"},
        {"Fundamental Katalog 5th Edition", "FK5 396"},
        {"Geneva Identification System", "GEN# +1.00091316J"},
        {"Smithsonian Astrophysical Observation", "SAO 118355"},
        {"Wilson Evans Batten Catalogue", "WEB 9417"},
    },
    visualMagnitude: 3.84,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.20281305),
        dec: Angle.Degrees(+09.30659431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106027"},
        {"Hipparcos Number", "HIP 59485"},
        {"Smithsonian Astrophysical Observation", "SAO 119265"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.99740828),
        dec: Angle.Degrees(+09.30715290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17502",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17502"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.22010982),
        dec: Angle.Degrees(+09.30740443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97356"},
        {"Smithsonian Astrophysical Observation", "SAO 125064"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.82297484),
        dec: Angle.Degrees(+09.30775439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17364"},
        {"Hipparcos Number", "HIP 13018"},
        {"Fundamental Katalog 5th Edition", "FK5 4254"},
        {"Smithsonian Astrophysical Observation", "SAO 110745"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.84585867),
        dec: Angle.Degrees(+09.30784880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54619"},
        {"Hipparcos Number", "HIP 34588"},
        {"Smithsonian Astrophysical Observation", "SAO 115009"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.46261522),
        dec: Angle.Degrees(+09.30891208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121967"},
        {"Hipparcos Number", "HIP 68281"},
        {"Geneva Identification System", "GEN# +1.00121967"},
        {"Smithsonian Astrophysical Observation", "SAO 120203"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.66825061),
        dec: Angle.Degrees(+09.31032845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 51.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223637"},
        {"Hipparcos Number", "HIP 117628"},
        {"Geneva Identification System", "GEN# +1.00223637"},
        {"Smithsonian Astrophysical Observation", "SAO 128421"},
        {"Wilson Evans Batten Catalogue", "WEB 20704"},
    },
    visualMagnitude: 5.77,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.83856042),
        dec: Angle.Degrees(+09.31350996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142477"},
        {"Hipparcos Number", "HIP 77898"},
        {"Smithsonian Astrophysical Observation", "SAO 121250"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.61637023),
        dec: Angle.Degrees(+09.31386142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171748"},
        {"Hipparcos Number", "HIP 91195"},
        {"Smithsonian Astrophysical Observation", "SAO 123685"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.05342036),
        dec: Angle.Degrees(+09.31476183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80670"},
        {"Smithsonian Astrophysical Observation", "SAO 121621"},
    },
    visualMagnitude: 9.16,
    bvColour: 1.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.05375476),
        dec: Angle.Degrees(+09.31605848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112446"},
        {"Hipparcos Number", "HIP 63173"},
        {"Geneva Identification System", "GEN# +1.00112446"},
        {"Smithsonian Astrophysical Observation", "SAO 119678"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.14758073),
        dec: Angle.Degrees(+09.31659142)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65911",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8928 A"},
        {"Henry Draper", "HD 117498"},
        {"Hipparcos Number", "HIP 65911"},
        {"Smithsonian Astrophysical Observation", "SAO 119971"},
    },
    visualMagnitude: 6.88,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.66307696),
        dec: Angle.Degrees(+09.31685875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180081"},
        {"Hipparcos Number", "HIP 94573"},
        {"Smithsonian Astrophysical Observation", "SAO 124434"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.70325193),
        dec: Angle.Degrees(+09.31891935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2294"},
        {"Hipparcos Number", "HIP 2118"},
        {"Geneva Identification System", "GEN# +1.00002294"},
        {"Smithsonian Astrophysical Observation", "SAO 109209"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.71830554),
        dec: Angle.Degrees(+09.31967221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184763"},
        {"Hipparcos Number", "HIP 96372"},
        {"Smithsonian Astrophysical Observation", "SAO 124829"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.90216800),
        dec: Angle.Degrees(+09.32024144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221381"},
        {"Hipparcos Number", "HIP 116116"},
        {"Geneva Identification System", "GEN# +1.00221381"},
        {"Smithsonian Astrophysical Observation", "SAO 128227"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.92290996),
        dec: Angle.Degrees(+09.32089560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29930",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4903 AB"},
        {"Henry Draper", "HD 43705"},
        {"Hipparcos Number", "HIP 29930"},
        {"Smithsonian Astrophysical Observation", "SAO 113699"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.52317801),
        dec: Angle.Degrees(+09.32094301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94357",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179441"},
        {"Hipparcos Number", "HIP 94357"},
        {"Smithsonian Astrophysical Observation", "SAO 124382"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.08111016),
        dec: Angle.Degrees(+09.32292929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117913"},
        {"Hipparcos Number", "HIP 66132"},
        {"Smithsonian Astrophysical Observation", "SAO 119996"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.35795943),
        dec: Angle.Degrees(+09.32375930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60108"},
        {"Hipparcos Number", "HIP 36733"},
        {"Geneva Identification System", "GEN# +1.00060108"},
        {"Smithsonian Astrophysical Observation", "SAO 115612"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.33272979),
        dec: Angle.Degrees(+09.32619408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180401"},
        {"Hipparcos Number", "HIP 94694"},
        {"Geneva Identification System", "GEN# +1.00180401"},
        {"Smithsonian Astrophysical Observation", "SAO 124450"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.02810530),
        dec: Angle.Degrees(+09.32781414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286728"},
        {"Hipparcos Number", "HIP 20189"},
        {"Smithsonian Astrophysical Observation", "SAO 111747"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.90939153),
        dec: Angle.Degrees(+09.32925892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112654",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112654"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.768,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.22847023),
        dec: Angle.Degrees(+09.33006306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17244",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17244"},
    },
    visualMagnitude: 10.84,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.39653972),
        dec: Angle.Degrees(+09.33039577)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66923"},
        {"Hipparcos Number", "HIP 39632"},
        {"Smithsonian Astrophysical Observation", "SAO 116337"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.49281118),
        dec: Angle.Degrees(+09.33069743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18778"},
        {"Smithsonian Astrophysical Observation", "SAO 111563"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.730,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.33892686),
        dec: Angle.Degrees(+09.33379437)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96092",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12568 AB"},
        {"Henry Draper", "HD 184061"},
        {"Hipparcos Number", "HIP 96092"},
        {"Smithsonian Astrophysical Observation", "SAO 124749"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.05285182),
        dec: Angle.Degrees(+09.33428559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127871"},
        {"Hipparcos Number", "HIP 71190"},
        {"Cincinnati Publication", "Ci 20 869"},
        {"Geneva Identification System", "GEN# +1.00127871A"},
        {"Smithsonian Astrophysical Observation", "SAO 120527"},
        {"Wilson Evans Batten Catalogue", "WEB 12305"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.39503180),
        dec: Angle.Degrees(+09.33562445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -513.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17986"},
        {"Hipparcos Number", "HIP 13495"},
        {"Smithsonian Astrophysical Observation", "SAO 110817"},
    },
    visualMagnitude: 6.54,
    bvColour: 1.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.44244965),
        dec: Angle.Degrees(+09.33587328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112612"},
        {"Hipparcos Number", "HIP 63267"},
        {"Geneva Identification System", "GEN# +1.00112612"},
        {"Smithsonian Astrophysical Observation", "SAO 119686"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.279,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.46514890),
        dec: Angle.Degrees(+09.33867157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94773",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12259 A"},
        {"Henry Draper", "HD 180660"},
        {"Hipparcos Number", "HIP 94773"},
        {"Geneva Identification System", "GEN# +1.00180660"},
        {"Smithsonian Astrophysical Observation", "SAO 124465"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.26316780),
        dec: Angle.Degrees(+09.33877202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74330"},
        {"Hipparcos Number", "HIP 42837"},
        {"Smithsonian Astrophysical Observation", "SAO 117058"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.92261490),
        dec: Angle.Degrees(+09.33988852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207073"},
        {"Hipparcos Number", "HIP 107495"},
        {"Smithsonian Astrophysical Observation", "SAO 127050"},
    },
    visualMagnitude: 7.69,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.58107640),
        dec: Angle.Degrees(+09.34241545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12259 B"},
        {"Henry Draper", "HD 180639"},
        {"Hipparcos Number", "HIP 94774"},
        {"Geneva Identification System", "GEN# +1.00180639"},
        {"Smithsonian Astrophysical Observation", "SAO 124466"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.26447125),
        dec: Angle.Degrees(+09.34404079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147396"},
        {"Hipparcos Number", "HIP 80139"},
        {"Geneva Identification System", "GEN# +1.00147396"},
        {"Smithsonian Astrophysical Observation", "SAO 121528"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.35268971),
        dec: Angle.Degrees(+09.34497542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75006",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75006"},
        {"Smithsonian Astrophysical Observation", "SAO 120949"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.90507803),
        dec: Angle.Degrees(+09.34660050)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175514"},
        {"Hipparcos Number", "HIP 92865"},
        {"Geneva Identification System", "GEN# +1.00175514"},
        {"Smithsonian Astrophysical Observation", "SAO 124049"},
        {"Wilson Evans Batten Catalogue", "WEB 16078"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.84635759),
        dec: Angle.Degrees(+09.34668990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1885"},
        {"Hipparcos Number", "HIP 1845"},
        {"Smithsonian Astrophysical Observation", "SAO 109170"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.83210508),
        dec: Angle.Degrees(+09.34883225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58418"},
        {"Smithsonian Astrophysical Observation", "SAO 119145"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.67022675),
        dec: Angle.Degrees(+09.34953422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64649"},
        {"Hipparcos Number", "HIP 38682"},
        {"Geneva Identification System", "GEN# +1.00064649"},
        {"Smithsonian Astrophysical Observation", "SAO 116112"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.79598258),
        dec: Angle.Degrees(+09.34998208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138750"},
        {"Hipparcos Number", "HIP 76185"},
        {"Geneva Identification System", "GEN# +1.00138750"},
        {"Smithsonian Astrophysical Observation", "SAO 121061"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.41811125),
        dec: Angle.Degrees(+09.35364377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -172.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98492"},
        {"Geneva Identification System", "GEN# +9.80023020"},
    },
    visualMagnitude: 11.59,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.14095094),
        dec: Angle.Degrees(+09.35401058)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -193.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -196.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71775",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129190"},
        {"Hipparcos Number", "HIP 71775"},
        {"Smithsonian Astrophysical Observation", "SAO 120598"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.23784359),
        dec: Angle.Degrees(+09.35481622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3861"},
        {"Hipparcos Number", "HIP 3236"},
        {"Geneva Identification System", "GEN# +1.00003861"},
        {"Smithsonian Astrophysical Observation", "SAO 109369"},
        {"Wilson Evans Batten Catalogue", "WEB 580"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.29977784),
        dec: Angle.Degrees(+09.35530818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -122.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113445",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16417 AB"},
        {"Henry Draper", "HD 217166"},
        {"Hipparcos Number", "HIP 113445"},
        {"Cincinnati Publication", "Ci 20 1393"},
        {"Geneva Identification System", "GEN# +1.00217166J"},
        {"Smithsonian Astrophysical Observation", "SAO 127870"},
        {"Wilson Evans Batten Catalogue", "WEB 20173"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.64519627),
        dec: Angle.Degrees(+09.35721774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 396.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56298"},
        {"Hipparcos Number", "HIP 35227"},
        {"Geneva Identification System", "GEN# +1.00056298"},
        {"Smithsonian Astrophysical Observation", "SAO 115189"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.20771378),
        dec: Angle.Degrees(+09.36238030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201257"},
        {"Hipparcos Number", "HIP 104325"},
        {"Geneva Identification System", "GEN# +1.00201257"},
        {"Smithsonian Astrophysical Observation", "SAO 126563"},
    },
    visualMagnitude: 7.38,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.00439872),
        dec: Angle.Degrees(+09.36256053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157443"},
        {"Hipparcos Number", "HIP 85051"},
        {"Smithsonian Astrophysical Observation", "SAO 122334"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.923,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.73356838),
        dec: Angle.Degrees(+09.36495623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178570"},
        {"Hipparcos Number", "HIP 94044"},
        {"Smithsonian Astrophysical Observation", "SAO 124316"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.19026847),
        dec: Angle.Degrees(+09.36774388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148148"},
        {"Hipparcos Number", "HIP 80479"},
        {"Smithsonian Astrophysical Observation", "SAO 121588"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.41955337),
        dec: Angle.Degrees(+09.37064361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72680"},
        {"Hipparcos Number", "HIP 42084"},
        {"Cincinnati Publication", "Ci 18 1002"},
        {"Geneva Identification System", "GEN# +1.00072680"},
        {"Smithsonian Astrophysical Observation", "SAO 116904"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.66545824),
        dec: Angle.Degrees(+09.37199751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 345.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -224.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224603"},
        {"Hipparcos Number", "HIP 118260"},
        {"Smithsonian Astrophysical Observation", "SAO 128512"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.80779597),
        dec: Angle.Degrees(+09.37207305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111498"},
        {"Hipparcos Number", "HIP 62597"},
        {"Geneva Identification System", "GEN# +1.00111498"},
        {"Smithsonian Astrophysical Observation", "SAO 119613"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.39544393),
        dec: Angle.Degrees(+09.37320990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21933"},
        {"Hipparcos Number", "HIP 16511"},
        {"Geneva Identification System", "GEN# +1.00021933"},
        {"Renson", "Renson 5520"},
        {"Smithsonian Astrophysical Observation", "SAO 111246"},
        {"Wilson Evans Batten Catalogue", "WEB 3154"},
    },
    visualMagnitude: 5.76,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.14970799),
        dec: Angle.Degrees(+09.37355768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153210"},
        {"Hipparcos Number", "HIP 83000"},
        {"Fundamental Katalog 5th Edition", "FK5 633"},
        {"Geneva Identification System", "GEN# +1.00153210"},
        {"Smithsonian Astrophysical Observation", "SAO 121962"},
        {"Wilson Evans Batten Catalogue", "WEB 14033"},
    },
    visualMagnitude: 3.19,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.41779418),
        dec: Angle.Degrees(+09.37505626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -293.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51975",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91960"},
        {"Hipparcos Number", "HIP 51975"},
        {"Smithsonian Astrophysical Observation", "SAO 118398"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.30098264),
        dec: Angle.Degrees(+09.37556657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103165",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103165"},
    },
    visualMagnitude: 11.27,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.52208672),
        dec: Angle.Degrees(+09.37600324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111313",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111313"},
        {"Geneva Identification System", "GEN# +0.00804887"},
    },
    visualMagnitude: 10.36,
    bvColour: 1.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.25794972),
        dec: Angle.Degrees(+09.37763447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 537.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54851"},
        {"Hipparcos Number", "HIP 34672"},
        {"Smithsonian Astrophysical Observation", "SAO 115038"},
    },
    visualMagnitude: 7.66,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.70776103),
        dec: Angle.Degrees(+09.37788321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74814",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9568 AB"},
        {"Henry Draper", "HD 135892"},
        {"Hipparcos Number", "HIP 74814"},
        {"Smithsonian Astrophysical Observation", "SAO 120930"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.33709644),
        dec: Angle.Degrees(+09.37972431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105743",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14954 C"},
        {"Hipparcos Number", "HIP 105743"},
        {"Smithsonian Astrophysical Observation", "SAO 126782"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.26704571),
        dec: Angle.Degrees(+09.38053417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3818"},
        {"Hipparcos Number", "HIP 3215"},
        {"Smithsonian Astrophysical Observation", "SAO 109367"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.21945350),
        dec: Angle.Degrees(+09.38122127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100362"},
        {"Hipparcos Number", "HIP 56338"},
        {"Smithsonian Astrophysical Observation", "SAO 118913"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.23920620),
        dec: Angle.Degrees(+09.38167453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -115.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32366"},
        {"Hipparcos Number", "HIP 23494"},
        {"Celescope Catalog", "CEL 517"},
        {"Geneva Identification System", "GEN# +1.00032366"},
        {"Smithsonian Astrophysical Observation", "SAO 112360"},
    },
    visualMagnitude: 7.56,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.75869463),
        dec: Angle.Degrees(+09.38242806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43134",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74911"},
        {"Hipparcos Number", "HIP 43134"},
        {"Geneva Identification System", "GEN# +1.00074911"},
        {"Smithsonian Astrophysical Observation", "SAO 117116"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.79235861),
        dec: Angle.Degrees(+09.38356056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88575",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 88575"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.28509408),
        dec: Angle.Degrees(+09.38364476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105747",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14954 AB"},
        {"Henry Draper", "HD 203944"},
        {"Henry Draper 2", "HD 203943"},
        {"Hipparcos Number", "HIP 105747"},
        {"Smithsonian Astrophysical Observation", "SAO 126783"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.27359850),
        dec: Angle.Degrees(+09.38405440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61527"},
        {"Geneva Identification System", "GEN# +0.01002449"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.970,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.08437792),
        dec: Angle.Degrees(+09.38470281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63935"},
        {"Hipparcos Number", "HIP 38374"},
        {"Geneva Identification System", "GEN# +1.00063935"},
        {"Smithsonian Astrophysical Observation", "SAO 116039"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.92517891),
        dec: Angle.Degrees(+09.38651076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76629"},
        {"Hipparcos Number", "HIP 44010"},
        {"Fundamental Katalog 5th Edition", "FK5 2710"},
        {"Geneva Identification System", "GEN# +1.00076629"},
        {"Smithsonian Astrophysical Observation", "SAO 117301"},
        {"Wilson Evans Batten Catalogue", "WEB 8459"},
    },
    visualMagnitude: 6.19,
    bvColour: 0.984,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.42512167),
        dec: Angle.Degrees(+09.38777759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118825"},
        {"Hipparcos Number", "HIP 66606"},
        {"Smithsonian Astrophysical Observation", "SAO 120054"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.79937381),
        dec: Angle.Degrees(+09.38959394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191637"},
        {"Hipparcos Number", "HIP 99410"},
        {"Geneva Identification System", "GEN# +1.00191637"},
        {"Smithsonian Astrophysical Observation", "SAO 125525"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.65001374),
        dec: Angle.Degrees(+09.39023888)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202575"},
        {"Hipparcos Number", "HIP 105038"},
        {"Geneva Identification System", "GEN# +1.00202575"},
        {"Smithsonian Astrophysical Observation", "SAO 126671"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.13491990),
        dec: Angle.Degrees(+09.39411501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28140"},
        {"Hipparcos Number", "HIP 20734"},
        {"Smithsonian Astrophysical Observation", "SAO 111818"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.65626621),
        dec: Angle.Degrees(+09.39424892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286914"},
        {"Hipparcos Number", "HIP 21504"},
        {"Smithsonian Astrophysical Observation", "SAO 111921"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.27998451),
        dec: Angle.Degrees(+09.39801045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99158",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13403 AB"},
        {"Henry Draper", "HD 191104"},
        {"Hipparcos Number", "HIP 99158"},
        {"Geneva Identification System", "GEN# +1.00191104J"},
        {"Smithsonian Astrophysical Observation", "SAO 125478"},
        {"Wilson Evans Batten Catalogue", "WEB 17647"},
    },
    visualMagnitude: 6.43,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.95975060),
        dec: Angle.Degrees(+09.39976375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40879",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70092"},
        {"Hipparcos Number", "HIP 40879"},
        {"Smithsonian Astrophysical Observation", "SAO 116645"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.12172088),
        dec: Angle.Degrees(+09.40016921)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73234",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73234"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.51593054),
        dec: Angle.Degrees(+09.40060606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -217.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 104.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83432",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154102"},
        {"Hipparcos Number", "HIP 83432"},
        {"Smithsonian Astrophysical Observation", "SAO 122039"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.78849386),
        dec: Angle.Degrees(+09.40104580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20457",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27733"},
        {"Hipparcos Number", "HIP 20457"},
        {"Geneva Identification System", "GEN# +1.00027733"},
        {"Smithsonian Astrophysical Observation", "SAO 111780"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.777,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.74563593),
        dec: Angle.Degrees(+09.40301987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100007"},
        {"Hipparcos Number", "HIP 56149"},
        {"Smithsonian Astrophysical Observation", "SAO 118898"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.873,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.63624617),
        dec: Angle.Degrees(+09.40325027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82460",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10229 AB"},
        {"Henry Draper", "HD 152113"},
        {"Hipparcos Number", "HIP 82460"},
        {"Geneva Identification System", "GEN# +1.00152113"},
        {"Smithsonian Astrophysical Observation", "SAO 121908"},
        {"Wilson Evans Batten Catalogue", "WEB 13923"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.78086152),
        dec: Angle.Degrees(+09.40460708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69222"},
        {"Hipparcos Number", "HIP 40512"},
        {"Geneva Identification System", "GEN# +1.00069222"},
        {"Smithsonian Astrophysical Observation", "SAO 116560"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.06388440),
        dec: Angle.Degrees(+09.40644450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19757"},
        {"Geneva Identification System", "GEN# +5.20257129"},
    },
    visualMagnitude: 11.09,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.53352961),
        dec: Angle.Degrees(+09.40672595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 110.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17907",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2796 A"},
        {"Henry Draper", "HD 23990"},
        {"Hipparcos Number", "HIP 17907"},
        {"Fundamental Katalog 5th Edition", "FK5 4347"},
        {"Smithsonian Astrophysical Observation", "SAO 111441"},
    },
    visualMagnitude: 6.77,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.44366240),
        dec: Angle.Degrees(+09.40755457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10168",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10168"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.224,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.69225393),
        dec: Angle.Degrees(+09.40777583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 185.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130896"},
        {"Hipparcos Number", "HIP 72579"},
        {"Smithsonian Astrophysical Observation", "SAO 120691"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.756,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.61304337),
        dec: Angle.Degrees(+09.40848288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218329"},
        {"Hipparcos Number", "HIP 114144"},
        {"Fundamental Katalog 5th Edition", "FK5 1603"},
        {"Geneva Identification System", "GEN# +1.00218329"},
        {"Smithsonian Astrophysical Observation", "SAO 127976"},
        {"Wilson Evans Batten Catalogue", "WEB 20268"},
    },
    visualMagnitude: 4.54,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.75106602),
        dec: Angle.Degrees(+09.40952259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28930"},
        {"Hipparcos Number", "HIP 21269"},
        {"Geneva Identification System", "GEN# +1.00028930"},
        {"Smithsonian Astrophysical Observation", "SAO 111890"},
        {"Wilson Evans Batten Catalogue", "WEB 4089"},
    },
    visualMagnitude: 6.01,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.45074507),
        dec: Angle.Degrees(+09.41362272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149059"},
        {"Hipparcos Number", "HIP 80964"},
        {"Geneva Identification System", "GEN# +1.00149059"},
        {"Smithsonian Astrophysical Observation", "SAO 121671"},
        {"Wilson Evans Batten Catalogue", "WEB 13694"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.98528500),
        dec: Angle.Degrees(+09.41451964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173799"},
        {"Hipparcos Number", "HIP 92151"},
        {"Geneva Identification System", "GEN# +1.00173799"},
        {"Smithsonian Astrophysical Observation", "SAO 123914"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.73161816),
        dec: Angle.Degrees(+09.41923330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151879"},
        {"Hipparcos Number", "HIP 82373"},
        {"Geneva Identification System", "GEN# +1.00151879"},
        {"Smithsonian Astrophysical Observation", "SAO 121893"},
        {"Wilson Evans Batten Catalogue", "WEB 13908"},
    },
    visualMagnitude: 6.91,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.49223551),
        dec: Angle.Degrees(+09.42129668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102621"},
        {"Smithsonian Astrophysical Observation", "SAO 126220"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.92292974),
        dec: Angle.Degrees(+09.42181532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91233"},
        {"Hipparcos Number", "HIP 51582"},
        {"Smithsonian Astrophysical Observation", "SAO 118352"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.03529674),
        dec: Angle.Degrees(+09.42203690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115383"},
        {"Hipparcos Number", "HIP 64792"},
        {"Geneva Identification System", "GEN# +1.00115383"},
        {"Smithsonian Astrophysical Observation", "SAO 119847"},
        {"Wilson Evans Batten Catalogue", "WEB 11451"},
    },
    visualMagnitude: 5.19,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.19463902),
        dec: Angle.Degrees(+09.42369300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -334.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 190.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6798 AB"},
        {"Henry Draper", "HD 70935"},
        {"Hipparcos Number", "HIP 41257"},
        {"Smithsonian Astrophysical Observation", "SAO 116737"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.25444469),
        dec: Angle.Degrees(+09.42601738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83699"},
        {"Hipparcos Number", "HIP 47462"},
        {"Geneva Identification System", "GEN# +1.00083699"},
        {"Smithsonian Astrophysical Observation", "SAO 117843"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.13100024),
        dec: Angle.Degrees(+09.42669678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221026"},
        {"Hipparcos Number", "HIP 115871"},
        {"Geneva Identification System", "GEN# +1.00221026"},
        {"Smithsonian Astrophysical Observation", "SAO 128201"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.13184122),
        dec: Angle.Degrees(+09.42716915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93310",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176487"},
        {"Hipparcos Number", "HIP 93310"},
    },
    visualMagnitude: 9.70,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.08754035),
        dec: Angle.Degrees(+09.42807256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 247.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 290.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213815"},
        {"Hipparcos Number", "HIP 111399"},
        {"Geneva Identification System", "GEN# +1.00213815"},
        {"Smithsonian Astrophysical Observation", "SAO 127607"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.52947722),
        dec: Angle.Degrees(+09.42810985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4278",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 754 AB"},
        {"Henry Draper", "HD 5280"},
        {"Hipparcos Number", "HIP 4278"},
        {"Smithsonian Astrophysical Observation", "SAO 109530"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.68830321),
        dec: Angle.Degrees(+09.42885962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176649"},
        {"Hipparcos Number", "HIP 93362"},
        {"Geneva Identification System", "GEN# +1.00176649"},
        {"Smithsonian Astrophysical Observation", "SAO 124155"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.25030347),
        dec: Angle.Degrees(+09.43188345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100382",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100382"},
    },
    visualMagnitude: 10.67,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.37212094),
        dec: Angle.Degrees(+09.43573729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71781"},
        {"Hipparcos Number", "HIP 41648"},
        {"Geneva Identification System", "GEN# +1.00071781"},
        {"Smithsonian Astrophysical Observation", "SAO 116813"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.38441771),
        dec: Angle.Degrees(+09.43625088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9810"},
        {"Smithsonian Astrophysical Observation", "SAO 110336"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.55396709),
        dec: Angle.Degrees(+09.43940738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32926",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50005"},
        {"Hipparcos Number", "HIP 32926"},
        {"Smithsonian Astrophysical Observation", "SAO 114515"},
        {"Wilson Evans Batten Catalogue", "WEB 6626"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.89913412),
        dec: Angle.Degrees(+09.44012798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124733"},
        {"Hipparcos Number", "HIP 69635"},
        {"Smithsonian Astrophysical Observation", "SAO 120369"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.78135837),
        dec: Angle.Degrees(+09.44135723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167241"},
        {"Hipparcos Number", "HIP 89355"},
        {"Smithsonian Astrophysical Observation", "SAO 123276"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.50471970),
        dec: Angle.Degrees(+09.44182603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208289"},
        {"Hipparcos Number", "HIP 108187"},
        {"Smithsonian Astrophysical Observation", "SAO 127157"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.77935296),
        dec: Angle.Degrees(+09.44276628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35987"},
        {"Hipparcos Number", "HIP 25666"},
        {"Geneva Identification System", "GEN# +1.00035987"},
        {"Smithsonian Astrophysical Observation", "SAO 112812"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.22576628),
        dec: Angle.Degrees(+09.44357282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160936"},
        {"Hipparcos Number", "HIP 86660"},
        {"Smithsonian Astrophysical Observation", "SAO 122659"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.59375988),
        dec: Angle.Degrees(+09.44952303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113609"},
        {"Hipparcos Number", "HIP 63811"},
        {"Geneva Identification System", "GEN# +1.00113609"},
        {"Smithsonian Astrophysical Observation", "SAO 119757"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.18587571),
        dec: Angle.Degrees(+09.44976666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210265"},
        {"Hipparcos Number", "HIP 109341"},
        {"Smithsonian Astrophysical Observation", "SAO 127326"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.26740960),
        dec: Angle.Degrees(+09.45120332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194598"},
        {"Hipparcos Number", "HIP 100792"},
        {"Cincinnati Publication", "Ci 20 1206"},
        {"Geneva Identification System", "GEN# +1.00194598"},
        {"Smithsonian Astrophysical Observation", "SAO 125806"},
        {"Wilson Evans Batten Catalogue", "WEB 18214"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.54937177),
        dec: Angle.Degrees(+09.45145179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -549.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115764"},
        {"Hipparcos Number", "HIP 64989"},
        {"Geneva Identification System", "GEN# +1.00115764"},
        {"Smithsonian Astrophysical Observation", "SAO 119877"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.80662122),
        dec: Angle.Degrees(+09.45148253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166097"},
        {"Hipparcos Number", "HIP 88887"},
        {"Geneva Identification System", "GEN# +1.00166097"},
        {"Wilson Evans Batten Catalogue", "WEB 15075"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.18916483),
        dec: Angle.Degrees(+09.45217551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203632"},
        {"Hipparcos Number", "HIP 105597"},
        {"Smithsonian Astrophysical Observation", "SAO 126755"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.83055360),
        dec: Angle.Degrees(+09.45336186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 266098"},
        {"Hipparcos Number", "HIP 33188"},
        {"Geneva Identification System", "GEN# +1.00266098"},
        {"Smithsonian Astrophysical Observation", "SAO 114588"},
        {"Wilson Evans Batten Catalogue", "WEB 6674"},
    },
    visualMagnitude: 8.73,
    bvColour: -0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.60966478),
        dec: Angle.Degrees(+09.45589816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44071",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76782"},
        {"Hipparcos Number", "HIP 44071"},
        {"Smithsonian Astrophysical Observation", "SAO 117315"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.65370180),
        dec: Angle.Degrees(+09.45719180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113180",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16364 AB"},
        {"Henry Draper", "HD 216734"},
        {"Hipparcos Number", "HIP 113180"},
        {"Smithsonian Astrophysical Observation", "SAO 127838"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.77957576),
        dec: Angle.Degrees(+09.45977989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20522",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3182 AB"},
        {"Henry Draper", "HD 27820"},
        {"Hipparcos Number", "HIP 20522"},
        {"Geneva Identification System", "GEN# +1.00027820J"},
        {"Smithsonian Astrophysical Observation", "SAO 111791"},
        {"Wilson Evans Batten Catalogue", "WEB 3926"},
    },
    visualMagnitude: 5.10,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.96599009),
        dec: Angle.Degrees(+09.46098377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212291"},
        {"Hipparcos Number", "HIP 110508"},
        {"Geneva Identification System", "GEN# +1.00212291"},
        {"Smithsonian Astrophysical Observation", "SAO 127490"},
        {"Wilson Evans Batten Catalogue", "WEB 19807"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.682,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.78747301),
        dec: Angle.Degrees(+09.46099598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 305.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 35.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65697",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8912 A"},
        {"Henry Draper", "HD 117114"},
        {"Hipparcos Number", "HIP 65697"},
        {"Geneva Identification System", "GEN# +1.00117114"},
        {"Smithsonian Astrophysical Observation", "SAO 119941"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.04049387),
        dec: Angle.Degrees(+09.46113183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156968"},
        {"Hipparcos Number", "HIP 84824"},
        {"Cincinnati Publication", "Ci 18 2310"},
        {"Geneva Identification System", "GEN# +1.00156968"},
        {"Smithsonian Astrophysical Observation", "SAO 122289"},
        {"Wilson Evans Batten Catalogue", "WEB 14319"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.04848966),
        dec: Angle.Degrees(+09.46170411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -308.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69359",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69359"},
        {"Geneva Identification System", "GEN# +0.01002643"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.95127285),
        dec: Angle.Degrees(+09.46221127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -222.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -162.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41064",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70534"},
        {"Hipparcos Number", "HIP 41064"},
        {"Geneva Identification System", "GEN# +1.00070534"},
        {"Smithsonian Astrophysical Observation", "SAO 116691"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.69055003),
        dec: Angle.Degrees(+09.46273113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35248",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56359"},
        {"Hipparcos Number", "HIP 35248"},
        {"Smithsonian Astrophysical Observation", "SAO 115194"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.25072383),
        dec: Angle.Degrees(+09.46316574)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189660"},
        {"Hipparcos Number", "HIP 98507"},
        {"Smithsonian Astrophysical Observation", "SAO 125351"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.18470711),
        dec: Angle.Degrees(+09.46317135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11870"},
        {"Hipparcos Number", "HIP 9070"},
        {"Smithsonian Astrophysical Observation", "SAO 110243"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.19143393),
        dec: Angle.Degrees(+09.46351290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107173"},
        {"Hipparcos Number", "HIP 60092"},
        {"Smithsonian Astrophysical Observation", "SAO 119327"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.84833115),
        dec: Angle.Degrees(+09.46467219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62877",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62877"},
        {"Geneva Identification System", "GEN# +0.01002480"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.30040366),
        dec: Angle.Degrees(+09.46599842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102703",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198227"},
        {"Hipparcos Number", "HIP 102703"},
        {"Geneva Identification System", "GEN# +1.00198227"},
        {"Smithsonian Astrophysical Observation", "SAO 126238"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.14909376),
        dec: Angle.Degrees(+09.46631269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157495"},
        {"Hipparcos Number", "HIP 85083"},
        {"Geneva Identification System", "GEN# +1.00157495"},
        {"Smithsonian Astrophysical Observation", "SAO 122338"},
        {"Wilson Evans Batten Catalogue", "WEB 14364"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.83267043),
        dec: Angle.Degrees(+09.46678890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39522",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66612"},
        {"Hipparcos Number", "HIP 39522"},
        {"Geneva Identification System", "GEN# +1.00066612"},
        {"Smithsonian Astrophysical Observation", "SAO 116305"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.896,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.16694870),
        dec: Angle.Degrees(+09.46695748)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42235"},
        {"Hipparcos Number", "HIP 29243"},
        {"Celescope Catalog", "CEL 1099"},
        {"Geneva Identification System", "GEN# +1.00042235"},
        {"Smithsonian Astrophysical Observation", "SAO 113529"},
    },
    visualMagnitude: 7.29,
    bvColour: -0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.48645484),
        dec: Angle.Degrees(+09.46779197)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63723",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8756 A"},
        {"Hipparcos Number", "HIP 63723"},
        {"Smithsonian Astrophysical Observation", "SAO 119744"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.88505156),
        dec: Angle.Degrees(+09.46887012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57501",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57501"},
        {"Smithsonian Astrophysical Observation", "SAO 119050"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.79446135),
        dec: Angle.Degrees(+09.46998263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215636"},
        {"Hipparcos Number", "HIP 112435"},
        {"Geneva Identification System", "GEN# +1.00215636"},
        {"Smithsonian Astrophysical Observation", "SAO 127748"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.62362060),
        dec: Angle.Degrees(+09.47140963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33021"},
        {"Hipparcos Number", "HIP 23852"},
        {"Geneva Identification System", "GEN# +1.00033021"},
        {"Smithsonian Astrophysical Observation", "SAO 112436"},
        {"Wilson Evans Batten Catalogue", "WEB 4652"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.90965166),
        dec: Angle.Degrees(+09.47270928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -382.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29132",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29132"},
    },
    visualMagnitude: 10.39,
    bvColour: 1.687,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.16977743),
        dec: Angle.Degrees(+09.47825311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99621"},
        {"Hipparcos Number", "HIP 55932"},
        {"Smithsonian Astrophysical Observation", "SAO 118872"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.974,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.94400539),
        dec: Angle.Degrees(+09.47854813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81324"},
        {"Hipparcos Number", "HIP 46197"},
        {"Smithsonian Astrophysical Observation", "SAO 117675"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.28987474),
        dec: Angle.Degrees(+09.47911495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210984"},
        {"Hipparcos Number", "HIP 109765"},
        {"Smithsonian Astrophysical Observation", "SAO 127391"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.49528147),
        dec: Angle.Degrees(+09.48015783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16807 AB"},
        {"Henry Draper", "HD 221305"},
        {"Hipparcos Number", "HIP 116055"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.73277363),
        dec: Angle.Degrees(+09.48213584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149995"},
        {"Hipparcos Number", "HIP 81430"},
        {"Smithsonian Astrophysical Observation", "SAO 121746"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.48264171),
        dec: Angle.Degrees(+09.48387764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10668"},
        {"Hipparcos Number", "HIP 8110"},
        {"Wilson Evans Batten Catalogue", "WEB 1732"},
    },
    visualMagnitude: 7.15,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.06292555),
        dec: Angle.Degrees(+09.48424502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 142.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4728",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 835 AB"},
        {"Henry Draper", "HD 5901"},
        {"Hipparcos Number", "HIP 4728"},
        {"Smithsonian Astrophysical Observation", "SAO 109596"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.17389368),
        dec: Angle.Degrees(+09.48687813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27236"},
        {"Hipparcos Number", "HIP 20089"},
        {"Geneva Identification System", "GEN# +1.00027236"},
        {"Smithsonian Astrophysical Observation", "SAO 111729"},
        {"Wilson Evans Batten Catalogue", "WEB 3837"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.60267190),
        dec: Angle.Degrees(+09.48720098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287095"},
        {"Hipparcos Number", "HIP 22085"},
        {"Smithsonian Astrophysical Observation", "SAO 112037"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.26705793),
        dec: Angle.Degrees(+09.48798017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26176",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "lambda Ori X-5"},
        {"Henry Draper", "HD 36822"},
        {"Hipparcos Number", "HIP 26176"},
        {"Celescope Catalog", "CEL 804"},
        {"Fundamental Katalog 5th Edition", "FK5 208"},
        {"Geneva Identification System", "GEN# +1.00036822"},
        {"Smithsonian Astrophysical Observation", "SAO 112914"},
        {"Wilson Evans Batten Catalogue", "WEB 5100"},
    },
    visualMagnitude: 4.39,
    bvColour: -0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.70515764),
        dec: Angle.Degrees(+09.48958528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30663"},
        {"Hipparcos Number", "HIP 22458"},
        {"Smithsonian Astrophysical Observation", "SAO 112108"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.48412507),
        dec: Angle.Degrees(+09.48962528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55678",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55678"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.12350960),
        dec: Angle.Degrees(+09.49028194)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31107"},
        {"Hipparcos Number", "HIP 22734"},
        {"Celescope Catalog", "CEL 480"},
        {"Geneva Identification System", "GEN# +1.00031107"},
        {"Smithsonian Astrophysical Observation", "SAO 112177"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.36525767),
        dec: Angle.Degrees(+09.49116813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71983"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.83368865),
        dec: Angle.Degrees(+09.49134000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 259264"},
        {"Hipparcos Number", "HIP 31184"},
        {"Geneva Identification System", "GEN# +1.00259264"},
        {"Smithsonian Astrophysical Observation", "SAO 114027"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.14992466),
        dec: Angle.Degrees(+09.49136999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78039",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78039"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.846,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.01788189),
        dec: Angle.Degrees(+09.49272196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -226.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267460"},
        {"Hipparcos Number", "HIP 33627"},
        {"Smithsonian Astrophysical Observation", "SAO 114726"},
    },
    visualMagnitude: 9.57,
    bvColour: -0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.79027884),
        dec: Angle.Degrees(+09.49345534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71998",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71998"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.86127594),
        dec: Angle.Degrees(+09.49370753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19257"},
    },
    visualMagnitude: 11.49,
    bvColour: 1.165,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.91447025),
        dec: Angle.Degrees(+09.49412248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10640"},
        {"Hipparcos Number", "HIP 8100"},
        {"Geneva Identification System", "GEN# +1.00010640"},
        {"Smithsonian Astrophysical Observation", "SAO 110096"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.01134299),
        dec: Angle.Degrees(+09.49684801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97036",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186312"},
        {"Hipparcos Number", "HIP 97036"},
        {"Geneva Identification System", "GEN# +1.00186312"},
        {"Smithsonian Astrophysical Observation", "SAO 124989"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.81816168),
        dec: Angle.Degrees(+09.49725081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55973"},
        {"Hipparcos Number", "HIP 35101"},
        {"Geneva Identification System", "GEN# +1.00055973"},
        {"Smithsonian Astrophysical Observation", "SAO 115150"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.87579031),
        dec: Angle.Degrees(+09.49761322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132374"},
        {"Hipparcos Number", "HIP 73271"},
        {"Geneva Identification System", "GEN# +1.00132374"},
        {"Smithsonian Astrophysical Observation", "SAO 120768"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.62942500),
        dec: Angle.Degrees(+09.49795331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58971"},
        {"Hipparcos Number", "HIP 36290"},
        {"Geneva Identification System", "GEN# +1.00058971"},
        {"Smithsonian Astrophysical Observation", "SAO 115479"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.05009563),
        dec: Angle.Degrees(+09.49885114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -269.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42159",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42159"},
        {"Smithsonian Astrophysical Observation", "SAO 116923"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.91409862),
        dec: Angle.Degrees(+09.49909613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106519",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205356"},
        {"Hipparcos Number", "HIP 106519"},
        {"Geneva Identification System", "GEN# +1.00205356"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.62380212),
        dec: Angle.Degrees(+09.49990517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6001",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6001"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.29736293),
        dec: Angle.Degrees(+09.50111503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24069",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24069"},
    },
    visualMagnitude: 12.27,
    bvColour: 1.383,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.57509798),
        dec: Angle.Degrees(+09.50290945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -351.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36970",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36970"},
        {"Smithsonian Astrophysical Observation", "SAO 115677"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.99694924),
        dec: Angle.Degrees(+09.50299353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219728"},
        {"Hipparcos Number", "HIP 115041"},
        {"Fundamental Katalog 5th Edition", "FK5 6060"},
        {"Smithsonian Astrophysical Observation", "SAO 128095"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.49944785),
        dec: Angle.Degrees(+09.50343349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286961"},
        {"Hipparcos Number", "HIP 21761"},
    },
    visualMagnitude: 10.11,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.10366921),
        dec: Angle.Degrees(+09.50403707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249515"},
        {"Hipparcos Number", "HIP 28123"},
        {"Smithsonian Astrophysical Observation", "SAO 113286"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.16071138),
        dec: Angle.Degrees(+09.50718893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151059"},
        {"Hipparcos Number", "HIP 81976"},
        {"Geneva Identification System", "GEN# +1.00151059"},
        {"Smithsonian Astrophysical Observation", "SAO 121829"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.18672169),
        dec: Angle.Degrees(+09.50773690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60509",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107952"},
        {"Hipparcos Number", "HIP 60509"},
        {"Geneva Identification System", "GEN# +1.00107952"},
        {"Smithsonian Astrophysical Observation", "SAO 119374"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.06864213),
        dec: Angle.Degrees(+09.50806460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48055"},
        {"Hipparcos Number", "HIP 32053"},
        {"Geneva Identification System", "GEN# +2.22640231"},
        {"Smithsonian Astrophysical Observation", "SAO 114286"},
        {"New General Catalogue", "NGC 2264 231"},
    },
    visualMagnitude: 8.99,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.45713706),
        dec: Angle.Degrees(+09.50816560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39985"},
        {"Hipparcos Number", "HIP 28110"},
        {"Geneva Identification System", "GEN# +1.00039985"},
        {"Smithsonian Astrophysical Observation", "SAO 113284"},
        {"Wilson Evans Batten Catalogue", "WEB 5502"},
    },
    visualMagnitude: 5.97,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.11681496),
        dec: Angle.Degrees(+09.50941963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223555"},
        {"Hipparcos Number", "HIP 117564"},
        {"Smithsonian Astrophysical Observation", "SAO 128414"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.62827261),
        dec: Angle.Degrees(+09.50977797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83603"},
        {"Hipparcos Number", "HIP 47435"},
        {"Smithsonian Astrophysical Observation", "SAO 117833"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.803,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.99030115),
        dec: Angle.Degrees(+09.51090611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95301"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.82417914),
        dec: Angle.Degrees(+09.51159495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1446",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 244 B"},
        {"Henry Draper", "HD 1376"},
        {"Hipparcos Number", "HIP 1446"},
        {"Smithsonian Astrophysical Observation", "SAO 109124"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.50111774),
        dec: Angle.Degrees(+09.51208255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56930"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.06962699),
        dec: Angle.Degrees(+09.51231362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -149.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98538",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189711"},
        {"Hipparcos Number", "HIP 98538"},
        {"Geneva Identification System", "GEN# +1.00189711"},
        {"Smithsonian Astrophysical Observation", "SAO 125356"},
        {"Wilson Evans Batten Catalogue", "WEB 17409"},
    },
    visualMagnitude: 8.50,
    bvColour: 2.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.26582016),
        dec: Angle.Degrees(+09.51426173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161338"},
        {"Hipparcos Number", "HIP 86848"},
        {"Smithsonian Astrophysical Observation", "SAO 122698"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.17903984),
        dec: Angle.Degrees(+09.51465813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1447",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 244 A"},
        {"Hipparcos Number", "HIP 1447"},
        {"Smithsonian Astrophysical Observation", "SAO 109125"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.50281028),
        dec: Angle.Degrees(+09.51491204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104004"},
        {"Smithsonian Astrophysical Observation", "SAO 126514"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.07044125),
        dec: Angle.Degrees(+09.51586352)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102869"},
        {"Hipparcos Number", "HIP 57755"},
        {"Smithsonian Astrophysical Observation", "SAO 119077"},
    },
    visualMagnitude: 8.26,
    bvColour: 1.127,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.66954995),
        dec: Angle.Degrees(+09.51616808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186442"},
        {"Hipparcos Number", "HIP 97101"},
        {"Geneva Identification System", "GEN# +1.00186442"},
        {"Smithsonian Astrophysical Observation", "SAO 125000"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.00747899),
        dec: Angle.Degrees(+09.51762405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287334"},
        {"Hipparcos Number", "HIP 23077"},
        {"Smithsonian Astrophysical Observation", "SAO 112267"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.48228536),
        dec: Angle.Degrees(+09.51764923)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10454 A"},
        {"Henry Draper", "HD 156615"},
        {"Hipparcos Number", "HIP 84644"},
        {"Smithsonian Astrophysical Observation", "SAO 122258"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.56587577),
        dec: Angle.Degrees(+09.51776067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140322"},
        {"Hipparcos Number", "HIP 76949"},
        {"Smithsonian Astrophysical Observation", "SAO 121142"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.67849003),
        dec: Angle.Degrees(+09.51936575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5558"},
        {"Hipparcos Number", "HIP 4485"},
        {"Smithsonian Astrophysical Observation", "SAO 109554"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.37000622),
        dec: Angle.Degrees(+09.51975351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27280",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4369 A"},
        {"Henry Draper", "HD 38527"},
        {"Hipparcos Number", "HIP 27280"},
        {"Fundamental Katalog 5th Edition", "FK5 2432"},
        {"Geneva Identification System", "GEN# +1.00038527"},
        {"Smithsonian Astrophysical Observation", "SAO 113124"},
        {"Wilson Evans Batten Catalogue", "WEB 5362"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.71731027),
        dec: Angle.Degrees(+09.52249963)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6268",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1091 AB"},
        {"Henry Draper", "HD 8089"},
        {"Hipparcos Number", "HIP 6268"},
        {"Smithsonian Astrophysical Observation", "SAO 109816"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.09461248),
        dec: Angle.Degrees(+09.52343169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81249"},
        {"Hipparcos Number", "HIP 46160"},
        {"Geneva Identification System", "GEN# +1.00081249"},
        {"Smithsonian Astrophysical Observation", "SAO 117667"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.392,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.20515011),
        dec: Angle.Degrees(+09.52491106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105295",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14856 AB"},
        {"Henry Draper", "HD 203067"},
        {"Hipparcos Number", "HIP 105295"},
        {"Smithsonian Astrophysical Observation", "SAO 126707"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.91395716),
        dec: Angle.Degrees(+09.52532589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63420",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112888"},
        {"Hipparcos Number", "HIP 63420"},
        {"Geneva Identification System", "GEN# +1.00112888"},
        {"Smithsonian Astrophysical Observation", "SAO 119702"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.94185181),
        dec: Angle.Degrees(+09.52599619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1584"},
        {"Hipparcos Number", "HIP 1620"},
        {"Smithsonian Astrophysical Observation", "SAO 109148"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.06292003),
        dec: Angle.Degrees(+09.52657424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 193.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71840",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9345 AB"},
        {"Henry Draper", "HD 129337"},
        {"Hipparcos Number", "HIP 71840"},
        {"Smithsonian Astrophysical Observation", "SAO 120604"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.43615256),
        dec: Angle.Degrees(+09.52765309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1015",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1015"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.16439337),
        dec: Angle.Degrees(+09.52777332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23634"},
        {"Hipparcos Number", "HIP 17658"},
        {"Smithsonian Astrophysical Observation", "SAO 111414"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.73370612),
        dec: Angle.Degrees(+09.53043596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6720",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6720"},
        {"Smithsonian Astrophysical Observation", "SAO 109891"},
    },
    visualMagnitude: 9.81,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.62004630),
        dec: Angle.Degrees(+09.53107912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26294",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37035"},
        {"Hipparcos Number", "HIP 26294"},
        {"Geneva Identification System", "GEN# +1.00037035"},
        {"Smithsonian Astrophysical Observation", "SAO 112941"},
    },
    visualMagnitude: 8.65,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.99271714),
        dec: Angle.Degrees(+09.53172236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40546"},
        {"Hipparcos Number", "HIP 28397"},
        {"Geneva Identification System", "GEN# +1.00040546"},
        {"Smithsonian Astrophysical Observation", "SAO 113335"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.97092747),
        dec: Angle.Degrees(+09.53374075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116334",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116334"},
        {"Geneva Identification System", "GEN# +9.80029044"},
    },
    visualMagnitude: 11.23,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.58777794),
        dec: Angle.Degrees(+09.53452562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -253.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -246.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38560"},
        {"Hipparcos Number", "HIP 27306"},
        {"Smithsonian Astrophysical Observation", "SAO 113132"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.77992768),
        dec: Angle.Degrees(+09.53524497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20941"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.34852404),
        dec: Angle.Degrees(+09.53593002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64262",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64262"},
        {"Geneva Identification System", "GEN# +0.01002518"},
        {"Smithsonian Astrophysical Observation", "SAO 119798"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.57027392),
        dec: Angle.Degrees(+09.53646613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 183.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85608",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85608"},
    },
    visualMagnitude: 9.79,
    bvColour: 1.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.40717456),
        dec: Angle.Degrees(+09.53697692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111028"},
        {"Hipparcos Number", "HIP 62325"},
        {"Cincinnati Publication", "Ci 20 736"},
        {"Geneva Identification System", "GEN# +1.00111028"},
        {"Smithsonian Astrophysical Observation", "SAO 119580"},
        {"Wilson Evans Batten Catalogue", "WEB 11069"},
    },
    visualMagnitude: 5.65,
    bvColour: 0.989,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.59324849),
        dec: Angle.Degrees(+09.54078962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 278.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -455.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79568",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146083"},
        {"Hipparcos Number", "HIP 79568"},
        {"Geneva Identification System", "GEN# +1.00146083"},
        {"Smithsonian Astrophysical Observation", "SAO 121441"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.52730021),
        dec: Angle.Degrees(+09.54087214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162404"},
        {"Hipparcos Number", "HIP 87326"},
        {"Smithsonian Astrophysical Observation", "SAO 122820"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.65496825),
        dec: Angle.Degrees(+09.54209086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71169"},
        {"Hipparcos Number", "HIP 41358"},
        {"Smithsonian Astrophysical Observation", "SAO 116759"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.56684186),
        dec: Angle.Degrees(+09.54313405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104570",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14715 AB"},
        {"Henry Draper", "HD 201686"},
        {"Hipparcos Number", "HIP 104570"},
        {"Smithsonian Astrophysical Observation", "SAO 126601"},
    },
    visualMagnitude: 7.44,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.74713804),
        dec: Angle.Degrees(+09.54942429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224546"},
        {"Hipparcos Number", "HIP 118222"},
        {"Smithsonian Astrophysical Observation", "SAO 128507"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.70440400),
        dec: Angle.Degrees(+09.55014305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70169",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125772"},
        {"Hipparcos Number", "HIP 70169"},
        {"Smithsonian Astrophysical Observation", "SAO 120411"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.34746852),
        dec: Angle.Degrees(+09.55096609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127044"},
        {"Hipparcos Number", "HIP 70820"},
        {"Smithsonian Astrophysical Observation", "SAO 120491"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.24759292),
        dec: Angle.Degrees(+09.55099358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103967"},
        {"Hipparcos Number", "HIP 58393"},
        {"Smithsonian Astrophysical Observation", "SAO 119141"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.59923290),
        dec: Angle.Degrees(+09.55269705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122717"},
        {"Hipparcos Number", "HIP 68663"},
        {"Smithsonian Astrophysical Observation", "SAO 120258"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.83516096),
        dec: Angle.Degrees(+09.55357553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42762"},
        {"Cincinnati Publication", "Ci 20 485"},
        {"Geneva Identification System", "GEN# +0.01001857C"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.71706848),
        dec: Angle.Degrees(+09.55459680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 223.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -616.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42748",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42748"},
        {"Cincinnati Publication", "Ci 20 484"},
        {"Geneva Identification System", "GEN# +0.01001857"},
        {"Wilson Evans Batten Catalogue", "WEB 8256"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.68501499),
        dec: Angle.Degrees(+09.55823981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 216.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -634.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39479"},
        {"Hipparcos Number", "HIP 27826"},
        {"Smithsonian Astrophysical Observation", "SAO 113234"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.32508269),
        dec: Angle.Degrees(+09.55892069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185061"},
        {"Hipparcos Number", "HIP 96497"},
        {"Geneva Identification System", "GEN# +1.00185061"},
        {"Smithsonian Astrophysical Observation", "SAO 124853"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.26521993),
        dec: Angle.Degrees(+09.55941689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16313"},
        {"Hipparcos Number", "HIP 12227"},
        {"Smithsonian Astrophysical Observation", "SAO 110646"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.35590960),
        dec: Angle.Degrees(+09.56174548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 972 A"},
        {"Henry Draper", "HD 7047"},
        {"Hipparcos Number", "HIP 5534"},
        {"Cincinnati Publication", "Ci 18 154"},
        {"Geneva Identification System", "GEN# +1.00007047"},
        {"Smithsonian Astrophysical Observation", "SAO 109718"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.72594414),
        dec: Angle.Degrees(+09.56332494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 94.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 237.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88771",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11076 A"},
        {"Henry Draper", "HD 165777"},
        {"Hipparcos Number", "HIP 88771"},
        {"Fundamental Katalog 5th Edition", "FK5 680"},
        {"Geneva Identification System", "GEN# +1.00165777A"},
        {"Renson", "Renson 46702"},
        {"Smithsonian Astrophysical Observation", "SAO 123142"},
        {"Wilson Evans Batten Catalogue", "WEB 15039"},
    },
    visualMagnitude: 3.71,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.83758610),
        dec: Angle.Degrees(+09.56365345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 79.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88204",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164430"},
        {"Hipparcos Number", "HIP 88204"},
        {"Smithsonian Astrophysical Observation", "SAO 123016"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.18348029),
        dec: Angle.Degrees(+09.56393470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90762"},
        {"Hipparcos Number", "HIP 51316"},
        {"Smithsonian Astrophysical Observation", "SAO 118325"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.23285626),
        dec: Angle.Degrees(+09.56516747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11603",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1896 A"},
        {"Henry Draper", "HD 15453"},
        {"Hipparcos Number", "HIP 11603"},
        {"Geneva Identification System", "GEN# +1.00015453"},
        {"Smithsonian Astrophysical Observation", "SAO 110565"},
        {"Wilson Evans Batten Catalogue", "WEB 2418"},
    },
    visualMagnitude: 6.09,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.39732674),
        dec: Angle.Degrees(+09.56562436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77829",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77829"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.37778081),
        dec: Angle.Degrees(+09.56590481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -154.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 160.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16778",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16778"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.98132660),
        dec: Angle.Degrees(+09.56605154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 255966"},
        {"Hipparcos Number", "HIP 30280"},
    },
    visualMagnitude: 10.83,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.54237324),
        dec: Angle.Degrees(+09.56816960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1360 AB"},
        {"Henry Draper", "HD 10619"},
        {"Hipparcos Number", "HIP 8078"},
        {"Smithsonian Astrophysical Observation", "SAO 110089"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.93731432),
        dec: Angle.Degrees(+09.56877399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10667"},
        {"Hipparcos Number", "HIP 8113"},
        {"Smithsonian Astrophysical Observation", "SAO 110101"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.632,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.06572254),
        dec: Angle.Degrees(+09.56978776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32340",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32340"},
    },
    visualMagnitude: 10.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)06, (int)45, 03.0800),
        dec: Angle.DegreesMinutesSeconds((int)+09, (int)34, 18.900)
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
    primaryId: "HIP 47710",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47710"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.049,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.90849340),
        dec: Angle.Degrees(+09.57448563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73316"},
        {"Hipparcos Number", "HIP 42353"},
        {"Geneva Identification System", "GEN# +1.00073316"},
        {"Smithsonian Astrophysical Observation", "SAO 116975"},
        {"Wilson Evans Batten Catalogue", "WEB 8140"},
    },
    visualMagnitude: 6.54,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.52164161),
        dec: Angle.Degrees(+09.57463555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68062"},
        {"Hipparcos Number", "HIP 40065"},
        {"Geneva Identification System", "GEN# +1.00068062"},
        {"Smithsonian Astrophysical Observation", "SAO 116439"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.76230602),
        dec: Angle.Degrees(+09.57668578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52554",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52554"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.967,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.17019292),
        dec: Angle.Degrees(+09.57690139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -163.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40222",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6659 A"},
        {"Henry Draper", "HD 68483"},
        {"Hipparcos Number", "HIP 40222"},
        {"Geneva Identification System", "GEN# +1.00068483"},
        {"Smithsonian Astrophysical Observation", "SAO 116479"},
        {"Wilson Evans Batten Catalogue", "WEB 7843"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.21892327),
        dec: Angle.Degrees(+09.57783471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135104"},
        {"Hipparcos Number", "HIP 74471"},
        {"Smithsonian Astrophysical Observation", "SAO 120897"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.26369473),
        dec: Angle.Degrees(+09.57813279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100727"},
        {"Hipparcos Number", "HIP 56542"},
        {"Smithsonian Astrophysical Observation", "SAO 118935"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.90616059),
        dec: Angle.Degrees(+09.58057629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178404"},
        {"Hipparcos Number", "HIP 93986"},
        {"Geneva Identification System", "GEN# +1.00178404"},
        {"Smithsonian Astrophysical Observation", "SAO 124308"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.422,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.04815076),
        dec: Angle.Degrees(+09.58112221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40165"},
        {"Hipparcos Number", "HIP 28200"},
        {"Geneva Identification System", "GEN# +1.00040165"},
        {"Smithsonian Astrophysical Observation", "SAO 113293"},
    },
    visualMagnitude: 8.40,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.38853856),
        dec: Angle.Degrees(+09.58140248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49566"},
        {"Hipparcos Number", "HIP 32705"},
        {"Geneva Identification System", "GEN# +1.00049566"},
        {"Smithsonian Astrophysical Observation", "SAO 114468"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.34879904),
        dec: Angle.Degrees(+09.58178269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217718"},
        {"Hipparcos Number", "HIP 113776"},
        {"Smithsonian Astrophysical Observation", "SAO 127919"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.62375256),
        dec: Angle.Degrees(+09.58267460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109869"},
        {"Hipparcos Number", "HIP 61640"},
        {"Smithsonian Astrophysical Observation", "SAO 119505"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.53709279),
        dec: Angle.Degrees(+09.58563087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6346"},
        {"Hipparcos Number", "HIP 5048"},
        {"Smithsonian Astrophysical Observation", "SAO 109652"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.16021082),
        dec: Angle.Degrees(+09.58612180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85998",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10635 A"},
        {"Henry Draper", "HD 159480"},
        {"Hipparcos Number", "HIP 85998"},
        {"Geneva Identification System", "GEN# +1.00159480A"},
        {"Smithsonian Astrophysical Observation", "SAO 122526"},
        {"Wilson Evans Batten Catalogue", "WEB 14509"},
    },
    visualMagnitude: 5.80,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.65287832),
        dec: Angle.Degrees(+09.58672378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88071"},
        {"Hipparcos Number", "HIP 49766"},
        {"Geneva Identification System", "GEN# +1.00088071"},
        {"Smithsonian Astrophysical Observation", "SAO 118138"},
        {"Wilson Evans Batten Catalogue", "WEB 9174"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.38116998),
        dec: Angle.Degrees(+09.59307180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9957"},
        {"Hipparcos Number", "HIP 7561"},
        {"Smithsonian Astrophysical Observation", "SAO 110016"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.35215023),
        dec: Angle.Degrees(+09.59407971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82810"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.85986651),
        dec: Angle.Degrees(+09.59620109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50054",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50054"},
        {"Cincinnati Publication", "Ci 20 567"},
        {"Geneva Identification System", "GEN# +0.01002122"},
        {"Wilson Evans Batten Catalogue", "WEB 9201"},
    },
    visualMagnitude: 9.90,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.28978139),
        dec: Angle.Degrees(+09.59693063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -559.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42821"},
        {"Hipparcos Number", "HIP 29529"},
        {"Smithsonian Astrophysical Observation", "SAO 113597"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.31577231),
        dec: Angle.Degrees(+09.59801325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136886"},
        {"Hipparcos Number", "HIP 75278"},
        {"Smithsonian Astrophysical Observation", "SAO 120968"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.69942616),
        dec: Angle.Degrees(+09.59885034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59562"},
        {"Hipparcos Number", "HIP 36524"},
        {"Smithsonian Astrophysical Observation", "SAO 115540"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.70974699),
        dec: Angle.Degrees(+09.60227192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37679",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62347"},
        {"Hipparcos Number", "HIP 37679"},
        {"Smithsonian Astrophysical Observation", "SAO 115858"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.95819796),
        dec: Angle.Degrees(+09.60366109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51004"},
    },
    visualMagnitude: 9.71,
    bvColour: 1.253,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.28952981),
        dec: Angle.Degrees(+09.60629277)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51898",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91812"},
        {"Hipparcos Number", "HIP 51898"},
        {"Smithsonian Astrophysical Observation", "SAO 118390"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.04647958),
        dec: Angle.Degrees(+09.60733807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141531"},
        {"Hipparcos Number", "HIP 77483"},
        {"Geneva Identification System", "GEN# +1.00141531"},
        {"Smithsonian Astrophysical Observation", "SAO 121207"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.31877259),
        dec: Angle.Degrees(+09.61192494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -55.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36895"},
        {"Hipparcos Number", "HIP 26212"},
        {"Celescope Catalog", "CEL 814"},
        {"Geneva Identification System", "GEN# +1.00036895"},
        {"Smithsonian Astrophysical Observation", "SAO 112922"},
        {"Wilson Evans Batten Catalogue", "WEB 5118"},
    },
    visualMagnitude: 6.72,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80331550),
        dec: Angle.Degrees(+09.61326949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94916",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181122"},
        {"Hipparcos Number", "HIP 94916"},
        {"Geneva Identification System", "GEN# +1.00181122"},
        {"Smithsonian Astrophysical Observation", "SAO 124497"},
        {"Wilson Evans Batten Catalogue", "WEB 16570"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.71979820),
        dec: Angle.Degrees(+09.61816161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1884",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1943"},
        {"Hipparcos Number", "HIP 1884"},
        {"Smithsonian Astrophysical Observation", "SAO 109174"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.633,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.94230951),
        dec: Angle.Degrees(+09.61930702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 91.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96460"},
        {"Hipparcos Number", "HIP 54346"},
        {"Smithsonian Astrophysical Observation", "SAO 118669"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.725,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.76936300),
        dec: Angle.Degrees(+09.61960398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -180.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56185",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100069"},
        {"Hipparcos Number", "HIP 56185"},
        {"Geneva Identification System", "GEN# +1.00100069"},
        {"Smithsonian Astrophysical Observation", "SAO 118900"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.75301563),
        dec: Angle.Degrees(+09.62032841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287022"},
        {"Hipparcos Number", "HIP 21954"},
        {"Smithsonian Astrophysical Observation", "SAO 112006"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.77708857),
        dec: Angle.Degrees(+09.62042275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202241"},
        {"Hipparcos Number", "HIP 104831"},
        {"Smithsonian Astrophysical Observation", "SAO 126638"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.56417761),
        dec: Angle.Degrees(+09.62372964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18540",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18540"},
    },
    visualMagnitude: 11.07,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.49075373),
        dec: Angle.Degrees(+09.62494506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74012",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74012"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.87966526),
        dec: Angle.Degrees(+09.62529013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18539",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18539"},
        {"Smithsonian Astrophysical Observation", "SAO 111526"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.48606176),
        dec: Angle.Degrees(+09.62529842)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114606"},
        {"Hipparcos Number", "HIP 64345"},
        {"Cincinnati Publication", "Ci 20 763"},
        {"Cincinnati Publication 2", "Ci 18 1692"},
        {"Geneva Identification System", "GEN# +1.00114606A"},
        {"Smithsonian Astrophysical Observation", "SAO 119805"},
        {"Wilson Evans Batten Catalogue", "WEB 11373"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.84046662),
        dec: Angle.Degrees(+09.62532760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -520.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 267.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47325",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47325"},
        {"Smithsonian Astrophysical Observation", "SAO 117823"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.64920314),
        dec: Angle.Degrees(+09.62627690)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30753",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45445"},
        {"Hipparcos Number", "HIP 30753"},
        {"Smithsonian Astrophysical Observation", "SAO 113916"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.92960735),
        dec: Angle.Degrees(+09.62654632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155264"},
        {"Hipparcos Number", "HIP 83994"},
        {"Smithsonian Astrophysical Observation", "SAO 122147"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54859046),
        dec: Angle.Degrees(+09.62694000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65971"},
        {"Hipparcos Number", "HIP 39258"},
        {"Geneva Identification System", "GEN# +1.00065971"},
        {"Smithsonian Astrophysical Observation", "SAO 116246"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.42259309),
        dec: Angle.Degrees(+09.62708752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65490",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65490"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.33696919),
        dec: Angle.Degrees(+09.62835245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42860"},
        {"Hipparcos Number", "HIP 29540"},
        {"Celescope Catalog", "CEL 1126"},
        {"Geneva Identification System", "GEN# +1.00042860"},
        {"Smithsonian Astrophysical Observation", "SAO 113603"},
    },
    visualMagnitude: 7.58,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.37684648),
        dec: Angle.Degrees(+09.62866164)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29386",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42532"},
        {"Hipparcos Number", "HIP 29386"},
        {"Geneva Identification System", "GEN# +1.00042532"},
        {"Smithsonian Astrophysical Observation", "SAO 113565"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.89612495),
        dec: Angle.Degrees(+09.62941394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -108.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183302"},
        {"Hipparcos Number", "HIP 95748"},
        {"Geneva Identification System", "GEN# +1.00183302"},
        {"Smithsonian Astrophysical Observation", "SAO 124667"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.11620717),
        dec: Angle.Degrees(+09.62965607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187753"},
        {"Hipparcos Number", "HIP 97697"},
        {"Geneva Identification System", "GEN# +1.00187753"},
        {"Renson", "Renson 51810"},
        {"Smithsonian Astrophysical Observation", "SAO 125139"},
        {"Wilson Evans Batten Catalogue", "WEB 17184"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.82386363),
        dec: Angle.Degrees(+09.62994013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204012"},
        {"Hipparcos Number", "HIP 105785"},
        {"Smithsonian Astrophysical Observation", "SAO 126788"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.36553439),
        dec: Angle.Degrees(+09.63026182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64114",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64114"},
        {"Geneva Identification System", "GEN# +0.01002513"},
        {"Smithsonian Astrophysical Observation", "SAO 119784"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.10721776),
        dec: Angle.Degrees(+09.63095185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38021",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63107"},
        {"Hipparcos Number", "HIP 38021"},
        {"Geneva Identification System", "GEN# +1.00063107"},
        {"Smithsonian Astrophysical Observation", "SAO 115932"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.88572570),
        dec: Angle.Degrees(+09.63218855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 152.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176980"},
        {"Hipparcos Number", "HIP 93494"},
        {"Smithsonian Astrophysical Observation", "SAO 124186"},
        {"Wilson Evans Batten Catalogue", "WEB 16228"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.60726578),
        dec: Angle.Degrees(+09.63305530)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29819"},
        {"Hipparcos Number", "HIP 21882"},
        {"Celescope Catalog", "CEL 457"},
        {"Fundamental Katalog 5th Edition", "FK5 4421"},
        {"Geneva Identification System", "GEN# +1.00029819A"},
        {"Smithsonian Astrophysical Observation", "SAO 111989"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.354,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.56246692),
        dec: Angle.Degrees(+09.63397873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18596"},
        {"Hipparcos Number", "HIP 13950"},
        {"Smithsonian Astrophysical Observation", "SAO 110888"},
    },
    visualMagnitude: 8.48,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.91947575),
        dec: Angle.Degrees(+09.63538584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132754"},
        {"Hipparcos Number", "HIP 73447"},
        {"Smithsonian Astrophysical Observation", "SAO 120788"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.13451014),
        dec: Angle.Degrees(+09.63734389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3456"},
        {"Hipparcos Number", "HIP 2963"},
        {"Smithsonian Astrophysical Observation", "SAO 109317"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.40758090),
        dec: Angle.Degrees(+09.64144345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177624"},
        {"Hipparcos Number", "HIP 93732"},
        {"Celescope Catalog", "CEL 4695"},
        {"Geneva Identification System", "GEN# +1.00177624"},
        {"Smithsonian Astrophysical Observation", "SAO 124246"},
        {"Wilson Evans Batten Catalogue", "WEB 16290"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.28560194),
        dec: Angle.Degrees(+09.64213837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144304"},
        {"Hipparcos Number", "HIP 78763"},
        {"Geneva Identification System", "GEN# +1.00144304"},
        {"Smithsonian Astrophysical Observation", "SAO 121356"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.20567037),
        dec: Angle.Degrees(+09.64497424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25578"},
        {"Cincinnati Publication", "Ci 20 329"},
        {"Geneva Identification System", "GEN# +6.10010203"},
        {"Geneva Identification System 2", "GEN# +9.80097042"},
    },
    visualMagnitude: 12.48,
    bvColour: 1.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.00110606),
        dec: Angle.Degrees(+09.64577431)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -759.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23841"},
        {"Hipparcos Number", "HIP 17792"},
        {"Fundamental Katalog 5th Edition", "FK5 2270"},
        {"Geneva Identification System", "GEN# +1.00023841"},
        {"Smithsonian Astrophysical Observation", "SAO 111430"},
        {"Wilson Evans Batten Catalogue", "WEB 3410"},
    },
    visualMagnitude: 6.68,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.12801966),
        dec: Angle.Degrees(+09.64592314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28614",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4617 AB"},
        {"Henry Draper", "HD 40932"},
        {"Hipparcos Number", "HIP 28614"},
        {"Celescope Catalog", "CEL 1062"},
        {"Geneva Identification System", "GEN# +5.20250169J"},
        {"Smithsonian Astrophysical Observation", "SAO 113389"},
        {"Wilson Evans Batten Catalogue", "WEB 5590"},
        {"Wilson Evans Batten Catalogue 2", "WEB 5591"},
    },
    visualMagnitude: 4.12,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.59579323),
        dec: Angle.Degrees(+09.64736756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9380 AB"},
        {"Henry Draper", "HD 130145"},
        {"Hipparcos Number", "HIP 72221"},
        {"Geneva Identification System", "GEN# +1.00130145"},
        {"Smithsonian Astrophysical Observation", "SAO 120651"},
        {"Wilson Evans Batten Catalogue", "WEB 12427"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.56473970),
        dec: Angle.Degrees(+09.64738886)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -264.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220108"},
        {"Hipparcos Number", "HIP 115293"},
        {"Geneva Identification System", "GEN# +1.00220108"},
        {"Smithsonian Astrophysical Observation", "SAO 128134"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.24535953),
        dec: Angle.Degrees(+09.64809104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193142"},
        {"Hipparcos Number", "HIP 100094"},
        {"Smithsonian Astrophysical Observation", "SAO 125662"},
    },
    visualMagnitude: 8.10,
    bvColour: 1.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.58950383),
        dec: Angle.Degrees(+09.64980953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50817"},
        {"Hipparcos Number", "HIP 33259"},
        {"Geneva Identification System", "GEN# +1.00050817"},
        {"Smithsonian Astrophysical Observation", "SAO 114613"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.79720113),
        dec: Angle.Degrees(+09.65009730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140254"},
        {"Hipparcos Number", "HIP 76910"},
        {"Geneva Identification System", "GEN# +1.00140254"},
        {"Smithsonian Astrophysical Observation", "SAO 121133"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.56623835),
        dec: Angle.Degrees(+09.65090209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32303"},
        {"Hipparcos Number", "HIP 23461"},
        {"Smithsonian Astrophysical Observation", "SAO 112349"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.63857418),
        dec: Angle.Degrees(+09.65098885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22670"},
        {"Hipparcos Number", "HIP 17032"},
        {"Smithsonian Astrophysical Observation", "SAO 111320"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.76854911),
        dec: Angle.Degrees(+09.65291967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56663",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56663"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.727,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.27656350),
        dec: Angle.Degrees(+09.65387090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35601",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6000 A"},
        {"Henry Draper", "HD 57270"},
        {"Hipparcos Number", "HIP 35601"},
        {"Smithsonian Astrophysical Observation", "SAO 115300"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.20563977),
        dec: Angle.Degrees(+09.65387899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73143"},
        {"Hipparcos Number", "HIP 42265"},
        {"Fundamental Katalog 5th Edition", "FK5 2675"},
        {"Geneva Identification System", "GEN# +1.00073143"},
        {"Smithsonian Astrophysical Observation", "SAO 116953"},
        {"Wilson Evans Batten Catalogue", "WEB 8120"},
    },
    visualMagnitude: 5.92,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.27410956),
        dec: Angle.Degrees(+09.65559645)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47777"},
        {"Hipparcos Number", "HIP 31955"},
        {"Geneva Identification System", "GEN# +2.22640083"},
        {"Smithsonian Astrophysical Observation", "SAO 114250"},
        {"Wilson Evans Batten Catalogue", "WEB 6426"},
        {"New General Catalogue", "NGC 2264 83"},
    },
    visualMagnitude: 7.96,
    bvColour: -0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.17622460),
        dec: Angle.Degrees(+09.65592947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76051",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9686 C"},
        {"Hipparcos Number", "HIP 76051"},
        {"Smithsonian Astrophysical Observation", "SAO 121045"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.787,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.97530038),
        dec: Angle.Degrees(+09.65746253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175100"},
        {"Hipparcos Number", "HIP 92715"},
        {"Geneva Identification System", "GEN# +1.00175100"},
        {"Smithsonian Astrophysical Observation", "SAO 124013"},
    },
    visualMagnitude: 7.40,
    bvColour: 1.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.37458020),
        dec: Angle.Degrees(+09.65857677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20789"},
        {"Hipparcos Number", "HIP 15630"},
        {"Smithsonian Astrophysical Observation", "SAO 111143"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.32242173),
        dec: Angle.Degrees(+09.65985912)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76052",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9686 AB"},
        {"Henry Draper", "HD 138455"},
        {"Hipparcos Number", "HIP 76052"},
        {"Smithsonian Astrophysical Observation", "SAO 121047"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.97834059),
        dec: Angle.Degrees(+09.66087405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105263"},
        {"Hipparcos Number", "HIP 59100"},
        {"Fundamental Katalog 5th Edition", "FK5 5071"},
        {"Smithsonian Astrophysical Observation", "SAO 119224"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.79497411),
        dec: Angle.Degrees(+09.66290022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38526"},
        {"Hipparcos Number", "HIP 27276"},
        {"Smithsonian Astrophysical Observation", "SAO 113120"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.70749883),
        dec: Angle.Degrees(+09.66299755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86479",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86479"},
    },
    visualMagnitude: 10.74,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.06337881),
        dec: Angle.Degrees(+09.66511393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19033"},
        {"Hipparcos Number", "HIP 14274"},
        {"Geneva Identification System", "GEN# +1.00019033"},
        {"Smithsonian Astrophysical Observation", "SAO 110940"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.00444841),
        dec: Angle.Degrees(+09.66534804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102974",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102974"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.94516641),
        dec: Angle.Degrees(+09.66595391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36510"},
        {"Hipparcos Number", "HIP 25972"},
        {"Smithsonian Astrophysical Observation", "SAO 112884"},
    },
    visualMagnitude: 8.43,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.13646860),
        dec: Angle.Degrees(+09.66968469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210041"},
        {"Hipparcos Number", "HIP 109218"},
        {"Smithsonian Astrophysical Observation", "SAO 127309"},
    },
    visualMagnitude: 7.06,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.88061117),
        dec: Angle.Degrees(+09.67102137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94969"},
        {"Hipparcos Number", "HIP 53596"},
        {"Smithsonian Astrophysical Observation", "SAO 118592"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.48172391),
        dec: Angle.Degrees(+09.67125721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78195"},
        {"Hipparcos Number", "HIP 44748"},
        {"Smithsonian Astrophysical Observation", "SAO 117433"},
        {"Wilson Evans Batten Catalogue", "WEB 8557"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.79419900),
        dec: Angle.Degrees(+09.67139857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68094",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 68094"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.11850546),
        dec: Angle.Degrees(+09.67323810)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82840"},
        {"Hipparcos Number", "HIP 47012"},
        {"Geneva Identification System", "GEN# +1.00082840"},
        {"Smithsonian Astrophysical Observation", "SAO 117780"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.72014022),
        dec: Angle.Degrees(+09.67725327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -125.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222377"},
        {"Hipparcos Number", "HIP 116768"},
        {"Geneva Identification System", "GEN# +1.00222377"},
        {"Renson", "Renson 60980"},
        {"Smithsonian Astrophysical Observation", "SAO 128309"},
        {"Wilson Evans Batten Catalogue", "WEB 20604"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.97911505),
        dec: Angle.Degrees(+09.67732079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68170"},
        {"Hipparcos Number", "HIP 40114"},
        {"Smithsonian Astrophysical Observation", "SAO 116456"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.90002371),
        dec: Angle.Degrees(+09.67771851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85143"},
        {"Hipparcos Number", "HIP 48246"},
        {"Geneva Identification System", "GEN# +1.00085143"},
        {"Smithsonian Astrophysical Observation", "SAO 117932"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.53969361),
        dec: Angle.Degrees(+09.68026307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90587",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170424"},
        {"Hipparcos Number", "HIP 90587"},
        {"Smithsonian Astrophysical Observation", "SAO 123551"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.26618888),
        dec: Angle.Degrees(+09.68301820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22062"},
        {"Hipparcos Number", "HIP 16604"},
        {"Smithsonian Astrophysical Observation", "SAO 111258"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.43379171),
        dec: Angle.Degrees(+09.68408901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175336"},
        {"Hipparcos Number", "HIP 92806"},
        {"Smithsonian Astrophysical Observation", "SAO 124033"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.64970893),
        dec: Angle.Degrees(+09.68576731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122563"},
        {"Hipparcos Number", "HIP 68594"},
        {"Geneva Identification System", "GEN# +1.00122563"},
        {"Smithsonian Astrophysical Observation", "SAO 120251"},
        {"Wilson Evans Batten Catalogue", "WEB 12011"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.63315739),
        dec: Angle.Degrees(+09.68626604)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -188.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99686",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99686"},
        {"Cincinnati Publication", "Ci 18 2639"},
        {"Smithsonian Astrophysical Observation", "SAO 125592"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.691,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.42984008),
        dec: Angle.Degrees(+09.68765499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16255",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16255"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.36747625),
        dec: Angle.Degrees(+09.69088319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21158"},
        {"Hipparcos Number", "HIP 15936"},
        {"Smithsonian Astrophysical Observation", "SAO 111178"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.30438434),
        dec: Angle.Degrees(+09.69121989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115004"},
        {"Geneva Identification System", "GEN# +0.00805036"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.38430810),
        dec: Angle.Degrees(+09.69355818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86340"},
        {"Hipparcos Number", "HIP 48866"},
        {"Smithsonian Astrophysical Observation", "SAO 118022"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.50246282),
        dec: Angle.Degrees(+09.69467573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172504"},
        {"Hipparcos Number", "HIP 91555"},
        {"Geneva Identification System", "GEN# +1.00172504"},
        {"Smithsonian Astrophysical Observation", "SAO 123790"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.07136933),
        dec: Angle.Degrees(+09.69582731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17444",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17444"},
        {"Smithsonian Astrophysical Observation", "SAO 111383"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.05763655),
        dec: Angle.Degrees(+09.69684441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169911"},
        {"Hipparcos Number", "HIP 90381"},
        {"Smithsonian Astrophysical Observation", "SAO 123481"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.63604665),
        dec: Angle.Degrees(+09.69684689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172521"},
        {"Hipparcos Number", "HIP 91562"},
        {"Geneva Identification System", "GEN# +1.00172521"},
        {"Smithsonian Astrophysical Observation", "SAO 123792"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.08758877),
        dec: Angle.Degrees(+09.69738496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2622"},
        {"Hipparcos Number", "HIP 2332"},
        {"Smithsonian Astrophysical Observation", "SAO 109234"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46166210),
        dec: Angle.Degrees(+09.69782308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175990"},
        {"Hipparcos Number", "HIP 93084"},
        {"Smithsonian Astrophysical Observation", "SAO 124102"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.42840760),
        dec: Angle.Degrees(+09.69804434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212141"},
        {"Hipparcos Number", "HIP 110423"},
        {"Geneva Identification System", "GEN# +1.00212141"},
        {"Smithsonian Astrophysical Observation", "SAO 127478"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.49722326),
        dec: Angle.Degrees(+09.69847629)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 138.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104798"},
        {"Hipparcos Number", "HIP 58844"},
        {"Smithsonian Astrophysical Observation", "SAO 119192"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.02856606),
        dec: Angle.Degrees(+09.69867976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31658",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260860"},
        {"Hipparcos Number", "HIP 31658"},
    },
    visualMagnitude: 10.22,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.38950561),
        dec: Angle.Degrees(+09.69924141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75645",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9643 AB"},
        {"Henry Draper", "HD 137723"},
        {"Hipparcos Number", "HIP 75645"},
        {"Geneva Identification System", "GEN# +1.00137723"},
        {"Smithsonian Astrophysical Observation", "SAO 121010"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.82512391),
        dec: Angle.Degrees(+09.70029914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175989"},
        {"Hipparcos Number", "HIP 93083"},
        {"Smithsonian Astrophysical Observation", "SAO 124100"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.42503615),
        dec: Angle.Degrees(+09.70071071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95004"},
        {"Hipparcos Number", "HIP 53619"},
        {"Smithsonian Astrophysical Observation", "SAO 118593"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.239,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.54957870),
        dec: Angle.Degrees(+09.70187480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114061"},
    },
    visualMagnitude: 11.81,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.49093927),
        dec: Angle.Degrees(+09.70282589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 141.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83143",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10295 AB"},
        {"Henry Draper", "HD 153475"},
        {"Hipparcos Number", "HIP 83143"},
        {"Smithsonian Astrophysical Observation", "SAO 121980"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.468,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.87307799),
        dec: Angle.Degrees(+09.70342801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37484",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6291 AB"},
        {"Henry Draper", "HD 61886"},
        {"Hipparcos Number", "HIP 37484"},
        {"Smithsonian Astrophysical Observation", "SAO 115814"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.42649034),
        dec: Angle.Degrees(+09.70487240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8219"},
        {"Hipparcos Number", "HIP 6363"},
        {"Smithsonian Astrophysical Observation", "SAO 109826"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.43354998),
        dec: Angle.Degrees(+09.70601813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19552"},
        {"Hipparcos Number", "HIP 14630"},
        {"Smithsonian Astrophysical Observation", "SAO 111003"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.25075856),
        dec: Angle.Degrees(+09.71169607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145589"},
        {"Hipparcos Number", "HIP 79337"},
        {"Geneva Identification System", "GEN# +1.00145589J"},
        {"Smithsonian Astrophysical Observation", "SAO 121414"},
        {"Wilson Evans Batten Catalogue", "WEB 13408"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.87394525),
        dec: Angle.Degrees(+09.71205342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135775"},
        {"Henry Draper 2", "HD 135774"},
        {"Hipparcos Number", "HIP 74749"},
        {"Geneva Identification System", "GEN# +1.00135774"},
        {"Renson", "Renson 38600"},
        {"Smithsonian Astrophysical Observation", "SAO 120927"},
        {"Wilson Evans Batten Catalogue", "WEB 12752"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.342,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.14911128),
        dec: Angle.Degrees(+09.71300660)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120365"},
        {"Hipparcos Number", "HIP 67404"},
        {"Smithsonian Astrophysical Observation", "SAO 120122"},
    },
    visualMagnitude: 7.33,
    bvColour: 1.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.21347672),
        dec: Angle.Degrees(+09.71335165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14903"},
        {"Hipparcos Number", "HIP 11228"},
        {"Smithsonian Astrophysical Observation", "SAO 110516"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.12703710),
        dec: Angle.Degrees(+09.71336520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126"},
        {"Hipparcos Number", "HIP 510"},
        {"Geneva Identification System", "GEN# +1.00000126"},
        {"Smithsonian Astrophysical Observation", "SAO 109006"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.53342667),
        dec: Angle.Degrees(+09.71496461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159798"},
        {"Hipparcos Number", "HIP 86143"},
        {"Smithsonian Astrophysical Observation", "SAO 122556"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.05806007),
        dec: Angle.Degrees(+09.71572772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -100.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46774",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7416 A"},
        {"Henry Draper", "HD 82381"},
        {"Hipparcos Number", "HIP 46774"},
        {"Geneva Identification System", "GEN# +1.00082381A"},
        {"Smithsonian Astrophysical Observation", "SAO 117751"},
        {"Wilson Evans Batten Catalogue", "WEB 8821"},
    },
    visualMagnitude: 5.07,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.98992745),
        dec: Angle.Degrees(+09.71579820)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61035",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8575 AB"},
        {"Henry Draper", "HD 108875"},
        {"Hipparcos Number", "HIP 61035"},
        {"Geneva Identification System", "GEN# +1.00108875"},
        {"Smithsonian Astrophysical Observation", "SAO 119436"},
        {"Wilson Evans Batten Catalogue", "WEB 10866"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.64063750),
        dec: Angle.Degrees(+09.71588127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38077",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38077"},
        {"Smithsonian Astrophysical Observation", "SAO 115950"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.04827554),
        dec: Angle.Degrees(+09.71720268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50543"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.85880155),
        dec: Angle.Degrees(+09.72073561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199194"},
        {"Hipparcos Number", "HIP 103271"},
        {"Geneva Identification System", "GEN# +1.00199194"},
        {"Smithsonian Astrophysical Observation", "SAO 126368"},
    },
    visualMagnitude: 7.45,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.82328163),
        dec: Angle.Degrees(+09.72105920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158370"},
        {"Hipparcos Number", "HIP 85515"},
        {"Smithsonian Astrophysical Observation", "SAO 122416"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.14155378),
        dec: Angle.Degrees(+09.72214360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126032"},
        {"Hipparcos Number", "HIP 70293"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.72360517),
        dec: Angle.Degrees(+09.72220434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72634",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9410 A"},
        {"Henry Draper", "HD 131023"},
        {"Hipparcos Number", "HIP 72634"},
        {"Geneva Identification System", "GEN# +1.00131023"},
        {"Smithsonian Astrophysical Observation", "SAO 120697"},
        {"Wilson Evans Batten Catalogue", "WEB 12487"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76017641),
        dec: Angle.Degrees(+09.72353210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -216.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 57.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34855"},
        {"Hipparcos Number", "HIP 24971"},
        {"Smithsonian Astrophysical Observation", "SAO 112654"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.22177051),
        dec: Angle.Degrees(+09.72456663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66243",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66243"},
        {"Smithsonian Astrophysical Observation", "SAO 120014"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.774,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.65642745),
        dec: Angle.Degrees(+09.72474426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -218.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28025"},
        {"Hipparcos Number", "HIP 20672"},
        {"Smithsonian Astrophysical Observation", "SAO 111808"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.42380084),
        dec: Angle.Degrees(+09.72507051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108863",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108863"},
    },
    visualMagnitude: 10.31,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.80629156),
        dec: Angle.Degrees(+09.72746584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286671"},
        {"Hipparcos Number", "HIP 20062"},
        {"Smithsonian Astrophysical Observation", "SAO 111725"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.53239635),
        dec: Angle.Degrees(+09.72835566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111149",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111149"},
    },
    visualMagnitude: 12.04,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.77590672),
        dec: Angle.Degrees(+09.73002603)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6815"},
        {"Hipparcos Number", "HIP 5387"},
        {"Geneva Identification System", "GEN# +1.00006815"},
        {"Smithsonian Astrophysical Observation", "SAO 109700"},
    },
    visualMagnitude: 7.31,
    bvColour: -0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.23269935),
        dec: Angle.Degrees(+09.73055089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80848",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80848"},
        {"Fundamental Katalog 5th Edition", "FK5 5461"},
        {"Smithsonian Astrophysical Observation", "SAO 121656"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.65858455),
        dec: Angle.Degrees(+09.73153527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21364"},
        {"Hipparcos Number", "HIP 16083"},
        {"Fundamental Katalog 5th Edition", "FK5 123"},
        {"Geneva Identification System", "GEN# +1.00021364"},
        {"Smithsonian Astrophysical Observation", "SAO 111195"},
        {"Wilson Evans Batten Catalogue", "WEB 3069"},
    },
    visualMagnitude: 3.73,
    bvColour: -0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.79217049),
        dec: Angle.Degrees(+09.73277240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57040",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57040"},
    },
    visualMagnitude: 10.76,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.41838133),
        dec: Angle.Degrees(+09.73328181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154610"},
        {"Hipparcos Number", "HIP 83677"},
        {"Geneva Identification System", "GEN# +1.00154610"},
        {"Smithsonian Astrophysical Observation", "SAO 122075"},
        {"Wilson Evans Batten Catalogue", "WEB 14150"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.54017278),
        dec: Angle.Degrees(+09.73385520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70527",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70527"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.41063428),
        dec: Angle.Degrees(+09.73529760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14554"},
        {"Hipparcos Number", "HIP 10972"},
        {"Smithsonian Astrophysical Observation", "SAO 110491"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.33698352),
        dec: Angle.Degrees(+09.73568382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169576"},
        {"Hipparcos Number", "HIP 90255"},
        {"Smithsonian Astrophysical Observation", "SAO 123448"},
        {"Wilson Evans Batten Catalogue", "WEB 15440"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.24162758),
        dec: Angle.Degrees(+09.73585970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157258"},
        {"Hipparcos Number", "HIP 84955"},
        {"Smithsonian Astrophysical Observation", "SAO 122312"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.46051820),
        dec: Angle.Degrees(+09.73595023)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118095",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 118095"},
        {"Geneva Identification System", "GEN# +6.20156386"},
    },
    visualMagnitude: 11.71,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.33384807),
        dec: Angle.Degrees(+09.73909876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53238",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53238"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.35006854),
        dec: Angle.Degrees(+09.73959315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -341.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96799"},
        {"Geneva Identification System", "GEN# +0.00904204"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.15903472),
        dec: Angle.Degrees(+09.74083148)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7463"},
        {"Hipparcos Number", "HIP 5837"},
        {"Geneva Identification System", "GEN# +1.00007463"},
        {"Smithsonian Astrophysical Observation", "SAO 109756"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.71327632),
        dec: Angle.Degrees(+09.74112841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3578"},
        {"Hipparcos Number", "HIP 3057"},
        {"Smithsonian Astrophysical Observation", "SAO 109341"},
    },
    visualMagnitude: 9.71,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.70497359),
        dec: Angle.Degrees(+09.74351718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6030"},
        {"Hipparcos Number", "HIP 4806"},
        {"Geneva Identification System", "GEN# +1.00006030"},
        {"Smithsonian Astrophysical Observation", "SAO 109610"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.954,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.42866739),
        dec: Angle.Degrees(+09.74593446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 36.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128311"},
        {"Hipparcos Number", "HIP 71395"},
        {"Cincinnati Publication", "Ci 18 1921"},
        {"Geneva Identification System", "GEN# +1.00128311"},
        {"Smithsonian Astrophysical Observation", "SAO 120554"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.00182978),
        dec: Angle.Degrees(+09.74712521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 205.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220795"},
        {"Hipparcos Number", "HIP 115719"},
        {"Geneva Identification System", "GEN# +1.00220795"},
        {"Smithsonian Astrophysical Observation", "SAO 128183"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.66518061),
        dec: Angle.Degrees(+09.74982780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98377"},
        {"Hipparcos Number", "HIP 55263"},
        {"Smithsonian Astrophysical Observation", "SAO 99553"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.77880205),
        dec: Angle.Degrees(+09.75106128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158252"},
        {"Hipparcos Number", "HIP 85465"},
        {"Smithsonian Astrophysical Observation", "SAO 122409"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.97166263),
        dec: Angle.Degrees(+09.75142858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108176"},
        {"Hipparcos Number", "HIP 60628"},
        {"Geneva Identification System", "GEN# +1.00108176"},
        {"Smithsonian Astrophysical Observation", "SAO 100092"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.38001784),
        dec: Angle.Degrees(+09.75182228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62452",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62452"},
        {"Cincinnati Publication", "Ci 20 737"},
        {"Geneva Identification System", "GEN# +9.80060032"},
        {"Wilson Evans Batten Catalogue", "WEB 11090"},
    },
    visualMagnitude: 11.39,
    bvColour: 1.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.98842235),
        dec: Angle.Degrees(+09.75251785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1007.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -461.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7041",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7041"},
    },
    visualMagnitude: 11.12,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.69320444),
        dec: Angle.Degrees(+09.75576256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 197.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75457"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.23018721),
        dec: Angle.Degrees(+09.75671258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112664"},
        {"Hipparcos Number", "HIP 63295"},
        {"Smithsonian Astrophysical Observation", "SAO 100352"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.57550567),
        dec: Angle.Degrees(+09.75671520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43211"},
        {"Hipparcos Number", "HIP 29700"},
        {"Smithsonian Astrophysical Observation", "SAO 113643"},
    },
    visualMagnitude: 8.64,
    bvColour: -0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.85036921),
        dec: Angle.Degrees(+09.75915268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45409"},
        {"Smithsonian Astrophysical Observation", "SAO 117536"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.951,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.80524888),
        dec: Angle.Degrees(+09.75947891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221348"},
        {"Hipparcos Number", "HIP 116086"},
        {"Smithsonian Astrophysical Observation", "SAO 128225"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.83700344),
        dec: Angle.Degrees(+09.76169155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44235"},
        {"Hipparcos Number", "HIP 30187"},
        {"Celescope Catalog", "CEL 1189"},
        {"Geneva Identification System", "GEN# +1.00044235"},
        {"Smithsonian Astrophysical Observation", "SAO 113746"},
    },
    visualMagnitude: 7.97,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.26637774),
        dec: Angle.Degrees(+09.76192544)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51213",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7781 A"},
        {"Henry Draper", "HD 90569"},
        {"Hipparcos Number", "HIP 51213"},
        {"Geneva Identification System", "GEN# +1.00090569A"},
        {"Renson", "Renson 26010"},
        {"Smithsonian Astrophysical Observation", "SAO 99136"},
        {"Wilson Evans Batten Catalogue", "WEB 9361"},
    },
    visualMagnitude: 6.01,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.91244127),
        dec: Angle.Degrees(+09.76241140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69950",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125392"},
        {"Hipparcos Number", "HIP 69950"},
        {"Smithsonian Astrophysical Observation", "SAO 120393"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.71568420),
        dec: Angle.Degrees(+09.76257847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10016"},
        {"Hipparcos Number", "HIP 7604"},
        {"Geneva Identification System", "GEN# +1.00010016"},
        {"Smithsonian Astrophysical Observation", "SAO 110020"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.48752027),
        dec: Angle.Degrees(+09.76358447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78636"},
        {"Hipparcos Number", "HIP 44978"},
        {"Smithsonian Astrophysical Observation", "SAO 117460"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.43419372),
        dec: Angle.Degrees(+09.76389166)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14041"},
        {"Hipparcos Number", "HIP 10614"},
        {"Smithsonian Astrophysical Observation", "SAO 110444"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.16310669),
        dec: Angle.Degrees(+09.76525958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63675"},
        {"Hipparcos Number", "HIP 38273"},
        {"Geneva Identification System", "GEN# +1.00063675"},
        {"Smithsonian Astrophysical Observation", "SAO 116004"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.62052337),
        dec: Angle.Degrees(+09.76556632)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32376",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48784"},
        {"Hipparcos Number", "HIP 32376"},
        {"Geneva Identification System", "GEN# +1.00048784"},
        {"Smithsonian Astrophysical Observation", "SAO 114366"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.36046517),
        dec: Angle.Degrees(+09.76581272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67109"},
        {"Hipparcos Number", "HIP 39697"},
        {"Smithsonian Astrophysical Observation", "SAO 116353"},
    },
    visualMagnitude: 7.99,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.70119261),
        dec: Angle.Degrees(+09.76733659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97964",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188384"},
        {"Hipparcos Number", "HIP 97964"},
        {"Smithsonian Astrophysical Observation", "SAO 125220"},
        {"Wilson Evans Batten Catalogue", "WEB 17241"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.64693644),
        dec: Angle.Degrees(+09.76739372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64158",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64158"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.24612417),
        dec: Angle.Degrees(+09.76767503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -142.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -249.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112073",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112073"},
    },
    visualMagnitude: 11.99,
    bvColour: 1.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.50680596),
        dec: Angle.Degrees(+09.76917562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12853",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12853"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.31417352),
        dec: Angle.Degrees(+09.76999278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12529"},
        {"Geneva Identification System", "GEN# +0.00900352"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.30607867),
        dec: Angle.Degrees(+09.77006508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 305.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177786"},
        {"Hipparcos Number", "HIP 93766"},
        {"Smithsonian Astrophysical Observation", "SAO 124258"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.43659356),
        dec: Angle.Degrees(+09.77044818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2640",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3015"},
        {"Hipparcos Number", "HIP 2640"},
        {"Smithsonian Astrophysical Observation", "SAO 109274"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.37002415),
        dec: Angle.Degrees(+09.77124777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27718"},
        {"Hipparcos Number", "HIP 20447"},
        {"Smithsonian Astrophysical Observation", "SAO 111778"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.457,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.71229348),
        dec: Angle.Degrees(+09.77146210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13543",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2210 A"},
        {"Henry Draper", "HD 18058"},
        {"Hipparcos Number", "HIP 13543"},
        {"Geneva Identification System", "GEN# +1.00018058A"},
        {"Smithsonian Astrophysical Observation", "SAO 110824"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.60457120),
        dec: Angle.Degrees(+09.77282830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167161"},
        {"Hipparcos Number", "HIP 89329"},
        {"Smithsonian Astrophysical Observation", "SAO 123268"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.40292322),
        dec: Angle.Degrees(+09.77349870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114991"},
        {"Hipparcos Number", "HIP 64566"},
        {"Fundamental Katalog 5th Edition", "FK5 5167"},
        {"Geneva Identification System", "GEN# +1.00114991"},
        {"Smithsonian Astrophysical Observation", "SAO 100471"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.51501927),
        dec: Angle.Degrees(+09.77391423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107031",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107031"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.14346336),
        dec: Angle.Degrees(+09.77394837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134871"},
        {"Hipparcos Number", "HIP 74373"},
        {"Smithsonian Astrophysical Observation", "SAO 120886"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.97572733),
        dec: Angle.Degrees(+09.77700064)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102841"},
        {"Hipparcos Number", "HIP 57743"},
        {"Geneva Identification System", "GEN# +1.00102841"},
        {"Smithsonian Astrophysical Observation", "SAO 99822"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.62071774),
        dec: Angle.Degrees(+09.77703231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13544",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2210 BC"},
        {"Hipparcos Number", "HIP 13544"},
        {"Geneva Identification System", "GEN# +1.00018058J"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.60666204),
        dec: Angle.Degrees(+09.77736897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218793"},
        {"Hipparcos Number", "HIP 114444"},
        {"Smithsonian Astrophysical Observation", "SAO 128014"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.66493950),
        dec: Angle.Degrees(+09.77933039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69301"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.76816875),
        dec: Angle.Degrees(+09.78144462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -230.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18618",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2911 AB"},
        {"Henry Draper", "HD 25034"},
        {"Hipparcos Number", "HIP 18618"},
        {"Smithsonian Astrophysical Observation", "SAO 111540"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.613,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.75109097),
        dec: Angle.Degrees(+09.78179816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161922"},
        {"Hipparcos Number", "HIP 87120"},
        {"Smithsonian Astrophysical Observation", "SAO 122761"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.00055752),
        dec: Angle.Degrees(+09.78208723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205619"},
        {"Hipparcos Number", "HIP 106666"},
        {"Smithsonian Astrophysical Observation", "SAO 126920"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.07092363),
        dec: Angle.Degrees(+09.78464790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5898",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1016 AB"},
        {"Henry Draper", "HD 7564"},
        {"Hipparcos Number", "HIP 5898"},
        {"Smithsonian Astrophysical Observation", "SAO 109766"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.94491363),
        dec: Angle.Degrees(+09.78479221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163054"},
        {"Hipparcos Number", "HIP 87615"},
        {"Smithsonian Astrophysical Observation", "SAO 122899"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.47651906),
        dec: Angle.Degrees(+09.78535237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14068"},
        {"Hipparcos Number", "HIP 10634"},
        {"Smithsonian Astrophysical Observation", "SAO 110447"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.21911574),
        dec: Angle.Degrees(+09.78547862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223061"},
        {"Hipparcos Number", "HIP 117236"},
        {"Geneva Identification System", "GEN# +1.00223061"},
        {"Smithsonian Astrophysical Observation", "SAO 128372"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.57658309),
        dec: Angle.Degrees(+09.78551648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -183.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77283",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141070"},
        {"Hipparcos Number", "HIP 77283"},
        {"Geneva Identification System", "GEN# +1.00141070"},
        {"Smithsonian Astrophysical Observation", "SAO 121188"},
        {"Wilson Evans Batten Catalogue", "WEB 13094"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.68094925),
        dec: Angle.Degrees(+09.78626105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138558"},
        {"Hipparcos Number", "HIP 76102"},
        {"Smithsonian Astrophysical Observation", "SAO 121054"},
    },
    visualMagnitude: 8.28,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.14146808),
        dec: Angle.Degrees(+09.78715978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80339"},
        {"Hipparcos Number", "HIP 45740"},
        {"Fundamental Katalog 5th Edition", "FK5 4828"},
        {"Smithsonian Astrophysical Observation", "SAO 98495"},
    },
    visualMagnitude: 7.17,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.87732274),
        dec: Angle.Degrees(+09.79013733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258853"},
        {"Hipparcos Number", "HIP 31073"},
        {"Geneva Identification System", "GEN# +1.00258853"},
        {"Smithsonian Astrophysical Observation", "SAO 113986"},
        {"Wilson Evans Batten Catalogue", "WEB 6187"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.81194728),
        dec: Angle.Degrees(+09.79029104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50812",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50812"},
        {"Smithsonian Astrophysical Observation", "SAO 99087"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.60807113),
        dec: Angle.Degrees(+09.79314597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145679"},
        {"Hipparcos Number", "HIP 79370"},
        {"Smithsonian Astrophysical Observation", "SAO 121419"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.98667425),
        dec: Angle.Degrees(+09.79328305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 240",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 240"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.74376859),
        dec: Angle.Degrees(+09.79522025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83178",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153562"},
        {"Hipparcos Number", "HIP 83178"},
        {"Geneva Identification System", "GEN# +1.00153562"},
        {"Smithsonian Astrophysical Observation", "SAO 121987"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.00261819),
        dec: Angle.Degrees(+09.79800703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163343"},
        {"Hipparcos Number", "HIP 87741"},
        {"Smithsonian Astrophysical Observation", "SAO 122920"},
    },
    visualMagnitude: 8.27,
    bvColour: -0.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.84611963),
        dec: Angle.Degrees(+09.80100668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65625",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65625"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.82398849),
        dec: Angle.Degrees(+09.80332993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 725 AB"},
        {"Henry Draper", "HD 5086"},
        {"Hipparcos Number", "HIP 4120"},
        {"Smithsonian Astrophysical Observation", "SAO 109518"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.19559715),
        dec: Angle.Degrees(+09.80358075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195765"},
        {"Hipparcos Number", "HIP 101392"},
        {"Smithsonian Astrophysical Observation", "SAO 125934"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.22522038),
        dec: Angle.Degrees(+09.80423472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217210"},
        {"Hipparcos Number", "HIP 113484"},
        {"Smithsonian Astrophysical Observation", "SAO 127876"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.73578835),
        dec: Angle.Degrees(+09.80479153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180126"},
        {"Hipparcos Number", "HIP 94596"},
        {"Geneva Identification System", "GEN# +1.00180126"},
        {"Smithsonian Astrophysical Observation", "SAO 124437"},
        {"Wilson Evans Batten Catalogue", "WEB 16483"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.75595744),
        dec: Angle.Degrees(+09.80763967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21111"},
        {"Hipparcos Number", "HIP 15897"},
        {"Geneva Identification System", "GEN# +1.00021111"},
        {"Smithsonian Astrophysical Observation", "SAO 111171"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.19266954),
        dec: Angle.Degrees(+09.80793025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212517"},
        {"Hipparcos Number", "HIP 110636"},
        {"Smithsonian Astrophysical Observation", "SAO 127511"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.18091778),
        dec: Angle.Degrees(+09.81012467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78388"},
        {"Smithsonian Astrophysical Observation", "SAO 121309"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.931,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.04960321),
        dec: Angle.Degrees(+09.81302379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109859"},
        {"Hipparcos Number", "HIP 61636"},
        {"Smithsonian Astrophysical Observation", "SAO 100185"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.51617806),
        dec: Angle.Degrees(+09.81359031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72208"},
        {"Hipparcos Number", "HIP 41843"},
        {"Geneva Identification System", "GEN# +1.00072208"},
        {"Renson", "Renson 19950"},
        {"Smithsonian Astrophysical Observation", "SAO 116863"},
        {"Wilson Evans Batten Catalogue", "WEB 8057"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.037,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.97708017),
        dec: Angle.Degrees(+09.81413441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48381",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48381"},
        {"Smithsonian Astrophysical Observation", "SAO 98815"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.94344216),
        dec: Angle.Degrees(+09.81515464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100042"},
        {"Hipparcos Number", "HIP 56173"},
        {"Smithsonian Astrophysical Observation", "SAO 99639"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.72277618),
        dec: Angle.Degrees(+09.81604698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14716",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14716"},
        {"Smithsonian Astrophysical Observation", "SAO 111020"},
    },
    visualMagnitude: 10.95,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.52732301),
        dec: Angle.Degrees(+09.81635548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31939",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47732"},
        {"Hipparcos Number", "HIP 31939"},
        {"Geneva Identification System", "GEN# +2.22640050"},
        {"Smithsonian Astrophysical Observation", "SAO 114241"},
        {"Wilson Evans Batten Catalogue", "WEB 6421"},
        {"New General Catalogue", "NGC 2264 50"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.11911249),
        dec: Angle.Degrees(+09.81786274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173634"},
        {"Hipparcos Number", "HIP 92078"},
        {"Geneva Identification System", "GEN# +1.00173634"},
        {"Smithsonian Astrophysical Observation", "SAO 123901"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.50467660),
        dec: Angle.Degrees(+09.81836938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201348"},
        {"Hipparcos Number", "HIP 104377"},
        {"Smithsonian Astrophysical Observation", "SAO 126570"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.17728972),
        dec: Angle.Degrees(+09.81940556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154015"},
        {"Hipparcos Number", "HIP 83388"},
        {"Smithsonian Astrophysical Observation", "SAO 122030"},
        {"Wilson Evans Batten Catalogue", "WEB 14093"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.63817616),
        dec: Angle.Degrees(+09.82028080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68099"},
        {"Hipparcos Number", "HIP 40085"},
        {"Geneva Identification System", "GEN# +1.00068099"},
        {"Renson", "Renson 18820"},
        {"Smithsonian Astrophysical Observation", "SAO 116444"},
        {"Wilson Evans Batten Catalogue", "WEB 7821"},
    },
    visualMagnitude: 6.08,
    bvColour: -0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.81918033),
        dec: Angle.Degrees(+09.82126887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25953"},
        {"Geneva Identification System", "GEN# +6.10010206"},
        {"Geneva Identification System 2", "GEN# +9.80097047"},
        {"Wilson Evans Batten Catalogue", "WEB 5050"},
    },
    visualMagnitude: 11.55,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.06151141),
        dec: Angle.Degrees(+09.82134080)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -219.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102328"},
        {"Smithsonian Astrophysical Observation", "SAO 126150"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.98473399),
        dec: Angle.Degrees(+09.82186223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218700"},
        {"Hipparcos Number", "HIP 114389"},
        {"Geneva Identification System", "GEN# +1.00218700"},
        {"Smithsonian Astrophysical Observation", "SAO 128007"},
        {"Wilson Evans Batten Catalogue", "WEB 20307"},
    },
    visualMagnitude: 5.39,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.50612955),
        dec: Angle.Degrees(+09.82210111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73083",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131933"},
        {"Hipparcos Number", "HIP 73083"},
        {"Smithsonian Astrophysical Observation", "SAO 101290"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.05218394),
        dec: Angle.Degrees(+09.82311112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93830"},
        {"Hipparcos Number", "HIP 52966"},
        {"Smithsonian Astrophysical Observation", "SAO 99312"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.492,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.49072476),
        dec: Angle.Degrees(+09.82389043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73857"},
        {"Hipparcos Number", "HIP 42594"},
        {"Geneva Identification System", "GEN# +1.00073857"},
        {"Smithsonian Astrophysical Observation", "SAO 98035"},
        {"Wilson Evans Batten Catalogue", "WEB 8224"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.21725771),
        dec: Angle.Degrees(+09.82424671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217165"},
        {"Hipparcos Number", "HIP 113438"},
        {"Fundamental Katalog 5th Edition", "FK5 6034"},
        {"Geneva Identification System", "GEN# +1.00217165"},
        {"Smithsonian Astrophysical Observation", "SAO 127869"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.62417869),
        dec: Angle.Degrees(+09.82552486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 129.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74008"},
        {"Smithsonian Astrophysical Observation", "SAO 101378"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.86500351),
        dec: Angle.Degrees(+09.82845624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3500"},
        {"Hipparcos Number", "HIP 2999"},
        {"Smithsonian Astrophysical Observation", "SAO 109329"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.52967278),
        dec: Angle.Degrees(+09.82910145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61413",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 61413"},
        {"Cincinnati Publication", "Ci 20 719"},
        {"Geneva Identification System", "GEN# +9.80012044"},
        {"Geneva Identification System 2", "GEN# +6.10010476"},
    },
    visualMagnitude: 11.40,
    bvColour: 1.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.75404727),
        dec: Angle.Degrees(+09.82926595)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -449.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -319.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111606"},
        {"Hipparcos Number", "HIP 62663"},
        {"Smithsonian Astrophysical Observation", "SAO 100295"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.59808163),
        dec: Angle.Degrees(+09.82945226)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33254"},
        {"Hipparcos Number", "HIP 23983"},
        {"Celescope Catalog", "CEL 547"},
        {"Fundamental Katalog 5th Edition", "FK5 1142"},
        {"Geneva Identification System", "GEN# +5.20250130"},
        {"Renson", "Renson 8490"},
        {"Smithsonian Astrophysical Observation", "SAO 112467"},
        {"Wilson Evans Batten Catalogue", "WEB 4674"},
    },
    visualMagnitude: 5.43,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.33168451),
        dec: Angle.Degrees(+09.82959768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46568",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46568"},
        {"Smithsonian Astrophysical Observation", "SAO 98604"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.45617891),
        dec: Angle.Degrees(+09.82974434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112935",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "sig Peg A"},
        {"Henry Draper", "HD 216385"},
        {"Hipparcos Number", "HIP 112935"},
        {"Cincinnati Publication", "Ci 20 1386"},
        {"Fundamental Katalog 5th Edition", "FK5 3828"},
        {"Geneva Identification System", "GEN# +1.00216385A"},
        {"Smithsonian Astrophysical Observation", "SAO 127810"},
        {"Wilson Evans Batten Catalogue", "WEB 20111"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.09902715),
        dec: Angle.Degrees(+09.83555733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 521.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 44.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109854"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.412,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.74351808),
        dec: Angle.Degrees(+09.83897903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 267238"},
        {"Hipparcos Number", "HIP 33552"},
        {"Smithsonian Astrophysical Observation", "SAO 114700"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.59517098),
        dec: Angle.Degrees(+09.84218904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3799",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 3799"},
        {"Smithsonian Astrophysical Observation", "SAO 109476"},
    },
    visualMagnitude: 9.52,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.20039458),
        dec: Angle.Degrees(+09.84344576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170934"},
        {"Hipparcos Number", "HIP 90820"},
        {"Smithsonian Astrophysical Observation", "SAO 123605"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.91022461),
        dec: Angle.Degrees(+09.84574598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57705"},
        {"Hipparcos Number", "HIP 35777"},
        {"Smithsonian Astrophysical Observation", "SAO 115355"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.70211316),
        dec: Angle.Degrees(+09.84576062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58179",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58179"},
        {"Geneva Identification System", "GEN# +0.01002357"},
        {"Smithsonian Astrophysical Observation", "SAO 99873"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.98605949),
        dec: Angle.Degrees(+09.84696944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124350"},
        {"Hipparcos Number", "HIP 69424"},
        {"Smithsonian Astrophysical Observation", "SAO 100914"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.22024069),
        dec: Angle.Degrees(+09.84824869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162319"},
        {"Hipparcos Number", "HIP 87289"},
        {"Fundamental Katalog 5th Edition", "FK5 1466"},
        {"Geneva Identification System", "GEN# +1.00162319"},
        {"Smithsonian Astrophysical Observation", "SAO 122806"},
    },
    visualMagnitude: 6.74,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.53859378),
        dec: Angle.Degrees(+09.84837244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37522"},
        {"Hipparcos Number", "HIP 26627"},
        {"Smithsonian Astrophysical Observation", "SAO 113005"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.89394092),
        dec: Angle.Degrees(+09.84850881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165864"},
        {"Hipparcos Number", "HIP 88812"},
        {"Smithsonian Astrophysical Observation", "SAO 123150"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.94824388),
        dec: Angle.Degrees(+09.84892067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10764",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14254"},
        {"Hipparcos Number", "HIP 10764"},
        {"Geneva Identification System", "GEN# +1.00014254"},
        {"Smithsonian Astrophysical Observation", "SAO 110460"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.899,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.63128479),
        dec: Angle.Degrees(+09.84903170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 96.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 449"},
        {"Hipparcos Number", "HIP 733"},
        {"Smithsonian Astrophysical Observation", "SAO 109036"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.714,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.26154948),
        dec: Angle.Degrees(+09.84996128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 124.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31488",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46783"},
        {"Hipparcos Number", "HIP 31488"},
        {"Geneva Identification System", "GEN# +1.00046783"},
        {"Smithsonian Astrophysical Observation", "SAO 114102"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.91926070),
        dec: Angle.Degrees(+09.85196896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32030",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5334 C"},
        {"Henry Draper", "HD 47961"},
        {"Hipparcos Number", "HIP 32030"},
        {"Geneva Identification System", "GEN# +2.22640212"},
        {"Smithsonian Astrophysical Observation", "SAO 114274"},
        {"Wilson Evans Batten Catalogue", "WEB 6462"},
        {"New General Catalogue", "NGC 2264 212"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.143,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.36377251),
        dec: Angle.Degrees(+09.85400894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75009",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75009"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.90871737),
        dec: Angle.Degrees(+09.85520227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106402",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106402"},
        {"Smithsonian Astrophysical Observation", "SAO 126881"},
    },
    visualMagnitude: 9.04,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.26030732),
        dec: Angle.Degrees(+09.85789397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111764",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 111764"},
        {"Geneva Identification System", "GEN# +0.00905074"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.850,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.59431619),
        dec: Angle.Degrees(+09.85906343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -181.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175988"},
        {"Hipparcos Number", "HIP 93079"},
        {"Smithsonian Astrophysical Observation", "SAO 124099"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.137,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.40907058),
        dec: Angle.Degrees(+09.86181749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99771",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192447"},
        {"Hipparcos Number", "HIP 99771"},
        {"Smithsonian Astrophysical Observation", "SAO 125606"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.64131999),
        dec: Angle.Degrees(+09.86246019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172290"},
        {"Hipparcos Number", "HIP 91447"},
        {"Smithsonian Astrophysical Observation", "SAO 123766"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.75979725),
        dec: Angle.Degrees(+09.86354131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30990"},
        {"Hipparcos Number", "HIP 22665"},
        {"Smithsonian Astrophysical Observation", "SAO 112166"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.298,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.12433842),
        dec: Angle.Degrees(+09.86412239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198060"},
        {"Hipparcos Number", "HIP 102595"},
        {"Geneva Identification System", "GEN# +1.00198060"},
        {"Smithsonian Astrophysical Observation", "SAO 126217"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.87476281),
        dec: Angle.Degrees(+09.86428715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117461"},
    },
    visualMagnitude: 12.14,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.24470947),
        dec: Angle.Degrees(+09.86518327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 156.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97407"},
        {"Hipparcos Number", "HIP 54760"},
        {"Smithsonian Astrophysical Observation", "SAO 99500"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.17925394),
        dec: Angle.Degrees(+09.86571673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83006"},
        {"Hipparcos Number", "HIP 47091"},
        {"Smithsonian Astrophysical Observation", "SAO 98661"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.95185762),
        dec: Angle.Degrees(+09.86817026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106988"},
        {"Hipparcos Number", "HIP 59992"},
        {"Geneva Identification System", "GEN# +1.00106988"},
        {"Smithsonian Astrophysical Observation", "SAO 100029"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.55501076),
        dec: Angle.Degrees(+09.86846706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45197"},
        {"Smithsonian Astrophysical Observation", "SAO 98431"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.15617353),
        dec: Angle.Degrees(+09.86993053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39007"},
        {"Hipparcos Number", "HIP 27549"},
        {"Geneva Identification System", "GEN# +1.00039007"},
        {"Smithsonian Astrophysical Observation", "SAO 113179"},
        {"Wilson Evans Batten Catalogue", "WEB 5409"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.51115293),
        dec: Angle.Degrees(+09.87122224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41500"},
        {"Hipparcos Number", "HIP 28893"},
        {"Celescope Catalog", "CEL 1075"},
        {"Smithsonian Astrophysical Observation", "SAO 113444"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.50125154),
        dec: Angle.Degrees(+09.87191309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79923"},
    },
    visualMagnitude: 10.59,
    bvColour: 1.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.70123191),
        dec: Angle.Degrees(+09.87243759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22616",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30913"},
        {"Hipparcos Number", "HIP 22616"},
        {"Celescope Catalog", "CEL 477"},
        {"Geneva Identification System", "GEN# +1.00030913"},
        {"Smithsonian Astrophysical Observation", "SAO 112155"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.98821053),
        dec: Angle.Degrees(+09.87277439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286955"},
        {"Hipparcos Number", "HIP 21710"},
        {"Cincinnati Publication", "Ci 18 601"},
        {"Smithsonian Astrophysical Observation", "SAO 111962"},
        {"Wilson Evans Batten Catalogue", "WEB 4173"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.92757018),
        dec: Angle.Degrees(+09.87298087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -373.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44735",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44735"},
        {"Smithsonian Astrophysical Observation", "SAO 98370"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.73227374),
        dec: Angle.Degrees(+09.87318184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98241",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98241"},
        {"Smithsonian Astrophysical Observation", "SAO 125283"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.46462950),
        dec: Angle.Degrees(+09.87323744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 124.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107315",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Enif"},
        {"Aitken", "ADS 15268 A"},
        {"Henry Draper", "HD 206778"},
        {"Hipparcos Number", "HIP 107315"},
        {"Fundamental Katalog 5th Edition", "FK5 815"},
        {"Geneva Identification System", "GEN# +1.00206778A"},
        {"Smithsonian Astrophysical Observation", "SAO 127029"},
        {"Wilson Evans Batten Catalogue", "WEB 19379"},
    },
    visualMagnitude: 2.38,
    bvColour: 1.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.04641808),
        dec: Angle.Degrees(+09.87500791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169361"},
        {"Hipparcos Number", "HIP 90167"},
        {"Smithsonian Astrophysical Observation", "SAO 123430"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.99288867),
        dec: Angle.Degrees(+09.87768935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23989"},
        {"Hipparcos Number", "HIP 17908"},
        {"Smithsonian Astrophysical Observation", "SAO 111442"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.44656187),
        dec: Angle.Degrees(+09.87803759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152112"},
        {"Hipparcos Number", "HIP 82456"},
        {"Geneva Identification System", "GEN# +1.00152112"},
        {"Smithsonian Astrophysical Observation", "SAO 121905"},
        {"Wilson Evans Batten Catalogue", "WEB 13922"},
    },
    visualMagnitude: 7.14,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.76287223),
        dec: Angle.Degrees(+09.87891705)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34337",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53878"},
        {"Hipparcos Number", "HIP 34337"},
        {"Fundamental Katalog 5th Edition", "FK5 4643"},
        {"Geneva Identification System", "GEN# +1.00053878"},
        {"Smithsonian Astrophysical Observation", "SAO 114934"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.77333252),
        dec: Angle.Degrees(+09.87935452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6818"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.92766374),
        dec: Angle.Degrees(+09.88088754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 131.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129047"},
        {"Hipparcos Number", "HIP 71714"},
        {"Smithsonian Astrophysical Observation", "SAO 101133"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.04114447),
        dec: Angle.Degrees(+09.88157891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 260986"},
        {"Hipparcos Number", "HIP 31714"},
        {"Geneva Identification System", "GEN# +1.00260986"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.50736080),
        dec: Angle.Degrees(+09.88359568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222684"},
        {"Hipparcos Number", "HIP 116978"},
        {"Smithsonian Astrophysical Observation", "SAO 128341"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.70446462),
        dec: Angle.Degrees(+09.88551667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61950",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8631 A"},
        {"Henry Draper", "HD 110412"},
        {"Hipparcos Number", "HIP 61950"},
        {"Geneva Identification System", "GEN# +1.00110412"},
        {"Smithsonian Astrophysical Observation", "SAO 100210"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.45175024),
        dec: Angle.Degrees(+09.88602015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128128"},
        {"Hipparcos Number", "HIP 71305"},
        {"Geneva Identification System", "GEN# +1.00128128"},
        {"Smithsonian Astrophysical Observation", "SAO 101087"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.73021857),
        dec: Angle.Degrees(+09.88647711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9599"},
    },
    visualMagnitude: 11.86,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.86752408),
        dec: Angle.Degrees(+09.88686394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46854",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46854"},
        {"Smithsonian Astrophysical Observation", "SAO 98633"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.194,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.21936310),
        dec: Angle.Degrees(+09.88748960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206014"},
        {"Hipparcos Number", "HIP 106895"},
        {"Smithsonian Astrophysical Observation", "SAO 126959"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.75382161),
        dec: Angle.Degrees(+09.88830195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119564"},
        {"Hipparcos Number", "HIP 66998"},
        {"Smithsonian Astrophysical Observation", "SAO 100679"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.96123224),
        dec: Angle.Degrees(+09.89055592)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55545",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55545"},
    },
    visualMagnitude: 9.72,
    bvColour: 1.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.66271897),
        dec: Angle.Degrees(+09.89078275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144874"},
        {"Hipparcos Number", "HIP 79007"},
        {"Fundamental Katalog 5th Edition", "FK5 3274"},
        {"Geneva Identification System", "GEN# +1.00144874"},
        {"Smithsonian Astrophysical Observation", "SAO 101939"},
        {"Wilson Evans Batten Catalogue", "WEB 13355"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90646234),
        dec: Angle.Degrees(+09.89176025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47508",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Subra"},
        {"Aitken", "ADS 7480 A"},
        {"Henry Draper", "HD 83808"},
        {"Henry Draper 2", "HD 83809"},
        {"Hipparcos Number", "HIP 47508"},
        {"Fundamental Katalog 5th Edition", "FK5 365"},
        {"Geneva Identification System", "GEN# +1.00083808"},
        {"Renson", "Renson 23896"},
        {"Smithsonian Astrophysical Observation", "SAO 98709"},
        {"Wilson Evans Batten Catalogue", "WEB 8912"},
    },
    visualMagnitude: 3.52,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.28799116),
        dec: Angle.Degrees(+09.89239902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -143.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107305"},
        {"Hipparcos Number", "HIP 60154"},
        {"Geneva Identification System", "GEN# +1.00107305"},
        {"Smithsonian Astrophysical Observation", "SAO 100050"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.03389404),
        dec: Angle.Degrees(+09.89243494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77572"},
        {"Hipparcos Number", "HIP 44475"},
        {"Geneva Identification System", "GEN# +1.00077572"},
        {"Smithsonian Astrophysical Observation", "SAO 98327"},
        {"Wilson Evans Batten Catalogue", "WEB 8523"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.92363514),
        dec: Angle.Degrees(+09.89279945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58035",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103356"},
        {"Hipparcos Number", "HIP 58035"},
        {"Smithsonian Astrophysical Observation", "SAO 99854"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.53324481),
        dec: Angle.Degrees(+09.89310638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 248018"},
        {"Hipparcos Number", "HIP 27474"},
        {"Geneva Identification System", "GEN# +1.00248018"},
        {"Smithsonian Astrophysical Observation", "SAO 113169"},
        {"Wilson Evans Batten Catalogue", "WEB 5397"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.27321766),
        dec: Angle.Degrees(+09.89330259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110120",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110120"},
        {"Smithsonian Astrophysical Observation", "SAO 127440"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.706,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.60513449),
        dec: Angle.Degrees(+09.89472599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 201.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53937",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8024 A"},
        {"Hipparcos Number", "HIP 53937"},
        {"Smithsonian Astrophysical Observation", "SAO 99413"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.54538098),
        dec: Angle.Degrees(+09.89526287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53934",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8024 B"},
        {"Hipparcos Number", "HIP 53934"},
        {"Geneva Identification System", "GEN# +0.01002234B"},
    },
    visualMagnitude: 10.61,
    bvColour: 0.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.54215115),
        dec: Angle.Degrees(+09.89528344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68868",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123233"},
        {"Hipparcos Number", "HIP 68868"},
        {"Geneva Identification System", "GEN# +1.00123233"},
        {"Smithsonian Astrophysical Observation", "SAO 100848"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.53999014),
        dec: Angle.Degrees(+09.89529205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31978",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5322"},
        {"Aitken 2", "ADS 5322 A"},
        {"Henry Draper", "HD 47839"},
        {"Hipparcos Number", "HIP 31978"},
        {"Geneva Identification System", "GEN# +1.00047839"},
        {"Geneva Identification System 2", "GEN# +2.22640131"},
        {"Smithsonian Astrophysical Observation", "SAO 114258"},
        {"Wilson Evans Batten Catalogue", "WEB 6438"},
        {"New General Catalogue", "NGC 2264 131"},
    },
    visualMagnitude: 4.66,
    bvColour: -0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.24442101),
        dec: Angle.Degrees(+09.89576021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195179"},
        {"Hipparcos Number", "HIP 101079"},
        {"Smithsonian Astrophysical Observation", "SAO 125861"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.35984538),
        dec: Angle.Degrees(+09.89786354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87178"},
        {"Hipparcos Number", "HIP 49279"},
        {"Geneva Identification System", "GEN# +1.00087178"},
        {"Smithsonian Astrophysical Observation", "SAO 98924"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.88847926),
        dec: Angle.Degrees(+09.89902366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39096",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65629"},
        {"Hipparcos Number", "HIP 39096"},
        {"Geneva Identification System", "GEN# +1.00065629"},
        {"Smithsonian Astrophysical Observation", "SAO 97452"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.97215575),
        dec: Angle.Degrees(+09.89906560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 123.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136885"},
        {"Hipparcos Number", "HIP 75279"},
        {"Smithsonian Astrophysical Observation", "SAO 101511"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.70859836),
        dec: Angle.Degrees(+09.89968823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6761"},
        {"Hipparcos Number", "HIP 5344"},
        {"Fundamental Katalog 5th Edition", "FK5 4104"},
        {"Smithsonian Astrophysical Observation", "SAO 109696"},
    },
    visualMagnitude: 6.71,
    bvColour: 1.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.09099608),
        dec: Angle.Degrees(+09.90820086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80202",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147573"},
        {"Hipparcos Number", "HIP 80202"},
        {"Smithsonian Astrophysical Observation", "SAO 102111"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.60009535),
        dec: Angle.Degrees(+09.90833241)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66092"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.21599608),
        dec: Angle.Degrees(+09.90859020)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48624",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48624"},
        {"Smithsonian Astrophysical Observation", "SAO 98843"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.73669248),
        dec: Angle.Degrees(+09.90920561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73707"},
    },
    visualMagnitude: 10.05,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.99150920),
        dec: Angle.Degrees(+09.91145650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103662"},
        {"Hipparcos Number", "HIP 58207"},
        {"Smithsonian Astrophysical Observation", "SAO 99875"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.437,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.06635699),
        dec: Angle.Degrees(+09.91194015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182101"},
        {"Hipparcos Number", "HIP 95253"},
        {"Fundamental Katalog 5th Edition", "FK5 3548"},
        {"Geneva Identification System", "GEN# +1.00182101"},
        {"Smithsonian Astrophysical Observation", "SAO 124564"},
        {"Wilson Evans Batten Catalogue", "WEB 16643"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.70144198),
        dec: Angle.Degrees(+09.91288991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 107.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5121"},
        {"Hipparcos Number", "HIP 4167"},
        {"Smithsonian Astrophysical Observation", "SAO 109520"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.30898571),
        dec: Angle.Degrees(+09.91441389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95591",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182902"},
        {"Hipparcos Number", "HIP 95591"},
        {"Smithsonian Astrophysical Observation", "SAO 124630"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.64313476),
        dec: Angle.Degrees(+09.91454932)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 246922"},
        {"Hipparcos Number", "HIP 27009"},
        {"Smithsonian Astrophysical Observation", "SAO 113082"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.93987365),
        dec: Angle.Degrees(+09.91458168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287171"},
        {"Hipparcos Number", "HIP 22548"},
        {"Smithsonian Astrophysical Observation", "SAO 112138"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.79946846),
        dec: Angle.Degrees(+09.91632312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177176"},
        {"Hipparcos Number", "HIP 93558"},
        {"Smithsonian Astrophysical Observation", "SAO 124200"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.83118669),
        dec: Angle.Degrees(+09.91741238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89432"},
        {"Hipparcos Number", "HIP 50547"},
        {"Smithsonian Astrophysical Observation", "SAO 99061"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.86682935),
        dec: Angle.Degrees(+09.92030368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2410",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2410"},
    },
    visualMagnitude: 12.07,
    bvColour: 1.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.67496153),
        dec: Angle.Degrees(+09.92045129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 245980"},
        {"Hipparcos Number", "HIP 26596"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.79747251),
        dec: Angle.Degrees(+09.92061505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24041"},
        {"Hipparcos Number", "HIP 17935"},
        {"Geneva Identification System", "GEN# +1.00024041"},
        {"Smithsonian Astrophysical Observation", "SAO 111445"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.53287199),
        dec: Angle.Degrees(+09.92457364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34338"},
        {"Hipparcos Number", "HIP 24632"},
        {"Smithsonian Astrophysical Observation", "SAO 112591"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.27208698),
        dec: Angle.Degrees(+09.92729305)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24656"},
        {"Hipparcos Number", "HIP 18368"},
        {"Smithsonian Astrophysical Observation", "SAO 111503"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.90719316),
        dec: Angle.Degrees(+09.92905707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80600",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80600"},
        {"Smithsonian Astrophysical Observation", "SAO 102182"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.85163857),
        dec: Angle.Degrees(+09.93067979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53727",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8003 A"},
        {"Henry Draper", "HD 95190"},
        {"Hipparcos Number", "HIP 53727"},
        {"Geneva Identification System", "GEN# +1.00095190"},
        {"Renson", "Renson 27400"},
        {"Smithsonian Astrophysical Observation", "SAO 99391"},
        {"Wilson Evans Batten Catalogue", "WEB 9734"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.88785536),
        dec: Angle.Degrees(+09.93081018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144782"},
        {"Hipparcos Number", "HIP 78976"},
        {"Wilson Evans Batten Catalogue", "WEB 13349"},
    },
    visualMagnitude: 10.13,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.82360971),
        dec: Angle.Degrees(+09.93122053)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203664"},
        {"Hipparcos Number", "HIP 105614"},
        {"Geneva Identification System", "GEN# +1.00203664"},
        {"Smithsonian Astrophysical Observation", "SAO 126757"},
        {"Wilson Evans Batten Catalogue", "WEB 19172"},
    },
    visualMagnitude: 8.57,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.87003618),
        dec: Angle.Degrees(+09.93194454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98437"},
        {"Hipparcos Number", "HIP 55306"},
        {"Smithsonian Astrophysical Observation", "SAO 99556"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.89698776),
        dec: Angle.Degrees(+09.93247196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22545"},
        {"Hipparcos Number", "HIP 16934"},
        {"Smithsonian Astrophysical Observation", "SAO 111303"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.815,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.47899074),
        dec: Angle.Degrees(+09.93288432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65133"},
        {"Geneva Identification System", "GEN# +0.01002540"},
        {"Wilson Evans Batten Catalogue", "WEB 11503"},
    },
    visualMagnitude: 9.90,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.20947978),
        dec: Angle.Degrees(+09.93321077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26207",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Heka"},
        {"Common Name 2", "Meissa"},
        {"Aitken", "ADS 4179 AB"},
        {"Henry Draper", "HD 36861J"},
        {"Hipparcos Number", "HIP 26207"},
        {"Geneva Identification System", "GEN# +1.00036861"},
        {"Smithsonian Astrophysical Observation", "SAO 112921"},
    },
    visualMagnitude: 3.39,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.78449043),
        dec: Angle.Degrees(+09.93416294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66839",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66839"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.47892369),
        dec: Angle.Degrees(+09.93444168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65524"},
        {"Hipparcos Number", "HIP 39058"},
        {"Geneva Identification System", "GEN# +1.00065524"},
        {"Smithsonian Astrophysical Observation", "SAO 97444"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.85620536),
        dec: Angle.Degrees(+09.93578583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144516"},
        {"Hipparcos Number", "HIP 78858"},
        {"Fundamental Katalog 5th Edition", "FK5 5421"},
        {"Smithsonian Astrophysical Observation", "SAO 101918"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.46779220),
        dec: Angle.Degrees(+09.93593040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1616"},
        {"Hipparcos Number", "HIP 1635"},
        {"Geneva Identification System", "GEN# +1.00001616"},
        {"Smithsonian Astrophysical Observation", "SAO 109150"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.12101869),
        dec: Angle.Degrees(+09.93763939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49194",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49194"},
        {"Smithsonian Astrophysical Observation", "SAO 98915"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.61244924),
        dec: Angle.Degrees(+09.93877684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31065",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5154 AB"},
        {"Henry Draper", "HD 46005"},
        {"Hipparcos Number", "HIP 31065"},
        {"Smithsonian Astrophysical Observation", "SAO 113984"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.78893111),
        dec: Angle.Degrees(+09.93982337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212224"},
        {"Hipparcos Number", "HIP 110464"},
        {"Smithsonian Astrophysical Observation", "SAO 127486"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.64127457),
        dec: Angle.Degrees(+09.94025181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108669"},
        {"Cincinnati Publication", "Ci 20 1329"},
        {"Geneva Identification System", "GEN# +0.00904955"},
        {"Wilson Evans Batten Catalogue", "WEB 19555"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.976,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.22431200),
        dec: Angle.Degrees(+09.94067439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -481.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29850",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4890 A"},
        {"Henry Draper", "HD 43525"},
        {"Hipparcos Number", "HIP 29850"},
        {"Celescope Catalog", "CEL 1160"},
        {"Fundamental Katalog 5th Edition", "FK5 2480"},
        {"Geneva Identification System", "GEN# +1.00043525A"},
        {"Geneva Identification System 2", "GEN# +1.00043525"},
        {"Smithsonian Astrophysical Observation", "SAO 113675"},
        {"Wilson Evans Batten Catalogue", "WEB 5907"},
    },
    visualMagnitude: 5.39,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.27756971),
        dec: Angle.Degrees(+09.94253598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107672"},
        {"Hipparcos Number", "HIP 60345"},
        {"Geneva Identification System", "GEN# +1.00107672"},
        {"Smithsonian Astrophysical Observation", "SAO 100065"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.59248858),
        dec: Angle.Degrees(+09.94273651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39398",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6542 A"},
        {"Henry Draper", "HD 66303"},
        {"Hipparcos Number", "HIP 39398"},
        {"Smithsonian Astrophysical Observation", "SAO 97510"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.81042064),
        dec: Angle.Degrees(+09.94285026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44077",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76795"},
        {"Hipparcos Number", "HIP 44077"},
        {"Geneva Identification System", "GEN# +1.00076795"},
        {"Smithsonian Astrophysical Observation", "SAO 98272"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.68807395),
        dec: Angle.Degrees(+09.94435745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72981"},
        {"Geneva Identification System", "GEN# +9.80066041"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.72362192),
        dec: Angle.Degrees(+09.94445916)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -317.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -398.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103112"},
        {"Hipparcos Number", "HIP 57888"},
        {"Geneva Identification System", "GEN# +1.00103112"},
        {"Smithsonian Astrophysical Observation", "SAO 99835"},
        {"Wilson Evans Batten Catalogue", "WEB 10378"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.08794247),
        dec: Angle.Degrees(+09.94787631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -347.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 110.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90042",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11294 AB"},
        {"Henry Draper", "HD 169062"},
        {"Hipparcos Number", "HIP 90042"},
        {"Smithsonian Astrophysical Observation", "SAO 123403"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.60093124),
        dec: Angle.Degrees(+09.94971302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63030",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63030"},
        {"Geneva Identification System", "GEN# +0.01002485"},
        {"Smithsonian Astrophysical Observation", "SAO 100331"},
    },
    visualMagnitude: 9.60,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.74015014),
        dec: Angle.Degrees(+09.95012394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11616"},
        {"Hipparcos Number", "HIP 8872"},
        {"Geneva Identification System", "GEN# +1.00011616"},
        {"Smithsonian Astrophysical Observation", "SAO 110212"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.54976128),
        dec: Angle.Degrees(+09.95080156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74745"},
        {"Hipparcos Number", "HIP 43027"},
        {"Smithsonian Astrophysical Observation", "SAO 98106"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.51212004),
        dec: Angle.Degrees(+09.95161565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179282"},
        {"Hipparcos Number", "HIP 94305"},
        {"Smithsonian Astrophysical Observation", "SAO 124371"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.92472108),
        dec: Angle.Degrees(+09.95170933)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151088"},
        {"Hipparcos Number", "HIP 81983"},
        {"Smithsonian Astrophysical Observation", "SAO 102359"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.21543909),
        dec: Angle.Degrees(+09.95176924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51104"},
        {"Hipparcos Number", "HIP 33372"},
        {"Fundamental Katalog 5th Edition", "FK5 2535"},
        {"Geneva Identification System", "GEN# +1.00051104"},
        {"Smithsonian Astrophysical Observation", "SAO 96294"},
        {"Wilson Evans Batten Catalogue", "WEB 6705"},
    },
    visualMagnitude: 5.90,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.10767805),
        dec: Angle.Degrees(+09.95659959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51757",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51757"},
    },
    visualMagnitude: 10.25,
    bvColour: 1.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.62592521),
        dec: Angle.Degrees(+09.96357097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184219"},
        {"Hipparcos Number", "HIP 96158"},
        {"Smithsonian Astrophysical Observation", "SAO 124780"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.27595823),
        dec: Angle.Degrees(+09.97016664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71579",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71579"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.57776768),
        dec: Angle.Degrees(+09.97123636)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183083"},
        {"Hipparcos Number", "HIP 95659"},
        {"Smithsonian Astrophysical Observation", "SAO 124644"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.87725566),
        dec: Angle.Degrees(+09.97135493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202927"},
        {"Hipparcos Number", "HIP 105216"},
        {"Smithsonian Astrophysical Observation", "SAO 126703"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.057,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.68520129),
        dec: Angle.Degrees(+09.97165716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141956"},
        {"Hipparcos Number", "HIP 77669"},
        {"Geneva Identification System", "GEN# +1.00141956"},
        {"Smithsonian Astrophysical Observation", "SAO 101777"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.85999217),
        dec: Angle.Degrees(+09.97359419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6134",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6134"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.67698091),
        dec: Angle.Degrees(+09.97422191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 190.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30870"},
        {"Hipparcos Number", "HIP 22597"},
        {"Celescope Catalog", "CEL 475"},
        {"Geneva Identification System", "GEN# +1.00030870"},
        {"Smithsonian Astrophysical Observation", "SAO 112150"},
        {"Wilson Evans Batten Catalogue", "WEB 4368"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.93075895),
        dec: Angle.Degrees(+09.97509562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173090"},
        {"Hipparcos Number", "HIP 91821"},
        {"Smithsonian Astrophysical Observation", "SAO 123844"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.244,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.81970220),
        dec: Angle.Degrees(+09.97624239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103035"},
        {"Hipparcos Number", "HIP 57852"},
        {"Geneva Identification System", "GEN# +1.00103035"},
        {"Smithsonian Astrophysical Observation", "SAO 99831"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.96525828),
        dec: Angle.Degrees(+09.97756185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 40449"},
    },
    visualMagnitude: 9.62,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.88012619),
        dec: Angle.Degrees(+09.97815467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73818",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73818"},
    },
    visualMagnitude: 10.02,
    bvColour: 0.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.31122392),
        dec: Angle.Degrees(+09.97875484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24346"},
        {"Hipparcos Number", "HIP 18146"},
        {"Geneva Identification System", "GEN# +1.00024346"},
        {"Smithsonian Astrophysical Observation", "SAO 111472"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.19718079),
        dec: Angle.Degrees(+09.97876282)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48836"},
        {"Smithsonian Astrophysical Observation", "SAO 98869"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.42823685),
        dec: Angle.Degrees(+09.97927567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -178.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89547",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89547"},
        {"Smithsonian Astrophysical Observation", "SAO 123314"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.07980601),
        dec: Angle.Degrees(+09.98009012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67177"},
        {"Hipparcos Number", "HIP 39719"},
        {"Geneva Identification System", "GEN# +1.00067177"},
        {"Smithsonian Astrophysical Observation", "SAO 97566"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.932,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.77705179),
        dec: Angle.Degrees(+09.98014034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118744"},
        {"Hipparcos Number", "HIP 66567"},
        {"Smithsonian Astrophysical Observation", "SAO 100646"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.68049213),
        dec: Angle.Degrees(+09.98081718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35426"},
        {"Hipparcos Number", "HIP 25326"},
        {"Smithsonian Astrophysical Observation", "SAO 112737"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.25371410),
        dec: Angle.Degrees(+09.98106091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74556",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74556"},
        {"Wilson Evans Batten Catalogue", "WEB 12725"},
    },
    visualMagnitude: 11.10,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.50393836),
        dec: Angle.Degrees(+09.98117137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126721"},
        {"Hipparcos Number", "HIP 70650"},
        {"Smithsonian Astrophysical Observation", "SAO 101028"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.75559615),
        dec: Angle.Degrees(+09.98141541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150123"},
        {"Hipparcos Number", "HIP 81489"},
        {"Smithsonian Astrophysical Observation", "SAO 102285"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.66818560),
        dec: Angle.Degrees(+09.98205550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4539"},
        {"Hipparcos Number", "HIP 3701"},
        {"Geneva Identification System", "GEN# +6.20028015"},
        {"Geneva Identification System 2", "GEN# +1.00004539"},
    },
    visualMagnitude: 10.31,
    bvColour: -0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.87173709),
        dec: Angle.Degrees(+09.98207648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90225"},
        {"Hipparcos Number", "HIP 50999"},
        {"Smithsonian Astrophysical Observation", "SAO 99106"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.25839180),
        dec: Angle.Degrees(+09.98235520)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23418"},
    },
    visualMagnitude: 11.45,
    bvColour: 1.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.49494498),
        dec: Angle.Degrees(+09.98331568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199775"},
        {"Hipparcos Number", "HIP 103573"},
        {"Geneva Identification System", "GEN# +1.00199775"},
        {"Smithsonian Astrophysical Observation", "SAO 126433"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.77224288),
        dec: Angle.Degrees(+09.98672906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106513"},
        {"Hipparcos Number", "HIP 59737"},
        {"Smithsonian Astrophysical Observation", "SAO 100006"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.75779590),
        dec: Angle.Degrees(+09.98783827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9324"},
        {"Hipparcos Number", "HIP 7131"},
        {"Smithsonian Astrophysical Observation", "SAO 109947"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.97188393),
        dec: Angle.Degrees(+09.98827972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46709"},
        {"Hipparcos Number", "HIP 31448"},
        {"Fundamental Katalog 5th Edition", "FK5 2505"},
        {"Geneva Identification System", "GEN# +1.00046709"},
        {"Smithsonian Astrophysical Observation", "SAO 95870"},
        {"Wilson Evans Batten Catalogue", "WEB 6291"},
    },
    visualMagnitude: 5.93,
    bvColour: 1.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.82331871),
        dec: Angle.Degrees(+09.98835403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110694",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110694"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.40820280),
        dec: Angle.Degrees(+09.98882459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14792",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14792"},
        {"Geneva Identification System", "GEN# +5.20250133"},
        {"Smithsonian Astrophysical Observation", "SAO 111029"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.75416724),
        dec: Angle.Degrees(+09.98970732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 165.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84363"},
    },
    visualMagnitude: 11.03,
    bvColour: 0.628,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.71533493),
        dec: Angle.Degrees(+09.98982379)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107346"},
        {"Hipparcos Number", "HIP 60181"},
        {"Geneva Identification System", "GEN# +1.00107346"},
    },
    visualMagnitude: 10.38,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.11516016),
        dec: Angle.Degrees(+09.98995976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106512"},
        {"Hipparcos Number", "HIP 59739"},
        {"Smithsonian Astrophysical Observation", "SAO 100008"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.76442553),
        dec: Angle.Degrees(+09.99089026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156018"},
        {"Hipparcos Number", "HIP 84360"},
        {"Smithsonian Astrophysical Observation", "SAO 102683"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.70832840),
        dec: Angle.Degrees(+09.99372798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144130"},
        {"Hipparcos Number", "HIP 78705"},
        {"Geneva Identification System", "GEN# +1.00144130"},
        {"Smithsonian Astrophysical Observation", "SAO 101901"},
    },
    visualMagnitude: 8.53,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.00891234),
        dec: Angle.Degrees(+09.99472882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200047"},
        {"Hipparcos Number", "HIP 103695"},
        {"Smithsonian Astrophysical Observation", "SAO 126462"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.18633076),
        dec: Angle.Degrees(+09.99584884)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 357068"},
        {"Hipparcos Number", "HIP 99541"},
    },
    visualMagnitude: 10.10,
    bvColour: 0.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.01775855),
        dec: Angle.Degrees(+09.99586089)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49637",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7649 A"},
        {"Henry Draper", "HD 87837"},
        {"Hipparcos Number", "HIP 49637"},
        {"Geneva Identification System", "GEN# +1.00087837"},
        {"Smithsonian Astrophysical Observation", "SAO 98964"},
        {"Wilson Evans Batten Catalogue", "WEB 9155"},
    },
    visualMagnitude: 4.39,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.97632850),
        dec: Angle.Degrees(+09.99766389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -81.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18805",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2938 A"},
        {"Henry Draper", "HD 25330"},
        {"Hipparcos Number", "HIP 18805"},
        {"Geneva Identification System", "GEN# +1.00025330J"},
        {"Smithsonian Astrophysical Observation", "SAO 111566"},
        {"Wilson Evans Batten Catalogue", "WEB 3621"},
    },
    visualMagnitude: 5.67,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.44222088),
        dec: Angle.Degrees(+09.99801393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115901"},
        {"Hipparcos Number", "HIP 65055"},
        {"Geneva Identification System", "GEN# +1.00115901"},
        {"Smithsonian Astrophysical Observation", "SAO 100515"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.02423597),
        dec: Angle.Degrees(+10.00004887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98366",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98366"},
        {"Renson", "Renson 52440"},
        {"Smithsonian Astrophysical Observation", "SAO 125306"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.77794774),
        dec: Angle.Degrees(+10.00123345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147751"},
        {"Hipparcos Number", "HIP 80288"},
        {"Smithsonian Astrophysical Observation", "SAO 102120"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.84281781),
        dec: Angle.Degrees(+10.00482773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14778",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19723"},
        {"Hipparcos Number", "HIP 14778"},
        {"Smithsonian Astrophysical Observation", "SAO 111028"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.70473888),
        dec: Angle.Degrees(+10.00587109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78713",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144150"},
        {"Hipparcos Number", "HIP 78713"},
        {"Geneva Identification System", "GEN# +1.00144150"},
        {"Smithsonian Astrophysical Observation", "SAO 101902"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.03441755),
        dec: Angle.Degrees(+10.00630805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102543",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102543"},
        {"Smithsonian Astrophysical Observation", "SAO 126204"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.69936070),
        dec: Angle.Degrees(+10.00665542)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14514"},
        {"Hipparcos Number", "HIP 10937"},
        {"Geneva Identification System", "GEN# +1.00014514"},
        {"Smithsonian Astrophysical Observation", "SAO 110485"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.21987290),
        dec: Angle.Degrees(+10.00670809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104858",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14773 AB"},
        {"Henry Draper", "HD 202275"},
        {"Henry Draper 2", "HD 202275A"},
        {"Hipparcos Number", "HIP 104858"},
        {"Geneva Identification System", "GEN# +1.00202275"},
        {"Smithsonian Astrophysical Observation", "SAO 126643"},
        {"Wilson Evans Batten Catalogue", "WEB 19067"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.61995883),
        dec: Angle.Degrees(+10.00771855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -303.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65496",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65496"},
    },
    visualMagnitude: 10.40,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.35278815),
        dec: Angle.Degrees(+10.00953720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21123"},
        {"Hipparcos Number", "HIP 15918"},
        {"Geneva Identification System", "GEN# +1.00021123"},
        {"Smithsonian Astrophysical Observation", "SAO 111174"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.24706729),
        dec: Angle.Degrees(+10.01006927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139195"},
        {"Hipparcos Number", "HIP 76425"},
        {"Geneva Identification System", "GEN# +1.00139195"},
        {"Smithsonian Astrophysical Observation", "SAO 101640"},
        {"Wilson Evans Batten Catalogue", "WEB 12974"},
    },
    visualMagnitude: 5.26,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.12313310),
        dec: Angle.Degrees(+10.01045490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26793"},
        {"Hipparcos Number", "HIP 19799"},
        {"Geneva Identification System", "GEN# +1.00026793"},
        {"Smithsonian Astrophysical Observation", "SAO 111680"},
        {"Wilson Evans Batten Catalogue", "WEB 3780"},
    },
    visualMagnitude: 5.22,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.65099178),
        dec: Angle.Degrees(+10.01143911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51670"},
        {"Smithsonian Astrophysical Observation", "SAO 99180"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.34158711),
        dec: Angle.Degrees(+10.01223008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118015",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224250"},
        {"Hipparcos Number", "HIP 118015"},
        {"Smithsonian Astrophysical Observation", "SAO 128479"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.08160384),
        dec: Angle.Degrees(+10.01223322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32509",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5443 AB"},
        {"Henry Draper", "HD 263803"},
        {"Hipparcos Number", "HIP 32509"},
        {"Smithsonian Astrophysical Observation", "SAO 96105"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.76334652),
        dec: Angle.Degrees(+10.01264070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123034"},
        {"Hipparcos Number", "HIP 68801"},
        {"Geneva Identification System", "GEN# +1.00123034"},
        {"Smithsonian Astrophysical Observation", "SAO 100840"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.859,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.26597354),
        dec: Angle.Degrees(+10.01347780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 46.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20831",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3233 B"},
        {"Hipparcos Number", "HIP 20831"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.96480795),
        dec: Angle.Degrees(+10.01437953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21308",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29004"},
        {"Hipparcos Number", "HIP 21308"},
        {"Geneva Identification System", "GEN# +1.00029004"},
        {"Smithsonian Astrophysical Observation", "SAO 111901"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.62553137),
        dec: Angle.Degrees(+10.01658798)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38095"},
        {"Hipparcos Number", "HIP 26994"},
        {"Smithsonian Astrophysical Observation", "SAO 113077"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.90600519),
        dec: Angle.Degrees(+10.01957067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20830",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3233 A"},
        {"Henry Draper", "HD 28259"},
        {"Hipparcos Number", "HIP 20830"},
        {"Smithsonian Astrophysical Observation", "SAO 111835"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.96204462),
        dec: Angle.Degrees(+10.02092449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93178"},
        {"Hipparcos Number", "HIP 52625"},
        {"Smithsonian Astrophysical Observation", "SAO 99279"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.43007558),
        dec: Angle.Degrees(+10.02157247)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64179",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114256"},
        {"Hipparcos Number", "HIP 64179"},
        {"Geneva Identification System", "GEN# +1.00114256"},
        {"Smithsonian Astrophysical Observation", "SAO 100436"},
        {"Wilson Evans Batten Catalogue", "WEB 11344"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.30175990),
        dec: Angle.Degrees(+10.02246786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54300"},
        {"Hipparcos Number", "HIP 34474"},
        {"Geneva Identification System", "GEN# +1.00054300"},
        {"Smithsonian Astrophysical Observation", "SAO 96548"},
        {"Wilson Evans Batten Catalogue", "WEB 6904"},
    },
    visualMagnitude: 7.83,
    bvColour: 2.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.17757069),
        dec: Angle.Degrees(+10.02401090)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91156",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91156"},
    },
    visualMagnitude: 10.44,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.96715817),
        dec: Angle.Degrees(+10.02970770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73259",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73259"},
        {"Smithsonian Astrophysical Observation", "SAO 101308"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.58471501),
        dec: Angle.Degrees(+10.03005621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 264729"},
        {"Hipparcos Number", "HIP 32785"},
        {"Smithsonian Astrophysical Observation", "SAO 96174"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.53220575),
        dec: Angle.Degrees(+10.03077072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195311"},
        {"Hipparcos Number", "HIP 101149"},
        {"Smithsonian Astrophysical Observation", "SAO 125875"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.54077184),
        dec: Angle.Degrees(+10.03429624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99941",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99941"},
    },
    visualMagnitude: 10.44,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.16229169),
        dec: Angle.Degrees(+10.03570051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75584",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137570"},
        {"Hipparcos Number", "HIP 75584"},
        {"Fundamental Katalog 5th Edition", "FK5 5367"},
        {"Geneva Identification System", "GEN# +1.00137570"},
        {"Smithsonian Astrophysical Observation", "SAO 101556"},
        {"Wilson Evans Batten Catalogue", "WEB 12879"},
    },
    visualMagnitude: 6.97,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.62618430),
        dec: Angle.Degrees(+10.03609811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25800"},
        {"Hipparcos Number", "HIP 19103"},
        {"Geneva Identification System", "GEN# +1.00025800"},
        {"Smithsonian Astrophysical Observation", "SAO 111597"},
    },
    visualMagnitude: 6.72,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.42329955),
        dec: Angle.Degrees(+10.03711220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99797"},
        {"Hipparcos Number", "HIP 56028"},
        {"Smithsonian Astrophysical Observation", "SAO 99621"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.24738883),
        dec: Angle.Degrees(+10.03782374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -147.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 41.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145436"},
        {"Hipparcos Number", "HIP 79270"},
        {"Geneva Identification System", "GEN# +1.00145436"},
        {"Smithsonian Astrophysical Observation", "SAO 101985"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.67668726),
        dec: Angle.Degrees(+10.03787570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59572",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106156"},
        {"Hipparcos Number", "HIP 59572"},
        {"Cincinnati Publication", "Ci 20 689"},
        {"Geneva Identification System", "GEN# +1.00106156"},
        {"Smithsonian Astrophysical Observation", "SAO 99991"},
        {"Wilson Evans Batten Catalogue", "WEB 10587"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.23919543),
        dec: Angle.Degrees(+10.03858627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 209.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -357.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155193"},
        {"Hipparcos Number", "HIP 83953"},
        {"Geneva Identification System", "GEN# +1.00155193"},
        {"Smithsonian Astrophysical Observation", "SAO 102623"},
    },
    visualMagnitude: 7.00,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.42134969),
        dec: Angle.Degrees(+10.03901689)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -65.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -134.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187130"},
        {"Hipparcos Number", "HIP 97414"},
        {"Smithsonian Astrophysical Observation", "SAO 125080"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.98743945),
        dec: Angle.Degrees(+10.03981233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159927"},
        {"Hipparcos Number", "HIP 86198"},
        {"Smithsonian Astrophysical Observation", "SAO 102963"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.22898087),
        dec: Angle.Degrees(+10.03985575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216817"},
        {"Hipparcos Number", "HIP 113251"},
        {"Smithsonian Astrophysical Observation", "SAO 127847"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.99396955),
        dec: Angle.Degrees(+10.04116034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56491",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56491"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.71538927),
        dec: Angle.Degrees(+10.04141841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106252"},
        {"Hipparcos Number", "HIP 59610"},
        {"Geneva Identification System", "GEN# +1.00106252"},
        {"Smithsonian Astrophysical Observation", "SAO 99998"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.37289681),
        dec: Angle.Degrees(+10.04231745)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -279.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130705"},
        {"Hipparcos Number", "HIP 72499"},
        {"Fundamental Katalog 5th Edition", "FK5 3170"},
        {"Geneva Identification System", "GEN# +1.00130705"},
        {"Smithsonian Astrophysical Observation", "SAO 101232"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.35911527),
        dec: Angle.Degrees(+10.04436288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181167"},
        {"Hipparcos Number", "HIP 94936"},
        {"Smithsonian Astrophysical Observation", "SAO 124500"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.77094609),
        dec: Angle.Degrees(+10.04570465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187129"},
        {"Hipparcos Number", "HIP 97410"},
        {"Smithsonian Astrophysical Observation", "SAO 125079"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.97429012),
        dec: Angle.Degrees(+10.04601108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27924"},
        {"Hipparcos Number", "HIP 20597"},
        {"Celescope Catalog", "CEL 396"},
        {"Geneva Identification System", "GEN# +1.00027924"},
        {"Smithsonian Astrophysical Observation", "SAO 111798"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.17500131),
        dec: Angle.Degrees(+10.04678385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -51.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59375"},
        {"Hipparcos Number", "HIP 36458"},
        {"Smithsonian Astrophysical Observation", "SAO 96958"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.52577287),
        dec: Angle.Degrees(+10.04769469)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14702 D"},
        {"Henry Draper", "HD 201616"},
        {"Hipparcos Number", "HIP 104538"},
        {"Geneva Identification System", "GEN# +1.00201616"},
        {"Renson", "Renson 56220"},
        {"Smithsonian Astrophysical Observation", "SAO 126597"},
        {"Wilson Evans Batten Catalogue", "WEB 19023"},
    },
    visualMagnitude: 6.07,
    bvColour: 0.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.63047657),
        dec: Angle.Degrees(+10.04887979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103389"},
        {"Hipparcos Number", "HIP 58049"},
        {"Geneva Identification System", "GEN# +1.00103389"},
        {"Smithsonian Astrophysical Observation", "SAO 99855"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.59487968),
        dec: Angle.Degrees(+10.04906743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91117"},
        {"Hipparcos Number", "HIP 51520"},
        {"Smithsonian Astrophysical Observation", "SAO 99166"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.84060382),
        dec: Angle.Degrees(+10.05010959)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123156"},
        {"Hipparcos Number", "HIP 68843"},
        {"Smithsonian Astrophysical Observation", "SAO 100845"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.505,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.44776816),
        dec: Angle.Degrees(+10.05054157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 64.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22239",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3448 AB"},
        {"Henry Draper", "HD 30342"},
        {"Hipparcos Number", "HIP 22239"},
        {"Celescope Catalog", "CEL 464"},
        {"Geneva Identification System", "GEN# +1.00030342J"},
        {"Smithsonian Astrophysical Observation", "SAO 112074"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.77773119),
        dec: Angle.Degrees(+10.05164940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130087"},
        {"Hipparcos Number", "HIP 72190"},
        {"Geneva Identification System", "GEN# +1.00130087"},
        {"Smithsonian Astrophysical Observation", "SAO 101198"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.48684227),
        dec: Angle.Degrees(+10.05207074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191246"},
        {"Hipparcos Number", "HIP 99223"},
        {"Smithsonian Astrophysical Observation", "SAO 125492"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.13774738),
        dec: Angle.Degrees(+10.05385605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116466",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116466"},
    },
    visualMagnitude: 10.64,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.98434856),
        dec: Angle.Degrees(+10.05390325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -96.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18038",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18038"},
        {"Smithsonian Astrophysical Observation", "SAO 111464"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.83570834),
        dec: Angle.Degrees(+10.05546256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194526"},
        {"Hipparcos Number", "HIP 100762"},
        {"Geneva Identification System", "GEN# +1.00194526"},
        {"Smithsonian Astrophysical Observation", "SAO 125797"},
        {"Wilson Evans Batten Catalogue", "WEB 18209"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.43376134),
        dec: Angle.Degrees(+10.05609372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195922"},
        {"Hipparcos Number", "HIP 101473"},
        {"Geneva Identification System", "GEN# +1.00195922"},
        {"Smithsonian Astrophysical Observation", "SAO 125960"},
        {"Wilson Evans Batten Catalogue", "WEB 18333"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.47376324),
        dec: Angle.Degrees(+10.05971802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166843"},
        {"Hipparcos Number", "HIP 89193"},
        {"Geneva Identification System", "GEN# +1.00166843"},
        {"Smithsonian Astrophysical Observation", "SAO 103468"},
        {"Wilson Evans Batten Catalogue", "WEB 15154"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.03662141),
        dec: Angle.Degrees(+10.06185097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258686"},
        {"Hipparcos Number", "HIP 31038"},
        {"Geneva Identification System", "GEN# +1.00258686"},
    },
    visualMagnitude: 9.13,
    bvColour: -0.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.69607099),
        dec: Angle.Degrees(+10.06291209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85823",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85823"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.05495561),
        dec: Angle.Degrees(+10.06321108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52123"},
        {"Geneva Identification System", "GEN# +0.01002179"},
        {"Renson", "Renson 26510"},
        {"Smithsonian Astrophysical Observation", "SAO 99230"},
    },
    visualMagnitude: 9.97,
    bvColour: -0.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(159.73017011),
        dec: Angle.Degrees(+10.06348033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70374"},
        {"Hipparcos Number", "HIP 40987"},
        {"Geneva Identification System", "GEN# +1.00070374"},
        {"Smithsonian Astrophysical Observation", "SAO 97763"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.837,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.47346403),
        dec: Angle.Degrees(+10.06457204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -119.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136564"},
        {"Hipparcos Number", "HIP 75128"},
        {"Smithsonian Astrophysical Observation", "SAO 101500"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.28378598),
        dec: Angle.Degrees(+10.06526738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72359"},
        {"Hipparcos Number", "HIP 41904"},
        {"Geneva Identification System", "GEN# +1.00072359"},
        {"Renson", "Renson 20027"},
        {"Smithsonian Astrophysical Observation", "SAO 97902"},
        {"Wilson Evans Batten Catalogue", "WEB 8066"},
    },
    visualMagnitude: 6.48,
    bvColour: -0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.16611526),
        dec: Angle.Degrees(+10.06602306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57734",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102824"},
        {"Hipparcos Number", "HIP 57734"},
        {"Geneva Identification System", "GEN# +1.00102824"},
        {"Smithsonian Astrophysical Observation", "SAO 99821"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.58759125),
        dec: Angle.Degrees(+10.06734590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 555",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 555"},
    },
    visualMagnitude: 9.74,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69415329),
        dec: Angle.Degrees(+10.06899229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20845",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3238 AB"},
        {"Henry Draper", "HD 28283"},
        {"Hipparcos Number", "HIP 20845"},
        {"Celescope Catalog", "CEL 404"},
        {"Geneva Identification System", "GEN# +1.00028283J"},
        {"Smithsonian Astrophysical Observation", "SAO 111837"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.01237221),
        dec: Angle.Degrees(+10.07220751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36606",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59723"},
        {"Hipparcos Number", "HIP 36606"},
        {"Smithsonian Astrophysical Observation", "SAO 96986"},
    },
    visualMagnitude: 8.51,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.92227942),
        dec: Angle.Degrees(+10.07362747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120382"},
        {"Hipparcos Number", "HIP 67416"},
        {"Smithsonian Astrophysical Observation", "SAO 100720"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.24970511),
        dec: Angle.Degrees(+10.07460453)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48055",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7517 AB"},
        {"Henry Draper", "HD 84781"},
        {"Hipparcos Number", "HIP 48055"},
        {"Smithsonian Astrophysical Observation", "SAO 98772"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.94140106),
        dec: Angle.Degrees(+10.07495919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101932",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14101 C"},
        {"Henry Draper", "HD 196794"},
        {"Hipparcos Number", "HIP 101932"},
        {"Cincinnati Publication", "Ci 18 2675"},
        {"Geneva Identification System", "GEN# +1.00196794"},
        {"Geneva Identification System 2", "GEN# +1.00196755C"},
        {"Smithsonian Astrophysical Observation", "SAO 126064"},
        {"Wilson Evans Batten Catalogue", "WEB 18420"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.84109282),
        dec: Angle.Degrees(+10.07568410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 317.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12773"},
        {"Hipparcos Number", "HIP 9748"},
        {"Smithsonian Astrophysical Observation", "SAO 110328"},
    },
    visualMagnitude: 7.01,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.34708066),
        dec: Angle.Degrees(+10.07684358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4108"},
        {"Hipparcos Number", "HIP 3424"},
        {"Smithsonian Astrophysical Observation", "SAO 109411"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.90454986),
        dec: Angle.Degrees(+10.07898157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41378",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41378"},
        {"Smithsonian Astrophysical Observation", "SAO 97816"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.61615698),
        dec: Angle.Degrees(+10.08037066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144937"},
        {"Hipparcos Number", "HIP 79047"},
        {"Geneva Identification System", "GEN# +1.00144937"},
        {"Smithsonian Astrophysical Observation", "SAO 101947"},
        {"Wilson Evans Batten Catalogue", "WEB 13362"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.02388651),
        dec: Angle.Degrees(+10.08050512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141530"},
        {"Hipparcos Number", "HIP 77490"},
        {"Geneva Identification System", "GEN# +1.00141530"},
        {"Smithsonian Astrophysical Observation", "SAO 101756"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.33399419),
        dec: Angle.Degrees(+10.08134336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74521"},
        {"Hipparcos Number", "HIP 42917"},
        {"Fundamental Katalog 5th Edition", "FK5 2688"},
        {"Geneva Identification System", "GEN# +1.00074521"},
        {"Renson", "Renson 20790"},
        {"Smithsonian Astrophysical Observation", "SAO 98089"},
        {"Wilson Evans Batten Catalogue", "WEB 8294"},
    },
    visualMagnitude: 5.63,
    bvColour: -0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.18768592),
        dec: Angle.Degrees(+10.08171256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22965"},
        {"Hipparcos Number", "HIP 17240"},
        {"Geneva Identification System", "GEN# +1.00022965"},
        {"Smithsonian Astrophysical Observation", "SAO 111356"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.38387442),
        dec: Angle.Degrees(+10.08182042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52716"},
        {"Hipparcos Number", "HIP 33947"},
        {"Smithsonian Astrophysical Observation", "SAO 96414"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.66573080),
        dec: Angle.Degrees(+10.08280664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62707"},
        {"Smithsonian Astrophysical Observation", "SAO 100298"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.75064595),
        dec: Angle.Degrees(+10.08514402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14101 A"},
        {"Henry Draper", "HD 196755"},
        {"Hipparcos Number", "HIP 101916"},
        {"Fundamental Katalog 5th Edition", "FK5 772"},
        {"Geneva Identification System", "GEN# +1.00196755A"},
        {"Smithsonian Astrophysical Observation", "SAO 126059"},
        {"Wilson Evans Batten Catalogue", "WEB 18415"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.78163540),
        dec: Angle.Degrees(+10.08615196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 323.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182514"},
        {"Hipparcos Number", "HIP 95425"},
        {"Smithsonian Astrophysical Observation", "SAO 124595"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.17192417),
        dec: Angle.Degrees(+10.08648418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 355784"},
        {"Hipparcos Number", "HIP 97051"},
        {"Wilson Evans Batten Catalogue", "WEB 17031"},
    },
    visualMagnitude: 10.00,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.85510662),
        dec: Angle.Degrees(+10.08926496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 189.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4823",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 851 AB"},
        {"Henry Draper", "HD 6051"},
        {"Hipparcos Number", "HIP 4823"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.48540441),
        dec: Angle.Degrees(+10.08974840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161732"},
        {"Hipparcos Number", "HIP 87014"},
        {"Smithsonian Astrophysical Observation", "SAO 103096"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.70262482),
        dec: Angle.Degrees(+10.09009454)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109119",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15630 B"},
        {"Hipparcos Number", "HIP 109119"},
        {"Smithsonian Astrophysical Observation", "SAO 127298"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.54925776),
        dec: Angle.Degrees(+10.09132575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15630 A"},
        {"Henry Draper", "HD 209845"},
        {"Hipparcos Number", "HIP 109117"},
        {"Renson", "Renson 58400"},
        {"Smithsonian Astrophysical Observation", "SAO 127297"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.54406737),
        dec: Angle.Degrees(+10.09346840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208443"},
        {"Hipparcos Number", "HIP 108263"},
        {"Smithsonian Astrophysical Observation", "SAO 127166"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.99616565),
        dec: Angle.Degrees(+10.09698139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26163"},
        {"Hipparcos Number", "HIP 19348"},
        {"Smithsonian Astrophysical Observation", "SAO 111624"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.17540384),
        dec: Angle.Degrees(+10.09944261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134284"},
        {"Hipparcos Number", "HIP 74099"},
        {"Geneva Identification System", "GEN# +1.00134284"},
        {"Smithsonian Astrophysical Observation", "SAO 101399"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.16207109),
        dec: Angle.Degrees(+10.09947061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110612"},
        {"Hipparcos Number", "HIP 62070"},
        {"Geneva Identification System", "GEN# +1.00110612"},
        {"Smithsonian Astrophysical Observation", "SAO 100222"},
        {"Wilson Evans Batten Catalogue", "WEB 11035"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.81631798),
        dec: Angle.Degrees(+10.10080185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124679"},
        {"Hipparcos Number", "HIP 69612"},
        {"Fundamental Katalog 5th Edition", "FK5 3131"},
        {"Geneva Identification System", "GEN# +1.00124679"},
        {"Smithsonian Astrophysical Observation", "SAO 100934"},
        {"Wilson Evans Batten Catalogue", "WEB 12119"},
    },
    visualMagnitude: 5.29,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.71192715),
        dec: Angle.Degrees(+10.10100970)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38422"},
        {"Hipparcos Number", "HIP 27217"},
        {"Smithsonian Astrophysical Observation", "SAO 94844"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.52593914),
        dec: Angle.Degrees(+10.10200679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89896",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168655"},
        {"Hipparcos Number", "HIP 89896"},
        {"Smithsonian Astrophysical Observation", "SAO 103627"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.15096396),
        dec: Angle.Degrees(+10.10389747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77987",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9840 B"},
        {"Hipparcos Number", "HIP 77987"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87886167),
        dec: Angle.Degrees(+10.10460899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77983",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9840 A"},
        {"Henry Draper", "HD 142658"},
        {"Hipparcos Number", "HIP 77983"},
        {"Geneva Identification System", "GEN# +1.00142658"},
        {"Smithsonian Astrophysical Observation", "SAO 101817"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.87469432),
        dec: Angle.Degrees(+10.10481450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77328"},
        {"Hipparcos Number", "HIP 44373"},
        {"Geneva Identification System", "GEN# +1.00077328"},
        {"Smithsonian Astrophysical Observation", "SAO 98305"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.919,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.56380159),
        dec: Angle.Degrees(+10.10596136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48656",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7578 B"},
        {"Hipparcos Number", "HIP 48656"},
        {"Smithsonian Astrophysical Observation", "SAO 98844"},
    },
    visualMagnitude: 10.77,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.84233466),
        dec: Angle.Degrees(+10.10799350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48657",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7578 A"},
        {"Henry Draper", "HD 85916"},
        {"Hipparcos Number", "HIP 48657"},
        {"Geneva Identification System", "GEN# +1.00085916"},
        {"Smithsonian Astrophysical Observation", "SAO 98845"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.84645810),
        dec: Angle.Degrees(+10.11183722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17094"},
        {"Hipparcos Number", "HIP 12828"},
        {"Fundamental Katalog 5th Edition", "FK5 98"},
        {"Geneva Identification System", "GEN# +1.00017094"},
        {"Renson", "Renson 4320"},
        {"Smithsonian Astrophysical Observation", "SAO 110723"},
        {"Wilson Evans Batten Catalogue", "WEB 2606"},
    },
    visualMagnitude: 4.27,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.23488901),
        dec: Angle.Degrees(+10.11421979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 285.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50370",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7710 AB"},
        {"Henry Draper", "HD 89126"},
        {"Hipparcos Number", "HIP 50370"},
        {"Smithsonian Astrophysical Observation", "SAO 99036"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.26223663),
        dec: Angle.Degrees(+10.11436416)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12736"},
        {"Hipparcos Number", "HIP 9718"},
        {"Smithsonian Astrophysical Observation", "SAO 110326"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.988,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.25210654),
        dec: Angle.Degrees(+10.11605191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161731"},
        {"Hipparcos Number", "HIP 87017"},
        {"Geneva Identification System", "GEN# +1.00161731"},
        {"Smithsonian Astrophysical Observation", "SAO 103099"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.71149939),
        dec: Angle.Degrees(+10.11731315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -228.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60525"},
        {"Hipparcos Number", "HIP 36900"},
        {"Smithsonian Astrophysical Observation", "SAO 97052"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.79894878),
        dec: Angle.Degrees(+10.11868929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59955",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106929"},
        {"Hipparcos Number", "HIP 59955"},
        {"Geneva Identification System", "GEN# +1.00106929"},
        {"Smithsonian Astrophysical Observation", "SAO 100024"},
    },
    visualMagnitude: 9.81,
    bvColour: -0.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.45820897),
        dec: Angle.Degrees(+10.11999339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53431",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53431"},
        {"Smithsonian Astrophysical Observation", "SAO 99357"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.95665239),
        dec: Angle.Degrees(+10.12153503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27386"},
        {"Hipparcos Number", "HIP 20188"},
        {"Geneva Identification System", "GEN# +1.00027386"},
        {"Smithsonian Astrophysical Observation", "SAO 93866"},
        {"Wilson Evans Batten Catalogue", "WEB 3848"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.90594457),
        dec: Angle.Degrees(+10.12153616)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24177",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 24177"},
    },
    visualMagnitude: 11.97,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.87400531),
        dec: Angle.Degrees(+10.12154556)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -216.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16129"},
        {"Hipparcos Number", "HIP 12076"},
        {"Smithsonian Astrophysical Observation", "SAO 110632"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.92580147),
        dec: Angle.Degrees(+10.12253458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200137"},
        {"Hipparcos Number", "HIP 103739"},
        {"Smithsonian Astrophysical Observation", "SAO 126470"},
    },
    visualMagnitude: 8.74,
    bvColour: -0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.32646190),
        dec: Angle.Degrees(+10.12414317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74345",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9530 AB"},
        {"Henry Draper", "HD 134827"},
        {"Hipparcos Number", "HIP 74345"},
        {"Smithsonian Astrophysical Observation", "SAO 101422"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.90959126),
        dec: Angle.Degrees(+10.12493347)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18284"},
        {"Hipparcos Number", "HIP 13706"},
        {"Smithsonian Astrophysical Observation", "SAO 110859"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.12338154),
        dec: Angle.Degrees(+10.12591218)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62449",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 62449"},
        {"Geneva Identification System", "GEN# +0.01002473"},
        {"Smithsonian Astrophysical Observation", "SAO 100265"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.97900866),
        dec: Angle.Degrees(+10.12622562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74670",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135576"},
        {"Hipparcos Number", "HIP 74670"},
        {"Geneva Identification System", "GEN# +1.00135576"},
        {"Smithsonian Astrophysical Observation", "SAO 101461"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.89712755),
        dec: Angle.Degrees(+10.12656985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61719"},
        {"Hipparcos Number", "HIP 37435"},
        {"Smithsonian Astrophysical Observation", "SAO 97141"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.27125712),
        dec: Angle.Degrees(+10.12789344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89345"},
        {"Hipparcos Number", "HIP 50496"},
        {"Smithsonian Astrophysical Observation", "SAO 99054"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.842,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.67106000),
        dec: Angle.Degrees(+10.12913033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65371"},
        {"Hipparcos Number", "HIP 38992"},
        {"Cincinnati Publication", "Ci 20 447"},
        {"Geneva Identification System", "GEN# +1.00065371"},
        {"Smithsonian Astrophysical Observation", "SAO 97434"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.70882712),
        dec: Angle.Degrees(+10.12969968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 448.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 251003"},
        {"Hipparcos Number", "HIP 28700"},
        {"Fundamental Katalog 5th Edition", "FK5 4552"},
        {"Smithsonian Astrophysical Observation", "SAO 95175"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.91678046),
        dec: Angle.Degrees(+10.12970578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181254"},
        {"Hipparcos Number", "HIP 94968"},
        {"Smithsonian Astrophysical Observation", "SAO 104718"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.88139935),
        dec: Angle.Degrees(+10.13121896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104521",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14702 A"},
        {"Henry Draper", "HD 201601"},
        {"Henry Draper 2", "HD 201601A"},
        {"Hipparcos Number", "HIP 104521"},
        {"Fundamental Katalog 5th Edition", "FK5 1555"},
        {"Geneva Identification System", "GEN# +1.00201601"},
        {"Renson", "Renson 56210"},
        {"Smithsonian Astrophysical Observation", "SAO 126593"},
        {"Wilson Evans Batten Catalogue", "WEB 19021"},
    },
    visualMagnitude: 4.70,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.58529617),
        dec: Angle.Degrees(+10.13194861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98201",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188951"},
        {"Hipparcos Number", "HIP 98201"},
        {"Geneva Identification System", "GEN# +1.00188951"},
        {"Smithsonian Astrophysical Observation", "SAO 125275"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.016,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.32781114),
        dec: Angle.Degrees(+10.13240428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208670"},
        {"Hipparcos Number", "HIP 108413"},
        {"Smithsonian Astrophysical Observation", "SAO 127193"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.44104548),
        dec: Angle.Degrees(+10.13301268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121923"},
        {"Hipparcos Number", "HIP 68251"},
        {"Smithsonian Astrophysical Observation", "SAO 100798"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.475,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.58439552),
        dec: Angle.Degrees(+10.13469145)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120848"},
        {"Hipparcos Number", "HIP 67674"},
        {"Smithsonian Astrophysical Observation", "SAO 100741"},
    },
    visualMagnitude: 6.57,
    bvColour: 1.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.96591679),
        dec: Angle.Degrees(+10.13597934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 244179"},
        {"Hipparcos Number", "HIP 25698"},
        {"Smithsonian Astrophysical Observation", "SAO 94587"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.32239774),
        dec: Angle.Degrees(+10.13601365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113142"},
        {"Hipparcos Number", "HIP 63558"},
        {"Smithsonian Astrophysical Observation", "SAO 100379"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.35871543),
        dec: Angle.Degrees(+10.13614174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11864",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11864"},
    },
    visualMagnitude: 10.10,
    bvColour: 1.621,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.27120537),
        dec: Angle.Degrees(+10.13713982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67860",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9047 AB"},
        {"Henry Draper", "HD 121215"},
        {"Hipparcos Number", "HIP 67860"},
        {"Smithsonian Astrophysical Observation", "SAO 100758"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48664146),
        dec: Angle.Degrees(+10.13886830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176304"},
        {"Hipparcos Number", "HIP 93218"},
        {"Geneva Identification System", "GEN# +1.00176304"},
        {"Renson", "Renson 49180"},
        {"Smithsonian Astrophysical Observation", "SAO 104313"},
        {"Wilson Evans Batten Catalogue", "WEB 16161"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.82225298),
        dec: Angle.Degrees(+10.14101187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58224"},
        {"Hipparcos Number", "HIP 35994"},
        {"Smithsonian Astrophysical Observation", "SAO 96874"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.27300748),
        dec: Angle.Degrees(+10.14144240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15288",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15288"},
        {"Smithsonian Astrophysical Observation", "SAO 111097"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.31329562),
        dec: Angle.Degrees(+10.14217150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71310",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71310"},
        {"Smithsonian Astrophysical Observation", "SAO 101089"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.74137149),
        dec: Angle.Degrees(+10.14343448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204134"},
        {"Hipparcos Number", "HIP 105847"},
        {"Geneva Identification System", "GEN# +1.00204134"},
        {"Smithsonian Astrophysical Observation", "SAO 126792"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.57533224),
        dec: Angle.Degrees(+10.14488929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2784"},
    },
    visualMagnitude: 10.85,
    bvColour: 0.836,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.88051802),
        dec: Angle.Degrees(+10.14514265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 85202"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.16141432),
        dec: Angle.Degrees(+10.14681967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117746"},
        {"Hipparcos Number", "HIP 66025"},
        {"Geneva Identification System", "GEN# +1.00117746"},
        {"Smithsonian Astrophysical Observation", "SAO 100609"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.546,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.04607858),
        dec: Angle.Degrees(+10.14750960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75900"},
        {"Hipparcos Number", "HIP 43631"},
        {"Geneva Identification System", "GEN# +1.00075900"},
        {"Smithsonian Astrophysical Observation", "SAO 98197"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.28629638),
        dec: Angle.Degrees(+10.14779339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2293"},
        {"Hipparcos Number", "HIP 2123"},
        {"Smithsonian Astrophysical Observation", "SAO 109210"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72203691),
        dec: Angle.Degrees(+10.14881290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103383"},
        {"Smithsonian Astrophysical Observation", "SAO 126393"},
    },
    visualMagnitude: 8.97,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.18425811),
        dec: Angle.Degrees(+10.15085468)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120316"},
        {"Hipparcos Number", "HIP 67377"},
        {"Smithsonian Astrophysical Observation", "SAO 100717"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.13832619),
        dec: Angle.Degrees(+10.15099847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 77.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31295"},
        {"Hipparcos Number", "HIP 22845"},
        {"Celescope Catalog", "CEL 485"},
        {"Geneva Identification System", "GEN# +1.00031295"},
        {"Smithsonian Astrophysical Observation", "SAO 94201"},
        {"Wilson Evans Batten Catalogue", "WEB 4425"},
    },
    visualMagnitude: 4.64,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.72376720),
        dec: Angle.Degrees(+10.15114511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -128.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192609"},
        {"Hipparcos Number", "HIP 99843"},
        {"Geneva Identification System", "GEN# +1.00192609"},
        {"Smithsonian Astrophysical Observation", "SAO 125614"},
        {"Wilson Evans Batten Catalogue", "WEB 17947"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.85051793),
        dec: Angle.Degrees(+10.15341045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53170"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.15965498),
        dec: Angle.Degrees(+10.15361259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286727"},
        {"Hipparcos Number", "HIP 20135"},
    },
    visualMagnitude: 9.63,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.75437318),
        dec: Angle.Degrees(+10.15420699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82215"},
        {"Hipparcos Number", "HIP 46681"},
        {"Geneva Identification System", "GEN# +1.00082215"},
        {"Smithsonian Astrophysical Observation", "SAO 98621"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.75533769),
        dec: Angle.Degrees(+10.15539439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210717"},
        {"Hipparcos Number", "HIP 109604"},
        {"Smithsonian Astrophysical Observation", "SAO 127365"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.03767040),
        dec: Angle.Degrees(+10.15541501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204818"},
        {"Hipparcos Number", "HIP 106221"},
        {"Geneva Identification System", "GEN# +1.00204818"},
        {"Smithsonian Astrophysical Observation", "SAO 126856"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.72378669),
        dec: Angle.Degrees(+10.15670575)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54556",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8077 AB"},
        {"Henry Draper", "HD 96936"},
        {"Hipparcos Number", "HIP 54556"},
        {"Smithsonian Astrophysical Observation", "SAO 99474"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.45089327),
        dec: Angle.Degrees(+10.15736202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93687"},
        {"Hipparcos Number", "HIP 52893"},
        {"Smithsonian Astrophysical Observation", "SAO 99302"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.26367791),
        dec: Angle.Degrees(+10.15793348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114698",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 114698"},
        {"Smithsonian Astrophysical Observation", "SAO 128054"},
    },
    visualMagnitude: 9.40,
    bvColour: 1.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.52390450),
        dec: Angle.Degrees(+10.16081848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3317 A"},
        {"Henry Draper", "HD 29140"},
        {"Hipparcos Number", "HIP 21402"},
        {"Celescope Catalog", "CEL 435"},
        {"Geneva Identification System", "GEN# +1.00029140"},
        {"Renson", "Renson 7450"},
        {"Smithsonian Astrophysical Observation", "SAO 94026"},
        {"Wilson Evans Batten Catalogue", "WEB 4109"},
    },
    visualMagnitude: 4.25,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.91347315),
        dec: Angle.Degrees(+10.16091706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18330"},
        {"Hipparcos Number", "HIP 13750"},
        {"Geneva Identification System", "GEN# +1.00018330"},
        {"Smithsonian Astrophysical Observation", "SAO 110862"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.604,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.25278648),
        dec: Angle.Degrees(+10.16222460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152614"},
        {"Hipparcos Number", "HIP 82673"},
        {"Fundamental Katalog 5th Edition", "FK5 1442"},
        {"Geneva Identification System", "GEN# +1.00152614"},
        {"Smithsonian Astrophysical Observation", "SAO 102458"},
        {"Wilson Evans Batten Catalogue", "WEB 13963"},
    },
    visualMagnitude: 4.39,
    bvColour: -0.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.50209743),
        dec: Angle.Degrees(+10.16544339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5483"},
        {"Hipparcos Number", "HIP 4431"},
        {"Smithsonian Astrophysical Observation", "SAO 109541"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.18240473),
        dec: Angle.Degrees(+10.16588307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46265"},
        {"Hipparcos Number", "HIP 31208"},
        {"Smithsonian Astrophysical Observation", "SAO 95816"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.935,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.20231265),
        dec: Angle.Degrees(+10.16610022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25205"},
        {"Hipparcos Number", "HIP 18715"},
        {"Smithsonian Astrophysical Observation", "SAO 93717"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.180,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.13579527),
        dec: Angle.Degrees(+10.16751151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44618"},
        {"Hipparcos Number", "HIP 30353"},
        {"Smithsonian Astrophysical Observation", "SAO 95607"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.77219016),
        dec: Angle.Degrees(+10.16773115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30392"},
        {"Hipparcos Number", "HIP 22258"},
        {"Celescope Catalog", "CEL 465"},
        {"Geneva Identification System", "GEN# +1.00030392"},
        {"Smithsonian Astrophysical Observation", "SAO 94121"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.87974770),
        dec: Angle.Degrees(+10.16939786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95924",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183705"},
        {"Hipparcos Number", "HIP 95924"},
        {"Smithsonian Astrophysical Observation", "SAO 104912"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.62931888),
        dec: Angle.Degrees(+10.17083209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163910"},
        {"Hipparcos Number", "HIP 87976"},
        {"Smithsonian Astrophysical Observation", "SAO 103256"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.56865095),
        dec: Angle.Degrees(+10.17093878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17762",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17762"},
        {"Smithsonian Astrophysical Observation", "SAO 93610"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.03885896),
        dec: Angle.Degrees(+10.17262380)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203842"},
        {"Hipparcos Number", "HIP 105695"},
        {"Geneva Identification System", "GEN# +1.00203842"},
        {"Smithsonian Astrophysical Observation", "SAO 126774"},
        {"Wilson Evans Batten Catalogue", "WEB 19182"},
    },
    visualMagnitude: 6.33,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.10217554),
        dec: Angle.Degrees(+10.17420266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17472",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23314"},
        {"Hipparcos Number", "HIP 17472"},
        {"Cincinnati Publication", "Ci 18 502"},
        {"Geneva Identification System", "GEN# +1.00023314"},
        {"Smithsonian Astrophysical Observation", "SAO 93577"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.16440976),
        dec: Angle.Degrees(+10.17850521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175056"},
        {"Hipparcos Number", "HIP 92693"},
        {"Smithsonian Astrophysical Observation", "SAO 104218"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.30800545),
        dec: Angle.Degrees(+10.17926985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222962"},
        {"Hipparcos Number", "HIP 117173"},
        {"Geneva Identification System", "GEN# +1.00222962"},
        {"Renson", "Renson 61143"},
        {"Smithsonian Astrophysical Observation", "SAO 128365"},
        {"Wilson Evans Batten Catalogue", "WEB 20650"},
    },
    visualMagnitude: 6.54,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.34069642),
        dec: Angle.Degrees(+10.17985386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205921"},
        {"Hipparcos Number", "HIP 106839"},
        {"Geneva Identification System", "GEN# +1.00205921"},
        {"Smithsonian Astrophysical Observation", "SAO 126953"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.59895154),
        dec: Angle.Degrees(+10.18456549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16830",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2639 AB"},
        {"Henry Draper", "HD 22376"},
        {"Hipparcos Number", "HIP 16830"},
        {"Smithsonian Astrophysical Observation", "SAO 93512"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.12852165),
        dec: Angle.Degrees(+10.18547773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 240534"},
        {"Hipparcos Number", "HIP 23599"},
        {"Geneva Identification System", "GEN# +1.00240534"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.11133583),
        dec: Angle.Degrees(+10.18703664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 112.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -94.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68835"},
        {"Hipparcos Number", "HIP 40372"},
        {"Geneva Identification System", "GEN# +1.00068835"},
        {"Smithsonian Astrophysical Observation", "SAO 97672"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.63323912),
        dec: Angle.Degrees(+10.18830098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101820",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196572"},
        {"Hipparcos Number", "HIP 101820"},
        {"Smithsonian Astrophysical Observation", "SAO 106328"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.50583810),
        dec: Angle.Degrees(+10.18897684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2235",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2454"},
        {"Hipparcos Number", "HIP 2235"},
        {"Fundamental Katalog 5th Edition", "FK5 2028"},
        {"Geneva Identification System", "GEN# +1.00002454"},
        {"Renson", "Renson 570"},
        {"Smithsonian Astrophysical Observation", "SAO 109224"},
        {"Wilson Evans Batten Catalogue", "WEB 415"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.08346734),
        dec: Angle.Degrees(+10.19034140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34224"},
        {"Hipparcos Number", "HIP 24561"},
        {"Smithsonian Astrophysical Observation", "SAO 94427"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.04426527),
        dec: Angle.Degrees(+10.19131732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57290"},
        {"Hipparcos Number", "HIP 35619"},
        {"Smithsonian Astrophysical Observation", "SAO 96803"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.25258346),
        dec: Angle.Degrees(+10.19565738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85006",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157360"},
        {"Hipparcos Number", "HIP 85006"},
        {"Smithsonian Astrophysical Observation", "SAO 102775"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.61499611),
        dec: Angle.Degrees(+10.19605819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34828",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55233"},
        {"Hipparcos Number", "HIP 34828"},
        {"Smithsonian Astrophysical Observation", "SAO 96624"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.12399004),
        dec: Angle.Degrees(+10.19791890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15228"},
        {"Hipparcos Number", "HIP 11427"},
        {"Geneva Identification System", "GEN# +1.00015228"},
        {"Smithsonian Astrophysical Observation", "SAO 110537"},
        {"Wilson Evans Batten Catalogue", "WEB 2386"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.84818295),
        dec: Angle.Degrees(+10.19881767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -294.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -202.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1463",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1463"},
    },
    visualMagnitude: 10.88,
    bvColour: 1.479,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.56912088),
        dec: Angle.Degrees(+10.20286093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190232"},
        {"Hipparcos Number", "HIP 98777"},
        {"Smithsonian Astrophysical Observation", "SAO 105617"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.91896906),
        dec: Angle.Degrees(+10.20410598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55250",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55250"},
        {"Smithsonian Astrophysical Observation", "SAO 99550"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.73055001),
        dec: Angle.Degrees(+10.20503066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118266"},
        {"Hipparcos Number", "HIP 66326"},
        {"Geneva Identification System", "GEN# +1.00118266A"},
        {"Smithsonian Astrophysical Observation", "SAO 100630"},
        {"Wilson Evans Batten Catalogue", "WEB 11717"},
    },
    visualMagnitude: 6.48,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88905155),
        dec: Angle.Degrees(+10.20508940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188652"},
        {"Hipparcos Number", "HIP 98079"},
        {"Geneva Identification System", "GEN# +1.00188652"},
        {"Smithsonian Astrophysical Observation", "SAO 105431"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.98824653),
        dec: Angle.Degrees(+10.20717850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206557"},
        {"Hipparcos Number", "HIP 107184"},
        {"Smithsonian Astrophysical Observation", "SAO 127009"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.65414565),
        dec: Angle.Degrees(+10.20779825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287234"},
        {"Hipparcos Number", "HIP 22893"},
        {"Geneva Identification System", "GEN# +5.20250147"},
        {"Smithsonian Astrophysical Observation", "SAO 94209"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.85935257),
        dec: Angle.Degrees(+10.20832068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287449"},
        {"Hipparcos Number", "HIP 23388"},
    },
    visualMagnitude: 10.07,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.41236160),
        dec: Angle.Degrees(+10.20980030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18556"},
        {"Hipparcos Number", "HIP 13918"},
        {"Geneva Identification System", "GEN# +1.00018556"},
        {"Smithsonian Astrophysical Observation", "SAO 93223"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.82331491),
        dec: Angle.Degrees(+10.21030915)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96479"},
        {"Hipparcos Number", "HIP 54356"},
        {"Geneva Identification System", "GEN# +1.00096479"},
        {"Smithsonian Astrophysical Observation", "SAO 99455"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.80527527),
        dec: Angle.Degrees(+10.21226857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180165"},
        {"Hipparcos Number", "HIP 94612"},
        {"Smithsonian Astrophysical Observation", "SAO 104649"},
        {"Wilson Evans Batten Catalogue", "WEB 16488"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.80679109),
        dec: Angle.Degrees(+10.21239398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26676"},
        {"Hipparcos Number", "HIP 19720"},
        {"Geneva Identification System", "GEN# +1.00026676"},
        {"Smithsonian Astrophysical Observation", "SAO 93821"},
        {"Wilson Evans Batten Catalogue", "WEB 3760"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.39397797),
        dec: Angle.Degrees(+10.21251930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223391"},
        {"Hipparcos Number", "HIP 117468"},
        {"Smithsonian Astrophysical Observation", "SAO 128398"},
    },
    visualMagnitude: 8.84,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.28691288),
        dec: Angle.Degrees(+10.21345198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11035"},
        {"Hipparcos Number", "HIP 8416"},
        {"Geneva Identification System", "GEN# +1.00011035"},
        {"Smithsonian Astrophysical Observation", "SAO 110140"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.14696802),
        dec: Angle.Degrees(+10.21475549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72479",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9397 AB"},
        {"Aitken 2", "ADS 9397"},
        {"Henry Draper", "HD 130669"},
        {"Hipparcos Number", "HIP 72479"},
        {"Cincinnati Publication", "Ci 18 1957"},
        {"Geneva Identification System", "GEN# +1.00130669J"},
        {"Smithsonian Astrophysical Observation", "SAO 101229"},
        {"Wilson Evans Batten Catalogue", "WEB 12455"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.866,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.30709695),
        dec: Angle.Degrees(+10.21491227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -139.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -184.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222558"},
        {"Hipparcos Number", "HIP 116886"},
        {"Smithsonian Astrophysical Observation", "SAO 128331"},
    },
    visualMagnitude: 9.91,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.38962006),
        dec: Angle.Degrees(+10.21587170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54927",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54927"},
    },
    visualMagnitude: 9.87,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.72236052),
        dec: Angle.Degrees(+10.21603483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49143",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49143"},
        {"Smithsonian Astrophysical Observation", "SAO 98905"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.44506622),
        dec: Angle.Degrees(+10.21603596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134854"},
        {"Hipparcos Number", "HIP 74359"},
        {"Smithsonian Astrophysical Observation", "SAO 101423"},
        {"Wilson Evans Batten Catalogue", "WEB 12690"},
    },
    visualMagnitude: 6.89,
    bvColour: 0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.94885092),
        dec: Angle.Degrees(+10.21652330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81794"},
        {"Hipparcos Number", "HIP 46431"},
        {"Smithsonian Astrophysical Observation", "SAO 98588"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.242,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.02958469),
        dec: Angle.Degrees(+10.21795217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40632"},
        {"Hipparcos Number", "HIP 28456"},
        {"Smithsonian Astrophysical Observation", "SAO 95108"},
        {"Wilson Evans Batten Catalogue", "WEB 5562"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.11811652),
        dec: Angle.Degrees(+10.21805981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216417"},
        {"Hipparcos Number", "HIP 112960"},
        {"Geneva Identification System", "GEN# +1.00216417"},
        {"Smithsonian Astrophysical Observation", "SAO 127815"},
    },
    visualMagnitude: 7.26,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.15032148),
        dec: Angle.Degrees(+10.22054815)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 166.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84418"},
        {"Hipparcos Number", "HIP 47880"},
        {"Smithsonian Astrophysical Observation", "SAO 98747"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.36930063),
        dec: Angle.Degrees(+10.22194941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80981",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80981"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.06406773),
        dec: Angle.Degrees(+10.22277752)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -131.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 163.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66328",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 66328"},
        {"Geneva Identification System", "GEN# +1.00118266B"},
        {"Geneva Identification System 2", "GEN# +0.01002566"},
        {"Smithsonian Astrophysical Observation", "SAO 100631"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.89428095),
        dec: Angle.Degrees(+10.22386331)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17383"},
        {"Hipparcos Number", "HIP 13043"},
        {"Smithsonian Astrophysical Observation", "SAO 93110"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.90604489),
        dec: Angle.Degrees(+10.22637001)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40086"},
        {"Hipparcos Number", "HIP 28171"},
        {"Smithsonian Astrophysical Observation", "SAO 95037"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.28574555),
        dec: Angle.Degrees(+10.22936943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13042",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13042"},
    },
    visualMagnitude: 10.63,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.90078911),
        dec: Angle.Degrees(+10.23053858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 249622"},
        {"Hipparcos Number", "HIP 28175"},
        {"Smithsonian Astrophysical Observation", "SAO 95040"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.29427523),
        dec: Angle.Degrees(+10.23293041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16615",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22061"},
        {"Hipparcos Number", "HIP 16615"},
        {"Smithsonian Astrophysical Observation", "SAO 93492"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.45390458),
        dec: Angle.Degrees(+10.23382033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103109",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103109"},
        {"Smithsonian Astrophysical Observation", "SAO 106621"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.36224554),
        dec: Angle.Degrees(+10.23451350)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121214"},
        {"Hipparcos Number", "HIP 67862"},
        {"Geneva Identification System", "GEN# +1.00121214"},
        {"Smithsonian Astrophysical Observation", "SAO 100759"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.48923863),
        dec: Angle.Degrees(+10.23557274)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110411"},
        {"Hipparcos Number", "HIP 61960"},
        {"Fundamental Katalog 5th Edition", "FK5 1326"},
        {"Geneva Identification System", "GEN# +1.00110411"},
        {"Smithsonian Astrophysical Observation", "SAO 100211"},
        {"Wilson Evans Batten Catalogue", "WEB 11018"},
    },
    visualMagnitude: 4.88,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.47086482),
        dec: Angle.Degrees(+10.23584294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71022",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71022"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.809,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.88043225),
        dec: Angle.Degrees(+10.23719736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54227",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 54227"},
    },
    visualMagnitude: 12.37,
    bvColour: 1.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.42822280),
        dec: Angle.Degrees(+10.23765432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 618.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -698.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30866",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 258038"},
        {"Hipparcos Number", "HIP 30866"},
        {"Smithsonian Astrophysical Observation", "SAO 95727"},
    },
    visualMagnitude: 9.06,
    bvColour: 1.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.20388895),
        dec: Angle.Degrees(+10.23890196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82909",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10268 AB"},
        {"Henry Draper", "HD 152995"},
        {"Hipparcos Number", "HIP 82909"},
        {"Smithsonian Astrophysical Observation", "SAO 102486"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.13906752),
        dec: Angle.Degrees(+10.23930009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26215",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4181 A"},
        {"Henry Draper", "HD 36881"},
        {"Henry Draper 2", "HD 36881A"},
        {"Hipparcos Number", "HIP 26215"},
        {"Celescope Catalog", "CEL 815"},
        {"Geneva Identification System", "GEN# +1.00036881"},
        {"Renson", "Renson 9680"},
        {"Smithsonian Astrophysical Observation", "SAO 94671"},
        {"Wilson Evans Batten Catalogue", "WEB 5117"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80516163),
        dec: Angle.Degrees(+10.24010204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108963",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209615"},
        {"Hipparcos Number", "HIP 108963"},
        {"Smithsonian Astrophysical Observation", "SAO 127267"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.936,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.12962440),
        dec: Angle.Degrees(+10.24034692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139457"},
        {"Hipparcos Number", "HIP 76543"},
        {"Fundamental Katalog 5th Edition", "FK5 5381"},
        {"Geneva Identification System", "GEN# +1.00139457"},
        {"Smithsonian Astrophysical Observation", "SAO 101658"},
        {"Wilson Evans Batten Catalogue", "WEB 12993"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.49638264),
        dec: Angle.Degrees(+10.24074306)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 135.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -356.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94103",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178717"},
        {"Hipparcos Number", "HIP 94103"},
        {"Geneva Identification System", "GEN# +1.00178717"},
        {"Smithsonian Astrophysical Observation", "SAO 104535"},
        {"Wilson Evans Batten Catalogue", "WEB 16386"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.34168344),
        dec: Angle.Degrees(+10.24115819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1810",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1810"},
    },
    visualMagnitude: 9.66,
    bvColour: 1.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.73964961),
        dec: Angle.Degrees(+10.24147581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69160",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123760"},
        {"Hipparcos Number", "HIP 69160"},
        {"Geneva Identification System", "GEN# +1.00123760"},
        {"Smithsonian Astrophysical Observation", "SAO 100878"},
        {"Wilson Evans Batten Catalogue", "WEB 12072"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.656,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.36077259),
        dec: Angle.Degrees(+10.24392553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -93.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67960"},
        {"Hipparcos Number", "HIP 40042"},
        {"Smithsonian Astrophysical Observation", "SAO 97626"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.69306150),
        dec: Angle.Degrees(+10.24428562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18718"},
        {"Hipparcos Number", "HIP 14039"},
        {"Smithsonian Astrophysical Observation", "SAO 93234"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.20458144),
        dec: Angle.Degrees(+10.24432086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4491 AB"},
        {"Henry Draper", "HD 39612"},
        {"Hipparcos Number", "HIP 27895"},
        {"Smithsonian Astrophysical Observation", "SAO 94975"},
    },
    visualMagnitude: 7.04,
    bvColour: 0.867,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.53969033),
        dec: Angle.Degrees(+10.24443803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10502"},
        {"Hipparcos Number", "HIP 7987"},
        {"Smithsonian Astrophysical Observation", "SAO 110082"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.64933110),
        dec: Angle.Degrees(+10.24460670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1339",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1255"},
        {"Hipparcos Number", "HIP 1339"},
        {"Smithsonian Astrophysical Observation", "SAO 109102"},
        {"Wilson Evans Batten Catalogue", "WEB 241"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.864,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.19031758),
        dec: Angle.Degrees(+10.24475802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58072"},
        {"Hipparcos Number", "HIP 35929"},
        {"Geneva Identification System", "GEN# +1.00058072"},
        {"Smithsonian Astrophysical Observation", "SAO 96868"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.10241119),
        dec: Angle.Degrees(+10.24569021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6530",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6530"},
    },
    visualMagnitude: 11.83,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.97263642),
        dec: Angle.Degrees(+10.24778459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29537",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4823 AB"},
        {"Henry Draper", "HD 42859"},
        {"Hipparcos Number", "HIP 29537"},
        {"Smithsonian Astrophysical Observation", "SAO 95399"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.36476686),
        dec: Angle.Degrees(+10.24803607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121249"},
        {"Hipparcos Number", "HIP 67882"},
        {"Cincinnati Publication", "Ci 18 1816"},
        {"Geneva Identification System", "GEN# +1.00121249"},
        {"Smithsonian Astrophysical Observation", "SAO 100763"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.54389869),
        dec: Angle.Degrees(+10.24849146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -210.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71962",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129583"},
        {"Hipparcos Number", "HIP 71962"},
        {"Smithsonian Astrophysical Observation", "SAO 101166"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.426,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.76995531),
        dec: Angle.Degrees(+10.24869816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202835"},
        {"Hipparcos Number", "HIP 105170"},
        {"Smithsonian Astrophysical Observation", "SAO 107009"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.56983480),
        dec: Angle.Degrees(+10.24890840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 136.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25677",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 25677"},
    },
    visualMagnitude: 10.98,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.25855458),
        dec: Angle.Degrees(+10.24947303)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 122.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39490",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66530"},
        {"Hipparcos Number", "HIP 39490"},
        {"Geneva Identification System", "GEN# +1.00066530"},
        {"Smithsonian Astrophysical Observation", "SAO 97531"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.08802486),
        dec: Angle.Degrees(+10.24958424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92548",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 92548"},
        {"New General Catalogue", "NGC 6709 7"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.89545866),
        dec: Angle.Degrees(+10.25044726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115230"},
        {"Hipparcos Number", "HIP 64707"},
        {"Smithsonian Astrophysical Observation", "SAO 100481"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.93385508),
        dec: Angle.Degrees(+10.25045259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39210"},
        {"Hipparcos Number", "HIP 27664"},
        {"Geneva Identification System", "GEN# +1.00039210"},
        {"Smithsonian Astrophysical Observation", "SAO 94930"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.86283970),
        dec: Angle.Degrees(+10.25247831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37620"},
        {"Hipparcos Number", "HIP 26680"},
        {"Fundamental Katalog 5th Edition", "FK5 4515"},
        {"Geneva Identification System", "GEN# +1.00037620"},
        {"Smithsonian Astrophysical Observation", "SAO 94745"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.04886501),
        dec: Angle.Degrees(+10.25275791)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80372",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147928"},
        {"Hipparcos Number", "HIP 80372"},
        {"Smithsonian Astrophysical Observation", "SAO 102139"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10055052),
        dec: Angle.Degrees(+10.25435101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4113 AB"},
        {"Henry Draper", "HD 36263"},
        {"Hipparcos Number", "HIP 25826"},
        {"Celescope Catalog", "CEL 743"},
        {"Geneva Identification System", "GEN# +1.00036263J"},
        {"Smithsonian Astrophysical Observation", "SAO 94602"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.71569397),
        dec: Angle.Degrees(+10.25438611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63877",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113716"},
        {"Hipparcos Number", "HIP 63877"},
        {"Geneva Identification System", "GEN# +1.00113716"},
        {"Smithsonian Astrophysical Observation", "SAO 100405"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.36791956),
        dec: Angle.Degrees(+10.25709501)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47072"},
        {"Smithsonian Astrophysical Observation", "SAO 98660"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.89469447),
        dec: Angle.Degrees(+10.25733761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4626"},
        {"Hipparcos Number", "HIP 3761"},
        {"Smithsonian Astrophysical Observation", "SAO 109469"},
    },
    visualMagnitude: 8.76,
    bvColour: 1.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.07234158),
        dec: Angle.Degrees(+10.25803278)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123804"},
        {"Hipparcos Number", "HIP 69180"},
        {"Geneva Identification System", "GEN# +1.00123804"},
        {"Smithsonian Astrophysical Observation", "SAO 100881"},
    },
    visualMagnitude: 7.93,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.41182742),
        dec: Angle.Degrees(+10.25856628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85720"},
        {"Hipparcos Number", "HIP 48540"},
        {"Smithsonian Astrophysical Observation", "SAO 98835"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.49293977),
        dec: Angle.Degrees(+10.25882312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37478"},
        {"Hipparcos Number", "HIP 26604"},
        {"Smithsonian Astrophysical Observation", "SAO 94729"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.694,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.82162739),
        dec: Angle.Degrees(+10.25992400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159522"},
        {"Hipparcos Number", "HIP 86027"},
        {"Smithsonian Astrophysical Observation", "SAO 102930"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.71629519),
        dec: Angle.Degrees(+10.26003911)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106251"},
        {"Hipparcos Number", "HIP 59608"},
        {"Fundamental Katalog 5th Edition", "FK5 2978"},
        {"Geneva Identification System", "GEN# +1.00106251"},
        {"Renson", "Renson 30740"},
        {"Smithsonian Astrophysical Observation", "SAO 99997"},
        {"Wilson Evans Batten Catalogue", "WEB 10594"},
    },
    visualMagnitude: 5.85,
    bvColour: 0.262,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.35831031),
        dec: Angle.Degrees(+10.26236039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28505"},
        {"Hipparcos Number", "HIP 20985"},
        {"Geneva Identification System", "GEN# +1.00028505"},
        {"Smithsonian Astrophysical Observation", "SAO 93971"},
        {"Wilson Evans Batten Catalogue", "WEB 4036"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.50960322),
        dec: Angle.Degrees(+10.26240493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53662"},
        {"Hipparcos Number", "HIP 34272"},
        {"Geneva Identification System", "GEN# +1.00053662"},
        {"Renson", "Renson 14740"},
        {"Smithsonian Astrophysical Observation", "SAO 96491"},
    },
    visualMagnitude: 8.69,
    bvColour: -0.064,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.57085689),
        dec: Angle.Degrees(+10.26711411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3150",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3714"},
        {"Hipparcos Number", "HIP 3150"},
        {"Geneva Identification System", "GEN# +1.00003714"},
        {"Smithsonian Astrophysical Observation", "SAO 109358"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.00998328),
        dec: Angle.Degrees(+10.26718334)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109033"},
        {"Hipparcos Number", "HIP 61129"},
        {"Geneva Identification System", "GEN# +1.00109033"},
        {"Smithsonian Astrophysical Observation", "SAO 100139"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.90484587),
        dec: Angle.Degrees(+10.26760161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -191.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -101.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146539"},
        {"Hipparcos Number", "HIP 79744"},
        {"Smithsonian Astrophysical Observation", "SAO 102052"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.12427125),
        dec: Angle.Degrees(+10.26807260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89806",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11260"},
        {"Aitken 2", "ADS 11260 AB"},
        {"Henry Draper", "HD 168499"},
        {"Hipparcos Number", "HIP 89806"},
        {"Geneva Identification System", "GEN# +1.00168499J"},
        {"Smithsonian Astrophysical Observation", "SAO 103612"},
        {"Wilson Evans Batten Catalogue", "WEB 15325"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.91742474),
        dec: Angle.Degrees(+10.27200499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -110.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14866"},
        {"Hipparcos Number", "HIP 11194"},
        {"Smithsonian Astrophysical Observation", "SAO 92922"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.04314391),
        dec: Angle.Degrees(+10.27251762)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218054"},
        {"Hipparcos Number", "HIP 113973"},
        {"Smithsonian Astrophysical Observation", "SAO 108381"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.907,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.22513154),
        dec: Angle.Degrees(+10.27308822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 119.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 111.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 287081"},
        {"Hipparcos Number", "HIP 22129"},
        {"Smithsonian Astrophysical Observation", "SAO 94105"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.439,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.43619203),
        dec: Angle.Degrees(+10.27430208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5092"},
        {"Geneva Identification System", "GEN# +0.00900124"},
        {"Renson", "Renson 1640"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.30230739),
        dec: Angle.Degrees(+10.27467675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112380",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112380"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.41892477),
        dec: Angle.Degrees(+10.27616419)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55811",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55811"},
        {"Smithsonian Astrophysical Observation", "SAO 99603"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.55644852),
        dec: Angle.Degrees(+10.27800945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7392",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 7392"},
    },
    visualMagnitude: 12.23,
    bvColour: 1.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.82904296),
        dec: Angle.Degrees(+10.27850061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -137.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117235",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117235"},
        {"Cincinnati Publication", "Ci 18 3118"},
    },
    visualMagnitude: 11.78,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.57503939),
        dec: Angle.Degrees(+10.27888395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107145",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107145"},
    },
    visualMagnitude: 10.28,
    bvColour: 0.807,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.54680600),
        dec: Angle.Degrees(+10.27986125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 102.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 98935"},
    },
    visualMagnitude: 10.93,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.32769137),
        dec: Angle.Degrees(+10.28077111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43299"},
        {"Hipparcos Number", "HIP 29752"},
        {"Geneva Identification System", "GEN# +1.00043299"},
        {"Smithsonian Astrophysical Observation", "SAO 95460"},
    },
    visualMagnitude: 6.84,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.98540048),
        dec: Angle.Degrees(+10.28180869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41613"},
        {"Smithsonian Astrophysical Observation", "SAO 97847"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.25616214),
        dec: Angle.Degrees(+10.28326389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150268"},
        {"Hipparcos Number", "HIP 81564"},
        {"Smithsonian Astrophysical Observation", "SAO 102296"},
    },
    visualMagnitude: 8.13,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.87874363),
        dec: Angle.Degrees(+10.28335485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146790"},
        {"Hipparcos Number", "HIP 79841"},
        {"Smithsonian Astrophysical Observation", "SAO 102066"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.45331382),
        dec: Angle.Degrees(+10.28478766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46883"},
        {"Hipparcos Number", "HIP 31542"},
        {"Geneva Identification System", "GEN# +1.00046883"},
        {"Smithsonian Astrophysical Observation", "SAO 95893"},
        {"Wilson Evans Batten Catalogue", "WEB 6312"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.04051173),
        dec: Angle.Degrees(+10.28488680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42770"},
        {"Hipparcos Number", "HIP 29508"},
        {"Celescope Catalog", "CEL 1122"},
        {"Geneva Identification System", "GEN# +1.00042770"},
        {"Smithsonian Astrophysical Observation", "SAO 95389"},
    },
    visualMagnitude: 6.60,
    bvColour: -0.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.24749691),
        dec: Angle.Degrees(+10.28743069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51626",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51626"},
        {"Smithsonian Astrophysical Observation", "SAO 99177"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.20316063),
        dec: Angle.Degrees(+10.29097654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9904",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9904"},
    },
    visualMagnitude: 11.28,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.87177645),
        dec: Angle.Degrees(+10.29135548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 174.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -71.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286823"},
        {"Hipparcos Number", "HIP 20832"},
    },
    visualMagnitude: 10.50,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.96510006),
        dec: Angle.Degrees(+10.29151224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7107"},
        {"Hipparcos Number", "HIP 5575"},
        {"Fundamental Katalog 5th Edition", "FK5 2079"},
        {"Geneva Identification System", "GEN# +1.00007107"},
        {"Smithsonian Astrophysical Observation", "SAO 92304"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.87069076),
        dec: Angle.Degrees(+10.29192297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107951"},
        {"Hipparcos Number", "HIP 60510"},
        {"Smithsonian Astrophysical Observation", "SAO 100081"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.06979380),
        dec: Angle.Degrees(+10.29192988)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61246",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109217"},
        {"Hipparcos Number", "HIP 61246"},
        {"Fundamental Katalog 5th Edition", "FK5 3004"},
        {"Geneva Identification System", "GEN# +1.00109217"},
        {"Smithsonian Astrophysical Observation", "SAO 100146"},
        {"Wilson Evans Batten Catalogue", "WEB 10898"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.26211970),
        dec: Angle.Degrees(+10.29566078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133995"},
        {"Hipparcos Number", "HIP 73986"},
        {"Geneva Identification System", "GEN# +1.00133995"},
        {"Smithsonian Astrophysical Observation", "SAO 101376"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.312,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.80500883),
        dec: Angle.Degrees(+10.29596801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217455"},
        {"Hipparcos Number", "HIP 113619"},
        {"Geneva Identification System", "GEN# +1.00217455"},
        {"Smithsonian Astrophysical Observation", "SAO 108328"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.17457053),
        dec: Angle.Degrees(+10.29642766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164988"},
        {"Hipparcos Number", "HIP 88448"},
        {"Smithsonian Astrophysical Observation", "SAO 103335"},
    },
    visualMagnitude: 7.99,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.87422145),
        dec: Angle.Degrees(+10.29664776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78055",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142798"},
        {"Hipparcos Number", "HIP 78055"},
        {"Smithsonian Astrophysical Observation", "SAO 101823"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.05036684),
        dec: Angle.Degrees(+10.29743216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88501"},
        {"Hipparcos Number", "HIP 50009"},
        {"Smithsonian Astrophysical Observation", "SAO 99003"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.14199087),
        dec: Angle.Degrees(+10.29751927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2695",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3088"},
        {"Hipparcos Number", "HIP 2695"},
        {"Geneva Identification System", "GEN# +1.00003088"},
        {"Smithsonian Astrophysical Observation", "SAO 91971"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.949,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.54482241),
        dec: Angle.Degrees(+10.29958061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124864"},
        {"Hipparcos Number", "HIP 69684"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.96040201),
        dec: Angle.Degrees(+10.30035814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102511",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102511"},
    },
    visualMagnitude: 11.09,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.62501728),
        dec: Angle.Degrees(+10.30178128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195274"},
        {"Hipparcos Number", "HIP 101125"},
        {"Smithsonian Astrophysical Observation", "SAO 106164"},
        {"Wilson Evans Batten Catalogue", "WEB 18264"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.060,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.48033090),
        dec: Angle.Degrees(+10.30211797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 229700"},
        {"Hipparcos Number", "HIP 92486"},
        {"Geneva Identification System", "GEN# +2.67090372"},
        {"Wilson Evans Batten Catalogue", "WEB 15986"},
        {"New General Catalogue", "NGC 6709 5"},
    },
    visualMagnitude: 10.33,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.74362431),
        dec: Angle.Degrees(+10.30252560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60938"},
        {"Hipparcos Number", "HIP 37092"},
        {"Geneva Identification System", "GEN# +1.00060938"},
        {"Smithsonian Astrophysical Observation", "SAO 97086"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.32854830),
        dec: Angle.Degrees(+10.30323914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154919"},
        {"Hipparcos Number", "HIP 83839"},
        {"Smithsonian Astrophysical Observation", "SAO 102608"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.278,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.01046033),
        dec: Angle.Degrees(+10.30378179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9142",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11981"},
        {"Hipparcos Number", "HIP 9142"},
        {"Smithsonian Astrophysical Observation", "SAO 92726"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.45491686),
        dec: Angle.Degrees(+10.30387774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45512"},
        {"Hipparcos Number", "HIP 30804"},
        {"Geneva Identification System", "GEN# +1.00045512"},
        {"Smithsonian Astrophysical Observation", "SAO 95718"},
        {"Wilson Evans Batten Catalogue", "WEB 6140"},
    },
    visualMagnitude: 6.16,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.07832159),
        dec: Angle.Degrees(+10.30399931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79264"},
        {"Hipparcos Number", "HIP 45255"},
        {"Smithsonian Astrophysical Observation", "SAO 98440"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.34962146),
        dec: Angle.Degrees(+10.30616141)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130355"},
        {"Hipparcos Number", "HIP 72322"},
        {"Geneva Identification System", "GEN# +1.00130355"},
        {"Smithsonian Astrophysical Observation", "SAO 101212"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.84300918),
        dec: Angle.Degrees(+10.30629532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121754"},
        {"Hipparcos Number", "HIP 68156"},
        {"Fundamental Katalog 5th Edition", "FK5 5233"},
        {"Geneva Identification System", "GEN# +1.00121754"},
        {"Smithsonian Astrophysical Observation", "SAO 100786"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.30055250),
        dec: Angle.Degrees(+10.30689294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14360",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14360"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.32282670),
        dec: Angle.Degrees(+10.30846113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44384"},
        {"Smithsonian Astrophysical Observation", "SAO 98309"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.62389619),
        dec: Angle.Degrees(+10.31150509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15401",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15401"},
    },
    visualMagnitude: 12.25,
    bvColour: 1.485,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.64631322),
        dec: Angle.Degrees(+10.31257186)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 286388"},
        {"Hipparcos Number", "HIP 18477"},
        {"Smithsonian Astrophysical Observation", "SAO 93685"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.23098133),
        dec: Angle.Degrees(+10.31426869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35446",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56844"},
        {"Hipparcos Number", "HIP 35446"},
        {"Smithsonian Astrophysical Observation", "SAO 96764"},
    },
    visualMagnitude: 7.37,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.77402394),
        dec: Angle.Degrees(+10.31496034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108091",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108091"},
    },
    visualMagnitude: 9.99,
    bvColour: 1.612,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.49180025),
        dec: Angle.Degrees(+10.31941198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29316",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 29316"},
        {"Cincinnati Publication", "Ci 20 375"},
        {"Geneva Identification System", "GEN# +0.01001032"},
        {"Wilson Evans Batten Catalogue", "WEB 5757"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.72819625),
        dec: Angle.Degrees(+10.32031841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 57.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -926.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
