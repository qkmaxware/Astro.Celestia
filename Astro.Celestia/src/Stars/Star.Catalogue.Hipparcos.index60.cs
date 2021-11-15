using System;
using System.Linq;
using System.Collections.Generic;
using Qkmaxware.Astro.Coordinates;
using Qkmaxware.Measurement;

namespace Qkmaxware.Astro.Celestia {
    
public static partial class StarCatalogue {
private static void _addHipparcos_60() {
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99631",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192107"},
        {"Hipparcos Number", "HIP 99631"},
        {"Geneva Identification System", "GEN# +1.00192107"},
        {"Smithsonian Astrophysical Observation", "SAO 144181"},
        {"Wilson Evans Batten Catalogue", "WEB 17854"},
    },
    visualMagnitude: 5.44,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.30778095),
        dec: Angle.Degrees(-01.00926621)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94854",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180818"},
        {"Hipparcos Number", "HIP 94854"},
        {"Smithsonian Astrophysical Observation", "SAO 143238"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.51050038),
        dec: Angle.Degrees(-01.00889571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39547",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66734"},
        {"Hipparcos Number", "HIP 39547"},
        {"Smithsonian Astrophysical Observation", "SAO 135460"},
    },
    visualMagnitude: 9.01,
    bvColour: 0.189,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.21914539),
        dec: Angle.Degrees(-01.00746117)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109560",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210609"},
        {"Hipparcos Number", "HIP 109560"},
        {"Smithsonian Astrophysical Observation", "SAO 145928"},
    },
    visualMagnitude: 9.20,
    bvColour: 1.681,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.90113771),
        dec: Angle.Degrees(-01.00506143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14680",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19629"},
        {"Hipparcos Number", "HIP 14680"},
        {"Smithsonian Astrophysical Observation", "SAO 130310"},
    },
    visualMagnitude: 8.94,
    bvColour: 1.424,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.41165599),
        dec: Angle.Degrees(-01.00379260)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170920"},
        {"Hipparcos Number", "HIP 90844"},
        {"Geneva Identification System", "GEN# +1.00170920"},
        {"Renson", "Renson 47860"},
        {"Smithsonian Astrophysical Observation", "SAO 142372"},
        {"Wilson Evans Batten Catalogue", "WEB 15573"},
    },
    visualMagnitude: 5.93,
    bvColour: 0.170,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.98745241),
        dec: Angle.Degrees(-01.00296614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25199",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35271"},
        {"Hipparcos Number", "HIP 25199"},
        {"Geneva Identification System", "GEN# +1.00035271"},
        {"Smithsonian Astrophysical Observation", "SAO 132054"},
    },
    visualMagnitude: 7.86,
    bvColour: -0.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.86727958),
        dec: Angle.Degrees(-01.00244093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94706"},
        {"Hipparcos Number", "HIP 53441"},
        {"Geneva Identification System", "GEN# +1.00094706"},
        {"Smithsonian Astrophysical Observation", "SAO 137892"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.98909694),
        dec: Angle.Degrees(-01.00227696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85368",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157984"},
        {"Hipparcos Number", "HIP 85368"},
        {"Geneva Identification System", "GEN# +1.00157984"},
        {"Smithsonian Astrophysical Observation", "SAO 141667"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.359,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.66645852),
        dec: Angle.Degrees(-01.00163409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77458",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141377"},
        {"Hipparcos Number", "HIP 77458"},
        {"Geneva Identification System", "GEN# +1.00141377"},
        {"Smithsonian Astrophysical Observation", "SAO 140773"},
    },
    visualMagnitude: 6.81,
    bvColour: 1.592,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(237.22017169),
        dec: Angle.Degrees(-01.00127321)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149163"},
        {"Hipparcos Number", "HIP 81040"},
        {"Smithsonian Astrophysical Observation", "SAO 141232"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.680,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.27263240),
        dec: Angle.Degrees(-01.00085620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -88.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150451"},
        {"Hipparcos Number", "HIP 81687"},
        {"Geneva Identification System", "GEN# +1.00150451"},
        {"Renson", "Renson 42550"},
        {"Smithsonian Astrophysical Observation", "SAO 141310"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.313,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.29805122),
        dec: Angle.Degrees(-01.00028370)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27994",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290956"},
        {"Hipparcos Number", "HIP 27994"},
    },
    visualMagnitude: 10.27,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.81027376),
        dec: Angle.Degrees(-00.99872300)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44675",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44675"},
    },
    visualMagnitude: 10.97,
    bvColour: 1.346,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.56984619),
        dec: Angle.Degrees(-00.99742825)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19816",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26886"},
        {"Hipparcos Number", "HIP 19816"},
        {"Geneva Identification System", "GEN# +1.00026886"},
        {"Smithsonian Astrophysical Observation", "SAO 131053"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.933,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.74512886),
        dec: Angle.Degrees(-00.99739040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40347"},
        {"Hipparcos Number", "HIP 28252"},
        {"Geneva Identification System", "GEN# +1.00040347"},
        {"Smithsonian Astrophysical Observation", "SAO 132700"},
    },
    visualMagnitude: 6.21,
    bvColour: 1.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.54876554),
        dec: Angle.Degrees(-00.99396796)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25339"},
        {"Hipparcos Number", "HIP 18791"},
        {"Geneva Identification System", "GEN# +1.00025339"},
        {"Smithsonian Astrophysical Observation", "SAO 130879"},
    },
    visualMagnitude: 9.54,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.39389031),
        dec: Angle.Degrees(-00.99370477)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104338",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201222"},
        {"Hipparcos Number", "HIP 104338"},
        {"Geneva Identification System", "GEN# +1.00201222"},
        {"Smithsonian Astrophysical Observation", "SAO 145132"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.03903565),
        dec: Angle.Degrees(-00.98968533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90473"},
        {"Hipparcos Number", "HIP 51117"},
        {"Geneva Identification System", "GEN# +1.00090473"},
        {"Smithsonian Astrophysical Observation", "SAO 137565"},
        {"Wilson Evans Batten Catalogue", "WEB 9344"},
    },
    visualMagnitude: 6.33,
    bvColour: 1.443,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.65392802),
        dec: Angle.Degrees(-00.98807769)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188804"},
        {"Hipparcos Number", "HIP 98171"},
        {"Smithsonian Astrophysical Observation", "SAO 143938"},
    },
    visualMagnitude: 7.76,
    bvColour: 1.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(299.25570078),
        dec: Angle.Degrees(-00.98711647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68794",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122950"},
        {"Hipparcos Number", "HIP 68794"},
        {"Smithsonian Astrophysical Observation", "SAO 139722"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.22975329),
        dec: Angle.Degrees(-00.98679782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203979"},
        {"Hipparcos Number", "HIP 105797"},
        {"Smithsonian Astrophysical Observation", "SAO 145389"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.38945682),
        dec: Angle.Degrees(-00.98520749)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 135894"},
        {"Hipparcos Number", "HIP 74841"},
        {"Geneva Identification System", "GEN# +1.00135894"},
        {"Smithsonian Astrophysical Observation", "SAO 140437"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.943,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.41852179),
        dec: Angle.Degrees(-00.98490757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84122",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155467"},
        {"Hipparcos Number", "HIP 84122"},
        {"Geneva Identification System", "GEN# +1.00155467"},
        {"Smithsonian Astrophysical Observation", "SAO 141553"},
        {"Wilson Evans Batten Catalogue", "WEB 14206"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.96565443),
        dec: Angle.Degrees(-00.98421488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 81.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174162"},
        {"Hipparcos Number", "HIP 92349"},
        {"Geneva Identification System", "GEN# +1.00174162"},
        {"Smithsonian Astrophysical Observation", "SAO 142655"},
    },
    visualMagnitude: 7.75,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.31438495),
        dec: Angle.Degrees(-00.98144907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106603",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106603"},
    },
    visualMagnitude: 10.24,
    bvColour: 1.223,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.85748322),
        dec: Angle.Degrees(-00.98127383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74106",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9514 AB"},
        {"Henry Draper", "HD 134212"},
        {"Hipparcos Number", "HIP 74106"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.17903315),
        dec: Angle.Degrees(-00.98067889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178804"},
        {"Hipparcos Number", "HIP 94164"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.264,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.52141916),
        dec: Angle.Degrees(-00.97700676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7476"},
        {"Hipparcos Number", "HIP 5833"},
        {"Fundamental Katalog 5th Edition", "FK5 2084"},
        {"Geneva Identification System", "GEN# +1.00007476"},
        {"Smithsonian Astrophysical Observation", "SAO 129196"},
        {"Wilson Evans Batten Catalogue", "WEB 1330"},
    },
    visualMagnitude: 5.70,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(018.70491873),
        dec: Angle.Degrees(-00.97429411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 205.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54942",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97779"},
        {"Hipparcos Number", "HIP 54942"},
        {"Smithsonian Astrophysical Observation", "SAO 138084"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.76757113),
        dec: Angle.Degrees(-00.97301048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29071"},
        {"Hipparcos Number", "HIP 21326"},
        {"Smithsonian Astrophysical Observation", "SAO 131323"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.482,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.66055874),
        dec: Angle.Degrees(-00.97234914)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6593",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8578"},
        {"Hipparcos Number", "HIP 6593"},
        {"Geneva Identification System", "GEN# +1.00008578"},
        {"Smithsonian Astrophysical Observation", "SAO 129278"},
    },
    visualMagnitude: 7.56,
    bvColour: 0.319,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.17147070),
        dec: Angle.Degrees(-00.97022643)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9733",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1645 AB"},
        {"Henry Draper", "HD 12774"},
        {"Hipparcos Number", "HIP 9733"},
        {"Smithsonian Astrophysical Observation", "SAO 129686"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.304,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.30633198),
        dec: Angle.Degrees(-00.96890425)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20477",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27809"},
        {"Hipparcos Number", "HIP 20477"},
        {"Geneva Identification System", "GEN# +1.00027809"},
        {"Smithsonian Astrophysical Observation", "SAO 131167"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.83215413),
        dec: Angle.Degrees(-00.96889156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46598",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 46598"},
    },
    visualMagnitude: 11.52,
    bvColour: 1.334,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.53643085),
        dec: Angle.Degrees(-00.96677019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -258.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 184.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92118",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11667 B"},
        {"Henry Draper", "HD 173654B"},
        {"Hipparcos Number", "HIP 92118"},
        {"Geneva Identification System", "GEN# +1.00173654B"},
        {"Renson", "Renson 48680"},
        {"Smithsonian Astrophysical Observation", "SAO 142607"},
        {"Wilson Evans Batten Catalogue", "WEB 15879"},
    },
    visualMagnitude: 7.51,
    bvColour: 0.308,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.62212771),
        dec: Angle.Degrees(-00.96344934)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200987"},
        {"Hipparcos Number", "HIP 104219"},
        {"Geneva Identification System", "GEN# +1.00200987"},
        {"Smithsonian Astrophysical Observation", "SAO 145109"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.387,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.71810547),
        dec: Angle.Degrees(-00.96335427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28933",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4690 AB"},
        {"Henry Draper", "HD 41661"},
        {"Hipparcos Number", "HIP 28933"},
        {"Smithsonian Astrophysical Observation", "SAO 132838"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.60180287),
        dec: Angle.Degrees(-00.96334465)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90594"},
        {"Hipparcos Number", "HIP 51211"},
        {"Geneva Identification System", "GEN# +1.00090594"},
        {"Smithsonian Astrophysical Observation", "SAO 137577"},
    },
    visualMagnitude: 7.50,
    bvColour: 1.086,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.89801108),
        dec: Angle.Degrees(-00.96291593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92117",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11667 A"},
        {"Henry Draper", "HD 173654A"},
        {"Hipparcos Number", "HIP 92117"},
        {"Geneva Identification System", "GEN# +1.00173654A"},
        {"Renson", "Renson 48670"},
        {"Smithsonian Astrophysical Observation", "SAO 142606"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.61909463),
        dec: Angle.Degrees(-00.96163956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41645",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71830"},
        {"Hipparcos Number", "HIP 41645"},
        {"Geneva Identification System", "GEN# +1.00071830"},
        {"Smithsonian Astrophysical Observation", "SAO 135971"},
    },
    visualMagnitude: 6.70,
    bvColour: 1.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.37719853),
        dec: Angle.Degrees(-00.96002893)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10671"},
        {"Smithsonian Astrophysical Observation", "SAO 129799"},
    },
    visualMagnitude: 9.01,
    bvColour: 1.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.32998165),
        dec: Angle.Degrees(-00.95866312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35913"},
        {"Hipparcos Number", "HIP 25574"},
        {"Geneva Identification System", "GEN# +1.00035913"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.98961619),
        dec: Angle.Degrees(-00.95850025)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121217"},
        {"Hipparcos Number", "HIP 67873"},
        {"Smithsonian Astrophysical Observation", "SAO 139608"},
    },
    visualMagnitude: 8.66,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(208.52736660),
        dec: Angle.Degrees(-00.95648183)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8377",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1427 AB"},
        {"Henry Draper", "HD 10997"},
        {"Hipparcos Number", "HIP 8377"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.98729132),
        dec: Angle.Degrees(-00.95643907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 28.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31138",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46204"},
        {"Hipparcos Number", "HIP 31138"},
        {"Smithsonian Astrophysical Observation", "SAO 133370"},
    },
    visualMagnitude: 9.23,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.99387369),
        dec: Angle.Degrees(-00.95541814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63155",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8708 AB"},
        {"Henry Draper", "HD 112398"},
        {"Hipparcos Number", "HIP 63155"},
        {"Smithsonian Astrophysical Observation", "SAO 139053"},
    },
    visualMagnitude: 6.62,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.11061466),
        dec: Angle.Degrees(-00.95438010)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 30383"},
    },
    visualMagnitude: 11.43,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.83245142),
        dec: Angle.Degrees(-00.95432429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36882"},
        {"Hipparcos Number", "HIP 26174"},
        {"Geneva Identification System", "GEN# +1.00036882"},
        {"Smithsonian Astrophysical Observation", "SAO 132286"},
    },
    visualMagnitude: 6.98,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.70082309),
        dec: Angle.Degrees(-00.95372710)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215312"},
        {"Hipparcos Number", "HIP 112255"},
        {"Smithsonian Astrophysical Observation", "SAO 146282"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.285,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.04969255),
        dec: Angle.Degrees(-00.95348906)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44740"},
        {"Hipparcos Number", "HIP 30384"},
        {"Smithsonian Astrophysical Observation", "SAO 133197"},
    },
    visualMagnitude: 8.31,
    bvColour: 1.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.83495441),
        dec: Angle.Degrees(-00.95226348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11440",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11440"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.87709047),
        dec: Angle.Degrees(-00.95110626)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41884",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41884"},
    },
    visualMagnitude: 10.19,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)08, (int)32, 24.8600),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)57, 03.300)
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
    primaryId: "HIP 79717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146393"},
        {"Hipparcos Number", "HIP 79717"},
    },
    visualMagnitude: 9.82,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(244.04617801),
        dec: Angle.Degrees(-00.95001077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 73.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73315",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73315"},
        {"Geneva Identification System", "GEN# -0.00002911"},
        {"Smithsonian Astrophysical Observation", "SAO 140257"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.282,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73305027),
        dec: Angle.Degrees(-00.94804196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115463",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220384"},
        {"Hipparcos Number", "HIP 115463"},
        {"Smithsonian Astrophysical Observation", "SAO 146679"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.979,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.84458071),
        dec: Angle.Degrees(-00.94682486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19945"},
        {"Hipparcos Number", "HIP 14894"},
        {"Geneva Identification System", "GEN# +1.00019945"},
        {"Smithsonian Astrophysical Observation", "SAO 130346"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.06091575),
        dec: Angle.Degrees(-00.94588874)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45067"},
        {"Hipparcos Number", "HIP 30545"},
        {"Geneva Identification System", "GEN# +1.00045067"},
        {"Smithsonian Astrophysical Observation", "SAO 133229"},
        {"Wilson Evans Batten Catalogue", "WEB 6091"},
    },
    visualMagnitude: 5.88,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.31836214),
        dec: Angle.Degrees(-00.94535265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 238.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94846",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12281 A"},
        {"Henry Draper", "HD 180783"},
        {"Hipparcos Number", "HIP 94846"},
        {"Geneva Identification System", "GEN# +1.00180783"},
        {"Smithsonian Astrophysical Observation", "SAO 143235"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.290,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.48836964),
        dec: Angle.Degrees(-00.94351229)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 88653"},
        {"Hipparcos Number", "HIP 50074"},
        {"Smithsonian Astrophysical Observation", "SAO 137418"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.35306741),
        dec: Angle.Degrees(-00.94067599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27007",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38165"},
        {"Hipparcos Number", "HIP 27007"},
        {"Geneva Identification System", "GEN# +1.00038165"},
        {"Smithsonian Astrophysical Observation", "SAO 132488"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.93243347),
        dec: Angle.Degrees(-00.93866093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101755"},
        {"Hipparcos Number", "HIP 57119"},
        {"Smithsonian Astrophysical Observation", "SAO 138362"},
    },
    visualMagnitude: 9.18,
    bvColour: 1.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.65397963),
        dec: Angle.Degrees(-00.93824901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72362"},
        {"Hipparcos Number", "HIP 41880"},
        {"Smithsonian Astrophysical Observation", "SAO 136014"},
    },
    visualMagnitude: 9.11,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.09331109),
        dec: Angle.Degrees(-00.93819958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 81.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5225",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6603"},
        {"Hipparcos Number", "HIP 5225"},
        {"Smithsonian Astrophysical Observation", "SAO 129124"},
    },
    visualMagnitude: 8.83,
    bvColour: 1.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.69833542),
        dec: Angle.Degrees(-00.93763087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18617",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25068"},
        {"Hipparcos Number", "HIP 18617"},
        {"Geneva Identification System", "GEN# +1.00025068"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.581,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.75034607),
        dec: Angle.Degrees(-00.93663851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60402",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107765"},
        {"Hipparcos Number", "HIP 60402"},
        {"Smithsonian Astrophysical Observation", "SAO 138746"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.76970059),
        dec: Angle.Degrees(-00.93602788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112392",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215524"},
        {"Hipparcos Number", "HIP 112392"},
        {"Smithsonian Astrophysical Observation", "SAO 146300"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.265,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.45706248),
        dec: Angle.Degrees(-00.93288427)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224265"},
        {"Hipparcos Number", "HIP 118028"},
        {"Smithsonian Astrophysical Observation", "SAO 146988"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.287,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.11567910),
        dec: Angle.Degrees(-00.93229428)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66367",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118330"},
        {"Hipparcos Number", "HIP 66367"},
        {"Geneva Identification System", "GEN# +1.00118330"},
        {"Smithsonian Astrophysical Observation", "SAO 139437"},
        {"Wilson Evans Batten Catalogue", "WEB 11720"},
    },
    visualMagnitude: 7.05,
    bvColour: 0.531,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.06157456),
        dec: Angle.Degrees(-00.93085852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -221.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15383",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2459 AB"},
        {"Aitken 2", "ADS 2459"},
        {"Henry Draper", "HD 20559"},
        {"Hipparcos Number", "HIP 15383"},
        {"Geneva Identification System", "GEN# +1.00020559"},
        {"Smithsonian Astrophysical Observation", "SAO 130408"},
        {"Wilson Evans Batten Catalogue", "WEB 2958"},
    },
    visualMagnitude: 5.62,
    bvColour: 1.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.59282830),
        dec: Angle.Degrees(-00.93014105)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 251.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -60.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139840"},
        {"Hipparcos Number", "HIP 76763"},
        {"Geneva Identification System", "GEN# +1.00139840"},
        {"Smithsonian Astrophysical Observation", "SAO 140690"},
        {"Wilson Evans Batten Catalogue", "WEB 13026"},
    },
    visualMagnitude: 8.07,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.10647562),
        dec: Angle.Degrees(-00.91236485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21894",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29870"},
        {"Hipparcos Number", "HIP 21894"},
        {"Geneva Identification System", "GEN# +1.00029870"},
        {"Renson", "Renson 7658"},
        {"Smithsonian Astrophysical Observation", "SAO 131419"},
    },
    visualMagnitude: 6.73,
    bvColour: 0.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.59409545),
        dec: Angle.Degrees(-00.92985473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2121",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2305"},
        {"Hipparcos Number", "HIP 2121"},
        {"Geneva Identification System", "GEN# +1.00002305"},
        {"Smithsonian Astrophysical Observation", "SAO 128762"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.72127984),
        dec: Angle.Degrees(-00.92960721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62808",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111853"},
        {"Hipparcos Number", "HIP 62808"},
        {"Smithsonian Astrophysical Observation", "SAO 139010"},
    },
    visualMagnitude: 7.74,
    bvColour: 1.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.05079599),
        dec: Angle.Degrees(-00.92899936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35038",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293675"},
        {"Hipparcos Number", "HIP 35038"},
    },
    visualMagnitude: 10.32,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.70642625),
        dec: Angle.Degrees(-00.92798876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41881",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41881"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.773,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.09725397),
        dec: Angle.Degrees(-00.92795342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -133.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 83.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32270",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 32270"},
    },
    visualMagnitude: 11.61,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.05860488),
        dec: Angle.Degrees(-00.92543766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200340"},
        {"Hipparcos Number", "HIP 103889"},
        {"Geneva Identification System", "GEN# +1.00200340"},
        {"Smithsonian Astrophysical Observation", "SAO 145050"},
        {"Wilson Evans Batten Catalogue", "WEB 18916"},
    },
    visualMagnitude: 6.50,
    bvColour: -0.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.74842658),
        dec: Angle.Degrees(-00.92474717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12464",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12464"},
    },
    visualMagnitude: 10.04,
    bvColour: 0.337,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.12910761),
        dec: Angle.Degrees(-00.92459295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27351"},
        {"Hipparcos Number", "HIP 20127"},
        {"Geneva Identification System", "GEN# +1.00027351"},
        {"Smithsonian Astrophysical Observation", "SAO 131107"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.929,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.72940821),
        dec: Angle.Degrees(-00.92425861)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185273"},
        {"Hipparcos Number", "HIP 96604"},
        {"Geneva Identification System", "GEN# +1.00185273"},
        {"Smithsonian Astrophysical Observation", "SAO 143639"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.60015256),
        dec: Angle.Degrees(-00.92291067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20969",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28520"},
        {"Hipparcos Number", "HIP 20969"},
        {"Renson", "Renson 7320"},
    },
    visualMagnitude: 9.64,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.43941795),
        dec: Angle.Degrees(-00.91986488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71434",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128350"},
        {"Hipparcos Number", "HIP 71434"},
        {"Smithsonian Astrophysical Observation", "SAO 140030"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.560,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.10999189),
        dec: Angle.Degrees(-00.91867315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18833"},
        {"Hipparcos Number", "HIP 14105"},
        {"Geneva Identification System", "GEN# +1.00018833"},
        {"Smithsonian Astrophysical Observation", "SAO 130247"},
    },
    visualMagnitude: 8.11,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.46950471),
        dec: Angle.Degrees(-00.91848318)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209321"},
        {"Hipparcos Number", "HIP 108810"},
        {"Smithsonian Astrophysical Observation", "SAO 145825"},
    },
    visualMagnitude: 7.80,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.63797887),
        dec: Angle.Degrees(-00.91836570)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27744",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39401"},
        {"Hipparcos Number", "HIP 27744"},
        {"Smithsonian Astrophysical Observation", "SAO 132605"},
    },
    visualMagnitude: 8.81,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.09398208),
        dec: Angle.Degrees(-00.91741620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68810",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123014"},
        {"Hipparcos Number", "HIP 68810"},
        {"Smithsonian Astrophysical Observation", "SAO 139728"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.31526550),
        dec: Angle.Degrees(-00.91614780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182905"},
        {"Hipparcos Number", "HIP 95622"},
        {"Geneva Identification System", "GEN# +1.00182905"},
        {"Smithsonian Astrophysical Observation", "SAO 143408"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.772,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.74074102),
        dec: Angle.Degrees(-00.91157108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -152.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111323",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213675"},
        {"Hipparcos Number", "HIP 111323"},
        {"Smithsonian Astrophysical Observation", "SAO 146152"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.515,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.30474026),
        dec: Angle.Degrees(-00.91146648)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40858",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70110"},
        {"Hipparcos Number", "HIP 40858"},
        {"Geneva Identification System", "GEN# +1.00070110"},
        {"Smithsonian Astrophysical Observation", "SAO 135783"},
    },
    visualMagnitude: 6.18,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.05406858),
        dec: Angle.Degrees(-00.90910329)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -86.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78080",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142817"},
        {"Hipparcos Number", "HIP 78080"},
        {"Geneva Identification System", "GEN# +1.00142817"},
        {"Smithsonian Astrophysical Observation", "SAO 140846"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.15369216),
        dec: Angle.Degrees(-00.90846513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35499",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5982 AB"},
        {"Henry Draper", "HD 57051"},
        {"Hipparcos Number", "HIP 35499"},
    },
    visualMagnitude: 8.46,
    bvColour: -0.059,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.88793354),
        dec: Angle.Degrees(-00.90835271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100237",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193328"},
        {"Hipparcos Number", "HIP 100237"},
        {"Geneva Identification System", "GEN# +1.00193328"},
        {"Smithsonian Astrophysical Observation", "SAO 144299"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.94776955),
        dec: Angle.Degrees(-00.90709652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108991",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209625"},
        {"Hipparcos Number", "HIP 108991"},
        {"Geneva Identification System", "GEN# +1.00209625"},
        {"Renson", "Renson 58320"},
        {"Smithsonian Astrophysical Observation", "SAO 145853"},
        {"Wilson Evans Batten Catalogue", "WEB 19598"},
    },
    visualMagnitude: 5.29,
    bvColour: 0.231,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.19764106),
        dec: Angle.Degrees(-00.90623994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29011",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41810"},
        {"Hipparcos Number", "HIP 29011"},
        {"Geneva Identification System", "GEN# +1.00041810"},
        {"Smithsonian Astrophysical Observation", "SAO 132851"},
    },
    visualMagnitude: 8.68,
    bvColour: 0.078,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.82828581),
        dec: Angle.Degrees(-00.90600429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73741",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133409"},
        {"Hipparcos Number", "HIP 73741"},
        {"Geneva Identification System", "GEN# +1.00133409"},
        {"Smithsonian Astrophysical Observation", "SAO 140303"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.216,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.10204092),
        dec: Angle.Degrees(-00.90550462)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90043"},
        {"Hipparcos Number", "HIP 50887"},
        {"Geneva Identification System", "GEN# +1.00090043"},
        {"Smithsonian Astrophysical Observation", "SAO 137532"},
        {"Wilson Evans Batten Catalogue", "WEB 9309"},
    },
    visualMagnitude: 6.45,
    bvColour: 0.918,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.86805001),
        dec: Angle.Degrees(-00.90216210)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70702",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70702"},
        {"Wilson Evans Batten Catalogue", "WEB 12252"},
    },
    visualMagnitude: 11.68,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.91281897),
        dec: Angle.Degrees(-00.90156680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99665"},
        {"Hipparcos Number", "HIP 55960"},
        {"Geneva Identification System", "GEN# +1.00099665"},
        {"Renson", "Renson 28683"},
        {"Smithsonian Astrophysical Observation", "SAO 138220"},
    },
    visualMagnitude: 7.11,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.01477582),
        dec: Angle.Degrees(-00.89780313)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52228",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92414"},
        {"Hipparcos Number", "HIP 52228"},
        {"Smithsonian Astrophysical Observation", "SAO 137715"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.05940600),
        dec: Angle.Degrees(-00.89499147)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3410",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 608 A"},
        {"Henry Draper", "HD 4096"},
        {"Hipparcos Number", "HIP 3410"},
        {"Cincinnati Publication", "Ci 18 92"},
        {"Geneva Identification System", "GEN# +1.00004096A"},
        {"Smithsonian Astrophysical Observation", "SAO 128919"},
        {"Wilson Evans Batten Catalogue", "WEB 601"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(010.85287972),
        dec: Angle.Degrees(-00.89412919)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -114.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -222.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15553",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15553"},
    },
    visualMagnitude: 10.17,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.09198385),
        dec: Angle.Degrees(-00.89411285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 157346"},
        {"Hipparcos Number", "HIP 85028"},
        {"Smithsonian Astrophysical Observation", "SAO 141640"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.68527058),
        dec: Angle.Degrees(-00.89386433)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 236",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225059"},
        {"Hipparcos Number", "HIP 236"},
        {"Smithsonian Astrophysical Observation", "SAO 128552"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.73781657),
        dec: Angle.Degrees(-00.89382979)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181440"},
        {"Hipparcos Number", "HIP 95073"},
        {"Geneva Identification System", "GEN# +1.00181440"},
        {"Smithsonian Astrophysical Observation", "SAO 143292"},
        {"Wilson Evans Batten Catalogue", "WEB 16605"},
    },
    visualMagnitude: 5.46,
    bvColour: -0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.14867994),
        dec: Angle.Degrees(-00.89216854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154445"},
        {"Hipparcos Number", "HIP 83635"},
        {"Fundamental Katalog 5th Edition", "FK5 3357"},
        {"Geneva Identification System", "GEN# +1.00154445"},
        {"Smithsonian Astrophysical Observation", "SAO 141513"},
        {"Wilson Evans Batten Catalogue", "WEB 14143"},
    },
    visualMagnitude: 5.63,
    bvColour: 0.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.38440349),
        dec: Angle.Degrees(-00.89206540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35410"},
        {"Hipparcos Number", "HIP 25282"},
        {"Geneva Identification System", "GEN# +1.00035410"},
        {"Smithsonian Astrophysical Observation", "SAO 132070"},
        {"Wilson Evans Batten Catalogue", "WEB 4902"},
    },
    visualMagnitude: 5.07,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.12046283),
        dec: Angle.Degrees(-00.89166902)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 140.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24611",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34341"},
        {"Hipparcos Number", "HIP 24611"},
        {"Geneva Identification System", "GEN# +1.00034341"},
        {"Smithsonian Astrophysical Observation", "SAO 131937"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.18268004),
        dec: Angle.Degrees(-00.88887974)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289953"},
        {"Hipparcos Number", "HIP 23953"},
        {"Smithsonian Astrophysical Observation", "SAO 131814"},
    },
    visualMagnitude: 10.23,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.21812605),
        dec: Angle.Degrees(-00.88811871)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24382",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33947"},
        {"Hipparcos Number", "HIP 24382"},
        {"Geneva Identification System", "GEN# +1.00033947"},
        {"Smithsonian Astrophysical Observation", "SAO 131892"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.375,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.45878487),
        dec: Angle.Degrees(-00.88655478)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39954"},
        {"Hipparcos Number", "HIP 28044"},
        {"Geneva Identification System", "GEN# +1.00039954"},
        {"Smithsonian Astrophysical Observation", "SAO 132659"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.96006739),
        dec: Angle.Degrees(-00.88606319)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -164.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38256",
    secondaryIds: new Dictionary<string,string>{
    },
    visualMagnitude: 11.18,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.HoursMinutesSeconds((int)07, (int)50, 12.0000),
        dec: Angle.DegreesMinutesSeconds((int)-00, (int)53, 09.300)
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
    primaryId: "HIP 18470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24830"},
        {"Hipparcos Number", "HIP 18470"},
        {"Geneva Identification System", "GEN# +1.00024830"},
        {"Smithsonian Astrophysical Observation", "SAO 130835"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.21628141),
        dec: Angle.Degrees(-00.88581129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9444",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12378"},
        {"Hipparcos Number", "HIP 9444"},
        {"Smithsonian Astrophysical Observation", "SAO 129636"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.33890770),
        dec: Angle.Degrees(-00.88491233)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76504",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139308"},
        {"Hipparcos Number", "HIP 76504"},
        {"Geneva Identification System", "GEN# +1.00139308"},
        {"Smithsonian Astrophysical Observation", "SAO 140659"},
        {"Wilson Evans Batten Catalogue", "WEB 12985"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.37026814),
        dec: Angle.Degrees(-00.88484569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14690"},
        {"Hipparcos Number", "HIP 11046"},
        {"Fundamental Katalog 5th Edition", "FK5 2160"},
        {"Geneva Identification System", "GEN# +1.00014690"},
        {"Smithsonian Astrophysical Observation", "SAO 129858"},
        {"Wilson Evans Batten Catalogue", "WEB 2323"},
    },
    visualMagnitude: 5.42,
    bvColour: 0.335,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.55169522),
        dec: Angle.Degrees(-00.88474037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -45.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115491",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220435"},
        {"Hipparcos Number", "HIP 115491"},
        {"Geneva Identification System", "GEN# +1.00220435"},
        {"Smithsonian Astrophysical Observation", "SAO 146682"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.93105564),
        dec: Angle.Degrees(-00.88458740)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -91.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 106385"},
    },
    visualMagnitude: 9.93,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.20623262),
        dec: Angle.Degrees(-00.88312348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162994"},
        {"Hipparcos Number", "HIP 87622"},
        {"Smithsonian Astrophysical Observation", "SAO 141951"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.49175564),
        dec: Angle.Degrees(-00.88286582)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74216",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134456"},
        {"Hipparcos Number", "HIP 74216"},
        {"Geneva Identification System", "GEN# +1.00134456"},
        {"Smithsonian Astrophysical Observation", "SAO 140360"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.49310737),
        dec: Angle.Degrees(-00.87979511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57564",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57564"},
    },
    visualMagnitude: 11.05,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.99636926),
        dec: Angle.Degrees(-00.87801037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190873"},
        {"Hipparcos Number", "HIP 99100"},
        {"Geneva Identification System", "GEN# +1.00190873"},
        {"Smithsonian Astrophysical Observation", "SAO 144081"},
    },
    visualMagnitude: 8.26,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.78794899),
        dec: Angle.Degrees(-00.87408537)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 115.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -69.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75153",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136582"},
        {"Hipparcos Number", "HIP 75153"},
        {"Smithsonian Astrophysical Observation", "SAO 140482"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.367,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.37793332),
        dec: Angle.Degrees(-00.87241808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201753"},
        {"Hipparcos Number", "HIP 104626"},
        {"Geneva Identification System", "GEN# +1.00201753"},
        {"Smithsonian Astrophysical Observation", "SAO 145186"},
    },
    visualMagnitude: 7.89,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.90951662),
        dec: Angle.Degrees(-00.87108738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1663",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1651"},
        {"Hipparcos Number", "HIP 1663"},
        {"Geneva Identification System", "GEN# +1.00001651"},
        {"Renson", "Renson 355"},
        {"Smithsonian Astrophysical Observation", "SAO 128703"},
    },
    visualMagnitude: 9.30,
    bvColour: 0.362,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.20735342),
        dec: Angle.Degrees(-00.87108457)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101991",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101991"},
        {"Wilson Evans Batten Catalogue", "WEB 18437"},
    },
    visualMagnitude: 11.42,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.03799576),
        dec: Angle.Degrees(-00.87088109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 75.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22408",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30625"},
        {"Hipparcos Number", "HIP 22408"},
        {"Geneva Identification System", "GEN# +1.00030625"},
        {"Smithsonian Astrophysical Observation", "SAO 131516"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.641,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.33026455),
        dec: Angle.Degrees(-00.86956387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222156"},
        {"Hipparcos Number", "HIP 116643"},
        {"Smithsonian Astrophysical Observation", "SAO 146817"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.56609501),
        dec: Angle.Degrees(-00.86861673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41068",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70596"},
        {"Hipparcos Number", "HIP 41068"},
        {"Geneva Identification System", "GEN# +1.00070596"},
        {"Smithsonian Astrophysical Observation", "SAO 135835"},
    },
    visualMagnitude: 6.95,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.69773231),
        dec: Angle.Degrees(-00.86756407)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99711",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Phoenicia"},
        {"Aitken", "ADS 13547 A"},
        {"Henry Draper", "HD 192263"},
        {"Hipparcos Number", "HIP 99711"},
        {"Geneva Identification System", "GEN# +1.00192263"},
        {"Smithsonian Astrophysical Observation", "SAO 144192"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.938,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.49950890),
        dec: Angle.Degrees(-00.86751441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 262.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6130",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1057 A"},
        {"Henry Draper", "HD 7895"},
        {"Hipparcos Number", "HIP 6130"},
        {"Cincinnati Publication", "Ci 20 94"},
        {"Geneva Identification System", "GEN# +1.00007895A"},
        {"Smithsonian Astrophysical Observation", "SAO 129219"},
        {"Wilson Evans Batten Catalogue", "WEB 1377"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.67019999),
        dec: Angle.Degrees(-00.86695851)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 431.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -250.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25240",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3991 ABC"},
        {"Henry Draper", "HD 35317"},
        {"Hipparcos Number", "HIP 25240"},
        {"Geneva Identification System", "GEN# +1.00035317J"},
        {"Smithsonian Astrophysical Observation", "SAO 132060"},
        {"Wilson Evans Batten Catalogue", "WEB 4895"},
    },
    visualMagnitude: 6.13,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.96388815),
        dec: Angle.Degrees(-00.86662418)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7825 AB"},
        {"Henry Draper", "HD 91333"},
        {"Hipparcos Number", "HIP 51619"},
        {"Smithsonian Astrophysical Observation", "SAO 137633"},
    },
    visualMagnitude: 8.88,
    bvColour: 0.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.18231253),
        dec: Angle.Degrees(-00.86651170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34170",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5769 AB"},
        {"Henry Draper", "HD 53481"},
        {"Hipparcos Number", "HIP 34170"},
        {"Smithsonian Astrophysical Observation", "SAO 134161"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.29240908),
        dec: Angle.Degrees(-00.86556589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104727"},
        {"Hipparcos Number", "HIP 58800"},
        {"Smithsonian Astrophysical Observation", "SAO 138557"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.570,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.90649593),
        dec: Angle.Degrees(-00.86297448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182534"},
        {"Hipparcos Number", "HIP 95466"},
        {"Smithsonian Astrophysical Observation", "SAO 143378"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.28993772),
        dec: Angle.Degrees(-00.86191389)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73276",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73276"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.423,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.64249137),
        dec: Angle.Degrees(-00.85622369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80261",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10028 AB"},
        {"Henry Draper", "HD 147645"},
        {"Hipparcos Number", "HIP 80261"},
        {"Smithsonian Astrophysical Observation", "SAO 141136"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.358,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.77470317),
        dec: Angle.Degrees(-00.85616280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74304",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74304"},
    },
    visualMagnitude: 11.64,
    bvColour: 1.344,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.81407655),
        dec: Angle.Degrees(-00.85534044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 87.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -194.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109969"},
        {"Hipparcos Number", "HIP 61711"},
        {"Geneva Identification System", "GEN# +1.00109969"},
        {"Smithsonian Astrophysical Observation", "SAO 138889"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.73488264),
        dec: Angle.Degrees(-00.85416201)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -79.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75938",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138185"},
        {"Hipparcos Number", "HIP 75938"},
    },
    visualMagnitude: 9.67,
    bvColour: 1.249,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.65001890),
        dec: Angle.Degrees(-00.84971403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99873"},
        {"Hipparcos Number", "HIP 56061"},
        {"Geneva Identification System", "GEN# +1.00099873"},
        {"Smithsonian Astrophysical Observation", "SAO 138233"},
        {"Wilson Evans Batten Catalogue", "WEB 10066"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.35119162),
        dec: Angle.Degrees(-00.84893127)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14912",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19964"},
        {"Hipparcos Number", "HIP 14912"},
        {"Geneva Identification System", "GEN# +1.00019964"},
        {"Smithsonian Astrophysical Observation", "SAO 130347"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.930,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.10668232),
        dec: Angle.Degrees(-00.84862641)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130557"},
        {"Hipparcos Number", "HIP 72449"},
        {"Fundamental Katalog 5th Edition", "FK5 3169"},
        {"Geneva Identification System", "GEN# +1.00130557"},
        {"Renson", "Renson 37150"},
        {"Smithsonian Astrophysical Observation", "SAO 140152"},
        {"Wilson Evans Batten Catalogue", "WEB 12449"},
    },
    visualMagnitude: 6.15,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.22541473),
        dec: Angle.Degrees(-00.84769586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57343"},
        {"Hipparcos Number", "HIP 35598"},
        {"Geneva Identification System", "GEN# +1.00057343"},
        {"Smithsonian Astrophysical Observation", "SAO 134541"},
    },
    visualMagnitude: 7.48,
    bvColour: 0.317,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.19297288),
        dec: Angle.Degrees(-00.84676375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12814",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17122"},
        {"Hipparcos Number", "HIP 12814"},
        {"Geneva Identification System", "GEN# +1.00017122"},
        {"Smithsonian Astrophysical Observation", "SAO 130091"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.17827966),
        dec: Angle.Degrees(-00.84611922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69493",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 124425"},
        {"Hipparcos Number", "HIP 69493"},
        {"Geneva Identification System", "GEN# +1.00124425"},
        {"Renson", "Renson 35610"},
        {"Smithsonian Astrophysical Observation", "SAO 139798"},
        {"Wilson Evans Batten Catalogue", "WEB 12110"},
    },
    visualMagnitude: 5.89,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.41945412),
        dec: Angle.Degrees(-00.84512445)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 207.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98665",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189907"},
        {"Hipparcos Number", "HIP 98665"},
        {"Smithsonian Astrophysical Observation", "SAO 144013"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.952,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.60546584),
        dec: Angle.Degrees(-00.84468336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116209",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221501"},
        {"Hipparcos Number", "HIP 116209"},
        {"Smithsonian Astrophysical Observation", "SAO 146761"},
    },
    visualMagnitude: 9.07,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.19489862),
        dec: Angle.Degrees(-00.84272286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98027",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13103 A"},
        {"Henry Draper", "HD 188429"},
        {"Hipparcos Number", "HIP 98027"},
        {"Smithsonian Astrophysical Observation", "SAO 143910"},
    },
    visualMagnitude: 8.32,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.80013452),
        dec: Angle.Degrees(-00.84254237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23991"},
        {"Hipparcos Number", "HIP 17863"},
        {"Geneva Identification System", "GEN# +1.00023991"},
        {"Smithsonian Astrophysical Observation", "SAO 130748"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.34569553),
        dec: Angle.Degrees(-00.84099847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96711"},
        {"Hipparcos Number", "HIP 54445"},
        {"Geneva Identification System", "GEN# +1.00096711"},
        {"Smithsonian Astrophysical Observation", "SAO 138004"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.535,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.09835043),
        dec: Angle.Degrees(-00.84071323)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96689",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 96689"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.906,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.85516930),
        dec: Angle.Degrees(-00.84031133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -145.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214100"},
        {"Hipparcos Number", "HIP 111571"},
        {"Cincinnati Publication", "Ci 20 1373"},
        {"Geneva Identification System", "GEN# +1.00214100"},
        {"Wilson Evans Batten Catalogue", "WEB 19946"},
    },
    visualMagnitude: 9.98,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.04021314),
        dec: Angle.Degrees(-00.84015099)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -630.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117126"},
        {"Hipparcos Number", "HIP 65708"},
        {"Geneva Identification System", "GEN# +1.00117126"},
        {"Smithsonian Astrophysical Observation", "SAO 139353"},
        {"Wilson Evans Batten Catalogue", "WEB 11628"},
    },
    visualMagnitude: 7.44,
    bvColour: 0.651,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.07740683),
        dec: Angle.Degrees(-00.83920302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 224.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -405.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7028",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9204"},
        {"Hipparcos Number", "HIP 7028"},
        {"Smithsonian Astrophysical Observation", "SAO 129337"},
    },
    visualMagnitude: 8.87,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.64104570),
        dec: Angle.Degrees(-00.83795451)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81390"},
        {"Hipparcos Number", "HIP 46211"},
        {"Geneva Identification System", "GEN# +1.00081390"},
        {"Smithsonian Astrophysical Observation", "SAO 136826"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.225,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.32778778),
        dec: Angle.Degrees(-00.83723733)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115891",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16781 AB"},
        {"Henry Draper", "HD 221043"},
        {"Hipparcos Number", "HIP 115891"},
        {"Smithsonian Astrophysical Observation", "SAO 146725"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.19275471),
        dec: Angle.Degrees(-00.83532822)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -130.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85136",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10518 AB"},
        {"Henry Draper", "HD 157544"},
        {"Hipparcos Number", "HIP 85136"},
        {"Smithsonian Astrophysical Observation", "SAO 141648"},
    },
    visualMagnitude: 8.41,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.98902158),
        dec: Angle.Degrees(-00.83522095)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81505",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150088"},
        {"Hipparcos Number", "HIP 81505"},
        {"Geneva Identification System", "GEN# +1.00150088"},
        {"Smithsonian Astrophysical Observation", "SAO 141293"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.115,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.71398533),
        dec: Angle.Degrees(-00.83487633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 145550"},
        {"Hipparcos Number", "HIP 79348"},
        {"Smithsonian Astrophysical Observation", "SAO 141021"},
    },
    visualMagnitude: 8.81,
    bvColour: 1.380,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.90684407),
        dec: Angle.Degrees(-00.83391937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72226",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130110"},
        {"Hipparcos Number", "HIP 72226"},
        {"Geneva Identification System", "GEN# +1.00130110"},
        {"Smithsonian Astrophysical Observation", "SAO 140129"},
    },
    visualMagnitude: 6.91,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.57422109),
        dec: Angle.Degrees(-00.83383067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195038"},
        {"Hipparcos Number", "HIP 101033"},
        {"Smithsonian Astrophysical Observation", "SAO 144482"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.243,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.23089421),
        dec: Angle.Degrees(-00.83356508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30332",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44654"},
        {"Hipparcos Number", "HIP 30332"},
        {"Fundamental Katalog 5th Edition", "FK5 4577"},
        {"Geneva Identification System", "GEN# +1.00044654"},
        {"Smithsonian Astrophysical Observation", "SAO 133183"},
    },
    visualMagnitude: 7.63,
    bvColour: -0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.70676179),
        dec: Angle.Degrees(-00.83308876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184180"},
        {"Hipparcos Number", "HIP 96167"},
        {"Geneva Identification System", "GEN# +1.00184180"},
        {"Smithsonian Astrophysical Observation", "SAO 143525"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.30320412),
        dec: Angle.Degrees(-00.83300393)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104878",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14775 AB"},
        {"Henry Draper", "HD 202260"},
        {"Hipparcos Number", "HIP 104878"},
        {"Geneva Identification System", "GEN# +1.00202260J"},
        {"Smithsonian Astrophysical Observation", "SAO 145230"},
    },
    visualMagnitude: 7.43,
    bvColour: 0.092,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.67125048),
        dec: Angle.Degrees(-00.83195634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197799"},
        {"Hipparcos Number", "HIP 102476"},
        {"Geneva Identification System", "GEN# +1.00197799"},
        {"Smithsonian Astrophysical Observation", "SAO 144784"},
    },
    visualMagnitude: 8.16,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.49599937),
        dec: Angle.Degrees(-00.82469691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56647",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100920"},
        {"Hipparcos Number", "HIP 56647"},
        {"Fundamental Katalog 5th Edition", "FK5 437"},
        {"Geneva Identification System", "GEN# +1.00100920"},
        {"Smithsonian Astrophysical Observation", "SAO 138298"},
        {"Wilson Evans Batten Catalogue", "WEB 10182"},
    },
    visualMagnitude: 4.30,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.23720774),
        dec: Angle.Degrees(-00.82385424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 43.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6236",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6236"},
        {"Smithsonian Astrophysical Observation", "SAO 129237"},
    },
    visualMagnitude: 9.34,
    bvColour: 1.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.00582507),
        dec: Angle.Degrees(-00.82338559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62348",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111044"},
        {"Hipparcos Number", "HIP 62348"},
        {"Geneva Identification System", "GEN# +1.00111044"},
        {"Smithsonian Astrophysical Observation", "SAO 138961"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(191.63497877),
        dec: Angle.Degrees(-00.82154922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99473",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191692"},
        {"Hipparcos Number", "HIP 99473"},
        {"Fundamental Katalog 5th Edition", "FK5 756"},
        {"Geneva Identification System", "GEN# +1.00191692"},
        {"Smithsonian Astrophysical Observation", "SAO 144150"},
        {"Wilson Evans Batten Catalogue", "WEB 17777"},
    },
    visualMagnitude: 3.24,
    bvColour: -0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82610327),
        dec: Angle.Degrees(-00.82147569)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78545",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143723"},
        {"Hipparcos Number", "HIP 78545"},
        {"Geneva Identification System", "GEN# +1.00143723"},
        {"Smithsonian Astrophysical Observation", "SAO 140907"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.52769461),
        dec: Angle.Degrees(-00.82105869)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37553",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62124"},
        {"Hipparcos Number", "HIP 37553"},
        {"Smithsonian Astrophysical Observation", "SAO 135003"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.60695291),
        dec: Angle.Degrees(-00.81764471)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102097"},
        {"Hipparcos Number", "HIP 57301"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.24528811),
        dec: Angle.Degrees(-00.81567039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -202.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 62.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38931",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6487 A"},
        {"Henry Draper", "HD 65277"},
        {"Henry Draper 2", "HD 65277A"},
        {"Hipparcos Number", "HIP 38931"},
        {"Cincinnati Publication", "Ci 18 946"},
        {"Geneva Identification System", "GEN# +1.00065277"},
        {"Smithsonian Astrophysical Observation", "SAO 135302"},
        {"Wilson Evans Batten Catalogue", "WEB 7630"},
    },
    visualMagnitude: 8.05,
    bvColour: 1.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.49115589),
        dec: Angle.Degrees(-00.81442473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -156.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65067"},
        {"Hipparcos Number", "HIP 38838"},
        {"Geneva Identification System", "GEN# +1.00065067"},
        {"Smithsonian Astrophysical Observation", "SAO 135285"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.22299775),
        dec: Angle.Degrees(-00.81206870)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -87.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48118",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84940"},
        {"Hipparcos Number", "HIP 48118"},
        {"Smithsonian Astrophysical Observation", "SAO 137148"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.14954651),
        dec: Angle.Degrees(-00.81034042)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24341",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290086"},
        {"Hipparcos Number", "HIP 24341"},
        {"Smithsonian Astrophysical Observation", "SAO 131882"},
    },
    visualMagnitude: 9.56,
    bvColour: 0.467,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.36044791),
        dec: Angle.Degrees(-00.80881969)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117739",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223794"},
        {"Hipparcos Number", "HIP 117739"},
        {"Smithsonian Astrophysical Observation", "SAO 146948"},
    },
    visualMagnitude: 10.22,
    bvColour: 0.517,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.17843240),
        dec: Angle.Degrees(-00.80824955)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34541",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293373"},
        {"Hipparcos Number", "HIP 34541"},
        {"New General Catalogue", "NGC 2346"},
    },
    visualMagnitude: 10.96,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.34384607),
        dec: Angle.Degrees(-00.80655572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53383",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53383"},
        {"Geneva Identification System", "GEN# -0.00002387"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.088,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.76819684),
        dec: Angle.Degrees(-00.80527719)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -237.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92955",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11854 AB"},
        {"Henry Draper", "HD 175615"},
        {"Hipparcos Number", "HIP 92955"},
        {"Smithsonian Astrophysical Observation", "SAO 142822"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.07390752),
        dec: Angle.Degrees(-00.80403225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25732",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4096 AB"},
        {"Henry Draper", "HD 36150"},
        {"Hipparcos Number", "HIP 25732"},
        {"Geneva Identification System", "GEN# +1.00036150J"},
        {"Smithsonian Astrophysical Observation", "SAO 132175"},
    },
    visualMagnitude: 6.49,
    bvColour: 0.251,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.42330541),
        dec: Angle.Degrees(-00.80241717)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25466"},
        {"Hipparcos Number", "HIP 18863"},
        {"Geneva Identification System", "GEN# +1.00025466"},
        {"Smithsonian Astrophysical Observation", "SAO 130894"},
    },
    visualMagnitude: 6.93,
    bvColour: 0.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.66025991),
        dec: Angle.Degrees(-00.80102081)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148713"},
        {"Hipparcos Number", "HIP 80805"},
        {"Smithsonian Astrophysical Observation", "SAO 141204"},
    },
    visualMagnitude: 8.02,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.50913268),
        dec: Angle.Degrees(-00.80067076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33039"},
        {"Hipparcos Number", "HIP 23832"},
        {"Smithsonian Astrophysical Observation", "SAO 131787"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.85384340),
        dec: Angle.Degrees(-00.79936190)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113307"},
        {"Hipparcos Number", "HIP 63659"},
        {"Smithsonian Astrophysical Observation", "SAO 139116"},
    },
    visualMagnitude: 8.72,
    bvColour: 1.533,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(195.70286876),
        dec: Angle.Degrees(-00.79440070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177259"},
        {"Hipparcos Number", "HIP 93627"},
        {"Geneva Identification System", "GEN# +1.00177259"},
        {"Smithsonian Astrophysical Observation", "SAO 142974"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.99741554),
        dec: Angle.Degrees(-00.79411781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23809",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289949"},
        {"Hipparcos Number", "HIP 23809"},
    },
    visualMagnitude: 10.35,
    bvColour: 0.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.75874729),
        dec: Angle.Degrees(-00.79229788)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17432",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17432"},
    },
    visualMagnitude: 10.71,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.01360596),
        dec: Angle.Degrees(-00.79184507)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -90.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112104",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16190 AB"},
        {"Henry Draper", "HD 215045"},
        {"Hipparcos Number", "HIP 112104"},
        {"Smithsonian Astrophysical Observation", "SAO 146257"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.487,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.59979373),
        dec: Angle.Degrees(-00.79163199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97373"},
        {"Hipparcos Number", "HIP 54736"},
        {"Smithsonian Astrophysical Observation", "SAO 138058"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.10178237),
        dec: Angle.Degrees(-00.79084499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90212"},
        {"Hipparcos Number", "HIP 50978"},
        {"Geneva Identification System", "GEN# +1.00090212"},
        {"Smithsonian Astrophysical Observation", "SAO 137545"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.19176435),
        dec: Angle.Degrees(-00.79020340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109835",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211079"},
        {"Hipparcos Number", "HIP 109835"},
        {"Smithsonian Astrophysical Observation", "SAO 145967"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.160,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.69461055),
        dec: Angle.Degrees(-00.78972362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12157",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12157"},
        {"Smithsonian Astrophysical Observation", "SAO 130010"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(039.16678149),
        dec: Angle.Degrees(-00.78929855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40797",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69996"},
        {"Hipparcos Number", "HIP 40797"},
        {"Geneva Identification System", "GEN# +1.00069996"},
        {"Smithsonian Astrophysical Observation", "SAO 135776"},
    },
    visualMagnitude: 7.84,
    bvColour: 1.008,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(124.89861072),
        dec: Angle.Degrees(-00.78921666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88833",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165829"},
        {"Hipparcos Number", "HIP 88833"},
        {"Smithsonian Astrophysical Observation", "SAO 142104"},
    },
    visualMagnitude: 8.09,
    bvColour: 1.048,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.99601489),
        dec: Angle.Degrees(-00.78784327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148375"},
        {"Hipparcos Number", "HIP 80618"},
        {"Smithsonian Astrophysical Observation", "SAO 141188"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.92502721),
        dec: Angle.Degrees(-00.78741467)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107070"},
        {"Hipparcos Number", "HIP 60030"},
        {"Geneva Identification System", "GEN# +1.00107070"},
        {"Smithsonian Astrophysical Observation", "SAO 138710"},
        {"Wilson Evans Batten Catalogue", "WEB 10669"},
    },
    visualMagnitude: 5.90,
    bvColour: 0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.66790853),
        dec: Angle.Degrees(-00.78714480)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136029"},
        {"Hipparcos Number", "HIP 74904"},
        {"Geneva Identification System", "GEN# +1.00136029"},
        {"Smithsonian Astrophysical Observation", "SAO 140445"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.835,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.61495192),
        dec: Angle.Degrees(-00.78602044)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -79.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83293",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153756"},
        {"Hipparcos Number", "HIP 83293"},
        {"Smithsonian Astrophysical Observation", "SAO 141487"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.255,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.34307089),
        dec: Angle.Degrees(-00.78560766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43488",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43488"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.87013768),
        dec: Angle.Degrees(-00.78474666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216689"},
        {"Hipparcos Number", "HIP 113164"},
        {"Geneva Identification System", "GEN# +1.00216689"},
        {"Smithsonian Astrophysical Observation", "SAO 146385"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.602,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.74062218),
        dec: Angle.Degrees(-00.78472700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 80.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81897",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150859"},
        {"Hipparcos Number", "HIP 81897"},
        {"Smithsonian Astrophysical Observation", "SAO 141330"},
    },
    visualMagnitude: 7.32,
    bvColour: 1.204,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.92453331),
        dec: Angle.Degrees(-00.78399446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108362",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208568"},
        {"Hipparcos Number", "HIP 108362"},
        {"Smithsonian Astrophysical Observation", "SAO 145765"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.489,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.28811976),
        dec: Angle.Degrees(-00.78345596)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 97428"},
    },
    visualMagnitude: 10.54,
    bvColour: 0.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.02417299),
        dec: Angle.Degrees(-00.78306829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83215",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 153589"},
        {"Hipparcos Number", "HIP 83215"},
        {"Smithsonian Astrophysical Observation", "SAO 141479"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.678,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.11247598),
        dec: Angle.Degrees(-00.77995249)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14374"},
        {"Hipparcos Number", "HIP 10818"},
        {"Geneva Identification System", "GEN# +1.00014374"},
        {"Smithsonian Astrophysical Observation", "SAO 129823"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.81667058),
        dec: Angle.Degrees(-00.77976108)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152015"},
        {"Hipparcos Number", "HIP 82445"},
        {"Smithsonian Astrophysical Observation", "SAO 141400"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.100,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.73597700),
        dec: Angle.Degrees(-00.77859366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37332"},
        {"Hipparcos Number", "HIP 26464"},
        {"Celescope Catalog", "CEL 870"},
        {"Geneva Identification System", "GEN# +9.00040015"},
        {"Smithsonian Astrophysical Observation", "SAO 132382"},
    },
    visualMagnitude: 7.61,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.44121195),
        dec: Angle.Degrees(-00.77825317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9929"},
        {"Hipparcos Number", "HIP 7531"},
        {"Smithsonian Astrophysical Observation", "SAO 129403"},
    },
    visualMagnitude: 8.61,
    bvColour: 1.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.25473776),
        dec: Angle.Degrees(-00.77805377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30650",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45257"},
        {"Hipparcos Number", "HIP 30650"},
        {"Geneva Identification System", "GEN# +1.00045257"},
        {"Smithsonian Astrophysical Observation", "SAO 133254"},
    },
    visualMagnitude: 6.79,
    bvColour: -0.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.60483225),
        dec: Angle.Degrees(-00.77674087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39641",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6582 AB"},
        {"Henry Draper", "HD 67010"},
        {"Hipparcos Number", "HIP 39641"},
        {"Smithsonian Astrophysical Observation", "SAO 135495"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.780,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.51445722),
        dec: Angle.Degrees(-00.77639594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4180",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 4180"},
        {"Smithsonian Astrophysical Observation", "SAO 129013"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.816,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.34554329),
        dec: Angle.Degrees(-00.77575813)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 223278"},
        {"Hipparcos Number", "HIP 117395"},
        {"Geneva Identification System", "GEN# +1.00223278"},
        {"Smithsonian Astrophysical Observation", "SAO 146916"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(357.05291598),
        dec: Angle.Degrees(-00.77484809)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78537"},
        {"Hipparcos Number", "HIP 44895"},
        {"Geneva Identification System", "GEN# +1.00078537"},
        {"Smithsonian Astrophysical Observation", "SAO 136605"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.20562975),
        dec: Angle.Degrees(-00.77401179)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84166",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155546"},
        {"Hipparcos Number", "HIP 84166"},
        {"Geneva Identification System", "GEN# +1.00155546"},
        {"Smithsonian Astrophysical Observation", "SAO 141555"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.09392241),
        dec: Angle.Degrees(-00.77374805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203581"},
        {"Hipparcos Number", "HIP 105588"},
        {"Smithsonian Astrophysical Observation", "SAO 145355"},
    },
    visualMagnitude: 7.56,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(320.79345487),
        dec: Angle.Degrees(-00.77296046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67088",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119734"},
        {"Hipparcos Number", "HIP 67088"},
        {"Smithsonian Astrophysical Observation", "SAO 139529"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.169,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.26611563),
        dec: Angle.Degrees(-00.77286358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200048"},
        {"Hipparcos Number", "HIP 103724"},
        {"Smithsonian Astrophysical Observation", "SAO 145029"},
    },
    visualMagnitude: 8.43,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.27026544),
        dec: Angle.Degrees(-00.76884866)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62687",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111631"},
        {"Hipparcos Number", "HIP 62687"},
        {"Cincinnati Publication", "Ci 18 1633"},
        {"Geneva Identification System", "GEN# +1.00111631"},
        {"Smithsonian Astrophysical Observation", "SAO 138992"},
        {"Wilson Evans Batten Catalogue", "WEB 11119"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.68160072),
        dec: Angle.Degrees(-00.76716459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -397.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29384",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42602"},
        {"Hipparcos Number", "HIP 29384"},
        {"Smithsonian Astrophysical Observation", "SAO 132937"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.89110285),
        dec: Angle.Degrees(-00.76711668)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104265",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201066"},
        {"Hipparcos Number", "HIP 104265"},
        {"Geneva Identification System", "GEN# +1.00201066"},
        {"Smithsonian Astrophysical Observation", "SAO 145120"},
    },
    visualMagnitude: 6.58,
    bvColour: 1.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.84111847),
        dec: Angle.Degrees(-00.76518170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82062",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10196 AB"},
        {"Henry Draper", "HD 151168"},
        {"Hipparcos Number", "HIP 82062"},
        {"Geneva Identification System", "GEN# +1.00151168J"},
        {"Smithsonian Astrophysical Observation", "SAO 141350"},
        {"Wilson Evans Batten Catalogue", "WEB 13857"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.44344632),
        dec: Angle.Degrees(-00.76494767)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -78.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156549"},
        {"Hipparcos Number", "HIP 84643"},
        {"Geneva Identification System", "GEN# +1.00156549"},
        {"Smithsonian Astrophysical Observation", "SAO 141599"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.56191149),
        dec: Angle.Degrees(-00.76467937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89305",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 167011"},
        {"Hipparcos Number", "HIP 89305"},
        {"Smithsonian Astrophysical Observation", "SAO 142163"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.884,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.33910817),
        dec: Angle.Degrees(-00.76304855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -123.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117354",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 17007 AB"},
        {"Henry Draper", "HD 223235"},
        {"Hipparcos Number", "HIP 117354"},
        {"Smithsonian Astrophysical Observation", "SAO 146911"},
    },
    visualMagnitude: 7.11,
    bvColour: 1.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.92496196),
        dec: Angle.Degrees(-00.76210697)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40426",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69058"},
        {"Hipparcos Number", "HIP 40426"},
        {"Smithsonian Astrophysical Observation", "SAO 135681"},
    },
    visualMagnitude: 9.19,
    bvColour: -0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.81509338),
        dec: Angle.Degrees(-00.76164517)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89259",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166931"},
        {"Hipparcos Number", "HIP 89259"},
        {"Geneva Identification System", "GEN# +1.00166931"},
        {"Smithsonian Astrophysical Observation", "SAO 142155"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(273.22971449),
        dec: Angle.Degrees(-00.76046446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83991",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10376 AB"},
        {"Henry Draper", "HD 155195"},
        {"Hipparcos Number", "HIP 83991"},
        {"Smithsonian Astrophysical Observation", "SAO 141541"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.266,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(257.54314003),
        dec: Angle.Degrees(-00.76016847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27423",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38823"},
        {"Hipparcos Number", "HIP 27423"},
        {"Geneva Identification System", "GEN# +1.00038823"},
        {"Renson", "Renson 10440"},
        {"Smithsonian Astrophysical Observation", "SAO 132550"},
    },
    visualMagnitude: 7.35,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.10631445),
        dec: Angle.Degrees(-00.75961265)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 205840"},
        {"Hipparcos Number", "HIP 106817"},
        {"Smithsonian Astrophysical Observation", "SAO 145544"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.50942835),
        dec: Angle.Degrees(-00.75881500)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17492",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23391"},
        {"Hipparcos Number", "HIP 17492"},
        {"Smithsonian Astrophysical Observation", "SAO 130702"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.674,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.20806628),
        dec: Angle.Degrees(-00.75710832)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -115.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38653",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 64652"},
        {"Hipparcos Number", "HIP 38653"},
        {"Geneva Identification System", "GEN# +1.00064652"},
        {"Smithsonian Astrophysical Observation", "SAO 135248"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(118.71675546),
        dec: Angle.Degrees(-00.75641781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 752",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 473"},
        {"Hipparcos Number", "HIP 752"},
        {"Smithsonian Astrophysical Observation", "SAO 128613"},
    },
    visualMagnitude: 9.89,
    bvColour: 0.617,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.30406964),
        dec: Angle.Degrees(-00.75219804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54027",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95771"},
        {"Hipparcos Number", "HIP 54027"},
        {"Geneva Identification System", "GEN# +1.00095771"},
        {"Smithsonian Astrophysical Observation", "SAO 137963"},
    },
    visualMagnitude: 6.12,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.81063394),
        dec: Angle.Degrees(-00.75206922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -113.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11438",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15275"},
        {"Hipparcos Number", "HIP 11438"},
        {"Geneva Identification System", "GEN# +1.00015275"},
        {"Smithsonian Astrophysical Observation", "SAO 129913"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.87263093),
        dec: Angle.Degrees(-00.75154782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50772",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89824"},
        {"Hipparcos Number", "HIP 50772"},
        {"Geneva Identification System", "GEN# +1.00089824"},
        {"Smithsonian Astrophysical Observation", "SAO 137517"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.51428019),
        dec: Angle.Degrees(-00.75151637)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6558"},
        {"Hipparcos Number", "HIP 5189"},
        {"Geneva Identification System", "GEN# +1.00006558"},
        {"Smithsonian Astrophysical Observation", "SAO 129121"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.60700174),
        dec: Angle.Degrees(-00.74936120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27399",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38784"},
        {"Hipparcos Number", "HIP 27399"},
        {"Smithsonian Astrophysical Observation", "SAO 132544"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.991,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.04262331),
        dec: Angle.Degrees(-00.74891619)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73853",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133626"},
        {"Hipparcos Number", "HIP 73853"},
        {"Smithsonian Astrophysical Observation", "SAO 140315"},
    },
    visualMagnitude: 8.92,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.40445830),
        dec: Angle.Degrees(-00.74684414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142881"},
        {"Hipparcos Number", "HIP 78114"},
        {"Smithsonian Astrophysical Observation", "SAO 140851"},
    },
    visualMagnitude: 7.53,
    bvColour: 1.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.25362272),
        dec: Angle.Degrees(-00.74521535)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38111",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63368"},
        {"Hipparcos Number", "HIP 38111"},
        {"Geneva Identification System", "GEN# +1.00063368"},
        {"Smithsonian Astrophysical Observation", "SAO 135125"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.15387215),
        dec: Angle.Degrees(-00.74436773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29789"},
        {"Hipparcos Number", "HIP 21829"},
        {"Geneva Identification System", "GEN# +5.20250163"},
        {"Smithsonian Astrophysical Observation", "SAO 131410"},
        {"Wilson Evans Batten Catalogue", "WEB 4200"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.386,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.39496291),
        dec: Angle.Degrees(-00.74414907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 92.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 75.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26686",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290798"},
        {"Hipparcos Number", "HIP 26686"},
        {"Geneva Identification System", "GEN# +1.00290798"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.07113919),
        dec: Angle.Degrees(-00.74374656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71127",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71127"},
        {"Smithsonian Astrophysical Observation", "SAO 139990"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.17893722),
        dec: Angle.Degrees(-00.74371854)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72828",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 72828"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.722,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.29465031),
        dec: Angle.Degrees(-00.74339605)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222342"},
        {"Hipparcos Number", "HIP 116756"},
        {"Geneva Identification System", "GEN# +1.00222342"},
        {"Smithsonian Astrophysical Observation", "SAO 146832"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.654,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(354.93687613),
        dec: Angle.Degrees(-00.74059448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175545"},
        {"Hipparcos Number", "HIP 92914"},
        {"Geneva Identification System", "GEN# +1.00175545"},
        {"Smithsonian Astrophysical Observation", "SAO 142812"},
        {"Wilson Evans Batten Catalogue", "WEB 16089"},
    },
    visualMagnitude: 7.39,
    bvColour: 1.199,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.96431818),
        dec: Angle.Degrees(-00.73923720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22282"},
        {"Hipparcos Number", "HIP 16727"},
        {"Geneva Identification System", "GEN# +1.00022282"},
        {"Smithsonian Astrophysical Observation", "SAO 130589"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.80350661),
        dec: Angle.Degrees(-00.73861013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92811",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175273"},
        {"Hipparcos Number", "HIP 92811"},
        {"Smithsonian Astrophysical Observation", "SAO 142789"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.148,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.66252296),
        dec: Angle.Degrees(-00.73639242)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10233"},
        {"Hipparcos Number", "HIP 7777"},
        {"Smithsonian Astrophysical Observation", "SAO 129433"},
    },
    visualMagnitude: 9.19,
    bvColour: 0.446,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.02045421),
        dec: Angle.Degrees(-00.73571741)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 63.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26213",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36954"},
        {"Hipparcos Number", "HIP 26213"},
        {"Celescope Catalog", "CEL 823"},
        {"Geneva Identification System", "GEN# +9.00040021"},
        {"Smithsonian Astrophysical Observation", "SAO 132305"},
        {"Wilson Evans Batten Catalogue", "WEB 5119"},
    },
    visualMagnitude: 6.97,
    bvColour: -0.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.80327820),
        dec: Angle.Degrees(-00.73535811)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112319",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215402"},
        {"Hipparcos Number", "HIP 112319"},
        {"Geneva Identification System", "GEN# +1.00215402"},
        {"Smithsonian Astrophysical Observation", "SAO 146292"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.534,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(341.25124843),
        dec: Angle.Degrees(-00.73194434)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 127.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 21.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93063",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 93063"},
    },
    visualMagnitude: 11.16,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.35111733),
        dec: Angle.Degrees(-00.73022286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45600"},
        {"Hipparcos Number", "HIP 30806"},
        {"Geneva Identification System", "GEN# +1.00045600"},
        {"Smithsonian Astrophysical Observation", "SAO 133298"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.08483038),
        dec: Angle.Degrees(-00.72939037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63803",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113564"},
        {"Hipparcos Number", "HIP 63803"},
        {"Geneva Identification System", "GEN# +1.00113564"},
        {"Smithsonian Astrophysical Observation", "SAO 139139"},
    },
    visualMagnitude: 7.21,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.16052480),
        dec: Angle.Degrees(-00.72826200)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72760"},
        {"Hipparcos Number", "HIP 42074"},
        {"Geneva Identification System", "GEN# +1.00072760"},
        {"Smithsonian Astrophysical Observation", "SAO 136057"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.791,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.63234578),
        dec: Angle.Degrees(-00.72612364)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -194.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45654"},
        {"Hipparcos Number", "HIP 30838"},
        {"Geneva Identification System", "GEN# +1.00045654"},
        {"Smithsonian Astrophysical Observation", "SAO 133307"},
    },
    visualMagnitude: 6.80,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.15924610),
        dec: Angle.Degrees(-00.72108177)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212189"},
        {"Hipparcos Number", "HIP 110461"},
    },
    visualMagnitude: 10.11,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.62158083),
        dec: Angle.Degrees(-00.71987541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18974",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25608"},
        {"Hipparcos Number", "HIP 18974"},
        {"Smithsonian Astrophysical Observation", "SAO 130906"},
    },
    visualMagnitude: 9.37,
    bvColour: 0.448,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.97953676),
        dec: Angle.Degrees(-00.71951872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65360",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8884 AB"},
        {"Henry Draper", "HD 116444"},
        {"Hipparcos Number", "HIP 65360"},
        {"Geneva Identification System", "GEN# +1.00116444"},
        {"Smithsonian Astrophysical Observation", "SAO 139313"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.92996756),
        dec: Angle.Degrees(-00.71912940)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13837",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13837"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.53432946),
        dec: Angle.Degrees(-00.71846230)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32398",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48922"},
        {"Hipparcos Number", "HIP 32398"},
        {"Geneva Identification System", "GEN# +1.00048922"},
        {"Smithsonian Astrophysical Observation", "SAO 133645"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.025,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.45857145),
        dec: Angle.Degrees(-00.71644883)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214577"},
        {"Hipparcos Number", "HIP 111844"},
        {"Smithsonian Astrophysical Observation", "SAO 146223"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.81842577),
        dec: Angle.Degrees(-00.71587070)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 204950"},
        {"Hipparcos Number", "HIP 106324"},
    },
    visualMagnitude: 9.78,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(323.02104001),
        dec: Angle.Degrees(-00.71516990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93519",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11971 BC"},
        {"Henry Draper", "HD 176983"},
        {"Hipparcos Number", "HIP 93519"},
        {"Geneva Identification System", "GEN# +1.00176983"},
        {"Smithsonian Astrophysical Observation", "SAO 142957"},
        {"Wilson Evans Batten Catalogue", "WEB 16239"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.723,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.69227866),
        dec: Angle.Degrees(-00.71163414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93518",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11971 A"},
        {"Henry Draper", "HD 176982"},
        {"Hipparcos Number", "HIP 93518"},
        {"Geneva Identification System", "GEN# +1.00176982J"},
        {"Smithsonian Astrophysical Observation", "SAO 142955"},
        {"Wilson Evans Batten Catalogue", "WEB 16235"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.68505833),
        dec: Angle.Degrees(-00.71091795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -129.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14825",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19835"},
        {"Hipparcos Number", "HIP 14825"},
        {"Smithsonian Astrophysical Observation", "SAO 130331"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.85333672),
        dec: Angle.Degrees(-00.70925518)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98844",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190299"},
        {"Hipparcos Number", "HIP 98844"},
        {"Geneva Identification System", "GEN# +1.00190299"},
        {"Smithsonian Astrophysical Observation", "SAO 144045"},
        {"Wilson Evans Batten Catalogue", "WEB 17536"},
    },
    visualMagnitude: 5.67,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.09647111),
        dec: Angle.Degrees(-00.70902114)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65860"},
        {"Hipparcos Number", "HIP 39175"},
        {"Smithsonian Astrophysical Observation", "SAO 135367"},
    },
    visualMagnitude: 9.52,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.19004585),
        dec: Angle.Degrees(-00.70805154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117018",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222754"},
        {"Hipparcos Number", "HIP 117018"},
        {"Geneva Identification System", "GEN# +1.00222754"},
        {"Smithsonian Astrophysical Observation", "SAO 146862"},
    },
    visualMagnitude: 7.95,
    bvColour: 1.012,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.82788926),
        dec: Angle.Degrees(-00.70805116)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80273",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147644"},
        {"Hipparcos Number", "HIP 80273"},
        {"Geneva Identification System", "GEN# +1.00147644"},
        {"Smithsonian Astrophysical Observation", "SAO 141138"},
        {"Wilson Evans Batten Catalogue", "WEB 13586"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.572,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78962491),
        dec: Angle.Degrees(-00.70757634)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -111.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71021",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71021"},
    },
    visualMagnitude: 11.16,
    bvColour: 0.980,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.88019060),
        dec: Angle.Degrees(-00.70452823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -83.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -197.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199104"},
        {"Hipparcos Number", "HIP 103238"},
        {"Geneva Identification System", "GEN# +1.00199104"},
        {"Smithsonian Astrophysical Observation", "SAO 144936"},
    },
    visualMagnitude: 8.24,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.73127120),
        dec: Angle.Degrees(-00.70300508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37422"},
        {"Smithsonian Astrophysical Observation", "SAO 134973"},
    },
    visualMagnitude: 8.64,
    bvColour: 1.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.22928154),
        dec: Angle.Degrees(-00.70230910)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14289"},
    },
    visualMagnitude: 9.86,
    bvColour: 0.360,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.05347428),
        dec: Angle.Degrees(-00.69866950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23363",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32219"},
        {"Hipparcos Number", "HIP 23363"},
        {"Geneva Identification System", "GEN# +1.00032219"},
        {"Renson", "Renson 8213"},
        {"Smithsonian Astrophysical Observation", "SAO 131697"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.35687645),
        dec: Angle.Degrees(-00.69684599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97233",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186641"},
        {"Hipparcos Number", "HIP 97233"},
        {"Geneva Identification System", "GEN# +1.00186641"},
        {"Smithsonian Astrophysical Observation", "SAO 143775"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.996,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.42189668),
        dec: Angle.Degrees(-00.69651699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 33.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -52.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178918"},
        {"Hipparcos Number", "HIP 94193"},
        {"Smithsonian Astrophysical Observation", "SAO 143101"},
    },
    visualMagnitude: 7.81,
    bvColour: 1.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.64459958),
        dec: Angle.Degrees(-00.69570395)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12530",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2046 AB"},
        {"Henry Draper", "HD 16765"},
        {"Hipparcos Number", "HIP 12530"},
        {"Geneva Identification System", "GEN# +1.00016765"},
        {"Smithsonian Astrophysical Observation", "SAO 130055"},
        {"Wilson Evans Batten Catalogue", "WEB 2561"},
    },
    visualMagnitude: 5.72,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.30779517),
        dec: Angle.Degrees(-00.69534847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 218.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -125.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70566",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126516"},
        {"Hipparcos Number", "HIP 70566"},
        {"Geneva Identification System", "GEN# +1.00126516"},
        {"Smithsonian Astrophysical Observation", "SAO 139927"},
        {"Wilson Evans Batten Catalogue", "WEB 12237"},
    },
    visualMagnitude: 8.29,
    bvColour: 0.456,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.51294269),
        dec: Angle.Degrees(-00.69168703)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38915",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 38915"},
    },
    visualMagnitude: 12.52,
    bvColour: 2.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.46266914),
        dec: Angle.Degrees(-00.68944606)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79356",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79356"},
    },
    visualMagnitude: 10.94,
    bvColour: 0.693,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.94631419),
        dec: Angle.Degrees(-00.68826017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13260",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13260"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.576,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.65352195),
        dec: Angle.Degrees(-00.68804022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13321",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17797"},
        {"Hipparcos Number", "HIP 13321"},
        {"Fundamental Katalog 5th Edition", "FK5 4263"},
        {"Smithsonian Astrophysical Observation", "SAO 130148"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.86183044),
        dec: Angle.Degrees(-00.68791051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187901"},
        {"Hipparcos Number", "HIP 97800"},
        {"Smithsonian Astrophysical Observation", "SAO 143869"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.10292667),
        dec: Angle.Degrees(-00.68735302)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17451",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17451"},
    },
    visualMagnitude: 10.49,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.11181616),
        dec: Angle.Degrees(-00.68723065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184066"},
        {"Hipparcos Number", "HIP 96127"},
        {"Smithsonian Astrophysical Observation", "SAO 143522"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.17847304),
        dec: Angle.Degrees(-00.68402692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40686"},
        {"Hipparcos Number", "HIP 28449"},
        {"Geneva Identification System", "GEN# +1.00040686"},
        {"Smithsonian Astrophysical Observation", "SAO 132736"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.047,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.10391479),
        dec: Angle.Degrees(-00.68381936)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13984",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18668"},
        {"Hipparcos Number", "HIP 13984"},
        {"Smithsonian Astrophysical Observation", "SAO 130232"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.477,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.02546869),
        dec: Angle.Degrees(-00.68239377)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139227"},
        {"Hipparcos Number", "HIP 76468"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.25575392),
        dec: Angle.Degrees(-00.68217213)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31707",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 47296"},
        {"Hipparcos Number", "HIP 31707"},
        {"Geneva Identification System", "GEN# +1.00047296"},
        {"Smithsonian Astrophysical Observation", "SAO 133497"},
    },
    visualMagnitude: 8.23,
    bvColour: -0.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(099.48488493),
        dec: Angle.Degrees(-00.68208420)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27510",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39000"},
        {"Hipparcos Number", "HIP 27510"},
        {"Celescope Catalog", "CEL 996"},
        {"Geneva Identification System", "GEN# +1.00039000"},
        {"Smithsonian Astrophysical Observation", "SAO 132570"},
    },
    visualMagnitude: 7.62,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.38606063),
        dec: Angle.Degrees(-00.68185225)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54272",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8055 AB"},
        {"Hipparcos Number", "HIP 54272"},
    },
    visualMagnitude: 9.48,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.53566409),
        dec: Angle.Degrees(-00.68025231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208477"},
        {"Hipparcos Number", "HIP 108299"},
        {"Geneva Identification System", "GEN# +1.00208477"},
        {"Smithsonian Astrophysical Observation", "SAO 145762"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.10711723),
        dec: Angle.Degrees(-00.67987139)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18645"},
        {"Hipparcos Number", "HIP 13968"},
        {"Geneva Identification System", "GEN# +1.00018645"},
        {"Smithsonian Astrophysical Observation", "SAO 130230"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.808,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.97156361),
        dec: Angle.Degrees(-00.67965280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44265",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44265"},
        {"Smithsonian Astrophysical Observation", "SAO 136488"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.957,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.21190220),
        dec: Angle.Degrees(-00.67963207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87290",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162249"},
        {"Hipparcos Number", "HIP 87290"},
        {"Geneva Identification System", "GEN# +1.00162249"},
        {"Smithsonian Astrophysical Observation", "SAO 141900"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(267.53876048),
        dec: Angle.Degrees(-00.67893784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99171",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191067"},
        {"Hipparcos Number", "HIP 99171"},
        {"Geneva Identification System", "GEN# +1.00191067"},
        {"Smithsonian Astrophysical Observation", "SAO 144095"},
        {"Wilson Evans Batten Catalogue", "WEB 17652"},
    },
    visualMagnitude: 5.97,
    bvColour: 1.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.00731244),
        dec: Angle.Degrees(-00.67802026)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 116.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 160743"},
        {"Hipparcos Number", "HIP 86582"},
        {"Smithsonian Astrophysical Observation", "SAO 141812"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.193,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(265.41397721),
        dec: Angle.Degrees(-00.67721442)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12476"},
        {"Smithsonian Astrophysical Observation", "SAO 130049"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.15245096),
        dec: Angle.Degrees(-00.67669614)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64838",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 115488"},
        {"Hipparcos Number", "HIP 64838"},
        {"Geneva Identification System", "GEN# +1.00115488"},
        {"Renson", "Renson 33360"},
        {"Smithsonian Astrophysical Observation", "SAO 139264"},
    },
    visualMagnitude: 6.36,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.37455403),
        dec: Angle.Degrees(-00.67604128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -68.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186551"},
        {"Hipparcos Number", "HIP 97187"},
        {"Smithsonian Astrophysical Observation", "SAO 143764"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.001,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.30008087),
        dec: Angle.Degrees(-00.67543336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195994"},
        {"Hipparcos Number", "HIP 101532"},
        {"Geneva Identification System", "GEN# +1.00195994"},
        {"Smithsonian Astrophysical Observation", "SAO 144580"},
    },
    visualMagnitude: 7.61,
    bvColour: 1.036,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.64163319),
        dec: Angle.Degrees(-00.67479549)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4619",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 819 AB"},
        {"Henry Draper", "HD 5781"},
        {"Hipparcos Number", "HIP 4619"},
        {"Geneva Identification System", "GEN# +1.00005781J"},
        {"Smithsonian Astrophysical Observation", "SAO 129063"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.83529281),
        dec: Angle.Degrees(-00.67452887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 101514"},
        {"Hipparcos Number", "HIP 56988"},
        {"Geneva Identification System", "GEN# +1.00101514"},
        {"Smithsonian Astrophysical Observation", "SAO 138346"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.23287144),
        dec: Angle.Degrees(-00.67427990)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171330"},
        {"Hipparcos Number", "HIP 91044"},
        {"Geneva Identification System", "GEN# +1.00171330"},
        {"Smithsonian Astrophysical Observation", "SAO 142397"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.58436112),
        dec: Angle.Degrees(-00.67373357)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33786",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5690 A"},
        {"Henry Draper", "HD 52379"},
        {"Hipparcos Number", "HIP 33786"},
        {"Smithsonian Astrophysical Observation", "SAO 134045"},
    },
    visualMagnitude: 7.25,
    bvColour: 0.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.23377255),
        dec: Angle.Degrees(-00.66920975)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52277",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52277"},
        {"Smithsonian Astrophysical Observation", "SAO 137722"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.23684439),
        dec: Angle.Degrees(-00.66905795)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60129",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Zaniah"},
        {"Aitken", "ADS 4689"},
        {"Henry Draper", "HD 107259"},
        {"Hipparcos Number", "HIP 60129"},
        {"Fundamental Katalog 5th Edition", "FK5 460"},
        {"Geneva Identification System", "GEN# +1.00107259"},
        {"Renson", "Renson 31060"},
        {"Smithsonian Astrophysical Observation", "SAO 138721"},
        {"Wilson Evans Batten Catalogue", "WEB 10691"},
    },
    visualMagnitude: 3.89,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(184.97663096),
        dec: Angle.Degrees(-00.66674709)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111059",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213213"},
        {"Hipparcos Number", "HIP 111059"},
        {"Smithsonian Astrophysical Observation", "SAO 146123"},
    },
    visualMagnitude: 8.78,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.47287123),
        dec: Angle.Degrees(-00.66595578)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24144",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290006"},
        {"Hipparcos Number", "HIP 24144"},
        {"Geneva Identification System", "GEN# +1.00290006"},
    },
    visualMagnitude: 10.62,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.77573780),
        dec: Angle.Degrees(-00.66161513)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59733",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106497"},
        {"Hipparcos Number", "HIP 59733"},
        {"Smithsonian Astrophysical Observation", "SAO 138671"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.903,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.75123008),
        dec: Angle.Degrees(-00.66091209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19114",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25870"},
        {"Hipparcos Number", "HIP 19114"},
        {"Smithsonian Astrophysical Observation", "SAO 130946"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.47460714),
        dec: Angle.Degrees(-00.66084269)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117151",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222928"},
        {"Hipparcos Number", "HIP 117151"},
        {"Smithsonian Astrophysical Observation", "SAO 146885"},
        {"Wilson Evans Batten Catalogue", "WEB 20648"},
    },
    visualMagnitude: 7.07,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(356.25019572),
        dec: Angle.Degrees(-00.66033920)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43445",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75596"},
        {"Hipparcos Number", "HIP 43445"},
        {"Geneva Identification System", "GEN# +1.00075596"},
        {"Smithsonian Astrophysical Observation", "SAO 136333"},
        {"Wilson Evans Batten Catalogue", "WEB 8372"},
    },
    visualMagnitude: 8.63,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(132.72965177),
        dec: Angle.Degrees(-00.65954188)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -174.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89117",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166562"},
        {"Hipparcos Number", "HIP 89117"},
        {"Geneva Identification System", "GEN# +1.00166562"},
        {"Smithsonian Astrophysical Observation", "SAO 142139"},
    },
    visualMagnitude: 7.46,
    bvColour: 1.183,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.81845551),
        dec: Angle.Degrees(-00.65898589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210987"},
        {"Hipparcos Number", "HIP 109777"},
        {"Smithsonian Astrophysical Observation", "SAO 145956"},
    },
    visualMagnitude: 9.49,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.53682136),
        dec: Angle.Degrees(-00.65861426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43995",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76646"},
        {"Hipparcos Number", "HIP 43995"},
        {"Geneva Identification System", "GEN# +1.00076646"},
        {"Smithsonian Astrophysical Observation", "SAO 136439"},
        {"Wilson Evans Batten Catalogue", "WEB 8455"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.381,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.38212585),
        dec: Angle.Degrees(-00.65774061)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100133",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100133"},
    },
    visualMagnitude: 11.01,
    bvColour: 1.430,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.69134866),
        dec: Angle.Degrees(-00.65712214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -207.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -67.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18109",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24336"},
        {"Hipparcos Number", "HIP 18109"},
        {"Fundamental Katalog 5th Edition", "FK5 4351"},
        {"Geneva Identification System", "GEN# +1.00024336"},
        {"Smithsonian Astrophysical Observation", "SAO 130784"},
    },
    visualMagnitude: 6.82,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.07118191),
        dec: Angle.Degrees(-00.65561414)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 47.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71869",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129313"},
        {"Hipparcos Number", "HIP 71869"},
        {"Geneva Identification System", "GEN# +1.00129313"},
        {"Smithsonian Astrophysical Observation", "SAO 140083"},
    },
    visualMagnitude: 9.26,
    bvColour: 0.410,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.49741945),
        dec: Angle.Degrees(-00.65162156)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69190",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123825"},
        {"Hipparcos Number", "HIP 69190"},
        {"Geneva Identification System", "GEN# +1.00123825"},
        {"Smithsonian Astrophysical Observation", "SAO 139765"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.47425052),
        dec: Angle.Degrees(-00.65130146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10142",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10142"},
    },
    visualMagnitude: 10.52,
    bvColour: 0.537,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.61698988),
        dec: Angle.Degrees(-00.65051646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45768",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80477"},
        {"Hipparcos Number", "HIP 45768"},
        {"Smithsonian Astrophysical Observation", "SAO 136762"},
    },
    visualMagnitude: 8.57,
    bvColour: 1.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.99152239),
        dec: Angle.Degrees(-00.65036030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17873"},
        {"Hipparcos Number", "HIP 13379"},
        {"Geneva Identification System", "GEN# +1.00017873"},
        {"Smithsonian Astrophysical Observation", "SAO 130155"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.145,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.04857469),
        dec: Angle.Degrees(-00.65029366)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23575",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32564"},
        {"Hipparcos Number", "HIP 23575"},
        {"Geneva Identification System", "GEN# +1.00032564"},
        {"Smithsonian Astrophysical Observation", "SAO 131734"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.741,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(076.02587930),
        dec: Angle.Degrees(-00.64870676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -143.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193353"},
        {"Hipparcos Number", "HIP 100247"},
        {"Geneva Identification System", "GEN# +1.00193353"},
        {"Smithsonian Astrophysical Observation", "SAO 144306"},
        {"Wilson Evans Batten Catalogue", "WEB 18069"},
    },
    visualMagnitude: 7.38,
    bvColour: 1.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.96981418),
        dec: Angle.Degrees(-00.64557905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21294"},
        {"Hipparcos Number", "HIP 16000"},
        {"Smithsonian Astrophysical Observation", "SAO 130484"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.51791755),
        dec: Angle.Degrees(-00.64392572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 34.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86463",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10696 AB"},
        {"Henry Draper", "HD 160438"},
        {"Hipparcos Number", "HIP 86463"},
        {"Smithsonian Astrophysical Observation", "SAO 141795"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.99042618),
        dec: Angle.Degrees(-00.63921294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 106316"},
        {"Hipparcos Number", "HIP 59641"},
        {"Smithsonian Astrophysical Observation", "SAO 138658"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(183.47012452),
        dec: Angle.Degrees(-00.63911611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146231"},
        {"Hipparcos Number", "HIP 79654"},
        {"Smithsonian Astrophysical Observation", "SAO 141064"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.81534855),
        dec: Angle.Degrees(-00.63831835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125981"},
        {"Hipparcos Number", "HIP 70282"},
        {"Fundamental Katalog 5th Edition", "FK5 5270"},
        {"Geneva Identification System", "GEN# +1.00125981"},
        {"Smithsonian Astrophysical Observation", "SAO 139902"},
    },
    visualMagnitude: 6.74,
    bvColour: 0.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(215.69343451),
        dec: Angle.Degrees(-00.63709953)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51437",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90994"},
        {"Hipparcos Number", "HIP 51437"},
        {"Fundamental Katalog 5th Edition", "FK5 2841"},
        {"Geneva Identification System", "GEN# +1.00090994"},
        {"Renson", "Renson 26165"},
        {"Smithsonian Astrophysical Observation", "SAO 137608"},
        {"Wilson Evans Batten Catalogue", "WEB 9388"},
    },
    visualMagnitude: 5.08,
    bvColour: -0.138,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.57292935),
        dec: Angle.Degrees(-00.63697208)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50005",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50005"},
    },
    visualMagnitude: 10.25,
    bvColour: 0.679,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.12401107),
        dec: Angle.Degrees(-00.63644978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 187.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -266.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38885",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65158"},
        {"Hipparcos Number", "HIP 38885"},
        {"Geneva Identification System", "GEN# +1.00065158"},
        {"Smithsonian Astrophysical Observation", "SAO 135292"},
        {"Wilson Evans Batten Catalogue", "WEB 7616"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.35779863),
        dec: Angle.Degrees(-00.63585185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55438",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 55438"},
        {"Smithsonian Astrophysical Observation", "SAO 138150"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.609,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.28776828),
        dec: Angle.Degrees(-00.63044047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 139.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -119.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36495",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 36495"},
        {"Smithsonian Astrophysical Observation", "SAO 134766"},
    },
    visualMagnitude: 8.82,
    bvColour: 1.828,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(112.62811991),
        dec: Angle.Degrees(-00.63026583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 105264"},
        {"Hipparcos Number", "HIP 59102"},
        {"Smithsonian Astrophysical Observation", "SAO 138591"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.79769775),
        dec: Angle.Degrees(-00.62995865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108406",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15488 AB"},
        {"Henry Draper", "HD 208643"},
        {"Hipparcos Number", "HIP 108406"},
        {"Smithsonian Astrophysical Observation", "SAO 145771"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.661,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.42190795),
        dec: Angle.Degrees(-00.62878115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68668",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122699"},
        {"Hipparcos Number", "HIP 68668"},
        {"Geneva Identification System", "GEN# +1.00122699"},
        {"Smithsonian Astrophysical Observation", "SAO 139702"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.85310981),
        dec: Angle.Degrees(-00.62801904)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13946",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18617"},
        {"Hipparcos Number", "HIP 13946"},
        {"Geneva Identification System", "GEN# +1.00018617"},
        {"Smithsonian Astrophysical Observation", "SAO 130225"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.90803188),
        dec: Angle.Degrees(-00.62722693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44116",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76910"},
        {"Hipparcos Number", "HIP 44116"},
        {"Geneva Identification System", "GEN# +1.00076910"},
        {"Smithsonian Astrophysical Observation", "SAO 136462"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.77474656),
        dec: Angle.Degrees(-00.62384354)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 76.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202532"},
        {"Hipparcos Number", "HIP 105040"},
        {"Geneva Identification System", "GEN# +1.00202532"},
        {"Smithsonian Astrophysical Observation", "SAO 145257"},
    },
    visualMagnitude: 7.31,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.14357648),
        dec: Angle.Degrees(-00.62169231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96807",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12775 A"},
        {"Henry Draper", "HD 185762"},
        {"Hipparcos Number", "HIP 96807"},
        {"Fundamental Katalog 5th Edition", "FK5 3573"},
        {"Geneva Identification System", "GEN# +1.00185762A"},
        {"Smithsonian Astrophysical Observation", "SAO 143678"},
        {"Wilson Evans Batten Catalogue", "WEB 16985"},
    },
    visualMagnitude: 5.64,
    bvColour: 0.123,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.18047034),
        dec: Angle.Degrees(-00.62129280)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110281"},
        {"Hipparcos Number", "HIP 61899"},
        {"Geneva Identification System", "GEN# +1.00110281"},
        {"Smithsonian Astrophysical Observation", "SAO 138910"},
    },
    visualMagnitude: 9.37,
    bvColour: 1.585,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.26506583),
        dec: Angle.Degrees(-00.62042543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27073",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290839"},
        {"Hipparcos Number", "HIP 27073"},
    },
    visualMagnitude: 9.81,
    bvColour: 0.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.11709420),
        dec: Angle.Degrees(-00.61865121)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48000",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84703"},
        {"Hipparcos Number", "HIP 48000"},
        {"Geneva Identification System", "GEN# +1.00084703"},
        {"Smithsonian Astrophysical Observation", "SAO 137125"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.564,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.77030885),
        dec: Angle.Degrees(-00.61860394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64247",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114360"},
        {"Hipparcos Number", "HIP 64247"},
        {"Smithsonian Astrophysical Observation", "SAO 139191"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.549,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.51715451),
        dec: Angle.Degrees(-00.61674067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -63.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13043"},
        {"Hipparcos Number", "HIP 9911"},
        {"Cincinnati Publication", "Ci 20 147"},
        {"Geneva Identification System", "GEN# +1.00013043A"},
        {"Smithsonian Astrophysical Observation", "SAO 129706"},
        {"Wilson Evans Batten Catalogue", "WEB 2078"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.89341053),
        dec: Angle.Degrees(-00.61658189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -249.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -344.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81990",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151046"},
        {"Hipparcos Number", "HIP 81990"},
        {"Smithsonian Astrophysical Observation", "SAO 141343"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.677,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.24933627),
        dec: Angle.Degrees(-00.61469387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137742"},
        {"Hipparcos Number", "HIP 75688"},
        {"Smithsonian Astrophysical Observation", "SAO 140547"},
    },
    visualMagnitude: 8.49,
    bvColour: 0.293,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.94032778),
        dec: Angle.Degrees(-00.61446261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43693",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 76082"},
        {"Hipparcos Number", "HIP 43693"},
        {"Geneva Identification System", "GEN# +1.00076082"},
        {"Smithsonian Astrophysical Observation", "SAO 136381"},
        {"Wilson Evans Batten Catalogue", "WEB 8412"},
    },
    visualMagnitude: 8.41,
    bvColour: 1.118,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.49505828),
        dec: Angle.Degrees(-00.61199353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79170",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79170"},
        {"Geneva Identification System", "GEN# -0.00003060"},
    },
    visualMagnitude: 10.65,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(242.37901959),
        dec: Angle.Degrees(-00.60920100)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3024"},
        {"Hipparcos Number", "HIP 2641"},
        {"Geneva Identification System", "GEN# +1.00003024"},
        {"Renson", "Renson 790"},
        {"Smithsonian Astrophysical Observation", "SAO 128823"},
    },
    visualMagnitude: 7.18,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.37143894),
        dec: Angle.Degrees(-00.60875174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23903",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33124"},
        {"Hipparcos Number", "HIP 23903"},
        {"Smithsonian Astrophysical Observation", "SAO 131798"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.343,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.03103673),
        dec: Angle.Degrees(-00.60836163)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45643",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80164"},
        {"Hipparcos Number", "HIP 45643"},
        {"Smithsonian Astrophysical Observation", "SAO 136741"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.55262525),
        dec: Angle.Degrees(-00.60777383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98694",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 189962"},
        {"Hipparcos Number", "HIP 98694"},
        {"Smithsonian Astrophysical Observation", "SAO 144019"},
    },
    visualMagnitude: 8.39,
    bvColour: 1.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.68700006),
        dec: Angle.Degrees(-00.60659128)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207611"},
        {"Hipparcos Number", "HIP 107799"},
        {"Geneva Identification System", "GEN# +1.00207611"},
        {"Smithsonian Astrophysical Observation", "SAO 145696"},
    },
    visualMagnitude: 7.73,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(327.55867144),
        dec: Angle.Degrees(-00.60592543)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -106.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36046"},
        {"Hipparcos Number", "HIP 25664"},
        {"Geneva Identification System", "GEN# +1.00036046"},
        {"Renson", "Renson 9290"},
        {"Smithsonian Astrophysical Observation", "SAO 132155"},
    },
    visualMagnitude: 8.06,
    bvColour: -0.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.21911488),
        dec: Angle.Degrees(-00.60306315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41143"},
        {"Hipparcos Number", "HIP 28672"},
        {"Geneva Identification System", "GEN# +1.00041143"},
        {"Smithsonian Astrophysical Observation", "SAO 132778"},
    },
    visualMagnitude: 7.75,
    bvColour: 1.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.81107798),
        dec: Angle.Degrees(-00.60174002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69567",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69567"},
        {"Smithsonian Astrophysical Observation", "SAO 139807"},
    },
    visualMagnitude: 9.27,
    bvColour: 0.990,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.59468036),
        dec: Angle.Degrees(-00.60119180)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45644",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 45644"},
    },
    visualMagnitude: 10.02,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.55709993),
        dec: Angle.Degrees(-00.60073459)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12995",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12995"},
    },
    visualMagnitude: 10.59,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.77398835),
        dec: Angle.Degrees(-00.59983327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113773",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217680"},
        {"Hipparcos Number", "HIP 113773"},
        {"Smithsonian Astrophysical Observation", "SAO 146464"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.61084259),
        dec: Angle.Degrees(-00.59792351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211787"},
        {"Hipparcos Number", "HIP 110224"},
        {"Geneva Identification System", "GEN# +1.00211787"},
        {"Smithsonian Astrophysical Observation", "SAO 146018"},
    },
    visualMagnitude: 9.00,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.91054121),
        dec: Angle.Degrees(-00.59785613)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159504"},
        {"Hipparcos Number", "HIP 86046"},
        {"Smithsonian Astrophysical Observation", "SAO 141745"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.77583092),
        dec: Angle.Degrees(-00.59734659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221307"},
        {"Hipparcos Number", "HIP 116062"},
        {"Smithsonian Astrophysical Observation", "SAO 146749"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.75754671),
        dec: Angle.Degrees(-00.59599617)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66249",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Heze"},
        {"Henry Draper", "HD 118098"},
        {"Hipparcos Number", "HIP 66249"},
        {"Fundamental Katalog 5th Edition", "FK5 501"},
        {"Geneva Identification System", "GEN# +1.00118098"},
        {"Smithsonian Astrophysical Observation", "SAO 139420"},
        {"Wilson Evans Batten Catalogue", "WEB 11707"},
    },
    visualMagnitude: 3.38,
    bvColour: 0.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.67397800),
        dec: Angle.Degrees(-00.59593821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -278.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120166"},
        {"Hipparcos Number", "HIP 67313"},
        {"Geneva Identification System", "GEN# +1.00120166"},
        {"Renson", "Renson 34656"},
        {"Smithsonian Astrophysical Observation", "SAO 139552"},
        {"Wilson Evans Batten Catalogue", "WEB 11846"},
    },
    visualMagnitude: 10.03,
    bvColour: 0.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.96915075),
        dec: Angle.Degrees(-00.59464983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94449",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179626"},
        {"Hipparcos Number", "HIP 94449"},
        {"Cincinnati Publication", "Ci 20 1137"},
        {"Cincinnati Publication 2", "Ci 18 2509"},
        {"Geneva Identification System", "GEN# +1.00179626"},
        {"Wilson Evans Batten Catalogue", "WEB 16460"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.33709826),
        dec: Angle.Degrees(-00.59400348)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -314.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -447.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77756",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 77756"},
    },
    visualMagnitude: 10.46,
    bvColour: 0.700,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.15250936),
        dec: Angle.Degrees(-00.59371721)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5245",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6639"},
        {"Hipparcos Number", "HIP 5245"},
        {"Smithsonian Astrophysical Observation", "SAO 129127"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.840,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.76882116),
        dec: Angle.Degrees(-00.59202228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42422",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42422"},
    },
    visualMagnitude: 10.07,
    bvColour: 1.149,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.75787308),
        dec: Angle.Degrees(-00.59151731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21935",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29936"},
        {"Hipparcos Number", "HIP 21935"},
        {"Geneva Identification System", "GEN# +1.00029936"},
        {"Smithsonian Astrophysical Observation", "SAO 131424"},
        {"Wilson Evans Batten Catalogue", "WEB 4213"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.73632551),
        dec: Angle.Degrees(-00.59010470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 95.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14424",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 14424"},
        {"Smithsonian Astrophysical Observation", "SAO 130281"},
    },
    visualMagnitude: 9.97,
    bvColour: 0.692,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.55169700),
        dec: Angle.Degrees(-00.58912432)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6202",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 6202"},
        {"Smithsonian Astrophysical Observation", "SAO 129231"},
    },
    visualMagnitude: 9.60,
    bvColour: 0.497,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.88194176),
        dec: Angle.Degrees(-00.58905625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 163913"},
        {"Hipparcos Number", "HIP 88014"},
        {"Smithsonian Astrophysical Observation", "SAO 141999"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.66467536),
        dec: Angle.Degrees(-00.58187109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77280"},
        {"Hipparcos Number", "HIP 44326"},
        {"Geneva Identification System", "GEN# +1.00077280"},
        {"Smithsonian Astrophysical Observation", "SAO 136504"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.41063741),
        dec: Angle.Degrees(-00.58135793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108638",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108638"},
        {"Smithsonian Astrophysical Observation", "SAO 145801"},
    },
    visualMagnitude: 9.78,
    bvColour: 1.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.13269737),
        dec: Angle.Degrees(-00.57896623)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65261",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116258"},
        {"Hipparcos Number", "HIP 65261"},
        {"Smithsonian Astrophysical Observation", "SAO 139303"},
    },
    visualMagnitude: 8.22,
    bvColour: 0.849,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.62012692),
        dec: Angle.Degrees(-00.57880345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100975"},
        {"Hipparcos Number", "HIP 56676"},
        {"Geneva Identification System", "GEN# +1.00100975"},
        {"Smithsonian Astrophysical Observation", "SAO 138302"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.129,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(174.31986224),
        dec: Angle.Degrees(-00.57803258)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216180"},
        {"Hipparcos Number", "HIP 112807"},
        {"Fundamental Katalog 5th Edition", "FK5 6015"},
        {"Geneva Identification System", "GEN# +1.00216180"},
        {"Smithsonian Astrophysical Observation", "SAO 146346"},
    },
    visualMagnitude: 7.47,
    bvColour: 0.206,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.67684600),
        dec: Angle.Degrees(-00.57780804)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66353",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118290"},
        {"Hipparcos Number", "HIP 66353"},
        {"Geneva Identification System", "GEN# +1.00118290"},
        {"Smithsonian Astrophysical Observation", "SAO 139435"},
    },
    visualMagnitude: 8.33,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.99802990),
        dec: Angle.Degrees(-00.57761663)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50385",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 50385"},
    },
    visualMagnitude: 11.51,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.31263116),
        dec: Angle.Degrees(-00.57514579)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -140.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13766",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2237 A"},
        {"Henry Draper", "HD 18384"},
        {"Hipparcos Number", "HIP 13766"},
        {"Smithsonian Astrophysical Observation", "SAO 130205"},
        {"Wilson Evans Batten Catalogue", "WEB 2726"},
    },
    visualMagnitude: 7.16,
    bvColour: 0.908,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(044.29424194),
        dec: Angle.Degrees(-00.57457475)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66950"},
        {"Hipparcos Number", "HIP 39625"},
        {"Geneva Identification System", "GEN# +1.00066950"},
        {"Smithsonian Astrophysical Observation", "SAO 135488"},
    },
    visualMagnitude: 6.40,
    bvColour: 1.058,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.45683895),
        dec: Angle.Degrees(-00.57332266)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10605"},
        {"Hipparcos Number", "HIP 8053"},
        {"Geneva Identification System", "GEN# +1.00010605"},
        {"Smithsonian Astrophysical Observation", "SAO 129470"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.105,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.84428429),
        dec: Angle.Degrees(-00.57246130)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30863",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45674"},
        {"Hipparcos Number", "HIP 30863"},
        {"Geneva Identification System", "GEN# +1.00045674"},
        {"Smithsonian Astrophysical Observation", "SAO 133312"},
    },
    visualMagnitude: 6.52,
    bvColour: 0.784,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.19609935),
        dec: Angle.Degrees(-00.57240664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27063"},
        {"Hipparcos Number", "HIP 19925"},
        {"Geneva Identification System", "GEN# +1.00027063"},
        {"Smithsonian Astrophysical Observation", "SAO 131080"},
    },
    visualMagnitude: 8.07,
    bvColour: 0.669,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(064.12615448),
        dec: Angle.Degrees(-00.57238523)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -172.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175038"},
        {"Hipparcos Number", "HIP 92716"},
        {"Smithsonian Astrophysical Observation", "SAO 142761"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(283.37928874),
        dec: Angle.Degrees(-00.57052056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25789"},
        {"Hipparcos Number", "HIP 19074"},
        {"Geneva Identification System", "GEN# +1.00025789"},
        {"Smithsonian Astrophysical Observation", "SAO 130934"},
    },
    visualMagnitude: 7.13,
    bvColour: 0.476,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.31684202),
        dec: Angle.Degrees(-00.56893652)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100618",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194164"},
        {"Hipparcos Number", "HIP 100618"},
        {"Smithsonian Astrophysical Observation", "SAO 144384"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.03811965),
        dec: Angle.Degrees(-00.56735143)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212738"},
        {"Hipparcos Number", "HIP 110770"},
        {"Smithsonian Astrophysical Observation", "SAO 146086"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.452,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.62461359),
        dec: Angle.Degrees(-00.56722887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24041",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33419"},
        {"Hipparcos Number", "HIP 24041"},
        {"Geneva Identification System", "GEN# +1.00033419"},
        {"Smithsonian Astrophysical Observation", "SAO 131834"},
    },
    visualMagnitude: 6.11,
    bvColour: 1.098,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.51358512),
        dec: Angle.Degrees(-00.56519928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111598",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214169"},
        {"Hipparcos Number", "HIP 111598"},
        {"Geneva Identification System", "GEN# +1.00214169"},
        {"Smithsonian Astrophysical Observation", "SAO 146194"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.670,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.14088095),
        dec: Angle.Degrees(-00.56463284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -40.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102770",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198272"},
        {"Hipparcos Number", "HIP 102770"},
        {"Fundamental Katalog 5th Edition", "FK5 1545"},
        {"Geneva Identification System", "GEN# +1.00198272"},
        {"Smithsonian Astrophysical Observation", "SAO 144841"},
    },
    visualMagnitude: 6.24,
    bvColour: 1.401,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.32188930),
        dec: Angle.Degrees(-00.56327506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54464",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96742"},
        {"Hipparcos Number", "HIP 54464"},
        {"Smithsonian Astrophysical Observation", "SAO 138009"},
    },
    visualMagnitude: 8.15,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(167.14794176),
        dec: Angle.Degrees(-00.56290328)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24441",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34055"},
        {"Hipparcos Number", "HIP 24441"},
        {"Geneva Identification System", "GEN# +1.00034055"},
        {"Smithsonian Astrophysical Observation", "SAO 131905"},
    },
    visualMagnitude: 6.89,
    bvColour: 1.820,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.65393349),
        dec: Angle.Degrees(-00.56283184)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17757",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2779 AB"},
        {"Henry Draper", "HD 23826"},
        {"Hipparcos Number", "HIP 17757"},
        {"Smithsonian Astrophysical Observation", "SAO 130731"},
    },
    visualMagnitude: 9.39,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.01848593),
        dec: Angle.Degrees(-00.56179140)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76427",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139137"},
        {"Hipparcos Number", "HIP 76427"},
        {"Geneva Identification System", "GEN# +1.00139137"},
        {"Smithsonian Astrophysical Observation", "SAO 140643"},
        {"Wilson Evans Batten Catalogue", "WEB 12977"},
    },
    visualMagnitude: 6.51,
    bvColour: 0.728,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.14051118),
        dec: Angle.Degrees(-00.56147928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81943",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10180 B"},
        {"Hipparcos Number", "HIP 81943"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.631,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07549477),
        dec: Angle.Degrees(-00.56020084)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34843",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55362"},
        {"Hipparcos Number", "HIP 34843"},
        {"Geneva Identification System", "GEN# +1.00055362"},
        {"Smithsonian Astrophysical Observation", "SAO 134349"},
    },
    visualMagnitude: 7.95,
    bvColour: -0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.14963374),
        dec: Angle.Degrees(-00.55949384)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34039",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53083"},
        {"Hipparcos Number", "HIP 34039"},
        {"Geneva Identification System", "GEN# +1.00053083"},
        {"Smithsonian Astrophysical Observation", "SAO 134125"},
    },
    visualMagnitude: 7.20,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.92357318),
        dec: Angle.Degrees(-00.55695346)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81942",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10180 A"},
        {"Henry Draper", "HD 150935"},
        {"Hipparcos Number", "HIP 81942"},
        {"Smithsonian Astrophysical Observation", "SAO 141335"},
    },
    visualMagnitude: 7.41,
    bvColour: 0.181,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.07391400),
        dec: Angle.Degrees(-00.55669654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58105",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 103486"},
        {"Hipparcos Number", "HIP 58105"},
        {"Geneva Identification System", "GEN# +1.00103486"},
        {"Smithsonian Astrophysical Observation", "SAO 138479"},
        {"Wilson Evans Batten Catalogue", "WEB 10402"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(178.75313065),
        dec: Angle.Degrees(-00.55614292)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23102",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31724"},
        {"Hipparcos Number", "HIP 23102"},
        {"Geneva Identification System", "GEN# +1.00031724"},
        {"Smithsonian Astrophysical Observation", "SAO 131641"},
    },
    visualMagnitude: 8.90,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.55663254),
        dec: Angle.Degrees(-00.55571541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105261",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105261"},
    },
    visualMagnitude: 11.57,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(319.82665235),
        dec: Angle.Degrees(-00.55460608)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -247.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -286.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78636",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 78636"},
    },
    visualMagnitude: 9.75,
    bvColour: 0.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.80159637),
        dec: Angle.Degrees(-00.55380031)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20422",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27719"},
        {"Hipparcos Number", "HIP 20422"},
        {"Geneva Identification System", "GEN# +1.00027719"},
        {"Smithsonian Astrophysical Observation", "SAO 131152"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.61687998),
        dec: Angle.Degrees(-00.55182679)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22574",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30898"},
        {"Hipparcos Number", "HIP 22574"},
        {"Geneva Identification System", "GEN# +1.00030898"},
        {"Renson", "Renson 7983"},
        {"Smithsonian Astrophysical Observation", "SAO 131543"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.86820937),
        dec: Angle.Degrees(-00.54662496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22856",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3522 ABC"},
        {"Henry Draper", "HD 31356"},
        {"Hipparcos Number", "HIP 22856"},
        {"Smithsonian Astrophysical Observation", "SAO 131593"},
    },
    visualMagnitude: 8.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.76618239),
        dec: Angle.Degrees(-00.54500198)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75397",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137128"},
        {"Hipparcos Number", "HIP 75397"},
        {"Geneva Identification System", "GEN# +1.00137128"},
        {"Smithsonian Astrophysical Observation", "SAO 140510"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(231.08776033),
        dec: Angle.Degrees(-00.54414284)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -31.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25365",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4020"},
        {"Henry Draper", "HD 35548"},
        {"Hipparcos Number", "HIP 25365"},
        {"Geneva Identification System", "GEN# +1.00035548J"},
        {"Renson", "Renson 9150"},
        {"Smithsonian Astrophysical Observation", "SAO 132086"},
        {"Wilson Evans Batten Catalogue", "WEB 4916"},
    },
    visualMagnitude: 6.55,
    bvColour: -0.038,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.37950629),
        dec: Angle.Degrees(-00.54393779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43174"},
        {"Hipparcos Number", "HIP 29641"},
        {"Smithsonian Astrophysical Observation", "SAO 133005"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.69627774),
        dec: Angle.Degrees(-00.54152692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1874",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1944"},
        {"Hipparcos Number", "HIP 1874"},
        {"Smithsonian Astrophysical Observation", "SAO 128735"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.947,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(005.91836915),
        dec: Angle.Degrees(-00.54135631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41482"},
        {"Hipparcos Number", "HIP 28862"},
        {"Smithsonian Astrophysical Observation", "SAO 132816"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.39191739),
        dec: Angle.Degrees(-00.54075324)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95316",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182198"},
        {"Hipparcos Number", "HIP 95316"},
        {"Geneva Identification System", "GEN# +1.00182198"},
        {"Smithsonian Astrophysical Observation", "SAO 143347"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.174,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.88175977),
        dec: Angle.Degrees(-00.54057333)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32851",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5505 A"},
        {"Henry Draper", "HD 49933"},
        {"Henry Draper 2", "HD 49933A"},
        {"Hipparcos Number", "HIP 32851"},
        {"Geneva Identification System", "GEN# +1.00049933"},
        {"Smithsonian Astrophysical Observation", "SAO 133760"},
        {"Wilson Evans Batten Catalogue", "WEB 6611"},
    },
    visualMagnitude: 5.78,
    bvColour: 0.396,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.70757903),
        dec: Angle.Degrees(-00.54042726)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -187.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44420"},
        {"Hipparcos Number", "HIP 30243"},
        {"Geneva Identification System", "GEN# +1.00044420"},
        {"Smithsonian Astrophysical Observation", "SAO 133153"},
        {"Wilson Evans Batten Catalogue", "WEB 6011"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.686,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.43140738),
        dec: Angle.Degrees(-00.53874678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14538",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 2345 AB"},
        {"Henry Draper", "HD 19465"},
        {"Hipparcos Number", "HIP 14538"},
        {"Smithsonian Astrophysical Observation", "SAO 130296"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.800,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(046.91923107),
        dec: Angle.Degrees(-00.53767828)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42473",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 42473"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.977,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(129.88580654),
        dec: Angle.Degrees(-00.53691843)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41043",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70549"},
        {"Hipparcos Number", "HIP 41043"},
        {"Geneva Identification System", "GEN# +1.00070549"},
        {"Smithsonian Astrophysical Observation", "SAO 135831"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.198,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.64119039),
        dec: Angle.Degrees(-00.53656368)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3124",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3691"},
        {"Hipparcos Number", "HIP 3124"},
    },
    visualMagnitude: 10.75,
    bvColour: 0.069,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.93333650),
        dec: Angle.Degrees(-00.53239625)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7527",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9921"},
        {"Hipparcos Number", "HIP 7527"},
        {"Smithsonian Astrophysical Observation", "SAO 129402"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.563,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.22415237),
        dec: Angle.Degrees(-00.53060864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 35.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93652",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 177335"},
        {"Hipparcos Number", "HIP 93652"},
        {"Smithsonian Astrophysical Observation", "SAO 142980"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.141,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(286.06062728),
        dec: Angle.Degrees(-00.52945593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61805",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110137"},
        {"Hipparcos Number", "HIP 61805"},
        {"Renson", "Renson 32000"},
        {"Smithsonian Astrophysical Observation", "SAO 138900"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.00050548),
        dec: Angle.Degrees(-00.52938040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20940"},
        {"Hipparcos Number", "HIP 15728"},
        {"Smithsonian Astrophysical Observation", "SAO 130451"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.65787819),
        dec: Angle.Degrees(-00.52843447)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 40.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 175905"},
        {"Hipparcos Number", "HIP 93078"},
        {"Geneva Identification System", "GEN# +1.00175905"},
        {"Smithsonian Astrophysical Observation", "SAO 142846"},
        {"Wilson Evans Batten Catalogue", "WEB 16123"},
    },
    visualMagnitude: 7.66,
    bvColour: 1.155,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.39992330),
        dec: Angle.Degrees(-00.52626948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107577",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 207185"},
        {"Hipparcos Number", "HIP 107577"},
        {"Smithsonian Astrophysical Observation", "SAO 145665"},
    },
    visualMagnitude: 9.18,
    bvColour: 0.972,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.81144948),
        dec: Angle.Degrees(-00.52613051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33106",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50531"},
        {"Hipparcos Number", "HIP 33106"},
        {"Smithsonian Astrophysical Observation", "SAO 133833"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.104,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.42831408),
        dec: Angle.Degrees(-00.52258841)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36659",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 59980"},
        {"Hipparcos Number", "HIP 36659"},
        {"Geneva Identification System", "GEN# +1.00059980"},
        {"Smithsonian Astrophysical Observation", "SAO 134810"},
        {"Wilson Evans Batten Catalogue", "WEB 7288"},
    },
    visualMagnitude: 7.69,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(113.11007959),
        dec: Angle.Degrees(-00.51836085)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -49.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102096"},
        {"Hipparcos Number", "HIP 57306"},
        {"Geneva Identification System", "GEN# +1.00102096"},
        {"Smithsonian Astrophysical Observation", "SAO 138388"},
    },
    visualMagnitude: 7.32,
    bvColour: 0.916,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.25584203),
        dec: Angle.Degrees(-00.51761079)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -97.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196395"},
        {"Hipparcos Number", "HIP 101718"},
        {"Geneva Identification System", "GEN# +1.00196395"},
        {"Smithsonian Astrophysical Observation", "SAO 144628"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.28177341),
        dec: Angle.Degrees(-00.51739562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22673"},
        {"Hipparcos Number", "HIP 17005"},
        {"Smithsonian Astrophysical Observation", "SAO 130629"},
    },
    visualMagnitude: 8.27,
    bvColour: 1.087,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.67948416),
        dec: Angle.Degrees(-00.51432295)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37831",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62724"},
        {"Hipparcos Number", "HIP 37831"},
        {"Geneva Identification System", "GEN# +1.00062724"},
        {"Smithsonian Astrophysical Observation", "SAO 135064"},
    },
    visualMagnitude: 7.61,
    bvColour: 0.374,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.34103554),
        dec: Angle.Degrees(-00.51340154)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29716",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43318"},
        {"Hipparcos Number", "HIP 29716"},
        {"Fundamental Katalog 5th Edition", "FK5 2477"},
        {"Geneva Identification System", "GEN# +1.00043318"},
        {"Smithsonian Astrophysical Observation", "SAO 133028"},
        {"Wilson Evans Batten Catalogue", "WEB 5859"},
    },
    visualMagnitude: 5.62,
    bvColour: 0.506,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.89315534),
        dec: Angle.Degrees(-00.51165873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -158.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -218.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112923",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 112923"},
    },
    visualMagnitude: 10.09,
    bvColour: 0.610,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(343.03868318),
        dec: Angle.Degrees(-00.51158473)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20725",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28159"},
        {"Hipparcos Number", "HIP 20725"},
        {"Geneva Identification System", "GEN# +1.00028159"},
        {"Smithsonian Astrophysical Observation", "SAO 131207"},
        {"Wilson Evans Batten Catalogue", "WEB 3976"},
    },
    visualMagnitude: 7.17,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(066.61308538),
        dec: Angle.Degrees(-00.51113775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33752"},
        {"Hipparcos Number", "HIP 24266"},
        {"Geneva Identification System", "GEN# +1.00033752"},
    },
    visualMagnitude: 8.89,
    bvColour: 0.040,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.12134411),
        dec: Angle.Degrees(-00.50951638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6226",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1081 ABC"},
        {"Henry Draper", "HD 8036"},
        {"Hipparcos Number", "HIP 6226"},
        {"Geneva Identification System", "GEN# +1.00008036J"},
        {"Smithsonian Astrophysical Observation", "SAO 129235"},
        {"Wilson Evans Batten Catalogue", "WEB 1394"},
    },
    visualMagnitude: 5.87,
    bvColour: 0.635,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.95121720),
        dec: Angle.Degrees(-00.50899490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107395",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 107395"},
    },
    visualMagnitude: 11.19,
    bvColour: 1.202,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.29265862),
        dec: Angle.Degrees(-00.50790402)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -138.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27980",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39833"},
        {"Hipparcos Number", "HIP 27980"},
        {"Geneva Identification System", "GEN# +1.00039833"},
        {"Smithsonian Astrophysical Observation", "SAO 132641"},
    },
    visualMagnitude: 7.65,
    bvColour: 0.629,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.75841263),
        dec: Angle.Degrees(-00.50784823)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28418",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 28418"},
    },
    visualMagnitude: 10.64,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.02754370),
        dec: Angle.Degrees(-00.50750892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7880",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10392"},
        {"Hipparcos Number", "HIP 7880"},
        {"Geneva Identification System", "GEN# +1.00010392"},
        {"Smithsonian Astrophysical Observation", "SAO 129449"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.993,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.34256579),
        dec: Angle.Degrees(-00.50654845)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2787",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 3229"},
        {"Hipparcos Number", "HIP 2787"},
        {"Fundamental Katalog 5th Edition", "FK5 2036"},
        {"Geneva Identification System", "GEN# +1.00003229"},
        {"Smithsonian Astrophysical Observation", "SAO 128843"},
        {"Wilson Evans Batten Catalogue", "WEB 499"},
    },
    visualMagnitude: 5.94,
    bvColour: 0.444,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.88645754),
        dec: Angle.Degrees(-00.50545908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 143.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11074",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14727"},
        {"Hipparcos Number", "HIP 11074"},
        {"Geneva Identification System", "GEN# +1.00014727"},
        {"Smithsonian Astrophysical Observation", "SAO 129864"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.63765818),
        dec: Angle.Degrees(-00.50515119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93195",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176157"},
        {"Hipparcos Number", "HIP 93195"},
        {"Smithsonian Astrophysical Observation", "SAO 142874"},
    },
    visualMagnitude: 8.39,
    bvColour: 0.829,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.73564558),
        dec: Angle.Degrees(-00.50370115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -109.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -117.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2994",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 534 A"},
        {"Henry Draper", "HD 3512"},
        {"Hipparcos Number", "HIP 2994"},
        {"Geneva Identification System", "GEN# +1.00003512A"},
        {"Smithsonian Astrophysical Observation", "SAO 128868"},
        {"Wilson Evans Batten Catalogue", "WEB 538"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.301,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(009.51902891),
        dec: Angle.Degrees(-00.50350326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 417",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6"},
        {"Hipparcos Number", "HIP 417"},
        {"Geneva Identification System", "GEN# +1.00000006"},
        {"Smithsonian Astrophysical Observation", "SAO 128569"},
        {"Wilson Evans Batten Catalogue", "WEB 65"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.099,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.26581912),
        dec: Angle.Degrees(-00.50290553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.86 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -53.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16528",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22007"},
        {"Hipparcos Number", "HIP 16528"},
        {"Geneva Identification System", "GEN# +1.00022007"},
        {"Smithsonian Astrophysical Observation", "SAO 130560"},
        {"Wilson Evans Batten Catalogue", "WEB 3158"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.956,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.20186201),
        dec: Angle.Degrees(-00.50274589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 24.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40635"},
        {"Hipparcos Number", "HIP 28421"},
        {"Geneva Identification System", "GEN# +1.00040635"},
        {"Smithsonian Astrophysical Observation", "SAO 132733"},
        {"Wilson Evans Batten Catalogue", "WEB 5555"},
    },
    visualMagnitude: 7.87,
    bvColour: 0.052,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.03265246),
        dec: Angle.Degrees(-00.50178814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32114"},
        {"Hipparcos Number", "HIP 23313"},
        {"Smithsonian Astrophysical Observation", "SAO 131686"},
        {"Wilson Evans Batten Catalogue", "WEB 4528"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.20336210),
        dec: Angle.Degrees(-00.50088169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26768"},
        {"Hipparcos Number", "HIP 19748"},
    },
    visualMagnitude: 8.46,
    bvColour: 1.627,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.50296031),
        dec: Angle.Degrees(-00.49976098)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114260",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218488"},
        {"Hipparcos Number", "HIP 114260"},
        {"Geneva Identification System", "GEN# +1.00218488"},
        {"Smithsonian Astrophysical Observation", "SAO 146526"},
    },
    visualMagnitude: 7.42,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(347.10854630),
        dec: Angle.Degrees(-00.49953527)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 90.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83737",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 83737"},
    },
    visualMagnitude: 10.70,
    bvColour: 0.372,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(256.71643514),
        dec: Angle.Degrees(-00.49748124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14841",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19866"},
        {"Hipparcos Number", "HIP 14841"},
        {"Geneva Identification System", "GEN# +1.00019866"},
        {"Smithsonian Astrophysical Observation", "SAO 130333"},
    },
    visualMagnitude: 7.09,
    bvColour: 1.167,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(047.91819123),
        dec: Angle.Degrees(-00.49405680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -32.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34769",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5864 A"},
        {"Henry Draper", "HD 55185"},
        {"Hipparcos Number", "HIP 34769"},
        {"Fundamental Katalog 5th Edition", "FK5 1187"},
        {"Geneva Identification System", "GEN# +1.00055185"},
        {"Smithsonian Astrophysical Observation", "SAO 134330"},
        {"Wilson Evans Batten Catalogue", "WEB 6951"},
    },
    visualMagnitude: 4.15,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.96608486),
        dec: Angle.Degrees(-00.49278056)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3763",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4639"},
        {"Hipparcos Number", "HIP 3763"},
        {"Smithsonian Astrophysical Observation", "SAO 128965"},
    },
    visualMagnitude: 7.64,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.08422041),
        dec: Angle.Degrees(-00.48910756)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128528"},
        {"Hipparcos Number", "HIP 71507"},
        {"Smithsonian Astrophysical Observation", "SAO 140039"},
    },
    visualMagnitude: 9.36,
    bvColour: 0.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.35197664),
        dec: Angle.Degrees(-00.48740172)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 82841"},
        {"Hipparcos Number", "HIP 46987"},
        {"Smithsonian Astrophysical Observation", "SAO 136965"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(143.65197852),
        dec: Angle.Degrees(-00.48719533)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59476",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59476"},
    },
    visualMagnitude: 10.29,
    bvColour: 0.660,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.98392338),
        dec: Angle.Degrees(-00.48457865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -57.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8670",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8670"},
        {"Smithsonian Astrophysical Observation", "SAO 129538"},
    },
    visualMagnitude: 9.86,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.91250333),
        dec: Angle.Degrees(-00.48431948)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53072",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94071"},
        {"Hipparcos Number", "HIP 53072"},
        {"Smithsonian Astrophysical Observation", "SAO 137840"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.395,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(162.87418997),
        dec: Angle.Degrees(-00.48380506)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44356",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77353"},
        {"Hipparcos Number", "HIP 44356"},
        {"Fundamental Katalog 5th Edition", "FK5 1235"},
        {"Geneva Identification System", "GEN# +1.00077353"},
        {"Smithsonian Astrophysical Observation", "SAO 136511"},
        {"Wilson Evans Batten Catalogue", "WEB 8504"},
    },
    visualMagnitude: 5.64,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.49173102),
        dec: Angle.Degrees(-00.48284175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -46.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 69.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59198",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59198"},
        {"Cincinnati Publication", "Ci 20 684"},
        {"Wilson Evans Batten Catalogue", "WEB 10533"},
    },
    visualMagnitude: 11.25,
    bvColour: 1.409,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.09485495),
        dec: Angle.Degrees(-00.48241351)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -963.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -90.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 170795"},
        {"Hipparcos Number", "HIP 90795"},
        {"Fundamental Katalog 5th Edition", "FK5 5624"},
        {"Geneva Identification System", "GEN# +1.00170795"},
        {"Smithsonian Astrophysical Observation", "SAO 142362"},
    },
    visualMagnitude: 7.07,
    bvColour: -0.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(277.84173897),
        dec: Angle.Degrees(-00.48195655)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16389",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21822"},
        {"Hipparcos Number", "HIP 16389"},
        {"Fundamental Katalog 5th Edition", "FK5 4317"},
        {"Geneva Identification System", "GEN# +1.00021822"},
        {"Smithsonian Astrophysical Observation", "SAO 130537"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.76663133),
        dec: Angle.Degrees(-00.48114835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42175",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72986"},
        {"Hipparcos Number", "HIP 42175"},
        {"Geneva Identification System", "GEN# +1.00072986"},
        {"Smithsonian Astrophysical Observation", "SAO 136080"},
    },
    visualMagnitude: 8.18,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.96517392),
        dec: Angle.Degrees(-00.48085490)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15174",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20266"},
        {"Hipparcos Number", "HIP 15174"},
        {"Geneva Identification System", "GEN# +1.00020266"},
        {"Smithsonian Astrophysical Observation", "SAO 130385"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.88258678),
        dec: Angle.Degrees(-00.47922875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33582",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51754"},
        {"Hipparcos Number", "HIP 33582"},
        {"Cincinnati Publication", "Ci 20 405"},
        {"Geneva Identification System", "GEN# +1.00051754"},
        {"Wilson Evans Batten Catalogue", "WEB 6751"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.65975967),
        dec: Angle.Degrees(-00.47899760)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 336.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -606.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101520",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195945"},
        {"Hipparcos Number", "HIP 101520"},
        {"Smithsonian Astrophysical Observation", "SAO 144577"},
    },
    visualMagnitude: 7.77,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.59631178),
        dec: Angle.Degrees(-00.47875872)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103766",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103766"},
    },
    visualMagnitude: 10.83,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.40990679),
        dec: Angle.Degrees(-00.47741548)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 157.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -136.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105983",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 105983"},
    },
    visualMagnitude: 9.80,
    bvColour: 1.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.97052855),
        dec: Angle.Degrees(-00.47584892)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49390",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87447"},
        {"Hipparcos Number", "HIP 49390"},
        {"Geneva Identification System", "GEN# +1.00087447"},
        {"Smithsonian Astrophysical Observation", "SAO 137341"},
    },
    visualMagnitude: 8.71,
    bvColour: 0.440,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.24749722),
        dec: Angle.Degrees(-00.47546956)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101521",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101521"},
    },
    visualMagnitude: 10.78,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.59605210),
        dec: Angle.Degrees(-00.47045271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76120",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138543"},
        {"Hipparcos Number", "HIP 76120"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.447,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.20364118),
        dec: Angle.Degrees(-00.47042994)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94676",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 180269"},
        {"Hipparcos Number", "HIP 94676"},
    },
    visualMagnitude: 9.76,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(288.98245202),
        dec: Angle.Degrees(-00.46954627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36130",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58666"},
        {"Hipparcos Number", "HIP 36130"},
        {"Geneva Identification System", "GEN# +1.00058666"},
        {"Smithsonian Astrophysical Observation", "SAO 134665"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(111.64235875),
        dec: Angle.Degrees(-00.46948594)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13619",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18217"},
        {"Hipparcos Number", "HIP 13619"},
        {"Geneva Identification System", "GEN# +1.00018217"},
        {"Smithsonian Astrophysical Observation", "SAO 130188"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.86491302),
        dec: Angle.Degrees(-00.46892766)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152036"},
        {"Hipparcos Number", "HIP 82455"},
        {"Smithsonian Astrophysical Observation", "SAO 141401"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.75815217),
        dec: Angle.Degrees(-00.46690485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115190",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 115190"},
        {"Geneva Identification System", "GEN# -0.00104417"},
        {"Smithsonian Astrophysical Observation", "SAO 146642"},
    },
    visualMagnitude: 10.31,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(349.96659788),
        dec: Angle.Degrees(-00.46589973)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -56.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -234.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84420"},
        {"Hipparcos Number", "HIP 47849"},
        {"Geneva Identification System", "GEN# +1.00084420"},
        {"Smithsonian Astrophysical Observation", "SAO 137099"},
    },
    visualMagnitude: 7.19,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.29754772),
        dec: Angle.Degrees(-00.46483631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220725"},
        {"Hipparcos Number", "HIP 115677"},
        {"Smithsonian Astrophysical Observation", "SAO 146704"},
    },
    visualMagnitude: 8.98,
    bvColour: 1.094,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.54441251),
        dec: Angle.Degrees(-00.46324074)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 86135"},
        {"Hipparcos Number", "HIP 48756"},
        {"Geneva Identification System", "GEN# +1.00086135"},
        {"Smithsonian Astrophysical Observation", "SAO 137239"},
        {"Wilson Evans Batten Catalogue", "WEB 9066"},
    },
    visualMagnitude: 7.86,
    bvColour: 1.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(149.16300170),
        dec: Angle.Degrees(-00.46147022)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74901",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136028"},
        {"Hipparcos Number", "HIP 74901"},
        {"Geneva Identification System", "GEN# +1.00136028"},
        {"Smithsonian Astrophysical Observation", "SAO 140444"},
        {"Wilson Evans Batten Catalogue", "WEB 12772"},
    },
    visualMagnitude: 5.88,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.60888718),
        dec: Angle.Degrees(-00.46123725)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14459"},
        {"Hipparcos Number", "HIP 10886"},
        {"Cincinnati Publication", "Ci 18 301"},
        {"Geneva Identification System", "GEN# +1.00014459"},
        {"Smithsonian Astrophysical Observation", "SAO 129836"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.757,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.02659918),
        dec: Angle.Degrees(-00.45890790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 170.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 80.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101204",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 101204"},
        {"Smithsonian Astrophysical Observation", "SAO 144520"},
    },
    visualMagnitude: 9.13,
    bvColour: 1.664,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.71393273),
        dec: Angle.Degrees(-00.45826320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119932"},
        {"Hipparcos Number", "HIP 67211"},
        {"Cincinnati Publication", "Ci 20 804"},
        {"Cincinnati Publication 2", "Ci 18 1788"},
        {"Geneva Identification System", "GEN# +1.00119932"},
        {"Smithsonian Astrophysical Observation", "SAO 139539"},
    },
    visualMagnitude: 9.31,
    bvColour: 0.928,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(206.58031193),
        dec: Angle.Degrees(-00.45799039)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -428.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136364"},
        {"Hipparcos Number", "HIP 75061"},
        {"Smithsonian Astrophysical Observation", "SAO 140466"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.08478767),
        dec: Angle.Degrees(-00.45776408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 59208",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 59208"},
        {"Geneva Identification System", "GEN# +0.00002900"},
        {"Wilson Evans Batten Catalogue", "WEB 10535"},
    },
    visualMagnitude: 10.73,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(182.14624064),
        dec: Angle.Degrees(-00.45674700)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93342",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11927 A"},
        {"Henry Draper", "HD 176531"},
        {"Hipparcos Number", "HIP 93342"},
        {"Smithsonian Astrophysical Observation", "SAO 142915"},
    },
    visualMagnitude: 7.20,
    bvColour: 0.858,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(285.18913820),
        dec: Angle.Degrees(-00.45504631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65514",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116767"},
        {"Hipparcos Number", "HIP 65514"},
        {"Smithsonian Astrophysical Observation", "SAO 139333"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.022,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.43717983),
        dec: Angle.Degrees(-00.45396392)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 15.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100550",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194014"},
        {"Hipparcos Number", "HIP 100550"},
        {"Smithsonian Astrophysical Observation", "SAO 144369"},
    },
    visualMagnitude: 7.00,
    bvColour: 1.603,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.83007221),
        dec: Angle.Degrees(-00.45229412)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5971",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 5971"},
        {"Smithsonian Astrophysical Observation", "SAO 129208"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.18634641),
        dec: Angle.Degrees(-00.45226048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 71.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6429",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8335"},
        {"Hipparcos Number", "HIP 6429"},
        {"Geneva Identification System", "GEN# +1.00008335"},
        {"Smithsonian Astrophysical Observation", "SAO 129262"},
        {"Wilson Evans Batten Catalogue", "WEB 1423"},
    },
    visualMagnitude: 6.50,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(020.64506808),
        dec: Angle.Degrees(-00.44964397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39931",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67720"},
        {"Hipparcos Number", "HIP 39931"},
        {"Smithsonian Astrophysical Observation", "SAO 135561"},
    },
    visualMagnitude: 7.52,
    bvColour: -0.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.32624231),
        dec: Angle.Degrees(-00.44924905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88671",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165462"},
        {"Hipparcos Number", "HIP 88671"},
        {"Geneva Identification System", "GEN# +1.00165462"},
        {"Smithsonian Astrophysical Observation", "SAO 142084"},
    },
    visualMagnitude: 6.32,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.53100222),
        dec: Angle.Degrees(-00.44609790)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2956"},
        {"Hipparcos Number", "HIP 2585"},
        {"Smithsonian Astrophysical Observation", "SAO 128818"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(008.20639086),
        dec: Angle.Degrees(-00.44564365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 7162"},
        {"Hipparcos Number", "HIP 5603"},
        {"Geneva Identification System", "GEN# +1.00007162"},
        {"Smithsonian Astrophysical Observation", "SAO 129173"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(017.96302440),
        dec: Angle.Degrees(-00.44528049)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84514",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10429 AB"},
        {"Henry Draper", "HD 156266"},
        {"Hipparcos Number", "HIP 84514"},
        {"Geneva Identification System", "GEN# +1.00156266"},
        {"Smithsonian Astrophysical Observation", "SAO 141586"},
        {"Wilson Evans Batten Catalogue", "WEB 14269"},
    },
    visualMagnitude: 4.72,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(259.15294004),
        dec: Angle.Degrees(-00.44514192)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -63.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12518 A"},
        {"Henry Draper", "HD 183518"},
        {"Hipparcos Number", "HIP 95886"},
        {"Geneva Identification System", "GEN# +1.00183518"},
        {"Smithsonian Astrophysical Observation", "SAO 143469"},
    },
    visualMagnitude: 7.34,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.51958026),
        dec: Angle.Degrees(-00.44494441)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8764"},
        {"Hipparcos Number", "HIP 6715"},
        {"Smithsonian Astrophysical Observation", "SAO 129299"},
    },
    visualMagnitude: 8.37,
    bvColour: 0.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.60493046),
        dec: Angle.Degrees(-00.44416409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 34.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37825",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37825"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.207,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.32906624),
        dec: Angle.Degrees(-00.44391867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -96.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 42883",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74487"},
        {"Hipparcos Number", "HIP 42883"},
        {"Geneva Identification System", "GEN# +1.00074487"},
        {"Smithsonian Astrophysical Observation", "SAO 136228"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.121,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.09641354),
        dec: Angle.Degrees(-00.44322342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39012",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 65500"},
        {"Hipparcos Number", "HIP 39012"},
        {"Smithsonian Astrophysical Observation", "SAO 135326"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.232,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(119.75333600),
        dec: Angle.Degrees(-00.44321234)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21747",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29648"},
        {"Hipparcos Number", "HIP 21747"},
        {"Geneva Identification System", "GEN# +1.00029648"},
        {"Smithsonian Astrophysical Observation", "SAO 131395"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.428,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.03849888),
        dec: Angle.Degrees(-00.43911560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37824",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 62697"},
        {"Hipparcos Number", "HIP 37824"},
        {"Geneva Identification System", "GEN# +1.00062697"},
        {"Smithsonian Astrophysical Observation", "SAO 135063"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.32739524),
        dec: Angle.Degrees(-00.43823207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98030",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 188444"},
        {"Hipparcos Number", "HIP 98030"},
        {"Smithsonian Astrophysical Observation", "SAO 143912"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(298.80648377),
        dec: Angle.Degrees(-00.43452363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219067"},
        {"Hipparcos Number", "HIP 114609"},
        {"Smithsonian Astrophysical Observation", "SAO 146566"},
    },
    visualMagnitude: 8.80,
    bvColour: 1.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.27133720),
        dec: Angle.Degrees(-00.43447954)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 31.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44577",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44577"},
        {"Smithsonian Astrophysical Observation", "SAO 136556"},
    },
    visualMagnitude: 9.49,
    bvColour: 0.926,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.23613782),
        dec: Angle.Degrees(-00.43203118)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 89909",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 168623"},
        {"Hipparcos Number", "HIP 89909"},
        {"Smithsonian Astrophysical Observation", "SAO 142236"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.333,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(275.19142859),
        dec: Angle.Degrees(-00.42926496)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113834",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217786"},
        {"Hipparcos Number", "HIP 113834"},
        {"Geneva Identification System", "GEN# +1.00217786"},
        {"Smithsonian Astrophysical Observation", "SAO 146477"},
        {"Wilson Evans Batten Catalogue", "WEB 20221"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.578,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.78440495),
        dec: Angle.Degrees(-00.42920986)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -89.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -169.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55495",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98760"},
        {"Hipparcos Number", "HIP 55495"},
        {"Smithsonian Astrophysical Observation", "SAO 138159"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.294,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.48506650),
        dec: Angle.Degrees(-00.42905720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197999"},
        {"Hipparcos Number", "HIP 102596"},
        {"Geneva Identification System", "GEN# +1.00197999"},
        {"Smithsonian Astrophysical Observation", "SAO 144809"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.240,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.87525513),
        dec: Angle.Degrees(-00.42858231)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27681",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290924"},
        {"Hipparcos Number", "HIP 27681"},
    },
    visualMagnitude: 9.51,
    bvColour: 0.419,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.90321940),
        dec: Angle.Degrees(-00.42852381)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112770"},
        {"Hipparcos Number", "HIP 63373"},
        {"Smithsonian Astrophysical Observation", "SAO 139082"},
    },
    visualMagnitude: 9.69,
    bvColour: 0.474,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.78112503),
        dec: Angle.Degrees(-00.42832774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -70.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 178744"},
        {"Hipparcos Number", "HIP 94149"},
        {"Geneva Identification System", "GEN# +1.00178744"},
        {"Smithsonian Astrophysical Observation", "SAO 143087"},
        {"Wilson Evans Batten Catalogue", "WEB 16401"},
    },
    visualMagnitude: 6.34,
    bvColour: -0.042,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.46497041),
        dec: Angle.Degrees(-00.42809819)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45944",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80871"},
        {"Hipparcos Number", "HIP 45944"},
        {"Geneva Identification System", "GEN# +1.00080871"},
        {"Smithsonian Astrophysical Observation", "SAO 136789"},
    },
    visualMagnitude: 7.59,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(140.54270072),
        dec: Angle.Degrees(-00.42586439)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131455"},
        {"Hipparcos Number", "HIP 72882"},
        {"Smithsonian Astrophysical Observation", "SAO 140206"},
    },
    visualMagnitude: 8.00,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.44440425),
        dec: Angle.Degrees(-00.42470508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116320",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 221674"},
        {"Hipparcos Number", "HIP 116320"},
        {"Smithsonian Astrophysical Observation", "SAO 146779"},
    },
    visualMagnitude: 8.75,
    bvColour: 1.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(353.53037156),
        dec: Angle.Degrees(-00.42368268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103561",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199701"},
        {"Hipparcos Number", "HIP 103561"},
        {"Smithsonian Astrophysical Observation", "SAO 145001"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.315,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.74155533),
        dec: Angle.Degrees(-00.42316711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76913",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 140162"},
        {"Hipparcos Number", "HIP 76913"},
        {"Geneva Identification System", "GEN# +1.00140162"},
    },
    visualMagnitude: 9.68,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(235.57400597),
        dec: Angle.Degrees(-00.42276808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19569",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26516"},
        {"Hipparcos Number", "HIP 19569"},
        {"Geneva Identification System", "GEN# +1.00026516"},
        {"Smithsonian Astrophysical Observation", "SAO 131012"},
    },
    visualMagnitude: 6.59,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(062.88185346),
        dec: Angle.Degrees(-00.42249670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 13139"},
        {"Hipparcos Number", "HIP 9976"},
        {"Smithsonian Astrophysical Observation", "SAO 129714"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.11365485),
        dec: Angle.Degrees(-00.41934067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 17.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95715",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 183127"},
        {"Hipparcos Number", "HIP 95715"},
        {"Geneva Identification System", "GEN# +1.00183127"},
        {"Smithsonian Astrophysical Observation", "SAO 143436"},
        {"Wilson Evans Batten Catalogue", "WEB 16746"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.458,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(292.02404908),
        dec: Angle.Degrees(-00.41884692)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64298",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114464"},
        {"Hipparcos Number", "HIP 64298"},
        {"Smithsonian Astrophysical Observation", "SAO 139197"},
    },
    visualMagnitude: 8.49,
    bvColour: 1.355,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(197.67981552),
        dec: Angle.Degrees(-00.41878859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16214",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21581"},
        {"Hipparcos Number", "HIP 16214"},
        {"Geneva Identification System", "GEN# +1.00021581"},
        {"Smithsonian Astrophysical Observation", "SAO 130513"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.786,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.22686266),
        dec: Angle.Degrees(-00.41734320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 65.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -77.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25028",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3941 A"},
        {"Henry Draper", "HD 35007"},
        {"Hipparcos Number", "HIP 25028"},
        {"Geneva Identification System", "GEN# +1.00035007A"},
        {"Smithsonian Astrophysical Observation", "SAO 132024"},
        {"Wilson Evans Batten Catalogue", "WEB 4847"},
    },
    visualMagnitude: 5.68,
    bvColour: -0.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.38268211),
        dec: Angle.Degrees(-00.41649397)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29654",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43191"},
        {"Hipparcos Number", "HIP 29654"},
        {"Geneva Identification System", "GEN# +1.00043191"},
        {"Smithsonian Astrophysical Observation", "SAO 133011"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.063,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(093.71793580),
        dec: Angle.Degrees(-00.41511227)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10487",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10487"},
        {"Smithsonian Astrophysical Observation", "SAO 129778"},
    },
    visualMagnitude: 10.15,
    bvColour: 0.594,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(033.80473112),
        dec: Angle.Degrees(-00.41458633)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 100.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 47.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 100269"},
        {"Hipparcos Number", "HIP 56282"},
        {"Geneva Identification System", "GEN# +1.00100269"},
        {"Smithsonian Astrophysical Observation", "SAO 138256"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.07736843),
        dec: Angle.Degrees(-00.41434337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 43.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -157.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220256"},
        {"Hipparcos Number", "HIP 115381"},
        {"Cincinnati Publication", "Ci 18 3063"},
        {"Smithsonian Astrophysical Observation", "SAO 146667"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.853,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(350.59857768),
        dec: Angle.Degrees(-00.41425958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 213.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -251.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78580",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 143838"},
        {"Hipparcos Number", "HIP 78580"},
        {"Geneva Identification System", "GEN# +1.00143838"},
        {"Smithsonian Astrophysical Observation", "SAO 140913"},
    },
    visualMagnitude: 7.45,
    bvColour: 1.018,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(240.68007063),
        dec: Angle.Degrees(-00.41240237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149616"},
        {"Hipparcos Number", "HIP 81274"},
        {"Geneva Identification System", "GEN# +1.00149616"},
        {"Smithsonian Astrophysical Observation", "SAO 141267"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.561,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(248.98962810),
        dec: Angle.Degrees(-00.41163123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41313",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71137"},
        {"Hipparcos Number", "HIP 41313"},
        {"Geneva Identification System", "GEN# +1.00071137"},
        {"Smithsonian Astrophysical Observation", "SAO 135898"},
        {"Wilson Evans Batten Catalogue", "WEB 7995"},
    },
    visualMagnitude: 7.30,
    bvColour: 1.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.44177007),
        dec: Angle.Degrees(-00.41160448)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 120004",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 120004"},
    },
    visualMagnitude: 9.84,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.45209219),
        dec: Angle.Degrees(-00.40980449)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -66.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 11.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54719",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97340"},
        {"Hipparcos Number", "HIP 54719"},
        {"Geneva Identification System", "GEN# +1.00097340"},
        {"Smithsonian Astrophysical Observation", "SAO 138052"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.04347157),
        dec: Angle.Degrees(-00.40954572)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21964",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 21964"},
    },
    visualMagnitude: 10.18,
    bvColour: 1.191,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(070.82042409),
        dec: Angle.Degrees(-00.40800976)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18642",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25116"},
        {"Hipparcos Number", "HIP 18642"},
        {"Geneva Identification System", "GEN# +1.00025116"},
        {"Smithsonian Astrophysical Observation", "SAO 130862"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.529,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.85586542),
        dec: Angle.Degrees(-00.40774470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -70.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131479"},
        {"Hipparcos Number", "HIP 72888"},
        {"Geneva Identification System", "GEN# +1.00131479"},
        {"Smithsonian Astrophysical Observation", "SAO 140209"},
    },
    visualMagnitude: 7.36,
    bvColour: 0.913,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.45765424),
        dec: Angle.Degrees(-00.40545073)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -59.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85844"},
        {"Hipparcos Number", "HIP 48590"},
        {"Geneva Identification System", "GEN# +1.00085844"},
        {"Smithsonian Astrophysical Observation", "SAO 137217"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.64270653),
        dec: Angle.Degrees(-00.40499344)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -59.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90211"},
        {"Hipparcos Number", "HIP 50982"},
        {"Geneva Identification System", "GEN# +1.00090211"},
        {"Smithsonian Astrophysical Observation", "SAO 137547"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.21317797),
        dec: Angle.Degrees(-00.40179560)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8779"},
        {"Hipparcos Number", "HIP 6717"},
        {"Geneva Identification System", "GEN# +1.00008779"},
        {"Smithsonian Astrophysical Observation", "SAO 129300"},
        {"Wilson Evans Batten Catalogue", "WEB 1467"},
    },
    visualMagnitude: 6.42,
    bvColour: 1.241,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.61382606),
        dec: Angle.Degrees(-00.39898610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 50.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146116"},
        {"Hipparcos Number", "HIP 79604"},
        {"Geneva Identification System", "GEN# +1.00146116"},
        {"Smithsonian Astrophysical Observation", "SAO 141056"},
    },
    visualMagnitude: 7.68,
    bvColour: 1.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.65995780),
        dec: Angle.Degrees(-00.39873002)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22109"},
        {"Hipparcos Number", "HIP 16600"},
        {"Smithsonian Astrophysical Observation", "SAO 130571"},
    },
    visualMagnitude: 8.68,
    bvColour: 1.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(053.41977241),
        dec: Angle.Degrees(-00.39811757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44953",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78663"},
        {"Hipparcos Number", "HIP 44953"},
        {"Geneva Identification System", "GEN# +1.00078663"},
        {"Smithsonian Astrophysical Observation", "SAO 136620"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.767,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.37567574),
        dec: Angle.Degrees(-00.39799228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -180.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12935",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12935"},
        {"Smithsonian Astrophysical Observation", "SAO 130102"},
    },
    visualMagnitude: 10.16,
    bvColour: 0.481,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(041.58686102),
        dec: Angle.Degrees(-00.39340228)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 67.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 121547"},
        {"Hipparcos Number", "HIP 68062"},
        {"Smithsonian Astrophysical Observation", "SAO 139634"},
    },
    visualMagnitude: 9.15,
    bvColour: 1.173,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.03938480),
        dec: Angle.Degrees(-00.39242896)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30510"},
        {"Hipparcos Number", "HIP 22307"},
        {"Smithsonian Astrophysical Observation", "SAO 131498"},
    },
    visualMagnitude: 8.44,
    bvColour: 1.365,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.06573881),
        dec: Angle.Degrees(-00.39089924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106758",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15142 A"},
        {"Henry Draper", "HD 205765"},
        {"Hipparcos Number", "HIP 106758"},
        {"Geneva Identification System", "GEN# +1.00205765A"},
        {"Smithsonian Astrophysical Observation", "SAO 145533"},
        {"Wilson Evans Batten Catalogue", "WEB 19301"},
    },
    visualMagnitude: 6.22,
    bvColour: 0.056,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.39072099),
        dec: Angle.Degrees(-00.39049406)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.76 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26154",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36841"},
        {"Hipparcos Number", "HIP 26154"},
        {"Geneva Identification System", "GEN# +1.00036841"},
        {"Smithsonian Astrophysical Observation", "SAO 132281"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.64050744),
        dec: Angle.Degrees(-00.38652759)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91352",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11515 AB"},
        {"Henry Draper", "HD 172028"},
        {"Hipparcos Number", "HIP 91352"},
        {"Geneva Identification System", "GEN# +1.00172028J"},
        {"Smithsonian Astrophysical Observation", "SAO 142454"},
        {"Wilson Evans Batten Catalogue", "WEB 15697"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.502,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.48591112),
        dec: Angle.Degrees(-00.38582744)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116826",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 16920 AB"},
        {"Henry Draper", "HD 222456"},
        {"Hipparcos Number", "HIP 116826"},
        {"Smithsonian Astrophysical Observation", "SAO 146841"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.393,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.17735571),
        dec: Angle.Degrees(-00.38300793)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25044",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35039"},
        {"Hipparcos Number", "HIP 25044"},
        {"Fundamental Katalog 5th Edition", "FK5 1147"},
        {"Geneva Identification System", "GEN# +1.00035039"},
        {"Renson", "Renson 8953"},
        {"Smithsonian Astrophysical Observation", "SAO 132028"},
        {"Wilson Evans Batten Catalogue", "WEB 4856"},
    },
    visualMagnitude: 4.72,
    bvColour: -0.168,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.44061530),
        dec: Angle.Degrees(-00.38246922)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74425",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134945"},
        {"Hipparcos Number", "HIP 74425"},
        {"Smithsonian Astrophysical Observation", "SAO 140379"},
    },
    visualMagnitude: 7.23,
    bvColour: 1.618,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(228.15619407),
        dec: Angle.Degrees(-00.38157664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 155717"},
        {"Hipparcos Number", "HIP 84253"},
        {"Geneva Identification System", "GEN# +1.00155717"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(258.34054094),
        dec: Angle.Degrees(-00.38155077)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4131",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5103"},
        {"Hipparcos Number", "HIP 4131"},
        {"Geneva Identification System", "GEN# +1.00005103"},
        {"Smithsonian Astrophysical Observation", "SAO 129007"},
    },
    visualMagnitude: 8.21,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.22509998),
        dec: Angle.Degrees(-00.38128772)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103225",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 103225"},
    },
    visualMagnitude: 9.54,
    bvColour: 1.389,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.69567940),
        dec: Angle.Degrees(-00.37968165)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58639",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104409"},
        {"Hipparcos Number", "HIP 58639"},
        {"Geneva Identification System", "GEN# +1.00104409"},
        {"Smithsonian Astrophysical Observation", "SAO 138542"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.939,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.36638930),
        dec: Angle.Degrees(-00.37877012)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33520",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 33520"},
        {"Wilson Evans Batten Catalogue", "WEB 6742"},
    },
    visualMagnitude: 10.85,
    bvColour: 1.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.50389550),
        dec: Angle.Degrees(-00.37596146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91987",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173371"},
        {"Hipparcos Number", "HIP 91987"},
        {"Geneva Identification System", "GEN# +1.00173371"},
        {"Smithsonian Astrophysical Observation", "SAO 142582"},
        {"Wilson Evans Batten Catalogue", "WEB 15846"},
    },
    visualMagnitude: 6.89,
    bvColour: -0.023,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.23297286),
        dec: Angle.Degrees(-00.37339176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87887"},
        {"Hipparcos Number", "HIP 49641"},
        {"Fundamental Katalog 5th Edition", "FK5 2814"},
        {"Geneva Identification System", "GEN# +1.00087887"},
        {"Smithsonian Astrophysical Observation", "SAO 137366"},
        {"Wilson Evans Batten Catalogue", "WEB 9156"},
    },
    visualMagnitude: 4.48,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.98456489),
        dec: Angle.Degrees(-00.37162786)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -26.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110113",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 110113"},
    },
    visualMagnitude: 11.43,
    bvColour: 0.920,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.58124726),
        dec: Angle.Degrees(-00.37125018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29934",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43777"},
        {"Hipparcos Number", "HIP 29934"},
        {"Geneva Identification System", "GEN# +1.00043777"},
        {"Smithsonian Astrophysical Observation", "SAO 133075"},
        {"Wilson Evans Batten Catalogue", "WEB 5934"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.136,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.53217613),
        dec: Angle.Degrees(-00.37072695)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16072"},
        {"Hipparcos Number", "HIP 12014"},
        {"Smithsonian Astrophysical Observation", "SAO 129985"},
    },
    visualMagnitude: 8.59,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.72383304),
        dec: Angle.Degrees(-00.37021174)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24689",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34480"},
        {"Hipparcos Number", "HIP 24689"},
        {"Geneva Identification System", "GEN# +1.00034480"},
        {"Smithsonian Astrophysical Observation", "SAO 131951"},
    },
    visualMagnitude: 9.04,
    bvColour: 0.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.43246782),
        dec: Angle.Degrees(-00.37009076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15621",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20802"},
        {"Hipparcos Number", "HIP 15621"},
        {"Smithsonian Astrophysical Observation", "SAO 130435"},
    },
    visualMagnitude: 8.18,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.28534334),
        dec: Angle.Degrees(-00.36954046)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52588"},
        {"Hipparcos Number", "HIP 33862"},
        {"Smithsonian Astrophysical Observation", "SAO 134070"},
    },
    visualMagnitude: 9.31,
    bvColour: -0.065,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.44326490),
        dec: Angle.Degrees(-00.36829322)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78886",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144490"},
        {"Hipparcos Number", "HIP 78886"},
        {"Geneva Identification System", "GEN# +1.00144490"},
        {"Smithsonian Astrophysical Observation", "SAO 140951"},
    },
    visualMagnitude: 7.41,
    bvColour: 1.002,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.55740387),
        dec: Angle.Degrees(-00.36650327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72165",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129975"},
        {"Hipparcos Number", "HIP 72165"},
        {"Geneva Identification System", "GEN# +1.00129975"},
        {"Smithsonian Astrophysical Observation", "SAO 140122"},
    },
    visualMagnitude: 8.37,
    bvColour: 1.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.40646542),
        dec: Angle.Degrees(-00.36471041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58637",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104408"},
        {"Hipparcos Number", "HIP 58637"},
        {"Geneva Identification System", "GEN# +1.00104408"},
        {"Smithsonian Astrophysical Observation", "SAO 138541"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.36424384),
        dec: Angle.Degrees(-00.36460746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109578",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210648"},
        {"Hipparcos Number", "HIP 109578"},
        {"Smithsonian Astrophysical Observation", "SAO 145933"},
    },
    visualMagnitude: 8.51,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.96641299),
        dec: Angle.Degrees(-00.36259541)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122798"},
        {"Hipparcos Number", "HIP 68718"},
        {"Smithsonian Astrophysical Observation", "SAO 139708"},
    },
    visualMagnitude: 8.48,
    bvColour: 0.587,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.00942323),
        dec: Angle.Degrees(-00.36255133)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92466",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 174461"},
        {"Hipparcos Number", "HIP 92466"},
        {"Smithsonian Astrophysical Observation", "SAO 142688"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(282.66200153),
        dec: Angle.Degrees(-00.36074129)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224726"},
        {"Hipparcos Number", "HIP 14"},
        {"Geneva Identification System", "GEN# +1.00224726"},
        {"Smithsonian Astrophysical Observation", "SAO 147023"},
    },
    visualMagnitude: 7.25,
    bvColour: 1.200,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.04827189),
        dec: Angle.Degrees(-00.36042119)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9989",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 9989"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.248,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(032.16594506),
        dec: Angle.Degrees(-00.35965586)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 442.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -99.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62468",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111275"},
        {"Hipparcos Number", "HIP 62468"},
        {"Geneva Identification System", "GEN# +1.00111275"},
        {"Smithsonian Astrophysical Observation", "SAO 138973"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.02679456),
        dec: Angle.Degrees(-00.35926509)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88667",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165437"},
        {"Hipparcos Number", "HIP 88667"},
    },
    visualMagnitude: 9.08,
    bvColour: 0.297,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.52265567),
        dec: Angle.Degrees(-00.35863659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17701",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 17701"},
    },
    visualMagnitude: 10.72,
    bvColour: 0.644,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.87063987),
        dec: Angle.Degrees(-00.35636680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17882",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24003"},
        {"Hipparcos Number", "HIP 17882"},
        {"Geneva Identification System", "GEN# +1.00024003"},
        {"Smithsonian Astrophysical Observation", "SAO 130749"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(057.37731505),
        dec: Angle.Degrees(-00.35585864)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46331",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81617"},
        {"Hipparcos Number", "HIP 46331"},
    },
    visualMagnitude: 9.32,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(141.69048048),
        dec: Angle.Degrees(-00.35551398)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16873",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22502"},
        {"Hipparcos Number", "HIP 16873"},
        {"Smithsonian Astrophysical Observation", "SAO 130610"},
    },
    visualMagnitude: 9.73,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.28332005),
        dec: Angle.Degrees(-00.35444066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -42.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 31383"},
        {"Hipparcos Number", "HIP 22888"},
        {"Geneva Identification System", "GEN# +1.00031383"},
        {"Smithsonian Astrophysical Observation", "SAO 131599"},
    },
    visualMagnitude: 8.16,
    bvColour: 0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.84283197),
        dec: Angle.Degrees(-00.35282849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7549",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9958"},
        {"Hipparcos Number", "HIP 7549"},
        {"Fundamental Katalog 5th Edition", "FK5 2106"},
        {"Geneva Identification System", "GEN# +1.00009958"},
        {"Smithsonian Astrophysical Observation", "SAO 129407"},
    },
    visualMagnitude: 7.08,
    bvColour: 0.671,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(024.31734985),
        dec: Angle.Degrees(-00.35013083)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75087",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 75087"},
    },
    visualMagnitude: 9.88,
    bvColour: 0.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.15804203),
        dec: Angle.Degrees(-00.34816939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158808"},
        {"Hipparcos Number", "HIP 85746"},
        {"Smithsonian Astrophysical Observation", "SAO 141714"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.182,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.83104871),
        dec: Angle.Degrees(-00.34705024)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94807"},
        {"Hipparcos Number", "HIP 53507"},
        {"Geneva Identification System", "GEN# +1.00094807"},
        {"Smithsonian Astrophysical Observation", "SAO 137900"},
    },
    visualMagnitude: 8.28,
    bvColour: 0.404,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.18682507),
        dec: Angle.Degrees(-00.34546173)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12728",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17000"},
        {"Hipparcos Number", "HIP 12728"},
        {"Geneva Identification System", "GEN# +1.00017000"},
        {"Smithsonian Astrophysical Observation", "SAO 130080"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.90416955),
        dec: Angle.Degrees(-00.34446155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56056",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 99864"},
        {"Hipparcos Number", "HIP 56056"},
        {"Fundamental Katalog 5th Edition", "FK5 5011"},
        {"Smithsonian Astrophysical Observation", "SAO 138231"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(172.33288933),
        dec: Angle.Degrees(-00.34274261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73317",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132392"},
        {"Hipparcos Number", "HIP 73317"},
        {"Smithsonian Astrophysical Observation", "SAO 140258"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.995,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.73498894),
        dec: Angle.Degrees(-00.34265784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51791",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 91637"},
        {"Hipparcos Number", "HIP 51791"},
        {"Wilson Evans Batten Catalogue", "WEB 9434"},
    },
    visualMagnitude: 10.14,
    bvColour: 1.598,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(158.73351545),
        dec: Angle.Degrees(-00.34262112)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41425",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 41425"},
        {"Geneva Identification System", "GEN# +0.00002299"},
    },
    visualMagnitude: 9.95,
    bvColour: 1.010,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.74011653),
        dec: Angle.Degrees(-00.34183996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -214.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -36.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197814"},
        {"Hipparcos Number", "HIP 102480"},
        {"Geneva Identification System", "GEN# +1.00197814"},
        {"Smithsonian Astrophysical Observation", "SAO 144785"},
    },
    visualMagnitude: 6.76,
    bvColour: 0.955,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.50502562),
        dec: Angle.Degrees(-00.34039670)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9631",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1634 A"},
        {"Henry Draper", "HD 12641"},
        {"Hipparcos Number", "HIP 9631"},
        {"Geneva Identification System", "GEN# +1.00012641A"},
        {"Smithsonian Astrophysical Observation", "SAO 129667"},
        {"Wilson Evans Batten Catalogue", "WEB 2023"},
    },
    visualMagnitude: 5.96,
    bvColour: 0.851,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.95051270),
        dec: Angle.Degrees(-00.34014611)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 82.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -43.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35469",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56990"},
        {"Hipparcos Number", "HIP 35469"},
        {"Geneva Identification System", "GEN# +1.00056990"},
        {"Smithsonian Astrophysical Observation", "SAO 134507"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.724,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.82960159),
        dec: Angle.Degrees(-00.33394531)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71628",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71628"},
        {"Geneva Identification System", "GEN# +0.00003214"},
        {"Smithsonian Astrophysical Observation", "SAO 140051"},
    },
    visualMagnitude: 9.66,
    bvColour: 0.579,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.74807621),
        dec: Angle.Degrees(-00.33236040)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 192086"},
        {"Hipparcos Number", "HIP 99624"},
        {"Geneva Identification System", "GEN# +1.00192086"},
        {"Smithsonian Astrophysical Observation", "SAO 144177"},
    },
    visualMagnitude: 6.47,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.26843803),
        dec: Angle.Degrees(-00.33079848)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90932",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171108"},
        {"Hipparcos Number", "HIP 90932"},
        {"Smithsonian Astrophysical Observation", "SAO 142379"},
    },
    visualMagnitude: 8.79,
    bvColour: 1.442,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.23099107),
        dec: Angle.Degrees(-00.33029693)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88961",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 166184"},
        {"Hipparcos Number", "HIP 88961"},
        {"Geneva Identification System", "GEN# +1.00166184"},
        {"Smithsonian Astrophysical Observation", "SAO 142127"},
    },
    visualMagnitude: 8.93,
    bvColour: 1.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(272.38416322),
        dec: Angle.Degrees(-00.32709783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 79.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20167"},
        {"Hipparcos Number", "HIP 15082"},
        {"Smithsonian Astrophysical Observation", "SAO 130371"},
    },
    visualMagnitude: 9.43,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.61511418),
        dec: Angle.Degrees(-00.32634254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 84804",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 156879"},
        {"Hipparcos Number", "HIP 84804"},
        {"Smithsonian Astrophysical Observation", "SAO 141613"},
    },
    visualMagnitude: 7.98,
    bvColour: 1.245,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(260.00016547),
        dec: Angle.Degrees(-00.32565635)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102823",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198371"},
        {"Hipparcos Number", "HIP 102823"},
        {"Geneva Identification System", "GEN# +1.00198371"},
        {"Smithsonian Astrophysical Observation", "SAO 144852"},
    },
    visualMagnitude: 7.18,
    bvColour: 1.203,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.45836625),
        dec: Angle.Degrees(-00.32429037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 209247"},
        {"Hipparcos Number", "HIP 108762"},
        {"Smithsonian Astrophysical Observation", "SAO 145819"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.47962686),
        dec: Angle.Degrees(-00.32372571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86388",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 86388"},
    },
    visualMagnitude: 10.78,
    bvColour: 0.796,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(264.77790103),
        dec: Angle.Degrees(-00.32251160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.18 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7005",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9149"},
        {"Hipparcos Number", "HIP 7005"},
        {"Smithsonian Astrophysical Observation", "SAO 129334"},
    },
    visualMagnitude: 9.08,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(022.53604405),
        dec: Angle.Degrees(-00.32179972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2333",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2624"},
        {"Hipparcos Number", "HIP 2333"},
        {"Geneva Identification System", "GEN# +1.00002624"},
        {"Smithsonian Astrophysical Observation", "SAO 128788"},
        {"Wilson Evans Batten Catalogue", "WEB 425"},
    },
    visualMagnitude: 7.83,
    bvColour: 1.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.46223588),
        dec: Angle.Degrees(-00.32088385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 37.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4795",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6020"},
        {"Hipparcos Number", "HIP 4795"},
        {"Smithsonian Astrophysical Observation", "SAO 129087"},
    },
    visualMagnitude: 8.95,
    bvColour: 0.473,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(015.39278196),
        dec: Angle.Degrees(-00.32034019)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109074",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Sadalmelik"},
        {"Henry Draper", "HD 209750"},
        {"Hipparcos Number", "HIP 109074"},
        {"Fundamental Katalog 5th Edition", "FK5 827"},
        {"Geneva Identification System", "GEN# +1.00209750"},
        {"Smithsonian Astrophysical Observation", "SAO 145862"},
        {"Wilson Evans Batten Catalogue", "WEB 19611"},
    },
    visualMagnitude: 2.95,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(331.44593869),
        dec: Angle.Degrees(-00.31982656)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47252",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7464 A"},
        {"Henry Draper", "HD 83363"},
        {"Hipparcos Number", "HIP 47252"},
        {"Fundamental Katalog 5th Edition", "FK5 4853"},
        {"Smithsonian Astrophysical Observation", "SAO 137009"},
    },
    visualMagnitude: 7.87,
    bvColour: -0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(144.47731050),
        dec: Angle.Degrees(-00.31967195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102634"},
        {"Hipparcos Number", "HIP 57629"},
        {"Geneva Identification System", "GEN# +1.00102634"},
        {"Smithsonian Astrophysical Observation", "SAO 138420"},
        {"Wilson Evans Batten Catalogue", "WEB 10346"},
    },
    visualMagnitude: 6.15,
    bvColour: 0.518,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.25584223),
        dec: Angle.Degrees(-00.31867805)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -206.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65683",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117088"},
        {"Hipparcos Number", "HIP 65683"},
        {"Smithsonian Astrophysical Observation", "SAO 139351"},
    },
    visualMagnitude: 8.86,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.01168440),
        dec: Angle.Degrees(-00.31678209)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -33.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96749",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185627"},
        {"Hipparcos Number", "HIP 96749"},
        {"Smithsonian Astrophysical Observation", "SAO 143665"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.292,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.01370231),
        dec: Angle.Degrees(-00.31620429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113478",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217188"},
        {"Hipparcos Number", "HIP 113478"},
        {"Geneva Identification System", "GEN# +1.00217188"},
        {"Smithsonian Astrophysical Observation", "SAO 146421"},
    },
    visualMagnitude: 7.42,
    bvColour: 1.031,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(344.72036742),
        dec: Angle.Degrees(-00.31597326)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 56.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.88 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65406",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116543"},
        {"Hipparcos Number", "HIP 65406"},
        {"Geneva Identification System", "GEN# +1.00116543"},
        {"Smithsonian Astrophysical Observation", "SAO 139319"},
    },
    visualMagnitude: 8.13,
    bvColour: 0.461,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(201.08762118),
        dec: Angle.Degrees(-00.31578540)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23101",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23101"},
        {"Smithsonian Astrophysical Observation", "SAO 131639"},
    },
    visualMagnitude: 9.83,
    bvColour: 0.134,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(074.55398574),
        dec: Angle.Degrees(-00.31539372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16911",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22548"},
        {"Hipparcos Number", "HIP 16911"},
    },
    visualMagnitude: 9.96,
    bvColour: 0.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(054.39831375),
        dec: Angle.Degrees(-00.31502875)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66212",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8949 AB"},
        {"Henry Draper", "HD 118036"},
        {"Hipparcos Number", "HIP 66212"},
        {"Geneva Identification System", "GEN# +1.00118036J"},
        {"Smithsonian Astrophysical Observation", "SAO 139416"},
        {"Wilson Evans Batten Catalogue", "WEB 11697"},
    },
    visualMagnitude: 7.37,
    bvColour: 1.521,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(203.56823695),
        dec: Angle.Degrees(-00.31383882)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -204.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33123",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50583"},
        {"Hipparcos Number", "HIP 33123"},
        {"Geneva Identification System", "GEN# +1.00050583"},
        {"Smithsonian Astrophysical Observation", "SAO 133839"},
        {"Wilson Evans Batten Catalogue", "WEB 6665"},
    },
    visualMagnitude: 8.26,
    bvColour: -0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.47591875),
        dec: Angle.Degrees(-00.31371515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53532",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94864"},
        {"Hipparcos Number", "HIP 53532"},
        {"Fundamental Katalog 5th Edition", "FK5 4965"},
        {"Geneva Identification System", "GEN# +1.00094864"},
        {"Smithsonian Astrophysical Observation", "SAO 137904"},
        {"Wilson Evans Batten Catalogue", "WEB 9717"},
    },
    visualMagnitude: 6.88,
    bvColour: 0.421,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(164.28336294),
        dec: Angle.Degrees(-00.31188971)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -107.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -30.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139590"},
        {"Hipparcos Number", "HIP 76635"},
        {"Geneva Identification System", "GEN# +1.00139590"},
        {"Smithsonian Astrophysical Observation", "SAO 140680"},
        {"Wilson Evans Batten Catalogue", "WEB 13010"},
    },
    visualMagnitude: 7.50,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.75490808),
        dec: Angle.Degrees(-00.31129859)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -208.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -82.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40061",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 68103"},
        {"Hipparcos Number", "HIP 40061"},
        {"Geneva Identification System", "GEN# +1.00068103"},
        {"Smithsonian Astrophysical Observation", "SAO 135590"},
    },
    visualMagnitude: 8.87,
    bvColour: 0.062,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.75469630),
        dec: Angle.Degrees(-00.31123620)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171978"},
        {"Hipparcos Number", "HIP 91322"},
        {"Fundamental Katalog 5th Edition", "FK5 3480"},
        {"Geneva Identification System", "GEN# +1.00171978"},
        {"Renson", "Renson 48190"},
        {"Smithsonian Astrophysical Observation", "SAO 142444"},
        {"Wilson Evans Batten Catalogue", "WEB 15692"},
    },
    visualMagnitude: 5.76,
    bvColour: 0.067,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(279.39981039),
        dec: Angle.Degrees(-00.30942411)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41983",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72526"},
        {"Hipparcos Number", "HIP 41983"},
        {"Geneva Identification System", "GEN# +1.00072526"},
        {"Smithsonian Astrophysical Observation", "SAO 136030"},
    },
    visualMagnitude: 7.93,
    bvColour: -0.005,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(128.35569266),
        dec: Angle.Degrees(-00.30806508)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21349",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29106"},
        {"Hipparcos Number", "HIP 21349"},
        {"Smithsonian Astrophysical Observation", "SAO 131326"},
    },
    visualMagnitude: 8.47,
    bvColour: 1.582,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.71794361),
        dec: Angle.Degrees(-00.30803032)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61992",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 110469"},
        {"Hipparcos Number", "HIP 61992"},
        {"Geneva Identification System", "GEN# +1.00110469"},
        {"Smithsonian Astrophysical Observation", "SAO 138923"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(190.57356514),
        dec: Angle.Degrees(-00.30800590)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 18.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 1050"},
        {"Hipparcos Number", "HIP 1189"},
        {"Smithsonian Astrophysical Observation", "SAO 128658"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.70889000),
        dec: Angle.Degrees(-00.30292564)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 42335"},
        {"Hipparcos Number", "HIP 29253"},
        {"Geneva Identification System", "GEN# +1.00042335"},
        {"Renson", "Renson 11290"},
        {"Smithsonian Astrophysical Observation", "SAO 132904"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(092.52221146),
        dec: Angle.Degrees(-00.30237378)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34724",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55057"},
        {"Hipparcos Number", "HIP 34724"},
        {"Geneva Identification System", "GEN# +1.00055057"},
        {"Smithsonian Astrophysical Observation", "SAO 134316"},
        {"Wilson Evans Batten Catalogue", "WEB 6941"},
    },
    visualMagnitude: 5.44,
    bvColour: 0.310,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.84846508),
        dec: Angle.Degrees(-00.30190562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71765"},
        {"Hipparcos Number", "HIP 41622"},
        {"Geneva Identification System", "GEN# +1.00071765"},
        {"Smithsonian Astrophysical Observation", "SAO 135966"},
    },
    visualMagnitude: 7.74,
    bvColour: -0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.28321708),
        dec: Angle.Degrees(-00.30012470)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198126"},
        {"Hipparcos Number", "HIP 102662"},
        {"Geneva Identification System", "GEN# +1.00198126"},
        {"Smithsonian Astrophysical Observation", "SAO 144825"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.267,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(312.05958804),
        dec: Angle.Degrees(-00.29936199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 13.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69219",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123881"},
        {"Hipparcos Number", "HIP 69219"},
        {"Smithsonian Astrophysical Observation", "SAO 139769"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.698,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(212.56581370),
        dec: Angle.Degrees(-00.29920394)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25930",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Mintaka"},
        {"Aitken", "ADS 4134 A"},
        {"Henry Draper", "HD 36486"},
        {"Hipparcos Number", "HIP 25930"},
        {"Celescope Catalog", "CEL 764"},
        {"Fundamental Katalog 5th Edition", "FK5 206"},
        {"Geneva Identification System", "GEN# +1.00036486A"},
        {"Smithsonian Astrophysical Observation", "SAO 132220"},
        {"Wilson Evans Batten Catalogue", "WEB 5041"},
    },
    visualMagnitude: 2.25,
    bvColour: -0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.00166562),
        dec: Angle.Degrees(-00.29909340)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17506",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23413"},
        {"Hipparcos Number", "HIP 17506"},
        {"Geneva Identification System", "GEN# +1.00023413"},
        {"Smithsonian Astrophysical Observation", "SAO 130704"},
        {"Wilson Evans Batten Catalogue", "WEB 3318"},
    },
    visualMagnitude: 5.56,
    bvColour: 1.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(056.23526063),
        dec: Angle.Degrees(-00.29671559)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114211",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218409"},
        {"Hipparcos Number", "HIP 114211"},
        {"Geneva Identification System", "GEN# +1.00218409"},
        {"Smithsonian Astrophysical Observation", "SAO 146521"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.150,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.94033780),
        dec: Angle.Degrees(-00.29604027)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32977",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 50209"},
        {"Hipparcos Number", "HIP 32977"},
        {"Geneva Identification System", "GEN# +1.00050209"},
        {"Smithsonian Astrophysical Observation", "SAO 133798"},
        {"Wilson Evans Batten Catalogue", "WEB 6638"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(103.04316430),
        dec: Angle.Degrees(-00.29553362)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61531",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109669"},
        {"Hipparcos Number", "HIP 61531"},
        {"Smithsonian Astrophysical Observation", "SAO 138869"},
    },
    visualMagnitude: 8.60,
    bvColour: 1.041,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(189.09463879),
        dec: Angle.Degrees(-00.29343372)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51428",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 51428"},
    },
    visualMagnitude: 10.94,
    bvColour: 1.555,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(157.54834875),
        dec: Angle.Degrees(-00.29339003)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99119",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190925"},
        {"Hipparcos Number", "HIP 99119"},
        {"Geneva Identification System", "GEN# +1.00190925"},
        {"Smithsonian Astrophysical Observation", "SAO 144084"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.84046903),
        dec: Angle.Degrees(-00.29101545)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8596",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 11296"},
        {"Hipparcos Number", "HIP 8596"},
        {"Geneva Identification System", "GEN# +1.00011296"},
        {"Smithsonian Astrophysical Observation", "SAO 129531"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.983,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(027.73307897),
        dec: Angle.Degrees(-00.28792771)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50195",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7694 AB"},
        {"Henry Draper", "HD 88831"},
        {"Hipparcos Number", "HIP 50195"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(153.70609683),
        dec: Angle.Degrees(-00.28711638)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -65.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94148",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12108 AB"},
        {"Henry Draper", "HD 178743"},
        {"Hipparcos Number", "HIP 94148"},
        {"Smithsonian Astrophysical Observation", "SAO 143086"},
    },
    visualMagnitude: 9.15,
    bvColour: 0.399,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.45873558),
        dec: Angle.Degrees(-00.28676018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 292079"},
        {"Hipparcos Number", "HIP 32058"},
        {"Smithsonian Astrophysical Observation", "SAO 133581"},
    },
    visualMagnitude: 8.99,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.47250892),
        dec: Angle.Degrees(-00.28657109)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117902",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224063"},
        {"Hipparcos Number", "HIP 117902"},
        {"Geneva Identification System", "GEN# +1.00224063"},
        {"Smithsonian Astrophysical Observation", "SAO 146974"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.734,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.72054756),
        dec: Angle.Degrees(-00.28562263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 172.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82901",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82901"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.789,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(254.11661460),
        dec: Angle.Degrees(-00.28384781)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -66.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96193",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12591 A"},
        {"Henry Draper", "HD 184264"},
        {"Hipparcos Number", "HIP 96193"},
        {"Smithsonian Astrophysical Observation", "SAO 143534"},
    },
    visualMagnitude: 8.09,
    bvColour: 0.390,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.39674887),
        dec: Angle.Degrees(-00.28341522)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.33 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24053",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289997"},
        {"Hipparcos Number", "HIP 24053"},
    },
    visualMagnitude: 10.01,
    bvColour: 0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(077.53266422),
        dec: Angle.Degrees(-00.28292674)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60641",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108189"},
        {"Hipparcos Number", "HIP 60641"},
        {"Geneva Identification System", "GEN# +1.00108189"},
        {"Smithsonian Astrophysical Observation", "SAO 138774"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.795,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.41929241),
        dec: Angle.Degrees(-00.28224273)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -80.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 27.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72339",
    secondaryIds: new Dictionary<string,string>{
        {"Common Name", "Monch"},
        {"Henry Draper", "HD 130322"},
        {"Hipparcos Number", "HIP 72339"},
        {"Fundamental Katalog 5th Edition", "FK5 5310"},
        {"Geneva Identification System", "GEN# +1.00130322"},
        {"Smithsonian Astrophysical Observation", "SAO 140142"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.781,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(221.88667704),
        dec: Angle.Degrees(-00.28113382)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -129.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118307",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224677"},
        {"Hipparcos Number", "HIP 118307"},
        {"Geneva Identification System", "GEN# +1.00224677"},
        {"Smithsonian Astrophysical Observation", "SAO 147018"},
        {"Wilson Evans Batten Catalogue", "WEB 20794"},
    },
    visualMagnitude: 6.83,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.94372764),
        dec: Angle.Degrees(-00.28005255)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 84050"},
        {"Hipparcos Number", "HIP 47604"},
        {"Geneva Identification System", "GEN# +1.00084050"},
        {"Smithsonian Astrophysical Observation", "SAO 137065"},
    },
    visualMagnitude: 6.64,
    bvColour: 0.863,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(145.59734437),
        dec: Angle.Degrees(-00.27946885)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 92559"},
        {"Hipparcos Number", "HIP 52301"},
        {"Geneva Identification System", "GEN# +1.00092559"},
        {"Smithsonian Astrophysical Observation", "SAO 137725"},
    },
    visualMagnitude: 7.52,
    bvColour: 0.361,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.29393865),
        dec: Angle.Degrees(-00.27622649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -37.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -34.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 45433"},
        {"Hipparcos Number", "HIP 30720"},
        {"Geneva Identification System", "GEN# +1.00045433"},
        {"Smithsonian Astrophysical Observation", "SAO 133269"},
        {"Wilson Evans Batten Catalogue", "WEB 6128"},
    },
    visualMagnitude: 5.55,
    bvColour: 1.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(096.81496020),
        dec: Angle.Degrees(-00.27598684)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 61240",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 109204"},
        {"Hipparcos Number", "HIP 61240"},
        {"Geneva Identification System", "GEN# +1.00109204"},
        {"Smithsonian Astrophysical Observation", "SAO 119461"},
    },
    visualMagnitude: 8.31,
    bvColour: 0.427,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(188.24554152),
        dec: Angle.Degrees(-00.27359777)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 55.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78825"},
        {"Hipparcos Number", "HIP 45025"},
        {"Smithsonian Astrophysical Observation", "SAO 136633"},
    },
    visualMagnitude: 8.02,
    bvColour: 1.588,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.57176768),
        dec: Angle.Degrees(-00.27293078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52327",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 7885 AB"},
        {"Henry Draper", "HD 92614"},
        {"Hipparcos Number", "HIP 52327"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.470,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(160.39763129),
        dec: Angle.Degrees(-00.27245320)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73722",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73722"},
        {"Geneva Identification System", "GEN# +0.00003300"},
    },
    visualMagnitude: 9.70,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.05084651),
        dec: Angle.Degrees(-00.27177649)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -50.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77335",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 141103"},
        {"Hipparcos Number", "HIP 77335"},
        {"Geneva Identification System", "GEN# +1.00141103"},
        {"Smithsonian Astrophysical Observation", "SAO 140761"},
    },
    visualMagnitude: 6.94,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.82179653),
        dec: Angle.Degrees(-00.26985699)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -243.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -23.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26210",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36935"},
        {"Hipparcos Number", "HIP 26210"},
        {"Celescope Catalog", "CEL 820"},
        {"Geneva Identification System", "GEN# +1.00036935"},
        {"Smithsonian Astrophysical Observation", "SAO 132300"},
    },
    visualMagnitude: 7.50,
    bvColour: -0.116,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.78835644),
        dec: Angle.Degrees(-00.26960062)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202395"},
        {"Hipparcos Number", "HIP 104947"},
        {"Smithsonian Astrophysical Observation", "SAO 145243"},
    },
    visualMagnitude: 8.25,
    bvColour: 0.944,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.87873376),
        dec: Angle.Degrees(-00.26879787)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18859",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25457"},
        {"Hipparcos Number", "HIP 18859"},
        {"Geneva Identification System", "GEN# +1.00025457"},
        {"Smithsonian Astrophysical Observation", "SAO 130893"},
        {"Wilson Evans Batten Catalogue", "WEB 3630"},
    },
    visualMagnitude: 5.38,
    bvColour: 0.516,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.65273634),
        dec: Angle.Degrees(-00.26831052)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.20 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -252.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12443",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 16658"},
        {"Hipparcos Number", "HIP 12443"},
        {"Smithsonian Astrophysical Observation", "SAO 130046"},
    },
    visualMagnitude: 8.52,
    bvColour: 1.014,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.04956985),
        dec: Angle.Degrees(-00.26671035)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 5181",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 6529"},
        {"Hipparcos Number", "HIP 5181"},
        {"Geneva Identification System", "GEN# +1.00006529"},
        {"Smithsonian Astrophysical Observation", "SAO 129120"},
        {"Wilson Evans Batten Catalogue", "WEB 1082"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.450,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(016.56418220),
        dec: Angle.Degrees(-00.26534486)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31291",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46486"},
        {"Hipparcos Number", "HIP 31291"},
        {"Geneva Identification System", "GEN# +1.00046486"},
        {"Smithsonian Astrophysical Observation", "SAO 133406"},
    },
    visualMagnitude: 8.33,
    bvColour: 0.011,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.43174181),
        dec: Angle.Degrees(-00.26422598)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80266",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147642"},
        {"Hipparcos Number", "HIP 80266"},
        {"Geneva Identification System", "GEN# +1.00147642"},
        {"Smithsonian Astrophysical Observation", "SAO 141137"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.571,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.78171684),
        dec: Angle.Degrees(-00.26347004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -47.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57782",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57782"},
    },
    visualMagnitude: 10.78,
    bvColour: 1.045,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.73433830),
        dec: Angle.Degrees(-00.26091436)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 10930"},
    },
    visualMagnitude: 11.06,
    bvColour: 0.643,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(035.19693412),
        dec: Angle.Degrees(-00.26081909)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 48.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37243",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61367"},
        {"Hipparcos Number", "HIP 37243"},
        {"Geneva Identification System", "GEN# +1.00061367"},
        {"Smithsonian Astrophysical Observation", "SAO 134937"},
        {"Wilson Evans Batten Catalogue", "WEB 7377"},
    },
    visualMagnitude: 6.76,
    bvColour: 1.710,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.73658871),
        dec: Angle.Degrees(-00.26042123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79627",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 146170"},
        {"Hipparcos Number", "HIP 79627"},
        {"Smithsonian Astrophysical Observation", "SAO 141058"},
    },
    visualMagnitude: 7.94,
    bvColour: 1.289,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.73110114),
        dec: Angle.Degrees(-00.26029067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34904",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 55533"},
        {"Hipparcos Number", "HIP 34904"},
        {"Geneva Identification System", "GEN# +1.00055533"},
        {"Smithsonian Astrophysical Observation", "SAO 134365"},
    },
    visualMagnitude: 6.68,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.32662942),
        dec: Angle.Degrees(-00.25951829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35754",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 57733"},
        {"Hipparcos Number", "HIP 35754"},
        {"Geneva Identification System", "GEN# +1.00057733"},
        {"Smithsonian Astrophysical Observation", "SAO 134587"},
    },
    visualMagnitude: 6.78,
    bvColour: -0.053,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.62857354),
        dec: Angle.Degrees(-00.25933144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -21.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25548",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35867"},
        {"Hipparcos Number", "HIP 25548"},
        {"Geneva Identification System", "GEN# +1.00035867"},
        {"Smithsonian Astrophysical Observation", "SAO 132131"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(081.93018584),
        dec: Angle.Degrees(-00.25912905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72629",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130970"},
        {"Hipparcos Number", "HIP 72629"},
        {"Geneva Identification System", "GEN# +1.00130970"},
        {"Smithsonian Astrophysical Observation", "SAO 140177"},
        {"Wilson Evans Batten Catalogue", "WEB 12486"},
    },
    visualMagnitude: 6.18,
    bvColour: 1.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.75047349),
        dec: Angle.Degrees(-00.25750738)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49600",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 87789"},
        {"Hipparcos Number", "HIP 49600"},
        {"Smithsonian Astrophysical Observation", "SAO 137361"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.942,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(151.87053682),
        dec: Angle.Degrees(-00.25689403)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64571",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 114977"},
        {"Hipparcos Number", "HIP 64571"},
        {"Smithsonian Astrophysical Observation", "SAO 119824"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.415,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(198.52481065),
        dec: Angle.Degrees(-00.25654834)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57703",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 57703"},
    },
    visualMagnitude: 10.88,
    bvColour: 0.615,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(177.50862871),
        dec: Angle.Degrees(-00.25585267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43046",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 74816"},
        {"Hipparcos Number", "HIP 43046"},
        {"Geneva Identification System", "GEN# +1.00074816"},
        {"Smithsonian Astrophysical Observation", "SAO 136256"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.914,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.55171744),
        dec: Angle.Degrees(-00.25546901)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9299",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12165"},
        {"Hipparcos Number", "HIP 9299"},
        {"Smithsonian Astrophysical Observation", "SAO 129608"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.645,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(029.86597938),
        dec: Angle.Degrees(-00.25276581)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -104.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105756",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203905"},
        {"Hipparcos Number", "HIP 105756"},
        {"Smithsonian Astrophysical Observation", "SAO 145383"},
    },
    visualMagnitude: 9.44,
    bvColour: 0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.29627332),
        dec: Angle.Degrees(-00.25245325)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95222",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181907"},
        {"Hipparcos Number", "HIP 95222"},
        {"Fundamental Katalog 5th Edition", "FK5 3546"},
        {"Geneva Identification System", "GEN# +1.00181907"},
        {"Smithsonian Astrophysical Observation", "SAO 143324"},
        {"Wilson Evans Batten Catalogue", "WEB 16637"},
    },
    visualMagnitude: 5.81,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(290.58962436),
        dec: Angle.Degrees(-00.25227829)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 60.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29899",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 291456"},
        {"Hipparcos Number", "HIP 29899"},
    },
    visualMagnitude: 9.76,
    bvColour: 2.950,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.43157904),
        dec: Angle.Degrees(-00.25181017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107745"},
        {"Hipparcos Number", "HIP 60378"},
        {"Smithsonian Astrophysical Observation", "SAO 119364"},
    },
    visualMagnitude: 9.40,
    bvColour: 0.465,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.70454055),
        dec: Angle.Degrees(-00.24971889)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71664",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 128866"},
        {"Hipparcos Number", "HIP 71664"},
        {"Geneva Identification System", "GEN# +1.00128866"},
        {"Smithsonian Astrophysical Observation", "SAO 140054"},
    },
    visualMagnitude: 9.09,
    bvColour: 0.704,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(219.86804039),
        dec: Angle.Degrees(-00.24886960)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -84.01 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14888",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19928"},
        {"Hipparcos Number", "HIP 14888"},
        {"Geneva Identification System", "GEN# +1.00019928"},
        {"Smithsonian Astrophysical Observation", "SAO 130344"},
    },
    visualMagnitude: 7.67,
    bvColour: 1.080,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.04068407),
        dec: Angle.Degrees(-00.24527232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3738",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4606"},
        {"Hipparcos Number", "HIP 3738"},
        {"Geneva Identification System", "GEN# +1.00004606"},
        {"Smithsonian Astrophysical Observation", "SAO 128962"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.968,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.00196996),
        dec: Angle.Degrees(-00.24238657)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7779",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10232"},
        {"Hipparcos Number", "HIP 7779"},
        {"Geneva Identification System", "GEN# +1.00010232"},
        {"Smithsonian Astrophysical Observation", "SAO 129435"},
    },
    visualMagnitude: 7.27,
    bvColour: 0.445,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.02920657),
        dec: Angle.Degrees(-00.24228931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37294"},
        {"Hipparcos Number", "HIP 26431"},
        {"Geneva Identification System", "GEN# +1.00037294"},
        {"Smithsonian Astrophysical Observation", "SAO 132374"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.37624810),
        dec: Angle.Degrees(-00.24041043)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 184700"},
        {"Hipparcos Number", "HIP 96379"},
        {"Cincinnati Publication", "Ci 18 2560"},
        {"Geneva Identification System", "GEN# +1.00184700"},
        {"Smithsonian Astrophysical Observation", "SAO 143573"},
        {"Wilson Evans Batten Catalogue", "WEB 16902"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.663,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(293.93719564),
        dec: Angle.Degrees(-00.23964189)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -82.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -326.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211575"},
        {"Hipparcos Number", "HIP 110091"},
        {"Geneva Identification System", "GEN# +1.00211575"},
        {"Smithsonian Astrophysical Observation", "SAO 146004"},
    },
    visualMagnitude: 6.39,
    bvColour: 0.441,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(334.51790289),
        dec: Angle.Degrees(-00.23752268)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -41.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -54.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127405"},
        {"Hipparcos Number", "HIP 70989"},
        {"Smithsonian Astrophysical Observation", "SAO 139982"},
    },
    visualMagnitude: 9.35,
    bvColour: 0.580,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(217.79823334),
        dec: Angle.Degrees(-00.23740547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -22.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 92224",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 173883"},
        {"Hipparcos Number", "HIP 92224"},
        {"Geneva Identification System", "GEN# +1.00173883"},
        {"Smithsonian Astrophysical Observation", "SAO 142626"},
        {"Wilson Evans Batten Catalogue", "WEB 15907"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.595,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(281.93518367),
        dec: Angle.Degrees(-00.23628951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 45.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104430",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 201377"},
        {"Hipparcos Number", "HIP 104430"},
        {"Geneva Identification System", "GEN# +1.00201377"},
        {"Smithsonian Astrophysical Observation", "SAO 145152"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.175,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.31653914),
        dec: Angle.Degrees(-00.23491698)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 66.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69529",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69529"},
    },
    visualMagnitude: 10.32,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(213.50715800),
        dec: Angle.Degrees(-00.23235285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -35.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 105800",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 203978"},
        {"Hipparcos Number", "HIP 105800"},
        {"Smithsonian Astrophysical Observation", "SAO 145391"},
    },
    visualMagnitude: 7.60,
    bvColour: 1.606,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(321.39552821),
        dec: Angle.Degrees(-00.23189746)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75126",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136515"},
        {"Hipparcos Number", "HIP 75126"},
        {"Geneva Identification System", "GEN# +1.00136515"},
        {"Smithsonian Astrophysical Observation", "SAO 140476"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(230.27921515),
        dec: Angle.Degrees(-00.23133782)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63428",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112889"},
        {"Hipparcos Number", "HIP 63428"},
        {"Smithsonian Astrophysical Observation", "SAO 119703"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(194.97179452),
        dec: Angle.Degrees(-00.23030136)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 968",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 766"},
        {"Hipparcos Number", "HIP 968"},
        {"Geneva Identification System", "GEN# +1.00000766"},
        {"Smithsonian Astrophysical Observation", "SAO 128634"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.403,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.99704490),
        dec: Angle.Degrees(-00.22969837)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48252",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85180"},
        {"Hipparcos Number", "HIP 48252"},
        {"Smithsonian Astrophysical Observation", "SAO 117933"},
    },
    visualMagnitude: 7.12,
    bvColour: 1.107,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.55096163),
        dec: Angle.Degrees(-00.22845337)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58908",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 58908"},
    },
    visualMagnitude: 10.79,
    bvColour: 1.577,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(181.19962887),
        dec: Angle.Degrees(-00.22661763)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -105.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91886",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 11614 AB"},
        {"Henry Draper", "HD 173160"},
        {"Hipparcos Number", "HIP 91886"},
        {"Smithsonian Astrophysical Observation", "SAO 142560"},
        {"Wilson Evans Batten Catalogue", "WEB 15819"},
    },
    visualMagnitude: 8.04,
    bvColour: 0.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(280.97312641),
        dec: Angle.Degrees(-00.22438794)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3889",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4790"},
        {"Hipparcos Number", "HIP 3889"},
        {"Fundamental Katalog 5th Edition", "FK5 4072"},
        {"Geneva Identification System", "GEN# +1.00004790"},
        {"Smithsonian Astrophysical Observation", "SAO 128974"},
    },
    visualMagnitude: 6.64,
    bvColour: 1.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.47892003),
        dec: Angle.Degrees(-00.22411718)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66460",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 118526"},
        {"Hipparcos Number", "HIP 66460"},
        {"Fundamental Katalog 5th Edition", "FK5 5200"},
        {"Geneva Identification System", "GEN# +1.00118526"},
        {"Smithsonian Astrophysical Observation", "SAO 120039"},
        {"Wilson Evans Batten Catalogue", "WEB 11731"},
    },
    visualMagnitude: 8.77,
    bvColour: 0.347,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(204.37639231),
        dec: Angle.Degrees(-00.22150498)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 22993"},
        {"Hipparcos Number", "HIP 17230"},
        {"Geneva Identification System", "GEN# +1.00022993"},
        {"Smithsonian Astrophysical Observation", "SAO 130665"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.106,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.35514563),
        dec: Angle.Degrees(-00.22040757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50720",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89734"},
        {"Hipparcos Number", "HIP 50720"},
        {"Geneva Identification System", "GEN# +1.00089734"},
        {"Smithsonian Astrophysical Observation", "SAO 118251"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.511,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(155.34284874),
        dec: Angle.Degrees(-00.22032585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27960",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39803"},
        {"Hipparcos Number", "HIP 27960"},
    },
    visualMagnitude: 9.22,
    bvColour: 0.236,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(088.72722886),
        dec: Angle.Degrees(-00.21833551)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224908"},
        {"Hipparcos Number", "HIP 135"},
        {"Smithsonian Astrophysical Observation", "SAO 147040"},
    },
    visualMagnitude: 8.64,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.42674592),
        dec: Angle.Degrees(-00.21749947)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -114.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28982",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41734"},
        {"Hipparcos Number", "HIP 28982"},
        {"Geneva Identification System", "GEN# +1.00041734"},
        {"Smithsonian Astrophysical Observation", "SAO 132844"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.026,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.73521322),
        dec: Angle.Degrees(-00.21570160)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 115624",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 220643"},
        {"Hipparcos Number", "HIP 115624"},
        {"Smithsonian Astrophysical Observation", "SAO 146698"},
    },
    visualMagnitude: 9.42,
    bvColour: 0.269,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(351.35117755),
        dec: Angle.Degrees(-00.21523223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70457",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 70457"},
        {"Smithsonian Astrophysical Observation", "SAO 120441"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.114,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.19110594),
        dec: Angle.Degrees(-00.21160263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 107413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 206925"},
        {"Hipparcos Number", "HIP 107413"},
        {"Smithsonian Astrophysical Observation", "SAO 145642"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.066,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(326.34313855),
        dec: Angle.Degrees(-00.21055271)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 50558",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 89488"},
        {"Hipparcos Number", "HIP 50558"},
        {"Geneva Identification System", "GEN# +1.00089488"},
        {"Smithsonian Astrophysical Observation", "SAO 118222"},
    },
    visualMagnitude: 7.70,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(154.91321670),
        dec: Angle.Degrees(-00.20989054)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32711",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 49660"},
        {"Hipparcos Number", "HIP 32711"},
        {"Fundamental Katalog 5th Edition", "FK5 4621"},
        {"Smithsonian Astrophysical Observation", "SAO 133722"},
        {"Wilson Evans Batten Catalogue", "WEB 6590"},
    },
    visualMagnitude: 9.02,
    bvColour: -0.027,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(102.36933563),
        dec: Angle.Degrees(-00.20965415)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111025",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15984 AB"},
        {"Henry Draper", "HD 213162"},
        {"Hipparcos Number", "HIP 111025"},
    },
    visualMagnitude: 7.74,
    bvColour: 0.544,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.38666322),
        dec: Angle.Degrees(-00.20502676)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 86.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 49280",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 49280"},
    },
    visualMagnitude: 10.00,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(150.88911985),
        dec: Angle.Degrees(-00.20417667)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 94237"},
        {"Hipparcos Number", "HIP 53167"},
        {"Geneva Identification System", "GEN# +1.00094237"},
        {"Smithsonian Astrophysical Observation", "SAO 118555"},
        {"Wilson Evans Batten Catalogue", "WEB 9655"},
    },
    visualMagnitude: 6.31,
    bvColour: 1.503,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.15039855),
        dec: Angle.Degrees(-00.20159519)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82181",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 82181"},
    },
    visualMagnitude: 10.08,
    bvColour: 1.713,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(251.84364267),
        dec: Angle.Degrees(-00.20053408)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98600",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 13259 AB"},
        {"Henry Draper", "HD 189759"},
        {"Hipparcos Number", "HIP 98600"},
        {"Smithsonian Astrophysical Observation", "SAO 144002"},
    },
    visualMagnitude: 7.22,
    bvColour: 0.172,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.41318920),
        dec: Angle.Degrees(-00.19902651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147871"},
        {"Hipparcos Number", "HIP 80373"},
        {"Smithsonian Astrophysical Observation", "SAO 141151"},
    },
    visualMagnitude: 8.51,
    bvColour: 1.608,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(246.10183108),
        dec: Angle.Degrees(-00.19667898)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22808",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22808"},
        {"Geneva Identification System", "GEN# -0.00000796"},
        {"Smithsonian Astrophysical Observation", "SAO 131585"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.60969397),
        dec: Angle.Degrees(-00.19663017)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.55 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 218249"},
        {"Hipparcos Number", "HIP 114098"},
        {"Cincinnati Publication", "Ci 18 3021"},
        {"Smithsonian Astrophysical Observation", "SAO 146513"},
    },
    visualMagnitude: 9.33,
    bvColour: 0.879,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(346.63581164),
        dec: Angle.Degrees(-00.19606931)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -236.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78895",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 144518"},
        {"Hipparcos Number", "HIP 78895"},
        {"Smithsonian Astrophysical Observation", "SAO 140955"},
    },
    visualMagnitude: 8.32,
    bvColour: 1.077,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.58615127),
        dec: Angle.Degrees(-00.19528706)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 32024"},
        {"Hipparcos Number", "HIP 23255"},
        {"Fundamental Katalog 5th Edition", "FK5 4455"},
        {"Geneva Identification System", "GEN# +1.00032024"},
        {"Smithsonian Astrophysical Observation", "SAO 131672"},
        {"Wilson Evans Batten Catalogue", "WEB 4518"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.411,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.06270401),
        dec: Angle.Degrees(-00.19377876)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69009",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123441"},
        {"Hipparcos Number", "HIP 69009"},
        {"Geneva Identification System", "GEN# +1.00123441"},
        {"Smithsonian Astrophysical Observation", "SAO 120294"},
    },
    visualMagnitude: 7.97,
    bvColour: 0.818,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.91625742),
        dec: Angle.Degrees(-00.18997013)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 113905"},
        {"Hipparcos Number", "HIP 64001"},
        {"Smithsonian Astrophysical Observation", "SAO 119768"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(196.72364757),
        dec: Angle.Degrees(-00.18962450)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55304",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98439"},
        {"Hipparcos Number", "HIP 55304"},
        {"Smithsonian Astrophysical Observation", "SAO 118786"},
    },
    visualMagnitude: 7.90,
    bvColour: 0.569,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(169.88706193),
        dec: Angle.Degrees(-00.18792460)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 70.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -151.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 79410"},
        {"Hipparcos Number", "HIP 45297"},
        {"Smithsonian Astrophysical Observation", "SAO 117519"},
    },
    visualMagnitude: 7.73,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(138.46931632),
        dec: Angle.Degrees(-00.18707296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -64.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.75 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 214142"},
        {"Hipparcos Number", "HIP 111583"},
        {"Geneva Identification System", "GEN# +1.00214142"},
        {"Smithsonian Astrophysical Observation", "SAO 146192"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.156,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(339.08068103),
        dec: Angle.Degrees(-00.18640835)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 46485",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 81941"},
        {"Hipparcos Number", "HIP 46485"},
        {"Smithsonian Astrophysical Observation", "SAO 117723"},
    },
    visualMagnitude: 8.40,
    bvColour: 1.119,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(142.21830355),
        dec: Angle.Degrees(-00.18601314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.42 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90388",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169846"},
        {"Hipparcos Number", "HIP 90388"},
        {"Smithsonian Astrophysical Observation", "SAO 142319"},
    },
    visualMagnitude: 8.30,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.64895146),
        dec: Angle.Degrees(-00.18533743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.38 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85380",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158000"},
        {"Hipparcos Number", "HIP 85380"},
        {"Smithsonian Astrophysical Observation", "SAO 141668"},
    },
    visualMagnitude: 8.11,
    bvColour: 1.091,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(261.69028631),
        dec: Angle.Degrees(-00.18484694)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26494",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4234 AB"},
        {"Henry Draper", "HD 37370"},
        {"Hipparcos Number", "HIP 26494"},
        {"Celescope Catalog", "CEL 877"},
        {"Geneva Identification System", "GEN# +1.00037370J"},
    },
    visualMagnitude: 7.46,
    bvColour: -0.028,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.52715099),
        dec: Angle.Degrees(-00.18429895)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27536",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 39034"},
        {"Hipparcos Number", "HIP 27536"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.032,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.47365427),
        dec: Angle.Degrees(-00.18358821)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60726",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 8550 AB"},
        {"Henry Draper", "HD 108318"},
        {"Hipparcos Number", "HIP 60726"},
        {"Smithsonian Astrophysical Observation", "SAO 119399"},
    },
    visualMagnitude: 7.72,
    bvColour: 0.300,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.69116088),
        dec: Angle.Degrees(-00.18331780)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 72212"},
        {"Hipparcos Number", "HIP 41827"},
        {"Smithsonian Astrophysical Observation", "SAO 136002"},
    },
    visualMagnitude: 8.35,
    bvColour: 1.186,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.91443318),
        dec: Angle.Degrees(-00.18306016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48632",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85904"},
        {"Hipparcos Number", "HIP 48632"},
        {"Geneva Identification System", "GEN# +1.00085904"},
        {"Smithsonian Astrophysical Observation", "SAO 117989"},
        {"Wilson Evans Batten Catalogue", "WEB 9051"},
    },
    visualMagnitude: 7.93,
    bvColour: 1.551,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.75235938),
        dec: Angle.Degrees(-00.18227650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26500",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4234 C"},
        {"Henry Draper", "HD 37371"},
        {"Hipparcos Number", "HIP 26500"},
        {"Geneva Identification System", "GEN# +1.00037371A"},
        {"Geneva Identification System 2", "GEN# +1.00037371C"},
    },
    visualMagnitude: 8.56,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.53845705),
        dec: Angle.Degrees(-00.18216202)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102301",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 102301"},
    },
    visualMagnitude: 11.46,
    bvColour: 1.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(310.92133141),
        dec: Angle.Degrees(-00.17882755)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 362.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 254.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11350",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15105"},
        {"Hipparcos Number", "HIP 11350"},
        {"Geneva Identification System", "GEN# +1.00015105"},
        {"Smithsonian Astrophysical Observation", "SAO 129898"},
        {"Wilson Evans Batten Catalogue", "WEB 2370"},
    },
    visualMagnitude: 9.12,
    bvColour: 1.322,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(036.50962250),
        dec: Angle.Degrees(-00.17828965)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.28 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116014",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 116014"},
        {"Smithsonian Astrophysical Observation", "SAO 146744"},
    },
    visualMagnitude: 9.47,
    bvColour: 1.263,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(352.58748236),
        dec: Angle.Degrees(-00.17783385)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 15.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12019",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12019"},
    },
    visualMagnitude: 10.60,
    bvColour: 0.499,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(038.75929670),
        dec: Angle.Degrees(-00.17748356)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 57415",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 102265"},
        {"Hipparcos Number", "HIP 57415"},
        {"Smithsonian Astrophysical Observation", "SAO 119040"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.462,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(176.56733534),
        dec: Angle.Degrees(-00.17190779)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15583",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20772"},
        {"Hipparcos Number", "HIP 15583"},
        {"Geneva Identification System", "GEN# +1.00020772"},
        {"Renson", "Renson 5190"},
        {"Smithsonian Astrophysical Observation", "SAO 130430"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.18582588),
        dec: Angle.Degrees(-00.16940182)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158462"},
        {"Hipparcos Number", "HIP 85603"},
        {"Geneva Identification System", "GEN# +1.00158462"},
        {"Smithsonian Astrophysical Observation", "SAO 141689"},
    },
    visualMagnitude: 7.81,
    bvColour: 0.388,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.38643225),
        dec: Angle.Degrees(-00.16910644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8098",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 10657"},
        {"Hipparcos Number", "HIP 8098"},
        {"Geneva Identification System", "GEN# +1.00010657"},
        {"Smithsonian Astrophysical Observation", "SAO 129478"},
    },
    visualMagnitude: 8.80,
    bvColour: 0.909,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(025.99968501),
        dec: Angle.Degrees(-00.16887558)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74925",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 136067"},
        {"Hipparcos Number", "HIP 74925"},
        {"Geneva Identification System", "GEN# +1.00136067"},
        {"Smithsonian Astrophysical Observation", "SAO 120942"},
    },
    visualMagnitude: 8.85,
    bvColour: 0.453,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.66272099),
        dec: Angle.Degrees(-00.16773405)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -29.90 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73193",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 132132"},
        {"Hipparcos Number", "HIP 73193"},
        {"Fundamental Katalog 5th Edition", "FK5 1393"},
        {"Geneva Identification System", "GEN# +1.00132132A"},
        {"Smithsonian Astrophysical Observation", "SAO 120758"},
        {"Wilson Evans Batten Catalogue", "WEB 12544"},
    },
    visualMagnitude: 5.51,
    bvColour: 1.131,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.38840115),
        dec: Angle.Degrees(-00.16754803)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68370",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122105"},
        {"Hipparcos Number", "HIP 68370"},
        {"Smithsonian Astrophysical Observation", "SAO 120210"},
    },
    visualMagnitude: 9.12,
    bvColour: 0.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.92582628),
        dec: Angle.Degrees(-00.16751711)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104279",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 14654 A"},
        {"Henry Draper", "HD 201098"},
        {"Hipparcos Number", "HIP 104279"},
        {"Smithsonian Astrophysical Observation", "SAO 145121"},
    },
    visualMagnitude: 6.61,
    bvColour: 1.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.88699718),
        dec: Angle.Degrees(-00.16383162)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.97 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.58 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76487",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 139287"},
        {"Hipparcos Number", "HIP 76487"},
        {"Geneva Identification System", "GEN# +1.00139287"},
        {"Smithsonian Astrophysical Observation", "SAO 121093"},
    },
    visualMagnitude: 8.43,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(234.32547016),
        dec: Angle.Degrees(-00.16371659)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 61.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17250",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23009"},
        {"Hipparcos Number", "HIP 17250"},
        {"Geneva Identification System", "GEN# +1.00023009"},
        {"Smithsonian Astrophysical Observation", "SAO 130668"},
    },
    visualMagnitude: 8.67,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.40866124),
        dec: Angle.Degrees(-00.16355430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60953",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 60953"},
    },
    visualMagnitude: 11.36,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(187.41685606),
        dec: Angle.Degrees(-00.16219732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -232.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -154.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35080",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5933 A"},
        {"Henry Draper", "HD 56003"},
        {"Hipparcos Number", "HIP 35080"},
        {"Geneva Identification System", "GEN# +1.00056003"},
        {"Smithsonian Astrophysical Observation", "SAO 134414"},
        {"Wilson Evans Batten Catalogue", "WEB 7012"},
    },
    visualMagnitude: 6.42,
    bvColour: 0.901,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(108.83088379),
        dec: Angle.Degrees(-00.16129299)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41001",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70435"},
        {"Hipparcos Number", "HIP 41001"},
        {"Geneva Identification System", "GEN# +1.00070435"},
        {"Smithsonian Astrophysical Observation", "SAO 116677"},
    },
    visualMagnitude: 7.78,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.51536758),
        dec: Angle.Degrees(-00.16007410)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 53123"},
    },
    visualMagnitude: 10.20,
    bvColour: 0.898,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(163.01112876),
        dec: Angle.Degrees(-00.15994987)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 55.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -256.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 10700",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 14193"},
        {"Hipparcos Number", "HIP 10700"},
        {"Geneva Identification System", "GEN# +1.00014193"},
        {"Smithsonian Astrophysical Observation", "SAO 129801"},
    },
    visualMagnitude: 7.71,
    bvColour: 1.407,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(034.43610743),
        dec: Angle.Degrees(-00.15987806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20445"},
        {"Hipparcos Number", "HIP 15302"},
        {"Geneva Identification System", "GEN# +1.00020445"},
        {"Smithsonian Astrophysical Observation", "SAO 130401"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.311,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.34708425),
        dec: Angle.Degrees(-00.15982736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25223",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35299"},
        {"Hipparcos Number", "HIP 25223"},
        {"Geneva Identification System", "GEN# +1.00035299"},
        {"Smithsonian Astrophysical Observation", "SAO 132057"},
        {"Wilson Evans Batten Catalogue", "WEB 4893"},
    },
    visualMagnitude: 5.69,
    bvColour: -0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(080.92628584),
        dec: Angle.Degrees(-00.15981294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43612",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75914"},
        {"Hipparcos Number", "HIP 43612"},
        {"Geneva Identification System", "GEN# +1.00075914"},
        {"Smithsonian Astrophysical Observation", "SAO 117229"},
    },
    visualMagnitude: 8.65,
    bvColour: 0.046,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(133.23981759),
        dec: Angle.Degrees(-00.15837673)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.82 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.95 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60280",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107534"},
        {"Hipparcos Number", "HIP 60280"},
        {"Fundamental Katalog 5th Edition", "FK5 5091"},
        {"Smithsonian Astrophysical Observation", "SAO 119352"},
    },
    visualMagnitude: 8.08,
    bvColour: 1.179,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.40764302),
        dec: Angle.Degrees(-00.15795627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6762",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8828"},
        {"Hipparcos Number", "HIP 6762"},
        {"Cincinnati Publication", "Ci 18 194"},
        {"Cincinnati Publication 2", "Ci 20 104"},
        {"Geneva Identification System", "GEN# +1.00008828"},
        {"Smithsonian Astrophysical Observation", "SAO 129305"},
    },
    visualMagnitude: 7.96,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.75571899),
        dec: Angle.Degrees(-00.15671666)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 298.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -358.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117016",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222753"},
        {"Hipparcos Number", "HIP 117016"},
        {"Geneva Identification System", "GEN# +1.00222753"},
        {"Smithsonian Astrophysical Observation", "SAO 146860"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.074,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.82428805),
        dec: Angle.Degrees(-00.15556928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101297",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195534"},
        {"Hipparcos Number", "HIP 101297"},
        {"Smithsonian Astrophysical Observation", "SAO 144534"},
        {"Wilson Evans Batten Catalogue", "WEB 18302"},
    },
    visualMagnitude: 7.48,
    bvColour: 1.113,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.97705969),
        dec: Angle.Degrees(-00.15443120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -27.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99253",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191231"},
        {"Hipparcos Number", "HIP 99253"},
        {"Geneva Identification System", "GEN# +1.00191231"},
        {"Smithsonian Astrophysical Observation", "SAO 144110"},
    },
    visualMagnitude: 8.15,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.21200639),
        dec: Angle.Degrees(-00.15421924)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100940",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100940"},
    },
    visualMagnitude: 10.75,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(306.99548835),
        dec: Angle.Degrees(-00.15143806)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -47.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100943",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 194844"},
        {"Hipparcos Number", "HIP 100943"},
        {"Smithsonian Astrophysical Observation", "SAO 144459"},
    },
    visualMagnitude: 9.05,
    bvColour: 1.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.00038029),
        dec: Angle.Degrees(-00.15135515)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21208",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28881"},
        {"Hipparcos Number", "HIP 21208"},
        {"Geneva Identification System", "GEN# +1.00028881"},
        {"Smithsonian Astrophysical Observation", "SAO 131280"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.238,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(068.23801709),
        dec: Angle.Degrees(-00.15080254)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -16.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 31455",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 46800"},
        {"Hipparcos Number", "HIP 31455"},
        {"Smithsonian Astrophysical Observation", "SAO 133440"},
    },
    visualMagnitude: 9.07,
    bvColour: -0.003,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(098.84960294),
        dec: Angle.Degrees(-00.15064878)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 51146",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 90484"},
        {"Hipparcos Number", "HIP 51146"},
        {"Smithsonian Astrophysical Observation", "SAO 118304"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.532,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(156.72435207),
        dec: Angle.Degrees(-00.14842599)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -33.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 37427"},
        {"Hipparcos Number", "HIP 26526"},
        {"Geneva Identification System", "GEN# +1.00037427J"},
        {"Smithsonian Astrophysical Observation", "SAO 132395"},
    },
    visualMagnitude: 8.61,
    bvColour: -0.024,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(084.63055914),
        dec: Angle.Degrees(-00.14778550)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1082",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 164"},
        {"Hipparcos Number", "HIP 1082"},
    },
    visualMagnitude: 10.68,
    bvColour: 0.738,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.36708471),
        dec: Angle.Degrees(-00.14768155)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -88.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -436.55 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76278",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138870"},
        {"Hipparcos Number", "HIP 76278"},
        {"Smithsonian Astrophysical Observation", "SAO 121069"},
    },
    visualMagnitude: 7.55,
    bvColour: 1.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.70657181),
        dec: Angle.Degrees(-00.14650342)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 83480",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 154145"},
        {"Hipparcos Number", "HIP 83480"},
        {"Fundamental Katalog 5th Edition", "FK5 5504"},
        {"Geneva Identification System", "GEN# +1.00154145"},
        {"Smithsonian Astrophysical Observation", "SAO 141503"},
    },
    visualMagnitude: 6.70,
    bvColour: 0.190,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(255.92274281),
        dec: Angle.Degrees(-00.14591149)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97212",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186609"},
        {"Hipparcos Number", "HIP 97212"},
        {"Geneva Identification System", "GEN# +1.00186609"},
        {"Smithsonian Astrophysical Observation", "SAO 143771"},
    },
    visualMagnitude: 7.88,
    bvColour: 0.356,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.36042776),
        dec: Angle.Degrees(-00.14540033)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4614",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5752"},
        {"Hipparcos Number", "HIP 4614"},
        {"Smithsonian Astrophysical Observation", "SAO 129060"},
    },
    visualMagnitude: 8.71,
    bvColour: 1.163,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(014.77956045),
        dec: Angle.Degrees(-00.14500041)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60164",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 107307"},
        {"Hipparcos Number", "HIP 60164"},
        {"Geneva Identification System", "GEN# +1.00107307"},
        {"Smithsonian Astrophysical Observation", "SAO 119340"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(185.06337094),
        dec: Angle.Degrees(-00.14457369)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -51.08 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.59 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73536",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9480 AB"},
        {"Henry Draper", "HD 132933"},
        {"Hipparcos Number", "HIP 73536"},
        {"Geneva Identification System", "GEN# +1.00132933"},
        {"Smithsonian Astrophysical Observation", "SAO 120798"},
        {"Wilson Evans Batten Catalogue", "WEB 12581"},
    },
    visualMagnitude: 5.71,
    bvColour: 1.509,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(225.45381414),
        dec: Angle.Degrees(-00.14025867)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18251",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 24538"},
        {"Hipparcos Number", "HIP 18251"},
        {"Geneva Identification System", "GEN# +1.00024538"},
        {"Smithsonian Astrophysical Observation", "SAO 130803"},
    },
    visualMagnitude: 9.57,
    bvColour: 0.530,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.55699545),
        dec: Angle.Degrees(-00.13998775)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.36 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24604",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290132"},
        {"Hipparcos Number", "HIP 24604"},
    },
    visualMagnitude: 10.55,
    bvColour: 0.234,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.16068859),
        dec: Angle.Degrees(-00.13988293)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.10 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.98 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41230",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70957"},
        {"Hipparcos Number", "HIP 41230"},
        {"Geneva Identification System", "GEN# +1.00070957"},
        {"Smithsonian Astrophysical Observation", "SAO 116736"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.538,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(126.20224923),
        dec: Angle.Degrees(-00.13985272)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -49.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -111.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99470",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191708"},
        {"Hipparcos Number", "HIP 99470"},
        {"Geneva Identification System", "GEN# +1.00191708"},
        {"Smithsonian Astrophysical Observation", "SAO 144148"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82098107),
        dec: Angle.Degrees(-00.13980281)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -17.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 36989",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 60778"},
        {"Hipparcos Number", "HIP 36989"},
        {"Geneva Identification System", "GEN# +1.00060778"},
        {"Smithsonian Astrophysical Observation", "SAO 134879"},
        {"Wilson Evans Batten Catalogue", "WEB 7339"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.135,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.04911840),
        dec: Angle.Degrees(-00.13745853)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -84.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112736",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 216070"},
        {"Hipparcos Number", "HIP 112736"},
        {"Smithsonian Astrophysical Observation", "SAO 146337"},
    },
    visualMagnitude: 9.23,
    bvColour: 1.607,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(342.47020836),
        dec: Angle.Degrees(-00.13713714)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86862",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161304"},
        {"Hipparcos Number", "HIP 86862"},
        {"Geneva Identification System", "GEN# +1.00161304"},
        {"Smithsonian Astrophysical Observation", "SAO 141850"},
        {"Wilson Evans Batten Catalogue", "WEB 14650"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.303,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.21122834),
        dec: Angle.Degrees(-00.13461455)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99078",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190817"},
        {"Hipparcos Number", "HIP 99078"},
        {"Smithsonian Astrophysical Observation", "SAO 144075"},
    },
    visualMagnitude: 8.23,
    bvColour: 1.254,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(301.70995038),
        dec: Angle.Degrees(-00.13349124)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96534",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 185090"},
        {"Hipparcos Number", "HIP 96534"},
        {"Geneva Identification System", "GEN# +1.00185090"},
        {"Smithsonian Astrophysical Observation", "SAO 143612"},
        {"Wilson Evans Batten Catalogue", "WEB 16943"},
    },
    visualMagnitude: 7.31,
    bvColour: 0.321,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.38935301),
        dec: Angle.Degrees(-00.12931757)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 19.22 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 118159",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224448"},
        {"Hipparcos Number", "HIP 118159"},
        {"Smithsonian Astrophysical Observation", "SAO 147004"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.653,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(359.51901150),
        dec: Angle.Degrees(-00.12814830)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 66840",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 119217"},
        {"Hipparcos Number", "HIP 66840"},
        {"Cincinnati Publication", "Ci 20 795"},
        {"Geneva Identification System", "GEN# +1.00119217"},
        {"Smithsonian Astrophysical Observation", "SAO 120072"},
        {"Wilson Evans Batten Catalogue", "WEB 11783"},
    },
    visualMagnitude: 9.76,
    bvColour: 1.288,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(205.48243094),
        dec: Angle.Degrees(-00.12809907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -160.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -429.82 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99476",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 191709"},
        {"Hipparcos Number", "HIP 99476"},
        {"Geneva Identification System", "GEN# +1.00191709"},
        {"Smithsonian Astrophysical Observation", "SAO 144151"},
        {"Wilson Evans Batten Catalogue", "WEB 17778"},
    },
    visualMagnitude: 7.10,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(302.82851414),
        dec: Angle.Degrees(-00.12639686)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.96 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -26.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16377",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 16377"},
    },
    visualMagnitude: 10.19,
    bvColour: 0.547,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(052.74882727),
        dec: Angle.Degrees(-00.12617101)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26188",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 4180 A"},
        {"Henry Draper", "HD 36898"},
        {"Hipparcos Number", "HIP 26188"},
        {"Celescope Catalog", "CEL 810"},
        {"Geneva Identification System", "GEN# +1.00036898A"},
        {"Smithsonian Astrophysical Observation", "SAO 132291"},
        {"Wilson Evans Batten Catalogue", "WEB 5103"},
    },
    visualMagnitude: 7.14,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.73538201),
        dec: Angle.Degrees(-00.12284978)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87489",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162737"},
        {"Hipparcos Number", "HIP 87489"},
        {"Smithsonian Astrophysical Observation", "SAO 141929"},
    },
    visualMagnitude: 8.96,
    bvColour: 0.371,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.13851151),
        dec: Angle.Degrees(-00.12105169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 198707"},
        {"Hipparcos Number", "HIP 103017"},
        {"Geneva Identification System", "GEN# +1.00198707"},
        {"Smithsonian Astrophysical Observation", "SAO 144891"},
    },
    visualMagnitude: 8.47,
    bvColour: 0.500,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(313.06551316),
        dec: Angle.Degrees(-00.11901216)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 24.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14033",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18739"},
        {"Hipparcos Number", "HIP 14033"},
        {"Smithsonian Astrophysical Observation", "SAO 130240"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.961,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(045.17598282),
        dec: Angle.Degrees(-00.11771601)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 41.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 111497",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 213998"},
        {"Hipparcos Number", "HIP 111497"},
        {"Fundamental Katalog 5th Edition", "FK5 850"},
        {"Geneva Identification System", "GEN# +1.00213998"},
        {"Smithsonian Astrophysical Observation", "SAO 146181"},
        {"Wilson Evans Batten Catalogue", "WEB 19931"},
    },
    visualMagnitude: 4.04,
    bvColour: -0.083,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(338.83887054),
        dec: Angle.Degrees(-00.11736123)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -56.10 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39930",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 67719"},
        {"Hipparcos Number", "HIP 39930"},
        {"Smithsonian Astrophysical Observation", "SAO 116406"},
    },
    visualMagnitude: 7.85,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(122.32460027),
        dec: Angle.Degrees(-00.11694065)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69911",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 69911"},
    },
    visualMagnitude: 10.56,
    bvColour: 0.702,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.61236222),
        dec: Angle.Degrees(-00.11505627)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -98.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -160.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101010",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 195004"},
        {"Hipparcos Number", "HIP 101010"},
        {"Smithsonian Astrophysical Observation", "SAO 144478"},
    },
    visualMagnitude: 8.75,
    bvColour: 0.739,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(307.18141130),
        dec: Angle.Degrees(-00.11291865)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39669",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 39669"},
        {"Geneva Identification System", "GEN# +0.00002186"},
    },
    visualMagnitude: 9.92,
    bvColour: 0.910,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(121.59345278),
        dec: Angle.Degrees(-00.11276339)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 111.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -229.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54292",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 96363"},
        {"Hipparcos Number", "HIP 54292"},
        {"Geneva Identification System", "GEN# +1.00096363"},
        {"Smithsonian Astrophysical Observation", "SAO 118661"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.61638661),
        dec: Angle.Degrees(-00.11099836)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -134.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.35 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79391",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9955 AB"},
        {"Henry Draper", "HD 145680"},
        {"Hipparcos Number", "HIP 79391"},
        {"Smithsonian Astrophysical Observation", "SAO 121421"},
    },
    visualMagnitude: 7.84,
    bvColour: 0.640,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(243.04012703),
        dec: Angle.Degrees(-00.11081387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8961",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 8961"},
    },
    visualMagnitude: 10.35,
    bvColour: 1.103,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(028.86065470),
        dec: Angle.Degrees(-00.11047827)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 75705",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 137794"},
        {"Hipparcos Number", "HIP 75705"},
        {"Smithsonian Astrophysical Observation", "SAO 121014"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.139,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(232.00048045),
        dec: Angle.Degrees(-00.10777279)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100061",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 100061"},
        {"Smithsonian Astrophysical Observation", "SAO 144263"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(304.50415219),
        dec: Angle.Degrees(-00.10761146)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 67486",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 120478"},
        {"Hipparcos Number", "HIP 67486"},
        {"Smithsonian Astrophysical Observation", "SAO 120129"},
    },
    visualMagnitude: 9.99,
    bvColour: 0.408,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(207.43932456),
        dec: Angle.Degrees(-00.10750214)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.67 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.53 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104189",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200932"},
        {"Hipparcos Number", "HIP 104189"},
        {"Fundamental Katalog 5th Edition", "FK5 1553"},
        {"Geneva Identification System", "GEN# +1.00200932"},
        {"Smithsonian Astrophysical Observation", "SAO 145101"},
    },
    visualMagnitude: 6.92,
    bvColour: 1.507,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(316.63922392),
        dec: Angle.Degrees(-00.10502111)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 102378",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 197576"},
        {"Hipparcos Number", "HIP 102378"},
        {"Geneva Identification System", "GEN# +1.00197576"},
        {"Smithsonian Astrophysical Observation", "SAO 144759"},
    },
    visualMagnitude: 8.70,
    bvColour: 0.268,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(311.15243224),
        dec: Angle.Degrees(-00.10130664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 30.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.62 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95562",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182786"},
        {"Hipparcos Number", "HIP 95562"},
        {"Geneva Identification System", "GEN# +1.00182786"},
        {"Smithsonian Astrophysical Observation", "SAO 143397"},
    },
    visualMagnitude: 7.92,
    bvColour: 0.220,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.57401823),
        dec: Angle.Degrees(-00.09944193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37026",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37026"},
        {"Smithsonian Astrophysical Observation", "SAO 115696"},
    },
    visualMagnitude: 9.11,
    bvColour: 1.496,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.13459751),
        dec: Angle.Degrees(-00.09882654)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.93 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20341",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 3152 A"},
        {"Henry Draper", "HD 27611"},
        {"Hipparcos Number", "HIP 20341"},
        {"Geneva Identification System", "GEN# +1.00027611"},
        {"Smithsonian Astrophysical Observation", "SAO 131140"},
    },
    visualMagnitude: 5.86,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.36270888),
        dec: Angle.Degrees(-00.09786658)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -19.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -124.66 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30951",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 5125 AB"},
        {"Henry Draper", "HD 45830"},
        {"Hipparcos Number", "HIP 30951"},
        {"Smithsonian Astrophysical Observation", "SAO 133335"},
    },
    visualMagnitude: 8.54,
    bvColour: 0.082,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(097.44434351),
        dec: Angle.Degrees(-00.09709983)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.79 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76241",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138806"},
        {"Hipparcos Number", "HIP 76241"},
        {"Smithsonian Astrophysical Observation", "SAO 121065"},
    },
    visualMagnitude: 9.41,
    bvColour: 0.611,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.60724563),
        dec: Angle.Degrees(-00.09653327)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22526",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30812"},
        {"Hipparcos Number", "HIP 22526"},
        {"Geneva Identification System", "GEN# +1.00030812"},
        {"Smithsonian Astrophysical Observation", "SAO 131538"},
        {"Wilson Evans Batten Catalogue", "WEB 4346"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.075,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.70567013),
        dec: Angle.Degrees(-00.09485115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 14.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.07 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53978",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95662"},
        {"Hipparcos Number", "HIP 53978"},
        {"Smithsonian Astrophysical Observation", "SAO 118629"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.63824100),
        dec: Angle.Degrees(-00.09364732)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 64980",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 64980"},
    },
    visualMagnitude: 10.57,
    bvColour: 0.649,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(199.76849396),
        dec: Angle.Degrees(-00.09349588)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -32.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -167.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24311",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 33831"},
        {"Hipparcos Number", "HIP 24311"},
        {"Geneva Identification System", "GEN# +1.00033831"},
        {"Smithsonian Astrophysical Observation", "SAO 131875"},
    },
    visualMagnitude: 8.01,
    bvColour: 0.140,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.25385787),
        dec: Angle.Degrees(-00.09195219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.09 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 78167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142981"},
        {"Hipparcos Number", "HIP 78167"},
        {"Geneva Identification System", "GEN# +1.00142981"},
        {"Smithsonian Astrophysical Observation", "SAO 121281"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.230,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(239.41745155),
        dec: Angle.Degrees(-00.09169285)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.83 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.89 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11649",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15565"},
        {"Hipparcos Number", "HIP 11649"},
        {"Geneva Identification System", "GEN# +1.00015565"},
        {"Smithsonian Astrophysical Observation", "SAO 129942"},
    },
    visualMagnitude: 8.23,
    bvColour: 0.327,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.56869901),
        dec: Angle.Degrees(-00.09044967)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.99 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22270",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30436"},
        {"Hipparcos Number", "HIP 22270"},
        {"Geneva Identification System", "GEN# +1.00030436"},
        {"Smithsonian Astrophysical Observation", "SAO 131489"},
        {"Wilson Evans Batten Catalogue", "WEB 4287"},
    },
    visualMagnitude: 7.99,
    bvColour: 0.417,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(071.92240049),
        dec: Angle.Degrees(-00.08877593)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.60 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 40439",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 69096"},
        {"Hipparcos Number", "HIP 40439"},
        {"Smithsonian Astrophysical Observation", "SAO 116543"},
    },
    visualMagnitude: 8.34,
    bvColour: 1.510,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(123.85600723),
        dec: Angle.Degrees(-00.08748547)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22591",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 22591"},
        {"Geneva Identification System", "GEN# -0.00000789"},
        {"Smithsonian Astrophysical Observation", "SAO 131547"},
        {"Wilson Evans Batten Catalogue", "WEB 4369"},
    },
    visualMagnitude: 8.95,
    bvColour: 1.054,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(072.91984234),
        dec: Angle.Degrees(-00.08699296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.60 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52652",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 52652"},
        {"Smithsonian Astrophysical Observation", "SAO 118482"},
    },
    visualMagnitude: 9.31,
    bvColour: 1.567,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.50455122),
        dec: Angle.Degrees(-00.08488850)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -22.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21696",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 29583"},
        {"Hipparcos Number", "HIP 21696"},
        {"Geneva Identification System", "GEN# +1.00029583"},
        {"Smithsonian Astrophysical Observation", "SAO 131386"},
    },
    visualMagnitude: 7.22,
    bvColour: 1.332,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(069.86795620),
        dec: Angle.Degrees(-00.08431618)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.46 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -46.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28608",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40984"},
        {"Hipparcos Number", "HIP 28608"},
        {"Geneva Identification System", "GEN# +1.00040984"},
        {"Smithsonian Astrophysical Observation", "SAO 132762"},
    },
    visualMagnitude: 8.52,
    bvColour: 0.159,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(090.56944027),
        dec: Angle.Degrees(-00.08258691)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196632"},
        {"Hipparcos Number", "HIP 101871"},
        {"Geneva Identification System", "GEN# +1.00196632"},
        {"Smithsonian Astrophysical Observation", "SAO 144655"},
    },
    visualMagnitude: 9.17,
    bvColour: 0.495,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.65296551),
        dec: Angle.Degrees(-00.08127553)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 3947",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 4865"},
        {"Hipparcos Number", "HIP 3947"},
        {"Smithsonian Astrophysical Observation", "SAO 128980"},
    },
    visualMagnitude: 8.53,
    bvColour: 0.622,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(012.66647482),
        dec: Angle.Degrees(-00.08022016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -44.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -139.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103400",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 199401"},
        {"Hipparcos Number", "HIP 103400"},
        {"Renson", "Renson 55570"},
        {"Smithsonian Astrophysical Observation", "SAO 144969"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.339,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(314.22336407),
        dec: Angle.Degrees(-00.07985712)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69785",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125041"},
        {"Hipparcos Number", "HIP 69785"},
        {"Smithsonian Astrophysical Observation", "SAO 120378"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.25620782),
        dec: Angle.Degrees(-00.07898196)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 51.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -140.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82329",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 151753"},
        {"Hipparcos Number", "HIP 82329"},
        {"Smithsonian Astrophysical Observation", "SAO 121881"},
    },
    visualMagnitude: 8.04,
    bvColour: 1.737,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(252.33670601),
        dec: Angle.Degrees(-00.07797424)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.15 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 17377",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 23197"},
        {"Hipparcos Number", "HIP 17377"},
        {"Smithsonian Astrophysical Observation", "SAO 130683"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.894,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(055.81094831),
        dec: Angle.Degrees(-00.07791086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 89.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224839"},
        {"Hipparcos Number", "HIP 93"},
        {"Geneva Identification System", "GEN# +1.00224839"},
        {"Smithsonian Astrophysical Observation", "SAO 147034"},
        {"Wilson Evans Batten Catalogue", "WEB 9"},
    },
    visualMagnitude: 8.12,
    bvColour: 0.619,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(000.29222255),
        dec: Angle.Degrees(-00.07592034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 54.94 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -73.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94295",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 179190"},
        {"Hipparcos Number", "HIP 94295"},
        {"Smithsonian Astrophysical Observation", "SAO 143115"},
    },
    visualMagnitude: 8.84,
    bvColour: 1.229,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(287.89714937),
        dec: Angle.Degrees(-00.07025430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.56 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 7.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54849",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 97585"},
        {"Hipparcos Number", "HIP 54849"},
        {"Geneva Identification System", "GEN# +1.00097585"},
        {"Smithsonian Astrophysical Observation", "SAO 118731"},
        {"Wilson Evans Batten Catalogue", "WEB 9897"},
    },
    visualMagnitude: 5.40,
    bvColour: -0.020,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(168.43991709),
        dec: Angle.Degrees(-00.06950857)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -48.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.73 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65238",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 116208"},
        {"Hipparcos Number", "HIP 65238"},
        {"Smithsonian Astrophysical Observation", "SAO 119903"},
    },
    visualMagnitude: 7.96,
    bvColour: 1.079,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(200.53233074),
        dec: Angle.Degrees(-00.06778472)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37671",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 37671"},
        {"Geneva Identification System", "GEN# +0.00002058A"},
    },
    visualMagnitude: 10.39,
    bvColour: 0.536,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(115.93361387),
        dec: Angle.Degrees(-00.06618950)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -185.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -304.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 293336"},
        {"Hipparcos Number", "HIP 34421"},
    },
    visualMagnitude: 10.37,
    bvColour: 0.785,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(107.03880172),
        dec: Angle.Degrees(-00.06571534)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110302",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211889"},
        {"Hipparcos Number", "HIP 110302"},
        {"Geneva Identification System", "GEN# +1.00211889"},
        {"Smithsonian Astrophysical Observation", "SAO 146026"},
    },
    visualMagnitude: 7.63,
    bvColour: 0.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(335.12181010),
        dec: Angle.Degrees(-00.06529499)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 88.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 59.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97403",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187044"},
        {"Hipparcos Number", "HIP 97403"},
        {"Geneva Identification System", "GEN# +1.00187044"},
        {"Smithsonian Astrophysical Observation", "SAO 143805"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.132,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(296.95878368),
        dec: Angle.Degrees(-00.06367773)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18891",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25501"},
        {"Hipparcos Number", "HIP 18891"},
        {"Smithsonian Astrophysical Observation", "SAO 130896"},
    },
    visualMagnitude: 8.93,
    bvColour: 0.583,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.74506623),
        dec: Angle.Degrees(-00.06328576)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 39.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27101",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38311"},
        {"Hipparcos Number", "HIP 27101"},
        {"Geneva Identification System", "GEN# +1.00038311"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.055,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.20248674),
        dec: Angle.Degrees(-00.06194939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104651",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104651"},
    },
    visualMagnitude: 9.33,
    bvColour: 1.120,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(317.98511077),
        dec: Angle.Degrees(-00.05895743)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.81 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 69025",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 123472"},
        {"Hipparcos Number", "HIP 69025"},
        {"Smithsonian Astrophysical Observation", "SAO 120297"},
    },
    visualMagnitude: 7.27,
    bvColour: 1.491,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(211.95864354),
        dec: Angle.Degrees(-00.05598873)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.69 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74051",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 134086"},
        {"Hipparcos Number", "HIP 74051"},
        {"Smithsonian Astrophysical Observation", "SAO 120854"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(227.00057041),
        dec: Angle.Degrees(-00.05574928)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -57.16 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 16.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45031",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78824"},
        {"Hipparcos Number", "HIP 45031"},
        {"Geneva Identification System", "GEN# +1.00078824"},
        {"Smithsonian Astrophysical Observation", "SAO 117467"},
    },
    visualMagnitude: 8.20,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(137.58529708),
        dec: Angle.Degrees(-00.05314263)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74761",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 74761"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.672,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(229.18854981),
        dec: Angle.Degrees(-00.05249199)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 26.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 106942",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15176 AB"},
        {"Henry Draper", "HD 206058"},
        {"Hipparcos Number", "HIP 106942"},
        {"Geneva Identification System", "GEN# +1.00206058J"},
        {"Smithsonian Astrophysical Observation", "SAO 145566"},
        {"Wilson Evans Batten Catalogue", "WEB 19324"},
    },
    visualMagnitude: 6.66,
    bvColour: 0.514,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(324.88079413),
        dec: Angle.Degrees(-00.05114059)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 237.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 12.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18226",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 18226"},
        {"Geneva Identification System", "GEN# -0.00000615"},
    },
    visualMagnitude: 10.80,
    bvColour: 0.540,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(058.45252322),
        dec: Angle.Degrees(-00.05045110)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 94988",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 181231"},
        {"Hipparcos Number", "HIP 94988"},
        {"Geneva Identification System", "GEN# +1.00181231"},
        {"Smithsonian Astrophysical Observation", "SAO 143268"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.260,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(289.92654080),
        dec: Angle.Degrees(-00.04984336)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2100",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2273"},
        {"Hipparcos Number", "HIP 2100"},
        {"Geneva Identification System", "GEN# +1.00002273"},
        {"Smithsonian Astrophysical Observation", "SAO 128760"},
        {"Wilson Evans Batten Catalogue", "WEB 394"},
    },
    visualMagnitude: 6.16,
    bvColour: 0.893,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(006.65572204),
        dec: Angle.Degrees(-00.04953631)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.49 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13567",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 18145"},
        {"Hipparcos Number", "HIP 13567"},
        {"Geneva Identification System", "GEN# +1.00018145"},
        {"Smithsonian Astrophysical Observation", "SAO 130181"},
        {"Wilson Evans Batten Catalogue", "WEB 2700"},
    },
    visualMagnitude: 6.53,
    bvColour: 1.044,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(043.69646008),
        dec: Angle.Degrees(-00.04831908)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.30 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 32.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81381",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149825"},
        {"Hipparcos Number", "HIP 81381"},
        {"Geneva Identification System", "GEN# +1.00149825"},
        {"Smithsonian Astrophysical Observation", "SAO 121733"},
    },
    visualMagnitude: 9.05,
    bvColour: 0.966,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.30804998),
        dec: Angle.Degrees(-00.04493175)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 4.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -17.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21139",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28749"},
        {"Hipparcos Number", "HIP 21139"},
        {"Geneva Identification System", "GEN# +1.00028749"},
        {"Smithsonian Astrophysical Observation", "SAO 131270"},
        {"Wilson Evans Batten Catalogue", "WEB 4066"},
    },
    visualMagnitude: 4.91,
    bvColour: 1.320,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.96945612),
        dec: Angle.Degrees(-00.04399115)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32355",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48807"},
        {"Hipparcos Number", "HIP 32355"},
        {"Geneva Identification System", "GEN# +1.00048807"},
        {"Smithsonian Astrophysical Observation", "SAO 114363"},
    },
    visualMagnitude: 7.02,
    bvColour: 0.208,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(101.29670632),
        dec: Angle.Degrees(-00.04317363)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.71 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80956",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148981"},
        {"Hipparcos Number", "HIP 80956"},
        {"Smithsonian Astrophysical Observation", "SAO 121668"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.373,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.95682667),
        dec: Angle.Degrees(-00.04254150)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25718",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36117"},
        {"Hipparcos Number", "HIP 25718"},
        {"Geneva Identification System", "GEN# +1.00036117"},
        {"Smithsonian Astrophysical Observation", "SAO 132169"},
    },
    visualMagnitude: 7.98,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.36407036),
        dec: Angle.Degrees(-00.04223476)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.69 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24709",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34511"},
        {"Hipparcos Number", "HIP 24709"},
        {"Fundamental Katalog 5th Edition", "FK5 4481"},
        {"Geneva Identification System", "GEN# +1.00034511"},
        {"Smithsonian Astrophysical Observation", "SAO 131959"},
    },
    visualMagnitude: 7.39,
    bvColour: -0.117,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(079.50409323),
        dec: Angle.Degrees(-00.03769307)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.25 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87521",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 162794"},
        {"Hipparcos Number", "HIP 87521"},
        {"Smithsonian Astrophysical Observation", "SAO 141936"},
    },
    visualMagnitude: 8.45,
    bvColour: 0.089,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(268.21612611),
        dec: Angle.Degrees(-00.03756170)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 8.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.31 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 39262",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 66032"},
        {"Hipparcos Number", "HIP 39262"},
        {"Smithsonian Astrophysical Observation", "SAO 116253"},
    },
    visualMagnitude: 8.91,
    bvColour: 1.093,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(120.42920994),
        dec: Angle.Degrees(-00.03537488)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -9.31 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56994",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56994"},
    },
    visualMagnitude: 10.58,
    bvColour: 0.650,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(175.25242829),
        dec: Angle.Degrees(-00.03480814)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -102.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -195.15 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 1127",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 965"},
        {"Hipparcos Number", "HIP 1127"},
        {"Geneva Identification System", "GEN# +1.00000965"},
        {"Renson", "Renson 160"},
        {"Smithsonian Astrophysical Observation", "SAO 128649"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(003.51687262),
        dec: Angle.Degrees(-00.03333774)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 56409",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 56409"},
        {"Wilson Evans Batten Catalogue", "WEB 10137"},
    },
    visualMagnitude: 10.92,
    bvColour: 0.201,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(173.47711818),
        dec: Angle.Degrees(-00.03328294)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -24.48 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54085",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95922"},
        {"Hipparcos Number", "HIP 54085"},
        {"Smithsonian Astrophysical Observation", "SAO 118640"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.548,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(166.00613461),
        dec: Angle.Degrees(-00.03100232)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26082",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36709"},
        {"Hipparcos Number", "HIP 26082"},
        {"Geneva Identification System", "GEN# +1.00036709"},
        {"Smithsonian Astrophysical Observation", "SAO 132261"},
    },
    visualMagnitude: 8.31,
    bvColour: -0.039,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.43938544),
        dec: Angle.Degrees(-00.02893102)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130969"},
        {"Hipparcos Number", "HIP 72635"},
        {"Geneva Identification System", "GEN# +1.00130969"},
        {"Smithsonian Astrophysical Observation", "SAO 120695"},
    },
    visualMagnitude: 8.40,
    bvColour: 0.965,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.76061759),
        dec: Angle.Degrees(-00.02684087)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72590",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 130850"},
        {"Hipparcos Number", "HIP 72590"},
        {"Smithsonian Astrophysical Observation", "SAO 120690"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.425,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(222.63802449),
        dec: Angle.Degrees(-00.02424511)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 58.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9625",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12626"},
        {"Hipparcos Number", "HIP 9625"},
        {"Smithsonian Astrophysical Observation", "SAO 129664"},
    },
    visualMagnitude: 8.60,
    bvColour: 0.309,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(030.92656209),
        dec: Angle.Degrees(-00.02403566)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.12 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.27 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 73124",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 73124"},
    },
    visualMagnitude: 9.61,
    bvColour: 0.455,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(224.17448295),
        dec: Angle.Degrees(-00.02342343)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -58.58 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 48.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12668",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12668"},
    },
    visualMagnitude: 10.81,
    bvColour: 0.642,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.69169347),
        dec: Angle.Degrees(-00.02317430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -11.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 30431",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 44815"},
        {"Hipparcos Number", "HIP 30431"},
        {"Smithsonian Astrophysical Observation", "SAO 113820"},
    },
    visualMagnitude: 8.30,
    bvColour: -0.068,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(095.97451932),
        dec: Angle.Degrees(-00.02285653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82588",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152391"},
        {"Hipparcos Number", "HIP 82588"},
        {"Cincinnati Publication", "Ci 20 1012"},
        {"Geneva Identification System", "GEN# +1.00152391"},
        {"Smithsonian Astrophysical Observation", "SAO 121921"},
        {"Wilson Evans Batten Catalogue", "WEB 13945"},
    },
    visualMagnitude: 6.65,
    bvColour: 0.749,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.24674087),
        dec: Angle.Degrees(-00.02281504)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -711.75 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1483.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88609",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 165343"},
        {"Hipparcos Number", "HIP 88609"},
        {"Geneva Identification System", "GEN# +1.00165343"},
        {"Smithsonian Astrophysical Observation", "SAO 142076"},
    },
    visualMagnitude: 8.46,
    bvColour: 0.273,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(271.38226209),
        dec: Angle.Degrees(-00.02236528)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 32188",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 48394"},
        {"Hipparcos Number", "HIP 32188"},
        {"Geneva Identification System", "GEN# +1.00048394"},
        {"Smithsonian Astrophysical Observation", "SAO 114317"},
    },
    visualMagnitude: 7.49,
    bvColour: 1.029,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(100.80480880),
        dec: Angle.Degrees(-00.02130345)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 8.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25727",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36139"},
        {"Hipparcos Number", "HIP 25727"},
        {"Geneva Identification System", "GEN# +1.00036139"},
        {"Smithsonian Astrophysical Observation", "SAO 132174"},
    },
    visualMagnitude: 6.87,
    bvColour: 0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.40649272),
        dec: Angle.Degrees(-00.02122430)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -13.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19140",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25896"},
        {"Hipparcos Number", "HIP 19140"},
        {"Geneva Identification System", "GEN# +1.00025896"},
        {"Smithsonian Astrophysical Observation", "SAO 130950"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.975,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(061.53787006),
        dec: Angle.Degrees(-00.02104937)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.36 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18666",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25154"},
        {"Hipparcos Number", "HIP 18666"},
        {"Geneva Identification System", "GEN# +1.00025154"},
        {"Renson", "Renson 6397"},
        {"Smithsonian Astrophysical Observation", "SAO 130864"},
    },
    visualMagnitude: 9.84,
    bvColour: 0.689,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(059.95040171),
        dec: Angle.Degrees(-00.02012887)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110960",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 15971 AB"},
        {"Hipparcos Number", "HIP 110960"},
        {"Smithsonian Astrophysical Observation", "SAO 146107"},
    },
    visualMagnitude: 3.65,
    bvColour: 0.406,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(337.20750231),
        dec: Angle.Degrees(-00.02006304)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 191.32 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 37.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 103806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 200196"},
        {"Hipparcos Number", "HIP 103806"},
        {"Smithsonian Astrophysical Observation", "SAO 145042"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.969,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(315.52286999),
        dec: Angle.Degrees(-00.01766034)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -6.76 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.32 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26893",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38002"},
        {"Hipparcos Number", "HIP 26893"},
        {"Fundamental Katalog 5th Edition", "FK5 4522"},
        {"Geneva Identification System", "GEN# +1.00038002"},
        {"Smithsonian Astrophysical Observation", "SAO 132472"},
    },
    visualMagnitude: 6.85,
    bvColour: 0.978,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(085.63714560),
        dec: Angle.Degrees(-00.01606048)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70002",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 125453"},
        {"Hipparcos Number", "HIP 70002"},
        {"Smithsonian Astrophysical Observation", "SAO 120397"},
    },
    visualMagnitude: 7.79,
    bvColour: 1.314,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(214.86232165),
        dec: Angle.Degrees(-00.01334261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.92 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 93135",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 176056"},
        {"Hipparcos Number", "HIP 93135"},
        {"Smithsonian Astrophysical Observation", "SAO 142858"},
    },
    visualMagnitude: 9.10,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(284.59272122),
        dec: Angle.Degrees(-00.01260664)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -16.94 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 26149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36840"},
        {"Hipparcos Number", "HIP 26149"},
        {"Geneva Identification System", "GEN# +1.00036840"},
        {"Smithsonian Astrophysical Observation", "SAO 132277"},
    },
    visualMagnitude: 6.25,
    bvColour: 0.997,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.62203574),
        dec: Angle.Degrees(-00.01233696)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 110677",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 212572"},
        {"Hipparcos Number", "HIP 110677"},
        {"Smithsonian Astrophysical Observation", "SAO 146079"},
    },
    visualMagnitude: 8.98,
    bvColour: 0.323,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(336.33290068),
        dec: Angle.Degrees(-00.01021521)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 2.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 99755",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 99755"},
    },
    visualMagnitude: 9.56,
    bvColour: 1.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(303.60387487),
        dec: Angle.Degrees(-00.00542939)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.65 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23515",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 289883"},
        {"Hipparcos Number", "HIP 23515"},
    },
    visualMagnitude: 10.18,
    bvColour: 0.101,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.84035850),
        dec: Angle.Degrees(-00.00450176)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.49 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86017",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159429"},
        {"Hipparcos Number", "HIP 86017"},
        {"Smithsonian Astrophysical Observation", "SAO 122524"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.222,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.69155902),
        dec: Angle.Degrees(-00.00187583)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.39 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -6.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 90173",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 169286"},
        {"Hipparcos Number", "HIP 90173"},
        {"Smithsonian Astrophysical Observation", "SAO 142275"},
    },
    visualMagnitude: 8.73,
    bvColour: 0.307,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(276.00916645),
        dec: Angle.Degrees(-00.00162855)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196203"},
        {"Hipparcos Number", "HIP 101622"},
        {"Geneva Identification System", "GEN# +1.00196203"},
        {"Smithsonian Astrophysical Observation", "SAO 144611"},
    },
    visualMagnitude: 7.09,
    bvColour: 0.512,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(308.94622342),
        dec: Angle.Degrees(-00.00113610)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -27.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44322",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 77279"},
        {"Hipparcos Number", "HIP 44322"},
        {"Geneva Identification System", "GEN# +1.00077279"},
        {"Smithsonian Astrophysical Observation", "SAO 117355"},
    },
    visualMagnitude: 7.86,
    bvColour: 0.490,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(135.39835711),
        dec: Angle.Degrees(-00.00098122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 47948",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 47948"},
        {"Smithsonian Astrophysical Observation", "SAO 117900"},
    },
    visualMagnitude: 10.08,
    bvColour: 0.584,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(146.55657658),
        dec: Angle.Degrees(-00.00084137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 23.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -156.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 54049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95849"},
        {"Hipparcos Number", "HIP 54049"},
        {"Geneva Identification System", "GEN# +1.00095849"},
        {"Smithsonian Astrophysical Observation", "SAO 118634"},
        {"Wilson Evans Batten Catalogue", "WEB 9774"},
    },
    visualMagnitude: 5.95,
    bvColour: 1.218,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.90261410),
        dec: Angle.Degrees(-00.00083195)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.41 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71363",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 71363"},
    },
    visualMagnitude: 11.70,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(218.91547288),
        dec: Angle.Degrees(+00.00193589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -91.91 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -147.03 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 116914",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 222591"},
        {"Hipparcos Number", "HIP 116914"},
        {"Geneva Identification System", "GEN# +1.00222591"},
        {"Smithsonian Astrophysical Observation", "SAO 146850"},
    },
    visualMagnitude: 8.79,
    bvColour: 0.731,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(355.48022647),
        dec: Angle.Degrees(+00.00243193)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 242.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -35.86 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 19867",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 26947"},
        {"Hipparcos Number", "HIP 19867"},
        {"Geneva Identification System", "GEN# +1.00026947"},
        {"Smithsonian Astrophysical Observation", "SAO 131066"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.324,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(063.90785542),
        dec: Angle.Degrees(+00.00390720)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 23289",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 23289"},
        {"Smithsonian Astrophysical Observation", "SAO 131681"},
    },
    visualMagnitude: 10.26,
    bvColour: 0.295,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(075.14332705),
        dec: Angle.Degrees(+00.00542899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.27 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.57 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33819",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52431"},
        {"Hipparcos Number", "HIP 33819"},
        {"Geneva Identification System", "GEN# +1.00052431"},
        {"Smithsonian Astrophysical Observation", "SAO 114789"},
    },
    visualMagnitude: 7.57,
    bvColour: 0.449,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.31242180),
        dec: Angle.Degrees(+00.01050899)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -60.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 10.37 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35871",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 58004"},
        {"Hipparcos Number", "HIP 35871"},
        {"Smithsonian Astrophysical Observation", "SAO 115381"},
    },
    visualMagnitude: 8.83,
    bvColour: 0.597,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(110.94216500),
        dec: Angle.Degrees(+00.01120584)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.02 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -44.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77221",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 9776 AB"},
        {"Henry Draper", "HD 140872"},
        {"Hipparcos Number", "HIP 77221"},
        {"Smithsonian Astrophysical Observation", "SAO 121178"},
    },
    visualMagnitude: 9.19,
    bvColour: 1.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(236.50385912),
        dec: Angle.Degrees(+00.01179144)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.07 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25976",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36558"},
        {"Hipparcos Number", "HIP 25976"},
        {"Geneva Identification System", "GEN# +1.00036558"},
        {"Smithsonian Astrophysical Observation", "SAO 132233"},
    },
    visualMagnitude: 6.15,
    bvColour: 1.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(083.15820239),
        dec: Angle.Degrees(+00.01196223)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.12 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97075",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 186327"},
        {"Hipparcos Number", "HIP 97075"},
        {"Smithsonian Astrophysical Observation", "SAO 143734"},
    },
    visualMagnitude: 8.38,
    bvColour: 0.221,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(295.92670926),
        dec: Angle.Degrees(+00.01368000)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 29782",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 43443"},
        {"Hipparcos Number", "HIP 29782"},
        {"Smithsonian Astrophysical Observation", "SAO 113666"},
    },
    visualMagnitude: 7.47,
    bvColour: -0.070,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(094.06157242),
        dec: Angle.Degrees(+00.01527647)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.80 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43172",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 43172"},
        {"Smithsonian Astrophysical Observation", "SAO 117128"},
    },
    visualMagnitude: 7.77,
    bvColour: 0.655,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.90340542),
        dec: Angle.Degrees(+00.01811972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 151.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -95.17 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37976",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6366 A"},
        {"Henry Draper", "HD 63065"},
        {"Hipparcos Number", "HIP 37976"},
        {"Geneva Identification System", "GEN# +1.00063065A"},
        {"Smithsonian Astrophysical Observation", "SAO 115922"},
    },
    visualMagnitude: 8.35,
    bvColour: -0.006,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.76028357),
        dec: Angle.Degrees(+00.01837409)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41688",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 71926"},
        {"Hipparcos Number", "HIP 41688"},
        {"Geneva Identification System", "GEN# +1.00071926"},
        {"Smithsonian Astrophysical Observation", "SAO 116824"},
    },
    visualMagnitude: 7.03,
    bvColour: 0.823,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(127.47994502),
        dec: Angle.Degrees(+00.01932256)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 7375",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 9702"},
        {"Hipparcos Number", "HIP 7375"},
        {"Geneva Identification System", "GEN# +1.00009702"},
        {"Smithsonian Astrophysical Observation", "SAO 129388"},
    },
    visualMagnitude: 8.06,
    bvColour: 0.845,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(023.75834118),
        dec: Angle.Degrees(+00.01942093)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 27.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.83 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 4336",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 5362"},
        {"Hipparcos Number", "HIP 4336"},
        {"Smithsonian Astrophysical Observation", "SAO 129029"},
        {"Wilson Evans Batten Catalogue", "WEB 777"},
    },
    visualMagnitude: 7.89,
    bvColour: 1.306,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(013.88830014),
        dec: Angle.Degrees(+00.01970097)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -48.56 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58461",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104089"},
        {"Hipparcos Number", "HIP 58461"},
        {"Smithsonian Astrophysical Observation", "SAO 119149"},
    },
    visualMagnitude: 9.25,
    bvColour: 0.451,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(179.82898131),
        dec: Angle.Degrees(+00.01983375)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25622",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 35971"},
        {"Hipparcos Number", "HIP 25622"},
        {"Celescope Catalog", "CEL 724"},
        {"Geneva Identification System", "GEN# +1.00035971"},
        {"Smithsonian Astrophysical Observation", "SAO 132144"},
    },
    visualMagnitude: 6.66,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.10730741),
        dec: Angle.Degrees(+00.02036030)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -3.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88094",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164081"},
        {"Hipparcos Number", "HIP 88094"},
        {"Smithsonian Astrophysical Observation", "SAO 122984"},
    },
    visualMagnitude: 8.76,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.88210657),
        dec: Angle.Degrees(+00.02091417)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 11.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37977",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 6366 B"},
        {"Henry Draper", "HD 63065B"},
        {"Hipparcos Number", "HIP 37977"},
        {"Geneva Identification System", "GEN# +1.00063065B"},
        {"Smithsonian Astrophysical Observation", "SAO 115923"},
    },
    visualMagnitude: 9.28,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(116.76111303),
        dec: Angle.Degrees(+00.02316446)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.74 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 45635",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 80149"},
        {"Hipparcos Number", "HIP 45635"},
        {"Smithsonian Astrophysical Observation", "SAO 117581"},
    },
    visualMagnitude: 8.34,
    bvColour: 0.504,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(139.53256337),
        dec: Angle.Degrees(+00.02404251)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -100.11 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.90 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 16058",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 21367"},
        {"Hipparcos Number", "HIP 16058"},
        {"Geneva Identification System", "GEN# +1.00021367"},
        {"Smithsonian Astrophysical Observation", "SAO 130495"},
    },
    visualMagnitude: 7.05,
    bvColour: 1.480,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(051.70509362),
        dec: Angle.Degrees(+00.02616977)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28187",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40210"},
        {"Hipparcos Number", "HIP 28187"},
        {"Geneva Identification System", "GEN# +1.00040210J"},
        {"Smithsonian Astrophysical Observation", "SAO 113296"},
    },
    visualMagnitude: 6.90,
    bvColour: 0.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.35532123),
        dec: Angle.Degrees(+00.02754004)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -15.52 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.85 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34091",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53175"},
        {"Hipparcos Number", "HIP 34091"},
        {"Smithsonian Astrophysical Observation", "SAO 114862"},
    },
    visualMagnitude: 8.30,
    bvColour: 1.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(106.03291430),
        dec: Angle.Degrees(+00.02756018)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.09 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25818",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36312"},
        {"Hipparcos Number", "HIP 25818"},
        {"Geneva Identification System", "GEN# +1.00036312"},
        {"Smithsonian Astrophysical Observation", "SAO 132197"},
    },
    visualMagnitude: 8.14,
    bvColour: -0.061,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.70280414),
        dec: Angle.Degrees(+00.02853014)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.42 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 74004",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 133987"},
        {"Hipparcos Number", "HIP 74004"},
        {"Fundamental Katalog 5th Edition", "FK5 5341"},
        {"Smithsonian Astrophysical Observation", "SAO 120846"},
    },
    visualMagnitude: 7.85,
    bvColour: 1.125,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(226.85322976),
        dec: Angle.Degrees(+00.02926207)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 114603",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 219066"},
        {"Hipparcos Number", "HIP 114603"},
        {"Geneva Identification System", "GEN# +1.00219066"},
        {"Smithsonian Astrophysical Observation", "SAO 146565"},
        {"Wilson Evans Batten Catalogue", "WEB 20330"},
    },
    visualMagnitude: 7.63,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(348.25148518),
        dec: Angle.Degrees(+00.03080051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 13.51 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 79008",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 79008"},
        {"Geneva Identification System", "GEN# +0.00003459"},
    },
    visualMagnitude: 9.77,
    bvColour: 1.000,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(241.90670756),
        dec: Angle.Degrees(+00.03268849)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 38.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13117",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 13117"},
    },
    visualMagnitude: 11.69,
    bvColour: 1.460,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.18007600),
        dec: Angle.Degrees(+00.03431650)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 494.62 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 78.24 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 9827",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 12923"},
        {"Hipparcos Number", "HIP 9827"},
        {"Geneva Identification System", "GEN# +1.00012923"},
        {"Smithsonian Astrophysical Observation", "SAO 129695"},
    },
    visualMagnitude: 6.29,
    bvColour: 0.897,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(031.62196116),
        dec: Angle.Degrees(+00.03536862)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.46 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109927",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211248"},
        {"Hipparcos Number", "HIP 109927"},
        {"Geneva Identification System", "GEN# +1.00211248"},
        {"Smithsonian Astrophysical Observation", "SAO 145981"},
    },
    visualMagnitude: 8.97,
    bvColour: -0.017,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.97527701),
        dec: Angle.Degrees(+00.03705852)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -0.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 97585",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 187469"},
        {"Hipparcos Number", "HIP 97585"},
        {"Smithsonian Astrophysical Observation", "SAO 143830"},
    },
    visualMagnitude: 8.77,
    bvColour: 1.658,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(297.52575276),
        dec: Angle.Degrees(+00.03830930)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.18 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76263",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138835"},
        {"Hipparcos Number", "HIP 76263"},
    },
    visualMagnitude: 9.72,
    bvColour: 0.416,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.66259160),
        dec: Angle.Degrees(+00.04001387)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81421",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 149933"},
        {"Hipparcos Number", "HIP 81421"},
        {"Geneva Identification System", "GEN# +1.00149933"},
        {"Smithsonian Astrophysical Observation", "SAO 121741"},
    },
    visualMagnitude: 8.05,
    bvColour: 0.763,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(249.44152725),
        dec: Angle.Degrees(+00.04071483)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -209.53 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -226.00 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 2281",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 2539"},
        {"Hipparcos Number", "HIP 2281"},
        {"Smithsonian Astrophysical Observation", "SAO 128779"},
    },
    visualMagnitude: 8.86,
    bvColour: 1.122,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(007.29159325),
        dec: Angle.Degrees(+00.04077104)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15461",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 15461"},
        {"Smithsonian Astrophysical Observation", "SAO 130417"},
    },
    visualMagnitude: 9.63,
    bvColour: 0.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(049.84462540),
        dec: Angle.Degrees(+00.04238784)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 45.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 6.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85806",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 158921"},
        {"Hipparcos Number", "HIP 85806"},
        {"Smithsonian Astrophysical Observation", "SAO 122477"},
    },
    visualMagnitude: 6.75,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(262.99048794),
        dec: Angle.Degrees(+00.04250946)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 91113",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 171491"},
        {"Hipparcos Number", "HIP 91113"},
        {"Geneva Identification System", "GEN# +1.00171491"},
        {"Smithsonian Astrophysical Observation", "SAO 123661"},
        {"Wilson Evans Batten Catalogue", "WEB 15637"},
    },
    visualMagnitude: 7.94,
    bvColour: 0.624,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(278.78421710),
        dec: Angle.Degrees(+00.04303076)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.19 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68605",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122549"},
        {"Hipparcos Number", "HIP 68605"},
        {"Smithsonian Astrophysical Observation", "SAO 120250"},
    },
    visualMagnitude: 8.62,
    bvColour: -0.072,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(210.64406138),
        dec: Angle.Degrees(+00.04638651)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -7.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 9.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 53857",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 95453"},
        {"Hipparcos Number", "HIP 53857"},
        {"Smithsonian Astrophysical Observation", "SAO 118620"},
    },
    visualMagnitude: 7.28,
    bvColour: 0.124,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(165.26556368),
        dec: Angle.Degrees(+00.04702824)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -38.72 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 22628",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 30979"},
        {"Hipparcos Number", "HIP 22628"},
        {"Geneva Identification System", "GEN# +1.00030979"},
        {"Smithsonian Astrophysical Observation", "SAO 131553"},
    },
    visualMagnitude: 8.50,
    bvColour: 1.035,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(073.03791917),
        dec: Angle.Degrees(+00.04754831)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 25.45 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72014",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129666"},
        {"Hipparcos Number", "HIP 72014"},
        {"Geneva Identification System", "GEN# +1.00129666"},
        {"Smithsonian Astrophysical Observation", "SAO 120626"},
    },
    visualMagnitude: 9.10,
    bvColour: 0.620,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.94249443),
        dec: Angle.Degrees(+00.04758383)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -177.24 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.13 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27507",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 290888"},
        {"Hipparcos Number", "HIP 27507"},
    },
    visualMagnitude: 9.85,
    bvColour: 0.486,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(087.37301553),
        dec: Angle.Degrees(+00.04774589)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.28 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109799",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 211018"},
        {"Hipparcos Number", "HIP 109799"},
        {"Smithsonian Astrophysical Observation", "SAO 145960"},
    },
    visualMagnitude: 7.78,
    bvColour: 1.636,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(333.59198404),
        dec: Angle.Degrees(+00.04890952)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.03 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 68373",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 122104"},
        {"Hipparcos Number", "HIP 68373"},
        {"Fundamental Katalog 5th Edition", "FK5 5240"},
        {"Geneva Identification System", "GEN# +1.00122104"},
        {"Smithsonian Astrophysical Observation", "SAO 120211"},
    },
    visualMagnitude: 7.91,
    bvColour: 0.945,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(209.93636130),
        dec: Angle.Degrees(+00.04914792)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 29.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -28.54 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 55496",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 98759"},
        {"Hipparcos Number", "HIP 55496"},
        {"Smithsonian Astrophysical Observation", "SAO 118815"},
    },
    visualMagnitude: 8.84,
    bvColour: 0.526,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(170.48794525),
        dec: Angle.Degrees(+00.05235120)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -69.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 23.50 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80708",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 148531"},
        {"Hipparcos Number", "HIP 80708"},
        {"Smithsonian Astrophysical Observation", "SAO 121627"},
    },
    visualMagnitude: 6.46,
    bvColour: 1.378,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(247.17646594),
        dec: Angle.Degrees(+00.05509353)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -61.70 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -98.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 63093",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 112281"},
        {"Hipparcos Number", "HIP 63093"},
        {"Fundamental Katalog 5th Edition", "FK5 3032"},
        {"Geneva Identification System", "GEN# +1.00112281"},
        {"Smithsonian Astrophysical Observation", "SAO 119673"},
    },
    visualMagnitude: 6.78,
    bvColour: 0.960,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(193.91012683),
        dec: Angle.Degrees(+00.05530078)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -30.87 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28395",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 40590"},
        {"Hipparcos Number", "HIP 28395"},
        {"Geneva Identification System", "GEN# +1.00040590"},
        {"Smithsonian Astrophysical Observation", "SAO 113339"},
    },
    visualMagnitude: 8.08,
    bvColour: 0.524,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(089.96489234),
        dec: Angle.Degrees(+00.05604316)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.85 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -31.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 383",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 225244"},
        {"Hipparcos Number", "HIP 383"},
        {"Geneva Identification System", "GEN# +1.00225244"},
        {"Smithsonian Astrophysical Observation", "SAO 128567"},
    },
    visualMagnitude: 8.82,
    bvColour: 0.433,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.18887204),
        dec: Angle.Degrees(+00.05649086)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 3.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 4.68 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6790",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8865"},
        {"Hipparcos Number", "HIP 6790"},
        {"Smithsonian Astrophysical Observation", "SAO 129308"},
        {"Wilson Evans Batten Catalogue", "WEB 1482"},
    },
    visualMagnitude: 8.44,
    bvColour: 0.397,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(021.84909850),
        dec: Angle.Degrees(+00.05774137)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 6.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -4.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 15626",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 20814"},
        {"Hipparcos Number", "HIP 15626"},
        {"Smithsonian Astrophysical Observation", "SAO 130437"},
    },
    visualMagnitude: 8.29,
    bvColour: 1.454,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(050.30244963),
        dec: Angle.Degrees(+00.05916860)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -8.74 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 41148",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 70757"},
        {"Hipparcos Number", "HIP 41148"},
        {"Geneva Identification System", "GEN# +1.00070757"},
        {"Smithsonian Astrophysical Observation", "SAO 116711"},
    },
    visualMagnitude: 7.46,
    bvColour: 0.330,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(125.94037761),
        dec: Angle.Degrees(+00.05949315)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -11.00 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 24498",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 34179"},
        {"Hipparcos Number", "HIP 24498"},
        {"Geneva Identification System", "GEN# +1.00034179"},
        {"Smithsonian Astrophysical Observation", "SAO 112572"},
    },
    visualMagnitude: 8.04,
    bvColour: -0.050,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(078.84041088),
        dec: Angle.Degrees(+00.06033739)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.95 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 95508",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 182622"},
        {"Hipparcos Number", "HIP 95508"},
        {"Smithsonian Astrophysical Observation", "SAO 143385"},
    },
    visualMagnitude: 8.06,
    bvColour: 1.348,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(291.38235531),
        dec: Angle.Degrees(+00.06105678)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -4.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -105.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 109301",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 210186"},
        {"Hipparcos Number", "HIP 109301"},
        {"Smithsonian Astrophysical Observation", "SAO 145896"},
    },
    visualMagnitude: 8.55,
    bvColour: 0.420,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(332.16851395),
        dec: Angle.Degrees(+00.06117736)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 16.65 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -19.29 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44777",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 78317"},
        {"Hipparcos Number", "HIP 44777"},
        {"Geneva Identification System", "GEN# +1.00078317"},
        {"Smithsonian Astrophysical Observation", "SAO 117440"},
    },
    visualMagnitude: 8.15,
    bvColour: 0.626,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(136.88841431),
        dec: Angle.Degrees(+00.06317365)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -94.26 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.84 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 87875",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 10912 AB"},
        {"Henry Draper", "HD 163624"},
        {"Hipparcos Number", "HIP 87875"},
        {"Geneva Identification System", "GEN# +1.00163624J"},
        {"Smithsonian Astrophysical Observation", "SAO 122950"},
        {"Wilson Evans Batten Catalogue", "WEB 14836"},
    },
    visualMagnitude: 5.95,
    bvColour: 0.110,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(269.26792871),
        dec: Angle.Degrees(+00.06668731)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 20.54 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -9.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108844",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 108844"},
        {"Smithsonian Astrophysical Observation", "SAO 145834"},
    },
    visualMagnitude: 9.25,
    bvColour: 1.219,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(330.73472515),
        dec: Angle.Degrees(+00.06988951)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.50 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -1.43 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 86910",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 161427"},
        {"Hipparcos Number", "HIP 86910"},
        {"Geneva Identification System", "GEN# +1.00161427"},
        {"Smithsonian Astrophysical Observation", "SAO 122703"},
    },
    visualMagnitude: 9.00,
    bvColour: 0.801,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(266.37441633),
        dec: Angle.Degrees(+00.07021219)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 59.13 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -76.06 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 112125",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 215077"},
        {"Hipparcos Number", "HIP 112125"},
        {"Geneva Identification System", "GEN# +1.00215077"},
        {"Smithsonian Astrophysical Observation", "SAO 146260"},
    },
    visualMagnitude: 7.19,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(340.67743599),
        dec: Angle.Degrees(+00.07105847)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -23.59 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -21.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 492"},
        {"Hipparcos Number", "HIP 766"},
        {"Smithsonian Astrophysical Observation", "SAO 128614"},
    },
    visualMagnitude: 8.59,
    bvColour: 0.484,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(002.35250184),
        dec: Angle.Degrees(+00.07209314)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -39.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -39.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 81829",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 150732"},
        {"Hipparcos Number", "HIP 81829"},
        {"Geneva Identification System", "GEN# +1.00150732J"},
        {"Smithsonian Astrophysical Observation", "SAO 121805"},
    },
    visualMagnitude: 8.24,
    bvColour: 1.015,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(250.71761472),
        dec: Angle.Degrees(+00.07523897)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 9.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48413",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85505"},
        {"Hipparcos Number", "HIP 48413"},
        {"Fundamental Katalog 5th Edition", "FK5 2788"},
        {"Geneva Identification System", "GEN# +1.00085505"},
        {"Smithsonian Astrophysical Observation", "SAO 117960"},
        {"Wilson Evans Batten Catalogue", "WEB 9030"},
    },
    visualMagnitude: 6.34,
    bvColour: 0.934,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(148.04999861),
        dec: Angle.Degrees(+00.07567169)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -25.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.40 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 20282",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 27550"},
        {"Hipparcos Number", "HIP 20282"},
        {"Geneva Identification System", "GEN# +1.00027550"},
        {"Smithsonian Astrophysical Observation", "SAO 131131"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.519,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(065.20724648),
        dec: Angle.Degrees(+00.07615066)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 44.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 26.81 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104930",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 104930"},
        {"Wilson Evans Batten Catalogue", "WEB 19074"},
    },
    visualMagnitude: 11.54,
    bvColour: null,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.82447916),
        dec: Angle.Degrees(+00.07648972)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -42.05 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -58.87 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 80149",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 147370"},
        {"Hipparcos Number", "HIP 80149"},
        {"Smithsonian Astrophysical Observation", "SAO 121529"},
        {"Wilson Evans Batten Catalogue", "WEB 13567"},
    },
    visualMagnitude: 6.85,
    bvColour: 1.112,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(245.39533501),
        dec: Angle.Degrees(+00.07690675)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -18.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -41.08 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 28986",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 41733"},
        {"Hipparcos Number", "HIP 28986"},
        {"Smithsonian Astrophysical Observation", "SAO 113465"},
        {"Wilson Evans Batten Catalogue", "WEB 5674"},
    },
    visualMagnitude: 7.26,
    bvColour: 1.363,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(091.74736772),
        dec: Angle.Degrees(+00.07695816)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 0.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 43167",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 75012"},
        {"Hipparcos Number", "HIP 43167"},
        {"Geneva Identification System", "GEN# +1.00075012"},
        {"Smithsonian Astrophysical Observation", "SAO 117127"},
    },
    visualMagnitude: 7.82,
    bvColour: 0.084,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(131.89515923),
        dec: Angle.Degrees(+00.07769312)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -1.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.51 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 77967",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 142594"},
        {"Hipparcos Number", "HIP 77967"},
        {"Smithsonian Astrophysical Observation", "SAO 121260"},
    },
    visualMagnitude: 8.19,
    bvColour: 0.740,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(238.84399668),
        dec: Angle.Degrees(+00.07818680)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 105.29 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -118.16 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 35436",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 56891"},
        {"Hipparcos Number", "HIP 35436"},
        {"Smithsonian Astrophysical Observation", "SAO 115247"},
    },
    visualMagnitude: 6.66,
    bvColour: 1.111,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(109.73129370),
        dec: Angle.Degrees(+00.07948317)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -68.23 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 38306",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 63838"},
        {"Hipparcos Number", "HIP 38306"},
        {"Smithsonian Astrophysical Observation", "SAO 116019"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.237,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(117.72258006),
        dec: Angle.Degrees(+00.07954261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 17.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.47 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 18832",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 25400"},
        {"Hipparcos Number", "HIP 18832"},
        {"Geneva Identification System", "GEN# +1.00025400"},
        {"Smithsonian Astrophysical Observation", "SAO 130882"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.364,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(060.55486768),
        dec: Angle.Degrees(+00.08064958)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 52.71 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 20.45 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33710",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 52185"},
        {"Hipparcos Number", "HIP 33710"},
        {"Geneva Identification System", "GEN# +1.00052185"},
        {"Smithsonian Astrophysical Observation", "SAO 114757"},
    },
    visualMagnitude: 7.64,
    bvColour: 0.376,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.05755103),
        dec: Angle.Degrees(+00.08349858)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.41 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 62776",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 111816"},
        {"Hipparcos Number", "HIP 62776"},
        {"Geneva Identification System", "GEN# +1.00111816"},
        {"Smithsonian Astrophysical Observation", "SAO 119638"},
    },
    visualMagnitude: 7.83,
    bvColour: 0.539,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(192.96656203),
        dec: Angle.Degrees(+00.08507783)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 64.68 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -38.77 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 27065",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 38248"},
        {"Hipparcos Number", "HIP 27065"},
    },
    visualMagnitude: 9.02,
    bvColour: 0.329,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(086.09916288),
        dec: Angle.Degrees(+00.08560907)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.21 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 3.48 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 13326",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 17806"},
        {"Hipparcos Number", "HIP 13326"},
        {"Smithsonian Astrophysical Observation", "SAO 130149"},
    },
    visualMagnitude: 7.70,
    bvColour: 1.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(042.87274326),
        dec: Angle.Degrees(+00.08632905)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 10.84 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 25.02 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 12705",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 12705"},
        {"Geneva Identification System", "GEN# -0.00000414"},
        {"Smithsonian Astrophysical Observation", "SAO 130073"},
    },
    visualMagnitude: 9.02,
    bvColour: 1.554,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(040.82145646),
        dec: Angle.Degrees(+00.08726051)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.26 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 98750",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 190118"},
        {"Hipparcos Number", "HIP 98750"},
        {"Geneva Identification System", "GEN# +1.00190118"},
        {"Smithsonian Astrophysical Observation", "SAO 144032"},
    },
    visualMagnitude: 8.03,
    bvColour: 0.523,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(300.86154190),
        dec: Angle.Degrees(+00.08900067)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 32.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -29.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 96402",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 12644 A"},
        {"Henry Draper", "HD 184768"},
        {"Hipparcos Number", "HIP 96402"},
        {"Cincinnati Publication", "Ci 18 2561"},
        {"Geneva Identification System", "GEN# +1.00184768"},
        {"Smithsonian Astrophysical Observation", "SAO 143582"},
        {"Wilson Evans Batten Catalogue", "WEB 16910"},
    },
    visualMagnitude: 7.55,
    bvColour: 0.675,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(294.00275529),
        dec: Angle.Degrees(+00.09212239)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.66 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -384.96 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 104872",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 202259"},
        {"Hipparcos Number", "HIP 104872"},
        {"Geneva Identification System", "GEN# +1.00202259"},
        {"Smithsonian Astrophysical Observation", "SAO 145229"},
    },
    visualMagnitude: 6.38,
    bvColour: 1.574,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(318.65428627),
        dec: Angle.Degrees(+00.09228716)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 36.40 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -12.61 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11613",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 11613"},
    },
    visualMagnitude: 9.95,
    bvColour: 0.400,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.44686390),
        dec: Angle.Degrees(+00.09317204)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.79 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -7.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 82807",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 152777"},
        {"Hipparcos Number", "HIP 82807"},
        {"Smithsonian Astrophysical Observation", "SAO 121942"},
    },
    visualMagnitude: 8.36,
    bvColour: 1.614,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(253.85363234),
        dec: Angle.Degrees(+00.09347211)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 0.64 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.01 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 100340",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 193581"},
        {"Hipparcos Number", "HIP 100340"},
        {"Geneva Identification System", "GEN# +1.00193581"},
        {"Smithsonian Astrophysical Observation", "SAO 144326"},
    },
    visualMagnitude: 8.69,
    bvColour: 0.370,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(305.23875371),
        dec: Angle.Degrees(+00.09403900)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 19.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.21 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 34040",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 53055"},
        {"Hipparcos Number", "HIP 34040"},
        {"Smithsonian Astrophysical Observation", "SAO 114848"},
    },
    visualMagnitude: 8.62,
    bvColour: 0.987,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(105.92430702),
        dec: Angle.Degrees(+00.09542047)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 69.57 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -61.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 108511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 208818"},
        {"Hipparcos Number", "HIP 108511"},
        {"Geneva Identification System", "GEN# +1.00208818"},
        {"Smithsonian Astrophysical Observation", "SAO 145786"},
    },
    visualMagnitude: 8.14,
    bvColour: 0.276,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(329.74015343),
        dec: Angle.Degrees(+00.09568644)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 21.88 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.14 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 101746",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 196426"},
        {"Hipparcos Number", "HIP 101746"},
        {"Geneva Identification System", "GEN# +1.00196426"},
        {"Renson", "Renson 54750"},
        {"Smithsonian Astrophysical Observation", "SAO 144632"},
        {"Wilson Evans Batten Catalogue", "WEB 18375"},
    },
    visualMagnitude: 6.21,
    bvColour: -0.076,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(309.32657723),
        dec: Angle.Degrees(+00.09700261)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 5.25 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -10.11 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 52662",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 93258"},
        {"Hipparcos Number", "HIP 52662"},
        {"Smithsonian Astrophysical Observation", "SAO 118484"},
    },
    visualMagnitude: 9.14,
    bvColour: 0.158,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(161.52728877),
        dec: Angle.Degrees(+00.09770122)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -28.37 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.78 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 25905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 36443"},
        {"Hipparcos Number", "HIP 25905"},
        {"Cincinnati Publication", "Ci 20 335"},
        {"Cincinnati Publication 2", "Ci 18 706"},
        {"Geneva Identification System", "GEN# +1.00036443"},
        {"Smithsonian Astrophysical Observation", "SAO 112876"},
        {"Wilson Evans Batten Catalogue", "WEB 5030"},
    },
    visualMagnitude: 8.36,
    bvColour: 0.697,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(082.93436723),
        dec: Angle.Degrees(+00.09986646)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 171.06 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -463.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 58678",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 104484"},
        {"Hipparcos Number", "HIP 58678"},
        {"Geneva Identification System", "GEN# +1.00104484"},
        {"Smithsonian Astrophysical Observation", "SAO 119174"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.338,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(180.48742450),
        dec: Angle.Degrees(+00.10214485)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -45.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -24.38 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 11636",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 15552"},
        {"Hipparcos Number", "HIP 11636"},
        {"Smithsonian Astrophysical Observation", "SAO 129941"},
    },
    visualMagnitude: 8.99,
    bvColour: 0.494,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(037.53269736),
        dec: Angle.Degrees(+00.10291653)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 7.34 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -15.64 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 85905",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 159187"},
        {"Hipparcos Number", "HIP 85905"},
        {"Smithsonian Astrophysical Observation", "SAO 122500"},
    },
    visualMagnitude: 7.87,
    bvColour: 1.648,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(263.32078319),
        dec: Angle.Degrees(+00.10329016)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -12.35 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.97 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 44123",
    secondaryIds: new Dictionary<string,string>{
        {"Hipparcos Number", "HIP 44123"},
        {"Geneva Identification System", "GEN# +0.00002437"},
    },
    visualMagnitude: 9.59,
    bvColour: 1.673,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(134.79129201),
        dec: Angle.Degrees(+00.10329571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -2.47 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 1.19 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 71817",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 129230"},
        {"Hipparcos Number", "HIP 71817"},
        {"Geneva Identification System", "GEN# +1.00129230"},
        {"Smithsonian Astrophysical Observation", "SAO 120600"},
        {"Wilson Evans Batten Catalogue", "WEB 12370"},
    },
    visualMagnitude: 8.12,
    bvColour: 1.030,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(220.36120585),
        dec: Angle.Degrees(+00.10355571)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 22.43 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -25.91 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88324",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164651"},
        {"Hipparcos Number", "HIP 88324"},
        {"Geneva Identification System", "GEN# +1.00164651"},
        {"Smithsonian Astrophysical Observation", "SAO 123047"},
    },
    visualMagnitude: 7.66,
    bvColour: 0.746,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.57407777),
        dec: Angle.Degrees(+00.10406426)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 178.17 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 52.80 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 48255",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 85179"},
        {"Hipparcos Number", "HIP 48255"},
        {"Geneva Identification System", "GEN# +1.00085179"},
        {"Smithsonian Astrophysical Observation", "SAO 117934"},
    },
    visualMagnitude: 7.40,
    bvColour: 0.483,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(147.55468196),
        dec: Angle.Degrees(+00.10439941)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.04 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 28.44 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 88268",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 164509"},
        {"Hipparcos Number", "HIP 88268"},
        {"Geneva Identification System", "GEN# +1.00164509"},
        {"Smithsonian Astrophysical Observation", "SAO 123026"},
    },
    visualMagnitude: 8.10,
    bvColour: 0.665,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(270.38013402),
        dec: Angle.Degrees(+00.10460585)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -5.78 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -20.39 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 6217",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 8031"},
        {"Hipparcos Number", "HIP 6217"},
        {"Smithsonian Astrophysical Observation", "SAO 129234"},
    },
    visualMagnitude: 8.97,
    bvColour: 0.754,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(019.92824181),
        dec: Angle.Degrees(+00.10571296)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 117.77 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 29.67 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 33379",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 51220"},
        {"Hipparcos Number", "HIP 33379"},
        {"Smithsonian Astrophysical Observation", "SAO 114660"},
        {"Wilson Evans Batten Catalogue", "WEB 6712"},
    },
    visualMagnitude: 7.47,
    bvColour: 1.034,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(104.13867876),
        dec: Angle.Degrees(+00.10626996)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -20.61 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 14.92 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 14875",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 19903"},
        {"Hipparcos Number", "HIP 14875"},
        {"Geneva Identification System", "GEN# +1.00019903"},
        {"Smithsonian Astrophysical Observation", "SAO 130338"},
    },
    visualMagnitude: 7.03,
    bvColour: 1.096,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(048.00886969),
        dec: Angle.Degrees(+00.10766267)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -13.23 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 5.05 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 117887",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 224062"},
        {"Hipparcos Number", "HIP 117887"},
        {"Fundamental Katalog 5th Edition", "FK5 3920"},
        {"Geneva Identification System", "GEN# +1.00224062"},
        {"Smithsonian Astrophysical Observation", "SAO 146973"},
        {"Wilson Evans Batten Catalogue", "WEB 20735"},
    },
    visualMagnitude: 5.78,
    bvColour: 1.466,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(358.69436350),
        dec: Angle.Degrees(+00.10934429)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -40.93 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -14.63 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 70717",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 126814"},
        {"Hipparcos Number", "HIP 70717"},
        {"Smithsonian Astrophysical Observation", "SAO 120472"},
    },
    visualMagnitude: 9.24,
    bvColour: 0.575,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(216.94268007),
        dec: Angle.Degrees(+00.10944185)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -34.73 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.72 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 37274",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 61422"},
        {"Hipparcos Number", "HIP 37274"},
        {"Smithsonian Astrophysical Observation", "SAO 115757"},
    },
    visualMagnitude: 8.00,
    bvColour: 0.095,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(114.81358390),
        dec: Angle.Degrees(+00.11037286)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -10.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -3.52 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 72766",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 131250"},
        {"Hipparcos Number", "HIP 72766"},
        {"Geneva Identification System", "GEN# +1.00131250"},
        {"Smithsonian Astrophysical Observation", "SAO 120705"},
    },
    visualMagnitude: 8.72,
    bvColour: 0.630,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(223.12749894),
        dec: Angle.Degrees(+00.11115036)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -36.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -294.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 8274",
    secondaryIds: new Dictionary<string,string>{
        {"Aitken", "ADS 1409 AB"},
        {"Henry Draper", "HD 10867"},
        {"Hipparcos Number", "HIP 8274"},
    },
    visualMagnitude: 9.34,
    bvColour: 0.513,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(026.65789046),
        dec: Angle.Degrees(+00.11216358)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 46.63 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -37.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 21049",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 28623"},
        {"Hipparcos Number", "HIP 21049"},
        {"Smithsonian Astrophysical Observation", "SAO 111858"},
    },
    visualMagnitude: 8.35,
    bvColour: 0.152,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(067.68750274),
        dec: Angle.Degrees(+00.11285297)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -14.44 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, 2.20 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 76062",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 138424"},
        {"Hipparcos Number", "HIP 76062"},
        {"Smithsonian Astrophysical Observation", "SAO 121046"},
    },
    visualMagnitude: 9.29,
    bvColour: 1.033,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(233.01564941),
        dec: Angle.Degrees(+00.11582037)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 1.22 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -18.30 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 65789",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 117266"},
        {"Hipparcos Number", "HIP 65789"},
        {"Geneva Identification System", "GEN# +1.00117266"},
        {"Smithsonian Astrophysical Observation", "SAO 119950"},
    },
    visualMagnitude: 7.79,
    bvColour: 0.553,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(202.30261730),
        dec: Angle.Degrees(+00.11919562)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -165.89 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -0.70 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 60748",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 108360"},
        {"Hipparcos Number", "HIP 60748"},
        {"Smithsonian Astrophysical Observation", "SAO 119401"},
    },
    visualMagnitude: 8.92,
    bvColour: 0.900,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(186.75225230),
        dec: Angle.Degrees(+00.11954237)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, -53.98 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -2.34 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 113672",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 217545"},
        {"Hipparcos Number", "HIP 113672"},
        {"Geneva Identification System", "GEN# +1.00217545"},
        {"Smithsonian Astrophysical Observation", "SAO 146449"},
    },
    visualMagnitude: 7.80,
    bvColour: 0.085,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(345.34605720),
        dec: Angle.Degrees(+00.12135943)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 18.14 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -5.99 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
_Hipparcos.Add(
new Star(
    primaryId: "HIP 511",
    secondaryIds: new Dictionary<string,string>{
        {"Henry Draper", "HD 127"},
        {"Hipparcos Number", "HIP 511"},
        {"Geneva Identification System", "GEN# +1.00000127"},
        {"Smithsonian Astrophysical Observation", "SAO 128581"},
    },
    visualMagnitude: 8.21,
    bvColour: 1.108,
    coordinates: new EquatorialCoordinate(
        ra:  Angle.Degrees(001.53351571),
        dec: Angle.Degrees(+00.12143808)
    ),
    motion: new ProperMotion(
        dra:  Angle.HoursMinutesSeconds(0, 0, 12.33 / 1000),
        ddec: Angle.DegreesMinutesSeconds(0, 0, -8.04 / 1000),
        duration:  Duration.Seconds(31557600)
    )
)
);
}
}

}
