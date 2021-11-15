using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_57() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38158",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63520"},
        {"Hipparcos Number", "HIP 38158"},
        {"Smithsonian Astrophysical Observation", "SAO 135135"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.29993188),
        dec: Angle.Degrees(-04.65881524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216540"},
        {"Hipparcos Number", "HIP 113056"},
        {"Smithsonian Astrophysical Observation", "SAO 146375"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.43394662),
        dec: Angle.Degrees(-04.65739727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84337"},
        {"Hipparcos Number", "HIP 47781"},
        {"Smithsonian Astrophysical Observation", "SAO 137092"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.12707677),
        dec: Angle.Degrees(-04.65728538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25673"},
        {"Hipparcos Number", "HIP 19007"},
        {"Smithsonian Astrophysical Observation", "SAO 130915"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.08444054),
        dec: Angle.Degrees(-04.65558342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 185.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21215"},
        {"Hipparcos Number", "HIP 15946"},
        {"Geneva Identification System", "GEN# +1.00021215"},
        {"Smithsonian Astrophysical Observation", "SAO 130476"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.33461558),
        dec: Angle.Degrees(-04.65526914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23794",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3698 A"},
        {"Henry Draper", "HD 32964"},
        {"Hipparcos Number", "HIP 23794"},
        {"Geneva Identification System", "GEN# +1.00032964A"},
        {"Renson", "Renson 8410"},
        {"Smithsonian Astrophysical Observation", "SAO 131777"},
        {"Wilson Evans Batten Catalogue", "WEB 4643"},
    },
    visualMagnitude: 5.12,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.69019503),
        dec: Angle.Degrees(-04.65516319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68793"},
        {"Hipparcos Number", "HIP 40323"},
        {"Geneva Identification System", "GEN# +1.00068793"},
        {"Smithsonian Astrophysical Observation", "SAO 135662"},
        {"Wilson Evans Batten Catalogue", "WEB 7862"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.49457028),
        dec: Angle.Degrees(-04.65513060)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23067",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31693"},
        {"Hipparcos Number", "HIP 23067"},
        {"Fundamental Katalog 5th Edition", "FK5 4453"},
        {"Geneva Identification System", "GEN# +1.00031693"},
        {"Smithsonian Astrophysical Observation", "SAO 131634"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.959,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.45155308),
        dec: Angle.Degrees(-04.65490289)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33918"},
        {"Hipparcos Number", "HIP 24345"},
        {"Celescope Catalog", "CEL 573"},
        {"Geneva Identification System", "GEN# +1.00033918"},
        {"Smithsonian Astrophysical Observation", "SAO 131884"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.36935121),
        dec: Angle.Degrees(-04.65286428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135366"},
        {"Hipparcos Number", "HIP 74619"},
        {"Smithsonian Astrophysical Observation", "SAO 140406"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.69469976),
        dec: Angle.Degrees(-04.65205730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128027"},
        {"Hipparcos Number", "HIP 71293"},
        {"Geneva Identification System", "GEN# +1.00128027"},
        {"Smithsonian Astrophysical Observation", "SAO 140010"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.70513768),
        dec: Angle.Degrees(-04.65162496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61581",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109757"},
        {"Hipparcos Number", "HIP 61581"},
        {"Smithsonian Astrophysical Observation", "SAO 138877"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.28860175),
        dec: Angle.Degrees(-04.65100360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5220",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 917 AB"},
        {"Henry Draper", "HD 6604"},
        {"Hipparcos Number", "HIP 5220"},
        {"Smithsonian Astrophysical Observation", "SAO 129123"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.68961983),
        dec: Angle.Degrees(-04.65041249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28267",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4557 A"},
        {"Henry Draper", "HD 40397"},
        {"Hipparcos Number", "HIP 28267"},
        {"Smithsonian Astrophysical Observation", "SAO 132703"},
    },
    visualMagnitude: 6.99,
    bvColour: 0.720,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.58955821),
        dec: Angle.Degrees(-04.65017345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -203.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101756"},
        {"Hipparcos Number", "HIP 57116"},
        {"Smithsonian Astrophysical Observation", "SAO 138361"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.63533462),
        dec: Angle.Degrees(-04.64923942)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5975"},
        {"Hipparcos Number", "HIP 4747"},
        {"Geneva Identification System", "GEN# +1.00005975"},
        {"Smithsonian Astrophysical Observation", "SAO 129081"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.25731681),
        dec: Angle.Degrees(-04.64826368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2024"},
        {"Hipparcos Number", "HIP 1941"},
        {"Smithsonian Astrophysical Observation", "SAO 128744"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.13708970),
        dec: Angle.Degrees(-04.64778091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185124"},
        {"Hipparcos Number", "HIP 96556"},
        {"Geneva Identification System", "GEN# +1.00185124"},
        {"Smithsonian Astrophysical Observation", "SAO 143621"},
        {"Wilson Evans Batten Catalogue", "WEB 16944"},
    },
    visualMagnitude: 5.45,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.44690167),
        dec: Angle.Degrees(-04.64750966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 104.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109761",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210927"},
        {"Hipparcos Number", "HIP 109761"},
        {"Smithsonian Astrophysical Observation", "SAO 145955"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.47618060),
        dec: Angle.Degrees(-04.64424688)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160159"},
        {"Hipparcos Number", "HIP 86341"},
        {"Smithsonian Astrophysical Observation", "SAO 141782"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.65452762),
        dec: Angle.Degrees(-04.64220084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 109388"},
        {"Cincinnati Publication", "Ci 20 1340"},
        {"Geneva Identification System", "GEN# -0.00505715"},
        {"Wilson Evans Batten Catalogue", "WEB 19654"},
    },
    visualMagnitude: 10.41,
    bvColour: 1.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.41534076),
        dec: Angle.Degrees(-04.64068104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1134.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84110",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155424"},
        {"Hipparcos Number", "HIP 84110"},
        {"Smithsonian Astrophysical Observation", "SAO 141550"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.93062668),
        dec: Angle.Degrees(-04.64060901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198111"},
        {"Hipparcos Number", "HIP 102666"},
        {"Smithsonian Astrophysical Observation", "SAO 144824"},
    },
    visualMagnitude: 6.96,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.06482268),
        dec: Angle.Degrees(-04.64016627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139177"},
        {"Hipparcos Number", "HIP 76451"},
        {"Geneva Identification System", "GEN# +1.00139177"},
        {"Smithsonian Astrophysical Observation", "SAO 140647"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.20969696),
        dec: Angle.Degrees(-04.63799046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26908",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38051"},
        {"Hipparcos Number", "HIP 26908"},
        {"Geneva Identification System", "GEN# +1.00038051"},
        {"Smithsonian Astrophysical Observation", "SAO 132475"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.69191835),
        dec: Angle.Degrees(-04.63618829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115700",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115700"},
        {"Smithsonian Astrophysical Observation", "SAO 146706"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.62808409),
        dec: Angle.Degrees(-04.63610230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63634",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 63634"},
        {"Smithsonian Astrophysical Observation", "SAO 139112"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.63280694),
        dec: Angle.Degrees(-04.63458685)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3552",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4301"},
        {"Hipparcos Number", "HIP 3552"},
        {"Geneva Identification System", "GEN# +1.00004301"},
        {"Smithsonian Astrophysical Observation", "SAO 128935"},
        {"Wilson Evans Batten Catalogue", "WEB 629"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.652,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.35043331),
        dec: Angle.Degrees(-04.62925140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175104"},
        {"Hipparcos Number", "HIP 92746"},
        {"Smithsonian Astrophysical Observation", "SAO 142767"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.49970332),
        dec: Angle.Degrees(-04.62715614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34120"},
        {"Hipparcos Number", "HIP 24458"},
        {"Smithsonian Astrophysical Observation", "SAO 131912"},
    },
    visualMagnitude: 9.45,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.71999001),
        dec: Angle.Degrees(-04.62665297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42759",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74244"},
        {"Hipparcos Number", "HIP 42759"},
        {"Fundamental Katalog 5th Edition", "FK5 4782"},
        {"Smithsonian Astrophysical Observation", "SAO 136205"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.70479111),
        dec: Angle.Degrees(-04.62358333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53177"},
        {"Hipparcos Number", "HIP 34072"},
        {"Smithsonian Astrophysical Observation", "SAO 134130"},
    },
    visualMagnitude: 7.44,
    bvColour: 1.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.00022118),
        dec: Angle.Degrees(-04.62350980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53883"},
        {"Hipparcos Number", "HIP 34299"},
        {"Wilson Evans Batten Catalogue", "WEB 6869"},
    },
    visualMagnitude: 9.61,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.65125287),
        dec: Angle.Degrees(-04.62347462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24156"},
        {"Hipparcos Number", "HIP 17987"},
        {"Geneva Identification System", "GEN# +1.00024156"},
        {"Smithsonian Astrophysical Observation", "SAO 130766"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.67331975),
        dec: Angle.Degrees(-04.62173187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -238.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293988"},
        {"Hipparcos Number", "HIP 24752"},
        {"Smithsonian Astrophysical Observation", "SAO 131968"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.61138705),
        dec: Angle.Degrees(-04.62109879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67092",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 67092"},
        {"Geneva Identification System", "GEN# -0.00303527"},
        {"Wilson Evans Batten Catalogue", "WEB 11815"},
    },
    visualMagnitude: 10.54,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.27264197),
        dec: Angle.Degrees(-04.62010875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -159.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43248"},
        {"Hipparcos Number", "HIP 29676"},
        {"Celescope Catalog", "CEL 1143"},
        {"Geneva Identification System", "GEN# +1.00043248"},
        {"Smithsonian Astrophysical Observation", "SAO 133018"},
    },
    visualMagnitude: 8.07,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.78013700),
        dec: Angle.Degrees(-04.61998877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170653"},
        {"Hipparcos Number", "HIP 90737"},
        {"Smithsonian Astrophysical Observation", "SAO 142356"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.70538207),
        dec: Angle.Degrees(-04.61884296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68059",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9058 AB"},
        {"Henry Draper", "HD 121537"},
        {"Hipparcos Number", "HIP 68059"},
        {"Smithsonian Astrophysical Observation", "SAO 139630"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)13, (int)56, 06.3800),
        dec: Angle.DegreesMinutesSeconds((int)-04, (int)37, 00.000)
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
    primaryId: "HIP 28011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39910"},
        {"Hipparcos Number", "HIP 28011"},
        {"Geneva Identification System", "GEN# +1.00039910"},
        {"Smithsonian Astrophysical Observation", "SAO 132652"},
        {"Wilson Evans Batten Catalogue", "WEB 5487"},
    },
    visualMagnitude: 5.87,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.87564797),
        dec: Angle.Degrees(-04.61649597)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171836"},
        {"Hipparcos Number", "HIP 91272"},
        {"Geneva Identification System", "GEN# +1.00171836"},
        {"Smithsonian Astrophysical Observation", "SAO 142432"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.26074159),
        dec: Angle.Degrees(-04.61538392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108506"},
        {"Hipparcos Number", "HIP 60813"},
        {"Fundamental Katalog 5th Edition", "FK5 3001"},
        {"Geneva Identification System", "GEN# +1.00108506"},
        {"Renson", "Renson 31515"},
        {"Smithsonian Astrophysical Observation", "SAO 138798"},
        {"Wilson Evans Batten Catalogue", "WEB 10821"},
    },
    visualMagnitude: 6.23,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.96499562),
        dec: Angle.Degrees(-04.61528240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91772"},
        {"Hipparcos Number", "HIP 51864"},
        {"Smithsonian Astrophysical Observation", "SAO 137662"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.94502929),
        dec: Angle.Degrees(-04.61087415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 146.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113286"},
        {"Hipparcos Number", "HIP 63654"},
        {"Smithsonian Astrophysical Observation", "SAO 139115"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.68940531),
        dec: Angle.Degrees(-04.60907301)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207204"},
        {"Hipparcos Number", "HIP 107585"},
        {"Smithsonian Astrophysical Observation", "SAO 145668"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.85329376),
        dec: Angle.Degrees(-04.60861838)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23144"},
        {"Hipparcos Number", "HIP 17344"},
        {"Smithsonian Astrophysical Observation", "SAO 130678"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.68155441),
        dec: Angle.Degrees(-04.60555869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10195",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10195"},
        {"Smithsonian Astrophysical Observation", "SAO 129734"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.77492527),
        dec: Angle.Degrees(-04.60508635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22206",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22206"},
    },
    visualMagnitude: 10.06,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.63724302),
        dec: Angle.Degrees(-04.60483427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175179"},
        {"Hipparcos Number", "HIP 92781"},
        {"Cincinnati Publication", "Ci 20 1116"},
        {"Cincinnati Publication 2", "Ci 18 2468"},
        {"Geneva Identification System", "GEN# +1.00175179"},
        {"Smithsonian Astrophysical Observation", "SAO 142780"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.586,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.59700238),
        dec: Angle.Degrees(-04.60412415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -430.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137947"},
        {"Hipparcos Number", "HIP 75803"},
        {"Smithsonian Astrophysical Observation", "SAO 140565"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.28874816),
        dec: Angle.Degrees(-04.60243198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48666"},
        {"Hipparcos Number", "HIP 32282"},
        {"Smithsonian Astrophysical Observation", "SAO 133626"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.391,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.09098512),
        dec: Angle.Degrees(-04.60180118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25647"},
        {"Hipparcos Number", "HIP 18985"},
        {"Smithsonian Astrophysical Observation", "SAO 130909"},
    },
    visualMagnitude: 7.28,
    bvColour: 1.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.00929176),
        dec: Angle.Degrees(-04.60051567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173438"},
        {"Hipparcos Number", "HIP 92028"},
        {"Geneva Identification System", "GEN# +1.00173438"},
        {"Smithsonian Astrophysical Observation", "SAO 142589"},
        {"Wilson Evans Batten Catalogue", "WEB 15855"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.36923486),
        dec: Angle.Degrees(-04.59964070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45321"},
        {"Hipparcos Number", "HIP 30660"},
        {"Celescope Catalog", "CEL 1238"},
        {"Geneva Identification System", "GEN# +2.22320002"},
        {"Smithsonian Astrophysical Observation", "SAO 133257"},
        {"Wilson Evans Batten Catalogue", "WEB 6115"},
        {"New General Catalogue", "NGC 2232 2"},
    },
    visualMagnitude: 6.16,
    bvColour: -0.151,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.64352725),
        dec: Angle.Degrees(-04.59739332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20966",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28531"},
        {"Hipparcos Number", "HIP 20966"},
        {"Smithsonian Astrophysical Observation", "SAO 131247"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.43155672),
        dec: Angle.Degrees(-04.59722393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44286"},
        {"Hipparcos Number", "HIP 30167"},
        {"Geneva Identification System", "GEN# +1.00044286"},
        {"Smithsonian Astrophysical Observation", "SAO 133136"},
    },
    visualMagnitude: 6.75,
    bvColour: 0.281,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.21022289),
        dec: Angle.Degrees(-04.59537747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99507",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13476 B"},
        {"Hipparcos Number", "HIP 99507"},
    },
    visualMagnitude: 10.23,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.91525003),
        dec: Angle.Degrees(-04.59328708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57289"},
        {"Smithsonian Astrophysical Observation", "SAO 138386"},
    },
    visualMagnitude: 8.85,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.20777017),
        dec: Angle.Degrees(-04.59280004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150016"},
        {"Hipparcos Number", "HIP 81473"},
        {"Smithsonian Astrophysical Observation", "SAO 141289"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.61225169),
        dec: Angle.Degrees(-04.59172165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8599",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8599"},
    },
    visualMagnitude: 11.79,
    bvColour: 1.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.74215022),
        dec: Angle.Degrees(-04.59121927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 177.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99508",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13476 A"},
        {"Henry Draper", "HD 191750"},
        {"Hipparcos Number", "HIP 99508"},
        {"Smithsonian Astrophysical Observation", "SAO 144156"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.91660683),
        dec: Angle.Degrees(-04.59008377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194227"},
        {"Hipparcos Number", "HIP 100669"},
        {"Smithsonian Astrophysical Observation", "SAO 144394"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.17105972),
        dec: Angle.Degrees(-04.58429015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57184"},
        {"Hipparcos Number", "HIP 35529"},
        {"Smithsonian Astrophysical Observation", "SAO 134522"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.98786156),
        dec: Angle.Degrees(-04.58335085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39254"},
        {"Hipparcos Number", "HIP 27645"},
        {"Geneva Identification System", "GEN# +1.00039254"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.78940433),
        dec: Angle.Degrees(-04.58258920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99226"},
        {"Hipparcos Number", "HIP 55727"},
        {"Smithsonian Astrophysical Observation", "SAO 138191"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(171.27410151),
        dec: Angle.Degrees(-04.58053349)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10316"},
        {"Hipparcos Number", "HIP 7831"},
        {"Smithsonian Astrophysical Observation", "SAO 129441"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.18671019),
        dec: Angle.Degrees(-04.57936584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45658"},
        {"Hipparcos Number", "HIP 30824"},
        {"Geneva Identification System", "GEN# +2.22320011"},
        {"Smithsonian Astrophysical Observation", "SAO 133306"},
        {"New General Catalogue", "NGC 2232 11"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.13773768),
        dec: Angle.Degrees(-04.57897369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9634",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12653"},
        {"Hipparcos Number", "HIP 9634"},
        {"Smithsonian Astrophysical Observation", "SAO 129669"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.95263230),
        dec: Angle.Degrees(-04.57853028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163422"},
        {"Hipparcos Number", "HIP 87807"},
        {"Renson", "Renson 46217"},
        {"Smithsonian Astrophysical Observation", "SAO 141968"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.06261595),
        dec: Angle.Degrees(-04.57635999)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50436"},
        {"Hipparcos Number", "HIP 33059"},
        {"Geneva Identification System", "GEN# +1.00050436"},
        {"Smithsonian Astrophysical Observation", "SAO 133825"},
        {"Wilson Evans Batten Catalogue", "WEB 6658"},
    },
    visualMagnitude: 8.19,
    bvColour: 2.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.29712872),
        dec: Angle.Degrees(-04.57611713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215886"},
        {"Hipparcos Number", "HIP 112617"},
        {"Fundamental Katalog 5th Edition", "FK5 6011"},
        {"Smithsonian Astrophysical Observation", "SAO 146325"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.927,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.12785979),
        dec: Angle.Degrees(-04.57551045)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12970",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17337"},
        {"Hipparcos Number", "HIP 12970"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.70316767),
        dec: Angle.Degrees(-04.57538389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171706"},
        {"Hipparcos Number", "HIP 91215"},
        {"Geneva Identification System", "GEN# +1.00171706"},
        {"Smithsonian Astrophysical Observation", "SAO 142422"},
        {"Wilson Evans Batten Catalogue", "WEB 15668"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.11391403),
        dec: Angle.Degrees(-04.57469980)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -201.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188043"},
        {"Hipparcos Number", "HIP 97872"},
        {"Smithsonian Astrophysical Observation", "SAO 143882"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.848,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.33003723),
        dec: Angle.Degrees(-04.57290697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64732"},
        {"Hipparcos Number", "HIP 38680"},
        {"Smithsonian Astrophysical Observation", "SAO 135253"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.79325562),
        dec: Angle.Degrees(-04.57144063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43072",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43072"},
        {"Smithsonian Astrophysical Observation", "SAO 136264"},
    },
    visualMagnitude: 8.90,
    bvColour: 1.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.59713103),
        dec: Angle.Degrees(-04.57052968)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29629",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4846 AB"},
        {"Henry Draper", "HD 43157"},
        {"Hipparcos Number", "HIP 29629"},
        {"Celescope Catalog", "CEL 1136"},
        {"Geneva Identification System", "GEN# +1.00043157J"},
        {"Smithsonian Astrophysical Observation", "SAO 133003"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.65294439),
        dec: Angle.Degrees(-04.56846315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47965"},
        {"Hipparcos Number", "HIP 31973"},
        {"Geneva Identification System", "GEN# +1.00047965"},
        {"Smithsonian Astrophysical Observation", "SAO 133564"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.353,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.23185422),
        dec: Angle.Degrees(-04.56841253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46562"},
        {"Hipparcos Number", "HIP 31312"},
        {"Geneva Identification System", "GEN# +1.00046562"},
        {"Smithsonian Astrophysical Observation", "SAO 133413"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.50284912),
        dec: Angle.Degrees(-04.56801991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35333"},
        {"Hipparcos Number", "HIP 25236"},
        {"Geneva Identification System", "GEN# +1.00035333"},
        {"Smithsonian Astrophysical Observation", "SAO 132064"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96170708),
        dec: Angle.Degrees(-04.56779561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76150"},
        {"Hipparcos Number", "HIP 43724"},
        {"Smithsonian Astrophysical Observation", "SAO 136386"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.56563326),
        dec: Angle.Degrees(-04.56714134)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74020",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133996"},
        {"Hipparcos Number", "HIP 74020"},
        {"Smithsonian Astrophysical Observation", "SAO 140335"},
    },
    visualMagnitude: 9.87,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.89753338),
        dec: Angle.Degrees(-04.56667927)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145124"},
        {"Hipparcos Number", "HIP 79167"},
        {"Smithsonian Astrophysical Observation", "SAO 140994"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.36704497),
        dec: Angle.Degrees(-04.56651180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36629"},
        {"Hipparcos Number", "HIP 26000"},
        {"Celescope Catalog", "CEL 777"},
        {"Geneva Identification System", "GEN# +9.00010025"},
        {"Geneva Identification System 2", "GEN# +2.19760025"},
        {"Renson", "Renson 9550"},
        {"Smithsonian Astrophysical Observation", "SAO 132244"},
        {"Wilson Evans Batten Catalogue", "WEB 5061"},
    },
    visualMagnitude: 7.65,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.23784080),
        dec: Angle.Degrees(-04.56647717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3840"},
        {"Hipparcos Number", "HIP 3222"},
        {"Smithsonian Astrophysical Observation", "SAO 128897"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.23724794),
        dec: Angle.Degrees(-04.56500267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25314",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35485"},
        {"Hipparcos Number", "HIP 25314"},
        {"Smithsonian Astrophysical Observation", "SAO 132079"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.22183643),
        dec: Angle.Degrees(-04.56476610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73601",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133092"},
        {"Hipparcos Number", "HIP 73601"},
        {"Smithsonian Astrophysical Observation", "SAO 140285"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.66628175),
        dec: Angle.Degrees(-04.56448111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8292"},
        {"Hipparcos Number", "HIP 6389"},
        {"Smithsonian Astrophysical Observation", "SAO 129257"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.53046398),
        dec: Angle.Degrees(-04.56434193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16172",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2562 AB"},
        {"Henry Draper", "HD 21529"},
        {"Hipparcos Number", "HIP 16172"},
        {"Smithsonian Astrophysical Observation", "SAO 130510"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.09146905),
        dec: Angle.Degrees(-04.56251039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81745"},
        {"Hipparcos Number", "HIP 46378"},
        {"Smithsonian Astrophysical Observation", "SAO 136864"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.85124828),
        dec: Angle.Degrees(-04.56190032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191658"},
        {"Hipparcos Number", "HIP 99458"},
        {"Smithsonian Astrophysical Observation", "SAO 144146"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.79278540),
        dec: Angle.Degrees(-04.56146827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201844"},
        {"Hipparcos Number", "HIP 104686"},
        {"Geneva Identification System", "GEN# +1.00201844"},
        {"Smithsonian Astrophysical Observation", "SAO 145197"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.08353119),
        dec: Angle.Degrees(-04.56018640)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203222"},
        {"Hipparcos Number", "HIP 105412"},
        {"Geneva Identification System", "GEN# +1.00203222"},
        {"Smithsonian Astrophysical Observation", "SAO 145317"},
        {"Wilson Evans Batten Catalogue", "WEB 19144"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.26802428),
        dec: Angle.Degrees(-04.56015214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86789",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86789"},
        {"Smithsonian Astrophysical Observation", "SAO 141838"},
    },
    visualMagnitude: 9.79,
    bvColour: 0.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.01473271),
        dec: Angle.Degrees(-04.55949981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31799"},
        {"Hipparcos Number", "HIP 23130"},
        {"Smithsonian Astrophysical Observation", "SAO 131649"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.65366367),
        dec: Angle.Degrees(-04.55922897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147145"},
        {"Hipparcos Number", "HIP 80037"},
        {"Smithsonian Astrophysical Observation", "SAO 141108"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.06618987),
        dec: Angle.Degrees(-04.55788046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45161",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79129"},
        {"Hipparcos Number", "HIP 45161"},
        {"Smithsonian Astrophysical Observation", "SAO 136653"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.00391730),
        dec: Angle.Degrees(-04.55523639)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217410"},
        {"Hipparcos Number", "HIP 113611"},
        {"Smithsonian Astrophysical Observation", "SAO 146441"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.15874267),
        dec: Angle.Degrees(-04.55297460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67722"},
        {"Hipparcos Number", "HIP 39927"},
        {"Smithsonian Astrophysical Observation", "SAO 135562"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.31543333),
        dec: Angle.Degrees(-04.55278086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104263"},
        {"Hipparcos Number", "HIP 58558"},
        {"Smithsonian Astrophysical Observation", "SAO 138527"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.753,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.11466544),
        dec: Angle.Degrees(-04.54845202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -146.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80878",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80878"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.72458563),
        dec: Angle.Degrees(-04.54757354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -101.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -190.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2713",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 475 AB"},
        {"Henry Draper", "HD 3125"},
        {"Hipparcos Number", "HIP 2713"},
        {"Geneva Identification System", "GEN# +1.00003125J"},
        {"Smithsonian Astrophysical Observation", "SAO 128831"},
        {"Wilson Evans Batten Catalogue", "WEB 491"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.732,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.62397660),
        dec: Angle.Degrees(-04.54653967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136119"},
        {"Hipparcos Number", "HIP 74952"},
        {"Geneva Identification System", "GEN# +1.00136119"},
        {"Smithsonian Astrophysical Observation", "SAO 140451"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.74072090),
        dec: Angle.Degrees(-04.54559699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -73.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79567"},
        {"Hipparcos Number", "HIP 45368"},
        {"Smithsonian Astrophysical Observation", "SAO 136686"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.187,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.68382594),
        dec: Angle.Degrees(-04.54309440)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2715",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 475 C"},
        {"Henry Draper", "HD 3125C"},
        {"Hipparcos Number", "HIP 2715"},
        {"Geneva Identification System", "GEN# +1.00003125C"},
        {"Smithsonian Astrophysical Observation", "SAO 128832"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.62777787),
        dec: Angle.Degrees(-04.54265776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 108.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198962"},
        {"Hipparcos Number", "HIP 103164"},
        {"Smithsonian Astrophysical Observation", "SAO 144918"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.52003990),
        dec: Angle.Degrees(-04.54219479)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58580"},
        {"Hipparcos Number", "HIP 36080"},
        {"Geneva Identification System", "GEN# +1.00058580"},
        {"Smithsonian Astrophysical Observation", "SAO 134658"},
        {"Wilson Evans Batten Catalogue", "WEB 7188"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.51412682),
        dec: Angle.Degrees(-04.53733398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116501"},
        {"Hipparcos Number", "HIP 65392"},
        {"Smithsonian Astrophysical Observation", "SAO 139316"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.03102452),
        dec: Angle.Degrees(-04.53649210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219375"},
        {"Hipparcos Number", "HIP 114803"},
        {"Smithsonian Astrophysical Observation", "SAO 146592"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.83347054),
        dec: Angle.Degrees(-04.53408246)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221148"},
        {"Hipparcos Number", "HIP 115953"},
        {"Fundamental Katalog 5th Edition", "FK5 3881"},
        {"Geneva Identification System", "GEN# +1.00221148"},
        {"Smithsonian Astrophysical Observation", "SAO 146736"},
        {"Wilson Evans Batten Catalogue", "WEB 20508"},
    },
    visualMagnitude: 6.26,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.38323384),
        dec: Angle.Degrees(-04.53218332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 179.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -231.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64562"},
        {"Hipparcos Number", "HIP 38614"},
        {"Smithsonian Astrophysical Observation", "SAO 135234"},
    },
    visualMagnitude: 8.91,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.60323417),
        dec: Angle.Degrees(-04.52831132)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23889"},
        {"Hipparcos Number", "HIP 17789"},
        {"Smithsonian Astrophysical Observation", "SAO 130738"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.688,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.11702292),
        dec: Angle.Degrees(-04.52720081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24727"},
        {"Hipparcos Number", "HIP 18388"},
        {"Geneva Identification System", "GEN# +1.00024727"},
        {"Smithsonian Astrophysical Observation", "SAO 130824"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.95562582),
        dec: Angle.Degrees(-04.52670309)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4207",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5181"},
        {"Hipparcos Number", "HIP 4207"},
        {"Geneva Identification System", "GEN# +1.00005181"},
        {"Smithsonian Astrophysical Observation", "SAO 129015"},
    },
    visualMagnitude: 6.53,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.42197878),
        dec: Angle.Degrees(-04.52557954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 99.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51722"},
        {"Hipparcos Number", "HIP 33555"},
        {"Geneva Identification System", "GEN# +1.00051722"},
        {"Smithsonian Astrophysical Observation", "SAO 133970"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.60074096),
        dec: Angle.Degrees(-04.52508293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186553"},
        {"Hipparcos Number", "HIP 97197"},
        {"Smithsonian Astrophysical Observation", "SAO 143762"},
    },
    visualMagnitude: 8.89,
    bvColour: 1.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.31565868),
        dec: Angle.Degrees(-04.52286418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39787",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39787"},
    },
    visualMagnitude: 11.21,
    bvColour: 0.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.96045312),
        dec: Angle.Degrees(-04.52238925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25163"},
        {"Hipparcos Number", "HIP 18667"},
        {"Renson", "Renson 6400"},
        {"Smithsonian Astrophysical Observation", "SAO 130866"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.96036585),
        dec: Angle.Degrees(-04.52215878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219686"},
        {"Hipparcos Number", "HIP 115030"},
        {"Geneva Identification System", "GEN# +1.00219686"},
        {"Smithsonian Astrophysical Observation", "SAO 146621"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.47390748),
        dec: Angle.Degrees(-04.52182477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17067"},
        {"Hipparcos Number", "HIP 12789"},
        {"Smithsonian Astrophysical Observation", "SAO 130088"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.09061427),
        dec: Angle.Degrees(-04.52035635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202753"},
        {"Hipparcos Number", "HIP 105164"},
        {"Fundamental Katalog 5th Edition", "FK5 3698"},
        {"Geneva Identification System", "GEN# +1.00202753"},
        {"Smithsonian Astrophysical Observation", "SAO 145278"},
    },
    visualMagnitude: 5.83,
    bvColour: -0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.54610828),
        dec: Angle.Degrees(-04.51951158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25954",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36540"},
        {"Hipparcos Number", "HIP 25954"},
        {"Geneva Identification System", "GEN# +1.00036540"},
        {"Renson", "Renson 9480"},
        {"Smithsonian Astrophysical Observation", "SAO 132229"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.06178305),
        dec: Angle.Degrees(-04.51838374)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20117"},
        {"Hipparcos Number", "HIP 15046"},
        {"Geneva Identification System", "GEN# +1.00020117"},
        {"Smithsonian Astrophysical Observation", "SAO 130366"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.668,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.47744817),
        dec: Angle.Degrees(-04.51826441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 188.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -176.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2077"},
        {"Hipparcos Number", "HIP 1974"},
        {"Geneva Identification System", "GEN# +1.00002077"},
        {"Smithsonian Astrophysical Observation", "SAO 128751"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.24764870),
        dec: Angle.Degrees(-04.51770643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80256",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147610"},
        {"Hipparcos Number", "HIP 80256"},
        {"Smithsonian Astrophysical Observation", "SAO 141134"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.76837286),
        dec: Angle.Degrees(-04.51751238)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82289",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151655"},
        {"Hipparcos Number", "HIP 82289"},
        {"Fundamental Katalog 5th Edition", "FK5 5483"},
        {"Geneva Identification System", "GEN# +1.00151655"},
        {"Smithsonian Astrophysical Observation", "SAO 141374"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.764,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.21428519),
        dec: Angle.Degrees(-04.51546377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44269",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77214"},
        {"Hipparcos Number", "HIP 44269"},
        {"Geneva Identification System", "GEN# +1.00077214"},
        {"Smithsonian Astrophysical Observation", "SAO 136491"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.336,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.22398144),
        dec: Angle.Degrees(-04.51196799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101852",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196554"},
        {"Hipparcos Number", "HIP 101852"},
        {"Geneva Identification System", "GEN# +1.00196554"},
        {"Smithsonian Astrophysical Observation", "SAO 144647"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.58796857),
        dec: Angle.Degrees(-04.51186104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57275",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102059"},
        {"Hipparcos Number", "HIP 57275"},
        {"Smithsonian Astrophysical Observation", "SAO 138384"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.17314407),
        dec: Angle.Degrees(-04.51074929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11026"},
        {"Smithsonian Astrophysical Observation", "SAO 129855"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.49741438),
        dec: Angle.Degrees(-04.51067466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107309"},
        {"Hipparcos Number", "HIP 60167"},
        {"Smithsonian Astrophysical Observation", "SAO 138724"},
    },
    visualMagnitude: 7.16,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.07027580),
        dec: Angle.Degrees(-04.51027370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44095"},
        {"Hipparcos Number", "HIP 30076"},
        {"Smithsonian Astrophysical Observation", "SAO 133112"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.94205596),
        dec: Angle.Degrees(-04.50988255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95059",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95059"},
        {"Cincinnati Publication", "Ci 20 1144"},
        {"Geneva Identification System", "GEN# -0.00404778"},
    },
    visualMagnitude: 10.53,
    bvColour: 0.889,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.12218274),
        dec: Angle.Degrees(-04.50881086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -466.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101027"},
        {"Hipparcos Number", "HIP 56699"},
        {"Smithsonian Astrophysical Observation", "SAO 138309"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.38979576),
        dec: Angle.Degrees(-04.50530069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112250"},
        {"Hipparcos Number", "HIP 63070"},
        {"Geneva Identification System", "GEN# +1.00112250"},
        {"Smithsonian Astrophysical Observation", "SAO 139039"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.797,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.84128248),
        dec: Angle.Degrees(-04.50430311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137374"},
        {"Hipparcos Number", "HIP 75526"},
        {"Smithsonian Astrophysical Observation", "SAO 140524"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.963,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.44015716),
        dec: Angle.Degrees(-04.50426806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1997"},
        {"Hipparcos Number", "HIP 1917"},
        {"Smithsonian Astrophysical Observation", "SAO 128741"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.05992020),
        dec: Angle.Degrees(-04.50271244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181475"},
        {"Hipparcos Number", "HIP 95099"},
        {"Geneva Identification System", "GEN# +1.00181475"},
        {"Smithsonian Astrophysical Observation", "SAO 143296"},
        {"Wilson Evans Batten Catalogue", "WEB 16610"},
    },
    visualMagnitude: 6.89,
    bvColour: 2.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.20130666),
        dec: Angle.Degrees(-04.50248749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217132"},
        {"Hipparcos Number", "HIP 113440"},
        {"Smithsonian Astrophysical Observation", "SAO 146417"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.62652105),
        dec: Angle.Degrees(-04.50210761)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72474",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130584"},
        {"Hipparcos Number", "HIP 72474"},
        {"Smithsonian Astrophysical Observation", "SAO 140154"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.28842485),
        dec: Angle.Degrees(-04.50197200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106163",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204677"},
        {"Hipparcos Number", "HIP 106163"},
        {"Smithsonian Astrophysical Observation", "SAO 145443"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.214,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.56319879),
        dec: Angle.Degrees(-04.50193269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172508"},
        {"Hipparcos Number", "HIP 91598"},
        {"Geneva Identification System", "GEN# +1.00172508"},
        {"Smithsonian Astrophysical Observation", "SAO 142491"},
        {"Wilson Evans Batten Catalogue", "WEB 15750"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.19759904),
        dec: Angle.Degrees(-04.49640424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97492",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97492"},
        {"Fundamental Katalog 5th Edition", "FK5 5748"},
        {"Smithsonian Astrophysical Observation", "SAO 143813"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.23523529),
        dec: Angle.Degrees(-04.49597450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32952"},
        {"Hipparcos Number", "HIP 23790"},
        {"Smithsonian Astrophysical Observation", "SAO 131775"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.68075300),
        dec: Angle.Degrees(-04.49521436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135895"},
        {"Hipparcos Number", "HIP 74845"},
        {"Smithsonian Astrophysical Observation", "SAO 140436"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.42599674),
        dec: Angle.Degrees(-04.49447183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37017"},
        {"Hipparcos Number", "HIP 26233"},
        {"Celescope Catalog", "CEL 834"},
        {"Geneva Identification System", "GEN# +9.00010632"},
        {"Geneva Identification System 2", "GEN# +2.19760632"},
        {"Renson", "Renson 9820"},
        {"Smithsonian Astrophysical Observation", "SAO 132317"},
        {"Wilson Evans Batten Catalogue", "WEB 5132"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.142,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.84110614),
        dec: Angle.Degrees(-04.49417472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27486"},
        {"Hipparcos Number", "HIP 20233"},
        {"Fundamental Katalog 5th Edition", "FK5 4398"},
        {"Smithsonian Astrophysical Observation", "SAO 131121"},
        {"Wilson Evans Batten Catalogue", "WEB 3863"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.04740975),
        dec: Angle.Degrees(-04.49313435)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7194"},
        {"Hipparcos Number", "HIP 5620"},
        {"Geneva Identification System", "GEN# +1.00007194"},
        {"Smithsonian Astrophysical Observation", "SAO 129174"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.03740356),
        dec: Angle.Degrees(-04.49211769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15384",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15384"},
        {"Smithsonian Astrophysical Observation", "SAO 130409"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59496646),
        dec: Angle.Degrees(-04.49131930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24701",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34523"},
        {"Hipparcos Number", "HIP 24701"},
        {"Smithsonian Astrophysical Observation", "SAO 131958"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.47850536),
        dec: Angle.Degrees(-04.48990641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110037",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110037"},
        {"Smithsonian Astrophysical Observation", "SAO 145995"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.31623594),
        dec: Angle.Degrees(-04.48943890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142269"},
        {"Hipparcos Number", "HIP 77843"},
        {"Geneva Identification System", "GEN# +1.00142269"},
        {"Smithsonian Astrophysical Observation", "SAO 140825"},
    },
    visualMagnitude: 8.74,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.41576157),
        dec: Angle.Degrees(-04.48837981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -106.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12129",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16248"},
        {"Hipparcos Number", "HIP 12129"},
        {"Smithsonian Astrophysical Observation", "SAO 130007"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.345,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.05710708),
        dec: Angle.Degrees(-04.48717651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203325"},
        {"Hipparcos Number", "HIP 105460"},
        {"Smithsonian Astrophysical Observation", "SAO 145327"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.41555688),
        dec: Angle.Degrees(-04.48662365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110524",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212304"},
        {"Hipparcos Number", "HIP 110524"},
        {"Smithsonian Astrophysical Observation", "SAO 146061"},
    },
    visualMagnitude: 9.57,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.86674576),
        dec: Angle.Degrees(-04.48454063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60680",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8548 AB"},
        {"Henry Draper", "HD 108240"},
        {"Hipparcos Number", "HIP 60680"},
        {"Smithsonian Astrophysical Observation", "SAO 138777"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.53458544),
        dec: Angle.Degrees(-04.48071935)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21196"},
        {"Hipparcos Number", "HIP 15927"},
        {"Fundamental Katalog 5th Edition", "FK5 4311"},
        {"Geneva Identification System", "GEN# +1.00021196"},
        {"Smithsonian Astrophysical Observation", "SAO 130473"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.29009708),
        dec: Angle.Degrees(-04.47835116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 61.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144250"},
        {"Hipparcos Number", "HIP 78780"},
        {"Geneva Identification System", "GEN# +1.00144250"},
        {"Smithsonian Astrophysical Observation", "SAO 140936"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.25198462),
        dec: Angle.Degrees(-04.47825585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15023",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20088"},
        {"Hipparcos Number", "HIP 15023"},
        {"Smithsonian Astrophysical Observation", "SAO 130364"},
    },
    visualMagnitude: 9.35,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.40643796),
        dec: Angle.Degrees(-04.46876190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6826",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8920"},
        {"Hipparcos Number", "HIP 6826"},
        {"Smithsonian Astrophysical Observation", "SAO 129312"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.95428579),
        dec: Angle.Degrees(-04.46837547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145071"},
        {"Hipparcos Number", "HIP 79132"},
        {"Geneva Identification System", "GEN# +1.00145071"},
        {"Smithsonian Astrophysical Observation", "SAO 140993"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.28576424),
        dec: Angle.Degrees(-04.46724770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117178"},
        {"Hipparcos Number", "HIP 65751"},
        {"Smithsonian Astrophysical Observation", "SAO 139356"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.17613917),
        dec: Angle.Degrees(-04.46555806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213750"},
        {"Hipparcos Number", "HIP 111373"},
        {"Smithsonian Astrophysical Observation", "SAO 146158"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.44675580),
        dec: Angle.Degrees(-04.46554832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37928"},
        {"Hipparcos Number", "HIP 26837"},
    },
    visualMagnitude: 9.80,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.47922662),
        dec: Angle.Degrees(-04.46480079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34271"},
        {"Hipparcos Number", "HIP 24556"},
        {"Smithsonian Astrophysical Observation", "SAO 131924"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.02745279),
        dec: Angle.Degrees(-04.46406135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179345"},
        {"Hipparcos Number", "HIP 94360"},
        {"Smithsonian Astrophysical Observation", "SAO 143131"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.09371204),
        dec: Angle.Degrees(-04.46308992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10277"},
        {"Hipparcos Number", "HIP 7802"},
        {"Smithsonian Astrophysical Observation", "SAO 129439"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.09777222),
        dec: Angle.Degrees(-04.46242693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223215"},
        {"Hipparcos Number", "HIP 117352"},
        {"Smithsonian Astrophysical Observation", "SAO 146909"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.91330629),
        dec: Angle.Degrees(-04.46168326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47799"},
        {"Hipparcos Number", "HIP 31921"},
        {"Smithsonian Astrophysical Observation", "SAO 133548"},
        {"Wilson Evans Batten Catalogue", "WEB 6417"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.06570311),
        dec: Angle.Degrees(-04.46132750)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5814"},
        {"Hipparcos Number", "HIP 4647"},
        {"Smithsonian Astrophysical Observation", "SAO 129067"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.92122978),
        dec: Angle.Degrees(-04.46087885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78190"},
        {"Smithsonian Astrophysical Observation", "SAO 140862"},
    },
    visualMagnitude: 9.43,
    bvColour: 1.992,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.48243930),
        dec: Angle.Degrees(-04.45955648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30691",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45398"},
        {"Hipparcos Number", "HIP 30691"},
        {"Geneva Identification System", "GEN# +2.22320004"},
        {"Smithsonian Astrophysical Observation", "SAO 133265"},
        {"New General Catalogue", "NGC 2232 4"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.74313131),
        dec: Angle.Degrees(-04.45929062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94364",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 94364"},
    },
    visualMagnitude: 11.77,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.09861854),
        dec: Angle.Degrees(-04.45803989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121284"},
        {"Hipparcos Number", "HIP 67931"},
        {"Geneva Identification System", "GEN# +1.00121284"},
        {"Smithsonian Astrophysical Observation", "SAO 139612"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.67721765),
        dec: Angle.Degrees(-04.45783929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39022"},
        {"Hipparcos Number", "HIP 27521"},
        {"Geneva Identification System", "GEN# +1.00039022"},
        {"Smithsonian Astrophysical Observation", "SAO 132575"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.41370773),
        dec: Angle.Degrees(-04.45655136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23941",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33256"},
        {"Hipparcos Number", "HIP 23941"},
        {"Celescope Catalog", "CEL 545"},
        {"Geneva Identification System", "GEN# +1.00033256"},
        {"Smithsonian Astrophysical Observation", "SAO 131813"},
        {"Wilson Evans Batten Catalogue", "WEB 4668"},
    },
    visualMagnitude: 5.11,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.18194475),
        dec: Angle.Degrees(-04.45624625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77296"},
        {"Hipparcos Number", "HIP 44316"},
        {"Smithsonian Astrophysical Observation", "SAO 136502"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.38058307),
        dec: Angle.Degrees(-04.45604427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132759"},
        {"Hipparcos Number", "HIP 73465"},
        {"Smithsonian Astrophysical Observation", "SAO 140269"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.552,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.22155583),
        dec: Angle.Degrees(-04.45559317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126498"},
        {"Hipparcos Number", "HIP 70571"},
        {"Smithsonian Astrophysical Observation", "SAO 139928"},
    },
    visualMagnitude: 8.42,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.52865722),
        dec: Angle.Degrees(-04.45492626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37815",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62699"},
        {"Hipparcos Number", "HIP 37815"},
        {"Smithsonian Astrophysical Observation", "SAO 135062"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.30128775),
        dec: Angle.Degrees(-04.45385831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59842",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106695"},
        {"Hipparcos Number", "HIP 59842"},
        {"Smithsonian Astrophysical Observation", "SAO 138684"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.06734972),
        dec: Angle.Degrees(-04.45183487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56049",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8178 A"},
        {"Henry Draper", "HD 99865"},
        {"Hipparcos Number", "HIP 56049"},
        {"Smithsonian Astrophysical Observation", "SAO 138230"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.31031918),
        dec: Angle.Degrees(-04.45144063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -89.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210926"},
        {"Hipparcos Number", "HIP 109750"},
        {"Smithsonian Astrophysical Observation", "SAO 145954"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.46454788),
        dec: Angle.Degrees(-04.45131101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31196",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46339"},
        {"Hipparcos Number", "HIP 31196"},
        {"Celescope Catalog", "CEL 1294"},
        {"Geneva Identification System", "GEN# +1.00046339"},
        {"Smithsonian Astrophysical Observation", "SAO 133388"},
        {"Wilson Evans Batten Catalogue", "WEB 6232"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.17370489),
        dec: Angle.Degrees(-04.44968670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1301"},
        {"Hipparcos Number", "HIP 1380"},
        {"Smithsonian Astrophysical Observation", "SAO 128679"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(004.31574636),
        dec: Angle.Degrees(-04.44902726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29638",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4851 AB"},
        {"Henry Draper", "HD 43195"},
        {"Hipparcos Number", "HIP 29638"},
        {"Smithsonian Astrophysical Observation", "SAO 133007"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.68332328),
        dec: Angle.Degrees(-04.44893163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90589",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90589"},
        {"Smithsonian Astrophysical Observation", "SAO 142339"},
    },
    visualMagnitude: 10.13,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.27550616),
        dec: Angle.Degrees(-04.44809417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61346",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109362"},
        {"Hipparcos Number", "HIP 61346"},
        {"Geneva Identification System", "GEN# +1.00109362"},
        {"Smithsonian Astrophysical Observation", "SAO 138850"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.54468952),
        dec: Angle.Degrees(-04.44641356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65570",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116869"},
        {"Hipparcos Number", "HIP 65570"},
        {"Geneva Identification System", "GEN# +1.00116869"},
        {"Smithsonian Astrophysical Observation", "SAO 139338"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.65816064),
        dec: Angle.Degrees(-04.44582371)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44450",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77588"},
        {"Hipparcos Number", "HIP 44450"},
        {"Smithsonian Astrophysical Observation", "SAO 136534"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.83802425),
        dec: Angle.Degrees(-04.44158124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165944"},
        {"Hipparcos Number", "HIP 88871"},
        {"Smithsonian Astrophysical Observation", "SAO 142114"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.15427574),
        dec: Angle.Degrees(-04.44051434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176588"},
        {"Hipparcos Number", "HIP 93381"},
        {"Smithsonian Astrophysical Observation", "SAO 142919"},
        {"Wilson Evans Batten Catalogue", "WEB 16192"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.684,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.28960928),
        dec: Angle.Degrees(-04.43898713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27466"},
        {"Hipparcos Number", "HIP 20218"},
        {"Geneva Identification System", "GEN# +1.00027466"},
        {"Smithsonian Astrophysical Observation", "SAO 131119"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.98796925),
        dec: Angle.Degrees(-04.43867332)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101136",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195200"},
        {"Hipparcos Number", "HIP 101136"},
        {"Geneva Identification System", "GEN# +1.00195200"},
        {"Smithsonian Astrophysical Observation", "SAO 144501"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.50670201),
        dec: Angle.Degrees(-04.43742631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223336"},
        {"Hipparcos Number", "HIP 117438"},
        {"Smithsonian Astrophysical Observation", "SAO 146922"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.18807103),
        dec: Angle.Degrees(-04.43523412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219628"},
        {"Hipparcos Number", "HIP 114977"},
        {"Smithsonian Astrophysical Observation", "SAO 146615"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.31277118),
        dec: Angle.Degrees(-04.43520046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216589"},
        {"Hipparcos Number", "HIP 113091"},
        {"Smithsonian Astrophysical Observation", "SAO 146379"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.54415735),
        dec: Angle.Degrees(-04.43366768)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206940"},
        {"Hipparcos Number", "HIP 107434"},
        {"Smithsonian Astrophysical Observation", "SAO 145644"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.39530153),
        dec: Angle.Degrees(-04.43264914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57956"},
        {"Hipparcos Number", "HIP 35831"},
        {"Fundamental Katalog 5th Edition", "FK5 4665"},
        {"Renson", "Renson 15786"},
        {"Smithsonian Astrophysical Observation", "SAO 134600"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.83876208),
        dec: Angle.Degrees(-04.43243864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112863"},
        {"Hipparcos Number", "HIP 63419"},
        {"Smithsonian Astrophysical Observation", "SAO 139087"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.779,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.93958650),
        dec: Angle.Degrees(-04.43021158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194976"},
        {"Hipparcos Number", "HIP 100998"},
        {"Geneva Identification System", "GEN# +1.00194976"},
        {"Smithsonian Astrophysical Observation", "SAO 144474"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.15465532),
        dec: Angle.Degrees(-04.42789333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104383"},
        {"Smithsonian Astrophysical Observation", "SAO 145139"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.18964368),
        dec: Angle.Degrees(-04.42684949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4449"},
        {"Hipparcos Number", "HIP 3645"},
        {"Cincinnati Publication", "Ci 18 102"},
        {"Geneva Identification System", "GEN# +1.00004449"},
        {"Smithsonian Astrophysical Observation", "SAO 128952"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.822,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.66882280),
        dec: Angle.Degrees(-04.42640522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -270.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70653",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70653"},
        {"Smithsonian Astrophysical Observation", "SAO 139937"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.703,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.76316056),
        dec: Angle.Degrees(-04.42581039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89909"},
        {"Hipparcos Number", "HIP 50806"},
        {"Geneva Identification System", "GEN# +1.00089909"},
        {"Smithsonian Astrophysical Observation", "SAO 137519"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.59709903),
        dec: Angle.Degrees(-04.42538153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -77.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26234",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37016"},
        {"Hipparcos Number", "HIP 26234"},
        {"Celescope Catalog", "CEL 835"},
        {"Geneva Identification System", "GEN# +9.00010631"},
        {"Geneva Identification System 2", "GEN# +9.00010631D"},
        {"Geneva Identification System 3", "GEN# +2.19760631"},
        {"Smithsonian Astrophysical Observation", "SAO 132319"},
        {"Wilson Evans Batten Catalogue", "WEB 5131"},
    },
    visualMagnitude: 6.24,
    bvColour: -0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.84298392),
        dec: Angle.Degrees(-04.42432372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222504"},
        {"Hipparcos Number", "HIP 116864"},
        {"Smithsonian Astrophysical Observation", "SAO 146846"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.953,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.32469687),
        dec: Angle.Degrees(-04.42319445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64043",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64043"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.88037136),
        dec: Angle.Degrees(-04.42294369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 101.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17801",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23901"},
        {"Hipparcos Number", "HIP 17801"},
        {"Geneva Identification System", "GEN# +1.00023901"},
        {"Smithsonian Astrophysical Observation", "SAO 130740"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.15797476),
        dec: Angle.Degrees(-04.42124667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37700"},
        {"Hipparcos Number", "HIP 26697"},
        {"Celescope Catalog", "CEL 916"},
        {"Geneva Identification System", "GEN# +1.00037700"},
        {"Smithsonian Astrophysical Observation", "SAO 132440"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.10521955),
        dec: Angle.Degrees(-04.42123381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22009"},
        {"Hipparcos Number", "HIP 16520"},
        {"Smithsonian Astrophysical Observation", "SAO 130559"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.17726487),
        dec: Angle.Degrees(-04.42030036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19832",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 19832"},
        {"Geneva Identification System", "GEN# -0.00400782"},
        {"Smithsonian Astrophysical Observation", "SAO 131057"},
    },
    visualMagnitude: 9.38,
    bvColour: 1.209,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.78948341),
        dec: Angle.Degrees(-04.41809253)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190739"},
        {"Hipparcos Number", "HIP 99050"},
        {"Fundamental Katalog 5th Edition", "FK5 5771"},
        {"Smithsonian Astrophysical Observation", "SAO 144070"},
    },
    visualMagnitude: 7.12,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.65099354),
        dec: Angle.Degrees(-04.41740171)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60237"},
        {"Hipparcos Number", "HIP 36743"},
        {"Smithsonian Astrophysical Observation", "SAO 134834"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.35865894),
        dec: Angle.Degrees(-04.41697721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41489",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6825 AB"},
        {"Henry Draper", "HD 71499"},
        {"Hipparcos Number", "HIP 41489"},
        {"Geneva Identification System", "GEN# +1.00071499J"},
        {"Smithsonian Astrophysical Observation", "SAO 135938"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.92005999),
        dec: Angle.Degrees(-04.41478188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40919",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70281"},
        {"Hipparcos Number", "HIP 40919"},
        {"Smithsonian Astrophysical Observation", "SAO 135799"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.081,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.26993742),
        dec: Angle.Degrees(-04.41301474)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175617"},
        {"Hipparcos Number", "HIP 92960"},
        {"Geneva Identification System", "GEN# +1.00175617"},
        {"Smithsonian Astrophysical Observation", "SAO 142820"},
    },
    visualMagnitude: 10.12,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.08678478),
        dec: Angle.Degrees(-04.41268774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -99.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -341.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46780",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82462"},
        {"Hipparcos Number", "HIP 46780"},
        {"Smithsonian Astrophysical Observation", "SAO 136933"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.00351542),
        dec: Angle.Degrees(-04.41239159)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82673"},
        {"Hipparcos Number", "HIP 46886"},
        {"Geneva Identification System", "GEN# +1.00082673"},
        {"Smithsonian Astrophysical Observation", "SAO 136949"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.31884935),
        dec: Angle.Degrees(-04.41201088)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26608"},
        {"Hipparcos Number", "HIP 19626"},
        {"Smithsonian Astrophysical Observation", "SAO 131025"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.08482053),
        dec: Angle.Degrees(-04.41028399)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74216"},
        {"Hipparcos Number", "HIP 42739"},
        {"Smithsonian Astrophysical Observation", "SAO 136202"},
    },
    visualMagnitude: 6.90,
    bvColour: 1.382,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.65412950),
        dec: Angle.Degrees(-04.41015757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92828"},
        {"Hipparcos Number", "HIP 52424"},
        {"Smithsonian Astrophysical Observation", "SAO 137746"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.76331636),
        dec: Angle.Degrees(-04.40714723)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36131",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36131"},
        {"Smithsonian Astrophysical Observation", "SAO 134669"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.760,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.64520460),
        dec: Angle.Degrees(-04.40257680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72188",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72188"},
        {"Smithsonian Astrophysical Observation", "SAO 140124"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.47963165),
        dec: Angle.Degrees(-04.40230071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106059"},
        {"Hipparcos Number", "HIP 59506"},
        {"Fundamental Katalog 5th Edition", "FK5 5083"},
        {"Smithsonian Astrophysical Observation", "SAO 138644"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.05931411),
        dec: Angle.Degrees(-04.40194070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221600"},
        {"Hipparcos Number", "HIP 116266"},
        {"Geneva Identification System", "GEN# +1.00221600"},
        {"Smithsonian Astrophysical Observation", "SAO 146774"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.36925681),
        dec: Angle.Degrees(-04.40124893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3465",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4184"},
        {"Hipparcos Number", "HIP 3465"},
        {"Smithsonian Astrophysical Observation", "SAO 128927"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(011.08160076),
        dec: Angle.Degrees(-04.39906259)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48754"},
        {"Hipparcos Number", "HIP 32312"},
        {"Geneva Identification System", "GEN# +1.00048754"},
        {"Renson", "Renson 13020"},
        {"Smithsonian Astrophysical Observation", "SAO 133631"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.19010563),
        dec: Angle.Degrees(-04.39355580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33128",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50637"},
        {"Hipparcos Number", "HIP 33128"},
        {"Smithsonian Astrophysical Observation", "SAO 133845"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.48359251),
        dec: Angle.Degrees(-04.39242356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118218"},
        {"Hipparcos Number", "HIP 66324"},
        {"Smithsonian Astrophysical Observation", "SAO 139429"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.88354831),
        dec: Angle.Degrees(-04.38986962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90485"},
        {"Hipparcos Number", "HIP 51135"},
        {"Geneva Identification System", "GEN# +1.00090485"},
        {"Smithsonian Astrophysical Observation", "SAO 137567"},
        {"Wilson Evans Batten Catalogue", "WEB 9347"},
    },
    visualMagnitude: 6.55,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.69541167),
        dec: Angle.Degrees(-04.38833591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164813"},
        {"Hipparcos Number", "HIP 88410"},
        {"Smithsonian Astrophysical Observation", "SAO 142053"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.77587909),
        dec: Angle.Degrees(-04.38772747)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -80.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107572"},
        {"Hipparcos Number", "HIP 60298"},
        {"Smithsonian Astrophysical Observation", "SAO 138735"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.46297772),
        dec: Angle.Degrees(-04.38632228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121815"},
        {"Hipparcos Number", "HIP 68221"},
        {"Smithsonian Astrophysical Observation", "SAO 139653"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.596,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.49332317),
        dec: Angle.Degrees(-04.38611037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295777"},
        {"Hipparcos Number", "HIP 33124"},
        {"Smithsonian Astrophysical Observation", "SAO 133843"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.47815090),
        dec: Angle.Degrees(-04.38517741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16579",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22076"},
        {"Hipparcos Number", "HIP 16579"},
        {"Geneva Identification System", "GEN# +1.00022076"},
        {"Smithsonian Astrophysical Observation", "SAO 130568"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.812,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.35457767),
        dec: Angle.Degrees(-04.38424115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43757"},
        {"Hipparcos Number", "HIP 29917"},
        {"Smithsonian Astrophysical Observation", "SAO 133071"},
    },
    visualMagnitude: 6.65,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.47222712),
        dec: Angle.Degrees(-04.38259449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196527"},
        {"Hipparcos Number", "HIP 101827"},
        {"Smithsonian Astrophysical Observation", "SAO 144642"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.53600320),
        dec: Angle.Degrees(-04.38180965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28775"},
        {"Hipparcos Number", "HIP 21145"},
        {"Smithsonian Astrophysical Observation", "SAO 131272"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.99804338),
        dec: Angle.Degrees(-04.38159541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56491"},
        {"Hipparcos Number", "HIP 35259"},
        {"Geneva Identification System", "GEN# +1.00056491"},
        {"Smithsonian Astrophysical Observation", "SAO 134457"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.921,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.27605989),
        dec: Angle.Degrees(-04.38105938)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64321",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64321"},
        {"Smithsonian Astrophysical Observation", "SAO 139202"},
    },
    visualMagnitude: 9.77,
    bvColour: 0.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.74550421),
        dec: Angle.Degrees(-04.38080698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83545"},
        {"Hipparcos Number", "HIP 47374"},
        {"Smithsonian Astrophysical Observation", "SAO 137027"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.78034162),
        dec: Angle.Degrees(-04.37862172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183370"},
        {"Hipparcos Number", "HIP 95817"},
        {"Smithsonian Astrophysical Observation", "SAO 143455"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.33532663),
        dec: Angle.Degrees(-04.37750095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114906"},
        {"Hipparcos Number", "HIP 64535"},
        {"Smithsonian Astrophysical Observation", "SAO 139230"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.41819187),
        dec: Angle.Degrees(-04.37705523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61685",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109944"},
        {"Hipparcos Number", "HIP 61685"},
        {"Geneva Identification System", "GEN# +1.00109944"},
        {"Smithsonian Astrophysical Observation", "SAO 138885"},
        {"Wilson Evans Batten Catalogue", "WEB 10973"},
    },
    visualMagnitude: 6.67,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.68065910),
        dec: Angle.Degrees(-04.37354727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208801"},
        {"Hipparcos Number", "HIP 108506"},
        {"Fundamental Katalog 5th Edition", "FK5 1580"},
        {"Geneva Identification System", "GEN# +1.00208801"},
        {"Smithsonian Astrophysical Observation", "SAO 145784"},
        {"Wilson Evans Batten Catalogue", "WEB 19536"},
    },
    visualMagnitude: 6.24,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.72910838),
        dec: Angle.Degrees(-04.37249443)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121420"},
        {"Hipparcos Number", "HIP 67991"},
        {"Smithsonian Astrophysical Observation", "SAO 139622"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.85448757),
        dec: Angle.Degrees(-04.37228243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131694"},
        {"Hipparcos Number", "HIP 73014"},
        {"Smithsonian Astrophysical Observation", "SAO 140223"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.82311211),
        dec: Angle.Degrees(-04.37223236)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21317"},
        {"Hipparcos Number", "HIP 16016"},
        {"Smithsonian Astrophysical Observation", "SAO 130486"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.54978017),
        dec: Angle.Degrees(-04.37176208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24424"},
        {"Hipparcos Number", "HIP 18164"},
        {"Geneva Identification System", "GEN# +1.00024424"},
        {"Smithsonian Astrophysical Observation", "SAO 130793"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.24943821),
        dec: Angle.Degrees(-04.37074398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103929"},
        {"Hipparcos Number", "HIP 58368"},
        {"Geneva Identification System", "GEN# +1.00103929"},
        {"Smithsonian Astrophysical Observation", "SAO 138508"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.52866810),
        dec: Angle.Degrees(-04.37065055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 67.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44257",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44257"},
    },
    visualMagnitude: 10.24,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.19494151),
        dec: Angle.Degrees(-04.37020460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58042",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103377"},
        {"Hipparcos Number", "HIP 58042"},
        {"Smithsonian Astrophysical Observation", "SAO 138469"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.55449011),
        dec: Angle.Degrees(-04.36998797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158576"},
        {"Hipparcos Number", "HIP 85661"},
        {"Geneva Identification System", "GEN# +1.00158576"},
        {"Smithsonian Astrophysical Observation", "SAO 141701"},
    },
    visualMagnitude: 6.72,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.58331492),
        dec: Angle.Degrees(-04.36939824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133646"},
        {"Hipparcos Number", "HIP 73859"},
        {"Geneva Identification System", "GEN# +1.00133646"},
        {"Smithsonian Astrophysical Observation", "SAO 140317"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.42093492),
        dec: Angle.Degrees(-04.36839663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106488",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15085 A"},
        {"Henry Draper", "HD 205244"},
        {"Hipparcos Number", "HIP 106488"},
        {"Renson", "Renson 57190"},
        {"Smithsonian Astrophysical Observation", "SAO 145493"},
    },
    visualMagnitude: 6.69,
    bvColour: 0.252,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.53171544),
        dec: Angle.Degrees(-04.36817078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 49.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41924",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41924"},
        {"Smithsonian Astrophysical Observation", "SAO 136022"},
    },
    visualMagnitude: 9.21,
    bvColour: 1.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.21554902),
        dec: Angle.Degrees(-04.36716779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118037"},
        {"Hipparcos Number", "HIP 66226"},
        {"Smithsonian Astrophysical Observation", "SAO 139417"},
    },
    visualMagnitude: 8.74,
    bvColour: 1.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.59981735),
        dec: Angle.Degrees(-04.36657903)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98686"},
        {"Hipparcos Number", "HIP 55443"},
        {"Smithsonian Astrophysical Observation", "SAO 138153"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.31807397),
        dec: Angle.Degrees(-04.36621524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12909"},
        {"Hipparcos Number", "HIP 9813"},
        {"Geneva Identification System", "GEN# +1.00012909"},
        {"Smithsonian Astrophysical Observation", "SAO 129693"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.56105041),
        dec: Angle.Degrees(-04.36500321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217274"},
        {"Hipparcos Number", "HIP 113537"},
        {"Smithsonian Astrophysical Observation", "SAO 146432"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.92196990),
        dec: Angle.Degrees(-04.36428362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10252",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10252"},
        {"Smithsonian Astrophysical Observation", "SAO 129746"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.97232203),
        dec: Angle.Degrees(-04.36422335)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26257",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4192 AB"},
        {"Henry Draper", "HD 37040"},
        {"Hipparcos Number", "HIP 26257"},
        {"Celescope Catalog", "CEL 841"},
        {"Geneva Identification System", "GEN# +9.00010722"},
        {"Geneva Identification System 2", "GEN# +9.00010722D"},
        {"Geneva Identification System 3", "GEN# +2.19760722"},
        {"Smithsonian Astrophysical Observation", "SAO 132325"},
        {"Wilson Evans Batten Catalogue", "WEB 5143"},
    },
    visualMagnitude: 6.56,
    bvColour: -0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.87948633),
        dec: Angle.Degrees(-04.36404861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138267"},
        {"Hipparcos Number", "HIP 75989"},
        {"Smithsonian Astrophysical Observation", "SAO 140580"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.78003095),
        dec: Angle.Degrees(-04.36259755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200758"},
        {"Hipparcos Number", "HIP 104111"},
        {"Fundamental Katalog 5th Edition", "FK5 5856"},
        {"Smithsonian Astrophysical Observation", "SAO 145084"},
    },
    visualMagnitude: 7.15,
    bvColour: 1.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.38329449),
        dec: Angle.Degrees(-04.36203687)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56500",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100659"},
        {"Hipparcos Number", "HIP 56500"},
        {"Fundamental Katalog 5th Edition", "FK5 5021"},
        {"Smithsonian Astrophysical Observation", "SAO 138284"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.74554486),
        dec: Angle.Degrees(-04.36118013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21977"},
        {"Hipparcos Number", "HIP 16498"},
        {"Geneva Identification System", "GEN# +1.00021977"},
        {"Smithsonian Astrophysical Observation", "SAO 130555"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.10755908),
        dec: Angle.Degrees(-04.36087887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 159.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59852"},
        {"Hipparcos Number", "HIP 36613"},
        {"Geneva Identification System", "GEN# +1.00059852"},
        {"Smithsonian Astrophysical Observation", "SAO 134790"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.94397893),
        dec: Angle.Degrees(-04.35978184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28334",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40534"},
        {"Hipparcos Number", "HIP 28334"},
        {"Celescope Catalog", "CEL 1053"},
        {"Geneva Identification System", "GEN# +1.00040534"},
        {"Smithsonian Astrophysical Observation", "SAO 132718"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.81086385),
        dec: Angle.Degrees(-04.35931757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45418"},
        {"Hipparcos Number", "HIP 30700"},
        {"Geneva Identification System", "GEN# +2.22320003"},
        {"Smithsonian Astrophysical Observation", "SAO 133267"},
        {"Wilson Evans Batten Catalogue", "WEB 6122"},
        {"New General Catalogue", "NGC 2232 3"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.75365905),
        dec: Angle.Degrees(-04.35564885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15573",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20763"},
        {"Hipparcos Number", "HIP 15573"},
        {"Geneva Identification System", "GEN# +1.00020763"},
        {"Smithsonian Astrophysical Observation", "SAO 130429"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.15679058),
        dec: Angle.Degrees(-04.35346342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3807"},
        {"Hipparcos Number", "HIP 3193"},
        {"Fundamental Katalog 5th Edition", "FK5 2042"},
        {"Geneva Identification System", "GEN# +1.00003807"},
        {"Smithsonian Astrophysical Observation", "SAO 128891"},
        {"Wilson Evans Batten Catalogue", "WEB 572"},
    },
    visualMagnitude: 5.90,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.17658814),
        dec: Angle.Degrees(-04.35180551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44335"},
        {"Hipparcos Number", "HIP 30197"},
        {"Smithsonian Astrophysical Observation", "SAO 133146"},
    },
    visualMagnitude: 7.91,
    bvColour: -0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.29520064),
        dec: Angle.Degrees(-04.35003885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200"},
        {"Hipparcos Number", "HIP 556"},
        {"Geneva Identification System", "GEN# +1.00000200"},
        {"Smithsonian Astrophysical Observation", "SAO 128587"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.69557460),
        dec: Angle.Degrees(-04.34981191)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115414",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115414"},
        {"Smithsonian Astrophysical Observation", "SAO 146675"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.277,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.68642822),
        dec: Angle.Degrees(-04.34812993)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178170"},
        {"Hipparcos Number", "HIP 93942"},
        {"Smithsonian Astrophysical Observation", "SAO 143050"},
    },
    visualMagnitude: 9.62,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.92141404),
        dec: Angle.Degrees(-04.34749488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137112"},
        {"Hipparcos Number", "HIP 75385"},
        {"Geneva Identification System", "GEN# +1.00137112"},
        {"Smithsonian Astrophysical Observation", "SAO 140506"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.637,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.06781594),
        dec: Angle.Degrees(-04.34632568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132052"},
        {"Hipparcos Number", "HIP 73165"},
        {"Fundamental Katalog 5th Edition", "FK5 3177"},
        {"Geneva Identification System", "GEN# +1.00132052"},
        {"Renson", "Renson 37490"},
        {"Smithsonian Astrophysical Observation", "SAO 140240"},
        {"Wilson Evans Batten Catalogue", "WEB 12538"},
    },
    visualMagnitude: 4.47,
    bvColour: 0.318,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.29606996),
        dec: Angle.Degrees(-04.34608634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14417"},
        {"Hipparcos Number", "HIP 10854"},
        {"Fundamental Katalog 5th Edition", "FK5 4216"},
        {"Geneva Identification System", "GEN# +1.00014417"},
        {"Smithsonian Astrophysical Observation", "SAO 129830"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.91982842),
        dec: Angle.Degrees(-04.34558086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50593",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7726 AB"},
        {"Henry Draper", "HD 89578"},
        {"Hipparcos Number", "HIP 50593"},
        {"Smithsonian Astrophysical Observation", "SAO 137498"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.02912723),
        dec: Angle.Degrees(-04.34343936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153240"},
        {"Hipparcos Number", "HIP 83058"},
        {"Geneva Identification System", "GEN# +1.00153240"},
        {"Smithsonian Astrophysical Observation", "SAO 141461"},
        {"Wilson Evans Batten Catalogue", "WEB 14043"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.57903817),
        dec: Angle.Degrees(-04.34343100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34734"},
        {"Hipparcos Number", "HIP 24838"},
        {"Celescope Catalog", "CEL 616"},
        {"Geneva Identification System", "GEN# +1.00034734"},
        {"Smithsonian Astrophysical Observation", "SAO 131981"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.87921002),
        dec: Angle.Degrees(-04.34114985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203825"},
        {"Hipparcos Number", "HIP 105715"},
        {"Geneva Identification System", "GEN# +1.00203825"},
        {"Smithsonian Astrophysical Observation", "SAO 145373"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.17280740),
        dec: Angle.Degrees(-04.34080433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206446"},
        {"Hipparcos Number", "HIP 107154"},
        {"Smithsonian Astrophysical Observation", "SAO 145598"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(325.57982068),
        dec: Angle.Degrees(-04.34010436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152555"},
        {"Hipparcos Number", "HIP 82688"},
        {"Geneva Identification System", "GEN# +1.00152555"},
        {"Smithsonian Astrophysical Observation", "SAO 141426"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.591,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.53402417),
        dec: Angle.Degrees(-04.33990566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40575"},
        {"Hipparcos Number", "HIP 28367"},
        {"Smithsonian Astrophysical Observation", "SAO 132725"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.89842175),
        dec: Angle.Degrees(-04.33751585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6078",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1048 A"},
        {"Hipparcos Number", "HIP 6078"},
        {"Smithsonian Astrophysical Observation", "SAO 129218"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.50052841),
        dec: Angle.Degrees(-04.33616257)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10757",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14291"},
        {"Hipparcos Number", "HIP 10757"},
        {"Smithsonian Astrophysical Observation", "SAO 129813"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.60741148),
        dec: Angle.Degrees(-04.33445876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65526"},
        {"Hipparcos Number", "HIP 39017"},
        {"Smithsonian Astrophysical Observation", "SAO 135329"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.76637059),
        dec: Angle.Degrees(-04.33231464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22588"},
        {"Hipparcos Number", "HIP 16949"},
        {"Smithsonian Astrophysical Observation", "SAO 130618"},
    },
    visualMagnitude: 9.27,
    bvColour: 1.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.51938861),
        dec: Angle.Degrees(-04.33179836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6077",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1048 B"},
        {"Hipparcos Number", "HIP 6077"},
    },
    visualMagnitude: 10.79,
    bvColour: 0.748,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.49758295),
        dec: Angle.Degrees(-04.33122964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12608"},
        {"Hipparcos Number", "HIP 9596"},
        {"Geneva Identification System", "GEN# +1.00012608"},
        {"Smithsonian Astrophysical Observation", "SAO 129661"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.85786487),
        dec: Angle.Degrees(-04.32975524)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125021"},
        {"Hipparcos Number", "HIP 69789"},
        {"Smithsonian Astrophysical Observation", "SAO 139838"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.26171778),
        dec: Angle.Degrees(-04.32873466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83837",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154850"},
        {"Hipparcos Number", "HIP 83837"},
        {"Smithsonian Astrophysical Observation", "SAO 141526"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.256,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.00851366),
        dec: Angle.Degrees(-04.32798183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19095"},
        {"Hipparcos Number", "HIP 14288"},
        {"Smithsonian Astrophysical Observation", "SAO 130267"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.04859304),
        dec: Angle.Degrees(-04.32693533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176449"},
        {"Hipparcos Number", "HIP 93323"},
        {"Smithsonian Astrophysical Observation", "SAO 142905"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.11711354),
        dec: Angle.Degrees(-04.32511019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15592",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15592"},
        {"Geneva Identification System", "GEN# -0.00400571"},
        {"Smithsonian Astrophysical Observation", "SAO 130432"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.20407653),
        dec: Angle.Degrees(-04.32437287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88316"},
        {"Hipparcos Number", "HIP 49862"},
        {"Smithsonian Astrophysical Observation", "SAO 137394"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.72978069),
        dec: Angle.Degrees(-04.32348233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192229"},
        {"Hipparcos Number", "HIP 99706"},
        {"Smithsonian Astrophysical Observation", "SAO 144189"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.48989371),
        dec: Angle.Degrees(-04.32206482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5822"},
        {"Hipparcos Number", "HIP 4648"},
        {"Smithsonian Astrophysical Observation", "SAO 129069"},
    },
    visualMagnitude: 7.69,
    bvColour: 1.004,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.92569869),
        dec: Angle.Degrees(-04.32150583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152484"},
        {"Hipparcos Number", "HIP 82653"},
        {"Geneva Identification System", "GEN# +1.00152484"},
        {"Smithsonian Astrophysical Observation", "SAO 141423"},
        {"Wilson Evans Batten Catalogue", "WEB 13954"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.43795652),
        dec: Angle.Degrees(-04.32123776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36137",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58690"},
        {"Hipparcos Number", "HIP 36137"},
        {"Smithsonian Astrophysical Observation", "SAO 134671"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.66277822),
        dec: Angle.Degrees(-04.31842193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177230"},
        {"Hipparcos Number", "HIP 93626"},
        {"Geneva Identification System", "GEN# +1.00177230"},
        {"Wilson Evans Batten Catalogue", "WEB 16263"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.99593107),
        dec: Angle.Degrees(-04.31718217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18182"},
        {"Hipparcos Number", "HIP 13596"},
        {"Smithsonian Astrophysical Observation", "SAO 130185"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.998,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.79619603),
        dec: Angle.Degrees(-04.31660858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12673",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16935"},
        {"Hipparcos Number", "HIP 12673"},
        {"Smithsonian Astrophysical Observation", "SAO 130069"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.70937727),
        dec: Angle.Degrees(-04.31493695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26662"},
        {"Hipparcos Number", "HIP 19689"},
        {"Geneva Identification System", "GEN# +1.00026662"},
        {"Smithsonian Astrophysical Observation", "SAO 131036"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.26047730),
        dec: Angle.Degrees(-04.31199722)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189582"},
        {"Hipparcos Number", "HIP 98513"},
        {"Smithsonian Astrophysical Observation", "SAO 143985"},
    },
    visualMagnitude: 7.54,
    bvColour: 1.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.20252662),
        dec: Angle.Degrees(-04.31148730)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113798"},
        {"Hipparcos Number", "HIP 63938"},
        {"Fundamental Katalog 5th Edition", "FK5 5158"},
        {"Smithsonian Astrophysical Observation", "SAO 139154"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.55604466),
        dec: Angle.Degrees(-04.31052677)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65414",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116545"},
        {"Hipparcos Number", "HIP 65414"},
        {"Smithsonian Astrophysical Observation", "SAO 139322"},
    },
    visualMagnitude: 6.82,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.10881057),
        dec: Angle.Degrees(-04.30863128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98916",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13334 AB"},
        {"Henry Draper", "HD 190437"},
        {"Hipparcos Number", "HIP 98916"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.28011473),
        dec: Angle.Degrees(-04.30819452)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156657"},
        {"Hipparcos Number", "HIP 84710"},
        {"Smithsonian Astrophysical Observation", "SAO 141603"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.948,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.73916275),
        dec: Angle.Degrees(-04.30753795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22745"},
        {"Hipparcos Number", "HIP 17051"},
        {"Smithsonian Astrophysical Observation", "SAO 130636"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.565,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.82685610),
        dec: Angle.Degrees(-04.30515279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94385"},
        {"Hipparcos Number", "HIP 53271"},
        {"Fundamental Katalog 5th Edition", "FK5 4961"},
        {"Smithsonian Astrophysical Observation", "SAO 137869"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.42365775),
        dec: Angle.Degrees(-04.30411074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25433"},
        {"Hipparcos Number", "HIP 18835"},
        {"Smithsonian Astrophysical Observation", "SAO 130889"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.56821164),
        dec: Angle.Degrees(-04.30271930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12037"},
        {"Hipparcos Number", "HIP 9177"},
        {"Geneva Identification System", "GEN# +1.00012037"},
        {"Renson", "Renson 3080"},
        {"Smithsonian Astrophysical Observation", "SAO 129589"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.52928468),
        dec: Angle.Degrees(-04.30183107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184914"},
        {"Hipparcos Number", "HIP 96470"},
        {"Geneva Identification System", "GEN# +1.00184914"},
        {"Smithsonian Astrophysical Observation", "SAO 143596"},
    },
    visualMagnitude: 8.17,
    bvColour: 1.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.18875463),
        dec: Angle.Degrees(-04.29975964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22008",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30018"},
        {"Hipparcos Number", "HIP 22008"},
        {"Fundamental Katalog 5th Edition", "FK5 4426"},
        {"Smithsonian Astrophysical Observation", "SAO 131446"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.270,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.95854656),
        dec: Angle.Degrees(-04.29936899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35778"},
        {"Hipparcos Number", "HIP 25479"},
        {"Smithsonian Astrophysical Observation", "SAO 132117"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.74379251),
        dec: Angle.Degrees(-04.29914015)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84705"},
        {"Hipparcos Number", "HIP 47990"},
        {"Smithsonian Astrophysical Observation", "SAO 137123"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.72483599),
        dec: Angle.Degrees(-04.29796809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207597"},
        {"Hipparcos Number", "HIP 107787"},
        {"Smithsonian Astrophysical Observation", "SAO 145694"},
    },
    visualMagnitude: 8.78,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.53533520),
        dec: Angle.Degrees(-04.29732879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91706"},
        {"Wilson Evans Batten Catalogue", "WEB 15773"},
    },
    visualMagnitude: 10.99,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.53297696),
        dec: Angle.Degrees(-04.29347547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31760",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47454"},
        {"Hipparcos Number", "HIP 31760"},
        {"Geneva Identification System", "GEN# +1.00047454"},
        {"Smithsonian Astrophysical Observation", "SAO 133517"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.64991988),
        dec: Angle.Degrees(-04.29274019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108630"},
        {"Hipparcos Number", "HIP 60890"},
        {"Geneva Identification System", "GEN# +1.00108630"},
        {"Smithsonian Astrophysical Observation", "SAO 138809"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.379,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.18554718),
        dec: Angle.Degrees(-04.29059156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185946"},
        {"Hipparcos Number", "HIP 96894"},
        {"Smithsonian Astrophysical Observation", "SAO 143703"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.44853957),
        dec: Angle.Degrees(-04.28921451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20355"},
        {"Hipparcos Number", "HIP 15236"},
        {"Smithsonian Astrophysical Observation", "SAO 130392"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.11417673),
        dec: Angle.Degrees(-04.28722149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105409"},
        {"Hipparcos Number", "HIP 59182"},
        {"Smithsonian Astrophysical Observation", "SAO 138602"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.05192037),
        dec: Angle.Degrees(-04.28703234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198570"},
        {"Hipparcos Number", "HIP 102936"},
        {"Smithsonian Astrophysical Observation", "SAO 144876"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.83193971),
        dec: Angle.Degrees(-04.28654054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41555",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71615"},
        {"Hipparcos Number", "HIP 41555"},
        {"Geneva Identification System", "GEN# +1.00071615"},
        {"Smithsonian Astrophysical Observation", "SAO 135955"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.09668504),
        dec: Angle.Degrees(-04.28574120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124900"},
        {"Hipparcos Number", "HIP 69724"},
        {"Smithsonian Astrophysical Observation", "SAO 139829"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.735,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.08447507),
        dec: Angle.Degrees(-04.28494836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -189.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9352",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12254"},
        {"Hipparcos Number", "HIP 9352"},
        {"Smithsonian Astrophysical Observation", "SAO 129620"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.144,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.03475841),
        dec: Angle.Degrees(-04.28362153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81342"},
        {"Hipparcos Number", "HIP 46165"},
        {"Geneva Identification System", "GEN# +1.00081342"},
        {"Smithsonian Astrophysical Observation", "SAO 136821"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.436,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.22183463),
        dec: Angle.Degrees(-04.28283031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2482",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2808"},
        {"Hipparcos Number", "HIP 2482"},
        {"Geneva Identification System", "GEN# +1.00002808"},
        {"Smithsonian Astrophysical Observation", "SAO 128805"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.88192575),
        dec: Angle.Degrees(-04.28187876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77899",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77899"},
    },
    visualMagnitude: 11.49,
    bvColour: 0.940,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.62180646),
        dec: Angle.Degrees(-04.28026711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -357.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 92.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83936"},
        {"Hipparcos Number", "HIP 47546"},
        {"Smithsonian Astrophysical Observation", "SAO 137054"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.599,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.40035379),
        dec: Angle.Degrees(-04.27989641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17416",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2732 AB"},
        {"Henry Draper", "HD 23291"},
        {"Hipparcos Number", "HIP 17416"},
        {"Smithsonian Astrophysical Observation", "SAO 130692"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.97786967),
        dec: Angle.Degrees(-04.27953814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71462",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128428"},
        {"Hipparcos Number", "HIP 71462"},
        {"Cincinnati Publication", "Ci 18 1923"},
        {"Geneva Identification System", "GEN# +1.00128428"},
        {"Smithsonian Astrophysical Observation", "SAO 140035"},
        {"Wilson Evans Batten Catalogue", "WEB 12329"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.755,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.22457920),
        dec: Angle.Degrees(-04.27901580)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -358.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36394",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59334"},
        {"Hipparcos Number", "HIP 36394"},
    },
    visualMagnitude: 12.34,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.33883065),
        dec: Angle.Degrees(-04.27880062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208111"},
        {"Hipparcos Number", "HIP 108102"},
        {"Geneva Identification System", "GEN# +1.00208111"},
        {"Smithsonian Astrophysical Observation", "SAO 145731"},
        {"Wilson Evans Batten Catalogue", "WEB 19490"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.185,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.54309196),
        dec: Angle.Degrees(-04.27595735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12691",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12691"},
        {"Smithsonian Astrophysical Observation", "SAO 130071"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.76036549),
        dec: Angle.Degrees(-04.27496910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 114.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66966",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9002 A"},
        {"Henry Draper", "HD 119461"},
        {"Hipparcos Number", "HIP 66966"},
        {"Geneva Identification System", "GEN# +1.00119461A"},
        {"Smithsonian Astrophysical Observation", "SAO 139507"},
        {"Wilson Evans Batten Catalogue", "WEB 11803"},
    },
    visualMagnitude: 7.06,
    bvColour: 1.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.87654816),
        dec: Angle.Degrees(-04.27443025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16347",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2581 AB"},
        {"Henry Draper", "HD 21789"},
        {"Hipparcos Number", "HIP 16347"},
        {"Smithsonian Astrophysical Observation", "SAO 130529"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.66390786),
        dec: Angle.Degrees(-04.27327348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9424",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12368"},
        {"Hipparcos Number", "HIP 9424"},
        {"Smithsonian Astrophysical Observation", "SAO 129634"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.26795202),
        dec: Angle.Degrees(-04.27205099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37480"},
        {"Hipparcos Number", "HIP 26558"},
        {"Geneva Identification System", "GEN# +1.00037480"},
        {"Smithsonian Astrophysical Observation", "SAO 132409"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.009,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.70916272),
        dec: Angle.Degrees(-04.27178086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4361 A"},
        {"Henry Draper", "HD 38495"},
        {"Hipparcos Number", "HIP 27212"},
        {"Geneva Identification System", "GEN# +1.00038495A"},
        {"Smithsonian Astrophysical Observation", "SAO 132515"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.51192813),
        dec: Angle.Degrees(-04.26831821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80053",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80053"},
        {"Geneva Identification System", "GEN# +9.80017011"},
        {"Geneva Identification System 2", "GEN# +6.10029555"},
    },
    visualMagnitude: 10.69,
    bvColour: 1.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.10426829),
        dec: Angle.Degrees(-04.26725427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -417.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210434"},
        {"Hipparcos Number", "HIP 109466"},
        {"Geneva Identification System", "GEN# +1.00210434"},
        {"Smithsonian Astrophysical Observation", "SAO 145916"},
        {"Wilson Evans Batten Catalogue", "WEB 19670"},
    },
    visualMagnitude: 5.98,
    bvColour: 0.981,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.64043335),
        dec: Angle.Degrees(-04.26686395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201985"},
        {"Hipparcos Number", "HIP 104743"},
        {"Geneva Identification System", "GEN# +1.00201985"},
        {"Smithsonian Astrophysical Observation", "SAO 145210"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.30709079),
        dec: Angle.Degrees(-04.26674271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53033"},
        {"Hipparcos Number", "HIP 34010"},
        {"Smithsonian Astrophysical Observation", "SAO 134121"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.86142550),
        dec: Angle.Degrees(-04.26637035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32839",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49935"},
        {"Hipparcos Number", "HIP 32839"},
        {"Renson", "Renson 13545"},
        {"Smithsonian Astrophysical Observation", "SAO 133758"},
    },
    visualMagnitude: 6.87,
    bvColour: -0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.68027184),
        dec: Angle.Degrees(-04.26620930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125079"},
        {"Hipparcos Number", "HIP 69817"},
        {"Smithsonian Astrophysical Observation", "SAO 139848"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.33630032),
        dec: Angle.Degrees(-04.26607733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86814"},
        {"Hipparcos Number", "HIP 49072"},
        {"Smithsonian Astrophysical Observation", "SAO 137289"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.23116314),
        dec: Angle.Degrees(-04.26493463)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90578",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 90578"},
        {"Geneva Identification System", "GEN# -0.00404475"},
    },
    visualMagnitude: 10.68,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.24174366),
        dec: Angle.Degrees(-04.26427717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35221"},
        {"Hipparcos Number", "HIP 25167"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.76431619),
        dec: Angle.Degrees(-04.26413199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149200"},
        {"Hipparcos Number", "HIP 81062"},
        {"Geneva Identification System", "GEN# +1.00149200"},
        {"Smithsonian Astrophysical Observation", "SAO 141237"},
    },
    visualMagnitude: 7.24,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.34757339),
        dec: Angle.Degrees(-04.26185658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31393",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46736"},
        {"Hipparcos Number", "HIP 31393"},
        {"Smithsonian Astrophysical Observation", "SAO 133432"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.71434456),
        dec: Angle.Degrees(-04.25525624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36342"},
        {"Hipparcos Number", "HIP 25830"},
        {"Geneva Identification System", "GEN# +1.00036342"},
        {"Smithsonian Astrophysical Observation", "SAO 132200"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.72053587),
        dec: Angle.Degrees(-04.25466158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49369"},
        {"Hipparcos Number", "HIP 32594"},
        {"Geneva Identification System", "GEN# +1.00049369"},
        {"Smithsonian Astrophysical Observation", "SAO 133682"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.99723084),
        dec: Angle.Degrees(-04.25188894)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116092",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221337"},
        {"Hipparcos Number", "HIP 116092"},
        {"Smithsonian Astrophysical Observation", "SAO 146751"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.85398923),
        dec: Angle.Degrees(-04.25138953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41063"},
        {"Hipparcos Number", "HIP 28629"},
        {"Smithsonian Astrophysical Observation", "SAO 132771"},
    },
    visualMagnitude: 9.03,
    bvColour: 0.471,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.66537132),
        dec: Angle.Degrees(-04.25089184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106833"},
        {"Hipparcos Number", "HIP 59893"},
        {"Geneva Identification System", "GEN# +1.00106833"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.876,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.26281638),
        dec: Angle.Degrees(-04.25067587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -240.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211530"},
        {"Hipparcos Number", "HIP 110075"},
        {"Renson", "Renson 58730"},
        {"Smithsonian Astrophysical Observation", "SAO 146001"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.45711902),
        dec: Angle.Degrees(-04.25064136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80218",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147512"},
        {"Hipparcos Number", "HIP 80218"},
        {"Geneva Identification System", "GEN# +1.00147512"},
        {"Smithsonian Astrophysical Observation", "SAO 141126"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.718,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.63653441),
        dec: Angle.Degrees(-04.24881792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -175.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18030"},
        {"Hipparcos Number", "HIP 13491"},
        {"Smithsonian Astrophysical Observation", "SAO 130176"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.43085389),
        dec: Angle.Degrees(-04.24749130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70906",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9284 A"},
        {"Henry Draper", "HD 127168"},
        {"Hipparcos Number", "HIP 70906"},
        {"Geneva Identification System", "GEN# +1.00127168A"},
        {"Smithsonian Astrophysical Observation", "SAO 139969"},
        {"Wilson Evans Batten Catalogue", "WEB 12276"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.50081442),
        dec: Angle.Degrees(-04.24716587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -95.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80746"},
        {"Hipparcos Number", "HIP 45889"},
        {"Smithsonian Astrophysical Observation", "SAO 136778"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.35103823),
        dec: Angle.Degrees(-04.24696647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46543",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82074"},
        {"Hipparcos Number", "HIP 46543"},
        {"Geneva Identification System", "GEN# +1.00082074"},
        {"Smithsonian Astrophysical Observation", "SAO 136900"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.838,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.38514104),
        dec: Angle.Degrees(-04.24650832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5625"},
        {"Hipparcos Number", "HIP 4516"},
        {"Smithsonian Astrophysical Observation", "SAO 129051"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.47152006),
        dec: Angle.Degrees(-04.24404018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85364"},
        {"Hipparcos Number", "HIP 48341"},
        {"Fundamental Katalog 5th Edition", "FK5 370"},
        {"Geneva Identification System", "GEN# +1.00085364"},
        {"Smithsonian Astrophysical Observation", "SAO 137183"},
        {"Wilson Evans Batten Catalogue", "WEB 9017"},
    },
    visualMagnitude: 6.01,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.80843348),
        dec: Angle.Degrees(-04.24328092)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70630"},
        {"Hipparcos Number", "HIP 41084"},
        {"Smithsonian Astrophysical Observation", "SAO 135838"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.73623792),
        dec: Angle.Degrees(-04.24319964)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105075",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14813 A"},
        {"Henry Draper", "HD 202632"},
        {"Hipparcos Number", "HIP 105075"},
        {"Smithsonian Astrophysical Observation", "SAO 145265"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.29441829),
        dec: Angle.Degrees(-04.23953647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33971",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52918"},
        {"Hipparcos Number", "HIP 33971"},
        {"Fundamental Katalog 5th Edition", "FK5 2547"},
        {"Geneva Identification System", "GEN# +1.00052918"},
        {"Smithsonian Astrophysical Observation", "SAO 134106"},
        {"Wilson Evans Batten Catalogue", "WEB 6815"},
    },
    visualMagnitude: 4.99,
    bvColour: -0.195,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.72824798),
        dec: Angle.Degrees(-04.23923814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78089",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78089"},
    },
    visualMagnitude: 11.90,
    bvColour: 1.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.17233671),
        dec: Angle.Degrees(-04.23876433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 147.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54810"},
        {"Hipparcos Number", "HIP 34622"},
        {"Fundamental Katalog 5th Edition", "FK5 1186"},
        {"Geneva Identification System", "GEN# +1.00054810"},
        {"Smithsonian Astrophysical Observation", "SAO 134282"},
        {"Wilson Evans Batten Catalogue", "WEB 6929"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.55700787),
        dec: Angle.Degrees(-04.23763568)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 217.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72309",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130238"},
        {"Hipparcos Number", "HIP 72309"},
        {"Geneva Identification System", "GEN# +1.00130238"},
        {"Smithsonian Astrophysical Observation", "SAO 140141"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.558,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.80376781),
        dec: Angle.Degrees(-04.23419415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3896"},
        {"Hipparcos Number", "HIP 3260"},
        {"Geneva Identification System", "GEN# +1.00003896"},
        {"Smithsonian Astrophysical Observation", "SAO 128900"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.37697668),
        dec: Angle.Degrees(-04.23282000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162558"},
        {"Hipparcos Number", "HIP 87406"},
        {"Smithsonian Astrophysical Observation", "SAO 141911"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.93720963),
        dec: Angle.Degrees(-04.23136176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8227",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10823"},
        {"Hipparcos Number", "HIP 8227"},
        {"Geneva Identification System", "GEN# +1.00010823"},
        {"Smithsonian Astrophysical Observation", "SAO 129489"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.49048809),
        dec: Angle.Degrees(-04.22857946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112559",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215812"},
        {"Hipparcos Number", "HIP 112559"},
        {"Geneva Identification System", "GEN# +1.00215812"},
        {"Smithsonian Astrophysical Observation", "SAO 146315"},
        {"Wilson Evans Batten Catalogue", "WEB 20068"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.95958960),
        dec: Angle.Degrees(-04.22827511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111710",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Situla"},
        {"Henry Draper", "HD 214376"},
        {"Hipparcos Number", "HIP 111710"},
        {"Fundamental Katalog 5th Edition", "FK5 1595"},
        {"Geneva Identification System", "GEN# +1.00214376"},
        {"Smithsonian Astrophysical Observation", "SAO 146210"},
        {"Wilson Evans Batten Catalogue", "WEB 19962"},
    },
    visualMagnitude: 5.04,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.43925419),
        dec: Angle.Degrees(-04.22776291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -120.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81170",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149414"},
        {"Hipparcos Number", "HIP 81170"},
        {"Cincinnati Publication", "Ci 20 1000"},
        {"Geneva Identification System", "GEN# +1.00149414A"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.736,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.67679862),
        dec: Angle.Degrees(-04.22735892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -704.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108081"},
        {"Hipparcos Number", "HIP 60574"},
        {"Geneva Identification System", "GEN# +1.00108081"},
        {"Smithsonian Astrophysical Observation", "SAO 138762"},
        {"Wilson Evans Batten Catalogue", "WEB 10770"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.24602649),
        dec: Angle.Degrees(-04.22513591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -124.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -211.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13143",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17559"},
        {"Hipparcos Number", "HIP 13143"},
        {"Smithsonian Astrophysical Observation", "SAO 130127"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.26084641),
        dec: Angle.Degrees(-04.22480082)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62915",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112048"},
        {"Hipparcos Number", "HIP 62915"},
        {"Geneva Identification System", "GEN# +1.00112048"},
        {"Smithsonian Astrophysical Observation", "SAO 139027"},
        {"Wilson Evans Batten Catalogue", "WEB 11155"},
    },
    visualMagnitude: 6.45,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.40883586),
        dec: Angle.Degrees(-04.22450913)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42586",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73925"},
        {"Hipparcos Number", "HIP 42586"},
        {"Smithsonian Astrophysical Observation", "SAO 136168"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.19408024),
        dec: Angle.Degrees(-04.22247357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153687"},
        {"Hipparcos Number", "HIP 83262"},
        {"Fundamental Katalog 5th Edition", "FK5 1445"},
        {"Geneva Identification System", "GEN# +1.00153687"},
        {"Smithsonian Astrophysical Observation", "SAO 141483"},
        {"Wilson Evans Batten Catalogue", "WEB 14072"},
    },
    visualMagnitude: 4.82,
    bvColour: 1.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.26510631),
        dec: Angle.Degrees(-04.22245426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153437"},
        {"Hipparcos Number", "HIP 83166"},
        {"Smithsonian Astrophysical Observation", "SAO 141473"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.95576790),
        dec: Angle.Degrees(-04.22122877)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8048 A"},
        {"Henry Draper", "HD 96064"},
        {"Hipparcos Number", "HIP 54155"},
        {"Geneva Identification System", "GEN# +1.00096064A"},
        {"Smithsonian Astrophysical Observation", "SAO 137978"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.17323941),
        dec: Angle.Degrees(-04.22083700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145788"},
        {"Hipparcos Number", "HIP 79463"},
        {"Geneva Identification System", "GEN# +1.00145788"},
        {"Renson", "Renson 41270"},
        {"Smithsonian Astrophysical Observation", "SAO 141031"},
        {"Wilson Evans Batten Catalogue", "WEB 13438"},
    },
    visualMagnitude: 6.26,
    bvColour: 0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.23583690),
        dec: Angle.Degrees(-04.22076069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208243"},
        {"Hipparcos Number", "HIP 108173"},
        {"Smithsonian Astrophysical Observation", "SAO 145740"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.74492587),
        dec: Angle.Degrees(-04.22004992)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11339"},
        {"Hipparcos Number", "HIP 8650"},
        {"Geneva Identification System", "GEN# +1.00011339"},
        {"Smithsonian Astrophysical Observation", "SAO 129535"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.87017068),
        dec: Angle.Degrees(-04.21995418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24901"},
        {"Hipparcos Number", "HIP 18511"},
        {"Smithsonian Astrophysical Observation", "SAO 130841"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.36849179),
        dec: Angle.Degrees(-04.21907658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23830",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33047"},
        {"Hipparcos Number", "HIP 23830"},
        {"Smithsonian Astrophysical Observation", "SAO 131788"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.85181106),
        dec: Angle.Degrees(-04.21761114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12984"},
        {"Hipparcos Number", "HIP 9874"},
        {"Fundamental Katalog 5th Edition", "FK5 4191"},
        {"Geneva Identification System", "GEN# +1.00012984"},
        {"Smithsonian Astrophysical Observation", "SAO 129700"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.75793858),
        dec: Angle.Degrees(-04.21752099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81706",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150466"},
        {"Hipparcos Number", "HIP 81706"},
        {"Geneva Identification System", "GEN# +1.00150466"},
        {"Smithsonian Astrophysical Observation", "SAO 141311"},
        {"Wilson Evans Batten Catalogue", "WEB 13801"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.463,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.34374751),
        dec: Angle.Degrees(-04.21474572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57884"},
        {"Hipparcos Number", "HIP 35810"},
        {"Geneva Identification System", "GEN# +1.00057884"},
        {"Wilson Evans Batten Catalogue", "WEB 7136"},
    },
    visualMagnitude: 9.01,
    bvColour: 2.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.77914904),
        dec: Angle.Degrees(-04.21355204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83604"},
        {"Hipparcos Number", "HIP 47409"},
        {"Smithsonian Astrophysical Observation", "SAO 137033"},
    },
    visualMagnitude: 8.21,
    bvColour: -0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.90686407),
        dec: Angle.Degrees(-04.21271075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163036"},
        {"Hipparcos Number", "HIP 87659"},
        {"Smithsonian Astrophysical Observation", "SAO 141953"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.912,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.56654276),
        dec: Angle.Degrees(-04.21192391)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32393"},
        {"Hipparcos Number", "HIP 23475"},
        {"Geneva Identification System", "GEN# +1.00032393"},
        {"Smithsonian Astrophysical Observation", "SAO 131715"},
        {"Wilson Evans Batten Catalogue", "WEB 4570"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.212,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.68904194),
        dec: Angle.Degrees(-04.21012550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18530"},
        {"Hipparcos Number", "HIP 13872"},
        {"Renson", "Renson 4644"},
        {"Smithsonian Astrophysical Observation", "SAO 130214"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.184,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.66549002),
        dec: Angle.Degrees(-04.20872326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5281",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5281"},
        {"Smithsonian Astrophysical Observation", "SAO 129131"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.88531789),
        dec: Angle.Degrees(-04.20691856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28489"},
        {"Hipparcos Number", "HIP 20942"},
        {"Smithsonian Astrophysical Observation", "SAO 131242"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.35011677),
        dec: Angle.Degrees(-04.20625774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32527"},
        {"Hipparcos Number", "HIP 23540"},
        {"Geneva Identification System", "GEN# +1.00032527"},
        {"Smithsonian Astrophysical Observation", "SAO 131732"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.92996554),
        dec: Angle.Degrees(-04.20552769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79957"},
        {"Hipparcos Number", "HIP 45537"},
        {"Renson", "Renson 22746"},
        {"Smithsonian Astrophysical Observation", "SAO 136729"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.21871218),
        dec: Angle.Degrees(-04.20356091)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42863",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6964 AB"},
        {"Henry Draper", "HD 74469"},
        {"Hipparcos Number", "HIP 42863"},
        {"Smithsonian Astrophysical Observation", "SAO 136226"},
    },
    visualMagnitude: 7.30,
    bvColour: 0.166,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.01695062),
        dec: Angle.Degrees(-04.20214985)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114120",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16512 A"},
        {"Henry Draper", "HD 218262"},
        {"Hipparcos Number", "HIP 114120"},
        {"Smithsonian Astrophysical Observation", "SAO 146514"},
    },
    visualMagnitude: 9.13,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.67429896),
        dec: Angle.Degrees(-04.20088229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16512 B"},
        {"Hipparcos Number", "HIP 114118"},
    },
    visualMagnitude: 10.61,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.67038326),
        dec: Angle.Degrees(-04.19952737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43397",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7040 A"},
        {"Henry Draper", "HD 75529"},
        {"Hipparcos Number", "HIP 43397"},
        {"Smithsonian Astrophysical Observation", "SAO 136325"},
    },
    visualMagnitude: 6.92,
    bvColour: 0.924,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.60283972),
        dec: Angle.Degrees(-04.19726330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 72.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28949",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4698 A"},
        {"Henry Draper", "HD 41692"},
        {"Hipparcos Number", "HIP 28949"},
        {"Celescope Catalog", "CEL 1080"},
        {"Fundamental Katalog 5th Edition", "FK5 2467"},
        {"Geneva Identification System", "GEN# +1.00041692"},
        {"Smithsonian Astrophysical Observation", "SAO 132841"},
        {"Wilson Evans Batten Catalogue", "WEB 5665"},
    },
    visualMagnitude: 5.37,
    bvColour: -0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.66141788),
        dec: Angle.Degrees(-04.19382480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35733"},
        {"Hipparcos Number", "HIP 25460"},
    },
    visualMagnitude: 9.67,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.67556444),
        dec: Angle.Degrees(-04.19218322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95217"},
        {"Hipparcos Number", "HIP 53728"},
        {"Smithsonian Astrophysical Observation", "SAO 137928"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.153,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.89047564),
        dec: Angle.Degrees(-04.19201120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84205",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155596"},
        {"Hipparcos Number", "HIP 84205"},
        {"Smithsonian Astrophysical Observation", "SAO 141558"},
    },
    visualMagnitude: 9.46,
    bvColour: 0.541,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.19489497),
        dec: Angle.Degrees(-04.18916931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213130"},
        {"Hipparcos Number", "HIP 111009"},
        {"Smithsonian Astrophysical Observation", "SAO 146117"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.34873814),
        dec: Angle.Degrees(-04.18809163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66675",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118926"},
        {"Hipparcos Number", "HIP 66675"},
        {"Cincinnati Publication", "Ci 20 794"},
        {"Geneva Identification System", "GEN# +1.00118926"},
        {"Smithsonian Astrophysical Observation", "SAO 139476"},
        {"Wilson Evans Batten Catalogue", "WEB 11761"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.03065332),
        dec: Angle.Degrees(-04.18727591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -385.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 482.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97272",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186708"},
        {"Hipparcos Number", "HIP 97272"},
        {"Smithsonian Astrophysical Observation", "SAO 143782"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.53846589),
        dec: Angle.Degrees(-04.18456210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135809"},
        {"Hipparcos Number", "HIP 74804"},
        {"Geneva Identification System", "GEN# +1.00135809"},
        {"Smithsonian Astrophysical Observation", "SAO 140433"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.31568299),
        dec: Angle.Degrees(-04.18436797)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159628"},
        {"Hipparcos Number", "HIP 86111"},
        {"Smithsonian Astrophysical Observation", "SAO 141752"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.366,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.97207102),
        dec: Angle.Degrees(-04.18415522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26132"},
        {"Hipparcos Number", "HIP 19282"},
        {"Smithsonian Astrophysical Observation", "SAO 130969"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.99140298),
        dec: Angle.Degrees(-04.18386663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91317"},
        {"Hipparcos Number", "HIP 51609"},
        {"Smithsonian Astrophysical Observation", "SAO 137630"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.13901156),
        dec: Angle.Degrees(-04.18293284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101104",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195155"},
        {"Hipparcos Number", "HIP 101104"},
        {"Smithsonian Astrophysical Observation", "SAO 144496"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.41981280),
        dec: Angle.Degrees(-04.18258075)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103627",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103627"},
    },
    visualMagnitude: 11.70,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.94305180),
        dec: Angle.Degrees(-04.17969096)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 42.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -204.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71171"},
        {"Hipparcos Number", "HIP 41316"},
        {"Smithsonian Astrophysical Observation", "SAO 135901"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.45247592),
        dec: Angle.Degrees(-04.17793143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11852"},
        {"Hipparcos Number", "HIP 9033"},
        {"Geneva Identification System", "GEN# +1.00011852"},
        {"Smithsonian Astrophysical Observation", "SAO 129573"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.434,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.08104660),
        dec: Angle.Degrees(-04.17736444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 85.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105483",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203384"},
        {"Hipparcos Number", "HIP 105483"},
        {"Smithsonian Astrophysical Observation", "SAO 145331"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.762,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.47312814),
        dec: Angle.Degrees(-04.17399146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 221.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21620",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29490"},
        {"Hipparcos Number", "HIP 21620"},
        {"Smithsonian Astrophysical Observation", "SAO 131374"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.62673672),
        dec: Angle.Degrees(-04.16920571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82905",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82905"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.12577063),
        dec: Angle.Degrees(-04.16706549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56419",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100519"},
        {"Hipparcos Number", "HIP 56419"},
        {"Smithsonian Astrophysical Observation", "SAO 138272"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.51688193),
        dec: Angle.Degrees(-04.16609939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123211"},
        {"Hipparcos Number", "HIP 68899"},
        {"Smithsonian Astrophysical Observation", "SAO 139734"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.60146857),
        dec: Angle.Degrees(-04.16379902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152600"},
        {"Hipparcos Number", "HIP 82715"},
        {"Geneva Identification System", "GEN# +1.00152600"},
        {"Smithsonian Astrophysical Observation", "SAO 141430"},
    },
    visualMagnitude: 7.58,
    bvColour: 1.217,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.61214196),
        dec: Angle.Degrees(-04.16378034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204429"},
        {"Hipparcos Number", "HIP 106031"},
        {"Smithsonian Astrophysical Observation", "SAO 145422"},
    },
    visualMagnitude: 9.51,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.14765430),
        dec: Angle.Degrees(-04.16345931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84328",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155864"},
        {"Hipparcos Number", "HIP 84328"},
        {"Smithsonian Astrophysical Observation", "SAO 141569"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.59682285),
        dec: Angle.Degrees(-04.16198252)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58197"},
    },
    visualMagnitude: 11.21,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.03438545),
        dec: Angle.Degrees(-04.15894114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -150.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146013"},
        {"Hipparcos Number", "HIP 79567"},
        {"Smithsonian Astrophysical Observation", "SAO 141048"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.126,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.52710787),
        dec: Angle.Degrees(-04.15846146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18276",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24604"},
        {"Hipparcos Number", "HIP 18276"},
        {"Geneva Identification System", "GEN# +1.00024604"},
        {"Smithsonian Astrophysical Observation", "SAO 130810"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.64364126),
        dec: Angle.Degrees(-04.15791286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106870",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205925"},
        {"Hipparcos Number", "HIP 106870"},
        {"Smithsonian Astrophysical Observation", "SAO 145555"},
    },
    visualMagnitude: 6.73,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.67183095),
        dec: Angle.Degrees(-04.15032648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81861",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150765"},
        {"Hipparcos Number", "HIP 81861"},
        {"Smithsonian Astrophysical Observation", "SAO 141328"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.80201017),
        dec: Angle.Degrees(-04.15019708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 20142"},
    },
    visualMagnitude: 10.62,
    bvColour: 1.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.77374076),
        dec: Angle.Degrees(-04.14877633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 98.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22785"},
        {"Hipparcos Number", "HIP 17085"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90968485),
        dec: Angle.Degrees(-04.14842694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87976"},
        {"Hipparcos Number", "HIP 49684"},
        {"Smithsonian Astrophysical Observation", "SAO 137373"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.13584510),
        dec: Angle.Degrees(-04.14662813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17180",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22919"},
        {"Hipparcos Number", "HIP 17180"},
        {"Geneva Identification System", "GEN# +1.00022919"},
        {"Smithsonian Astrophysical Observation", "SAO 130654"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.19259153),
        dec: Angle.Degrees(-04.14609248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 267",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225086"},
        {"Henry Draper 2", "HD 225086A"},
        {"Hipparcos Number", "HIP 267"},
        {"Smithsonian Astrophysical Observation", "SAO 128557"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.83541112),
        dec: Angle.Degrees(-04.14573041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7546",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9959"},
        {"Hipparcos Number", "HIP 7546"},
        {"Smithsonian Astrophysical Observation", "SAO 129406"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.30528119),
        dec: Angle.Degrees(-04.14285958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48332"},
        {"Hipparcos Number", "HIP 32146"},
        {"Geneva Identification System", "GEN# +1.00048332"},
        {"Smithsonian Astrophysical Observation", "SAO 133603"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.501,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.69786382),
        dec: Angle.Degrees(-04.14088297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20431"},
        {"Hipparcos Number", "HIP 15281"},
        {"Geneva Identification System", "GEN# +1.00020431"},
        {"Renson", "Renson 5087"},
        {"Smithsonian Astrophysical Observation", "SAO 130400"},
    },
    visualMagnitude: 7.39,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.29193878),
        dec: Angle.Degrees(-04.13971989)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201689"},
        {"Hipparcos Number", "HIP 104595"},
        {"Smithsonian Astrophysical Observation", "SAO 145178"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.81772750),
        dec: Angle.Degrees(-04.13965376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11804"},
        {"Hipparcos Number", "HIP 8978"},
        {"Smithsonian Astrophysical Observation", "SAO 129569"},
    },
    visualMagnitude: 9.21,
    bvColour: 0.915,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.92669872),
        dec: Angle.Degrees(-04.13922528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56848",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101281"},
        {"Hipparcos Number", "HIP 56848"},
        {"Smithsonian Astrophysical Observation", "SAO 138321"},
    },
    visualMagnitude: 8.63,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.83052507),
        dec: Angle.Degrees(-04.13721118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130898"},
        {"Hipparcos Number", "HIP 72618"},
        {"Geneva Identification System", "GEN# +1.00130898"},
        {"Smithsonian Astrophysical Observation", "SAO 140174"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.986,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.71582687),
        dec: Angle.Degrees(-04.13358775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200139"},
        {"Hipparcos Number", "HIP 103769"},
        {"Smithsonian Astrophysical Observation", "SAO 145037"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.41856025),
        dec: Angle.Degrees(-04.13151651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62305"},
        {"Hipparcos Number", "HIP 37624"},
        {"Geneva Identification System", "GEN# +1.00062305"},
        {"Smithsonian Astrophysical Observation", "SAO 135023"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.81006509),
        dec: Angle.Degrees(-04.13096591)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179048"},
        {"Hipparcos Number", "HIP 94253"},
        {"Smithsonian Astrophysical Observation", "SAO 143109"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.78457225),
        dec: Angle.Degrees(-04.12937163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107501",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207051"},
        {"Hipparcos Number", "HIP 107501"},
        {"Smithsonian Astrophysical Observation", "SAO 145649"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.438,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.59533597),
        dec: Angle.Degrees(-04.12765192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10821",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14387"},
        {"Hipparcos Number", "HIP 10821"},
        {"Smithsonian Astrophysical Observation", "SAO 129824"},
    },
    visualMagnitude: 8.69,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.82862688),
        dec: Angle.Degrees(-04.12719381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103783"},
        {"Hipparcos Number", "HIP 58282"},
        {"Smithsonian Astrophysical Observation", "SAO 138498"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.29194209),
        dec: Angle.Degrees(-04.12646375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12166"},
        {"Hipparcos Number", "HIP 9288"},
        {"Smithsonian Astrophysical Observation", "SAO 129605"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.83769545),
        dec: Angle.Degrees(-04.12465652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88726"},
        {"Hipparcos Number", "HIP 50119"},
        {"Smithsonian Astrophysical Observation", "SAO 137427"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.47738105),
        dec: Angle.Degrees(-04.12455230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30798"},
        {"Hipparcos Number", "HIP 22511"},
        {"Smithsonian Astrophysical Observation", "SAO 131536"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.65739483),
        dec: Angle.Degrees(-04.12137187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27850"},
        {"Hipparcos Number", "HIP 20503"},
        {"Geneva Identification System", "GEN# +1.00027850"},
        {"Smithsonian Astrophysical Observation", "SAO 131175"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.90722411),
        dec: Angle.Degrees(-04.12100328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29938"},
        {"Hipparcos Number", "HIP 21927"},
        {"Smithsonian Astrophysical Observation", "SAO 131426"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.72426815),
        dec: Angle.Degrees(-04.11983851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104786"},
        {"Hipparcos Number", "HIP 58829"},
        {"Smithsonian Astrophysical Observation", "SAO 138560"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.99723557),
        dec: Angle.Degrees(-04.11692596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18618"},
        {"Hipparcos Number", "HIP 13938"},
        {"Geneva Identification System", "GEN# +1.00018618"},
        {"Smithsonian Astrophysical Observation", "SAO 130223"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.508,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.89320408),
        dec: Angle.Degrees(-04.11634048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 227.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1653"},
        {"Hipparcos Number", "HIP 1661"},
        {"Smithsonian Astrophysical Observation", "SAO 128702"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.20579352),
        dec: Angle.Degrees(-04.11590834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61064"},
        {"Hipparcos Number", "HIP 37088"},
        {"Fundamental Katalog 5th Edition", "FK5 289"},
        {"Geneva Identification System", "GEN# +1.00061064"},
        {"Smithsonian Astrophysical Observation", "SAO 134899"},
        {"Wilson Evans Batten Catalogue", "WEB 7355"},
    },
    visualMagnitude: 5.14,
    bvColour: 0.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.31971063),
        dec: Angle.Degrees(-04.11102250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172730"},
        {"Hipparcos Number", "HIP 91697"},
        {"Geneva Identification System", "GEN# +1.00172730"},
        {"Wilson Evans Batten Catalogue", "WEB 15770"},
    },
    visualMagnitude: 9.44,
    bvColour: 1.810,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.48492418),
        dec: Angle.Degrees(-04.11065848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26182",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36916"},
        {"Hipparcos Number", "HIP 26182"},
        {"Celescope Catalog", "CEL 812"},
        {"Geneva Identification System", "GEN# +1.00036916"},
        {"Renson", "Renson 9700"},
        {"Smithsonian Astrophysical Observation", "SAO 132292"},
    },
    visualMagnitude: 6.74,
    bvColour: -0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.72486479),
        dec: Angle.Degrees(-04.11041714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197475"},
        {"Hipparcos Number", "HIP 102340"},
        {"Fundamental Katalog 5th Edition", "FK5 5823"},
        {"Smithsonian Astrophysical Observation", "SAO 144745"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.03282231),
        dec: Angle.Degrees(-04.10961931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37410"},
        {"Hipparcos Number", "HIP 26510"},
        {"Fundamental Katalog 5th Edition", "FK5 4512"},
        {"Geneva Identification System", "GEN# +1.00037410"},
        {"Renson", "Renson 10040"},
        {"Smithsonian Astrophysical Observation", "SAO 132392"},
    },
    visualMagnitude: 6.86,
    bvColour: 0.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.56368626),
        dec: Angle.Degrees(-04.10818770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 65940"},
        {"Geneva Identification System", "GEN# -0.00303488"},
    },
    visualMagnitude: 10.41,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.77558869),
        dec: Angle.Degrees(-04.10559539)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70004"},
        {"Smithsonian Astrophysical Observation", "SAO 139865"},
    },
    visualMagnitude: 9.92,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.86526715),
        dec: Angle.Degrees(-04.10557090)
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
    primaryId: "HIP 89755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168245"},
        {"Hipparcos Number", "HIP 89755"},
        {"Fundamental Katalog 5th Edition", "FK5 5614"},
        {"Smithsonian Astrophysical Observation", "SAO 142218"},
        {"Wilson Evans Batten Catalogue", "WEB 15305"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.74691168),
        dec: Angle.Degrees(-04.10544538)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6968",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6968"},
        {"Smithsonian Astrophysical Observation", "SAO 129327"},
    },
    visualMagnitude: 9.53,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.42359898),
        dec: Angle.Degrees(-04.10397040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12642"},
        {"Hipparcos Number", "HIP 9622"},
        {"Fundamental Katalog 5th Edition", "FK5 2143"},
        {"Geneva Identification System", "GEN# +1.00012642"},
        {"Smithsonian Astrophysical Observation", "SAO 129665"},
        {"Wilson Evans Batten Catalogue", "WEB 2022"},
    },
    visualMagnitude: 5.61,
    bvColour: 1.589,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.91868509),
        dec: Angle.Degrees(-04.10336397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14264"},
        {"Hipparcos Number", "HIP 10746"},
        {"Smithsonian Astrophysical Observation", "SAO 129810"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.56607176),
        dec: Angle.Degrees(-04.09763127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 93.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73490",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9476 AB"},
        {"Henry Draper", "HD 132797"},
        {"Hipparcos Number", "HIP 73490"},
        {"Geneva Identification System", "GEN# +1.00132797"},
        {"Smithsonian Astrophysical Observation", "SAO 140274"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.090,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.29320460),
        dec: Angle.Degrees(-04.09722153)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13999"},
        {"Hipparcos Number", "HIP 10561"},
        {"Smithsonian Astrophysical Observation", "SAO 129787"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.98917841),
        dec: Angle.Degrees(-04.09501161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38858"},
        {"Hipparcos Number", "HIP 27435"},
        {"Fundamental Katalog 5th Edition", "FK5 1155"},
        {"Geneva Identification System", "GEN# +1.00038858"},
        {"Smithsonian Astrophysical Observation", "SAO 132554"},
        {"Wilson Evans Batten Catalogue", "WEB 5387"},
    },
    visualMagnitude: 5.97,
    bvColour: 0.639,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.14543446),
        dec: Angle.Degrees(-04.09408727)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -230.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72697",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131087"},
        {"Hipparcos Number", "HIP 72697"},
        {"Smithsonian Astrophysical Observation", "SAO 140185"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.94719108),
        dec: Angle.Degrees(-04.09160769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23918",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33192"},
        {"Hipparcos Number", "HIP 23918"},
        {"Geneva Identification System", "GEN# +1.00033192"},
        {"Smithsonian Astrophysical Observation", "SAO 131804"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.08706291),
        dec: Angle.Degrees(-04.09146115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90198",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169310"},
        {"Hipparcos Number", "HIP 90198"},
        {"Smithsonian Astrophysical Observation", "SAO 142277"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.368,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.07245782),
        dec: Angle.Degrees(-04.08830549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221356"},
        {"Hipparcos Number", "HIP 116106"},
        {"Geneva Identification System", "GEN# +1.00221356"},
        {"Smithsonian Astrophysical Observation", "SAO 146752"},
        {"Wilson Evans Batten Catalogue", "WEB 20522"},
    },
    visualMagnitude: 6.50,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.88082708),
        dec: Angle.Degrees(-04.08693695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -192.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4980"},
        {"Hipparcos Number", "HIP 4040"},
        {"Geneva Identification System", "GEN# +1.00004980"},
        {"Smithsonian Astrophysical Observation", "SAO 128996"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.95407843),
        dec: Angle.Degrees(-04.08647157)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30268"},
        {"Hipparcos Number", "HIP 22156"},
        {"Smithsonian Astrophysical Observation", "SAO 131475"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.50633674),
        dec: Angle.Degrees(-04.08475151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148804"},
        {"Hipparcos Number", "HIP 80862"},
        {"Geneva Identification System", "GEN# +1.00148804"},
        {"Smithsonian Astrophysical Observation", "SAO 141213"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68394957),
        dec: Angle.Degrees(-04.08250608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87847",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163532"},
        {"Hipparcos Number", "HIP 87847"},
        {"Geneva Identification System", "GEN# +1.00163532"},
        {"Smithsonian Astrophysical Observation", "SAO 141979"},
        {"Wilson Evans Batten Catalogue", "WEB 14830"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.162,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.19895085),
        dec: Angle.Degrees(-04.08180189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190664"},
        {"Hipparcos Number", "HIP 99024"},
        {"Geneva Identification System", "GEN# +1.00190664"},
        {"Smithsonian Astrophysical Observation", "SAO 144062"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.55080882),
        dec: Angle.Degrees(-04.07812491)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32644",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5471"},
        {"Henry Draper", "HD 49503"},
        {"Hipparcos Number", "HIP 32644"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.14909805),
        dec: Angle.Degrees(-04.07570904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -81.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92671"},
        {"Hipparcos Number", "HIP 52349"},
        {"Fundamental Katalog 5th Edition", "FK5 4951"},
        {"Smithsonian Astrophysical Observation", "SAO 137736"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.431,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.47871896),
        dec: Angle.Degrees(-04.07431420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90044"},
        {"Hipparcos Number", "HIP 50885"},
        {"Fundamental Katalog 5th Edition", "FK5 388"},
        {"Geneva Identification System", "GEN# +1.00090044"},
        {"Renson", "Renson 25890"},
        {"Smithsonian Astrophysical Observation", "SAO 137533"},
        {"Wilson Evans Batten Catalogue", "WEB 9308"},
    },
    visualMagnitude: 5.93,
    bvColour: -0.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.86045025),
        dec: Angle.Degrees(-04.07404512)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211802"},
        {"Hipparcos Number", "HIP 110240"},
        {"Fundamental Katalog 5th Edition", "FK5 5970"},
        {"Smithsonian Astrophysical Observation", "SAO 146021"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.233,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.95435026),
        dec: Angle.Degrees(-04.06620261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109522"},
        {"Hipparcos Number", "HIP 61438"},
        {"Smithsonian Astrophysical Observation", "SAO 138859"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.83704652),
        dec: Angle.Degrees(-04.06559125)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46648",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82229"},
        {"Hipparcos Number", "HIP 46648"},
        {"Smithsonian Astrophysical Observation", "SAO 136910"},
        {"Wilson Evans Batten Catalogue", "WEB 8803"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.67231772),
        dec: Angle.Degrees(-04.06539211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70937",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127265"},
        {"Hipparcos Number", "HIP 70937"},
        {"Geneva Identification System", "GEN# +1.00127265"},
        {"Smithsonian Astrophysical Observation", "SAO 139974"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.62731641),
        dec: Angle.Degrees(-04.06518325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40271",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68707"},
        {"Hipparcos Number", "HIP 40271"},
        {"Smithsonian Astrophysical Observation", "SAO 135645"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.35442647),
        dec: Angle.Degrees(-04.06489876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39777"},
        {"Hipparcos Number", "HIP 27929"},
        {"Celescope Catalog", "CEL 1029"},
        {"Geneva Identification System", "GEN# +1.00039777"},
        {"Smithsonian Astrophysical Observation", "SAO 132635"},
        {"Wilson Evans Batten Catalogue", "WEB 5469"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.64456212),
        dec: Angle.Degrees(-04.06470929)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139444"},
        {"Hipparcos Number", "HIP 76574"},
        {"Smithsonian Astrophysical Observation", "SAO 140669"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.57040683),
        dec: Angle.Degrees(-04.06437160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -75.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213536"},
        {"Hipparcos Number", "HIP 111238"},
        {"Smithsonian Astrophysical Observation", "SAO 146139"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.05254947),
        dec: Angle.Degrees(-04.06266071)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61054",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108910"},
        {"Hipparcos Number", "HIP 61054"},
        {"Geneva Identification System", "GEN# +1.00108910"},
        {"Smithsonian Astrophysical Observation", "SAO 138824"},
        {"Wilson Evans Batten Catalogue", "WEB 10869"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.70977141),
        dec: Angle.Degrees(-04.06081614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -62.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140954"},
        {"Hipparcos Number", "HIP 77266"},
        {"Smithsonian Astrophysical Observation", "SAO 140748"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.62843659),
        dec: Angle.Degrees(-04.05996022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41920",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72444"},
        {"Hipparcos Number", "HIP 41920"},
        {"Geneva Identification System", "GEN# +1.00072444"},
        {"Smithsonian Astrophysical Observation", "SAO 136020"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.19954657),
        dec: Angle.Degrees(-04.05859032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174915"},
        {"Hipparcos Number", "HIP 92684"},
        {"Smithsonian Astrophysical Observation", "SAO 142748"},
    },
    visualMagnitude: 8.52,
    bvColour: 2.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.28318041),
        dec: Angle.Degrees(-04.05632754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27998",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39885"},
        {"Hipparcos Number", "HIP 27998"},
        {"Smithsonian Astrophysical Observation", "SAO 132647"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.81779921),
        dec: Angle.Degrees(-04.05386792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18"},
    },
    visualMagnitude: 11.03,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.05313923),
        dec: Angle.Degrees(-04.05373813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -127.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68814"},
        {"Hipparcos Number", "HIP 40317"},
        {"Smithsonian Astrophysical Observation", "SAO 135661"},
    },
    visualMagnitude: 9.58,
    bvColour: 0.695,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.48796122),
        dec: Angle.Degrees(-04.05349709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161606"},
        {"Hipparcos Number", "HIP 87004"},
        {"Smithsonian Astrophysical Observation", "SAO 141865"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.67414469),
        dec: Angle.Degrees(-04.05318180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79503",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145876"},
        {"Hipparcos Number", "HIP 79503"},
        {"Geneva Identification System", "GEN# +1.00145876"},
        {"Smithsonian Astrophysical Observation", "SAO 141036"},
    },
    visualMagnitude: 6.96,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.35678357),
        dec: Angle.Degrees(-04.05154481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156825"},
        {"Hipparcos Number", "HIP 84784"},
        {"Geneva Identification System", "GEN# +1.00156825"},
        {"Smithsonian Astrophysical Observation", "SAO 141607"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.95894375),
        dec: Angle.Degrees(-04.04900648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110537"},
        {"Hipparcos Number", "HIP 62039"},
        {"Cincinnati Publication", "Ci 18 1611"},
        {"Geneva Identification System", "GEN# +1.00110537"},
        {"Smithsonian Astrophysical Observation", "SAO 138928"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.74772308),
        dec: Angle.Degrees(-04.04889355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -179.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3016"},
        {"Hipparcos Number", "HIP 2632"},
        {"Smithsonian Astrophysical Observation", "SAO 128822"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.35401742),
        dec: Angle.Degrees(-04.04380018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94439"},
        {"Hipparcos Number", "HIP 53297"},
        {"Smithsonian Astrophysical Observation", "SAO 137873"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.50475073),
        dec: Angle.Degrees(-04.04155818)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93716",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12007 B"},
        {"Henry Draper", "HD 177442"},
        {"Hipparcos Number", "HIP 93716"},
        {"Smithsonian Astrophysical Observation", "SAO 142993"},
        {"Wilson Evans Batten Catalogue", "WEB 16281"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.23490116),
        dec: Angle.Degrees(-04.04078190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167694"},
        {"Hipparcos Number", "HIP 89562"},
        {"Smithsonian Astrophysical Observation", "SAO 142187"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.394,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.13220871),
        dec: Angle.Degrees(-04.03703357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79836",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146700"},
        {"Hipparcos Number", "HIP 79836"},
        {"Smithsonian Astrophysical Observation", "SAO 141078"},
    },
    visualMagnitude: 7.21,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.43929171),
        dec: Angle.Degrees(-04.03657982)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75094"},
        {"Hipparcos Number", "HIP 43181"},
        {"Smithsonian Astrophysical Observation", "SAO 136283"},
    },
    visualMagnitude: 8.13,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.94661635),
        dec: Angle.Degrees(-04.03404123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185739"},
        {"Hipparcos Number", "HIP 96811"},
        {"Smithsonian Astrophysical Observation", "SAO 143677"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18621183),
        dec: Angle.Degrees(-04.03338702)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132133"},
        {"Hipparcos Number", "HIP 73208"},
        {"Geneva Identification System", "GEN# +1.00132133"},
        {"Smithsonian Astrophysical Observation", "SAO 140243"},
    },
    visualMagnitude: 7.53,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.42956221),
        dec: Angle.Degrees(-04.03154626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93717",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12007 A"},
        {"Henry Draper", "HD 177463"},
        {"Hipparcos Number", "HIP 93717"},
        {"Geneva Identification System", "GEN# +1.00177463"},
        {"Smithsonian Astrophysical Observation", "SAO 142996"},
        {"Wilson Evans Batten Catalogue", "WEB 16286"},
    },
    visualMagnitude: 5.40,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.24024804),
        dec: Angle.Degrees(-04.03135505)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66815",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "47 Tuc TO Star"},
        {"Henry Draper", "HD 119173"},
        {"Hipparcos Number", "HIP 66815"},
        {"Smithsonian Astrophysical Observation", "SAO 139492"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.550,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.42834052),
        dec: Angle.Degrees(-04.02925946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -64.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73686"},
        {"Hipparcos Number", "HIP 42464"},
        {"Smithsonian Astrophysical Observation", "SAO 136138"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.85887437),
        dec: Angle.Degrees(-04.02895104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37560",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6308"},
        {"Henry Draper", "HD 62162"},
        {"Hipparcos Number", "HIP 37560"},
        {"Smithsonian Astrophysical Observation", "SAO 135010"},
    },
    visualMagnitude: 8.50,
    bvColour: 0.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.64183414),
        dec: Angle.Degrees(-04.02649952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126292"},
        {"Hipparcos Number", "HIP 70463"},
        {"Smithsonian Astrophysical Observation", "SAO 139920"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19507406),
        dec: Angle.Degrees(-04.02595110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44124"},
        {"Cincinnati Publication", "Ci 20 501"},
        {"Geneva Identification System", "GEN# -0.00302525"},
        {"Wilson Evans Batten Catalogue", "WEB 8475"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.79129271),
        dec: Angle.Degrees(-04.02539734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 345.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -581.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77779"},
        {"Hipparcos Number", "HIP 44532"},
        {"Geneva Identification System", "GEN# +1.00077779"},
        {"Smithsonian Astrophysical Observation", "SAO 136550"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.10948530),
        dec: Angle.Degrees(-04.02407708)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52913",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7936 AB"},
        {"Henry Draper", "HD 93742"},
        {"Hipparcos Number", "HIP 52913"},
        {"Geneva Identification System", "GEN# +1.00093742"},
        {"Smithsonian Astrophysical Observation", "SAO 137808"},
        {"Wilson Evans Batten Catalogue", "WEB 9632"},
    },
    visualMagnitude: 6.61,
    bvColour: 0.211,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.32209415),
        dec: Angle.Degrees(-04.02392567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -50.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111045"},
        {"Hipparcos Number", "HIP 62347"},
        {"Smithsonian Astrophysical Observation", "SAO 138960"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.63159875),
        dec: Angle.Degrees(-04.01914146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69721"},
        {"Hipparcos Number", "HIP 40663"},
        {"Smithsonian Astrophysical Observation", "SAO 135748"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.826,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.50742671),
        dec: Angle.Degrees(-04.01894831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -200.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26186"},
        {"Hipparcos Number", "HIP 19329"},
        {"Smithsonian Astrophysical Observation", "SAO 130974"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.247,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.13668896),
        dec: Angle.Degrees(-04.01869429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51871"},
        {"Hipparcos Number", "HIP 33605"},
        {"Smithsonian Astrophysical Observation", "SAO 133986"},
    },
    visualMagnitude: 7.76,
    bvColour: -0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.73839826),
        dec: Angle.Degrees(-04.01851928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72739",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72739"},
        {"Smithsonian Astrophysical Observation", "SAO 140191"},
    },
    visualMagnitude: 9.03,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.06561070),
        dec: Angle.Degrees(-04.01651832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2322",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 2322"},
        {"Smithsonian Astrophysical Observation", "SAO 128786"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.600,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.40936115),
        dec: Angle.Degrees(-04.01503000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83536"},
        {"Hipparcos Number", "HIP 47358"},
        {"Smithsonian Astrophysical Observation", "SAO 137025"},
    },
    visualMagnitude: 7.57,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.74217589),
        dec: Angle.Degrees(-04.01500151)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 53.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81145",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149382"},
        {"Hipparcos Number", "HIP 81145"},
        {"Geneva Identification System", "GEN# +1.00149382"},
        {"Smithsonian Astrophysical Observation", "SAO 141250"},
        {"Wilson Evans Batten Catalogue", "WEB 13721"},
    },
    visualMagnitude: 8.94,
    bvColour: -0.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.59723876),
        dec: Angle.Degrees(-04.01443910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39714",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67257"},
        {"Hipparcos Number", "HIP 39714"},
        {"Geneva Identification System", "GEN# +1.00067257"},
        {"Smithsonian Astrophysical Observation", "SAO 135519"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.76465818),
        dec: Angle.Degrees(-04.01408671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134250"},
        {"Hipparcos Number", "HIP 74132"},
        {"Smithsonian Astrophysical Observation", "SAO 140346"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.305,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.24040640),
        dec: Angle.Degrees(-04.01329499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89288",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166960"},
        {"Hipparcos Number", "HIP 89288"},
        {"Fundamental Katalog 5th Edition", "FK5 3450"},
        {"Geneva Identification System", "GEN# +1.00166960"},
        {"Renson", "Renson 46990"},
        {"Smithsonian Astrophysical Observation", "SAO 142159"},
    },
    visualMagnitude: 6.59,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.29162840),
        dec: Angle.Degrees(-04.01166263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38531"},
        {"Hipparcos Number", "HIP 27241"},
        {"Geneva Identification System", "GEN# +1.00038531"},
        {"Smithsonian Astrophysical Observation", "SAO 132522"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.60630648),
        dec: Angle.Degrees(-04.00738361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84022"},
        {"Hipparcos Number", "HIP 47577"},
        {"Smithsonian Astrophysical Observation", "SAO 137063"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.51639032),
        dec: Angle.Degrees(-03.99953360)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84683"},
        {"Hipparcos Number", "HIP 47986"},
        {"Smithsonian Astrophysical Observation", "SAO 137122"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.70967639),
        dec: Angle.Degrees(-03.99842176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98645"},
        {"Hipparcos Number", "HIP 55426"},
        {"Smithsonian Astrophysical Observation", "SAO 138146"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.316,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.25627183),
        dec: Angle.Degrees(-03.99650961)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60194",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107365"},
        {"Hipparcos Number", "HIP 60194"},
        {"Geneva Identification System", "GEN# +1.00107365"},
        {"Smithsonian Astrophysical Observation", "SAO 138728"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.16386432),
        dec: Angle.Degrees(-03.99500594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61921",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110337"},
        {"Hipparcos Number", "HIP 61921"},
        {"Smithsonian Astrophysical Observation", "SAO 138915"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.35831079),
        dec: Angle.Degrees(-03.99400623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116396"},
        {"Hipparcos Number", "HIP 65335"},
        {"Smithsonian Astrophysical Observation", "SAO 139311"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.86410258),
        dec: Angle.Degrees(-03.99300481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4345",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5383"},
        {"Hipparcos Number", "HIP 4345"},
        {"Smithsonian Astrophysical Observation", "SAO 129031"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.92440760),
        dec: Angle.Degrees(-03.99292635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3644"},
        {"Hipparcos Number", "HIP 3082"},
        {"Geneva Identification System", "GEN# +1.00003644"},
        {"Renson", "Renson 985"},
        {"Smithsonian Astrophysical Observation", "SAO 128875"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.78980462),
        dec: Angle.Degrees(-03.99266224)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107993",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207920"},
        {"Hipparcos Number", "HIP 107993"},
        {"Geneva Identification System", "GEN# +1.00207920"},
        {"Smithsonian Astrophysical Observation", "SAO 145721"},
        {"Wilson Evans Batten Catalogue", "WEB 19472"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.911,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(328.18726675),
        dec: Angle.Degrees(-03.99206072)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88890",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165991"},
        {"Hipparcos Number", "HIP 88890"},
        {"Smithsonian Astrophysical Observation", "SAO 142117"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.19196245),
        dec: Angle.Degrees(-03.99087304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40231"},
        {"Hipparcos Number", "HIP 28189"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.35976368),
        dec: Angle.Degrees(-03.98949221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122787"},
        {"Hipparcos Number", "HIP 68716"},
        {"Smithsonian Astrophysical Observation", "SAO 139706"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.747,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00743219),
        dec: Angle.Degrees(-03.98923760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145465"},
        {"Hipparcos Number", "HIP 79316"},
        {"Smithsonian Astrophysical Observation", "SAO 141019"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.464,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.80907517),
        dec: Angle.Degrees(-03.98904451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40613",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69611"},
        {"Hipparcos Number", "HIP 40613"},
        {"Cincinnati Publication", "Ci 20 470"},
        {"Cincinnati Publication 2", "Ci 18 978"},
        {"Geneva Identification System", "GEN# +1.00069611"},
        {"Smithsonian Astrophysical Observation", "SAO 135736"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.37263760),
        dec: Angle.Degrees(-03.98854893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -145.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -438.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7171 A"},
        {"Henry Draper", "HD 77876"},
        {"Hipparcos Number", "HIP 44584"},
        {"Geneva Identification System", "GEN# +1.00077876"},
        {"Smithsonian Astrophysical Observation", "SAO 136558"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.24809224),
        dec: Angle.Degrees(-03.98752846)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71297"},
        {"Hipparcos Number", "HIP 41375"},
        {"Geneva Identification System", "GEN# +1.00071297"},
        {"Renson", "Renson 19710"},
        {"Smithsonian Astrophysical Observation", "SAO 135916"},
        {"Wilson Evans Batten Catalogue", "WEB 8003"},
    },
    visualMagnitude: 5.60,
    bvColour: 0.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.61345247),
        dec: Angle.Degrees(-03.98729976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44585",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7171 B"},
        {"Hipparcos Number", "HIP 44585"},
        {"Smithsonian Astrophysical Observation", "SAO 136559"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.25102973),
        dec: Angle.Degrees(-03.98725220)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -71.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90660",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170513"},
        {"Hipparcos Number", "HIP 90660"},
        {"Geneva Identification System", "GEN# +1.00170513"},
        {"Smithsonian Astrophysical Observation", "SAO 142351"},
    },
    visualMagnitude: 8.27,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.47890363),
        dec: Angle.Degrees(-03.98539880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106592",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205423"},
        {"Hipparcos Number", "HIP 106592"},
        {"Geneva Identification System", "GEN# +1.00205423"},
        {"Smithsonian Astrophysical Observation", "SAO 145510"},
        {"Wilson Evans Batten Catalogue", "WEB 19284"},
    },
    visualMagnitude: 5.79,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.82344304),
        dec: Angle.Degrees(-03.98329291)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46872"},
        {"Hipparcos Number", "HIP 31476"},
        {"Geneva Identification System", "GEN# +1.00046872"},
        {"Smithsonian Astrophysical Observation", "SAO 133446"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.89148790),
        dec: Angle.Degrees(-03.98257317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 73892"},
        {"Hipparcos Number", "HIP 42561"},
        {"Smithsonian Astrophysical Observation", "SAO 136157"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(130.13782390),
        dec: Angle.Degrees(-03.98063693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11751",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15735"},
        {"Hipparcos Number", "HIP 11751"},
        {"Smithsonian Astrophysical Observation", "SAO 129955"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.90272994),
        dec: Angle.Degrees(-03.97957947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88184",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164287"},
        {"Hipparcos Number", "HIP 88184"},
        {"Smithsonian Astrophysical Observation", "SAO 142027"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.14301712),
        dec: Angle.Degrees(-03.97945396)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28959"},
        {"Hipparcos Number", "HIP 21255"},
        {"Smithsonian Astrophysical Observation", "SAO 131297"},
    },
    visualMagnitude: 7.92,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.39583424),
        dec: Angle.Degrees(-03.97944272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224461"},
        {"Hipparcos Number", "HIP 118166"},
        {"Smithsonian Astrophysical Observation", "SAO 147005"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.53831823),
        dec: Angle.Degrees(-03.97913266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35896",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6047 A"},
        {"Henry Draper", "HD 58098"},
        {"Hipparcos Number", "HIP 35896"},
        {"Smithsonian Astrophysical Observation", "SAO 134618"},
        {"Wilson Evans Batten Catalogue", "WEB 7148"},
    },
    visualMagnitude: 7.10,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.00536018),
        dec: Angle.Degrees(-03.97887403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35895",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6047 B"},
        {"Hipparcos Number", "HIP 35895"},
    },
    visualMagnitude: 9.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.00139344),
        dec: Angle.Degrees(-03.97781672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31517",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46949"},
        {"Hipparcos Number", "HIP 31517"},
        {"Smithsonian Astrophysical Observation", "SAO 133457"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.99078493),
        dec: Angle.Degrees(-03.97763600)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72346",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72346"},
        {"Smithsonian Astrophysical Observation", "SAO 140143"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.821,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.91026419),
        dec: Angle.Degrees(-03.97373160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39309",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39309"},
        {"Geneva Identification System", "GEN# -0.00302179"},
    },
    visualMagnitude: 10.34,
    bvColour: -0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.56201996),
        dec: Angle.Degrees(-03.97116275)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14524"},
    },
    visualMagnitude: 10.86,
    bvColour: 1.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.89142462),
        dec: Angle.Degrees(-03.97048481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -264.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -388.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55081",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98046"},
        {"Hipparcos Number", "HIP 55081"},
        {"Geneva Identification System", "GEN# +1.00098046"},
        {"Smithsonian Astrophysical Observation", "SAO 138101"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.15183498),
        dec: Angle.Degrees(-03.96675837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94610",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180085"},
        {"Hipparcos Number", "HIP 94610"},
        {"Geneva Identification System", "GEN# +1.00180085"},
        {"Smithsonian Astrophysical Observation", "SAO 143180"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.80096175),
        dec: Angle.Degrees(-03.96652245)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114355",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16551 AB"},
        {"Henry Draper", "HD 218625"},
        {"Hipparcos Number", "HIP 114355"},
        {"Smithsonian Astrophysical Observation", "SAO 146538"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.40309385),
        dec: Angle.Degrees(-03.96229261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62901"},
        {"Hipparcos Number", "HIP 37913"},
        {"Geneva Identification System", "GEN# +1.00062901"},
        {"Smithsonian Astrophysical Observation", "SAO 135081"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.54241666),
        dec: Angle.Degrees(-03.96110979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2353",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 410 A"},
        {"Henry Draper", "HD 2637"},
        {"Hipparcos Number", "HIP 2353"},
        {"Fundamental Katalog 5th Edition", "FK5 13"},
        {"Geneva Identification System", "GEN# +1.00002637"},
        {"Smithsonian Astrophysical Observation", "SAO 128791"},
        {"Wilson Evans Batten Catalogue", "WEB 429"},
    },
    visualMagnitude: 5.72,
    bvColour: 1.545,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.50980355),
        dec: Angle.Degrees(-03.95729662)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104150"},
        {"Hipparcos Number", "HIP 58491"},
        {"Smithsonian Astrophysical Observation", "SAO 138523"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.93863162),
        dec: Angle.Degrees(-03.95489535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75053"},
        {"Hipparcos Number", "HIP 43165"},
        {"Smithsonian Astrophysical Observation", "SAO 136281"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.89068318),
        dec: Angle.Degrees(-03.95468659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59983",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8505 B"},
        {"Henry Draper", "HD 106975"},
        {"Hipparcos Number", "HIP 59983"},
        {"Geneva Identification System", "GEN# +1.00106975"},
        {"Smithsonian Astrophysical Observation", "SAO 138703"},
        {"Wilson Evans Batten Catalogue", "WEB 10660"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.53840708),
        dec: Angle.Degrees(-03.95418895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146514"},
        {"Hipparcos Number", "HIP 79781"},
        {"Geneva Identification System", "GEN# +1.00146514"},
        {"Smithsonian Astrophysical Observation", "SAO 141075"},
        {"Wilson Evans Batten Catalogue", "WEB 13500"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.326,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.23032857),
        dec: Angle.Degrees(-03.95336481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72002",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72002"},
        {"Smithsonian Astrophysical Observation", "SAO 140096"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.87291964),
        dec: Angle.Degrees(-03.94951551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -83.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59984",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8505 A"},
        {"Henry Draper", "HD 106976"},
        {"Hipparcos Number", "HIP 59984"},
        {"Geneva Identification System", "GEN# +1.00106976"},
        {"Smithsonian Astrophysical Observation", "SAO 138704"},
        {"Wilson Evans Batten Catalogue", "WEB 10661"},
    },
    visualMagnitude: 6.57,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.53991313),
        dec: Angle.Degrees(-03.94883265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111484",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213964"},
        {"Hipparcos Number", "HIP 111484"},
        {"Smithsonian Astrophysical Observation", "SAO 146179"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.80793558),
        dec: Angle.Degrees(-03.94785649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88106"},
        {"Hipparcos Number", "HIP 49762"},
        {"Smithsonian Astrophysical Observation", "SAO 137380"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.36973311),
        dec: Angle.Degrees(-03.94780919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55090",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98069"},
        {"Hipparcos Number", "HIP 55090"},
        {"Smithsonian Astrophysical Observation", "SAO 138104"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.18592488),
        dec: Angle.Degrees(-03.94290760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77008"},
        {"Smithsonian Astrophysical Observation", "SAO 140717"},
    },
    visualMagnitude: 9.55,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.85585397),
        dec: Angle.Degrees(-03.93903606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218588"},
        {"Hipparcos Number", "HIP 114325"},
        {"Smithsonian Astrophysical Observation", "SAO 146535"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.31305652),
        dec: Angle.Degrees(-03.93858857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218945"},
        {"Hipparcos Number", "HIP 114553"},
        {"Smithsonian Astrophysical Observation", "SAO 146559"},
    },
    visualMagnitude: 8.58,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.05449526),
        dec: Angle.Degrees(-03.93711281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36363"},
        {"Hipparcos Number", "HIP 25849"},
        {"Geneva Identification System", "GEN# +1.00036363"},
    },
    visualMagnitude: 9.50,
    bvColour: 0.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.76959484),
        dec: Angle.Degrees(-03.93345588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8713"},
        {"Hipparcos Number", "HIP 6687"},
        {"Smithsonian Astrophysical Observation", "SAO 129292"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.46803699),
        dec: Angle.Degrees(-03.92732676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36411"},
        {"Hipparcos Number", "HIP 25872"},
        {"Geneva Identification System", "GEN# +1.00036411"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.84589487),
        dec: Angle.Degrees(-03.92566986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293852"},
        {"Hipparcos Number", "HIP 24001"},
        {"Smithsonian Astrophysical Observation", "SAO 131830"},
    },
    visualMagnitude: 8.79,
    bvColour: -0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.40089012),
        dec: Angle.Degrees(-03.92538719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97565",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12984 AB"},
        {"Henry Draper", "HD 187381"},
        {"Hipparcos Number", "HIP 97565"},
        {"Smithsonian Astrophysical Observation", "SAO 143827"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.744,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.45554043),
        dec: Angle.Degrees(-03.92231330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79012"},
        {"Hipparcos Number", "HIP 45099"},
        {"Smithsonian Astrophysical Observation", "SAO 136647"},
    },
    visualMagnitude: 9.45,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.81277537),
        dec: Angle.Degrees(-03.92170628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77542",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141569"},
        {"Henry Draper 2", "HD 141569A"},
        {"Hipparcos Number", "HIP 77542"},
        {"Smithsonian Astrophysical Observation", "SAO 140789"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.49066123),
        dec: Angle.Degrees(-03.92115974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37745"},
        {"Hipparcos Number", "HIP 26716"},
        {"Geneva Identification System", "GEN# +1.00037745"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.16914852),
        dec: Angle.Degrees(-03.91980485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115220",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219983"},
        {"Hipparcos Number", "HIP 115220"},
        {"Geneva Identification System", "GEN# +1.00219983"},
        {"Smithsonian Astrophysical Observation", "SAO 146645"},
        {"Wilson Evans Batten Catalogue", "WEB 20408"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.06533995),
        dec: Angle.Degrees(-03.91887496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 287.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -109.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86765",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161098"},
        {"Hipparcos Number", "HIP 86765"},
        {"Geneva Identification System", "GEN# +1.00161098"},
        {"Smithsonian Astrophysical Observation", "SAO 141833"},
    },
    visualMagnitude: 7.67,
    bvColour: 0.676,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.93464856),
        dec: Angle.Degrees(-03.91727949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53197",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94279"},
        {"Hipparcos Number", "HIP 53197"},
        {"Smithsonian Astrophysical Observation", "SAO 137857"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.20465628),
        dec: Angle.Degrees(-03.91714128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66575"},
        {"Hipparcos Number", "HIP 39475"},
        {"Smithsonian Astrophysical Observation", "SAO 135442"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.02289521),
        dec: Angle.Degrees(-03.91712896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102344",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197491"},
        {"Hipparcos Number", "HIP 102344"},
        {"Smithsonian Astrophysical Observation", "SAO 144748"},
    },
    visualMagnitude: 7.04,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.05255576),
        dec: Angle.Degrees(-03.91538741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51394",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7800 A"},
        {"Henry Draper", "HD 90934"},
        {"Hipparcos Number", "HIP 51394"},
        {"Geneva Identification System", "GEN# +1.00090934"},
        {"Smithsonian Astrophysical Observation", "SAO 137604"},
    },
    visualMagnitude: 7.71,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.45533311),
        dec: Angle.Degrees(-03.91526930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57212"},
        {"Hipparcos Number", "HIP 35547"},
        {"Smithsonian Astrophysical Observation", "SAO 134527"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.02827256),
        dec: Angle.Degrees(-03.91453185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43786",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76295"},
        {"Hipparcos Number", "HIP 43786"},
        {"Smithsonian Astrophysical Observation", "SAO 136403"},
    },
    visualMagnitude: 8.56,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.77378261),
        dec: Angle.Degrees(-03.91340449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51393",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7800 B"},
        {"Hipparcos Number", "HIP 51393"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.557,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.45428107),
        dec: Angle.Degrees(-03.91116593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 966"},
        {"Hipparcos Number", "HIP 1120"},
        {"Smithsonian Astrophysical Observation", "SAO 128648"},
        {"Wilson Evans Batten Catalogue", "WEB 198"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.50500923),
        dec: Angle.Degrees(-03.90877812)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16338"},
        {"Hipparcos Number", "HIP 12209"},
        {"Smithsonian Astrophysical Observation", "SAO 130022"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.29734299),
        dec: Angle.Degrees(-03.90792930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71155"},
        {"Hipparcos Number", "HIP 41307"},
        {"Fundamental Katalog 5th Edition", "FK5 316"},
        {"Geneva Identification System", "GEN# +1.00071155"},
        {"Smithsonian Astrophysical Observation", "SAO 135896"},
        {"Wilson Evans Batten Catalogue", "WEB 7992"},
    },
    visualMagnitude: 3.91,
    bvColour: -0.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.41529546),
        dec: Angle.Degrees(-03.90636482)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64731",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115257"},
        {"Hipparcos Number", "HIP 64731"},
        {"Smithsonian Astrophysical Observation", "SAO 139252"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.01245694),
        dec: Angle.Degrees(-03.90610958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28564",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40903"},
        {"Hipparcos Number", "HIP 28564"},
        {"Smithsonian Astrophysical Observation", "SAO 132753"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.43278450),
        dec: Angle.Degrees(-03.90480579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47171",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47171"},
        {"Smithsonian Astrophysical Observation", "SAO 136997"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.18880591),
        dec: Angle.Degrees(-03.90427590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 136.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22929",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31468"},
        {"Hipparcos Number", "HIP 22929"},
        {"Smithsonian Astrophysical Observation", "SAO 131610"},
    },
    visualMagnitude: 8.25,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.01711315),
        dec: Angle.Degrees(-03.90346847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117325",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223178"},
        {"Hipparcos Number", "HIP 117325"},
        {"Smithsonian Astrophysical Observation", "SAO 146906"},
    },
    visualMagnitude: 9.06,
    bvColour: 0.522,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.84798292),
        dec: Angle.Degrees(-03.90303917)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34975",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5911 A"},
        {"Henry Draper", "HD 55775"},
        {"Henry Draper 2", "HD 55775A"},
        {"Hipparcos Number", "HIP 34975"},
        {"Geneva Identification System", "GEN# +1.00055775"},
        {"Smithsonian Astrophysical Observation", "SAO 134391"},
        {"Wilson Evans Batten Catalogue", "WEB 6992"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.54529505),
        dec: Angle.Degrees(-03.90175914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96027",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96027"},
        {"Smithsonian Astrophysical Observation", "SAO 143496"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.86380331),
        dec: Angle.Degrees(-03.90077330)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105518"},
        {"Hipparcos Number", "HIP 59230"},
        {"Smithsonian Astrophysical Observation", "SAO 138610"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.22570292),
        dec: Angle.Degrees(-03.90052269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51784",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91638"},
        {"Hipparcos Number", "HIP 51784"},
        {"Geneva Identification System", "GEN# +1.00091638"},
        {"Smithsonian Astrophysical Observation", "SAO 137653"},
    },
    visualMagnitude: 6.67,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.70924157),
        dec: Angle.Degrees(-03.89929772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -161.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54990"},
        {"Hipparcos Number", "HIP 34688"},
        {"Smithsonian Astrophysical Observation", "SAO 134306"},
    },
    visualMagnitude: 6.51,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.76274605),
        dec: Angle.Degrees(-03.89799535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96695"},
        {"Hipparcos Number", "HIP 54435"},
        {"Smithsonian Astrophysical Observation", "SAO 138003"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.488,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.07594043),
        dec: Angle.Degrees(-03.89676543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40759"},
        {"Hipparcos Number", "HIP 28479"},
        {"Geneva Identification System", "GEN# +1.00040759"},
        {"Renson", "Renson 10900"},
        {"Smithsonian Astrophysical Observation", "SAO 132745"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.19055029),
        dec: Angle.Degrees(-03.89566235)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11045",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11045"},
    },
    visualMagnitude: 10.34,
    bvColour: 0.890,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.55102676),
        dec: Angle.Degrees(-03.89554160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 264.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64467",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114784"},
        {"Hipparcos Number", "HIP 64467"},
        {"Smithsonian Astrophysical Observation", "SAO 139220"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.964,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.20328297),
        dec: Angle.Degrees(-03.89460083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210419"},
        {"Hipparcos Number", "HIP 109442"},
        {"Geneva Identification System", "GEN# +1.00210419"},
        {"Smithsonian Astrophysical Observation", "SAO 145914"},
    },
    visualMagnitude: 6.28,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.58791064),
        dec: Angle.Degrees(-03.89397811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11260",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1840 A"},
        {"Henry Draper", "HD 15005"},
        {"Hipparcos Number", "HIP 11260"},
        {"Geneva Identification System", "GEN# +1.00015005"},
        {"Smithsonian Astrophysical Observation", "SAO 129887"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.23452404),
        dec: Angle.Degrees(-03.89266555)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201378"},
        {"Hipparcos Number", "HIP 104435"},
        {"Geneva Identification System", "GEN# +1.00201378"},
        {"Smithsonian Astrophysical Observation", "SAO 145153"},
    },
    visualMagnitude: 7.62,
    bvColour: 0.625,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.33003141),
        dec: Angle.Degrees(-03.89252408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 33.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57861"},
        {"Hipparcos Number", "HIP 35792"},
        {"Geneva Identification System", "GEN# +1.00057861"},
        {"Smithsonian Astrophysical Observation", "SAO 134595"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.74242784),
        dec: Angle.Degrees(-03.89216028)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128461"},
        {"Hipparcos Number", "HIP 71486"},
        {"Geneva Identification System", "GEN# +1.00128461"},
        {"Smithsonian Astrophysical Observation", "SAO 140036"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.28604023),
        dec: Angle.Degrees(-03.89214055)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30595",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45168"},
        {"Hipparcos Number", "HIP 30595"},
        {"Geneva Identification System", "GEN# +1.00045168"},
        {"Smithsonian Astrophysical Observation", "SAO 133238"},
        {"Wilson Evans Batten Catalogue", "WEB 6103"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.44641262),
        dec: Angle.Degrees(-03.88902523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102802",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198318"},
        {"Hipparcos Number", "HIP 102802"},
        {"Smithsonian Astrophysical Observation", "SAO 144846"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.40475706),
        dec: Angle.Degrees(-03.88877343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17952",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24107"},
        {"Hipparcos Number", "HIP 17952"},
        {"Smithsonian Astrophysical Observation", "SAO 130763"},
        {"Wilson Evans Batten Catalogue", "WEB 3456"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.109,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.57672902),
        dec: Angle.Degrees(-03.88852770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62234",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8657 A"},
        {"Henry Draper", "HD 110886"},
        {"Hipparcos Number", "HIP 62234"},
        {"Smithsonian Astrophysical Observation", "SAO 138952"},
    },
    visualMagnitude: 7.29,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.32238524),
        dec: Angle.Degrees(-03.88809732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37952",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37952"},
        {"Geneva Identification System", "GEN# +1.00063023"},
        {"Smithsonian Astrophysical Observation", "SAO 135090"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.68703808),
        dec: Angle.Degrees(-03.88758021)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26692"},
        {"Hipparcos Number", "HIP 19700"},
        {"Smithsonian Astrophysical Observation", "SAO 131037"},
    },
    visualMagnitude: 7.51,
    bvColour: 1.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.30218522),
        dec: Angle.Degrees(-03.88489764)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62233",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8657 B"},
        {"Henry Draper", "HD 110886B"},
        {"Hipparcos Number", "HIP 62233"},
        {"Smithsonian Astrophysical Observation", "SAO 138951"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.226,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.32146490),
        dec: Angle.Degrees(-03.88375185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57972",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103252"},
        {"Hipparcos Number", "HIP 57972"},
        {"Smithsonian Astrophysical Observation", "SAO 138460"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.405,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.36465680),
        dec: Angle.Degrees(-03.88365317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25366",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35561"},
        {"Hipparcos Number", "HIP 25366"},
        {"Smithsonian Astrophysical Observation", "SAO 132087"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.39040835),
        dec: Angle.Degrees(-03.88322027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83906",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154962"},
        {"Hipparcos Number", "HIP 83906"},
        {"Geneva Identification System", "GEN# +1.00154962"},
        {"Smithsonian Astrophysical Observation", "SAO 141535"},
        {"Wilson Evans Batten Catalogue", "WEB 14180"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.22729747),
        dec: Angle.Degrees(-03.88260680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -54.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -158.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71871"},
        {"Hipparcos Number", "HIP 41654"},
        {"Smithsonian Astrophysical Observation", "SAO 135973"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.40210123),
        dec: Angle.Degrees(-03.88050715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34684",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 54975"},
        {"Hipparcos Number", "HIP 34684"},
        {"Geneva Identification System", "GEN# +1.00054975"},
        {"Smithsonian Astrophysical Observation", "SAO 134302"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.74108978),
        dec: Angle.Degrees(-03.87864046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78949",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144636"},
        {"Hipparcos Number", "HIP 78949"},
        {"Smithsonian Astrophysical Observation", "SAO 140966"},
    },
    visualMagnitude: 7.43,
    bvColour: 1.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.75466602),
        dec: Angle.Degrees(-03.87779250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11365",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15168"},
        {"Hipparcos Number", "HIP 11365"},
        {"Smithsonian Astrophysical Observation", "SAO 129901"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.60063854),
        dec: Angle.Degrees(-03.87750587)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90539",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170232"},
        {"Hipparcos Number", "HIP 90539"},
        {"Geneva Identification System", "GEN# +1.00170232A"},
        {"Smithsonian Astrophysical Observation", "SAO 142337"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.10386629),
        dec: Angle.Degrees(-03.87527217)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -198.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -311.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168782"},
        {"Hipparcos Number", "HIP 89988"},
        {"Geneva Identification System", "GEN# +1.00168782"},
        {"Smithsonian Astrophysical Observation", "SAO 142244"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.40575389),
        dec: Angle.Degrees(-03.87486946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109698",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210826"},
        {"Hipparcos Number", "HIP 109698"},
        {"Smithsonian Astrophysical Observation", "SAO 145944"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.30073535),
        dec: Angle.Degrees(-03.87236889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148038"},
        {"Hipparcos Number", "HIP 80470"},
        {"Geneva Identification System", "GEN# +1.00148038"},
        {"Smithsonian Astrophysical Observation", "SAO 141164"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.38837963),
        dec: Angle.Degrees(-03.86655403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22499",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30781"},
        {"Hipparcos Number", "HIP 22499"},
        {"Smithsonian Astrophysical Observation", "SAO 131533"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.192,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.61609254),
        dec: Angle.Degrees(-03.86519880)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100783",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194497"},
        {"Hipparcos Number", "HIP 100783"},
        {"Geneva Identification System", "GEN# +1.00194497"},
        {"Smithsonian Astrophysical Observation", "SAO 144418"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.50920490),
        dec: Angle.Degrees(-03.86472376)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22340"},
        {"Hipparcos Number", "HIP 16766"},
        {"Smithsonian Astrophysical Observation", "SAO 130594"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.93708310),
        dec: Angle.Degrees(-03.86405160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -182.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48518",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85734"},
        {"Hipparcos Number", "HIP 48518"},
        {"Fundamental Katalog 5th Edition", "FK5 4879"},
        {"Smithsonian Astrophysical Observation", "SAO 137209"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.42778559),
        dec: Angle.Degrees(-03.86201357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89776"},
        {"Hipparcos Number", "HIP 50736"},
        {"Smithsonian Astrophysical Observation", "SAO 137513"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.39759835),
        dec: Angle.Degrees(-03.85945407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3385",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4061"},
        {"Hipparcos Number", "HIP 3385"},
        {"Geneva Identification System", "GEN# +1.00004061"},
        {"Smithsonian Astrophysical Observation", "SAO 128916"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.75748192),
        dec: Angle.Degrees(-03.85626787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 83453"},
        {"Hipparcos Number", "HIP 47302"},
        {"Smithsonian Astrophysical Observation", "SAO 137019"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.59254501),
        dec: Angle.Degrees(-03.85480876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221801"},
        {"Hipparcos Number", "HIP 116402"},
        {"Geneva Identification System", "GEN# +1.00221801"},
        {"Smithsonian Astrophysical Observation", "SAO 146789"},
    },
    visualMagnitude: 7.23,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.81101031),
        dec: Angle.Degrees(-03.85384909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 31.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33431"},
        {"Hipparcos Number", "HIP 24058"},
        {"Smithsonian Astrophysical Observation", "SAO 131838"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.54061939),
        dec: Angle.Degrees(-03.85245008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 453",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46"},
        {"Hipparcos Number", "HIP 453"},
        {"Fundamental Katalog 5th Edition", "FK5 4010"},
        {"Smithsonian Astrophysical Observation", "SAO 128574"},
    },
    visualMagnitude: 7.59,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.35611944),
        dec: Angle.Degrees(-03.85159559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217624"},
        {"Hipparcos Number", "HIP 113740"},
        {"Smithsonian Astrophysical Observation", "SAO 146460"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.52456683),
        dec: Angle.Degrees(-03.85045713)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185879"},
        {"Hipparcos Number", "HIP 96867"},
        {"Smithsonian Astrophysical Observation", "SAO 143698"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.34755131),
        dec: Angle.Degrees(-03.84914439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217580"},
        {"Hipparcos Number", "HIP 113718"},
        {"Cincinnati Publication", "Ci 20 1399"},
        {"Geneva Identification System", "GEN# +1.00217580"},
        {"Smithsonian Astrophysical Observation", "SAO 146456"},
        {"Wilson Evans Batten Catalogue", "WEB 20204"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.46380492),
        dec: Angle.Degrees(-03.84823101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 395.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -207.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2995"},
        {"Hipparcos Number", "HIP 2612"},
        {"Smithsonian Astrophysical Observation", "SAO 128820"},
    },
    visualMagnitude: 7.36,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.29708881),
        dec: Angle.Degrees(-03.84786179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26743",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37777"},
        {"Hipparcos Number", "HIP 26743"},
        {"Smithsonian Astrophysical Observation", "SAO 132449"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.24031608),
        dec: Angle.Degrees(-03.84315509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199651"},
        {"Hipparcos Number", "HIP 103550"},
        {"Smithsonian Astrophysical Observation", "SAO 144993"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.68807353),
        dec: Angle.Degrees(-03.84149263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48737",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86123"},
        {"Hipparcos Number", "HIP 48737"},
        {"Smithsonian Astrophysical Observation", "SAO 137238"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.11637594),
        dec: Angle.Degrees(-03.83841221)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140574"},
        {"Hipparcos Number", "HIP 77089"},
        {"Geneva Identification System", "GEN# +1.00140574"},
        {"Smithsonian Astrophysical Observation", "SAO 140729"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.10963471),
        dec: Angle.Degrees(-03.83839140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48301"},
        {"Hipparcos Number", "HIP 32133"},
        {"Smithsonian Astrophysical Observation", "SAO 133598"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.65658891),
        dec: Angle.Degrees(-03.83575945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54781",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97479"},
        {"Hipparcos Number", "HIP 54781"},
        {"Smithsonian Astrophysical Observation", "SAO 138066"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.23562905),
        dec: Angle.Degrees(-03.83215229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40358",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68937"},
        {"Hipparcos Number", "HIP 40358"},
        {"Smithsonian Astrophysical Observation", "SAO 135670"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.340,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.59991598),
        dec: Angle.Degrees(-03.82987388)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89278"},
        {"Hipparcos Number", "HIP 50443"},
        {"Smithsonian Astrophysical Observation", "SAO 137470"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.49136646),
        dec: Angle.Degrees(-03.82397996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77279",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140985"},
        {"Hipparcos Number", "HIP 77279"},
        {"Geneva Identification System", "GEN# +1.00140985"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.66939779),
        dec: Angle.Degrees(-03.82211029)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46389"},
        {"Hipparcos Number", "HIP 31224"},
        {"Smithsonian Astrophysical Observation", "SAO 133395"},
    },
    visualMagnitude: 7.72,
    bvColour: 1.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.24336750),
        dec: Angle.Degrees(-03.82006703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24289"},
        {"Hipparcos Number", "HIP 18082"},
        {"Geneva Identification System", "GEN# +1.00024289"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.97659669),
        dec: Angle.Degrees(-03.81965607)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 272.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141378"},
        {"Hipparcos Number", "HIP 77464"},
        {"Geneva Identification System", "GEN# +1.00141378"},
        {"Renson", "Renson 40130"},
        {"Smithsonian Astrophysical Observation", "SAO 140775"},
        {"Wilson Evans Batten Catalogue", "WEB 13117"},
    },
    visualMagnitude: 5.53,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.23672761),
        dec: Angle.Degrees(-03.81852811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136178"},
        {"Hipparcos Number", "HIP 74989"},
        {"Geneva Identification System", "GEN# +1.00136178"},
        {"Smithsonian Astrophysical Observation", "SAO 140458"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.711,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.85581225),
        dec: Angle.Degrees(-03.81727715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -135.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91630",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172593"},
        {"Hipparcos Number", "HIP 91630"},
        {"Smithsonian Astrophysical Observation", "SAO 142498"},
    },
    visualMagnitude: 8.03,
    bvColour: 1.638,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.30765525),
        dec: Angle.Degrees(-03.81713659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160913"},
        {"Hipparcos Number", "HIP 86678"},
        {"Smithsonian Astrophysical Observation", "SAO 141822"},
    },
    visualMagnitude: 9.61,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.65107272),
        dec: Angle.Degrees(-03.81688703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38204"},
        {"Hipparcos Number", "HIP 27026"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.99269466),
        dec: Angle.Degrees(-03.81498187)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82945",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152997"},
        {"Hipparcos Number", "HIP 82945"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.25484675),
        dec: Angle.Degrees(-03.81493583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199171"},
        {"Hipparcos Number", "HIP 103285"},
        {"Smithsonian Astrophysical Observation", "SAO 144948"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.87542396),
        dec: Angle.Degrees(-03.81229801)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4936",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4936"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.83172242),
        dec: Angle.Degrees(-03.81229243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63414",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8727 A"},
        {"Henry Draper", "HD 112846"},
        {"Hipparcos Number", "HIP 63414"},
        {"Fundamental Katalog 5th Edition", "FK5 1336"},
        {"Geneva Identification System", "GEN# +1.00112846A"},
        {"Smithsonian Astrophysical Observation", "SAO 139086"},
    },
    visualMagnitude: 5.79,
    bvColour: 0.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.91477267),
        dec: Angle.Degrees(-03.81194179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100535",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193953"},
        {"Hipparcos Number", "HIP 100535"},
        {"Smithsonian Astrophysical Observation", "SAO 144366"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.78470734),
        dec: Angle.Degrees(-03.81185357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14819",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2389 A"},
        {"Henry Draper", "HD 19836"},
        {"Hipparcos Number", "HIP 14819"},
        {"Fundamental Katalog 5th Edition", "FK5 2224"},
        {"Geneva Identification System", "GEN# +1.00019836"},
        {"Smithsonian Astrophysical Observation", "SAO 130328"},
        {"Wilson Evans Batten Catalogue", "WEB 2861"},
    },
    visualMagnitude: 6.08,
    bvColour: 1.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.82824506),
        dec: Angle.Degrees(-03.81155504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48711",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Bibha"},
        {"Henry Draper", "HD 86081"},
        {"Hipparcos Number", "HIP 48711"},
        {"Smithsonian Astrophysical Observation", "SAO 137236"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.02482314),
        dec: Angle.Degrees(-03.80846317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33361",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51193"},
        {"Hipparcos Number", "HIP 33361"},
        {"Geneva Identification System", "GEN# +1.00051193"},
        {"Smithsonian Astrophysical Observation", "SAO 133917"},
        {"Wilson Evans Batten Catalogue", "WEB 6703"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.07952093),
        dec: Angle.Degrees(-03.80708741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28076",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40011"},
        {"Hipparcos Number", "HIP 28076"},
        {"Celescope Catalog", "CEL 1039"},
        {"Geneva Identification System", "GEN# +1.00040011"},
        {"Smithsonian Astrophysical Observation", "SAO 132669"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.03027066),
        dec: Angle.Degrees(-03.80609355)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32409",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48959"},
        {"Hipparcos Number", "HIP 32409"},
        {"Smithsonian Astrophysical Observation", "SAO 133648"},
        {"New General Catalogue", "NGC 2286 383"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.49449567),
        dec: Angle.Degrees(-03.80388250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31831"},
        {"Hipparcos Number", "HIP 23149"},
        {"Smithsonian Astrophysical Observation", "SAO 131656"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.71634786),
        dec: Angle.Degrees(-03.80045817)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8337"},
        {"Hipparcos Number", "HIP 6428"},
        {"Smithsonian Astrophysical Observation", "SAO 129263"},
    },
    visualMagnitude: 7.62,
    bvColour: 1.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.64175020),
        dec: Angle.Degrees(-03.80029493)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 91911"},
    },
    visualMagnitude: 11.94,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.05480551),
        dec: Angle.Degrees(-03.79937513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74555",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "NC 40"},
        {"Hipparcos Number", "HIP 74555"},
        {"Cincinnati Publication", "Ci 20 920"},
        {"Geneva Identification System", "GEN# -0.00303746"},
        {"Smithsonian Astrophysical Observation", "SAO 140396"},
        {"Wilson Evans Batten Catalogue", "WEB 12724"},
    },
    visualMagnitude: 9.84,
    bvColour: 1.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.50030750),
        dec: Angle.Degrees(-03.79836583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -735.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 149.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81764"},
        {"Hipparcos Number", "HIP 46389"},
        {"Geneva Identification System", "GEN# +1.00081764"},
        {"Smithsonian Astrophysical Observation", "SAO 136867"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.88540153),
        dec: Angle.Degrees(-03.79778712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98529",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189620"},
        {"Hipparcos Number", "HIP 98529"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.24974011),
        dec: Angle.Degrees(-03.79614372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29177",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42204"},
        {"Hipparcos Number", "HIP 29177"},
        {"Celescope Catalog", "CEL 1094"},
        {"Geneva Identification System", "GEN# +1.00042204"},
        {"Smithsonian Astrophysical Observation", "SAO 132889"},
        {"Wilson Evans Batten Catalogue", "WEB 5720"},
    },
    visualMagnitude: 8.45,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.33143227),
        dec: Angle.Degrees(-03.79477983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108836",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108836"},
    },
    visualMagnitude: 10.99,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.72119167),
        dec: Angle.Degrees(-03.79390763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -121.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -188.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149306"},
        {"Hipparcos Number", "HIP 81111"},
        {"Smithsonian Astrophysical Observation", "SAO 141246"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.49198682),
        dec: Angle.Degrees(-03.79022833)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23602",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293782"},
        {"Hipparcos Number", "HIP 23602"},
        {"Geneva Identification System", "GEN# +1.00293782"},
    },
    visualMagnitude: 10.51,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.12494946),
        dec: Angle.Degrees(-03.78729237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46326"},
        {"Hipparcos Number", "HIP 31181"},
        {"Smithsonian Astrophysical Observation", "SAO 133385"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.051,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.14530313),
        dec: Angle.Degrees(-03.78524094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22784"},
        {"Hipparcos Number", "HIP 17093"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.92192423),
        dec: Angle.Degrees(-03.78493635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51279"},
        {"Hipparcos Number", "HIP 33381"},
        {"Smithsonian Astrophysical Observation", "SAO 133922"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.14205489),
        dec: Angle.Degrees(-03.78451891)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45657"},
        {"Hipparcos Number", "HIP 30843"},
        {"Smithsonian Astrophysical Observation", "SAO 133310"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.16473397),
        dec: Angle.Degrees(-03.78449068)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74123"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.701,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.22485802),
        dec: Angle.Degrees(-03.78311383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -219.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -163.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79610"},
        {"Hipparcos Number", "HIP 45398"},
        {"Geneva Identification System", "GEN# +1.00079610"},
        {"Smithsonian Astrophysical Observation", "SAO 136692"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.429,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.77335472),
        dec: Angle.Degrees(-03.78241945)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30654"},
        {"Hipparcos Number", "HIP 22412"},
        {"Geneva Identification System", "GEN# +1.00030654"},
        {"Smithsonian Astrophysical Observation", "SAO 131520"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.34323757),
        dec: Angle.Degrees(-03.78240049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71410",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128273"},
        {"Hipparcos Number", "HIP 71410"},
        {"Smithsonian Astrophysical Observation", "SAO 140025"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.04379183),
        dec: Angle.Degrees(-03.78101523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5845",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7493"},
        {"Hipparcos Number", "HIP 5845"},
        {"Smithsonian Astrophysical Observation", "SAO 129198"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.75246749),
        dec: Angle.Degrees(-03.78093737)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44594",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77894"},
        {"Hipparcos Number", "HIP 44594"},
        {"Smithsonian Astrophysical Observation", "SAO 136563"},
        {"Wilson Evans Batten Catalogue", "WEB 8532"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.27207138),
        dec: Angle.Degrees(-03.78088477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92155",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173725"},
        {"Hipparcos Number", "HIP 92155"},
        {"Smithsonian Astrophysical Observation", "SAO 142615"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.74570830),
        dec: Angle.Degrees(-03.78003458)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105912"},
        {"Hipparcos Number", "HIP 59422"},
        {"Smithsonian Astrophysical Observation", "SAO 138638"},
    },
    visualMagnitude: 6.95,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.84107311),
        dec: Angle.Degrees(-03.77871780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78871"},
        {"Hipparcos Number", "HIP 45041"},
        {"Smithsonian Astrophysical Observation", "SAO 136638"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.60752530),
        dec: Angle.Degrees(-03.77795832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103327"},
        {"Hipparcos Number", "HIP 58007"},
        {"Geneva Identification System", "GEN# +1.00103327"},
        {"Smithsonian Astrophysical Observation", "SAO 138464"},
        {"Wilson Evans Batten Catalogue", "WEB 10391"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.46693943),
        dec: Angle.Degrees(-03.77674940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210910"},
        {"Hipparcos Number", "HIP 109733"},
        {"Smithsonian Astrophysical Observation", "SAO 145952"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.42588900),
        dec: Angle.Degrees(-03.77567667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180996"},
        {"Hipparcos Number", "HIP 94917"},
        {"Geneva Identification System", "GEN# +1.00180996"},
        {"Smithsonian Astrophysical Observation", "SAO 143255"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.72258472),
        dec: Angle.Degrees(-03.77525466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82822"},
        {"Hipparcos Number", "HIP 46967"},
        {"Smithsonian Astrophysical Observation", "SAO 136960"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.59085502),
        dec: Angle.Degrees(-03.77372283)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75706",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75706"},
        {"Smithsonian Astrophysical Observation", "SAO 140548"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00393654),
        dec: Angle.Degrees(-03.77084715)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28036"},
        {"Hipparcos Number", "HIP 20643"},
        {"Smithsonian Astrophysical Observation", "SAO 131198"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.35918068),
        dec: Angle.Degrees(-03.76906170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133746"},
        {"Hipparcos Number", "HIP 73912"},
        {"Geneva Identification System", "GEN# +1.00133746"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.57399735),
        dec: Angle.Degrees(-03.76768736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28181"},
        {"Hipparcos Number", "HIP 20738"},
        {"Geneva Identification System", "GEN# +1.00028181"},
        {"Smithsonian Astrophysical Observation", "SAO 131209"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.66172022),
        dec: Angle.Degrees(-03.76751368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143615"},
        {"Hipparcos Number", "HIP 78513"},
        {"Geneva Identification System", "GEN# +1.00143615"},
        {"Smithsonian Astrophysical Observation", "SAO 140903"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.42177662),
        dec: Angle.Degrees(-03.76350767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -76.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1866",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 1866"},
        {"Geneva Identification System", "GEN# +9.80031047"},
    },
    visualMagnitude: 10.66,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.90706384),
        dec: Angle.Degrees(-03.76335753)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 250.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55435",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98665"},
        {"Hipparcos Number", "HIP 55435"},
        {"Smithsonian Astrophysical Observation", "SAO 138151"},
    },
    visualMagnitude: 9.24,
    bvColour: 1.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28535793),
        dec: Angle.Degrees(-03.76258386)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92560"},
        {"Hipparcos Number", "HIP 52298"},
        {"Smithsonian Astrophysical Observation", "SAO 137726"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.413,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.28954423),
        dec: Angle.Degrees(-03.76234782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98007"},
        {"Hipparcos Number", "HIP 55057"},
        {"Geneva Identification System", "GEN# +1.00098007"},
        {"Smithsonian Astrophysical Observation", "SAO 138097"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.729,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.07006540),
        dec: Angle.Degrees(-03.76162389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -196.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71173",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71173"},
        {"Smithsonian Astrophysical Observation", "SAO 139996"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.34864710),
        dec: Angle.Degrees(-03.76088384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116638",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222147"},
        {"Hipparcos Number", "HIP 116638"},
        {"Smithsonian Astrophysical Observation", "SAO 146814"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.54398334),
        dec: Angle.Degrees(-03.75921902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59474"},
        {"Hipparcos Number", "HIP 36447"},
        {"Smithsonian Astrophysical Observation", "SAO 134755"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.50328949),
        dec: Angle.Degrees(-03.75858181)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74057",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134068"},
        {"Hipparcos Number", "HIP 74057"},
        {"Smithsonian Astrophysical Observation", "SAO 140338"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.02416179),
        dec: Angle.Degrees(-03.75672601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28156",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40146"},
        {"Hipparcos Number", "HIP 28156"},
        {"Renson", "Renson 10710"},
        {"Smithsonian Astrophysical Observation", "SAO 132680"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.146,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.24541451),
        dec: Angle.Degrees(-03.75565569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52690"},
        {"Hipparcos Number", "HIP 33891"},
        {"Geneva Identification System", "GEN# +1.00052690J"},
        {"Smithsonian Astrophysical Observation", "SAO 134082"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.52805013),
        dec: Angle.Degrees(-03.75482839)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193240"},
        {"Hipparcos Number", "HIP 100188"},
        {"Smithsonian Astrophysical Observation", "SAO 144290"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.83121784),
        dec: Angle.Degrees(-03.75414182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70958"},
        {"Hipparcos Number", "HIP 41211"},
        {"Geneva Identification System", "GEN# +1.00070958"},
        {"Smithsonian Astrophysical Observation", "SAO 135877"},
        {"Wilson Evans Batten Catalogue", "WEB 7975"},
    },
    visualMagnitude: 5.61,
    bvColour: 0.478,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.14640836),
        dec: Angle.Degrees(-03.75117744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -211.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20242",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27485"},
        {"Hipparcos Number", "HIP 20242"},
        {"Geneva Identification System", "GEN# +1.00027485"},
        {"Smithsonian Astrophysical Observation", "SAO 131123"},
        {"Wilson Evans Batten Catalogue", "WEB 3862"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.06072810),
        dec: Angle.Degrees(-03.75062710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -318.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69537",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124495"},
        {"Hipparcos Number", "HIP 69537"},
        {"Smithsonian Astrophysical Observation", "SAO 139802"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.973,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.52287522),
        dec: Angle.Degrees(-03.75047707)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36791",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36791"},
        {"Smithsonian Astrophysical Observation", "SAO 134842"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.50957661),
        dec: Angle.Degrees(-03.74895962)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56610"},
        {"Hipparcos Number", "HIP 35306"},
        {"Smithsonian Astrophysical Observation", "SAO 134475"},
    },
    visualMagnitude: 7.38,
    bvColour: -0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.39697323),
        dec: Angle.Degrees(-03.74798527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30026",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43990"},
        {"Hipparcos Number", "HIP 30026"},
        {"Smithsonian Astrophysical Observation", "SAO 133094"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.77631200),
        dec: Angle.Degrees(-03.74692211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188129"},
        {"Hipparcos Number", "HIP 97901"},
        {"Smithsonian Astrophysical Observation", "SAO 143892"},
    },
    visualMagnitude: 9.30,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.43413038),
        dec: Angle.Degrees(-03.74600770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27861"},
        {"Hipparcos Number", "HIP 20507"},
        {"Fundamental Katalog 5th Edition", "FK5 1120"},
        {"Geneva Identification System", "GEN# +1.00027861"},
        {"Smithsonian Astrophysical Observation", "SAO 131176"},
        {"Wilson Evans Batten Catalogue", "WEB 3924"},
    },
    visualMagnitude: 5.17,
    bvColour: 0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.92033483),
        dec: Angle.Degrees(-03.74533244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49986",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49986"},
        {"Geneva Identification System", "GEN# -0.00302870"},
        {"Smithsonian Astrophysical Observation", "SAO 137411"},
        {"Wilson Evans Batten Catalogue", "WEB 9193"},
    },
    visualMagnitude: 9.26,
    bvColour: 1.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.07398953),
        dec: Angle.Degrees(-03.74507182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -152.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -242.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91167"},
        {"Hipparcos Number", "HIP 51527"},
        {"Smithsonian Astrophysical Observation", "SAO 137618"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.85832229),
        dec: Angle.Degrees(-03.74345131)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90763"},
        {"Hipparcos Number", "HIP 51302"},
        {"Geneva Identification System", "GEN# +1.00090763"},
        {"Renson", "Renson 26060"},
        {"Smithsonian Astrophysical Observation", "SAO 137591"},
    },
    visualMagnitude: 6.05,
    bvColour: 0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.18316638),
        dec: Angle.Degrees(-03.74231608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102331"},
        {"Hipparcos Number", "HIP 57456"},
        {"Geneva Identification System", "GEN# +1.00102331"},
        {"Smithsonian Astrophysical Observation", "SAO 138399"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.66943728),
        dec: Angle.Degrees(-03.74231571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43023"},
        {"Hipparcos Number", "HIP 29575"},
        {"Geneva Identification System", "GEN# +1.00043023"},
        {"Smithsonian Astrophysical Observation", "SAO 132994"},
        {"Wilson Evans Batten Catalogue", "WEB 5816"},
    },
    visualMagnitude: 5.83,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.47601857),
        dec: Angle.Degrees(-03.74142288)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4374",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5435"},
        {"Hipparcos Number", "HIP 4374"},
        {"Geneva Identification System", "GEN# +1.00005435"},
        {"Smithsonian Astrophysical Observation", "SAO 129035"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.00894383),
        dec: Angle.Degrees(-03.73796256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110471",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212204"},
        {"Hipparcos Number", "HIP 110471"},
        {"Smithsonian Astrophysical Observation", "SAO 146058"},
    },
    visualMagnitude: 8.22,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.65604932),
        dec: Angle.Degrees(-03.73700663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95494",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182576"},
        {"Hipparcos Number", "HIP 95494"},
        {"Geneva Identification System", "GEN# +1.00182576"},
        {"Smithsonian Astrophysical Observation", "SAO 143384"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.36083598),
        dec: Angle.Degrees(-03.73501308)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31768"},
        {"Hipparcos Number", "HIP 23116"},
        {"Geneva Identification System", "GEN# +1.00031768"},
        {"Smithsonian Astrophysical Observation", "SAO 131645"},
    },
    visualMagnitude: 6.97,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.60897584),
        dec: Angle.Degrees(-03.73300361)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 78.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157333"},
        {"Hipparcos Number", "HIP 85031"},
        {"Geneva Identification System", "GEN# +1.00157333"},
        {"Smithsonian Astrophysical Observation", "SAO 141638"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.726,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.68826462),
        dec: Angle.Degrees(-03.73148949)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37887"},
        {"Hipparcos Number", "HIP 26812"},
        {"Geneva Identification System", "GEN# +1.00037887"},
        {"Smithsonian Astrophysical Observation", "SAO 132463"},
    },
    visualMagnitude: 7.73,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.40010905),
        dec: Angle.Degrees(-03.73116315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88442",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164877"},
        {"Hipparcos Number", "HIP 88442"},
        {"Renson", "Renson 46584"},
        {"Smithsonian Astrophysical Observation", "SAO 142055"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.325,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.84749457),
        dec: Angle.Degrees(-03.72728619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70258",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125905"},
        {"Hipparcos Number", "HIP 70258"},
        {"Smithsonian Astrophysical Observation", "SAO 139896"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.63253888),
        dec: Angle.Degrees(-03.72708546)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174796"},
        {"Hipparcos Number", "HIP 92628"},
        {"Geneva Identification System", "GEN# +1.00174796"},
        {"Smithsonian Astrophysical Observation", "SAO 142731"},
        {"Wilson Evans Batten Catalogue", "WEB 16025"},
    },
    visualMagnitude: 7.08,
    bvColour: 1.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.10708118),
        dec: Angle.Degrees(-03.72562169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109376"},
        {"Hipparcos Number", "HIP 61349"},
        {"Geneva Identification System", "GEN# +1.00109376"},
        {"Smithsonian Astrophysical Observation", "SAO 138852"},
    },
    visualMagnitude: 8.61,
    bvColour: 0.733,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.55526725),
        dec: Angle.Degrees(-03.72102069)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27574"},
        {"Hipparcos Number", "HIP 20303"},
        {"Geneva Identification System", "GEN# +1.00027574"},
        {"Smithsonian Astrophysical Observation", "SAO 131137"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.994,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.25661339),
        dec: Angle.Degrees(-03.71891573)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181939"},
        {"Hipparcos Number", "HIP 95236"},
        {"Smithsonian Astrophysical Observation", "SAO 143328"},
    },
    visualMagnitude: 7.07,
    bvColour: 0.130,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.64155415),
        dec: Angle.Degrees(-03.71813038)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46021"},
        {"Hipparcos Number", "HIP 31040"},
        {"Smithsonian Astrophysical Observation", "SAO 133354"},
    },
    visualMagnitude: 7.54,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.69727361),
        dec: Angle.Degrees(-03.71308436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109013"},
        {"Hipparcos Number", "HIP 61139"},
        {"Smithsonian Astrophysical Observation", "SAO 138833"},
    },
    visualMagnitude: 9.20,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.92355226),
        dec: Angle.Degrees(-03.71308084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126482"},
        {"Hipparcos Number", "HIP 70556"},
        {"Smithsonian Astrophysical Observation", "SAO 139925"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.352,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.49096232),
        dec: Angle.Degrees(-03.71305336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18331"},
        {"Hipparcos Number", "HIP 13717"},
        {"Fundamental Katalog 5th Edition", "FK5 1080"},
        {"Geneva Identification System", "GEN# +1.00018331"},
        {"Smithsonian Astrophysical Observation", "SAO 130199"},
        {"Wilson Evans Batten Catalogue", "WEB 2720"},
    },
    visualMagnitude: 5.16,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.15602146),
        dec: Angle.Degrees(-03.71221461)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9152",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12022"},
        {"Hipparcos Number", "HIP 9152"},
        {"Smithsonian Astrophysical Observation", "SAO 129587"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.48150753),
        dec: Angle.Degrees(-03.71220510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4621"},
        {"Hipparcos Number", "HIP 3746"},
        {"Smithsonian Astrophysical Observation", "SAO 128963"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.01625333),
        dec: Angle.Degrees(-03.71198928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35231",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56423"},
        {"Hipparcos Number", "HIP 35231"},
        {"Geneva Identification System", "GEN# +1.00056423"},
        {"Smithsonian Astrophysical Observation", "SAO 134447"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.22230118),
        dec: Angle.Degrees(-03.71054423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36956"},
        {"Hipparcos Number", "HIP 26209"},
        {"Smithsonian Astrophysical Observation", "SAO 132304"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.78823103),
        dec: Angle.Degrees(-03.71047488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12479",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16710"},
        {"Hipparcos Number", "HIP 12479"},
        {"Smithsonian Astrophysical Observation", "SAO 130051"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15555488),
        dec: Angle.Degrees(-03.70866495)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16456",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21927"},
        {"Hipparcos Number", "HIP 16456"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.459,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.00197070),
        dec: Angle.Degrees(-03.70746681)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111632"},
        {"Hipparcos Number", "HIP 62688"},
        {"Smithsonian Astrophysical Observation", "SAO 138991"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.68354082),
        dec: Angle.Degrees(-03.70710400)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118674"},
        {"Hipparcos Number", "HIP 66549"},
        {"Smithsonian Astrophysical Observation", "SAO 139458"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.885,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.62681922),
        dec: Angle.Degrees(-03.70674292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111411"},
        {"Hipparcos Number", "HIP 62567"},
        {"Geneva Identification System", "GEN# +1.00111411"},
        {"Smithsonian Astrophysical Observation", "SAO 138980"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.414,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.29245000),
        dec: Angle.Degrees(-03.69937207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176984"},
        {"Hipparcos Number", "HIP 93526"},
        {"Celescope Catalog", "CEL 4693"},
        {"Geneva Identification System", "GEN# +1.00176984"},
        {"Smithsonian Astrophysical Observation", "SAO 142959"},
        {"Wilson Evans Batten Catalogue", "WEB 16240"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.72704960),
        dec: Angle.Degrees(-03.69900363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91565"},
        {"Hipparcos Number", "HIP 51745"},
        {"Smithsonian Astrophysical Observation", "SAO 137647"},
    },
    visualMagnitude: 8.73,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.58183324),
        dec: Angle.Degrees(-03.69553106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11258"},
        {"Hipparcos Number", "HIP 8566"},
        {"Smithsonian Astrophysical Observation", "SAO 129528"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.62321074),
        dec: Angle.Degrees(-03.69458250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79593",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Yed Prior"},
        {"Henry Draper", "HD 146051"},
        {"Hipparcos Number", "HIP 79593"},
        {"Fundamental Katalog 5th Edition", "FK5 603"},
        {"Geneva Identification System", "GEN# +1.00146051"},
        {"Smithsonian Astrophysical Observation", "SAO 141052"},
        {"Wilson Evans Batten Catalogue", "WEB 13466"},
    },
    visualMagnitude: 2.73,
    bvColour: 1.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.58652601),
        dec: Angle.Degrees(-03.69397562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -142.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135005"},
        {"Hipparcos Number", "HIP 74464"},
        {"Geneva Identification System", "GEN# +1.00135005"},
        {"Smithsonian Astrophysical Observation", "SAO 140383"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.699,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.25132153),
        dec: Angle.Degrees(-03.69263281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -97.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33405",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51332"},
        {"Hipparcos Number", "HIP 33405"},
        {"Geneva Identification System", "GEN# +1.00051332"},
        {"Smithsonian Astrophysical Observation", "SAO 133933"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.418,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.21513456),
        dec: Angle.Degrees(-03.69233720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164259"},
        {"Hipparcos Number", "HIP 88175"},
        {"Geneva Identification System", "GEN# +1.00164259"},
        {"Smithsonian Astrophysical Observation", "SAO 142025"},
        {"Wilson Evans Batten Catalogue", "WEB 14898"},
    },
    visualMagnitude: 4.62,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.12050178),
        dec: Angle.Degrees(-03.69016112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 154.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7999",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10550"},
        {"Hipparcos Number", "HIP 7999"},
        {"Fundamental Katalog 5th Edition", "FK5 1049"},
        {"Geneva Identification System", "GEN# +1.00010550"},
        {"Smithsonian Astrophysical Observation", "SAO 129465"},
        {"Wilson Evans Batten Catalogue", "WEB 1715"},
    },
    visualMagnitude: 4.98,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.68132047),
        dec: Angle.Degrees(-03.69011692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48477",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 48477"},
        {"Geneva Identification System", "GEN# -0.00203000"},
    },
    visualMagnitude: 10.53,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.29933992),
        dec: Angle.Degrees(-03.68899298)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -103.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -460.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74701"},
        {"Hipparcos Number", "HIP 42960"},
        {"Smithsonian Astrophysical Observation", "SAO 136246"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.35102600),
        dec: Angle.Degrees(-03.68152732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28576",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40914"},
        {"Hipparcos Number", "HIP 28576"},
        {"Smithsonian Astrophysical Observation", "SAO 132755"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.213,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.46328912),
        dec: Angle.Degrees(-03.68137244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105183",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202818"},
        {"Hipparcos Number", "HIP 105183"},
        {"Geneva Identification System", "GEN# +1.00202818"},
        {"Smithsonian Astrophysical Observation", "SAO 145283"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.61270219),
        dec: Angle.Degrees(-03.68021205)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 58.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63094"},
        {"Hipparcos Number", "HIP 37965"},
        {"Smithsonian Astrophysical Observation", "SAO 135094"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.73450767),
        dec: Angle.Degrees(-03.68017594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65695"},
        {"Hipparcos Number", "HIP 39079"},
        {"Fundamental Katalog 5th Edition", "FK5 304"},
        {"Geneva Identification System", "GEN# +1.00065695"},
        {"Smithsonian Astrophysical Observation", "SAO 135345"},
        {"Wilson Evans Batten Catalogue", "WEB 7664"},
    },
    visualMagnitude: 4.93,
    bvColour: 1.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.93410303),
        dec: Angle.Degrees(-03.67957835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -55.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80864",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148803"},
        {"Hipparcos Number", "HIP 80864"},
        {"Geneva Identification System", "GEN# +1.00148803"},
        {"Smithsonian Astrophysical Observation", "SAO 141214"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.593,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.68500424),
        dec: Angle.Degrees(-03.67931622)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 788",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 518"},
        {"Hipparcos Number", "HIP 788"},
        {"Smithsonian Astrophysical Observation", "SAO 128615"},
    },
    visualMagnitude: 9.59,
    bvColour: 0.469,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.43212812),
        dec: Angle.Degrees(-03.67851928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 42.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60451",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107857"},
        {"Hipparcos Number", "HIP 60451"},
        {"Smithsonian Astrophysical Observation", "SAO 138755"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.89945033),
        dec: Angle.Degrees(-03.67743256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -43.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199363"},
        {"Hipparcos Number", "HIP 103384"},
        {"Smithsonian Astrophysical Observation", "SAO 144967"},
    },
    visualMagnitude: 7.24,
    bvColour: 1.071,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.18605334),
        dec: Angle.Degrees(-03.67453290)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18689"},
        {"Hipparcos Number", "HIP 13986"},
        {"Geneva Identification System", "GEN# +1.00018689"},
        {"Smithsonian Astrophysical Observation", "SAO 130233"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.432,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.02971089),
        dec: Angle.Degrees(-03.67288805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25878",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36395"},
        {"Hipparcos Number", "HIP 25878"},
        {"Cincinnati Publication", "Ci 20 334"},
        {"Geneva Identification System", "GEN# +1.00036395"},
        {"Smithsonian Astrophysical Observation", "SAO 132211"},
        {"Wilson Evans Batten Catalogue", "WEB 5024"},
    },
    visualMagnitude: 7.97,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.86229396),
        dec: Angle.Degrees(-03.67214214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 763.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2092.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23661",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32721"},
        {"Hipparcos Number", "HIP 23661"},
        {"Geneva Identification System", "GEN# +1.00032721"},
        {"Smithsonian Astrophysical Observation", "SAO 131749"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.27633933),
        dec: Angle.Degrees(-03.67012006)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25041"},
        {"Hipparcos Number", "HIP 18588"},
        {"Geneva Identification System", "GEN# +1.00025041"},
        {"Smithsonian Astrophysical Observation", "SAO 130859"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.66725103),
        dec: Angle.Degrees(-03.66514931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8759 AB"},
        {"Henry Draper", "HD 113459"},
        {"Hipparcos Number", "HIP 63750"},
        {"Geneva Identification System", "GEN# +1.00113459"},
        {"Smithsonian Astrophysical Observation", "SAO 139131"},
        {"Wilson Evans Batten Catalogue", "WEB 11274"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.296,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.97683982),
        dec: Angle.Degrees(-03.66304672)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102679",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102679"},
    },
    visualMagnitude: 11.76,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.10001978),
        dec: Angle.Degrees(-03.66295036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 158.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68050",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121523"},
        {"Hipparcos Number", "HIP 68050"},
        {"Smithsonian Astrophysical Observation", "SAO 139628"},
    },
    visualMagnitude: 6.78,
    bvColour: 1.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.00162802),
        dec: Angle.Degrees(-03.66189387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99217",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13409 AB"},
        {"Henry Draper", "HD 191146"},
        {"Hipparcos Number", "HIP 99217"},
        {"Smithsonian Astrophysical Observation", "SAO 144105"},
    },
    visualMagnitude: 9.52,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.12198311),
        dec: Angle.Degrees(-03.66144464)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65540",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116817"},
        {"Hipparcos Number", "HIP 65540"},
        {"Smithsonian Astrophysical Observation", "SAO 139336"},
    },
    visualMagnitude: 7.06,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.53612763),
        dec: Angle.Degrees(-03.66109193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94122"},
        {"Hipparcos Number", "HIP 53093"},
        {"Smithsonian Astrophysical Observation", "SAO 137845"},
    },
    visualMagnitude: 9.16,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.92836514),
        dec: Angle.Degrees(-03.65979150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -161.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 94.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30914"},
        {"Hipparcos Number", "HIP 22577"},
        {"Smithsonian Astrophysical Observation", "SAO 131545"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.87747368),
        dec: Angle.Degrees(-03.65954240)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143819"},
        {"Hipparcos Number", "HIP 78577"},
        {"Geneva Identification System", "GEN# +1.00143819"},
        {"Smithsonian Astrophysical Observation", "SAO 140912"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.67678778),
        dec: Angle.Degrees(-03.65797466)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -75.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37322"},
        {"Hipparcos Number", "HIP 26448"},
        {"Geneva Identification System", "GEN# +1.00037322"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.40894777),
        dec: Angle.Degrees(-03.65493179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1112"},
        {"Hipparcos Number", "HIP 1241"},
        {"Geneva Identification System", "GEN# +1.00001112"},
        {"Smithsonian Astrophysical Observation", "SAO 128663"},
    },
    visualMagnitude: 9.11,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.86367401),
        dec: Angle.Degrees(-03.65418943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113391",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217052"},
        {"Hipparcos Number", "HIP 113391"},
        {"Smithsonian Astrophysical Observation", "SAO 146410"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.328,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.46908490),
        dec: Angle.Degrees(-03.65398996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51304"},
        {"Hipparcos Number", "HIP 33395"},
        {"Geneva Identification System", "GEN# +1.00051304"},
        {"Smithsonian Astrophysical Observation", "SAO 133929"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.19221922),
        dec: Angle.Degrees(-03.65373794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55084",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98058"},
        {"Hipparcos Number", "HIP 55084"},
        {"Fundamental Katalog 5th Edition", "FK5 1292"},
        {"Geneva Identification System", "GEN# +1.00098058"},
        {"Smithsonian Astrophysical Observation", "SAO 138102"},
        {"Wilson Evans Batten Catalogue", "WEB 9934"},
    },
    visualMagnitude: 4.45,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.16568371),
        dec: Angle.Degrees(-03.65151412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -108.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115525",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115525"},
        {"Smithsonian Astrophysical Observation", "SAO 146685"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.696,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.01944357),
        dec: Angle.Degrees(-03.64767094)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 62.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90057"},
        {"Hipparcos Number", "HIP 50893"},
        {"Smithsonian Astrophysical Observation", "SAO 137534"},
    },
    visualMagnitude: 6.39,
    bvColour: 1.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.88609768),
        dec: Angle.Degrees(-03.64286765)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 172104"},
        {"Hipparcos Number", "HIP 91403"},
        {"Smithsonian Astrophysical Observation", "SAO 142462"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.61237718),
        dec: Angle.Degrees(-03.64256232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177655"},
        {"Hipparcos Number", "HIP 93768"},
        {"Smithsonian Astrophysical Observation", "SAO 143010"},
    },
    visualMagnitude: 8.54,
    bvColour: 1.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.44226925),
        dec: Angle.Degrees(-03.63958093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92200",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173818"},
        {"Hipparcos Number", "HIP 92200"},
        {"Cincinnati Publication", "Ci 18 2459"},
        {"Geneva Identification System", "GEN# +1.00173818"},
        {"Smithsonian Astrophysical Observation", "SAO 142621"},
        {"Wilson Evans Batten Catalogue", "WEB 15902"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.86386608),
        dec: Angle.Degrees(-03.63916615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -132.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -273.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38973",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65409"},
        {"Hipparcos Number", "HIP 38973"},
        {"Smithsonian Astrophysical Observation", "SAO 135317"},
    },
    visualMagnitude: 8.11,
    bvColour: -0.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.62639660),
        dec: Angle.Degrees(-03.63781423)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42761"},
        {"Hipparcos Number", "HIP 29461"},
        {"Geneva Identification System", "GEN# +1.00042761"},
        {"Smithsonian Astrophysical Observation", "SAO 132954"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.792,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.11352122),
        dec: Angle.Degrees(-03.63671438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193783"},
        {"Hipparcos Number", "HIP 100454"},
        {"Smithsonian Astrophysical Observation", "SAO 144347"},
    },
    visualMagnitude: 8.70,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.55685539),
        dec: Angle.Degrees(-03.63490957)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10416",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13789"},
        {"Hipparcos Number", "HIP 10416"},
        {"Smithsonian Astrophysical Observation", "SAO 129769"},
    },
    visualMagnitude: 8.55,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.55657244),
        dec: Angle.Degrees(-03.63467442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -217.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56697",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56697"},
        {"Smithsonian Astrophysical Observation", "SAO 138308"},
    },
    visualMagnitude: 9.98,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.38577769),
        dec: Angle.Degrees(-03.63403610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86445"},
        {"Hipparcos Number", "HIP 48897"},
        {"Geneva Identification System", "GEN# +1.00086445"},
        {"Smithsonian Astrophysical Observation", "SAO 137262"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.62192118),
        dec: Angle.Degrees(-03.63390900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181909"},
        {"Hipparcos Number", "HIP 95225"},
        {"Smithsonian Astrophysical Observation", "SAO 143325"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.60654378),
        dec: Angle.Degrees(-03.63379168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22432"},
        {"Hipparcos Number", "HIP 16823"},
        {"Smithsonian Astrophysical Observation", "SAO 130604"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.11632268),
        dec: Angle.Degrees(-03.63289630)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37807"},
        {"Hipparcos Number", "HIP 26766"},
        {"Celescope Catalog", "CEL 928"},
        {"Geneva Identification System", "GEN# +1.00037807"},
        {"Renson", "Renson 10200"},
        {"Smithsonian Astrophysical Observation", "SAO 132455"},
    },
    visualMagnitude: 7.90,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.28385794),
        dec: Angle.Degrees(-03.63255807)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131634"},
        {"Hipparcos Number", "HIP 72990"},
        {"Geneva Identification System", "GEN# +1.00131634"},
        {"Smithsonian Astrophysical Observation", "SAO 140219"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.73886244),
        dec: Angle.Degrees(-03.63053009)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 22.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151923"},
        {"Hipparcos Number", "HIP 82412"},
        {"Smithsonian Astrophysical Observation", "SAO 141395"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.62424983),
        dec: Angle.Degrees(-03.62742329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96197",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96197"},
        {"Smithsonian Astrophysical Observation", "SAO 143531"},
    },
    visualMagnitude: 9.65,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.40520700),
        dec: Angle.Degrees(-03.62660357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208"},
        {"Hipparcos Number", "HIP 569"},
        {"Geneva Identification System", "GEN# +1.00000208"},
        {"Smithsonian Astrophysical Observation", "SAO 128589"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.72480379),
        dec: Angle.Degrees(-03.62572272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174323"},
        {"Hipparcos Number", "HIP 92426"},
        {"Geneva Identification System", "GEN# +1.00174323"},
        {"Smithsonian Astrophysical Observation", "SAO 142673"},
        {"Wilson Evans Batten Catalogue", "WEB 15966"},
    },
    visualMagnitude: 6.93,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.53683768),
        dec: Angle.Degrees(-03.62249855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33928"},
        {"Hipparcos Number", "HIP 24367"},
        {"Celescope Catalog", "CEL 575"},
        {"Smithsonian Astrophysical Observation", "SAO 131889"},
    },
    visualMagnitude: 7.09,
    bvColour: -0.133,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.41274054),
        dec: Angle.Degrees(-03.62202412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81584",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10142 AB"},
        {"Henry Draper", "HD 150218"},
        {"Hipparcos Number", "HIP 81584"},
        {"Smithsonian Astrophysical Observation", "SAO 141299"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.92691915),
        dec: Angle.Degrees(-03.61953733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17490"},
        {"Hipparcos Number", "HIP 13085"},
        {"Smithsonian Astrophysical Observation", "SAO 130117"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.102,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.05494154),
        dec: Angle.Degrees(-03.61915487)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167564"},
        {"Hipparcos Number", "HIP 89512"},
        {"Geneva Identification System", "GEN# +1.00167564"},
        {"Smithsonian Astrophysical Observation", "SAO 142185"},
    },
    visualMagnitude: 6.35,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.99137704),
        dec: Angle.Degrees(-03.61798359)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21428",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3328 A"},
        {"Henry Draper", "HD 29227"},
        {"Hipparcos Number", "HIP 21428"},
        {"Celescope Catalog", "CEL 438"},
        {"Geneva Identification System", "GEN# +1.00029227J"},
        {"Smithsonian Astrophysical Observation", "SAO 131344"},
        {"Wilson Evans Batten Catalogue", "WEB 4112"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.00696699),
        dec: Angle.Degrees(-03.61162210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71589",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128684"},
        {"Hipparcos Number", "HIP 71589"},
        {"Smithsonian Astrophysical Observation", "SAO 140046"},
        {"Wilson Evans Batten Catalogue", "WEB 12344"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.62072756),
        dec: Angle.Degrees(-03.61103565)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84484",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 84484"},
        {"Smithsonian Astrophysical Observation", "SAO 141583"},
    },
    visualMagnitude: 10.04,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.07630333),
        dec: Angle.Degrees(-03.61084532)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214571"},
        {"Hipparcos Number", "HIP 111840"},
        {"Smithsonian Astrophysical Observation", "SAO 146222"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.274,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.81486523),
        dec: Angle.Degrees(-03.60739526)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139343"},
        {"Hipparcos Number", "HIP 76528"},
        {"Geneva Identification System", "GEN# +1.00139343"},
        {"Smithsonian Astrophysical Observation", "SAO 140663"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.43991183),
        dec: Angle.Degrees(-03.60512250)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31967"},
        {"Hipparcos Number", "HIP 23219"},
        {"Smithsonian Astrophysical Observation", "SAO 131665"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.94973932),
        dec: Angle.Degrees(-03.60445345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29037",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41895"},
        {"Hipparcos Number", "HIP 29037"},
        {"Celescope Catalog", "CEL 1086"},
        {"Smithsonian Astrophysical Observation", "SAO 132860"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.89237619),
        dec: Angle.Degrees(-03.60335829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1878"},
        {"Hipparcos Number", "HIP 1825"},
        {"Smithsonian Astrophysical Observation", "SAO 128731"},
    },
    visualMagnitude: 8.57,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.77376216),
        dec: Angle.Degrees(-03.60327036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6052"},
        {"Hipparcos Number", "HIP 4808"},
        {"Smithsonian Astrophysical Observation", "SAO 129089"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.157,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.42962242),
        dec: Angle.Degrees(-03.60082439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73690",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73690"},
        {"Smithsonian Astrophysical Observation", "SAO 140293"},
    },
    visualMagnitude: 9.94,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.93532240),
        dec: Angle.Degrees(-03.59951408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111454",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213896"},
        {"Hipparcos Number", "HIP 111454"},
        {"Smithsonian Astrophysical Observation", "SAO 146171"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.601,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.67545688),
        dec: Angle.Degrees(-03.59943991)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 73.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58132",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103549"},
        {"Hipparcos Number", "HIP 58132"},
        {"Smithsonian Astrophysical Observation", "SAO 138483"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.84861488),
        dec: Angle.Degrees(-03.59936960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209225"},
        {"Hipparcos Number", "HIP 108754"},
        {"Smithsonian Astrophysical Observation", "SAO 145818"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.525,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.45474442),
        dec: Angle.Degrees(-03.59774859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 30.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63800"},
        {"Hipparcos Number", "HIP 38274"},
        {"Renson", "Renson 17603"},
        {"Smithsonian Astrophysical Observation", "SAO 135160"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.62765965),
        dec: Angle.Degrees(-03.59771039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24326"},
        {"Hipparcos Number", "HIP 18102"},
        {"Geneva Identification System", "GEN# +1.00024326"},
        {"Smithsonian Astrophysical Observation", "SAO 130782"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.03296722),
        dec: Angle.Degrees(-03.59684314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61606"},
        {"Hipparcos Number", "HIP 37349"},
        {"Cincinnati Publication", "Ci 18 918"},
        {"Geneva Identification System", "GEN# +1.00061606A"},
        {"Geneva Identification System 2", "GEN# +1.10061606"},
        {"Smithsonian Astrophysical Observation", "SAO 134954"},
        {"Wilson Evans Batten Catalogue", "WEB 7393"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.891,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.99703127),
        dec: Angle.Degrees(-03.59683158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -277.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221126"},
        {"Hipparcos Number", "HIP 115936"},
        {"Smithsonian Astrophysical Observation", "SAO 146732"},
    },
    visualMagnitude: 9.01,
    bvColour: -0.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.34178928),
        dec: Angle.Degrees(-03.59534438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27024",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38194"},
        {"Hipparcos Number", "HIP 27024"},
        {"Smithsonian Astrophysical Observation", "SAO 132491"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.97244743),
        dec: Angle.Degrees(-03.59488484)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47132"},
        {"Hipparcos Number", "HIP 31614"},
        {"Geneva Identification System", "GEN# +1.00047132"},
        {"Smithsonian Astrophysical Observation", "SAO 133481"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.25019881),
        dec: Angle.Degrees(-03.59321879)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 68.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2762",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 490 AB"},
        {"Henry Draper", "HD 3196"},
        {"Hipparcos Number", "HIP 2762"},
        {"Cincinnati Publication", "Ci 20 37"},
        {"Geneva Identification System", "GEN# +1.00003196"},
        {"Smithsonian Astrophysical Observation", "SAO 128839"},
        {"Wilson Evans Batten Catalogue", "WEB 498"},
    },
    visualMagnitude: 5.20,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.81100390),
        dec: Angle.Degrees(-03.59275785)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 407.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14598",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2366 AB"},
        {"Henry Draper", "HD 19542"},
        {"Hipparcos Number", "HIP 14598"},
        {"Smithsonian Astrophysical Observation", "SAO 130304"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.11265653),
        dec: Angle.Degrees(-03.58991485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45258"},
        {"Hipparcos Number", "HIP 30636"},
        {"Smithsonian Astrophysical Observation", "SAO 133253"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.58163161),
        dec: Angle.Degrees(-03.58489395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80616",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 80616"},
        {"Geneva Identification System", "GEN# +6.20030765"},
    },
    visualMagnitude: 10.81,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.91229935),
        dec: Angle.Degrees(-03.58423008)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169268"},
        {"Hipparcos Number", "HIP 90174"},
        {"Geneva Identification System", "GEN# +1.00169268"},
        {"Renson", "Renson 47460"},
        {"Smithsonian Astrophysical Observation", "SAO 142274"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.351,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.01499107),
        dec: Angle.Degrees(-03.58304161)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106865",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205911"},
        {"Hipparcos Number", "HIP 106865"},
        {"Smithsonian Astrophysical Observation", "SAO 145554"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.66218581),
        dec: Angle.Degrees(-03.58299249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37057"},
        {"Hipparcos Number", "HIP 26265"},
        {"Geneva Identification System", "GEN# +1.00037057"},
    },
    visualMagnitude: 9.29,
    bvColour: 0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.90609598),
        dec: Angle.Degrees(-03.57841444)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44038",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7111 A"},
        {"Henry Draper", "HD 76769"},
        {"Hipparcos Number", "HIP 44038"},
        {"Smithsonian Astrophysical Observation", "SAO 136452"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.435,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.52072661),
        dec: Angle.Degrees(-03.57793763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77988"},
        {"Hipparcos Number", "HIP 44622"},
        {"Smithsonian Astrophysical Observation", "SAO 136571"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.39334750),
        dec: Angle.Degrees(-03.57434156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99447",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191657"},
        {"Hipparcos Number", "HIP 99447"},
        {"Smithsonian Astrophysical Observation", "SAO 144143"},
    },
    visualMagnitude: 8.14,
    bvColour: 1.257,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.76782570),
        dec: Angle.Degrees(-03.57392735)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109794"},
        {"Hipparcos Number", "HIP 61608"},
        {"Smithsonian Astrophysical Observation", "SAO 138880"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.38215015),
        dec: Angle.Degrees(-03.57356026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -117.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -130.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19440",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26336"},
        {"Hipparcos Number", "HIP 19440"},
        {"Fundamental Katalog 5th Edition", "FK5 4375"},
        {"Smithsonian Astrophysical Observation", "SAO 130995"},
    },
    visualMagnitude: 6.84,
    bvColour: 0.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.45473040),
        dec: Angle.Degrees(-03.57352788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8931"},
        {"Hipparcos Number", "HIP 6832"},
        {"Smithsonian Astrophysical Observation", "SAO 129313"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.98062898),
        dec: Angle.Degrees(-03.57333138)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104368"},
        {"Hipparcos Number", "HIP 58609"},
        {"Smithsonian Astrophysical Observation", "SAO 138535"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.28660543),
        dec: Angle.Degrees(-03.57230403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12171",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1984 AB"},
        {"Henry Draper", "HD 16305"},
        {"Hipparcos Number", "HIP 12171"},
        {"Smithsonian Astrophysical Observation", "SAO 130012"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.275,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.21221975),
        dec: Angle.Degrees(-03.56988914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17674",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23704"},
        {"Hipparcos Number", "HIP 17674"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.590,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.78890515),
        dec: Angle.Degrees(-03.56985287)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134629"},
        {"Hipparcos Number", "HIP 74292"},
        {"Geneva Identification System", "GEN# +1.00134629"},
        {"Smithsonian Astrophysical Observation", "SAO 140366"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.77087165),
        dec: Angle.Degrees(-03.56729799)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117731"},
        {"Hipparcos Number", "HIP 66031"},
        {"Smithsonian Astrophysical Observation", "SAO 139393"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.377,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.06616721),
        dec: Angle.Degrees(-03.56582118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -52.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37594"},
        {"Hipparcos Number", "HIP 26624"},
        {"Geneva Identification System", "GEN# +1.00037594"},
        {"Renson", "Renson 10120"},
        {"Smithsonian Astrophysical Observation", "SAO 132424"},
    },
    visualMagnitude: 5.99,
    bvColour: 0.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.87980519),
        dec: Angle.Degrees(-03.56470944)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36527"},
        {"Hipparcos Number", "HIP 25956"},
        {"Geneva Identification System", "GEN# +1.00036527"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.06942184),
        dec: Angle.Degrees(-03.56411618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87513",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162775"},
        {"Hipparcos Number", "HIP 87513"},
        {"Geneva Identification System", "GEN# +1.00162775"},
        {"Smithsonian Astrophysical Observation", "SAO 141932"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.350,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.19843483),
        dec: Angle.Degrees(-03.56389615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137593"},
        {"Hipparcos Number", "HIP 75619"},
        {"Geneva Identification System", "GEN# +1.00137593"},
        {"Smithsonian Astrophysical Observation", "SAO 140539"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.76232548),
        dec: Angle.Degrees(-03.56174311)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103347",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199280"},
        {"Hipparcos Number", "HIP 103347"},
        {"Geneva Identification System", "GEN# +1.00199280"},
        {"Smithsonian Astrophysical Observation", "SAO 144957"},
        {"Wilson Evans Batten Catalogue", "WEB 18784"},
    },
    visualMagnitude: 6.57,
    bvColour: -0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.07600685),
        dec: Angle.Degrees(-03.56171067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12048",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16141"},
        {"Hipparcos Number", "HIP 12048"},
        {"Fundamental Katalog 5th Edition", "FK5 4237"},
        {"Geneva Identification System", "GEN# +1.00016141"},
        {"Smithsonian Astrophysical Observation", "SAO 129992"},
        {"Wilson Evans Batten Catalogue", "WEB 2480"},
    },
    visualMagnitude: 6.83,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.83341680),
        dec: Angle.Degrees(-03.55953966)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -437.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105767",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203926"},
        {"Hipparcos Number", "HIP 105767"},
        {"Fundamental Katalog 5th Edition", "FK5 3708"},
        {"Geneva Identification System", "GEN# +1.00203926"},
        {"Smithsonian Astrophysical Observation", "SAO 145384"},
        {"Wilson Evans Batten Catalogue", "WEB 19194"},
    },
    visualMagnitude: 5.48,
    bvColour: 1.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.32068720),
        dec: Angle.Degrees(-03.55657786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118209",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17137 AB"},
        {"Henry Draper", "HD 224533"},
        {"Hipparcos Number", "HIP 118209"},
        {"Fundamental Katalog 5th Edition", "FK5 900"},
        {"Geneva Identification System", "GEN# +1.00224533J"},
        {"Smithsonian Astrophysical Observation", "SAO 147008"},
        {"Wilson Evans Batten Catalogue", "WEB 20777"},
    },
    visualMagnitude: 4.88,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.66837736),
        dec: Angle.Degrees(-03.55580738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -72.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43774",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76273"},
        {"Hipparcos Number", "HIP 43774"},
        {"Geneva Identification System", "GEN# +1.00076273"},
        {"Renson", "Renson 21381"},
        {"Smithsonian Astrophysical Observation", "SAO 136401"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.74327004),
        dec: Angle.Degrees(-03.55562398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67387",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120298"},
        {"Hipparcos Number", "HIP 67387"},
        {"Smithsonian Astrophysical Observation", "SAO 139565"},
    },
    visualMagnitude: 8.94,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.16595306),
        dec: Angle.Degrees(-03.55451934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111965",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214810"},
        {"Hipparcos Number", "HIP 111965"},
        {"Geneva Identification System", "GEN# +1.00214810"},
        {"Smithsonian Astrophysical Observation", "SAO 146239"},
    },
    visualMagnitude: 6.32,
    bvColour: 0.520,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.19983525),
        dec: Angle.Degrees(-03.55413415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189114"},
        {"Hipparcos Number", "HIP 98313"},
        {"Smithsonian Astrophysical Observation", "SAO 143959"},
    },
    visualMagnitude: 6.79,
    bvColour: 1.925,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.63556434),
        dec: Angle.Degrees(-03.55371767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111998"},
        {"Hipparcos Number", "HIP 62875"},
        {"Fundamental Katalog 5th Edition", "FK5 3025"},
        {"Geneva Identification System", "GEN# +1.00111998"},
        {"Smithsonian Astrophysical Observation", "SAO 139022"},
        {"Wilson Evans Batten Catalogue", "WEB 11147"},
    },
    visualMagnitude: 6.11,
    bvColour: 0.493,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.29712947),
        dec: Angle.Degrees(-03.55308979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -263.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222660"},
        {"Hipparcos Number", "HIP 116967"},
        {"Smithsonian Astrophysical Observation", "SAO 146854"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.65376069),
        dec: Angle.Degrees(-03.55263447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45831"},
        {"Hipparcos Number", "HIP 30938"},
        {"Geneva Identification System", "GEN# +1.00045831"},
        {"Smithsonian Astrophysical Observation", "SAO 133332"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.40364958),
        dec: Angle.Degrees(-03.55163567)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63099",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112283"},
        {"Hipparcos Number", "HIP 63099"},
        {"Geneva Identification System", "GEN# +1.00112283"},
        {"Smithsonian Astrophysical Observation", "SAO 139044"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.472,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.92078334),
        dec: Angle.Degrees(-03.55070403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122106"},
        {"Hipparcos Number", "HIP 68380"},
        {"Fundamental Katalog 5th Edition", "FK5 1362"},
        {"Geneva Identification System", "GEN# +1.00122106"},
        {"Smithsonian Astrophysical Observation", "SAO 139666"},
        {"Wilson Evans Batten Catalogue", "WEB 11991"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.95540345),
        dec: Angle.Degrees(-03.54965113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105563",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203539"},
        {"Hipparcos Number", "HIP 105563"},
        {"Smithsonian Astrophysical Observation", "SAO 145349"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.70591032),
        dec: Angle.Degrees(-03.54653890)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109531"},
        {"Hipparcos Number", "HIP 61441"},
        {"Smithsonian Astrophysical Observation", "SAO 138861"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.86512354),
        dec: Angle.Degrees(-03.54601149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64539"},
        {"Hipparcos Number", "HIP 38599"},
        {"Smithsonian Astrophysical Observation", "SAO 135233"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.55247987),
        dec: Angle.Degrees(-03.54520122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57133",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101784"},
        {"Hipparcos Number", "HIP 57133"},
        {"Smithsonian Astrophysical Observation", "SAO 138365"},
    },
    visualMagnitude: 7.55,
    bvColour: -0.013,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.70823380),
        dec: Angle.Degrees(-03.54502767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -86.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121032"},
        {"Hipparcos Number", "HIP 67785"},
        {"Smithsonian Astrophysical Observation", "SAO 139603"},
    },
    visualMagnitude: 7.60,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.30046915),
        dec: Angle.Degrees(-03.54210397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80599",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148333"},
        {"Hipparcos Number", "HIP 80599"},
        {"Smithsonian Astrophysical Observation", "SAO 141184"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.84995193),
        dec: Angle.Degrees(-03.54150056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60750",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8552 D"},
        {"Hipparcos Number", "HIP 60750"},
    },
    visualMagnitude: 10.42,
    bvColour: 0.917,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.75678115),
        dec: Angle.Degrees(-03.54041318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86475",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160454"},
        {"Hipparcos Number", "HIP 86475"},
        {"Geneva Identification System", "GEN# +1.00160454"},
        {"Smithsonian Astrophysical Observation", "SAO 141797"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.04111123),
        dec: Angle.Degrees(-03.53595144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21439",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21439"},
        {"Celescope Catalog", "CEL 441"},
        {"Geneva Identification System", "GEN# -0.00300832"},
        {"Smithsonian Astrophysical Observation", "SAO 131345"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.06348469),
        dec: Angle.Degrees(-03.53572787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21125"},
        {"Hipparcos Number", "HIP 15880"},
        {"Geneva Identification System", "GEN# +1.00021125"},
        {"Smithsonian Astrophysical Observation", "SAO 130468"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.13592375),
        dec: Angle.Degrees(-03.53508881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14473"},
        {"Hipparcos Number", "HIP 10885"},
        {"Geneva Identification System", "GEN# +1.00014473"},
        {"Smithsonian Astrophysical Observation", "SAO 129837"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.02062196),
        dec: Angle.Degrees(-03.53480106)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -87.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60749",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8552 AB"},
        {"Henry Draper", "HD 108361"},
        {"Hipparcos Number", "HIP 60749"},
        {"Smithsonian Astrophysical Observation", "SAO 138788"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.657,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.75294899),
        dec: Angle.Degrees(-03.53468950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 118.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -93.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50404",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89226"},
        {"Hipparcos Number", "HIP 50404"},
        {"Renson", "Renson 25600"},
        {"Smithsonian Astrophysical Observation", "SAO 137464"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.38221467),
        dec: Angle.Degrees(-03.53385854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119667"},
        {"Hipparcos Number", "HIP 67070"},
        {"Smithsonian Astrophysical Observation", "SAO 139526"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.18807510),
        dec: Angle.Degrees(-03.53335422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112720"},
        {"Hipparcos Number", "HIP 63348"},
        {"Smithsonian Astrophysical Observation", "SAO 139073"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.70887742),
        dec: Angle.Degrees(-03.53288624)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210121"},
        {"Hipparcos Number", "HIP 109265"},
        {"Smithsonian Astrophysical Observation", "SAO 145889"},
    },
    visualMagnitude: 7.68,
    bvColour: 0.164,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.04955367),
        dec: Angle.Degrees(-03.53132782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20385"},
        {"Hipparcos Number", "HIP 15247"},
        {"Geneva Identification System", "GEN# +1.00020385"},
        {"Smithsonian Astrophysical Observation", "SAO 130394"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.16926943),
        dec: Angle.Degrees(-03.53014978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 77.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63263"},
        {"Hipparcos Number", "HIP 38039"},
        {"Smithsonian Astrophysical Observation", "SAO 135109"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.94948062),
        dec: Angle.Degrees(-03.52964701)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26964"},
        {"Hipparcos Number", "HIP 19873"},
        {"Smithsonian Astrophysical Observation", "SAO 131070"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.188,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.93563793),
        dec: Angle.Degrees(-03.52849623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78792",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144271"},
        {"Hipparcos Number", "HIP 78792"},
        {"Geneva Identification System", "GEN# +1.00144271"},
        {"Smithsonian Astrophysical Observation", "SAO 140938"},
        {"Wilson Evans Batten Catalogue", "WEB 13320"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.176,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.28541970),
        dec: Angle.Degrees(-03.52763438)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113303",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216873"},
        {"Hipparcos Number", "HIP 113303"},
        {"Smithsonian Astrophysical Observation", "SAO 146398"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.498,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.18044194),
        dec: Angle.Degrees(-03.52693611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41448",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71432"},
        {"Hipparcos Number", "HIP 41448"},
        {"Smithsonian Astrophysical Observation", "SAO 135930"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.81535132),
        dec: Angle.Degrees(-03.52549467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119499"},
        {"Hipparcos Number", "HIP 66982"},
        {"Smithsonian Astrophysical Observation", "SAO 139510"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.91437084),
        dec: Angle.Degrees(-03.52488211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47840"},
        {"Hipparcos Number", "HIP 31942"},
        {"Smithsonian Astrophysical Observation", "SAO 133555"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.12502020),
        dec: Angle.Degrees(-03.52445004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9690"},
        {"Hipparcos Number", "HIP 7362"},
        {"Smithsonian Astrophysical Observation", "SAO 129387"},
    },
    visualMagnitude: 6.44,
    bvColour: 1.341,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.71379541),
        dec: Angle.Degrees(-03.52380859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71868",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71868"},
        {"Smithsonian Astrophysical Observation", "SAO 140081"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.49463899),
        dec: Angle.Degrees(-03.52358642)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22943",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22943"},
    },
    visualMagnitude: 10.29,
    bvColour: 1.261,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.05007113),
        dec: Angle.Degrees(-03.52321102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37532",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6302 B"},
        {"Hipparcos Number", "HIP 37532"},
        {"Smithsonian Astrophysical Observation", "SAO 134999"},
    },
    visualMagnitude: 8.65,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.54758496),
        dec: Angle.Degrees(-03.52276214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75089",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136405"},
        {"Hipparcos Number", "HIP 75089"},
        {"Smithsonian Astrophysical Observation", "SAO 140472"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.16208715),
        dec: Angle.Degrees(-03.51958700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37534",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6302 A"},
        {"Henry Draper", "HD 62125"},
        {"Hipparcos Number", "HIP 37534"},
        {"Smithsonian Astrophysical Observation", "SAO 135000"},
    },
    visualMagnitude: 8.01,
    bvColour: 1.280,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.55212302),
        dec: Angle.Degrees(-03.51952840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50985",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90239"},
        {"Hipparcos Number", "HIP 50985"},
        {"Smithsonian Astrophysical Observation", "SAO 137550"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.23274206),
        dec: Angle.Degrees(-03.51886830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90595"},
        {"Hipparcos Number", "HIP 51210"},
        {"Geneva Identification System", "GEN# +1.00090595"},
        {"Smithsonian Astrophysical Observation", "SAO 137578"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.89706480),
        dec: Angle.Degrees(-03.51861135)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72740",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131210"},
        {"Hipparcos Number", "HIP 72740"},
        {"Smithsonian Astrophysical Observation", "SAO 140192"},
    },
    visualMagnitude: 8.19,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.07212492),
        dec: Angle.Degrees(-03.51841170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -74.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49412",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87486"},
        {"Hipparcos Number", "HIP 49412"},
        {"Fundamental Katalog 5th Edition", "FK5 4898"},
        {"Smithsonian Astrophysical Observation", "SAO 137343"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.30138672),
        dec: Angle.Degrees(-03.51736578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152450"},
        {"Hipparcos Number", "HIP 82635"},
        {"Geneva Identification System", "GEN# +1.00152450"},
        {"Smithsonian Astrophysical Observation", "SAO 141420"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.38174593),
        dec: Angle.Degrees(-03.51718494)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45215"},
        {"Hipparcos Number", "HIP 30627"},
        {"Geneva Identification System", "GEN# +1.00045215"},
        {"Smithsonian Astrophysical Observation", "SAO 133248"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.54001992),
        dec: Angle.Degrees(-03.51584922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -92.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 65.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44720"},
        {"Hipparcos Number", "HIP 30356"},
        {"Celescope Catalog", "CEL 1209"},
        {"Geneva Identification System", "GEN# +1.00044720"},
        {"Smithsonian Astrophysical Observation", "SAO 133192"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.77547359),
        dec: Angle.Degrees(-03.51577085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106095",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204543"},
        {"Hipparcos Number", "HIP 106095"},
        {"Geneva Identification System", "GEN# +1.00204543"},
        {"Smithsonian Astrophysical Observation", "SAO 145433"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.888,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(322.36755756),
        dec: Angle.Degrees(-03.51526671)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82490"},
        {"Hipparcos Number", "HIP 46799"},
        {"Smithsonian Astrophysical Observation", "SAO 136935"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.830,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.04926722),
        dec: Angle.Degrees(-03.51497449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88032",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163950"},
        {"Hipparcos Number", "HIP 88032"},
        {"Smithsonian Astrophysical Observation", "SAO 142003"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.398,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.72128348),
        dec: Angle.Degrees(-03.51482638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50041"},
        {"Hipparcos Number", "HIP 32901"},
        {"Smithsonian Astrophysical Observation", "SAO 133773"},
    },
    visualMagnitude: 7.23,
    bvColour: -0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.82722392),
        dec: Angle.Degrees(-03.51376867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95695"},
        {"Hipparcos Number", "HIP 53984"},
        {"Fundamental Katalog 5th Edition", "FK5 1285"},
        {"Geneva Identification System", "GEN# +1.00095695"},
        {"Smithsonian Astrophysical Observation", "SAO 137952"},
    },
    visualMagnitude: 6.81,
    bvColour: 0.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.65335231),
        dec: Angle.Degrees(-03.51257918)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24922",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34859"},
        {"Hipparcos Number", "HIP 24922"},
        {"Renson", "Renson 8900"},
        {"Smithsonian Astrophysical Observation", "SAO 132000"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.147,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.10285382),
        dec: Angle.Degrees(-03.50985732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 117644"},
        {"Smithsonian Astrophysical Observation", "SAO 146937"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.88568401),
        dec: Angle.Degrees(-03.50847255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25285",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35427"},
        {"Hipparcos Number", "HIP 25285"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.250,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.13749188),
        dec: Angle.Degrees(-03.50814107)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99815",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13574 B"},
        {"Henry Draper", "HD 192461B"},
        {"Hipparcos Number", "HIP 99815"},
        {"Geneva Identification System", "GEN# +1.00192461B"},
        {"Smithsonian Astrophysical Observation", "SAO 144211"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.79120532),
        dec: Angle.Degrees(-03.50582502)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9732",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12784"},
        {"Hipparcos Number", "HIP 9732"},
        {"Smithsonian Astrophysical Observation", "SAO 129684"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.971,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.29748672),
        dec: Angle.Degrees(-03.50480583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86917",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10763 AB"},
        {"Henry Draper", "HD 161428"},
        {"Hipparcos Number", "HIP 86917"},
        {"Smithsonian Astrophysical Observation", "SAO 141855"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.39271341),
        dec: Angle.Degrees(-03.50449850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99816",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13574 A"},
        {"Henry Draper", "HD 192461"},
        {"Hipparcos Number", "HIP 99816"},
        {"Geneva Identification System", "GEN# +1.00192461A"},
        {"Smithsonian Astrophysical Observation", "SAO 144212"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.369,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.79439646),
        dec: Angle.Degrees(-03.50342856)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -62.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44303"},
        {"Hipparcos Number", "HIP 30181"},
        {"Geneva Identification System", "GEN# +1.00044303"},
        {"Smithsonian Astrophysical Observation", "SAO 133140"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.385,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.25349813),
        dec: Angle.Degrees(-03.50309353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15812",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21054"},
        {"Hipparcos Number", "HIP 15812"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.743,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.92136865),
        dec: Angle.Degrees(-03.49860422)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -132.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17459",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23364"},
        {"Hipparcos Number", "HIP 17459"},
        {"Smithsonian Astrophysical Observation", "SAO 130699"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.12871501),
        dec: Angle.Degrees(-03.49784084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21887"},
        {"Hipparcos Number", "HIP 16436"},
        {"Geneva Identification System", "GEN# +1.00021887"},
        {"Smithsonian Astrophysical Observation", "SAO 130544"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.007,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.91687560),
        dec: Angle.Degrees(-03.49770063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25623",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36003"},
        {"Hipparcos Number", "HIP 25623"},
        {"Cincinnati Publication", "Ci 20 330"},
        {"Geneva Identification System", "GEN# +1.00036003"},
        {"Smithsonian Astrophysical Observation", "SAO 132145"},
        {"Wilson Evans Batten Catalogue", "WEB 4971"},
    },
    visualMagnitude: 7.65,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.10948129),
        dec: Angle.Degrees(-03.49761780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -306.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -797.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114822",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219402"},
        {"Hipparcos Number", "HIP 114822"},
        {"Fundamental Katalog 5th Edition", "FK5 3860"},
        {"Geneva Identification System", "GEN# +1.00219402"},
        {"Smithsonian Astrophysical Observation", "SAO 146593"},
        {"Wilson Evans Batten Catalogue", "WEB 20352"},
    },
    visualMagnitude: 5.56,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.89277051),
        dec: Angle.Degrees(-03.49637244)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33023"},
        {"Hipparcos Number", "HIP 23819"},
        {"Geneva Identification System", "GEN# +1.00033023"},
        {"Smithsonian Astrophysical Observation", "SAO 131783"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.79946416),
        dec: Angle.Degrees(-03.49633415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39556",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66778"},
        {"Hipparcos Number", "HIP 39556"},
        {"Smithsonian Astrophysical Observation", "SAO 135465"},
    },
    visualMagnitude: 6.98,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.24436455),
        dec: Angle.Degrees(-03.49583881)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64512",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114866"},
        {"Hipparcos Number", "HIP 64512"},
        {"Geneva Identification System", "GEN# +1.00114866"},
        {"Smithsonian Astrophysical Observation", "SAO 139229"},
    },
    visualMagnitude: 7.34,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.33869138),
        dec: Angle.Degrees(-03.49455503)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217996"},
        {"Hipparcos Number", "HIP 113956"},
        {"Smithsonian Astrophysical Observation", "SAO 146493"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.16186389),
        dec: Angle.Degrees(-03.49449517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192791"},
        {"Hipparcos Number", "HIP 99956"},
        {"Smithsonian Astrophysical Observation", "SAO 144237"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.20943491),
        dec: Angle.Degrees(-03.49142892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -103.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108448",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15494 AB"},
        {"Henry Draper", "HD 208690"},
        {"Hipparcos Number", "HIP 108448"},
        {"Smithsonian Astrophysical Observation", "SAO 145777"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.331,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.53239956),
        dec: Angle.Degrees(-03.48988272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80176",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147412"},
        {"Hipparcos Number", "HIP 80176"},
        {"Smithsonian Astrophysical Observation", "SAO 141121"},
    },
    visualMagnitude: 9.38,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.49710277),
        dec: Angle.Degrees(-03.48830547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82842"},
        {"Hipparcos Number", "HIP 46983"},
        {"Geneva Identification System", "GEN# +1.00082842"},
        {"Smithsonian Astrophysical Observation", "SAO 136962"},
    },
    visualMagnitude: 7.14,
    bvColour: 0.799,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.63645791),
        dec: Angle.Degrees(-03.48802751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138989"},
        {"Hipparcos Number", "HIP 76356"},
        {"Smithsonian Astrophysical Observation", "SAO 140626"},
    },
    visualMagnitude: 8.88,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.92445483),
        dec: Angle.Degrees(-03.48752056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89236",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11154 AB"},
        {"Henry Draper", "HD 166847"},
        {"Hipparcos Number", "HIP 89236"},
        {"Smithsonian Astrophysical Observation", "SAO 142153"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.15080254),
        dec: Angle.Degrees(-03.48567853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23745",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32884"},
        {"Hipparcos Number", "HIP 23745"},
        {"Geneva Identification System", "GEN# +1.00032884"},
        {"Smithsonian Astrophysical Observation", "SAO 131766"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.55451814),
        dec: Angle.Degrees(-03.48491548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53621",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53621"},
        {"Smithsonian Astrophysical Observation", "SAO 137915"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.55132552),
        dec: Angle.Degrees(-03.48466609)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24567",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3856 AB"},
        {"Henry Draper", "HD 34280"},
        {"Hipparcos Number", "HIP 24567"},
        {"Celescope Catalog", "CEL 588"},
        {"Geneva Identification System", "GEN# +1.00034280J"},
        {"Smithsonian Astrophysical Observation", "SAO 131928"},
    },
    visualMagnitude: 7.76,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.06056359),
        dec: Angle.Degrees(-03.48311734)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27936",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39786"},
        {"Hipparcos Number", "HIP 27936"},
        {"Fundamental Katalog 5th Edition", "FK5 4539"},
        {"Smithsonian Astrophysical Observation", "SAO 132637"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.543,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.66996975),
        dec: Angle.Degrees(-03.48238066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49287",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87246"},
        {"Hipparcos Number", "HIP 49287"},
        {"Smithsonian Astrophysical Observation", "SAO 137325"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.043,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.91069995),
        dec: Angle.Degrees(-03.48073473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76784",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76784"},
        {"Smithsonian Astrophysical Observation", "SAO 140694"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.16045307),
        dec: Angle.Degrees(-03.47914534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49682",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87975"},
        {"Hipparcos Number", "HIP 49682"},
        {"Smithsonian Astrophysical Observation", "SAO 137372"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.097,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(152.13075540),
        dec: Angle.Degrees(-03.47784558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1900",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 326 AB"},
        {"Henry Draper", "HD 1978"},
        {"Hipparcos Number", "HIP 1900"},
        {"Smithsonian Astrophysical Observation", "SAO 128739"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.99923139),
        dec: Angle.Degrees(-03.47527939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112079",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214982"},
        {"Hipparcos Number", "HIP 112079"},
        {"Smithsonian Astrophysical Observation", "SAO 146252"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.52745588),
        dec: Angle.Degrees(-03.47339665)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146050"},
        {"Hipparcos Number", "HIP 79585"},
        {"Smithsonian Astrophysical Observation", "SAO 141050"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.770,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.56694029),
        dec: Angle.Degrees(-03.47337124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -92.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97991"},
        {"Hipparcos Number", "HIP 55051"},
        {"Geneva Identification System", "GEN# +1.00097991"},
        {"Smithsonian Astrophysical Observation", "SAO 138096"},
        {"Wilson Evans Batten Catalogue", "WEB 9930"},
    },
    visualMagnitude: 7.40,
    bvColour: -0.210,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.04872846),
        dec: Angle.Degrees(-03.47202113)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209359"},
        {"Hipparcos Number", "HIP 108835"},
        {"Smithsonian Astrophysical Observation", "SAO 145832"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.71850537),
        dec: Angle.Degrees(-03.47192481)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53765",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8007 AB"},
        {"Henry Draper", "HD 95280"},
        {"Hipparcos Number", "HIP 53765"},
        {"Smithsonian Astrophysical Observation", "SAO 137933"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.00840105),
        dec: Angle.Degrees(-03.47141563)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 39.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2312",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2593"},
        {"Hipparcos Number", "HIP 2312"},
        {"Smithsonian Astrophysical Observation", "SAO 128784"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.37223007),
        dec: Angle.Degrees(-03.46928805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68755",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122851"},
        {"Hipparcos Number", "HIP 68755"},
    },
    visualMagnitude: 10.36,
    bvColour: 0.892,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.09670769),
        dec: Angle.Degrees(-03.46720615)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -182.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39139",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39139"},
        {"Smithsonian Astrophysical Observation", "SAO 135357"},
    },
    visualMagnitude: 9.09,
    bvColour: 1.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.08849013),
        dec: Angle.Degrees(-03.46690404)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145206"},
        {"Hipparcos Number", "HIP 79195"},
        {"Geneva Identification System", "GEN# +1.00145206"},
        {"Smithsonian Astrophysical Observation", "SAO 141001"},
        {"Wilson Evans Batten Catalogue", "WEB 13389"},
    },
    visualMagnitude: 5.39,
    bvColour: 1.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.46055144),
        dec: Angle.Degrees(-03.46673076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76111",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 76111"},
        {"Smithsonian Astrophysical Observation", "SAO 140594"},
    },
    visualMagnitude: 9.74,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.17380274),
        dec: Angle.Degrees(-03.46407663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26070",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36710"},
        {"Hipparcos Number", "HIP 26070"},
        {"Smithsonian Astrophysical Observation", "SAO 132259"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.40717364),
        dec: Angle.Degrees(-03.46315553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89707",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 89707"},
        {"Smithsonian Astrophysical Observation", "SAO 142211"},
    },
    visualMagnitude: 10.03,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(274.62576647),
        dec: Angle.Degrees(-03.46230682)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163102"},
        {"Hipparcos Number", "HIP 87678"},
        {"Geneva Identification System", "GEN# +1.00163102"},
        {"Smithsonian Astrophysical Observation", "SAO 141954"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.62425104),
        dec: Angle.Degrees(-03.46210471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -144.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29813",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 294822"},
        {"Hipparcos Number", "HIP 29813"},
        {"Smithsonian Astrophysical Observation", "SAO 133054"},
    },
    visualMagnitude: 8.63,
    bvColour: -0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.17879010),
        dec: Angle.Degrees(-03.46013063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94433",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12167 A"},
        {"Henry Draper", "HD 179567"},
        {"Hipparcos Number", "HIP 94433"},
        {"Smithsonian Astrophysical Observation", "SAO 143149"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.30629700),
        dec: Angle.Degrees(-03.45745561)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69651",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124715"},
        {"Hipparcos Number", "HIP 69651"},
        {"Geneva Identification System", "GEN# +1.00124715"},
        {"Smithsonian Astrophysical Observation", "SAO 139816"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.566,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.82262349),
        dec: Angle.Degrees(-03.45045729)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 103.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -127.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36134"},
        {"Hipparcos Number", "HIP 25708"},
        {"Geneva Identification System", "GEN# +1.00036134"},
        {"Smithsonian Astrophysical Observation", "SAO 132170"},
        {"Wilson Evans Batten Catalogue", "WEB 4990"},
    },
    visualMagnitude: 5.80,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.34875680),
        dec: Angle.Degrees(-03.44637074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42320",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42320"},
        {"Smithsonian Astrophysical Observation", "SAO 136107"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.42016896),
        dec: Angle.Degrees(-03.44341920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75333"},
        {"Hipparcos Number", "HIP 43305"},
        {"Fundamental Katalog 5th Edition", "FK5 1230"},
        {"Geneva Identification System", "GEN# +1.00075333"},
        {"Renson", "Renson 21100"},
        {"Smithsonian Astrophysical Observation", "SAO 136308"},
        {"Wilson Evans Batten Catalogue", "WEB 8344"},
    },
    visualMagnitude: 5.30,
    bvColour: -0.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.34057358),
        dec: Angle.Degrees(-03.44297063)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101299",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13955 AB"},
        {"Henry Draper", "HD 195511"},
        {"Hipparcos Number", "HIP 101299"},
        {"Smithsonian Astrophysical Observation", "SAO 144533"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.98140719),
        dec: Angle.Degrees(-03.44170754)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200065"},
        {"Hipparcos Number", "HIP 103729"},
        {"Smithsonian Astrophysical Observation", "SAO 145030"},
    },
    visualMagnitude: 7.90,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.28591653),
        dec: Angle.Degrees(-03.44127557)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41446",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41446"},
        {"Smithsonian Astrophysical Observation", "SAO 135929"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.80746064),
        dec: Angle.Degrees(-03.44116338)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7597",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10024"},
        {"Hipparcos Number", "HIP 7597"},
        {"Smithsonian Astrophysical Observation", "SAO 129415"},
    },
    visualMagnitude: 6.43,
    bvColour: 1.568,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.46688941),
        dec: Angle.Degrees(-03.44065222)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43989"},
        {"Hipparcos Number", "HIP 30030"},
        {"Smithsonian Astrophysical Observation", "SAO 133095"},
    },
    visualMagnitude: 7.95,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.78354667),
        dec: Angle.Degrees(-03.43888711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95483",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 95483"},
        {"Smithsonian Astrophysical Observation", "SAO 143379"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.33265073),
        dec: Angle.Degrees(-03.43810046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15390"},
        {"Hipparcos Number", "HIP 11521"},
        {"Smithsonian Astrophysical Observation", "SAO 129927"},
    },
    visualMagnitude: 8.62,
    bvColour: 1.128,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.14140242),
        dec: Angle.Degrees(-03.43712717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6360",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8234"},
        {"Hipparcos Number", "HIP 6360"},
        {"Smithsonian Astrophysical Observation", "SAO 129251"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.42422001),
        dec: Angle.Degrees(-03.43684243)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74871",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74871"},
        {"Smithsonian Astrophysical Observation", "SAO 140439"},
    },
    visualMagnitude: 9.61,
    bvColour: 1.283,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.51289243),
        dec: Angle.Degrees(-03.43617320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159188"},
        {"Hipparcos Number", "HIP 85917"},
        {"Smithsonian Astrophysical Observation", "SAO 141729"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.284,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.36146265),
        dec: Angle.Degrees(-03.43602628)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77516",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141513"},
        {"Hipparcos Number", "HIP 77516"},
        {"Fundamental Katalog 5th Edition", "FK5 585"},
        {"Geneva Identification System", "GEN# +1.00141513"},
        {"Smithsonian Astrophysical Observation", "SAO 140787"},
        {"Wilson Evans Batten Catalogue", "WEB 13122"},
    },
    visualMagnitude: 3.54,
    bvColour: -0.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.40527375),
        dec: Angle.Degrees(-03.43014112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37687"},
        {"Hipparcos Number", "HIP 26693"},
        {"Celescope Catalog", "CEL 914"},
        {"Geneva Identification System", "GEN# +1.00037687"},
        {"Renson", "Renson 10160"},
        {"Smithsonian Astrophysical Observation", "SAO 132439"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.019,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.08219397),
        dec: Angle.Degrees(-03.42706631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45047",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78889"},
        {"Hipparcos Number", "HIP 45047"},
        {"Renson", "Renson 22340"},
        {"Smithsonian Astrophysical Observation", "SAO 136639"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.286,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.63334376),
        dec: Angle.Degrees(-03.42658192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194340"},
        {"Hipparcos Number", "HIP 100720"},
        {"Smithsonian Astrophysical Observation", "SAO 144405"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.29589852),
        dec: Angle.Degrees(-03.42527931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10507"},
        {"Hipparcos Number", "HIP 7967"},
        {"Smithsonian Astrophysical Observation", "SAO 129459"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.559,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.58663370),
        dec: Angle.Degrees(-03.42457925)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29359",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42563"},
        {"Hipparcos Number", "HIP 29359"},
        {"Celescope Catalog", "CEL 1111"},
        {"Geneva Identification System", "GEN# +1.00042563"},
        {"Smithsonian Astrophysical Observation", "SAO 132931"},
    },
    visualMagnitude: 8.89,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.82526081),
        dec: Angle.Degrees(-03.41778783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24314"},
        {"Hipparcos Number", "HIP 18098"},
        {"Smithsonian Astrophysical Observation", "SAO 130781"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.02708300),
        dec: Angle.Degrees(-03.41666445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16699",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22240"},
        {"Hipparcos Number", "HIP 16699"},
        {"Geneva Identification System", "GEN# +1.00022240"},
        {"Smithsonian Astrophysical Observation", "SAO 130587"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.205,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.72461378),
        dec: Angle.Degrees(-03.41192393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205260"},
        {"Hipparcos Number", "HIP 106495"},
        {"Smithsonian Astrophysical Observation", "SAO 145496"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.171,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.56286824),
        dec: Angle.Degrees(-03.41053297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89300",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166993"},
        {"Hipparcos Number", "HIP 89300"},
        {"Smithsonian Astrophysical Observation", "SAO 142162"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.562,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.32743249),
        dec: Angle.Degrees(-03.40679981)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67404"},
        {"Hipparcos Number", "HIP 39769"},
        {"Geneva Identification System", "GEN# +1.00067404"},
        {"Smithsonian Astrophysical Observation", "SAO 135530"},
        {"Wilson Evans Batten Catalogue", "WEB 7760"},
    },
    visualMagnitude: 6.86,
    bvColour: 1.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.92222573),
        dec: Angle.Degrees(-03.40668776)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10524",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10524"},
        {"Smithsonian Astrophysical Observation", "SAO 129782"},
    },
    visualMagnitude: 9.55,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.90748063),
        dec: Angle.Degrees(-03.40413497)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223653"},
        {"Hipparcos Number", "HIP 117641"},
        {"Smithsonian Astrophysical Observation", "SAO 146936"},
    },
    visualMagnitude: 7.91,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.87034316),
        dec: Angle.Degrees(-03.40385007)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 295354"},
        {"Hipparcos Number", "HIP 32214"},
        {"Renson", "Renson 12970"},
    },
    visualMagnitude: 9.47,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.88433640),
        dec: Angle.Degrees(-03.40265158)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56367",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56367"},
    },
    visualMagnitude: 11.29,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.32022080),
        dec: Angle.Degrees(-03.40200840)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -120.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197142"},
        {"Hipparcos Number", "HIP 102135"},
        {"Geneva Identification System", "GEN# +1.00197142"},
        {"Smithsonian Astrophysical Observation", "SAO 144713"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.573,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.45164540),
        dec: Angle.Degrees(-03.40188248)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2917",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3413"},
        {"Hipparcos Number", "HIP 2917"},
        {"Fundamental Katalog 5th Edition", "FK5 4054"},
        {"Smithsonian Astrophysical Observation", "SAO 128859"},
    },
    visualMagnitude: 7.88,
    bvColour: 1.228,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.23661274),
        dec: Angle.Degrees(-03.40064751)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105729",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203843"},
        {"Hipparcos Number", "HIP 105729"},
        {"Geneva Identification System", "GEN# +1.00203843"},
        {"Renson", "Renson 56760"},
        {"Smithsonian Astrophysical Observation", "SAO 145376"},
        {"Wilson Evans Batten Catalogue", "WEB 19188"},
    },
    visualMagnitude: 6.38,
    bvColour: 0.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.21532853),
        dec: Angle.Degrees(-03.39823510)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16400"},
        {"Hipparcos Number", "HIP 12247"},
        {"Fundamental Katalog 5th Edition", "FK5 2180"},
        {"Geneva Identification System", "GEN# +1.00016400"},
        {"Smithsonian Astrophysical Observation", "SAO 130026"},
        {"Wilson Evans Batten Catalogue", "WEB 2513"},
    },
    visualMagnitude: 5.65,
    bvColour: 1.021,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.42407297),
        dec: Angle.Degrees(-03.39606767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100900",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194767"},
        {"Hipparcos Number", "HIP 100900"},
        {"Smithsonian Astrophysical Observation", "SAO 144451"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.87487756),
        dec: Angle.Degrees(-03.39541802)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58769",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104677"},
        {"Hipparcos Number", "HIP 58769"},
        {"Smithsonian Astrophysical Observation", "SAO 138553"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.80517114),
        dec: Angle.Degrees(-03.39525168)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17086",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22798"},
        {"Hipparcos Number", "HIP 17086"},
        {"Geneva Identification System", "GEN# +1.00022798"},
        {"Smithsonian Astrophysical Observation", "SAO 130639"},
    },
    visualMagnitude: 6.22,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.90980877),
        dec: Angle.Degrees(-03.39284230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64221",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114302"},
        {"Hipparcos Number", "HIP 64221"},
        {"Smithsonian Astrophysical Observation", "SAO 139186"},
    },
    visualMagnitude: 8.42,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.42811377),
        dec: Angle.Degrees(-03.38935046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -67.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112669",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215959"},
        {"Hipparcos Number", "HIP 112669"},
        {"Smithsonian Astrophysical Observation", "SAO 146332"},
    },
    visualMagnitude: 8.58,
    bvColour: 0.528,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.25335116),
        dec: Angle.Degrees(-03.38758770)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80133"},
        {"Hipparcos Number", "HIP 45621"},
        {"Smithsonian Astrophysical Observation", "SAO 136740"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.869,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.48070610),
        dec: Angle.Degrees(-03.38709035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82425"},
        {"Hipparcos Number", "HIP 46756"},
        {"Smithsonian Astrophysical Observation", "SAO 136929"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.177,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.94504562),
        dec: Angle.Degrees(-03.38430172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
